using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using UnityEngine.LowLevel;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Foundation_PlayerLoop_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x99E1440", Offset = "0x99E0440", VA = "0x1899E1440", Slot = "4")]
		public override void OTSRDIPIITJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD1F100", Offset = "0xD1E100", VA = "0x180D1F100")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.Foundation.PlayerLoop
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public static class PlayerLoopSystems
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		public struct PostPhysicsFixedUpdate
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public struct PostUpdate
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public struct RigidbodyExLateUpdate
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public struct PostUpdateNetworkSend
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public struct PostUpdateNetworkReceive
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public struct PreRender
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public struct LatePreRender
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public struct PreXREarlyUpdate
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public struct PostXREarlyUpdate
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public struct PreWaitForGPUUpdate
		{
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct PostWaitForGPUUpdate
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public static class OM
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000010")]
			public struct PreGameplayUpdate
			{
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000011")]
			public struct PrePhysicsFixedUpdate
			{
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000012")]
			public struct PostPhysicsFixedUpdate
			{
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000013")]
			public struct PostGameplayUpdate
			{
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000014")]
			public struct PreNetworkReceive
			{
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000015")]
			public struct NetworkReceive
			{
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public struct PostNetworkReceive
			{
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000017")]
			public struct NetworkSend
			{
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000018")]
			public struct PreRender
			{
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000019")]
			public struct ScalabilityManager
			{
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public struct PostLateUpdate
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public static class DVKMVYUTSKU
		{
			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001C")]
			public struct Initialize
			{
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public struct FixedUpdate
			{
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public struct PreUpdate
			{
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x200001F")]
			public struct Update
			{
			}

			[StructLayout((LayoutKind)0, Size = 1)]
			[Cpp2IlInjected.Token(Token = "0x2000020")]
			public struct PreLateUpdate
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public delegate void UpdateSingleSystem(List<PlayerLoopSystem> list, int index, PlayerLoopSystem system);

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public delegate void UpdateMultipleSystems(List<PlayerLoopSystem> list, int index, PlayerLoopSystem[] systems);

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		internal struct Callback<T>
		{
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public static PlayerLoopSystem.UpdateFunction update;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x50A05D0", Offset = "0x509F5D0", VA = "0x1850A05D0")]
			public static void Invoke()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class QQDHDTGICDH<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public (PlayerLoopSystem system, UpdateSingleSystem action) XHHIISPLJAT;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xCF99C0", Offset = "0xCF89C0", VA = "0x180CF99C0")]
			public QQDHDTGICDH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x7791800", Offset = "0x7790800", VA = "0x187791800")]
			internal void CTNKRSTHVBA(List<PlayerLoopSystem> a, int b, PlayerLoopSystem c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool HPQACNPDYZT;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x99E2290", Offset = "0x99E1290", VA = "0x1899E2290")]
		public static void UPMZPHYXZZM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x99E2150", Offset = "0x99E1150", VA = "0x1899E2150")]
		public static void UEGDZZGHJJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3D94620", Offset = "0x3D93620", VA = "0x183D94620")]
		public static PlayerLoopSystem.UpdateFunction SHFJSKFNWRT<a>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3D94670", Offset = "0x3D93670", VA = "0x183D94670")]
		public static PlayerLoopSystem TUURATTTHFJ<b>()
		{
			return default(PlayerLoopSystem);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x99E1810", Offset = "0x99E0810", VA = "0x1899E1810")]
		public static void Insert(List<PlayerLoopSystem> list, int index, PlayerLoopSystem system)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x99E2070", Offset = "0x99E1070", VA = "0x1899E2070")]
		public static void TVEHZXHDFFL(List<PlayerLoopSystem> a, int b, PlayerLoopSystem c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x99E15C0", Offset = "0x99E05C0", VA = "0x1899E15C0")]
		public static void HHZNFHYPSSQ(List<PlayerLoopSystem> a, int b, PlayerLoopSystem c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x99E1F40", Offset = "0x99E0F40", VA = "0x1899E1F40")]
		public static void Remove(List<PlayerLoopSystem> list, int index, PlayerLoopSystem system)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x99E1760", Offset = "0x99E0760", VA = "0x1899E1760")]
		public static void Insert(List<PlayerLoopSystem> list, int index, PlayerLoopSystem[] systems)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x99E1E90", Offset = "0x99E0E90", VA = "0x1899E1E90")]
		public static void Remove(List<PlayerLoopSystem> list, int index, PlayerLoopSystem[] systems)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x99E18F0", Offset = "0x99E08F0", VA = "0x1899E18F0")]
		public static (PlayerLoopSystem[], UpdateMultipleSystems) Insert(params PlayerLoopSystem[] systems)
		{
			return default((PlayerLoopSystem[], UpdateMultipleSystems));
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x99E1DF0", Offset = "0x99E0DF0", VA = "0x1899E1DF0")]
		public static (PlayerLoopSystem[], UpdateMultipleSystems) Remove(params PlayerLoopSystem[] systems)
		{
			return default((PlayerLoopSystem[], UpdateMultipleSystems));
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3D94000", Offset = "0x3D93000", VA = "0x183D94000")]
		public static (PlayerLoopSystem, UpdateSingleSystem) Insert<T>()
		{
			return default((PlayerLoopSystem, UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x99E16A0", Offset = "0x99E06A0", VA = "0x1899E16A0")]
		public static (PlayerLoopSystem, UpdateSingleSystem) Insert(PlayerLoopSystem system)
		{
			return default((PlayerLoopSystem, UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3D943E0", Offset = "0x3D933E0", VA = "0x183D943E0")]
		public static (PlayerLoopSystem, UpdateSingleSystem) Remove<T>()
		{
			return default((PlayerLoopSystem, UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3D93990", Offset = "0x3D92990", VA = "0x183D93990")]
		public static (Type, Type, PlayerLoopSystem[], UpdateMultipleSystems) TVEHZXHDFFL<c>(this (PlayerLoopSystem[] systems, UpdateMultipleSystems action) insert)
		{
			return default((Type, Type, PlayerLoopSystem[], UpdateMultipleSystems));
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3D93990", Offset = "0x3D92990", VA = "0x183D93990")]
		public static (Type, Type, PlayerLoopSystem[], UpdateMultipleSystems) HHZNFHYPSSQ<d>(this (PlayerLoopSystem[] systems, UpdateMultipleSystems action) insert)
		{
			return default((Type, Type, PlayerLoopSystem[], UpdateMultipleSystems));
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3D94960", Offset = "0x3D93960", VA = "0x183D94960")]
		public static (Type, Type, PlayerLoopSystem[], UpdateMultipleSystems) WXIVKTDSHYM<e>(this (Type parentType, Type subType, PlayerLoopSystem[] systems, UpdateMultipleSystems callback) data)
		{
			return default((Type, Type, PlayerLoopSystem[], UpdateMultipleSystems));
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3D938D0", Offset = "0x3D928D0", VA = "0x183D938D0")]
		public static (Type, Type, PlayerLoopSystem[], UpdateMultipleSystems) From<TParent>(this (PlayerLoopSystem[] systems, UpdateMultipleSystems action) pair)
		{
			return default((Type, Type, PlayerLoopSystem[], UpdateMultipleSystems));
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3D94740", Offset = "0x3D93740", VA = "0x183D94740")]
		public static (Type, Type, PlayerLoopSystem, UpdateSingleSystem) TVEHZXHDFFL<f>(this (PlayerLoopSystem system, UpdateSingleSystem action) insert)
		{
			return default((Type, Type, PlayerLoopSystem, UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3D93A80", Offset = "0x3D92A80", VA = "0x183D93A80")]
		public static (Type, Type, PlayerLoopSystem, UpdateSingleSystem) HHZNFHYPSSQ<g>(this (PlayerLoopSystem system, UpdateSingleSystem action) insert)
		{
			return default((Type, Type, PlayerLoopSystem, UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3D94860", Offset = "0x3D93860", VA = "0x183D94860")]
		public static (Type, Type, PlayerLoopSystem, UpdateSingleSystem) WXIVKTDSHYM<h>(this (Type parentType, Type subType, PlayerLoopSystem system, UpdateSingleSystem callback) data)
		{
			return default((Type, Type, PlayerLoopSystem, UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3D937E0", Offset = "0x3D927E0", VA = "0x183D937E0")]
		public static (Type, Type, PlayerLoopSystem, UpdateSingleSystem) From<TParent>(this (PlayerLoopSystem system, UpdateSingleSystem action) pair)
		{
			return default((Type, Type, PlayerLoopSystem, UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3D936B0", Offset = "0x3D926B0", VA = "0x183D936B0")]
		public static PlayerLoopSystem AWWZSVRGBDX<i>(PlayerLoopSystem a)
		{
			return default(PlayerLoopSystem);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x99E14C0", Offset = "0x99E04C0", VA = "0x1899E14C0")]
		internal static PlayerLoopSystem AWWZSVRGBDX(PlayerLoopSystem a, Type b, Type c)
		{
			return default(PlayerLoopSystem);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x99E2AC0", Offset = "0x99E1AC0", VA = "0x1899E2AC0")]
		internal static void UQTDYPCUDEL(PlayerLoopSystem a, List<PlayerLoopSystem> b, Type c, Type d, PlayerLoopSystem[] e, UpdateMultipleSystems f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x99E2D20", Offset = "0x99E1D20", VA = "0x1899E2D20")]
		internal static void UQTDYPCUDEL(PlayerLoopSystem a, List<PlayerLoopSystem> b, Type c, Type d, PlayerLoopSystem e, UpdateSingleSystem f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x99E1990", Offset = "0x99E0990", VA = "0x1899E1990")]
		internal static (PlayerLoopSystem, int, int) MBBVJNHROBO(PlayerLoopSystem a, Type b, Type c)
		{
			return default((PlayerLoopSystem, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x99E1D00", Offset = "0x99E0D00", VA = "0x1899E1D00")]
		private static void NAVJMIDZRTK(List<PlayerLoopSystem> a, PlayerLoopSystem b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x99E1FA0", Offset = "0x99E0FA0", VA = "0x1899E1FA0")]
		private static void TMDWCEOOSET(List<PlayerLoopSystem> a, PlayerLoopSystem b, PlayerLoopSystem c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x99E1C60", Offset = "0x99E0C60", VA = "0x1899E1C60")]
		private static int MLIJHKJYXLE(this PlayerLoopSystem[] a, Type b)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public struct UpdatePlayerLoop : IEnumerable<PlayerLoopSystem>, IEnumerable, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private PlayerLoopSystem playerLoop;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private List<PlayerLoopSystem> scratch;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x99E3470", Offset = "0x99E2470", VA = "0x1899E3470")]
		public UpdatePlayerLoop(PlayerLoopSystem playerLoop)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x99E3310", Offset = "0x99E2310", VA = "0x1899E3310")]
		public void Add((Type parentType, Type subType, PlayerLoopSystem[] systems, PlayerLoopSystems.UpdateMultipleSystems callback) tuple)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x99E3200", Offset = "0x99E2200", VA = "0x1899E3200")]
		public void Add((Type parentType, Type subType, PlayerLoopSystem system, PlayerLoopSystems.UpdateSingleSystem callback) tuple)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x99E3040", Offset = "0x99E2040", VA = "0x1899E3040")]
		public void Add((Type parentType, Type subType, PlayerLoopSystem before, PlayerLoopSystem after) tuple)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x99E33D0", Offset = "0x99E23D0", VA = "0x1899E33D0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x99E3410", Offset = "0x99E2410", VA = "0x1899E3410", Slot = "4")]
		public IEnumerator<PlayerLoopSystem> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x99E3460", Offset = "0x99E2460", VA = "0x1899E3460", Slot = "5")]
		private IEnumerator YIRXJWVWWXR()
		{
			return null;
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
