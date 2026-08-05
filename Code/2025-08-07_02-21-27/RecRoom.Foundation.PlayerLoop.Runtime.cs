using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
		[Cpp2IlInjected.Address(RVA = "0x8A24810", Offset = "0x8A23410", VA = "0x188A24810", Slot = "4")]
		public override void Register()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
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
		public static class GZAMEJAWQGB
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

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x43C0F50", Offset = "0x43BFB50", VA = "0x1843C0F50")]
			public static void Invoke()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class RQUZLGDQDCQ<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public (PlayerLoopSystem system, UpdateSingleSystem action) TSXBRMQHFJC;

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public RQUZLGDQDCQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6290320", Offset = "0x628EF20", VA = "0x186290320")]
			internal void JICHMBYDSWL(List<PlayerLoopSystem> a, int b, PlayerLoopSystem c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool WBJIELRTBXC;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8A24890", Offset = "0x8A23490", VA = "0x188A24890")]
		public static void EOFKIXKYAEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8A25EF0", Offset = "0x8A24AF0", VA = "0x188A25EF0")]
		public static void QBBKDYLTLCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3EA6150", Offset = "0x3EA4D50", VA = "0x183EA6150")]
		public static PlayerLoopSystem.UpdateFunction AXBZWWDZFSA<a>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3EA6350", Offset = "0x3EA4F50", VA = "0x183EA6350")]
		public static PlayerLoopSystem DYEKLEKKEZC<b>()
		{
			return default(PlayerLoopSystem);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8A25740", Offset = "0x8A24340", VA = "0x188A25740")]
		public static void Insert(List<PlayerLoopSystem> list, int index, PlayerLoopSystem system)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8A258C0", Offset = "0x8A244C0", VA = "0x188A258C0")]
		public static void KEEIYTJVRRY(List<PlayerLoopSystem> a, int b, PlayerLoopSystem c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8A25B40", Offset = "0x8A24740", VA = "0x188A25B40")]
		public static void NOVZBJCCVDH(List<PlayerLoopSystem> a, int b, PlayerLoopSystem c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8A26180", Offset = "0x8A24D80", VA = "0x188A26180")]
		public static void Remove(List<PlayerLoopSystem> list, int index, PlayerLoopSystem system)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8A25690", Offset = "0x8A24290", VA = "0x188A25690")]
		public static void Insert(List<PlayerLoopSystem> list, int index, PlayerLoopSystem[] systems)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8A260D0", Offset = "0x8A24CD0", VA = "0x188A260D0")]
		public static void Remove(List<PlayerLoopSystem> list, int index, PlayerLoopSystem[] systems)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8A25820", Offset = "0x8A24420", VA = "0x188A25820")]
		public static (PlayerLoopSystem[], UpdateMultipleSystems) Insert(params PlayerLoopSystem[] systems)
		{
			return default((PlayerLoopSystem[], UpdateMultipleSystems));
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8A26030", Offset = "0x8A24C30", VA = "0x188A26030")]
		public static (PlayerLoopSystem[], UpdateMultipleSystems) Remove(params PlayerLoopSystem[] systems)
		{
			return default((PlayerLoopSystem[], UpdateMultipleSystems));
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3EA6770", Offset = "0x3EA5370", VA = "0x183EA6770")]
		public static (PlayerLoopSystem, UpdateSingleSystem) Insert<T>()
		{
			return default((PlayerLoopSystem, UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8A255D0", Offset = "0x8A241D0", VA = "0x188A255D0")]
		public static (PlayerLoopSystem, UpdateSingleSystem) Insert(PlayerLoopSystem system)
		{
			return default((PlayerLoopSystem, UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3EA7140", Offset = "0x3EA5D40", VA = "0x183EA7140")]
		public static (PlayerLoopSystem, UpdateSingleSystem) Remove<T>()
		{
			return default((PlayerLoopSystem, UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3EA6AD0", Offset = "0x3EA56D0", VA = "0x183EA6AD0")]
		public static (Type, Type, PlayerLoopSystem[], UpdateMultipleSystems) KEEIYTJVRRY<c>(this (PlayerLoopSystem[] systems, UpdateMultipleSystems action) insert)
		{
			return default((Type, Type, PlayerLoopSystem[], UpdateMultipleSystems));
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3EA6AD0", Offset = "0x3EA56D0", VA = "0x183EA6AD0")]
		public static (Type, Type, PlayerLoopSystem[], UpdateMultipleSystems) NOVZBJCCVDH<d>(this (PlayerLoopSystem[] systems, UpdateMultipleSystems action) insert)
		{
			return default((Type, Type, PlayerLoopSystem[], UpdateMultipleSystems));
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3EA62A0", Offset = "0x3EA4EA0", VA = "0x183EA62A0")]
		public static (Type, Type, PlayerLoopSystem[], UpdateMultipleSystems) AZXGXDDCXHL<e>(this (Type parentType, Type subType, PlayerLoopSystem[] systems, UpdateMultipleSystems callback) data)
		{
			return default((Type, Type, PlayerLoopSystem[], UpdateMultipleSystems));
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3EA6510", Offset = "0x3EA5110", VA = "0x183EA6510")]
		public static (Type, Type, PlayerLoopSystem[], UpdateMultipleSystems) From<TParent>(this (PlayerLoopSystem[] systems, UpdateMultipleSystems action) pair)
		{
			return default((Type, Type, PlayerLoopSystem[], UpdateMultipleSystems));
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3EA69B0", Offset = "0x3EA55B0", VA = "0x183EA69B0")]
		public static (Type, Type, PlayerLoopSystem, UpdateSingleSystem) KEEIYTJVRRY<f>(this (PlayerLoopSystem system, UpdateSingleSystem action) insert)
		{
			return default((Type, Type, PlayerLoopSystem, UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3EA6BC0", Offset = "0x3EA57C0", VA = "0x183EA6BC0")]
		public static (Type, Type, PlayerLoopSystem, UpdateSingleSystem) NOVZBJCCVDH<g>(this (PlayerLoopSystem system, UpdateSingleSystem action) insert)
		{
			return default((Type, Type, PlayerLoopSystem, UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3EA61A0", Offset = "0x3EA4DA0", VA = "0x183EA61A0")]
		public static (Type, Type, PlayerLoopSystem, UpdateSingleSystem) AZXGXDDCXHL<h>(this (Type parentType, Type subType, PlayerLoopSystem system, UpdateSingleSystem callback) data)
		{
			return default((Type, Type, PlayerLoopSystem, UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3EA6420", Offset = "0x3EA5020", VA = "0x183EA6420")]
		public static (Type, Type, PlayerLoopSystem, UpdateSingleSystem) From<TParent>(this (PlayerLoopSystem system, UpdateSingleSystem action) pair)
		{
			return default((Type, Type, PlayerLoopSystem, UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3EA7380", Offset = "0x3EA5F80", VA = "0x183EA7380")]
		public static PlayerLoopSystem YRCWMCGNNJM<i>(PlayerLoopSystem a)
		{
			return default(PlayerLoopSystem);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8A262B0", Offset = "0x8A24EB0", VA = "0x188A262B0")]
		internal static PlayerLoopSystem YRCWMCGNNJM(PlayerLoopSystem a, Type b, Type c)
		{
			return default(PlayerLoopSystem);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8A250C0", Offset = "0x8A23CC0", VA = "0x188A250C0")]
		internal static void IPQEHSHLUVI(PlayerLoopSystem a, List<PlayerLoopSystem> b, Type c, Type d, PlayerLoopSystem[] e, UpdateMultipleSystems f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8A25330", Offset = "0x8A23F30", VA = "0x188A25330")]
		internal static void IPQEHSHLUVI(PlayerLoopSystem a, List<PlayerLoopSystem> b, Type c, Type d, PlayerLoopSystem e, UpdateSingleSystem f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8A25C20", Offset = "0x8A24820", VA = "0x188A25C20")]
		internal static (PlayerLoopSystem, int, int) NQQUQXTHYJH(PlayerLoopSystem a, Type b, Type c)
		{
			return default((PlayerLoopSystem, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8A263B0", Offset = "0x8A24FB0", VA = "0x188A263B0")]
		private static void ZRBUYFKXAAZ(List<PlayerLoopSystem> a, PlayerLoopSystem b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8A261E0", Offset = "0x8A24DE0", VA = "0x188A261E0")]
		private static void SOFPGDXWMVM(List<PlayerLoopSystem> a, PlayerLoopSystem b, PlayerLoopSystem c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8A259A0", Offset = "0x8A245A0", VA = "0x188A259A0")]
		private static int LIOHQIBKOUN(this PlayerLoopSystem[] a, Type b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8A25A40", Offset = "0x8A24640", VA = "0x188A25A40")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		internal static void MNWGDWIQQCP(Type a, Type b)
		{
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

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8A26960", Offset = "0x8A25560", VA = "0x188A26960")]
		public UpdatePlayerLoop(PlayerLoopSystem playerLoop)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8A26800", Offset = "0x8A25400", VA = "0x188A26800")]
		public void Add((Type parentType, Type subType, PlayerLoopSystem[] systems, PlayerLoopSystems.UpdateMultipleSystems callback) tuple)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8A266F0", Offset = "0x8A252F0", VA = "0x188A266F0")]
		public void Add((Type parentType, Type subType, PlayerLoopSystem system, PlayerLoopSystems.UpdateSingleSystem callback) tuple)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8A26530", Offset = "0x8A25130", VA = "0x188A26530")]
		public void Add((Type parentType, Type subType, PlayerLoopSystem before, PlayerLoopSystem after) tuple)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8A268C0", Offset = "0x8A254C0", VA = "0x188A268C0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8A26900", Offset = "0x8A25500", VA = "0x188A26900", Slot = "4")]
		public IEnumerator<PlayerLoopSystem> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x8A26950", Offset = "0x8A25550", VA = "0x188A26950", Slot = "5")]
		private IEnumerator ZFHLTDQPCLO()
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
