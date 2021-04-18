﻿using System;

namespace ARMeilleure.Memory
{
    public interface IMemoryManager
    {
        int AddressSpaceBits { get; }

        IntPtr PageTablePointer { get; }

        MemoryManagerType Type { get; }

        T Read<T>(ulong va) where T : unmanaged;
        T ReadTracked<T>(ulong va) where T : unmanaged;
        void Write<T>(ulong va, T value) where T : unmanaged;

        ReadOnlySpan<byte> GetSpan(ulong va, int size, bool tracked = false);

        ref T GetRef<T>(ulong va) where T : unmanaged;

        bool IsMapped(ulong va);

        void SignalMemoryTracking(ulong va, ulong size, bool write);
    }
}