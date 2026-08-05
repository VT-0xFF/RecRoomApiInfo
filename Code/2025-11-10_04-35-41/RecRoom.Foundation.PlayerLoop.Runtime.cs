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
		[Cpp2IlInjected.Address(RVA = "0x82AE200", Offset = "0x82AD600", VA = "0x1882AE200", Slot = "4")]
		public override void SHWXSEAJSCT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
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
		public static class MRKNZZFMKZG
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
			[Cpp2IlInjected.Address(RVA = "0x3F4EFA0", Offset = "0x3F4E3A0", VA = "0x183F4EFA0")]
			public static void Invoke()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class WCPZPVGXSMV<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public (PlayerLoopSystem system, UpdateSingleSystem action) HLVAYKDHUEP;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public WCPZPVGXSMV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x65A39F0", Offset = "0x65A2DF0", VA = "0x1865A39F0")]
			internal void YDBRIKUTKVE(List<PlayerLoopSystem> a, int b, PlayerLoopSystem c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool PNRLNZBVYRD;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x82AE3C0", Offset = "0x82AD7C0", VA = "0x1882AE3C0")]
		public static void BWUYWWNDERQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x82AE280", Offset = "0x82AD680", VA = "0x1882AE280")]
		public static void AVXEQRQQERY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3914AF0", Offset = "0x3913EF0", VA = "0x183914AF0")]
		public static PlayerLoopSystem.UpdateFunction XOGBWKQEWGZ<a>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3914490", Offset = "0x3913890", VA = "0x183914490")]
		public static PlayerLoopSystem LVYTMABRKGD<b>()
		{
			return default(PlayerLoopSystem);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x82AEF20", Offset = "0x82AE320", VA = "0x1882AEF20")]
		public static void Insert(List<PlayerLoopSystem> list, int index, PlayerLoopSystem system)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x82AECD0", Offset = "0x82AE0D0", VA = "0x1882AECD0")]
		public static void IGNUARYDRSJ(List<PlayerLoopSystem> a, int b, PlayerLoopSystem c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x82AFC80", Offset = "0x82AF080", VA = "0x1882AFC80")]
		public static void ZAXAWXTRSEM(List<PlayerLoopSystem> a, int b, PlayerLoopSystem c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x82AF730", Offset = "0x82AEB30", VA = "0x1882AF730")]
		public static void Remove(List<PlayerLoopSystem> list, int index, PlayerLoopSystem system)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x82AEE70", Offset = "0x82AE270", VA = "0x1882AEE70")]
		public static void Insert(List<PlayerLoopSystem> list, int index, PlayerLoopSystem[] systems)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x82AF680", Offset = "0x82AEA80", VA = "0x1882AF680")]
		public static void Remove(List<PlayerLoopSystem> list, int index, PlayerLoopSystem[] systems)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x82AF000", Offset = "0x82AE400", VA = "0x1882AF000")]
		public static (PlayerLoopSystem[], UpdateMultipleSystems) Insert(params PlayerLoopSystem[] systems)
		{
			return default((PlayerLoopSystem[], UpdateMultipleSystems));
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x82AF5E0", Offset = "0x82AE9E0", VA = "0x1882AF5E0")]
		public static (PlayerLoopSystem[], UpdateMultipleSystems) Remove(params PlayerLoopSystem[] systems)
		{
			return default((PlayerLoopSystem[], UpdateMultipleSystems));
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3914120", Offset = "0x3913520", VA = "0x183914120")]
		public static (PlayerLoopSystem, UpdateSingleSystem) Insert<T>()
		{
			return default((PlayerLoopSystem, UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x82AEDB0", Offset = "0x82AE1B0", VA = "0x1882AEDB0")]
		public static (PlayerLoopSystem, UpdateSingleSystem) Insert(PlayerLoopSystem system)
		{
			return default((PlayerLoopSystem, UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x39148B0", Offset = "0x3913CB0", VA = "0x1839148B0")]
		public static (PlayerLoopSystem, UpdateSingleSystem) Remove<T>()
		{
			return default((PlayerLoopSystem, UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3913E90", Offset = "0x3913290", VA = "0x183913E90")]
		public static (Type, Type, PlayerLoopSystem[], UpdateMultipleSystems) IGNUARYDRSJ<c>(this (PlayerLoopSystem[] systems, UpdateMultipleSystems action) insert)
		{
			return default((Type, Type, PlayerLoopSystem[], UpdateMultipleSystems));
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3913E90", Offset = "0x3913290", VA = "0x183913E90")]
		public static (Type, Type, PlayerLoopSystem[], UpdateMultipleSystems) ZAXAWXTRSEM<d>(this (PlayerLoopSystem[] systems, UpdateMultipleSystems action) insert)
		{
			return default((Type, Type, PlayerLoopSystem[], UpdateMultipleSystems));
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3914660", Offset = "0x3913A60", VA = "0x183914660")]
		public static (Type, Type, PlayerLoopSystem[], UpdateMultipleSystems) NNNXPMAZBGA<e>(this (Type parentType, Type subType, PlayerLoopSystem[] systems, UpdateMultipleSystems callback) data)
		{
			return default((Type, Type, PlayerLoopSystem[], UpdateMultipleSystems));
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3913CB0", Offset = "0x39130B0", VA = "0x183913CB0")]
		public static (Type, Type, PlayerLoopSystem[], UpdateMultipleSystems) From<TParent>(this (PlayerLoopSystem[] systems, UpdateMultipleSystems action) pair)
		{
			return default((Type, Type, PlayerLoopSystem[], UpdateMultipleSystems));
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3913D70", Offset = "0x3913170", VA = "0x183913D70")]
		public static (Type, Type, PlayerLoopSystem, UpdateSingleSystem) IGNUARYDRSJ<f>(this (PlayerLoopSystem system, UpdateSingleSystem action) insert)
		{
			return default((Type, Type, PlayerLoopSystem, UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3914B30", Offset = "0x3913F30", VA = "0x183914B30")]
		public static (Type, Type, PlayerLoopSystem, UpdateSingleSystem) ZAXAWXTRSEM<g>(this (PlayerLoopSystem system, UpdateSingleSystem action) insert)
		{
			return default((Type, Type, PlayerLoopSystem, UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3914560", Offset = "0x3913960", VA = "0x183914560")]
		public static (Type, Type, PlayerLoopSystem, UpdateSingleSystem) NNNXPMAZBGA<h>(this (Type parentType, Type subType, PlayerLoopSystem system, UpdateSingleSystem callback) data)
		{
			return default((Type, Type, PlayerLoopSystem, UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3913BC0", Offset = "0x3912FC0", VA = "0x183913BC0")]
		public static (Type, Type, PlayerLoopSystem, UpdateSingleSystem) From<TParent>(this (PlayerLoopSystem system, UpdateSingleSystem action) pair)
		{
			return default((Type, Type, PlayerLoopSystem, UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3914360", Offset = "0x3913760", VA = "0x183914360")]
		public static PlayerLoopSystem JEIGWBOVAEJ<i>(PlayerLoopSystem a)
		{
			return default(PlayerLoopSystem);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x82AF0A0", Offset = "0x82AE4A0", VA = "0x1882AF0A0")]
		internal static PlayerLoopSystem JEIGWBOVAEJ(PlayerLoopSystem a, Type b, Type c)
		{
			return default(PlayerLoopSystem);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x82AF790", Offset = "0x82AEB90", VA = "0x1882AF790")]
		internal static void XTBRCKJXQRN(PlayerLoopSystem a, List<PlayerLoopSystem> b, Type c, Type d, PlayerLoopSystem[] e, UpdateMultipleSystems f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x82AF9F0", Offset = "0x82AEDF0", VA = "0x1882AF9F0")]
		internal static void XTBRCKJXQRN(PlayerLoopSystem a, List<PlayerLoopSystem> b, Type c, Type d, PlayerLoopSystem e, UpdateSingleSystem f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x82AF240", Offset = "0x82AE640", VA = "0x1882AF240")]
		internal static (PlayerLoopSystem, int, int) MYSUCRHGMYI(PlayerLoopSystem a, Type b, Type c)
		{
			return default((PlayerLoopSystem, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x82AEBE0", Offset = "0x82ADFE0", VA = "0x1882AEBE0")]
		private static void IAWKCPNBBEA(List<PlayerLoopSystem> a, PlayerLoopSystem b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x82AF510", Offset = "0x82AE910", VA = "0x1882AF510")]
		private static void QEEYCCRUMQD(List<PlayerLoopSystem> a, PlayerLoopSystem b, PlayerLoopSystem c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x82AF1A0", Offset = "0x82AE5A0", VA = "0x1882AF1A0")]
		private static int KLGACHUARFY(this PlayerLoopSystem[] a, Type b)
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
		[Cpp2IlInjected.Address(RVA = "0x82B0210", Offset = "0x82AF610", VA = "0x1882B0210")]
		public UpdatePlayerLoop(PlayerLoopSystem playerLoop)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x82B00B0", Offset = "0x82AF4B0", VA = "0x1882B00B0")]
		public void Add((Type parentType, Type subType, PlayerLoopSystem[] systems, PlayerLoopSystems.UpdateMultipleSystems callback) tuple)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x82AFFA0", Offset = "0x82AF3A0", VA = "0x1882AFFA0")]
		public void Add((Type parentType, Type subType, PlayerLoopSystem system, PlayerLoopSystems.UpdateSingleSystem callback) tuple)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x82AFDE0", Offset = "0x82AF1E0", VA = "0x1882AFDE0")]
		public void Add((Type parentType, Type subType, PlayerLoopSystem before, PlayerLoopSystem after) tuple)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x82B0180", Offset = "0x82AF580", VA = "0x1882B0180", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x82B01C0", Offset = "0x82AF5C0", VA = "0x1882B01C0", Slot = "4")]
		public IEnumerator<PlayerLoopSystem> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x82B0170", Offset = "0x82AF570", VA = "0x1882B0170", Slot = "5")]
		private IEnumerator CQMSCGRISCD()
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
