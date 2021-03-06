﻿using System;
namespace SME.Components
{
    /// <summary>
    /// Implementation of a true dual-port memory resource
    /// </summary>
    [ClockedProcess]
    public class TrueDualPortMemory<T> : SimpleProcess
    {
        /// <summary>
        /// The controller bus for port A
        /// </summary>
        public interface IControlA : IBus
        {
            /// <summary>
            /// Sets a value indicating whether the address is used for writing or not
            /// </summary>
            /// <value><c>true</c> if is writing; otherwise, <c>false</c>.</value>
            [InitialValue]
            bool IsWriting { get; set; }
            /// <summary>
            /// Sets a value indicating whether this bus is enabled.
            /// </summary>
            /// <value><c>true</c> if enabled; otherwise, <c>false</c>.</value>
            [InitialValue]
            bool Enabled { get; set; }
            /// <summary>
            /// Sets the address used to read or write.
            /// </summary>
            /// <value>The address.</value>
            [InitialValue]
            int Address { get; set; }
            /// <summary>
            /// Sets the data to write.
            /// </summary>
            /// <value>The data.</value>
            T Data { get; set; }
        }

        /// <summary>
        /// The controller bus for port A
        /// </summary>
        public interface IControlB : IBus
        {
            /// <summary>
            /// Sets a value indicating whether the address is used for writing or not
            /// </summary>
            /// <value><c>true</c> if is writing; otherwise, <c>false</c>.</value>
            [InitialValue]
            bool IsWriting { get; set; }
            /// <summary>
            /// Sets a value indicating whether this bus is enabled.
            /// </summary>
            /// <value><c>true</c> if enabled; otherwise, <c>false</c>.</value>
            [InitialValue]
            bool Enabled { get; set; }
            /// <summary>
            /// Sets the address used to read or write.
            /// </summary>
            /// <value>The address.</value>
            [InitialValue]
            int Address { get; set; }
            /// <summary>
            /// Sets the data to write.
            /// </summary>
            /// <value>The data.</value>
            T Data { get; set; }
        }

        /// <summary>
        /// The read result from port A
        /// </summary>
        public interface IReadResultA : IBus
        {
            /// <summary>
            /// Gets the last data read from port A
            /// </summary>
            /// <value>The data.</value>
            T Data { get; set; }
        }

        /// <summary>
        /// The read result from port B
        /// </summary>
        public interface IReadResultB : IBus
        {
            /// <summary>
            /// Gets the last data read from port B
            /// </summary>
            /// <value>The data.</value>
            T Data { get; set; }
        }

        /// <summary>
        /// The control bus for port A
        /// </summary>
        [InputBus]
        public readonly IControlA ControlA = Scope.CreateBus<IControlA>();
        /// <summary>
        /// The control bus for port B
        /// </summary>
        [InputBus]
        public readonly IControlB ControlB = Scope.CreateBus<IControlB>();

        /// <summary>
        /// The result of reading from port A
        /// </summary>
        [OutputBus]
        public readonly IReadResultA ReadResultA = Scope.CreateBus<IReadResultA>();
        /// <summary>
        /// The result of reading from port B
        /// </summary>
        [OutputBus]
        public readonly IReadResultB ReadResultB = Scope.CreateBus<IReadResultB>();

        /// <summary>
        /// The stored memory
        /// </summary>
        [Signal]
        private readonly T[] m_memory;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:SME.Components.TrueDualPortMemory`1"/> class.
        /// </summary>
        /// <param name="size">The size of the allocated memory area.</param>
        /// <param name="initial">The initial memory contents (optional).</param>
        public TrueDualPortMemory(int size, T[] initial = null)
        {
            m_memory = new T[size];
            if (initial != null)
                Array.Copy(initial, 0, m_memory, 0, Math.Min(initial.Length, size));                        
        }

        /// <summary>
        /// Performs the operations when the signals are ready
        /// </summary>
        protected override void OnTick()
        {
            SimulationOnly(() =>
            {
                if (ControlA.Enabled && ControlB.Enabled && ControlA.Address == ControlB.Address)
                {
                    if (ControlA.IsWriting && ControlB.IsWriting)
                        throw new Exception("Both ports are writing the same memory address");

                    if (ControlA.IsWriting == !ControlB.IsWriting)
                        throw new Exception("Conflicting read and write to the same memory address");
                }
            });

            if (ControlA.Enabled)
            {
                ReadResultA.Data = m_memory[ControlA.Address];
                if (ControlA.IsWriting)
                    m_memory[ControlA.Address] = ControlA.Data;
            }

            if (ControlB.Enabled)
            {
                ReadResultB.Data = m_memory[ControlB.Address];
                if (ControlB.IsWriting)
                    m_memory[ControlB.Address] = ControlB.Data;
            }

        }
    }
}
