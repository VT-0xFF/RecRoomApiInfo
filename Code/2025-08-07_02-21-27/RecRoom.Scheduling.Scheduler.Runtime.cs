using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Analytics;
using RecRoom.ApplicationLifecycle;
using RecRoom.Async;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation.PlayerLoop;
using RecRoom.Initialization;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Common;
using UJect;
using UJect.Injection;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.LowLevel;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xB3EE00", Offset = "0xB3DA00", VA = "0x180B3EE00")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xB3EE40", Offset = "0xB3DA40", VA = "0x180B3EE40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_Scheduling_Scheduler_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9531840", Offset = "0x9530440", VA = "0x189531840", Slot = "4")]
		public override void Register()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xB3E190", Offset = "0xB3CD90", VA = "0x180B3E190")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_Scheduling_Scheduler_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9538320", Offset = "0x9536F20", VA = "0x189538320", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2C401F0", Offset = "0x2C3EDF0", VA = "0x182C401F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class CustomPlayerLoopInjector
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct WrapperPreSystem
		{
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			[CompilerGenerated]
			private sealed class GWGISWCHLZW
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000007")]
				public XSSHGXDEBNU.WrapperKey NFHQLEPGVHS;

				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public GWGISWCHLZW()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0x952F180", Offset = "0x952DD80", VA = "0x18952F180")]
				internal void YADEGECMLTA()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public static IDisposable frameScope;

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x9536100", Offset = "0x9534D00", VA = "0x189536100")]
			public static PlayerLoopSystem YRUMSOISJAS(XSSHGXDEBNU.WrapperKey a)
			{
				return default(PlayerLoopSystem);
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private struct WrapperPostSystem
		{
			[Cpp2IlInjected.Token(Token = "0x200000D")]
			[CompilerGenerated]
			private sealed class UVCWZJPGRUD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400000A")]
				public XSSHGXDEBNU.WrapperKey NFHQLEPGVHS;

				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public UVCWZJPGRUD()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600001F")]
				[Cpp2IlInjected.Address(RVA = "0x9533B70", Offset = "0x9532770", VA = "0x189533B70")]
				internal void YADEGECMLTA()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x9535FE0", Offset = "0x9534BE0", VA = "0x189535FE0")]
			public static PlayerLoopSystem YRUMSOISJAS(XSSHGXDEBNU.WrapperKey a)
			{
				return default(PlayerLoopSystem);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9529890", Offset = "0x9528490", VA = "0x189529890")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9529F10", Offset = "0x9528B10", VA = "0x189529F10")]
		private static void FPTWWZCEIAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x952AFB0", Offset = "0x9529BB0", VA = "0x18952AFB0")]
		private static void QBBKDYLTLCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9529AB0", Offset = "0x95286B0", VA = "0x189529AB0")]
		private static void EOJZKTRSAQT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x952A430", Offset = "0x9529030", VA = "0x18952A430")]
		private static void MSHKSJPTMJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9529FA0", Offset = "0x9528BA0", VA = "0x189529FA0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private static void ITYNXAFIGBB(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3A86340", Offset = "0x3A84F40", VA = "0x183A86340")]
		private static (PlayerLoopSystem, PlayerLoopSystems.UpdateSingleSystem) Insert<T>()
		{
			return default((PlayerLoopSystem, PlayerLoopSystems.UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x952A390", Offset = "0x9528F90", VA = "0x18952A390")]
		private static (PlayerLoopSystem, PlayerLoopSystems.UpdateSingleSystem) Insert(PlayerLoopSystem system)
		{
			return default((PlayerLoopSystem, PlayerLoopSystems.UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3A86340", Offset = "0x3A84F40", VA = "0x183A86340")]
		private static (PlayerLoopSystem, PlayerLoopSystems.UpdateSingleSystem) Remove<T>()
		{
			return default((PlayerLoopSystem, PlayerLoopSystems.UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3A861C0", Offset = "0x3A84DC0", VA = "0x183A861C0")]
		public static (Type, Type, PlayerLoopSystem, PlayerLoopSystem) DJUFLPCSUIF<a, b>(XSSHGXDEBNU.WrapperKey a)
		{
			return default((Type, Type, PlayerLoopSystem, PlayerLoopSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9529950", Offset = "0x9528550", VA = "0x189529950")]
		public static (Type, Type, PlayerLoopSystem, PlayerLoopSystem) DJUFLPCSUIF(XSSHGXDEBNU.WrapperKey a, Type b, Type c)
		{
			return default((Type, Type, PlayerLoopSystem, PlayerLoopSystem));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public static class XSSHGXDEBNU
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public enum WrapperKey
		{
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			Update,
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			SchedulerUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			PostUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			FixedUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			NetworkReceive,
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			NetworkSend,
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			RigidbodyExLateUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			LateUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			PreRenderUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			LatePreRenderUpdate,
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			PhysicsFixedUpdate,
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			PhysicsUpdate,
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			SendFrameStarted,
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			FinishFrameRendering,
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			PhysicsResetInterpolatedPosition,
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			FullPlayerLoop,
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			OMPreGameplayUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			OMPrePhysicsFixedUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			OMPostPhysicsFixedUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			OMPostGameplayUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			OMPreNetworkReceive,
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			OMNetworkReceive,
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			OMPostNetworkReceive,
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			OMNetworkSend,
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			OMPreRenderSystem,
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			OMPostLateUpdate
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public class KIRCYQRMPYE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public readonly WrapperKey VWNPGBONXPJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public readonly ZTZMKJHNMAO QUWQWRRRVUH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private long OLACCYIAMGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private long DRZGQDMXTWE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public long EDDPVEDHDBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public int UQSZERJQDES;

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x9531790", Offset = "0x9530390", VA = "0x189531790")]
			public KIRCYQRMPYE(WrapperKey a, int b = 90)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9531770", Offset = "0x9530370", VA = "0x189531770")]
			public void XDDIRFFJVFT()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9531720", Offset = "0x9530320", VA = "0x189531720")]
			public void OAOHMDZLDZO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x9531640", Offset = "0x9530240", VA = "0x189531640")]
			public void KUXPMHWQRWV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x95315B0", Offset = "0x95301B0", VA = "0x1895315B0")]
			public double GPUVXBOZCQP(int a)
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public static WrapperKey[] SZGPHDTCTPO;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static KIRCYQRMPYE[] SMFLNEQMNRE;

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9536290", Offset = "0x9534E90", VA = "0x189536290")]
		public static KIRCYQRMPYE ICPWNGAVSSY(WrapperKey a, int b = 90)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9536220", Offset = "0x9534E20", VA = "0x189536220")]
		public static KIRCYQRMPYE CNBQJKQMPBI(WrapperKey a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x95363D0", Offset = "0x9534FD0", VA = "0x1895363D0")]
		public static void RDEFDSHXCHN()
		{
		}
	}
}
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public static class WIESWDIPQTH
	{
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private interface SCGBJNENTJV
		{
			[Cpp2IlInjected.Token(Token = "0x17000002")]
			bool TKNACZBONHK
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void Complete();
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private abstract class ICLHADTTZKL<a, b> : SCGBJNENTJV where a : ZPYKPRNSTIB where b : a
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private readonly a ZQDWBFFEXJU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			protected readonly b UYTIHNXZJHE;

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public a PTBAUZRNKYR
			{
				[Cpp2IlInjected.Token(Token = "0x6000037")]
				[Cpp2IlInjected.Address(RVA = "0x554D050", Offset = "0x554BC50", VA = "0x18554D050")]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public bool TKNACZBONHK
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x554D0B0", Offset = "0x554BCB0", VA = "0x18554D0B0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xB1A040", Offset = "0xB18C40", VA = "0x180B1A040")]
			protected ICLHADTTZKL(a a, b b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x554CF00", Offset = "0x554BB00", VA = "0x18554CF00", Slot = "5")]
			public void Complete()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(Slot = "6")]
			protected abstract void TAOZRYELKLB(a a);
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		private class GVSIPSQFLXV<a> : ICLHADTTZKL<EWYSBGHBSNQ<a>, JEHCUHDTWGJ<a>>
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x541C010", Offset = "0x541AC10", VA = "0x18541C010")]
			public GVSIPSQFLXV(EWYSBGHBSNQ<a> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x541BC70", Offset = "0x541A870", VA = "0x18541BC70", Slot = "6")]
			protected override void TAOZRYELKLB(EWYSBGHBSNQ<a> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x541BB60", Offset = "0x541A760", VA = "0x18541BB60")]
			[CompilerGenerated]
			private void FWRTPDTQVTP(a a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x541BB00", Offset = "0x541A700", VA = "0x18541BB00")]
			[CompilerGenerated]
			private void FWMMRWZTMIG(string a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		private class WPUVXUASKXX : SCGBJNENTJV
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private readonly Action PZRSECPTZTV;

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			public bool TKNACZBONHK
			{
				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
			public WPUVXUASKXX(Action a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x13E7AB0", Offset = "0x13E66B0", VA = "0x1813E7AB0", Slot = "5")]
			public void Complete()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly List<SCGBJNENTJV> FLEQWZQFWIO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool QFTJBHNQKWB
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x41A39F0", Offset = "0x41A25F0", VA = "0x1841A39F0")]
		public static EWYSBGHBSNQ<a> PVMFYAIFEUO<a>(this EWYSBGHBSNQ<a> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9535610", Offset = "0x9534210", VA = "0x189535610")]
		public static void PVMFYAIFEUO(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x41A38C0", Offset = "0x41A24C0", VA = "0x1841A38C0")]
		private static EWYSBGHBSNQ<b> EMTWGYUEKYB<b>(EWYSBGHBSNQ<b> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9535350", Offset = "0x9533F50", VA = "0x189535350")]
		private static void KRSIPXOOWGC(SCGBJNENTJV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x95356A0", Offset = "0x95342A0", VA = "0x1895356A0")]
		private static void WGQYSTODZST()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x95359A0", Offset = "0x95345A0", VA = "0x1895359A0")]
		private static void ZYTZRVEUHPQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9535240", Offset = "0x9533E40", VA = "0x189535240")]
		private static void GOGJDBWSERH()
		{
		}
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public static class YXKJWVIGQQO
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9537C30", Offset = "0x9536830", VA = "0x189537C30")]
		public static IDisposable OXRRZAGQRND(this ILIEJXHRKGW a, float b, Action<float> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9537CB0", Offset = "0x95368B0", VA = "0x189537CB0")]
		public static IDisposable UKTBIRHDTEB(this ILIEJXHRKGW a, Action<float> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9537BB0", Offset = "0x95367B0", VA = "0x189537BB0")]
		public static IDisposable CWLKAPLDBXR(this ILIEJXHRKGW a, Action<float> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public static class VRCJVZXIKAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x419A800", Offset = "0x4199400", VA = "0x18419A800")]
		[MustUseReturnValue]
		public static IDisposable GBXSIINCGIB<a>(this a a, Action b, ScheduleQueueType c, bool d = true) where a : MonoBehaviour, QKMOLDHPCOF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x419A9A0", Offset = "0x41995A0", VA = "0x18419A9A0")]
		[MustUseReturnValue]
		public static IDisposable GBXSIINCGIB<b>(this b a, Action<float> b, ScheduleQueueType c, bool d = true) where b : MonoBehaviour, QKMOLDHPCOF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x419B010", Offset = "0x4199C10", VA = "0x18419B010")]
		[MustUseReturnValue]
		public static IDisposable Update<T>(this T behaviour, Action update, bool validateContext = true) where T : MonoBehaviour, QKMOLDHPCOF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x419A5E0", Offset = "0x41991E0", VA = "0x18419A5E0")]
		[MustUseReturnValue]
		public static IDisposable FixedUpdate<T>(this T behaviour, Action update, bool validateContext = true) where T : MonoBehaviour, QKMOLDHPCOF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x419A650", Offset = "0x4199250", VA = "0x18419A650")]
		[MustUseReturnValue]
		public static IDisposable FixedUpdate<T>(this T behaviour, Action<float> update, bool validateContext = true) where T : MonoBehaviour, QKMOLDHPCOF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x419AC40", Offset = "0x4199840", VA = "0x18419AC40")]
		[MustUseReturnValue]
		public static IDisposable LateUpdate<T>(this T behaviour, Action update, bool validateContext = true) where T : MonoBehaviour, QKMOLDHPCOF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x419AEA0", Offset = "0x4199AA0", VA = "0x18419AEA0")]
		[MustUseReturnValue]
		public static IDisposable RigidbodyExLateUpdate<T>(this T behaviour, Action update, bool validateContext = true) where T : MonoBehaviour, QKMOLDHPCOF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x419AD30", Offset = "0x4199930", VA = "0x18419AD30")]
		[MustUseReturnValue]
		public static IDisposable PreRenderUpdate<T>(this T behaviour, Action update, bool validateContext = true) where T : MonoBehaviour, QKMOLDHPCOF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x419A3F0", Offset = "0x4198FF0", VA = "0x18419A3F0")]
		[MustUseReturnValue]
		public static IDisposable DZUOBLJUQYW<d>(this d a, float b, Action<float> c, ScheduleQueueType d, bool e = true, bool f = true) where d : MonoBehaviour, QKMOLDHPCOF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9534C90", Offset = "0x9533890", VA = "0x189534C90")]
		[MustUseReturnValue]
		public static IDisposable DZUOBLJUQYW(this MonoBehaviour a, QKMOLDHPCOF b, float c, Action<float> d, ScheduleQueueType e, bool f = true, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x419A430", Offset = "0x4199030", VA = "0x18419A430")]
		[MustUseReturnValue]
		public static IDisposable FNODYMBGJQU<e>(this e a, float b, Action<float> c, ScheduleQueueType d, bool e = true, bool f = true) where e : MonoBehaviour, QKMOLDHPCOF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x419B100", Offset = "0x4199D00", VA = "0x18419B100")]
		[MustUseReturnValue]
		public static IDisposable YWEDMBWJEVJ<f>(this f a, float b, Action<float> c, bool d = true, bool e = true) where f : MonoBehaviour, QKMOLDHPCOF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x419AB40", Offset = "0x4199740", VA = "0x18419AB40")]
		[MustUseReturnValue]
		public static IDisposable GLMZNWCTJLC<g>(this g a, Action<float> b, bool c = true, bool d = true) where g : MonoBehaviour, QKMOLDHPCOF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x419B180", Offset = "0x4199D80", VA = "0x18419B180")]
		[MustUseReturnValue]
		public static IDisposable ZCLTZSQGAQN<h>(this h a, Action<float> b, bool c = true, bool d = true) where h : MonoBehaviour, QKMOLDHPCOF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x419ABC0", Offset = "0x41997C0", VA = "0x18419ABC0")]
		[MustUseReturnValue]
		public static IDisposable LPVJJIDWBGY<i>(this i a, Action<float> b, bool c = true, bool d = true) where i : MonoBehaviour, QKMOLDHPCOF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x419AE20", Offset = "0x4199A20", VA = "0x18419AE20")]
		[MustUseReturnValue]
		public static IDisposable RVAGTNPSRIL<j>(this j a, Action<float> b, bool c = true, bool d = true) where j : MonoBehaviour, QKMOLDHPCOF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x419B080", Offset = "0x4199C80", VA = "0x18419B080")]
		[MustUseReturnValue]
		public static IDisposable YMJFXBIFUKV<k>(this k a, Action<float> b, bool c = true, bool d = true) where k : MonoBehaviour, QKMOLDHPCOF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x419ADA0", Offset = "0x41999A0", VA = "0x18419ADA0")]
		[MustUseReturnValue]
		public static IDisposable QVBNCINKIUF<l>(this l a, Action<float> b, bool c = true, bool d = true) where l : MonoBehaviour, QKMOLDHPCOF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x419AF10", Offset = "0x4199B10", VA = "0x18419AF10")]
		[MustUseReturnValue]
		public static IDisposable TOQZXXUVGBZ<o>(this o a, Action<float> b, bool c = true, bool d = true) where o : MonoBehaviour, QKMOLDHPCOF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x419ACB0", Offset = "0x41998B0", VA = "0x18419ACB0")]
		[MustUseReturnValue]
		public static IDisposable PEVSCEAKUXB<q>(this q a, float b, Action<float> c, bool d = true, bool e = true) where q : MonoBehaviour, QKMOLDHPCOF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x419AF90", Offset = "0x4199B90", VA = "0x18419AF90")]
		[MustUseReturnValue]
		public static IDisposable ULLSQUFOKTF<s>(this s a, Action<float> b, bool c = true, bool d = true) where s : MonoBehaviour, QKMOLDHPCOF
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public static class VSGAQWNSGWB
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class DACGFFIHLPE : IEnumerator<UGECMBPSTCZ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			private UGECMBPSTCZ DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public ScheduleQueueType OWOTPXFXZCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public Action LXYYSDKRFHS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			private CGXTCWDUXPE EDBZKLPMKOV;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private UGECMBPSTCZ RADPMWRJHYU
			{
				[Cpp2IlInjected.Token(Token = "0x6000063")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x6000065")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
			[DebuggerHidden]
			public DACGFFIHLPE(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x952B210", Offset = "0x9529E10", VA = "0x18952B210", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x952B2E0", Offset = "0x9529EE0", VA = "0x18952B2E0", Slot = "8")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class DAHNCMCEVAN : IEnumerator<UGECMBPSTCZ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private UGECMBPSTCZ DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public ScheduleQueueType OWOTPXFXZCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public Action<float> LXYYSDKRFHS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private CGXTCWDUXPE EDBZKLPMKOV;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private UGECMBPSTCZ RADPMWRJHYU
			{
				[Cpp2IlInjected.Token(Token = "0x6000069")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x600006B")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
			[DebuggerHidden]
			public DAHNCMCEVAN(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x952B320", Offset = "0x9529F20", VA = "0x18952B320", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x952B400", Offset = "0x952A000", VA = "0x18952B400", Slot = "8")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x95350A0", Offset = "0x9533CA0", VA = "0x1895350A0")]
		public static GEUHFRHGIWS GBXSIINCGIB(Action a, ScheduleQueueType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9535010", Offset = "0x9533C10", VA = "0x189535010")]
		public static GEUHFRHGIWS GBXSIINCGIB(Behaviour a, Action b, ScheduleQueueType c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9535120", Offset = "0x9533D20", VA = "0x189535120")]
		public static GEUHFRHGIWS GBXSIINCGIB(Behaviour a, Action<float> b, ScheduleQueueType c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9534F90", Offset = "0x9533B90", VA = "0x189534F90")]
		[IteratorStateMachine(typeof(DACGFFIHLPE))]
		private static IEnumerator<UGECMBPSTCZ> DKIIHRNWVEK(ScheduleQueueType a, Action b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9534F10", Offset = "0x9533B10", VA = "0x189534F10")]
		[IteratorStateMachine(typeof(DAHNCMCEVAN))]
		private static IEnumerator<UGECMBPSTCZ> DKIIHRNWVEK(ScheduleQueueType a, Action<float> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class CDHNXVAQQAQ : INotifyCompletion
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class EQMDDPIQIZP : IEnumerator<UGECMBPSTCZ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			private UGECMBPSTCZ DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public CDHNXVAQQAQ VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private UGECMBPSTCZ RADPMWRJHYU
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x6000076")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
			[DebuggerHidden]
			public EQMDDPIQIZP(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x952D950", Offset = "0x952C550", VA = "0x18952D950", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x952D9E0", Offset = "0x952C5E0", VA = "0x18952D9E0", Slot = "8")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly ScheduleQueueType IBRYPWEISMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Action TZVAYGEVPGX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private bool ALSBKQJQXGK;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool JZXUPAMYITE
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xB13220", Offset = "0xB11E20", VA = "0x180B13220")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x95294A0", Offset = "0x95280A0", VA = "0x1895294A0")]
		public CDHNXVAQQAQ(ScheduleQueueType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9529390", Offset = "0x9527F90", VA = "0x189529390")]
		[IteratorStateMachine(typeof(EQMDDPIQIZP))]
		private IEnumerator<UGECMBPSTCZ> ATBPJOLRADL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9529400", Offset = "0x9528000", VA = "0x189529400", Slot = "4")]
		public void OnCompleted(Action continuation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0")]
		public void FISHJDRILVA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class DLETMEEISVD
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x952B440", Offset = "0x952A040", VA = "0x18952B440")]
		public static CDHNXVAQQAQ JQSTEJIDXIY(this ScheduleQueueType a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public static class YYNHTNIIEEV
	{
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class FOMGGAWQMUO : IEnumerator<UGECMBPSTCZ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private UGECMBPSTCZ DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public float QGCAGYAVQMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public Action<float> LXYYSDKRFHS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public ScheduleQueueType OWOTPXFXZCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public MDJOYDCAPDE JGTJFHXXAYE;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private UGECMBPSTCZ RADPMWRJHYU
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
			[DebuggerHidden]
			public FOMGGAWQMUO(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x952E4D0", Offset = "0x952D0D0", VA = "0x18952E4D0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x952E8E0", Offset = "0x952D4E0", VA = "0x18952E8E0", Slot = "8")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9537EB0", Offset = "0x9536AB0", VA = "0x189537EB0")]
		public static GEUHFRHGIWS GBXSIINCGIB(float a, Action<float> b, ScheduleQueueType c, bool d = true, [Optional] PABQSBFBGZX e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9537DE0", Offset = "0x95369E0", VA = "0x189537DE0")]
		public static GEUHFRHGIWS GBXSIINCGIB(MonoBehaviour a, float b, Action<float> c, ScheduleQueueType d, bool e = true, [Optional] PABQSBFBGZX f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9538090", Offset = "0x9536C90", VA = "0x189538090")]
		public static GEUHFRHGIWS RFGNRQGIGUN(MonoBehaviour a, float b, Action<float> c, ScheduleQueueType d, bool e = true, [Optional] PABQSBFBGZX f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9538180", Offset = "0x9536D80", VA = "0x189538180")]
		public static GEUHFRHGIWS WJWRLLXBWOH(ILIEJXHRKGW a, float b, Action<float> c, ScheduleQueueType d, bool e = true, [Optional] PABQSBFBGZX f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9537D30", Offset = "0x9536930", VA = "0x189537D30")]
		private static IEnumerator<UGECMBPSTCZ> DKIIHRNWVEK(PDLRKGLSCHQ a, float b, ScheduleQueueType c, Action<float> d, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x9537F80", Offset = "0x9536B80", VA = "0x189537F80")]
		private static IEnumerator<UGECMBPSTCZ> IGZKXVCCWWC(PDLRKGLSCHQ a, float b, ScheduleQueueType c, Action<float> d, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9537FE0", Offset = "0x9536BE0", VA = "0x189537FE0")]
		[IteratorStateMachine(typeof(FOMGGAWQMUO))]
		private static IEnumerator<UGECMBPSTCZ> IZNYFXMNRAW(MDJOYDCAPDE a, float b, ScheduleQueueType c, Action<float> d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public static class FJURPUMHQKL
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class IEKCUPIDVNR : IEnumerator<UGECMBPSTCZ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private UGECMBPSTCZ DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public ScheduleQueueType IBRYPWEISMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public Func<bool> LYCYQFZYCFU;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private UGECMBPSTCZ RADPMWRJHYU
			{
				[Cpp2IlInjected.Token(Token = "0x600008A")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x600008C")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
			[DebuggerHidden]
			public IEKCUPIDVNR(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x952FA10", Offset = "0x952E610", VA = "0x18952FA10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x952FAC0", Offset = "0x952E6C0", VA = "0x18952FAC0", Slot = "8")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x952E370", Offset = "0x952CF70", VA = "0x18952E370")]
		[IteratorStateMachine(typeof(IEKCUPIDVNR))]
		private static IEnumerator<UGECMBPSTCZ> COULUUAJXMT(ScheduleQueueType a, Func<bool> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x952E3F0", Offset = "0x952CFF0", VA = "0x18952E3F0")]
		public static GEUHFRHGIWS YSSQSYUGFAI(this MonoBehaviour a, Func<bool> b, ScheduleQueueType c = ScheduleQueueType.Update)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public static class VPIMFQVPAMM
	{
		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class ERHESQKFUSZ : IEnumerator<UGECMBPSTCZ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private UGECMBPSTCZ DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public float XHWKOWORCCW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public ScheduleQueueType OWOTPXFXZCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public Action IBLKMMDCJOJ;

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			private UGECMBPSTCZ RADPMWRJHYU
			{
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x60000A4")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
			[DebuggerHidden]
			public ERHESQKFUSZ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x952DA20", Offset = "0x952C620", VA = "0x18952DA20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x952DA90", Offset = "0x952C690", VA = "0x18952DA90", Slot = "8")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		[CompilerGenerated]
		private sealed class YVBRWMCONQB<a> : IEnumerator<UGECMBPSTCZ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private UGECMBPSTCZ DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public float XHWKOWORCCW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public ScheduleQueueType OWOTPXFXZCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public Action<a> IBLKMMDCJOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public a ZHKBAYQBOTJ;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private UGECMBPSTCZ RADPMWRJHYU
			{
				[Cpp2IlInjected.Token(Token = "0x60000A8")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x60000AA")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
			[DebuggerHidden]
			public YVBRWMCONQB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x448DF40", Offset = "0x448CB40", VA = "0x18448DF40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x4381FB0", Offset = "0x4380BB0", VA = "0x184381FB0", Slot = "8")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private sealed class ZXIKNYPPEMF : IEnumerator<UGECMBPSTCZ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private UGECMBPSTCZ DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public float XHWKOWORCCW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public ScheduleQueueType OWOTPXFXZCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			public Action IBLKMMDCJOJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private UGECMBPSTCZ JKCWBFYGSCN;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private UGECMBPSTCZ RADPMWRJHYU
			{
				[Cpp2IlInjected.Token(Token = "0x60000AE")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x60000B0")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
			[DebuggerHidden]
			public ZXIKNYPPEMF(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x9538250", Offset = "0x9536E50", VA = "0x189538250", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x95382E0", Offset = "0x9536EE0", VA = "0x1895382E0", Slot = "8")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9534230", Offset = "0x9532E30", VA = "0x189534230")]
		[IteratorStateMachine(typeof(ERHESQKFUSZ))]
		private static IEnumerator<UGECMBPSTCZ> ATBPJOLRADL(float a, ScheduleQueueType b, Action c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x4199CB0", Offset = "0x41988B0", VA = "0x184199CB0")]
		[IteratorStateMachine(typeof(YVBRWMCONQB<>))]
		private static IEnumerator<UGECMBPSTCZ> ATBPJOLRADL<a>(float a, ScheduleQueueType b, Action<a> c, a d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x9534530", Offset = "0x9533130", VA = "0x189534530")]
		[IteratorStateMachine(typeof(ZXIKNYPPEMF))]
		private static IEnumerator<UGECMBPSTCZ> EIZLPRMBYLF(float a, ScheduleQueueType b, Action c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9534750", Offset = "0x9533350", VA = "0x189534750")]
		public static IDisposable KWBMGJDSSED(this MonoBehaviour a, float b, Action c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9534A10", Offset = "0x9533610", VA = "0x189534A10")]
		public static GEUHFRHGIWS WLYJJJAHYXN(this MonoBehaviour a, float b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9534660", Offset = "0x9533260", VA = "0x189534660")]
		public static GEUHFRHGIWS KWBMGJDSSED(this MonoBehaviour a, float b, ScheduleQueueType c, Action d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x95342C0", Offset = "0x9532EC0", VA = "0x1895342C0")]
		public static GEUHFRHGIWS AWGETTNHLXX(this MonoBehaviour a, Action b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x4199E80", Offset = "0x4198A80", VA = "0x184199E80")]
		public static GEUHFRHGIWS AWGETTNHLXX<b>(this MonoBehaviour a, Action<b> b, b c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x95345C0", Offset = "0x95331C0", VA = "0x1895345C0")]
		public static GEUHFRHGIWS GVQOBGWDHSL(this MonoBehaviour a, Action b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9534970", Offset = "0x9533570", VA = "0x189534970")]
		public static GEUHFRHGIWS WBWQRKNTAND(this MonoBehaviour a, Action b, [Optional] PABQSBFBGZX c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x9534B40", Offset = "0x9533740", VA = "0x189534B40")]
		public static GEUHFRHGIWS XDYDQYKMCHD(this MonoBehaviour a, Action b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x9534490", Offset = "0x9533090", VA = "0x189534490")]
		public static GEUHFRHGIWS DGQTYNMNPMZ(this MonoBehaviour a, Action b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x9534830", Offset = "0x9533430", VA = "0x189534830")]
		public static GEUHFRHGIWS OVPOQESMFWN(MonoBehaviour a, ScheduleQueueType b, Action c, [Optional] PABQSBFBGZX d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x419A130", Offset = "0x4198D30", VA = "0x18419A130")]
		public static GEUHFRHGIWS OVPOQESMFWN<h>(MonoBehaviour a, ScheduleQueueType b, Action<h> c, h d, [Optional] PABQSBFBGZX e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x9534400", Offset = "0x9533000", VA = "0x189534400")]
		public static GEUHFRHGIWS CCXSSNICAKL(this MonoBehaviour a, float b, Action c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x95348D0", Offset = "0x95334D0", VA = "0x1895348D0")]
		public static GEUHFRHGIWS VNATPHRJPUH(this MonoBehaviour a, float b, Action c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x9534AA0", Offset = "0x95336A0", VA = "0x189534AA0")]
		public static GEUHFRHGIWS WXYHFSGWRUL(this MonoBehaviour a, float b, Action c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x9534360", Offset = "0x9532F60", VA = "0x189534360")]
		public static GEUHFRHGIWS BDIWERFNGOX(this MonoBehaviour a, float b, Action c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class EPJRCXBUCGS : FRJKIYBORVQ, IEnumerable<FRJKIYBORVQ>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private readonly List<FRJKIYBORVQ> KLPWXJZQSMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private bool RDRCXRRAULI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private Action VCZKVWOHMHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private bool TIGSZUTZWEK;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool TCVVEKIRZAW
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x952D1F0", Offset = "0x952BDF0", VA = "0x18952D1F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action EYOFPSUJETA
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x952D150", Offset = "0x952BD50", VA = "0x18952D150", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x952D6B0", Offset = "0x952C2B0", VA = "0x18952D6B0", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x952D8B0", Offset = "0x952C4B0", VA = "0x18952D8B0")]
		public EPJRCXBUCGS([Optional] Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x952CFD0", Offset = "0x952BBD0", VA = "0x18952CFD0")]
		public void Add(FRJKIYBORVQ limiter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x952D750", Offset = "0x952C350", VA = "0x18952D750")]
		private void WOCCMSFNNUH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x952D6A0", Offset = "0x952C2A0", VA = "0x18952D6A0", Slot = "7")]
		public bool KDUXPNNVWHI(bool a = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x952D3A0", Offset = "0x952BFA0", VA = "0x18952D3A0", Slot = "8")]
		public bool KDUXPNNVWHI(Action a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x952D320", Offset = "0x952BF20", VA = "0x18952D320", Slot = "9")]
		public IEnumerator<FRJKIYBORVQ> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x952D320", Offset = "0x952BF20", VA = "0x18952D320", Slot = "10")]
		private IEnumerator ZFHLTDQPCLO()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class PYFGJUEXMVW : JQGZALWEESU
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		[CompilerGenerated]
		private sealed class LIKIZMPSLOB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public PYFGJUEXMVW VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public Action PZRSECPTZTV;

			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public LIKIZMPSLOB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x9531810", Offset = "0x9530410", VA = "0x189531810")]
			internal void ZWXFQWHOGRC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class QBWFFRHGRMS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public PYFGJUEXMVW VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public Action PZRSECPTZTV;

			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public QBWFFRHGRMS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x9531810", Offset = "0x9530410", VA = "0x189531810")]
			internal void KGQTDLDHNGN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly float NBVLRZVXZNH;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x9529250", Offset = "0x9527E50", VA = "0x189529250")]
		public PYFGJUEXMVW(Behaviour a, float b, [Optional] Action c, [Optional] PABQSBFBGZX d, [Optional] PDLRKGLSCHQ e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x9532AD0", Offset = "0x95316D0", VA = "0x189532AD0", Slot = "9")]
		protected override bool PQFDEPUXTPK(Action a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x9532BE0", Offset = "0x95317E0", VA = "0x189532BE0", Slot = "10")]
		protected override bool TMJGZAGEGPZ(Action a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public interface FRJKIYBORVQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000018")]
		bool TCVVEKIRZAW
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action EYOFPSUJETA;

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool KDUXPNNVWHI(bool a = false);

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool KDUXPNNVWHI(Action a, bool b = false);
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public abstract class JQGZALWEESU : FRJKIYBORVQ
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		[CompilerGenerated]
		private sealed class NUFEWSSTXTZ : IEnumerator<UGECMBPSTCZ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000072")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			private UGECMBPSTCZ DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public JQGZALWEESU VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public float BNVIDHJCWTX;

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private UGECMBPSTCZ RADPMWRJHYU
			{
				[Cpp2IlInjected.Token(Token = "0x60000DB")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x60000DD")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
			[DebuggerHidden]
			public NUFEWSSTXTZ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x95329C0", Offset = "0x95315C0", VA = "0x1895329C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x9532A90", Offset = "0x9531690", VA = "0x189532A90", Slot = "8")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly Behaviour KEBYUPXJULG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly Action VCZKVWOHMHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private TVVSFJCWLRF UAUSFCBFRHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly PABQSBFBGZX LVOZVQMMXRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		protected readonly PDLRKGLSCHQ CUAVQIGNOZR;

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public bool TCVVEKIRZAW
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x20740E0", Offset = "0x2072CE0", VA = "0x1820740E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action EYOFPSUJETA
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x9530E70", Offset = "0x952FA70", VA = "0x189530E70", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x9531070", Offset = "0x952FC70", VA = "0x189531070", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x9531400", Offset = "0x9530000", VA = "0x189531400")]
		protected JQGZALWEESU(Behaviour a, [Optional] Action b, [Optional] PABQSBFBGZX c, [Optional] PDLRKGLSCHQ d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9530F90", Offset = "0x952FB90", VA = "0x189530F90", Slot = "7")]
		public bool KDUXPNNVWHI(bool a = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x9530F30", Offset = "0x952FB30", VA = "0x189530F30", Slot = "8")]
		public bool KDUXPNNVWHI(Action a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract bool PQFDEPUXTPK(Action a);

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract bool TMJGZAGEGPZ(Action a);

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9530F10", Offset = "0x952FB10", VA = "0x189530F10")]
		protected void GHIOFLUBQYP(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x95311D0", Offset = "0x952FDD0", VA = "0x1895311D0")]
		protected ZPYKPRNSTIB WHHHIMYMVEZ(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9531150", Offset = "0x952FD50", VA = "0x189531150")]
		private void PSQVJGKHVTU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x9530FF0", Offset = "0x952FBF0", VA = "0x189530FF0")]
		[IteratorStateMachine(typeof(NUFEWSSTXTZ))]
		private IEnumerator<UGECMBPSTCZ> KYJQOWKJRMU(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x9531110", Offset = "0x952FD10", VA = "0x189531110")]
		[CompilerGenerated]
		private void NMCSLQMMGPD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class VLVHDVKUATL : JQGZALWEESU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private readonly float PXONRJXSRTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private readonly int GMTNPTUDAWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private readonly float SPUHDZGYFID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly float[] XBPCUALIZFQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int OOJBZLVUCXG;

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x9534060", Offset = "0x9532C60", VA = "0x189534060")]
		public VLVHDVKUATL(Behaviour a, float b, int c, [Optional] Action d, float e = 0f, [Optional] PABQSBFBGZX f, [Optional] PDLRKGLSCHQ g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "9")]
		protected override bool PQFDEPUXTPK(Action a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x9533E60", Offset = "0x9532A60", VA = "0x189533E60", Slot = "10")]
		protected override bool TMJGZAGEGPZ(Action a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x9533DE0", Offset = "0x95329E0", VA = "0x189533DE0")]
		private void EPTRZPRXARQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class BUXHQOYNFVP : JQGZALWEESU
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly float NBVLRZVXZNH;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9529250", Offset = "0x9527E50", VA = "0x189529250")]
		public BUXHQOYNFVP(Behaviour a, float b, [Optional] Action c, [Optional] PABQSBFBGZX d, [Optional] PDLRKGLSCHQ e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "9")]
		protected override bool PQFDEPUXTPK(Action a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x9529210", Offset = "0x9527E10", VA = "0x189529210", Slot = "10")]
		protected override bool TMJGZAGEGPZ(Action a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public sealed class IADZIAHPJDJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private sealed class VUALJNYOKBP : IEnumerator<UGECMBPSTCZ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			private UGECMBPSTCZ DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public Action QBLFRPGYVAB;

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			private UGECMBPSTCZ RADPMWRJHYU
			{
				[Cpp2IlInjected.Token(Token = "0x60000EE")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x60000F0")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
			[DebuggerHidden]
			public VUALJNYOKBP(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x9534E60", Offset = "0x9533A60", VA = "0x189534E60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x9535200", Offset = "0x9533E00", VA = "0x189535200", Slot = "8")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private GEUHFRHGIWS HIIBRPAPPXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private ILIEJXHRKGW KEBYUPXJULG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private Action<float> HOHWQUXRMBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private ScheduleQueueType IBRYPWEISMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private float LCWVATFSLAO;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x952F870", Offset = "0x952E470", VA = "0x18952F870")]
		public IADZIAHPJDJ(ILIEJXHRKGW a, float b, Action<float> c, ScheduleQueueType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x952F420", Offset = "0x952E020", VA = "0x18952F420")]
		private void COUEONTJXVF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x952F750", Offset = "0x952E350", VA = "0x18952F750")]
		private void SWJYPUCIYHV(string a, Action b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x952F3B0", Offset = "0x952DFB0", VA = "0x18952F3B0")]
		[IteratorStateMachine(typeof(VUALJNYOKBP))]
		private IEnumerator<UGECMBPSTCZ> AGAHBJJCNUX(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x952F6F0", Offset = "0x952E2F0", VA = "0x18952F6F0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x952F580", Offset = "0x952E180", VA = "0x18952F580")]
		[CompilerGenerated]
		private void DXDLFFUHITU(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class MJFPOUODFBD : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class VRUNNRNRKGU : IEnumerator<UGECMBPSTCZ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private UGECMBPSTCZ DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			public Action QBLFRPGYVAB;

			[Cpp2IlInjected.Token(Token = "0x1700001E")]
			private UGECMBPSTCZ RADPMWRJHYU
			{
				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001F")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x6000106")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
			[DebuggerHidden]
			public VRUNNRNRKGU(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x9534E60", Offset = "0x9533A60", VA = "0x189534E60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x9534ED0", Offset = "0x9533AD0", VA = "0x189534ED0", Slot = "8")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private GEUHFRHGIWS HIIBRPAPPXT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private MonoBehaviour ETBYQANLNUA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private Action LXYYSDKRFHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private Action<float> HOHWQUXRMBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private ScheduleQueueType IBRYPWEISMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		private float LCWVATFSLAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private bool GGBDKUHKEIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private readonly PABQSBFBGZX LVOZVQMMXRU;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x95324A0", Offset = "0x95310A0", VA = "0x1895324A0")]
		public MJFPOUODFBD(MonoBehaviour a, Action b, ScheduleQueueType c, [Optional] PABQSBFBGZX d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9532620", Offset = "0x9531220", VA = "0x189532620")]
		public MJFPOUODFBD(MonoBehaviour a, Action<float> b, ScheduleQueueType c, [Optional] PABQSBFBGZX d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x95327E0", Offset = "0x95313E0", VA = "0x1895327E0")]
		public MJFPOUODFBD(MonoBehaviour a, float b, Action<float> c, ScheduleQueueType d, bool e = true, [Optional] PABQSBFBGZX f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0xF8EDE0", Offset = "0xF8D9E0", VA = "0x180F8EDE0")]
		private MJFPOUODFBD(PABQSBFBGZX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x9531930", Offset = "0x9530530", VA = "0x189531930")]
		internal static MJFPOUODFBD ARTCWULXPML(MonoBehaviour a, float b, Action<float> c, ScheduleQueueType d, bool e = true, [Optional] PABQSBFBGZX f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x9531D20", Offset = "0x9530920", VA = "0x189531D20")]
		private void GBXSIINCGIB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x9532330", Offset = "0x9530F30", VA = "0x189532330")]
		private void XAKXEEYTUIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x9531B50", Offset = "0x9530750", VA = "0x189531B50")]
		private void COUEONTJXVF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x9532000", Offset = "0x9530C00", VA = "0x189532000")]
		private void TELQEWFWNWX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x9531EE0", Offset = "0x9530AE0", VA = "0x189531EE0")]
		private void SWJYPUCIYHV(string a, Action b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x95318C0", Offset = "0x95304C0", VA = "0x1895318C0")]
		[IteratorStateMachine(typeof(VRUNNRNRKGU))]
		private IEnumerator<UGECMBPSTCZ> AGAHBJJCNUX(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x9531CC0", Offset = "0x95308C0", VA = "0x189531CC0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x9532210", Offset = "0x9530E10", VA = "0x189532210")]
		[CompilerGenerated]
		private void VUBLKWHAEGO(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x95322A0", Offset = "0x9530EA0", VA = "0x1895322A0")]
		[CompilerGenerated]
		private void WPVDTDRQKMV(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x9532180", Offset = "0x9530D80", VA = "0x189532180")]
		[CompilerGenerated]
		private void VPISSDQGCZE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x9531E50", Offset = "0x9530A50", VA = "0x189531E50")]
		[CompilerGenerated]
		private void ILIRWEIDQVZ(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[Flags]
	internal enum CoroutineState : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		Inactive = 0,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		Running = 1,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		Cancelled = 2,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		Paused = 4
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal sealed class VQPAVSTYVQM : PDLRKGLSCHQ
	{
		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float AUQDPIVCHZO
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x9534BF0", Offset = "0x95337F0", VA = "0x189534BF0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float MGQIQZSIBNS
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x9534BE0", Offset = "0x95337E0", VA = "0x189534BE0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public double EGGPXLFWCBR
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x9534C00", Offset = "0x9533800", VA = "0x189534C00", Slot = "6")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x9534C20", Offset = "0x9533820", VA = "0x189534C20")]
		[IFIZWETSKCB.Root]
		internal static void KQEBINAABYI(DiContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		[UnityEngine.Scripting.Preserve]
		internal VQPAVSTYVQM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal interface IADLVEUHJEF
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MQFTDXSDXRO(string a);

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void FORTQJLQOLK();
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	internal interface CRJQJJJSHSI
	{
		[Cpp2IlInjected.Token(Token = "0x17000023")]
		string QMZMPPIFWAW
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		bool SGZBYYBIKJN
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		bool VULLGOQQXAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	internal class WUZVEIADRIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public BFSBGZIFYHB LYKWEKFLMEI;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public int TBYJWOVXLDZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0xB1FB20", Offset = "0xB1E720", VA = "0x180B1FB20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x9535D50", Offset = "0x9534950", VA = "0x189535D50")]
		public static UGECMBPSTCZ FJWWWFKWMTR(IEnumerator<UGECMBPSTCZ> a, KEYBCSBBEDV b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x9535C90", Offset = "0x9534890", VA = "0x189535C90")]
		public UGECMBPSTCZ FJWWWFKWMTR(KEYBCSBBEDV[] a, IEnumerator<UGECMBPSTCZ>[] b, UGECMBPSTCZ[] c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x9535C60", Offset = "0x9534860", VA = "0x189535C60")]
		public void WRREUNZDIHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x9535EB0", Offset = "0x9534AB0", VA = "0x189535EB0")]
		public void SYEZSBOWHPW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x9535B70", Offset = "0x9534770", VA = "0x189535B70")]
		public void BGTLTWYZRPR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x9535C60", Offset = "0x9534860", VA = "0x189535C60")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public WUZVEIADRIO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal sealed class BFSBGZIFYHB
	{
		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public struct JobbedInsertionData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public WUZVEIADRIO Routine;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public ILIEJXHRKGW Context;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public KEYBCSBBEDV Promise;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public IEnumerator<UGECMBPSTCZ> Coroutine;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public UGECMBPSTCZ CurrentSchedule;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public CoroutineState CoroutineState;
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public struct JobbedReinsertBuffer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public ScheduleQueueType QueueType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public List<JobbedInsertionData> Insertions;
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private sealed class FTNYYFHXZBU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public KEYBCSBBEDV RXORLNVKNWC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public BFSBGZIFYHB VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public ILIEJXHRKGW KEBYUPXJULG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public WUZVEIADRIO NEQCPBLFSQT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public CoroutineState KFYXQNSUXNY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public UGECMBPSTCZ OMIDBKHIQSL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public IEnumerator<UGECMBPSTCZ> PSIGCDIRLIR;

			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public FTNYYFHXZBU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x952E920", Offset = "0x952D520", VA = "0x18952E920")]
			internal void RKGXBGCDGIZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class IZMSCMSHGEC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public WUZVEIADRIO JGTJFHXXAYE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public BFSBGZIFYHB VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public IZMSCMSHGEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x952FB00", Offset = "0x952E700", VA = "0x18952FB00")]
			internal void VVCWMTNHCZT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		[CompilerGenerated]
		private sealed class WYJGJAFGLYJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public WUZVEIADRIO JGTJFHXXAYE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public BFSBGZIFYHB VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public WYJGJAFGLYJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x9535FA0", Offset = "0x9534BA0", VA = "0x189535FA0")]
			internal void PROLLDCNSPR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		[CompilerGenerated]
		private sealed class SEXKCVNSFZS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public WUZVEIADRIO JGTJFHXXAYE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public BFSBGZIFYHB VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public SEXKCVNSFZS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x9532DF0", Offset = "0x95319F0", VA = "0x189532DF0")]
			internal void FRQOXXRJBTC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private const CoroutineState SUUSUTQWPFJ = CoroutineState.Cancelled | CoroutineState.Paused;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly ScheduleQueueType IBRYPWEISMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private bool[] PKYVFLUOKVZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private NativeArray<CoroutineState> JVYJYPOVHSA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private NativeArray<float> UAVSMFBUJTO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private NativeArray<int> LDFDIEUEKWY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private NativeArray<int> LYSGXYXHQHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private NativeArray<int> ZQIWAJLRLTT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private NativeArray<int> UTBESICVTRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private NativeArray<int> HYLEBWULFOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private WUZVEIADRIO[] LINWOOEWOJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private KEYBCSBBEDV[] QITLIABTNYJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private ILIEJXHRKGW[] OIKIBUKNKZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private IEnumerator<UGECMBPSTCZ>[] GDCJXSKMSVV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private UGECMBPSTCZ[] VSXKEXRDERX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private int ADNGGRBZNAY;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private int JZLURPBHBUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private readonly int MOFGULHUKBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private float DWYKZASQKXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private ScheduleSortJob LDTMUKZNWDZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private JobHandle QYFYINBFDUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		private List<WUZVEIADRIO> KXEEZWJCQCR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private bool BXWKLZCQXOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private List<Action> SNBLXNQMHLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private List<Action> BCTHQNIDUZU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private bool DHCTXBRXEBH;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public JobbedReinsertBuffer[] UIERTOVZHCP
		{
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xC8E1D0", Offset = "0xC8CDD0", VA = "0x180C8E1D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x9526CA0", Offset = "0x95258A0", VA = "0x189526CA0")]
		private static int DMXYKASCQNH(ScheduleQueueType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x9528BC0", Offset = "0x95277C0", VA = "0x189528BC0")]
		public BFSBGZIFYHB(ScheduleQueueType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x95289E0", Offset = "0x95275E0", VA = "0x1895289E0")]
		private void ZXJAIGZNAZJ(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x9528650", Offset = "0x9527250", VA = "0x189528650")]
		public void RCKSHPWOYAH(ILIEJXHRKGW a, UGECMBPSTCZ b, IEnumerator<UGECMBPSTCZ> c, KEYBCSBBEDV d, [Optional] WUZVEIADRIO e, CoroutineState f = CoroutineState.Running)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9527510", Offset = "0x9526110", VA = "0x189527510")]
		public void Insert(IEnumerable<JobbedInsertionData> insertionDatas)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x9527750", Offset = "0x9526350", VA = "0x189527750")]
		private JobbedInsertionData NJDCFDGZOQU(int a)
		{
			return default(JobbedInsertionData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x9526870", Offset = "0x9525470", VA = "0x189526870")]
		private void CDRIKHBACJU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x38FCD00", Offset = "0x38FB900", VA = "0x1838FCD00")]
		private static void LNLVYUXZBYE<a>(int a, a[] b, int c, [Optional] a d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x38FCD50", Offset = "0x38FB950", VA = "0x1838FCD50")]
		private static void LNLVYUXZBYE<b>(int a, NativeArray<b> b, int c, [Optional] b d) where b : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x9526EB0", Offset = "0x9525AB0", VA = "0x189526EB0")]
		private void ECRBNSTAYGA(IEnumerable<JobbedInsertionData> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x9527440", Offset = "0x9526040", VA = "0x189527440")]
		private void IODNDCXAEKZ(JobbedInsertionData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x95283F0", Offset = "0x9526FF0", VA = "0x1895283F0")]
		private TickResult QZHCCJHFDGI(int a)
		{
			return default(TickResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x9527240", Offset = "0x9525E40", VA = "0x189527240")]
		public void GQEOZBWUMYL(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x9528900", Offset = "0x9527500", VA = "0x189528900")]
		private void WRDABXHXHSF(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x9528820", Offset = "0x9527420", VA = "0x189528820")]
		private void WFCVTSPQEWV(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x9527C00", Offset = "0x9526800", VA = "0x189527C00")]
		public void PMYMQVKTZNT(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x9526DB0", Offset = "0x95259B0", VA = "0x189526DB0")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x9526BC0", Offset = "0x95257C0", VA = "0x189526BC0")]
		public void Cancel(WUZVEIADRIO schedule)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x9528310", Offset = "0x9526F10", VA = "0x189528310")]
		public void Pause(WUZVEIADRIO schedule)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x9526CD0", Offset = "0x95258D0", VA = "0x189526CD0")]
		public void DVIHBQEVGWA(WUZVEIADRIO a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class Receipt : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public static readonly Receipt SFYIBZFHVJY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private readonly Action PDOECYDAWMR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private bool DDIOUOLRIDQ;

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public Receipt(Action onDispose)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8B7DEE0", Offset = "0x8B7CAE0", VA = "0x188B7DEE0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public interface KVONPMLCVWH<a>
	{
		[Cpp2IlInjected.Token(Token = "0x17000028")]
		a ZSNEVPBDVJU
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IDisposable IHMVDPHUFED(UnityEngine.Object a, Action<a> b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public interface QSNETRWQFRT<a> : KVONPMLCVWH<a>
	{
		[Cpp2IlInjected.Token(Token = "0x17000029")]
		new a ZSNEVPBDVJU
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class TAOFBAYVQJC<a> : QSNETRWQFRT<a>, KVONPMLCVWH<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000047")]
		[CompilerGenerated]
		private sealed class CMIBJUZGHFB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public TAOFBAYVQJC<a> VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public Tuple<UnityEngine.Object, Action<a>> TJCKEIUJYYO;

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public CMIBJUZGHFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x43AACF0", Offset = "0x43A98F0", VA = "0x1843AACF0")]
			internal void JPVPCXAGDRH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		private static GameObject SKQTQUNJLFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private readonly List<Tuple<UnityEngine.Object, Action<a>>> QSLJGDTNXRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private a GRSFRMKJMGL;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public a ZSNEVPBDVJU
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0xB69420", Offset = "0xB68020", VA = "0x180B69420", Slot = "5")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x65DD390", Offset = "0x65DBF90", VA = "0x1865DD390", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x65DD0B0", Offset = "0x65DBCB0", VA = "0x1865DD0B0")]
		private static bool MWMLYBHJHKP(a a, a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x65DD5B0", Offset = "0x65DC1B0", VA = "0x1865DD5B0")]
		public TAOFBAYVQJC(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x65DCB80", Offset = "0x65DB780", VA = "0x1865DCB80", Slot = "6")]
		public IDisposable IHMVDPHUFED(UnityEngine.Object a, Action<a> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x65DC320", Offset = "0x65DAF20", VA = "0x1865DC320")]
		private void CENGKXVVTZB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	internal class XXQUIJTGSDC : TWFICYHPZMJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		private class TDMYBLMOZNF : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x200004A")]
			private class YWCOKGHMZSE : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				private int KGOJFCHDRGI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				private TDMYBLMOZNF OWOTPXFXZCI;

				[Cpp2IlInjected.Token(Token = "0x6000159")]
				[Cpp2IlInjected.Address(RVA = "0x1155AA0", Offset = "0x11546A0", VA = "0x181155AA0")]
				public YWCOKGHMZSE(int a, TDMYBLMOZNF b)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600015A")]
				[Cpp2IlInjected.Address(RVA = "0x9537B80", Offset = "0x9536780", VA = "0x189537B80", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004B")]
			[CompilerGenerated]
			private sealed class GLPIMGKKXXA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				public int KGOJFCHDRGI;

				[Cpp2IlInjected.Token(Token = "0x600015B")]
				[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
				public GLPIMGKKXXA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600015C")]
				[Cpp2IlInjected.Address(RVA = "0xBF2BA0", Offset = "0xBF17A0", VA = "0x180BF2BA0")]
				internal bool TZFTQSLHJKR(YQMXINKHWII a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200004C")]
			[CompilerGenerated]
			private sealed class CYWQVQSXGZC : IEnumerator<UGECMBPSTCZ>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				private int JEOGOPMUBAR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				private UGECMBPSTCZ DPUPDOXIACG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public TDMYBLMOZNF VISDDFDIKLJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				public PDLRKGLSCHQ BNXARLMEDQG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				private CGXTCWDUXPE EDBZKLPMKOV;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000DF")]
				private List<YQMXINKHWII> BQWOYKXLXRV;

				[Cpp2IlInjected.Token(Token = "0x1700002B")]
				private UGECMBPSTCZ RADPMWRJHYU
				{
					[Cpp2IlInjected.Token(Token = "0x6000160")]
					[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002C")]
				private object APIHCGBOWUL
				{
					[Cpp2IlInjected.Token(Token = "0x6000162")]
					[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600015D")]
				[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
				[DebuggerHidden]
				public CYWQVQSXGZC(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600015E")]
				[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
				[DebuggerHidden]
				private void YLGUCQLHQAY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600015F")]
				[Cpp2IlInjected.Address(RVA = "0x9529570", Offset = "0x9528170", VA = "0x189529570", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000161")]
				[Cpp2IlInjected.Address(RVA = "0x9529850", Offset = "0x9528450", VA = "0x189529850", Slot = "8")]
				[DebuggerHidden]
				private void RALPBKOBMUN()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			private readonly ScheduleQueueType IBRYPWEISMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			private GEUHFRHGIWS RXORLNVKNWC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			private readonly List<YQMXINKHWII> WPTKDGBBJMP;

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x95337A0", Offset = "0x95323A0", VA = "0x1895337A0")]
			public TDMYBLMOZNF(ScheduleQueueType a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x9533450", Offset = "0x9532050", VA = "0x189533450")]
			public IDisposable VBDRRMQTZRS(YQMXINKHWII a, PABQSBFBGZX b, PDLRKGLSCHQ c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x9533620", Offset = "0x9532220", VA = "0x189533620")]
			private void XLMSVFKWQCH(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x9533370", Offset = "0x9531F70", VA = "0x189533370")]
			[IteratorStateMachine(typeof(CYWQVQSXGZC))]
			private IEnumerator<UGECMBPSTCZ> DKIIHRNWVEK(PDLRKGLSCHQ a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x9533400", Offset = "0x9532000", VA = "0x189533400", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		private class YQMXINKHWII
		{
			[Cpp2IlInjected.Token(Token = "0x200004E")]
			public enum UpdateTypes : byte
			{
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				EveryFrame,
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				Scheduled,
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				ScheduledNonFramerateLimited
			}

			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			private static int PWLJOLIXCSA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public readonly int AXUVQJAOTPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public readonly QKMOLDHPCOF VAVZNXDXCGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			private readonly MonoBehaviour ARXVMRWKCPI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public readonly Action KRZWVPGGDNW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public readonly Action<float> YWHPCWRNKZT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public readonly float MXWDPTGCTPG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public float UAVSMFBUJTO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public readonly string QMZMPPIFWAW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public readonly bool HSSECTKRXTQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public readonly UpdateTypes ZHOEGFNAJQY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public bool AAMNJOFHXTJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4B")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public bool CEHUUJBTVLM;

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x9537690", Offset = "0x9536290", VA = "0x189537690")]
			public YQMXINKHWII(QKMOLDHPCOF a, Action b, bool c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x9537A00", Offset = "0x9536600", VA = "0x189537A00")]
			public YQMXINKHWII(QKMOLDHPCOF a, Action<float> b, bool c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x9537810", Offset = "0x9536410", VA = "0x189537810")]
			public YQMXINKHWII(QKMOLDHPCOF a, float b, Action<float> c, PDLRKGLSCHQ d, UpdateTypes e, bool f, bool g)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x9537160", Offset = "0x9535D60", VA = "0x189537160")]
			public bool LMPFYIVBEUX(float a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0x95373B0", Offset = "0x9535FB0", VA = "0x1895373B0")]
			private static string WSLXOGUNDTC(Action a, Action<float> b, float c)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly PABQSBFBGZX LVOZVQMMXRU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private readonly PDLRKGLSCHQ CUAVQIGNOZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private readonly Dictionary<ScheduleQueueType, TDMYBLMOZNF> FCWTWCCZKMA;

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x9536840", Offset = "0x9535440", VA = "0x189536840")]
		[IFIZWETSKCB.Root]
		internal static void RPEZVDINPXC(DiContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x95370A0", Offset = "0x9535CA0", VA = "0x1895370A0")]
		[UnityEngine.Scripting.Preserve]
		internal XXQUIJTGSDC([Inject(null)] PABQSBFBGZX scheduler, [Inject(null)] PDLRKGLSCHQ schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x9536C50", Offset = "0x9535850", VA = "0x189536C50", Slot = "4")]
		public IDisposable Update(QKMOLDHPCOF context, Action callback, ScheduleQueueType queueType, bool validateContext = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x9536A70", Offset = "0x9535670", VA = "0x189536A70", Slot = "5")]
		public IDisposable Update(QKMOLDHPCOF context, Action<float> callback, ScheduleQueueType queueType, bool validateContext = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x9536E30", Offset = "0x9535A30", VA = "0x189536E30", Slot = "7")]
		public IDisposable YWEDMBWJEVJ(QKMOLDHPCOF a, float b, Action<float> c, ScheduleQueueType d, bool e = true, bool f = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x9536610", Offset = "0x9535210", VA = "0x189536610", Slot = "8")]
		public IDisposable CHUUDFKAUDB(QKMOLDHPCOF a, float b, Action<float> c, ScheduleQueueType d, bool e = true, bool f = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x9536F30", Offset = "0x9535B30", VA = "0x189536F30", Slot = "6")]
		public IDisposable YWEDMBWJEVJ(float a, Action<float> b, bool c = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x95368B0", Offset = "0x95354B0", VA = "0x1895368B0", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x9536710", Offset = "0x9535310", VA = "0x189536710")]
		private TDMYBLMOZNF IFWJQIBMIPX(ScheduleQueueType a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public class AJBIPVUFGCW : JQECWSPFHWX, PABQSBFBGZX, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private BFSBGZIFYHB[] TMIOQXVFPQH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private IADLVEUHJEF IOIBWCNVROH;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x9525B80", Offset = "0x9524780", VA = "0x189525B80")]
		[IFIZWETSKCB.Root]
		internal static void KQEBINAABYI(DiContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x95267C0", Offset = "0x95253C0", VA = "0x1895267C0")]
		[UnityEngine.Scripting.Preserve]
		public AJBIPVUFGCW([Inject(null)] SPOXKCARAWS unityLifecycleEvents, [Inject(null)] PDLRKGLSCHQ schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x9525FD0", Offset = "0x9524BD0", VA = "0x189525FD0", Slot = "19")]
		public override GEUHFRHGIWS QQMWMEXDJQI(ILIEJXHRKGW a, IEnumerator<UGECMBPSTCZ> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x9526100", Offset = "0x9524D00", VA = "0x189526100", Slot = "20")]
		public override void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x9526490", Offset = "0x9525090", VA = "0x189526490", Slot = "22")]
		public override void TDMYBLMOZNF(ScheduleQueueType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x95266F0", Offset = "0x95252F0", VA = "0x1895266F0", Slot = "21")]
		protected override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x95266C0", Offset = "0x95252C0", VA = "0x1895266C0")]
		private BFSBGZIFYHB TMTPNEXBLGY(ScheduleQueueType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x9525DC0", Offset = "0x95249C0", VA = "0x189525DC0", Slot = "23")]
		internal override FBVUZDXCDBW QDCGPTYGXFG(IEnumerator<UGECMBPSTCZ> a, Behaviour b, KEYBCSBBEDV c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0x9525D10", Offset = "0x9524910", VA = "0x189525D10", Slot = "24")]
		internal override EDYIRMURRZH NNMHTYCTYPX(ScheduleQueueType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x9525BF0", Offset = "0x95247F0", VA = "0x189525BF0")]
		private void KQKAGROVQTC(BFSBGZIFYHB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x9525B20", Offset = "0x9524720", VA = "0x189525B20", Slot = "25")]
		public override void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	[BurstCompile]
	internal struct ScheduleSortJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		[ReadOnly]
		public float Now;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[ReadOnly]
		public int ActiveCoroutineCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private NativeArray<int> Indices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private NativeArray<int> scratchLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private NativeArray<int> scratchRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		[ReadOnly]
		public NativeArray<CoroutineState> AllCoroutineStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		[ReadOnly]
		public NativeArray<float> AllNextUpdateTimes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		[WriteOnly]
		public NativeArray<int> SortedIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		[WriteOnly]
		public NativeArray<int> NumberToExecute;

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9532E30", Offset = "0x9531A30", VA = "0x189532E30")]
		public static ScheduleSortJob Create(int activeCoroutines, float currentTime, NativeArray<CoroutineState> coroutineStates, NativeArray<float> nextUpdateTimes, NativeArray<int> numToExecute, NativeArray<int> unsortedIndicies, NativeArray<int> sortedIndicies, NativeArray<int> scratchLeft, NativeArray<int> scratchRight)
		{
			return default(ScheduleSortJob);
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9532E90", Offset = "0x9531A90", VA = "0x189532E90", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x95330C0", Offset = "0x9531CC0", VA = "0x1895330C0")]
		private bool LDIXKRRUUAZ(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9533340", Offset = "0x9531F40", VA = "0x189533340")]
		private void XQDJEKNMXVR(NativeArray<int> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x9533040", Offset = "0x9531C40", VA = "0x189533040")]
		private int JXVZHHAIMOO(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x9532F70", Offset = "0x9531B70", VA = "0x189532F70")]
		private void FFSVNQTLZIF(NativeArray<int> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9533100", Offset = "0x9531D00", VA = "0x189533100")]
		private void Merge(NativeArray<int> arr, int leftStart, int middle, int rightEnd)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public abstract class JQECWSPFHWX : PABQSBFBGZX, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private readonly SPOXKCARAWS QIUHOGSJUSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		protected readonly PDLRKGLSCHQ CUAVQIGNOZR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private EDYIRMURRZH[] ADYBPKGECYJ;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public static PABQSBFBGZX CFGULCWBBYG
		{
			[Cpp2IlInjected.Token(Token = "0x600017A")]
			[Cpp2IlInjected.Address(RVA = "0x95302F0", Offset = "0x952EEF0", VA = "0x1895302F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public static bool VAIKGMZRCIN
		{
			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0xB2EAD0", Offset = "0xB2D6D0", VA = "0x180B2EAD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public ScheduleQueueType CIYVDRCPROD
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xB13110", Offset = "0xB11D10", VA = "0x180B13110", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(ScheduleQueueType);
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xB1FB20", Offset = "0xB1E720", VA = "0x180B1FB20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public PDLRKGLSCHQ LPZPMSPOJAO
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0xB18810", Offset = "0xB17410", VA = "0x180B18810", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public UGECMBPSTCZ FMIEEUBUGRI
		{
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xB13140", Offset = "0xB11D40", VA = "0x180B13140", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public UGECMBPSTCZ RWIZLABXBSF
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xB13240", Offset = "0xB11E40", VA = "0x180B13240", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public UGECMBPSTCZ QPXPNGCWOPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xB13230", Offset = "0xB11E30", VA = "0x180B13230", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public UGECMBPSTCZ YZHQYJRQQGN
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xB13B30", Offset = "0xB12730", VA = "0x180B13B30", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x95301A0", Offset = "0x952EDA0", VA = "0x1895301A0")]
		public static GEUHFRHGIWS EAOPIYCXQGF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x95309F0", Offset = "0x952F5F0", VA = "0x1895309F0")]
		[UnityEngine.Scripting.Preserve]
		protected JQECWSPFHWX([Inject(null)] SPOXKCARAWS unityLifecycleEvents, [Inject(null)] PDLRKGLSCHQ schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x95304D0", Offset = "0x952F0D0", VA = "0x1895304D0", Slot = "6")]
		public GEUHFRHGIWS Run(IEnumerator<UGECMBPSTCZ> coroutineToRun)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x95304E0", Offset = "0x952F0E0", VA = "0x1895304E0", Slot = "7")]
		public GEUHFRHGIWS Run(Behaviour context, IEnumerator<UGECMBPSTCZ> coroutineToRun)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "19")]
		public abstract GEUHFRHGIWS QQMWMEXDJQI(ILIEJXHRKGW a, IEnumerator<UGECMBPSTCZ> b);

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x9530360", Offset = "0x952EF60", VA = "0x189530360", Slot = "20")]
		public virtual void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x952FB60", Offset = "0x952E760", VA = "0x18952FB60", Slot = "9")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x9530930", Offset = "0x952F530", VA = "0x189530930", Slot = "21")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x95302D0", Offset = "0x952EED0", VA = "0x1895302D0")]
		private void NYLCANXTBVV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x952FDA0", Offset = "0x952E9A0", VA = "0x18952FDA0")]
		private void DBQQERGETJN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x9530230", Offset = "0x952EE30", VA = "0x189530230")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x95302B0", Offset = "0x952EEB0", VA = "0x1895302B0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x952FB40", Offset = "0x952E740", VA = "0x18952FB40")]
		private void CWFTGYJEMWE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x95306B0", Offset = "0x952F2B0", VA = "0x1895306B0")]
		private void SRRBQXYLYFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x95309D0", Offset = "0x952F5D0", VA = "0x1895309D0")]
		private void YUFYYIHKNYR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x95306D0", Offset = "0x952F2D0", VA = "0x1895306D0", Slot = "22")]
		public virtual void TDMYBLMOZNF(ScheduleQueueType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x9530760", Offset = "0x952F360", VA = "0x189530760")]
		private void TYZZZQXJVSK(EDYIRMURRZH a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x2C66DA0", Offset = "0x2C659A0", VA = "0x182C66DA0")]
		private EDYIRMURRZH CCZLSMMHDUC(ScheduleQueueType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "23")]
		internal abstract FBVUZDXCDBW QDCGPTYGXFG(IEnumerator<UGECMBPSTCZ> a, Behaviour b, KEYBCSBBEDV c);

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(Slot = "24")]
		internal abstract EDYIRMURRZH NNMHTYCTYPX(ScheduleQueueType a);

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x952FE20", Offset = "0x952EA20", VA = "0x18952FE20", Slot = "25")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x9530250", Offset = "0x952EE50", VA = "0x189530250", Slot = "15")]
		public UGECMBPSTCZ LHQFVZYTHSB(ScheduleQueueType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x9530950", Offset = "0x952F550", VA = "0x189530950", Slot = "16")]
		public UGECMBPSTCZ YMEUJUMADYU(float a, ScheduleQueueType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x952FDC0", Offset = "0x952E9C0", VA = "0x18952FDC0", Slot = "17")]
		public UGECMBPSTCZ DNHLGKCRHUT(Func<bool> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal sealed class FBVUZDXCDBW
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private readonly KEYBCSBBEDV RXORLNVKNWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private readonly CRJQJJJSHSI KEBYUPXJULG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private readonly bool PPKPPMAULMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private string CFFWKEOMCTA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private StackTrace LUZZDWSLFIQ;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public IEnumerator<UGECMBPSTCZ> QBKYMPSDLUJ
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xB13A40", Offset = "0xB12640", VA = "0x180B13A40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xB13340", Offset = "0xB11F40", VA = "0x180B13340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public UGECMBPSTCZ HPOZLLSIWUP
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xB13A60", Offset = "0xB12660", VA = "0x180B13A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool MLNDALOJBHZ
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x952DFF0", Offset = "0x952CBF0", VA = "0x18952DFF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool HEPXNNOJNUG
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xDE26E0", Offset = "0xDE12E0", VA = "0x180DE26E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xEF2BF0", Offset = "0xEF17F0", VA = "0x180EF2BF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public string QMZMPPIFWAW
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x952DE40", Offset = "0x952CA40", VA = "0x18952DE40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public float HBMRZBHGETS
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xF9E0D0", Offset = "0xF9CCD0", VA = "0x180F9E0D0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xF9E0E0", Offset = "0xF9CCE0", VA = "0x180F9E0E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x952E1C0", Offset = "0x952CDC0", VA = "0x18952E1C0")]
		public FBVUZDXCDBW(IEnumerator<UGECMBPSTCZ> a, CRJQJJJSHSI b, KEYBCSBBEDV c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x952DB20", Offset = "0x952C720", VA = "0x18952DB20")]
		public UGECMBPSTCZ FJWWWFKWMTR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x952E150", Offset = "0x952CD50", VA = "0x18952E150")]
		public bool VRUVBKKZIKV()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x952DAD0", Offset = "0x952C6D0", VA = "0x18952DAD0")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x952E070", Offset = "0x952CC70", VA = "0x18952E070", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xFA51C0", Offset = "0xFA3DC0", VA = "0x180FA51C0")]
		[CompilerGenerated]
		private void LYJPMRWBVOJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	internal sealed class KEYBCSBBEDV : QHMKGAGJHZG, GEUHFRHGIWS, TVVSFJCWLRF, ZPYKPRNSTIB, IEnumerator, UGECMBPSTCZ, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private ScheduleQueueType WBJDEPUXPDH;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		private ScheduleQueueType TUCYZOAXELY
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0xBD4350", Offset = "0xBD2F50", VA = "0x180BD4350", Slot = "23")]
			get
			{
				return default(ScheduleQueueType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public ScheduleQueueType LYKWEKFLMEI
		{
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x11A6450", Offset = "0x11A5050", VA = "0x1811A6450")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private float FXPWLQAOXFG
		{
			[Cpp2IlInjected.Token(Token = "0x60001AE")]
			[Cpp2IlInjected.Address(RVA = "0xB64500", Offset = "0xB63100", VA = "0x180B64500", Slot = "25")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool RCINKPZYOIX
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0xB5DE90", Offset = "0xB5CA90", VA = "0x180B5DE90", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x9531540", Offset = "0x9530140", VA = "0x189531540", Slot = "24")]
		private bool ETEEBPVOQYW()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x9531530", Offset = "0x9530130", VA = "0x189531530", Slot = "27")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x9531560", Offset = "0x9530160", VA = "0x189531560")]
		public KEYBCSBBEDV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	internal enum TickResult : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		Remove,
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		Reinsert,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		NextUpdateChanged
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	internal sealed class EDYIRMURRZH : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000056")]
		public enum SubQueue
		{
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			Immediate,
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			Future
		}

		[Cpp2IlInjected.Token(Token = "0x2000057")]
		public struct ReinsertBuffer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public ScheduleQueueType QueueType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public SubQueue SubQueue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public List<FBVUZDXCDBW> Coroutines;
		}

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private static readonly SubQueue[] WNCEPMDAFEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly ScheduleQueueType IBRYPWEISMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private bool SOEQAVRWQGT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private readonly FBVUZDXCDBW[] PIXMZCYSFBW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private readonly List<FBVUZDXCDBW> CPDSTJUTWOB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private readonly Stack<int> VRCTDDMQGBQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly List<FBVUZDXCDBW> RVJTUXJFUAR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly Stack<int> PNLEFPDFJUK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private readonly IADLVEUHJEF NRWPKFGIQWI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private bool DHCTXBRXEBH;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public ReinsertBuffer[,] QATIYVQIMQI
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0xB13230", Offset = "0xB11E30", VA = "0x180B13230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x952CB50", Offset = "0x952B750", VA = "0x18952CB50")]
		public EDYIRMURRZH(ScheduleQueueType a, IADLVEUHJEF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x952BC60", Offset = "0x952A860", VA = "0x18952BC60")]
		public void LSBGDAYQMGK(FBVUZDXCDBW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x952BD20", Offset = "0x952A920", VA = "0x18952BD20")]
		public void MEHYVXDUQBA(IList<FBVUZDXCDBW> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x952C010", Offset = "0x952AC10", VA = "0x18952C010")]
		public void RHHRDCGCPDC(IList<FBVUZDXCDBW> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x952B850", Offset = "0x952A450", VA = "0x18952B850")]
		private void HBXLUNHHGDR(FBVUZDXCDBW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x952B9A0", Offset = "0x952A5A0", VA = "0x18952B9A0")]
		private void HPOQBOBPBDR(IList<FBVUZDXCDBW> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x952C300", Offset = "0x952AF00", VA = "0x18952C300")]
		private TickResult SUZVAZKNDJY(FBVUZDXCDBW a)
		{
			return default(TickResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x952C560", Offset = "0x952B160", VA = "0x18952C560")]
		public void Update(float currentTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x952B540", Offset = "0x952A140", VA = "0x18952B540")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x952C6D0", Offset = "0x952B2D0", VA = "0x18952C6D0")]
		private void XCDLFGLLFQK(List<FBVUZDXCDBW> a, Stack<int> b, bool c, float d = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x952B730", Offset = "0x952A330", VA = "0x18952B730", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x952BB20", Offset = "0x952A720", VA = "0x18952BB20")]
		private void JKRVCGBWPUC(List<FBVUZDXCDBW> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	internal class LQEZLLFYAIP : IADLVEUHJEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "4")]
		public void MQFTDXSDXRO(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
		public void FORTQJLQOLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
		public LQEZLLFYAIP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	internal class FWZJTTEKJUS : CRJQJJJSHSI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private readonly Behaviour ETBYQANLNUA;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public string QMZMPPIFWAW
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x952F100", Offset = "0x952DD00", VA = "0x18952F100", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool SGZBYYBIKJN
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x952F0B0", Offset = "0x952DCB0", VA = "0x18952F0B0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool VULLGOQQXAN
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x952F090", Offset = "0x952DC90", VA = "0x18952F090", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		public FWZJTTEKJUS(Behaviour a)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__3908136882
{
	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x95385E0", Offset = "0x95371E0", VA = "0x1895385E0")]
	public static void TGIQTAWGCFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x95385D0", Offset = "0x95371D0", VA = "0x1895385D0")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	public static void EarlyInit()
	{
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
