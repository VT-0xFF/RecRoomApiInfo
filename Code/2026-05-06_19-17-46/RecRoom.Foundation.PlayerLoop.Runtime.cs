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
		[Cpp2IlInjected.Address(RVA = "0x9890290", Offset = "0x988EC90", VA = "0x189890290", Slot = "4")]
		public override void GZVUEGYMGMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
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
		public static class TWGHINTULYE
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
			[Cpp2IlInjected.Address(RVA = "0x50464F0", Offset = "0x5044EF0", VA = "0x1850464F0")]
			public static void Invoke()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class OUFVCRFMVRH<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public (PlayerLoopSystem system, UpdateSingleSystem action) UZSDITEOTED;

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public OUFVCRFMVRH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x73ED8E0", Offset = "0x73EC2E0", VA = "0x1873ED8E0")]
			internal void AKVTETRLFBY(List<PlayerLoopSystem> a, int b, PlayerLoopSystem c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static bool HNAHYCKENEB;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private static readonly Log GLGEGNAUXIQ;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x98913B0", Offset = "0x988FDB0", VA = "0x1898913B0")]
		public static void UUPNZTCBDLY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9891BE0", Offset = "0x98905E0", VA = "0x189891BE0")]
		public static void WMLVYJHXGIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x3D782C0", Offset = "0x3D76CC0", VA = "0x183D782C0")]
		public static PlayerLoopSystem.UpdateFunction CLXTHBEUVYB<a>()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x3D78AB0", Offset = "0x3D774B0", VA = "0x183D78AB0")]
		public static PlayerLoopSystem OSGEQJQOXBR<b>()
		{
			return default(PlayerLoopSystem);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9890850", Offset = "0x988F250", VA = "0x189890850")]
		public static void Insert(List<PlayerLoopSystem> list, int index, PlayerLoopSystem system)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9890F60", Offset = "0x988F960", VA = "0x189890F60")]
		public static void ODIDMZGRZGZ(List<PlayerLoopSystem> a, int b, PlayerLoopSystem c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9891D20", Offset = "0x9890720", VA = "0x189891D20")]
		public static void XHOWABPSJHC(List<PlayerLoopSystem> a, int b, PlayerLoopSystem c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9891350", Offset = "0x988FD50", VA = "0x189891350")]
		public static void Remove(List<PlayerLoopSystem> list, int index, PlayerLoopSystem system)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x98907A0", Offset = "0x988F1A0", VA = "0x1898907A0")]
		public static void Insert(List<PlayerLoopSystem> list, int index, PlayerLoopSystem[] systems)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x98912A0", Offset = "0x988FCA0", VA = "0x1898912A0")]
		public static void Remove(List<PlayerLoopSystem> list, int index, PlayerLoopSystem[] systems)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9890930", Offset = "0x988F330", VA = "0x189890930")]
		public static (PlayerLoopSystem[], UpdateMultipleSystems) Insert(params PlayerLoopSystem[] systems)
		{
			return default((PlayerLoopSystem[], UpdateMultipleSystems));
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9891200", Offset = "0x988FC00", VA = "0x189891200")]
		public static (PlayerLoopSystem[], UpdateMultipleSystems) Remove(params PlayerLoopSystem[] systems)
		{
			return default((PlayerLoopSystem[], UpdateMultipleSystems));
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3D78660", Offset = "0x3D77060", VA = "0x183D78660")]
		public static (PlayerLoopSystem, UpdateSingleSystem) Insert<T>()
		{
			return default((PlayerLoopSystem, UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x98906E0", Offset = "0x988F0E0", VA = "0x1898906E0")]
		public static (PlayerLoopSystem, UpdateSingleSystem) Insert(PlayerLoopSystem system)
		{
			return default((PlayerLoopSystem, UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3D78D20", Offset = "0x3D77720", VA = "0x183D78D20")]
		public static (PlayerLoopSystem, UpdateSingleSystem) Remove<T>()
		{
			return default((PlayerLoopSystem, UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x3D789C0", Offset = "0x3D773C0", VA = "0x183D789C0")]
		public static (Type, Type, PlayerLoopSystem[], UpdateMultipleSystems) ODIDMZGRZGZ<c>(this (PlayerLoopSystem[] systems, UpdateMultipleSystems action) insert)
		{
			return default((Type, Type, PlayerLoopSystem[], UpdateMultipleSystems));
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3D789C0", Offset = "0x3D773C0", VA = "0x183D789C0")]
		public static (Type, Type, PlayerLoopSystem[], UpdateMultipleSystems) XHOWABPSJHC<d>(this (PlayerLoopSystem[] systems, UpdateMultipleSystems action) insert)
		{
			return default((Type, Type, PlayerLoopSystem[], UpdateMultipleSystems));
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3D79060", Offset = "0x3D77A60", VA = "0x183D79060")]
		public static (Type, Type, PlayerLoopSystem[], UpdateMultipleSystems) SFYSKVOBGAA<e>(this (Type parentType, Type subType, PlayerLoopSystem[] systems, UpdateMultipleSystems callback) data)
		{
			return default((Type, Type, PlayerLoopSystem[], UpdateMultipleSystems));
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3D78400", Offset = "0x3D76E00", VA = "0x183D78400")]
		public static (Type, Type, PlayerLoopSystem[], UpdateMultipleSystems) From<TParent>(this (PlayerLoopSystem[] systems, UpdateMultipleSystems action) pair)
		{
			return default((Type, Type, PlayerLoopSystem[], UpdateMultipleSystems));
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3D788A0", Offset = "0x3D772A0", VA = "0x183D788A0")]
		public static (Type, Type, PlayerLoopSystem, UpdateSingleSystem) ODIDMZGRZGZ<f>(this (PlayerLoopSystem system, UpdateSingleSystem action) insert)
		{
			return default((Type, Type, PlayerLoopSystem, UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3D79110", Offset = "0x3D77B10", VA = "0x183D79110")]
		public static (Type, Type, PlayerLoopSystem, UpdateSingleSystem) XHOWABPSJHC<g>(this (PlayerLoopSystem system, UpdateSingleSystem action) insert)
		{
			return default((Type, Type, PlayerLoopSystem, UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3D78F60", Offset = "0x3D77960", VA = "0x183D78F60")]
		public static (Type, Type, PlayerLoopSystem, UpdateSingleSystem) SFYSKVOBGAA<h>(this (Type parentType, Type subType, PlayerLoopSystem system, UpdateSingleSystem callback) data)
		{
			return default((Type, Type, PlayerLoopSystem, UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3D78310", Offset = "0x3D76D10", VA = "0x183D78310")]
		public static (Type, Type, PlayerLoopSystem, UpdateSingleSystem) From<TParent>(this (PlayerLoopSystem system, UpdateSingleSystem action) pair)
		{
			return default((Type, Type, PlayerLoopSystem, UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3D78190", Offset = "0x3D76B90", VA = "0x183D78190")]
		public static PlayerLoopSystem BDTPWDTIBJT<i>(PlayerLoopSystem a)
		{
			return default(PlayerLoopSystem);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9890310", Offset = "0x988ED10", VA = "0x189890310")]
		internal static PlayerLoopSystem BDTPWDTIBJT(PlayerLoopSystem a, Type b, Type c)
		{
			return default(PlayerLoopSystem);
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9890D00", Offset = "0x988F700", VA = "0x189890D00")]
		internal static void OCEMXMOZESL(PlayerLoopSystem a, List<PlayerLoopSystem> b, Type c, Type d, PlayerLoopSystem[] e, UpdateMultipleSystems f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x9890A70", Offset = "0x988F470", VA = "0x189890A70")]
		internal static void OCEMXMOZESL(PlayerLoopSystem a, List<PlayerLoopSystem> b, Type c, Type d, PlayerLoopSystem e, UpdateSingleSystem f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9890410", Offset = "0x988EE10", VA = "0x189890410")]
		internal static (PlayerLoopSystem, int, int) DLKTTQLVKDC(PlayerLoopSystem a, Type b, Type c)
		{
			return default((PlayerLoopSystem, int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9891110", Offset = "0x988FB10", VA = "0x189891110")]
		private static void PUUGIQQXVZW(List<PlayerLoopSystem> a, PlayerLoopSystem b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9891040", Offset = "0x988FA40", VA = "0x189891040")]
		private static void OSCMVAJLZIP(List<PlayerLoopSystem> a, PlayerLoopSystem b, PlayerLoopSystem c, int d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x98909D0", Offset = "0x988F3D0", VA = "0x1898909D0")]
		private static int KOEAQDOKXHE(this PlayerLoopSystem[] a, Type b)
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
		[Cpp2IlInjected.Address(RVA = "0x98922C0", Offset = "0x9890CC0", VA = "0x1898922C0")]
		public UpdatePlayerLoop(PlayerLoopSystem playerLoop)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9892160", Offset = "0x9890B60", VA = "0x189892160")]
		public void Add((Type parentType, Type subType, PlayerLoopSystem[] systems, PlayerLoopSystems.UpdateMultipleSystems callback) tuple)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9892050", Offset = "0x9890A50", VA = "0x189892050")]
		public void Add((Type parentType, Type subType, PlayerLoopSystem system, PlayerLoopSystems.UpdateSingleSystem callback) tuple)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9891E90", Offset = "0x9890890", VA = "0x189891E90")]
		public void Add((Type parentType, Type subType, PlayerLoopSystem before, PlayerLoopSystem after) tuple)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9892220", Offset = "0x9890C20", VA = "0x189892220", Slot = "6")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9892260", Offset = "0x9890C60", VA = "0x189892260", Slot = "4")]
		public IEnumerator<PlayerLoopSystem> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x98922B0", Offset = "0x9890CB0", VA = "0x1898922B0", Slot = "5")]
		private IEnumerator SJAOULXGYMP()
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
