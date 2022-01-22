﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PatcherYRpp
{
    [StructLayout(LayoutKind.Explicit, Size = 90296)]
    [Serializable]
    public struct HouseClass
    {
        private static IntPtr arrayPoint = new IntPtr(0xA80228);
        public static ref DynamicVectorClass<Pointer<HouseClass>> Array { get => ref DynamicVectorClass<Pointer<HouseClass>>.GetDynamicVector(arrayPoint); }

        private static IntPtr player = new IntPtr(0xA83D4C);
        public static Pointer<HouseClass> Player { get => player.Convert<Pointer<HouseClass>>().Data; set => player.Convert<Pointer<HouseClass>>().Ref = value; }

        private static IntPtr observer = new IntPtr(0xAC1198);
        public static Pointer<HouseClass> Observer { get => observer.Convert<Pointer<HouseClass>>().Data; set => observer.Convert<Pointer<HouseClass>>().Ref = value; }

        // HouseClass is too large that clr could not process. so we user Pointer instead.
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private Pointer<HouseClass> GetThis() => Pointer<HouseClass>.AsPointer(ref this);

        public unsafe Bool IsAlliedWith(int iHouse)
        {
            var func = (delegate* unmanaged[Thiscall]<IntPtr, int, Bool>)0x4F9A10;
            return func(GetThis(), iHouse);
        }

        public unsafe Bool IsAlliedWith(Pointer<HouseClass> pOther)
        {
            
            var func = (delegate* unmanaged[Thiscall]<IntPtr, IntPtr, Bool>)0x4F9A50;
            return func(GetThis(), pOther);
        }

        public unsafe Bool IsAlliedWith(Pointer<ObjectClass> pOther)
        {
            
            var func = (delegate* unmanaged[Thiscall]<IntPtr, IntPtr, Bool>)0x4F9A90;
            return func(GetThis(), pOther);
        }

        public unsafe bool IsAlliedWith(Pointer<AbstractClass> pAbstract)
        {
            var func = (delegate* unmanaged[Thiscall]<IntPtr, IntPtr, Bool>)0x4F9AF0;
            return func(GetThis(), pAbstract);
        }

        public unsafe void GiveMoney(int amount)
        {
            var func = (delegate* unmanaged[Thiscall]<IntPtr, int, void>)0x4F9950;
            func(GetThis(), amount);
        }

        public unsafe void TakeMoney(int amount)
        {
            var func = (delegate* unmanaged[Thiscall]<IntPtr, int, void>)0x4F9790;
            func(GetThis(), amount);
        }

        [FieldOffset(48)] public int ArrayIndex;

        [FieldOffset(52)] public Pointer<HouseTypeClass> Type;

        // [FieldOffset(80)] public DynamicVectorClass<Pointer<BuildingClass>> ConYards;
        [FieldOffset(80)] public byte conyards;
        public ref DynamicVectorClass<Pointer<BuildingClass>> ConYards => ref Pointer<byte>.AsPointer(ref conyards).Convert<DynamicVectorClass<Pointer<BuildingClass>>>().Ref;

        // [FieldOffset(104)] public DynamicVectorClass<Pointer<BuildingClass>> Buildings;
        [FieldOffset(104)] public byte buildings;
        public ref DynamicVectorClass<Pointer<BuildingClass>> Buildings => ref Pointer<byte>.AsPointer(ref buildings).Convert<DynamicVectorClass<Pointer<BuildingClass>>>().Ref;

        // [FieldOffset(128)] public DynamicVectorClass<Pointer<BuildingClass>> UnitRepairStations;
        [FieldOffset(128)] public byte unitRepairStations;
        public ref DynamicVectorClass<Pointer<BuildingClass>> UnitRepairStations => ref Pointer<byte>.AsPointer(ref unitRepairStations).Convert<DynamicVectorClass<Pointer<BuildingClass>>>().Ref;

        // [FieldOffset(152)] public DynamicVectorClass<Pointer<BuildingClass>> Grinders;
        [FieldOffset(152)] public byte grinders;
        public ref DynamicVectorClass<Pointer<BuildingClass>> Grinders => ref Pointer<byte>.AsPointer(ref grinders).Convert<DynamicVectorClass<Pointer<BuildingClass>>>().Ref;

        // [FieldOffset(176)] public DynamicVectorClass<Pointer<BuildingClass>> Absorbers;
        [FieldOffset(176)] public byte absorbers;
        public ref DynamicVectorClass<Pointer<BuildingClass>> Absorbers => ref Pointer<byte>.AsPointer(ref absorbers).Convert<DynamicVectorClass<Pointer<BuildingClass>>>().Ref;

        // [FieldOffset(200)] public DynamicVectorClass<Pointer<BuildingClass>> Bunkers;
        [FieldOffset(200)] public byte bunkers;
        public ref DynamicVectorClass<Pointer<BuildingClass>> Bunkers => ref Pointer<byte>.AsPointer(ref bunkers).Convert<DynamicVectorClass<Pointer<BuildingClass>>>().Ref;

        // [FieldOffset(224)] public DynamicVectorClass<Pointer<BuildingClass>> Occupiables;
        [FieldOffset(224)] public byte occupiables;
        public ref DynamicVectorClass<Pointer<BuildingClass>> Occupiables => ref Pointer<byte>.AsPointer(ref occupiables).Convert<DynamicVectorClass<Pointer<BuildingClass>>>().Ref;

        // [FieldOffset(248)] public DynamicVectorClass<Pointer<BuildingClass>> CloningVats;
        [FieldOffset(248)] public byte cloningVats;
        public ref DynamicVectorClass<Pointer<BuildingClass>> CloningVats => ref Pointer<byte>.AsPointer(ref cloningVats).Convert<DynamicVectorClass<Pointer<BuildingClass>>>().Ref;

        // [FieldOffset(272)] public DynamicVectorClass<Pointer<BuildingClass>> SecretLabs;
        [FieldOffset(272)] public byte secretLabs;
        public ref DynamicVectorClass<Pointer<BuildingClass>> SecretLabs => ref Pointer<byte>.AsPointer(ref secretLabs).Convert<DynamicVectorClass<Pointer<BuildingClass>>>().Ref;

        // [FieldOffset(296)] public DynamicVectorClass<Pointer<BuildingClass>> PsychicDetectionBuildings;
        [FieldOffset(296)] public byte psychicDetectionBuildings;
        public ref DynamicVectorClass<Pointer<BuildingClass>> PsychicDetectionBuildings => ref Pointer<byte>.AsPointer(ref psychicDetectionBuildings).Convert<DynamicVectorClass<Pointer<BuildingClass>>>().Ref;

        // [FieldOffset(320)] public DynamicVectorClass<Pointer<BuildingClass>> FactoryPlants;
        [FieldOffset(320)] public byte factoryPlants;
        public ref DynamicVectorClass<Pointer<BuildingClass>> FactoryPlants => ref Pointer<byte>.AsPointer(ref factoryPlants).Convert<DynamicVectorClass<Pointer<BuildingClass>>>().Ref;

        [FieldOffset(392)] public double FirepowerMultiplier;

        [FieldOffset(400)] public double GroundspeedMultiplier;

        [FieldOffset(408)] public double AirspeedMultiplier;

        [FieldOffset(416)] public double ArmorMultiplier;

        [FieldOffset(424)] public double ROFMultiplier;

        [FieldOffset(432)] public double CostMultiplier;

        [FieldOffset(440)] public double BuildTimeMultiplier;

        [FieldOffset(492)] public Bool CurrentPlayer;

        [FieldOffset(493)] public Bool PlayerControl;

        [FieldOffset(596)] public DynamicVectorClass<Pointer<SuperClass>> Supers;

        [FieldOffset(724)] public int AirportDocks;

        [FieldOffset(744)] public int OwnedUnits;

        [FieldOffset(748)] public int OwnedNavy;

        [FieldOffset(752)] public int OwnedBuildings;

        [FieldOffset(756)] public int OwnedInfantry;

        [FieldOffset(760)] public int OwnedAircraft;

        [FieldOffset(780)] public int Balance;

        [FieldOffset(21368)] public int NumAirpads;

        [FieldOffset(21372)] public int NumBarracks;

        [FieldOffset(21376)] public int NumWarFactories;

        [FieldOffset(21380)] public int NumConYards;

        [FieldOffset(21384)] public int NumShipyards;

        [FieldOffset(21388)] public int NumOrePurifiers;

        [FieldOffset(22265)] public ColorStruct Color;

        [FieldOffset(22268)] public ColorStruct LaserColor;

        [FieldOffset(90196)] public int ColorSchemeIndex;

        public Pointer<SuperClass> FindSuperWeapon(Pointer<SuperWeaponTypeClass> pType)
        {
            for (int i = 0; i < Supers.Count; i++)
            {
                var pItem = Supers[i];
                if (pItem.Ref.Type == pType)
                {
                    return pItem;
                }
            }

            return Pointer<SuperClass>.Zero;
        }

    }
}
