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
		[Cpp2IlInjected.Address(RVA = "0x852EF80", Offset = "0x852D580", VA = "0x18852EF80", Slot = "4")]
		public override void KQPXXDZDTRT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
		public static class MNBRHLVBYRY
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
			[Cpp2IlInjected.Address(RVA = "0x4121030", Offset = "0x411F630", VA = "0x184121030")]
			public static void Invoke()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class VXFUTGGXEJV<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public (PlayerLoopSystem system, UpdateSingleSystem action) HVAMCMABVEJ;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public VXFUTGGXEJV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6525270", Offset = "0x6523870", VA = "0x186525270")]
			internal void XCRLGQAJVKM(List<PlayerLoopSystem> a, int b, PlayerLoopSystem c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool VUSNMKKUDMP;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x85302C0", Offset = "0x852E8C0", VA = "0x1885302C0")]
		public static void ZBQBDKAXXEU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x852F8A0", Offset = "0x852DEA0", VA = "0x18852F8A0")]
		public static void HYPSARXSOGY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3BC4340", Offset = "0x3BC2940", VA = "0x183BC4340")]
		public static PlayerLoopSystem.UpdateFunction DFNLXIENOMH<a>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3BC4530", Offset = "0x3BC2B30", VA = "0x183BC4530")]
		public static PlayerLoopSystem ISKYHZDXYXL<b>()
		{
			return default(PlayerLoopSystem);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x852FC30", Offset = "0x852E230", VA = "0x18852FC30")]
		public static void Insert(List<PlayerLoopSystem> list, int index, PlayerLoopSystem system)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x852F9E0", Offset = "0x852DFE0", VA = "0x18852F9E0")]
		public static void IYEGMGUSHXR(List<PlayerLoopSystem> a, int b, PlayerLoopSystem c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x852F000", Offset = "0x852D600", VA = "0x18852F000")]
		public static void CXGPHDQHWGG(List<PlayerLoopSystem> a, int b, PlayerLoopSystem c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x85300A0", Offset = "0x852E6A0", VA = "0x1885300A0")]
		public static void Remove(List<PlayerLoopSystem> list, int index, PlayerLoopSystem system)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x852FB80", Offset = "0x852E180", VA = "0x18852FB80")]
		public static void Insert(List<PlayerLoopSystem> list, int index, PlayerLoopSystem[] systems)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x852FFF0", Offset = "0x852E5F0", VA = "0x18852FFF0")]
		public static void Remove(List<PlayerLoopSystem> list, int index, PlayerLoopSystem[] systems)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x852FD10", Offset = "0x852E310", VA = "0x18852FD10")]
		public static (PlayerLoopSystem[], UpdateMultipleSystems) Insert(params PlayerLoopSystem[] systems)
		{
			return default((PlayerLoopSystem[], UpdateMultipleSystems));
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x852FF50", Offset = "0x852E550", VA = "0x18852FF50")]
		public static (PlayerLoopSystem[], UpdateMultipleSystems) Remove(params PlayerLoopSystem[] systems)
		{
			return default((PlayerLoopSystem[], UpdateMultipleSystems));
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3BC48C0", Offset = "0x3BC2EC0", VA = "0x183BC48C0")]
		public static (PlayerLoopSystem, UpdateSingleSystem) Insert<T>()
		{
			return default((PlayerLoopSystem, UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x852FAC0", Offset = "0x852E0C0", VA = "0x18852FAC0")]
		public static (PlayerLoopSystem, UpdateSingleSystem) Insert(PlayerLoopSystem system)
		{
			return default((PlayerLoopSystem, UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3BC4F80", Offset = "0x3BC3580", VA = "0x183BC4F80")]
		public static (PlayerLoopSystem, UpdateSingleSystem) Remove<T>()
		{
			return default((PlayerLoopSystem, UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3BC3E70", Offset = "0x3BC2470", VA = "0x183BC3E70")]
		public static (Type, Type, PlayerLoopSystem[], UpdateMultipleSystems) IYEGMGUSHXR<c>(this (PlayerLoopSystem[] systems, UpdateMultipleSystems action) insert)
		{
			return default((Type, Type, PlayerLoopSystem[], UpdateMultipleSystems));
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3BC3E70", Offset = "0x3BC2470", VA = "0x183BC3E70")]
		public static (Type, Type, PlayerLoopSystem[], UpdateMultipleSystems) CXGPHDQHWGG<d>(this (PlayerLoopSystem[] systems, UpdateMultipleSystems action) insert)
		{
			return default((Type, Type, PlayerLoopSystem[], UpdateMultipleSystems));
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3BC4D30", Offset = "0x3BC3330", VA = "0x183BC4D30")]
		public static (Type, Type, PlayerLoopSystem[], UpdateMultipleSystems) PWXXYNRFJZI<e>(this (Type parentType, Type subType, PlayerLoopSystem[] systems, UpdateMultipleSystems callback) data)
		{
			return default((Type, Type, PlayerLoopSystem[], UpdateMultipleSystems));
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3BC4470", Offset = "0x3BC2A70", VA = "0x183BC4470")]
		public static (Type, Type, PlayerLoopSystem[], UpdateMultipleSystems) From<TParent>(this (PlayerLoopSystem[] systems, UpdateMultipleSystems action) pair)
		{
			return default((Type, Type, PlayerLoopSystem[], UpdateMultipleSystems));
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3BC4600", Offset = "0x3BC2C00", VA = "0x183BC4600")]
		public static (Type, Type, PlayerLoopSystem, UpdateSingleSystem) IYEGMGUSHXR<f>(this (PlayerLoopSystem system, UpdateSingleSystem action) insert)
		{
			return default((Type, Type, PlayerLoopSystem, UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3BC3F60", Offset = "0x3BC2560", VA = "0x183BC3F60")]
		public static (Type, Type, PlayerLoopSystem, UpdateSingleSystem) CXGPHDQHWGG<g>(this (PlayerLoopSystem system, UpdateSingleSystem action) insert)
		{
			return default((Type, Type, PlayerLoopSystem, UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3BC4C30", Offset = "0x3BC3230", VA = "0x183BC4C30")]
		public static (Type, Type, PlayerLoopSystem, UpdateSingleSystem) PWXXYNRFJZI<h>(this (Type parentType, Type subType, PlayerLoopSystem system, UpdateSingleSystem callback) data)
		{
			return default((Type, Type, PlayerLoopSystem, UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3BC4380", Offset = "0x3BC2980", VA = "0x183BC4380")]
		public static (Type, Type, PlayerLoopSystem, UpdateSingleSystem) From<TParent>(this (PlayerLoopSystem system, UpdateSingleSystem action) pair)
		{
			return default((Type, Type, PlayerLoopSystem, UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3BC4B00", Offset = "0x3BC3100", VA = "0x183BC4B00")]
		public static PlayerLoopSystem OADZSIRQJJZ<i>(PlayerLoopSystem a)
		{
			return default(PlayerLoopSystem);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x852FE50", Offset = "0x852E450", VA = "0x18852FE50")]
		internal static PlayerLoopSystem OADZSIRQJJZ(PlayerLoopSystem a, Type b, Type c)
		{
			return default(PlayerLoopSystem);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x852F0E0", Offset = "0x852D6E0", VA = "0x18852F0E0")]
		internal static void CXLGCXLIAZP(PlayerLoopSystem a, List<PlayerLoopSystem> b, Type c, Type d, PlayerLoopSystem[] e, UpdateMultipleSystems f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x852F340", Offset = "0x852D940", VA = "0x18852F340")]
		internal static void CXLGCXLIAZP(PlayerLoopSystem a, List<PlayerLoopSystem> b, Type c, Type d, PlayerLoopSystem e, UpdateSingleSystem f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x852F5D0", Offset = "0x852DBD0", VA = "0x18852F5D0")]
		internal static (PlayerLoopSystem, int, int) DHCTIOGUSPY(PlayerLoopSystem a, Type b, Type c)
		{
			return default((PlayerLoopSystem, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x85301D0", Offset = "0x852E7D0", VA = "0x1885301D0")]
		private static void YKWWPMMZZNM(List<PlayerLoopSystem> a, PlayerLoopSystem b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8530100", Offset = "0x852E700", VA = "0x188530100")]
		private static void XLVABFQKHPL(List<PlayerLoopSystem> a, PlayerLoopSystem b, PlayerLoopSystem c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x852FDB0", Offset = "0x852E3B0", VA = "0x18852FDB0")]
		private static int MXWWWVJKWII(this PlayerLoopSystem[] a, Type b)
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
		[Cpp2IlInjected.Address(RVA = "0x8530F90", Offset = "0x852F590", VA = "0x188530F90")]
		public UpdatePlayerLoop(PlayerLoopSystem playerLoop)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8530E30", Offset = "0x852F430", VA = "0x188530E30")]
		public void Add((Type parentType, Type subType, PlayerLoopSystem[] systems, PlayerLoopSystems.UpdateMultipleSystems callback) tuple)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8530D20", Offset = "0x852F320", VA = "0x188530D20")]
		public void Add((Type parentType, Type subType, PlayerLoopSystem system, PlayerLoopSystems.UpdateSingleSystem callback) tuple)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8530B60", Offset = "0x852F160", VA = "0x188530B60")]
		public void Add((Type parentType, Type subType, PlayerLoopSystem before, PlayerLoopSystem after) tuple)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8530EF0", Offset = "0x852F4F0", VA = "0x188530EF0", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8530F30", Offset = "0x852F530", VA = "0x188530F30", Slot = "4")]
		public IEnumerator<PlayerLoopSystem> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8530F80", Offset = "0x852F580", VA = "0x188530F80", Slot = "5")]
		private IEnumerator MZPFIUHPQEF()
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
