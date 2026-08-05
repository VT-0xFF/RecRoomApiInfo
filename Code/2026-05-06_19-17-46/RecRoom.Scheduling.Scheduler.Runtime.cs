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
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD007A0", Offset = "0xCFF1A0", VA = "0x180D007A0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD007E0", Offset = "0xCFF1E0", VA = "0x180D007E0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA366970", Offset = "0xA365370", VA = "0x18A366970", Slot = "4")]
		public override void GZVUEGYMGMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA36F2D0", Offset = "0xA36DCD0", VA = "0x18A36F2D0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x29FAE60", Offset = "0x29F9860", VA = "0x1829FAE60")]
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
			private sealed class KDEBKHUDUUH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000007")]
				public OUINWLIQNJX.WrapperKey WBDMRGPRNOV;

				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
				public KDEBKHUDUUH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0xA365D60", Offset = "0xA364760", VA = "0x18A365D60")]
				internal void LSAIOEGCECZ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public static IDisposable frameScope;

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xA36DD60", Offset = "0xA36C760", VA = "0x18A36DD60")]
			public static PlayerLoopSystem QJHRTBDRRER(OUINWLIQNJX.WrapperKey a)
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
			private sealed class VXVANLUKZAY
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400000A")]
				public OUINWLIQNJX.WrapperKey WBDMRGPRNOV;

				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
				public VXVANLUKZAY()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0xA36D990", Offset = "0xA36C390", VA = "0x18A36D990")]
				internal void LSAIOEGCECZ()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xA36DC40", Offset = "0xA36C640", VA = "0x18A36DC40")]
			public static PlayerLoopSystem QJHRTBDRRER(OUINWLIQNJX.WrapperKey a)
			{
				return default(PlayerLoopSystem);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static readonly Log GLGEGNAUXIQ;

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA35EE50", Offset = "0xA35D850", VA = "0x18A35EE50")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		public static void AppStart()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA35F030", Offset = "0xA35DA30", VA = "0x18A35F030")]
		private static void GUODZFOMDSH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA360100", Offset = "0xA35EB00", VA = "0x18A360100")]
		private static void WMLVYJHXGIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA35FCA0", Offset = "0xA35E6A0", VA = "0x18A35FCA0")]
		private static void UPZNRAHSWMS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA35F080", Offset = "0xA35DA80", VA = "0x18A35F080")]
		private static void IGKZWGIXAYO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x38C9D90", Offset = "0x38C8790", VA = "0x1838C9D90")]
		private static (PlayerLoopSystem, PlayerLoopSystems.UpdateSingleSystem) Insert<T>()
		{
			return default((PlayerLoopSystem, PlayerLoopSystems.UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0xA35FC00", Offset = "0xA35E600", VA = "0x18A35FC00")]
		private static (PlayerLoopSystem, PlayerLoopSystems.UpdateSingleSystem) Insert(PlayerLoopSystem system)
		{
			return default((PlayerLoopSystem, PlayerLoopSystems.UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x38C9D90", Offset = "0x38C8790", VA = "0x1838C9D90")]
		private static (PlayerLoopSystem, PlayerLoopSystems.UpdateSingleSystem) Remove<T>()
		{
			return default((PlayerLoopSystem, PlayerLoopSystems.UpdateSingleSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x38C9C10", Offset = "0x38C8610", VA = "0x1838C9C10")]
		public static (Type, Type, PlayerLoopSystem, PlayerLoopSystem) GLOTKAQKDIG<a, b>(OUINWLIQNJX.WrapperKey a)
		{
			return default((Type, Type, PlayerLoopSystem, PlayerLoopSystem));
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA35EED0", Offset = "0xA35D8D0", VA = "0x18A35EED0")]
		public static (Type, Type, PlayerLoopSystem, PlayerLoopSystem) GLOTKAQKDIG(OUINWLIQNJX.WrapperKey a, Type b, Type c)
		{
			return default((Type, Type, PlayerLoopSystem, PlayerLoopSystem));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public static class OUINWLIQNJX
	{
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public enum WrapperKey
		{
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			Update,
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			SchedulerUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			PostUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			FixedUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			NetworkReceive,
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			NetworkSend,
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			RigidbodyExLateUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			LateUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			PreRenderUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			LatePreRenderUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			PhysicsFixedUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			PhysicsUpdate,
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			SendFrameStarted,
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			FinishFrameRendering,
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			PhysicsResetInterpolatedPosition,
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			FullPlayerLoop,
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			OMPreGameplayUpdate,
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			OMPrePhysicsFixedUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			OMPostPhysicsFixedUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			OMPostGameplayUpdate,
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			OMPreNetworkReceive,
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			OMNetworkReceive,
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			OMPostNetworkReceive,
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			OMNetworkSend,
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			OMPreRenderSystem,
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			OMPostLateUpdate
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public class HKGDBBKKKFD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public readonly WrapperKey TIKJDVBBURW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public readonly XMLSGJQBGFB UGZDRBVWLYY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private long QTOVLNAWDNC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private long OSDDSURFMLV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public long MULXZHCCEDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public int ZIQGIYIAAHD;

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA3645A0", Offset = "0xA362FA0", VA = "0x18A3645A0")]
			public HKGDBBKKKFD(WrapperKey a, int b = 90)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xA3644A0", Offset = "0xA362EA0", VA = "0x18A3644A0")]
			public void OBVRKBTRKFE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA364450", Offset = "0xA362E50", VA = "0x18A364450")]
			public void CNRREGHDXZH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xA3644C0", Offset = "0xA362EC0", VA = "0x18A3644C0")]
			public void WPQGOAESYSI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public static WrapperKey[] ZYZYEJQCMMZ;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static HKGDBBKKKFD[] MPOGUNSNNDB;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xA366C30", Offset = "0xA365630", VA = "0x18A366C30")]
		public static HKGDBBKKKFD ZUAPCBYHWGZ(WrapperKey a, int b = 90)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA366B10", Offset = "0xA365510", VA = "0x18A366B10")]
		public static HKGDBBKKKFD BEPRBAXKAVD(WrapperKey a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0xA366B80", Offset = "0xA365580", VA = "0x18A366B80")]
		public static void FYBMVSAAKKM()
		{
		}
	}
}
namespace RecRoom.Utils
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public static class LYSEHTFNAHI
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private interface CZFTOQGVEDY
		{
			[Cpp2IlInjected.Token(Token = "0x17000002")]
			bool JXAULVHERXX
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			void Complete();
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private class RCWDNKSXOEG : CZFTOQGVEDY
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private readonly Action DVPPDHBXRUI;

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public bool JXAULVHERXX
			{
				[Cpp2IlInjected.Token(Token = "0x6000030")]
				[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0xCE33E0", Offset = "0xCE1DE0", VA = "0x180CE33E0")]
			public RCWDNKSXOEG(Action a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x135CFC0", Offset = "0x135B9C0", VA = "0x18135CFC0", Slot = "5")]
			public void Complete()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly List<CZFTOQGVEDY> AIEJIAEJEYB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		private static bool UUFQBGHITMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA366480", Offset = "0xA364E80", VA = "0x18A366480")]
		public static void RQGJLKRDBZL(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA366510", Offset = "0xA364F10", VA = "0x18A366510")]
		private static void WVMEBPVIZTJ(CZFTOQGVEDY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA366040", Offset = "0xA364A40", VA = "0x18A366040")]
		private static void JJEMTLZOWNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA366340", Offset = "0xA364D40", VA = "0x18A366340")]
		private static void OIWWKHIFBBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA3667D0", Offset = "0xA3651D0", VA = "0x18A3667D0")]
		private static void XWPOSAJAXOO()
		{
		}
	}
}
namespace RecRoom.Core
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public static class YHDSEUUXPQT
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0xA36F000", Offset = "0xA36DA00", VA = "0x18A36F000")]
		public static IDisposable QLRSWEXXOOO(this OHMKRHMOYNJ a, float b, Action<float> c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0xA36F080", Offset = "0xA36DA80", VA = "0x18A36F080")]
		public static IDisposable RDFIACDXYRY(this OHMKRHMOYNJ a, Action<float> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0xA36EF80", Offset = "0xA36D980", VA = "0x18A36EF80")]
		public static IDisposable OIBRTHNHIPA(this OHMKRHMOYNJ a, Action<float> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public static class YVQOWUGDJRG
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x412A210", Offset = "0x4128C10", VA = "0x18412A210")]
		[MustUseReturnValue]
		public static IDisposable SOLNCALAXOY<a>(this a a, Action b, ScheduleQueueType c, bool d = true) where a : MonoBehaviour, PBUFILHXHAU
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x412A070", Offset = "0x4128A70", VA = "0x18412A070")]
		[MustUseReturnValue]
		public static IDisposable SOLNCALAXOY<b>(this b a, Action<float> b, ScheduleQueueType c, bool d = true) where b : MonoBehaviour, PBUFILHXHAU
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x412A420", Offset = "0x4128E20", VA = "0x18412A420")]
		[MustUseReturnValue]
		public static IDisposable Update<T>(this T behaviour, Action update, bool validateContext = true) where T : MonoBehaviour, PBUFILHXHAU
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4129930", Offset = "0x4128330", VA = "0x184129930")]
		[MustUseReturnValue]
		public static IDisposable FixedUpdate<T>(this T behaviour, Action update, bool validateContext = true) where T : MonoBehaviour, PBUFILHXHAU
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4129780", Offset = "0x4128180", VA = "0x184129780")]
		[MustUseReturnValue]
		public static IDisposable FixedUpdate<T>(this T behaviour, Action<float> update, bool validateContext = true) where T : MonoBehaviour, PBUFILHXHAU
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x4129CD0", Offset = "0x41286D0", VA = "0x184129CD0")]
		[MustUseReturnValue]
		public static IDisposable LateUpdate<T>(this T behaviour, Action update, bool validateContext = true) where T : MonoBehaviour, PBUFILHXHAU
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x412A3B0", Offset = "0x4128DB0", VA = "0x18412A3B0")]
		[MustUseReturnValue]
		public static IDisposable ULNVRITYTPT<c>(this c a, Action b, bool c = true) where c : MonoBehaviour, PBUFILHXHAU
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4129B60", Offset = "0x4128560", VA = "0x184129B60")]
		[MustUseReturnValue]
		public static IDisposable KLAGENJUNFM<d>(this d a, Action b, bool c = true) where d : MonoBehaviour, PBUFILHXHAU
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4129B20", Offset = "0x4128520", VA = "0x184129B20")]
		[MustUseReturnValue]
		public static IDisposable JDWONOIYEXR<f>(this f a, float b, Action<float> c, ScheduleQueueType d, bool e = true, bool f = true) where f : MonoBehaviour, PBUFILHXHAU
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA36F100", Offset = "0xA36DB00", VA = "0x18A36F100")]
		[MustUseReturnValue]
		public static IDisposable JDWONOIYEXR(this MonoBehaviour a, PBUFILHXHAU b, float c, Action<float> d, ScheduleQueueType e, bool f = true, bool g = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4129E40", Offset = "0x4128840", VA = "0x184129E40")]
		[MustUseReturnValue]
		public static IDisposable QEGFTNGVXHN<g>(this g a, float b, Action<float> c, ScheduleQueueType d, bool e = true, bool f = true) where g : MonoBehaviour, PBUFILHXHAU
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4129C50", Offset = "0x4128650", VA = "0x184129C50")]
		[MustUseReturnValue]
		public static IDisposable LRJOZNUOPKI<h>(this h a, float b, Action<float> c, bool d = true, bool e = true) where h : MonoBehaviour, PBUFILHXHAU
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4129FF0", Offset = "0x41289F0", VA = "0x184129FF0")]
		[MustUseReturnValue]
		public static IDisposable QNAJAXAYCET<i>(this i a, Action<float> b, bool c = true, bool d = true) where i : MonoBehaviour, PBUFILHXHAU
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x4129BD0", Offset = "0x41285D0", VA = "0x184129BD0")]
		[MustUseReturnValue]
		public static IDisposable KUZXOXBGUWG<j>(this j a, Action<float> b, bool c = true, bool d = true) where j : MonoBehaviour, PBUFILHXHAU
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x4129DC0", Offset = "0x41287C0", VA = "0x184129DC0")]
		[MustUseReturnValue]
		public static IDisposable PIIZHXYRXSH<k>(this k a, Action<float> b, bool c = true, bool d = true) where k : MonoBehaviour, PBUFILHXHAU
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x4129AA0", Offset = "0x41284A0", VA = "0x184129AA0")]
		[MustUseReturnValue]
		public static IDisposable JDEBXSMVHQU<l>(this l a, Action<float> b, bool c = true, bool d = true) where l : MonoBehaviour, PBUFILHXHAU
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4129A20", Offset = "0x4128420", VA = "0x184129A20")]
		[MustUseReturnValue]
		public static IDisposable IEQQXXRBDAE<m>(this m a, Action<float> b, bool c = true, bool d = true) where m : MonoBehaviour, PBUFILHXHAU
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x41299A0", Offset = "0x41283A0", VA = "0x1841299A0")]
		[MustUseReturnValue]
		public static IDisposable GFLZUCCXFMQ<n>(this n a, Action<float> b, bool c = true, bool d = true) where n : MonoBehaviour, PBUFILHXHAU
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x4129700", Offset = "0x4128100", VA = "0x184129700")]
		[MustUseReturnValue]
		public static IDisposable EPODHXXHQRU<q>(this q a, Action<float> b, bool c = true, bool d = true) where q : MonoBehaviour, PBUFILHXHAU
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x4129680", Offset = "0x4128080", VA = "0x184129680")]
		[MustUseReturnValue]
		public static IDisposable CRWRRMPXAXW<s>(this s a, float b, Action<float> c, bool d = true, bool e = true) where s : MonoBehaviour, PBUFILHXHAU
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4129D40", Offset = "0x4128740", VA = "0x184129D40")]
		[MustUseReturnValue]
		public static IDisposable OJTEPRWHLII<u>(this u a, Action<float> b, bool c = true, bool d = true) where u : MonoBehaviour, PBUFILHXHAU
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class IPVHOTSXPKO
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		[CompilerGenerated]
		private sealed class SMKFEFTQJID : IEnumerator<KHZACSYKHRO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private KHZACSYKHRO BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public ScheduleQueueType BZTMNTKMKMR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public Action PVENCTAKJED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private LQYBXSHKYFJ QLROSTUTOLE;

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			private KHZACSYKHRO MMVFURGWOML
			{
				[Cpp2IlInjected.Token(Token = "0x6000053")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x6000055")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
			[DebuggerHidden]
			public SMKFEFTQJID(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA36AE20", Offset = "0xA369820", VA = "0x18A36AE20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA36AEF0", Offset = "0xA3698F0", VA = "0x18A36AEF0", Slot = "8")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private sealed class SMEYGYZSZWU : IEnumerator<KHZACSYKHRO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			private KHZACSYKHRO BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public ScheduleQueueType BZTMNTKMKMR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public Action<float> PVENCTAKJED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private LQYBXSHKYFJ QLROSTUTOLE;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			private KHZACSYKHRO MMVFURGWOML
			{
				[Cpp2IlInjected.Token(Token = "0x6000059")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x600005B")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
			[DebuggerHidden]
			public SMEYGYZSZWU(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA36AD00", Offset = "0xA369700", VA = "0x18A36AD00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xA36ADE0", Offset = "0xA3697E0", VA = "0x18A36ADE0", Slot = "8")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0xA364FE0", Offset = "0xA3639E0", VA = "0x18A364FE0")]
		public static NDLSPIRTFEP SOLNCALAXOY(Action a, ScheduleQueueType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xA365060", Offset = "0xA363A60", VA = "0x18A365060")]
		public static NDLSPIRTFEP SOLNCALAXOY(Behaviour a, Action b, ScheduleQueueType c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA364F00", Offset = "0xA363900", VA = "0x18A364F00")]
		public static NDLSPIRTFEP SOLNCALAXOY(Behaviour a, Action<float> b, ScheduleQueueType c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA364E00", Offset = "0xA363800", VA = "0x18A364E00")]
		[IteratorStateMachine(typeof(SMKFEFTQJID))]
		private static IEnumerator<KHZACSYKHRO> LUDZCPYUVXF(ScheduleQueueType a, Action b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0xA364E80", Offset = "0xA363880", VA = "0x18A364E80")]
		[IteratorStateMachine(typeof(SMEYGYZSZWU))]
		private static IEnumerator<KHZACSYKHRO> LUDZCPYUVXF(ScheduleQueueType a, Action<float> b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class FAHGIEANZKD : INotifyCompletion
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		[CompilerGenerated]
		private sealed class KCMPDUAEQSC : IEnumerator<KHZACSYKHRO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private KHZACSYKHRO BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public FAHGIEANZKD IRZLODQIRHI;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private KHZACSYKHRO MMVFURGWOML
			{
				[Cpp2IlInjected.Token(Token = "0x6000064")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x6000066")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
			[DebuggerHidden]
			public KCMPDUAEQSC(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xA365C90", Offset = "0xA364690", VA = "0x18A365C90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0xA365D20", Offset = "0xA364720", VA = "0x18A365D20", Slot = "8")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private readonly ScheduleQueueType IIUGFEPFFQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private Action WKYYEKWJRXS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool CQZPXNDDZTV;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool FCMKGLSMPJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xCD7520", Offset = "0xCD5F20", VA = "0x180CD7520")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0xA363E60", Offset = "0xA362860", VA = "0x18A363E60")]
		public FAHGIEANZKD(ScheduleQueueType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0xA363DF0", Offset = "0xA3627F0", VA = "0x18A363DF0")]
		[IteratorStateMachine(typeof(KCMPDUAEQSC))]
		private IEnumerator<KHZACSYKHRO> QRWIJDEZTXQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xA363D50", Offset = "0xA362750", VA = "0x18A363D50", Slot = "4")]
		public void OnCompleted(Action continuation)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190")]
		public void YVIESLQOYIL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public static class TLLGBOTTPKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA36B4E0", Offset = "0xA369EE0", VA = "0x18A36B4E0")]
		public static FAHGIEANZKD UXGKLJIPXNN(this ScheduleQueueType a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public static class PMJKOQCLCZW
	{
		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class AKFLNZECOMT : IEnumerator<KHZACSYKHRO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			private KHZACSYKHRO BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public UHVWWHPURDH ZNEBITBTULN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public Action<float> PVENCTAKJED;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private KHZACSYKHRO MMVFURGWOML
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
			[DebuggerHidden]
			public AKFLNZECOMT(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xA35DB60", Offset = "0xA35C560", VA = "0x18A35DB60", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA35DBE0", Offset = "0xA35C5E0", VA = "0x18A35DBE0", Slot = "8")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA3687F0", Offset = "0xA3671F0", VA = "0x18A3687F0")]
		public static NDLSPIRTFEP SOLNCALAXOY(float a, Action<float> b, ScheduleQueueType c, bool d = true, [Optional] GUZFZPTTQMS e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xA368720", Offset = "0xA367120", VA = "0x18A368720")]
		public static NDLSPIRTFEP SOLNCALAXOY(MonoBehaviour a, float b, Action<float> c, ScheduleQueueType d, bool e = true, [Optional] GUZFZPTTQMS f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0xA3685A0", Offset = "0xA366FA0", VA = "0x18A3685A0")]
		public static NDLSPIRTFEP QMZVDBLWESG(MonoBehaviour a, float b, Action<float> c, ScheduleQueueType d, bool e = true, [Optional] GUZFZPTTQMS f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA3683C0", Offset = "0xA366DC0", VA = "0x18A3683C0")]
		public static NDLSPIRTFEP KXSYCSOTDRA(OHMKRHMOYNJ a, float b, Action<float> c, ScheduleQueueType d, bool e = true, [Optional] GUZFZPTTQMS f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0xA368490", Offset = "0xA366E90", VA = "0x18A368490")]
		private static IEnumerator<KHZACSYKHRO> LUDZCPYUVXF(IZYCAHMLASH a, float b, ScheduleQueueType c, Action<float> d, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0xA368540", Offset = "0xA366F40", VA = "0x18A368540")]
		private static IEnumerator<KHZACSYKHRO> MRFYVWFRXBP(IZYCAHMLASH a, float b, ScheduleQueueType c, Action<float> d, bool e = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA368690", Offset = "0xA367090", VA = "0x18A368690")]
		[IteratorStateMachine(typeof(AKFLNZECOMT))]
		private static IEnumerator<KHZACSYKHRO> QXIJYWCDLTZ(UHVWWHPURDH a, float b, ScheduleQueueType c, Action<float> d)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public static class BIDPFGEFYZS
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class AOENYDZCYXC : IEnumerator<KHZACSYKHRO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			private KHZACSYKHRO BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public ScheduleQueueType IIUGFEPFFQN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public Func<bool> KRDMYWOMGSH;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private KHZACSYKHRO MMVFURGWOML
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
			[DebuggerHidden]
			public AOENYDZCYXC(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xA35DC20", Offset = "0xA35C620", VA = "0x18A35DC20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xA35DCD0", Offset = "0xA35C6D0", VA = "0x18A35DCD0", Slot = "8")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xA35EBE0", Offset = "0xA35D5E0", VA = "0x18A35EBE0")]
		[IteratorStateMachine(typeof(AOENYDZCYXC))]
		private static IEnumerator<KHZACSYKHRO> OCYTTNSMIKM(ScheduleQueueType a, Func<bool> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0xA35EC60", Offset = "0xA35D660", VA = "0x18A35EC60")]
		public static NDLSPIRTFEP VZRAQULTEDP(this MonoBehaviour a, Func<bool> b, ScheduleQueueType c = ScheduleQueueType.Update)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public static class EJQDFDJMXEN
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private sealed class KDHQSVBUCLM : IEnumerator<KHZACSYKHRO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			private KHZACSYKHRO BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			public float LGUNYXIWFMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			public ScheduleQueueType BZTMNTKMKMR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public Action DANUYMCPHOK;

			[Cpp2IlInjected.Token(Token = "0x1700000F")]
			private KHZACSYKHRO MMVFURGWOML
			{
				[Cpp2IlInjected.Token(Token = "0x6000092")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000010")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x6000094")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
			[DebuggerHidden]
			public KDHQSVBUCLM(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0xA365F90", Offset = "0xA364990", VA = "0x18A365F90", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xA366000", Offset = "0xA364A00", VA = "0x18A366000", Slot = "8")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		[CompilerGenerated]
		private sealed class FWIKRPISKGG<a> : IEnumerator<KHZACSYKHRO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			private KHZACSYKHRO BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			public float LGUNYXIWFMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public ScheduleQueueType BZTMNTKMKMR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			public Action<a> DANUYMCPHOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public a QVIEKQHPMXY;

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			private KHZACSYKHRO MMVFURGWOML
			{
				[Cpp2IlInjected.Token(Token = "0x6000098")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x600009A")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
			[DebuggerHidden]
			public FWIKRPISKGG(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0x630ABE0", Offset = "0x63095E0", VA = "0x18630ABE0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x4F08450", Offset = "0x4F06E50", VA = "0x184F08450", Slot = "8")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		[CompilerGenerated]
		private sealed class FZODQSVCYBC : IEnumerator<KHZACSYKHRO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private KHZACSYKHRO BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public float LGUNYXIWFMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public ScheduleQueueType BZTMNTKMKMR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public Action DANUYMCPHOK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			private KHZACSYKHRO UHYJBZFCOVA;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private KHZACSYKHRO MMVFURGWOML
			{
				[Cpp2IlInjected.Token(Token = "0x600009E")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x60000A0")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
			[DebuggerHidden]
			public FZODQSVCYBC(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0xA363F30", Offset = "0xA362930", VA = "0x18A363F30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0xA363FC0", Offset = "0xA3629C0", VA = "0x18A363FC0", Slot = "8")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xA363300", Offset = "0xA361D00", VA = "0x18A363300")]
		[IteratorStateMachine(typeof(KDHQSVBUCLM))]
		private static IEnumerator<KHZACSYKHRO> QRWIJDEZTXQ(float a, ScheduleQueueType b, Action c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x3928940", Offset = "0x3927340", VA = "0x183928940")]
		[IteratorStateMachine(typeof(FWIKRPISKGG<>))]
		private static IEnumerator<KHZACSYKHRO> QRWIJDEZTXQ<a>(float a, ScheduleQueueType b, Action<a> c, a d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0xA363570", Offset = "0xA361F70", VA = "0x18A363570")]
		[IteratorStateMachine(typeof(FZODQSVCYBC))]
		private static IEnumerator<KHZACSYKHRO> XRURVNLSWTE(float a, ScheduleQueueType b, Action c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0xA362E20", Offset = "0xA361820", VA = "0x18A362E20")]
		public static IDisposable JKGEEDKKCGM(this MonoBehaviour a, float b, Action c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xA363600", Offset = "0xA362000", VA = "0x18A363600")]
		public static NDLSPIRTFEP YEKLNJIYPXA(this MonoBehaviour a, float b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xA362F00", Offset = "0xA361900", VA = "0x18A362F00")]
		public static NDLSPIRTFEP JKGEEDKKCGM(this MonoBehaviour a, float b, ScheduleQueueType c, Action d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xA362D80", Offset = "0xA361780", VA = "0x18A362D80")]
		public static NDLSPIRTFEP HXTBSWGVTXQ(this MonoBehaviour a, Action b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x3928630", Offset = "0x3927030", VA = "0x183928630")]
		public static NDLSPIRTFEP HXTBSWGVTXQ<b>(this MonoBehaviour a, Action<b> b, b c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0xA3631D0", Offset = "0xA361BD0", VA = "0x18A3631D0")]
		public static NDLSPIRTFEP OGDYDEJUKXY(this MonoBehaviour a, Action b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0xA363130", Offset = "0xA361B30", VA = "0x18A363130")]
		public static NDLSPIRTFEP NHSHEGAHVPE(this MonoBehaviour a, Action b, [Optional] GUZFZPTTQMS c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0xA362CE0", Offset = "0xA3616E0", VA = "0x18A362CE0")]
		public static NDLSPIRTFEP CAKUTGHBVNW(this MonoBehaviour a, Action b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0xA362FF0", Offset = "0xA3619F0", VA = "0x18A362FF0")]
		public static NDLSPIRTFEP MBTHZDODSUC(this MonoBehaviour a, Action b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0xA363430", Offset = "0xA361E30", VA = "0x18A363430")]
		public static NDLSPIRTFEP RCZVMDBRJHA(MonoBehaviour a, ScheduleQueueType b, Action c, [Optional] GUZFZPTTQMS d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3928BA0", Offset = "0x39275A0", VA = "0x183928BA0")]
		public static NDLSPIRTFEP RCZVMDBRJHA<h>(MonoBehaviour a, ScheduleQueueType b, Action<h> c, h d, [Optional] GUZFZPTTQMS e)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0xA363270", Offset = "0xA361C70", VA = "0x18A363270")]
		public static NDLSPIRTFEP PNHUHBCHHDG(this MonoBehaviour a, float b, Action c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xA3634D0", Offset = "0xA361ED0", VA = "0x18A3634D0")]
		public static NDLSPIRTFEP TTVJCPZZDQI(this MonoBehaviour a, float b, Action c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xA363090", Offset = "0xA361A90", VA = "0x18A363090")]
		public static NDLSPIRTFEP MZVWOXTJWYU(this MonoBehaviour a, float b, Action c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xA363390", Offset = "0xA361D90", VA = "0x18A363390")]
		public static NDLSPIRTFEP QTWTMVAHUYG(this MonoBehaviour a, float b, Action c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class PIMVDXIZVRH : QHISMEANRUZ, IEnumerable<QHISMEANRUZ>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly List<QHISMEANRUZ> CMXEQIWTOHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private bool IPEWARWVUIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private Action ZQJAJLCYDPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private bool WPQWKNHNDDT;

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public bool LYKOXAIYTSF
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0xA3681F0", Offset = "0xA366BF0", VA = "0x18A3681F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action AVYOLWSTZYT
		{
			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xA368150", Offset = "0xA366B50", VA = "0x18A368150", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0xA367D20", Offset = "0xA366720", VA = "0x18A367D20", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0xA368320", Offset = "0xA366D20", VA = "0x18A368320")]
		public PIMVDXIZVRH([Optional] Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0xA367A50", Offset = "0xA366450", VA = "0x18A367A50")]
		public void Add(QHISMEANRUZ limiter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0xA367BC0", Offset = "0xA3665C0", VA = "0x18A367BC0")]
		private void BROJRWAQJUC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0xA367E40", Offset = "0xA366840", VA = "0x18A367E40", Slot = "7")]
		public bool IYWGARHGYKL(bool a = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0xA367E50", Offset = "0xA366850", VA = "0x18A367E50", Slot = "8")]
		public bool IYWGARHGYKL(Action a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0xA367DC0", Offset = "0xA3667C0", VA = "0x18A367DC0", Slot = "9")]
		public IEnumerator<QHISMEANRUZ> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0xA367DC0", Offset = "0xA3667C0", VA = "0x18A367DC0", Slot = "10")]
		private IEnumerator SJAOULXGYMP()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public class JEQVLJQRIEJ : EQKFSXXCPUF
	{
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class VUGRTXXDLRI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public JEQVLJQRIEJ IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public Action DVPPDHBXRUI;

			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public VUGRTXXDLRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0xA365C60", Offset = "0xA364660", VA = "0x18A365C60")]
			internal void XENLXYEJWFX()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class JZPSQTWWHKR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public JEQVLJQRIEJ IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public Action DVPPDHBXRUI;

			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public JZPSQTWWHKR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0xA365C60", Offset = "0xA364660", VA = "0x18A365C60")]
			internal void OYXFYAMNKIM()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private readonly float AZRQKSEMCSA;

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0xA35DD50", Offset = "0xA35C750", VA = "0x18A35DD50")]
		public JEQVLJQRIEJ(Behaviour a, float b, [Optional] Action c, [Optional] GUZFZPTTQMS d, [Optional] IZYCAHMLASH e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0xA365B50", Offset = "0xA364550", VA = "0x18A365B50", Slot = "9")]
		protected override bool GATHRHPHRAV(Action a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0xA365A40", Offset = "0xA364440", VA = "0x18A365A40", Slot = "10")]
		protected override bool FYHAQZGQJZA(Action a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public interface QHISMEANRUZ
	{
		[Cpp2IlInjected.Token(Token = "0x17000016")]
		bool LYKOXAIYTSF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x14000002")]
		event Action AVYOLWSTZYT;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool IYWGARHGYKL(bool a = false);

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(Slot = "4")]
		bool IYWGARHGYKL(Action a, bool b = false);
	}
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public abstract class EQKFSXXCPUF : QHISMEANRUZ
	{
		[Cpp2IlInjected.Token(Token = "0x200002B")]
		[CompilerGenerated]
		private sealed class BRFLTUPULUQ : IEnumerator<KHZACSYKHRO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400006C")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private KHZACSYKHRO BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public EQKFSXXCPUF IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public float AJUNQHTRFDA;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private KHZACSYKHRO MMVFURGWOML
			{
				[Cpp2IlInjected.Token(Token = "0x60000CB")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x60000CD")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
			[DebuggerHidden]
			public BRFLTUPULUQ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0xA35ED40", Offset = "0xA35D740", VA = "0x18A35ED40", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0xA35EE10", Offset = "0xA35D810", VA = "0x18A35EE10", Slot = "8")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private readonly Behaviour DGWPTYIAQJX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private readonly Action ZQJAJLCYDPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private LEVOMZEPWVK PGDKYVEBVCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly GUZFZPTTQMS TIZXXEFOSPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		protected readonly IZYCAHMLASH AXBVZNQJOJO;

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public bool LYKOXAIYTSF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xE19A30", Offset = "0xE18430", VA = "0x180E19A30", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000003")]
		public event Action AVYOLWSTZYT
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xA363810", Offset = "0xA362210", VA = "0x18A363810", Slot = "4")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xA363690", Offset = "0xA362090", VA = "0x18A363690", Slot = "5")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xA363C20", Offset = "0xA362620", VA = "0x18A363C20")]
		protected EQKFSXXCPUF(Behaviour a, [Optional] Action b, [Optional] GUZFZPTTQMS c, [Optional] IZYCAHMLASH d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0xA363750", Offset = "0xA362150", VA = "0x18A363750", Slot = "7")]
		public bool IYWGARHGYKL(bool a = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0xA3637B0", Offset = "0xA3621B0", VA = "0x18A3637B0", Slot = "8")]
		public bool IYWGARHGYKL(Action a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(Slot = "9")]
		protected abstract bool GATHRHPHRAV(Action a);

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract bool FYHAQZGQJZA(Action a);

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xA363730", Offset = "0xA362130", VA = "0x18A363730")]
		protected void IWOQVMEZXFG(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xA363970", Offset = "0xA362370", VA = "0x18A363970")]
		protected NKOSDRYVRPY QOJMXJAVSQG(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0xA363BA0", Offset = "0xA3625A0", VA = "0x18A363BA0")]
		private void XEUUUMWOJWV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0xA3638F0", Offset = "0xA3622F0", VA = "0x18A3638F0")]
		[IteratorStateMachine(typeof(BRFLTUPULUQ))]
		private IEnumerator<KHZACSYKHRO> NJZQPUCVBAR(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0xA3638B0", Offset = "0xA3622B0", VA = "0x18A3638B0")]
		[CompilerGenerated]
		private void KWSICIXKVLK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class GMKQVYFXINQ : EQKFSXXCPUF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly float QKBKJNRYTOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly int QDDLXCITLCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly float HQGVDTQDPSA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly float[] DKJVFLSPKRZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private int DUHEIZTSMSB;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0xA364280", Offset = "0xA362C80", VA = "0x18A364280")]
		public GMKQVYFXINQ(Behaviour a, float b, int c, [Optional] Action d, float e = 0f, [Optional] GUZFZPTTQMS f, [Optional] IZYCAHMLASH g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "9")]
		protected override bool GATHRHPHRAV(Action a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0xA364000", Offset = "0xA362A00", VA = "0x18A364000", Slot = "10")]
		protected override bool FYHAQZGQJZA(Action a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0xA364200", Offset = "0xA362C00", VA = "0x18A364200")]
		private void YBXNRROGQIJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class ARPOFYMXMTC : EQKFSXXCPUF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private readonly float AZRQKSEMCSA;

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0xA35DD50", Offset = "0xA35C750", VA = "0x18A35DD50")]
		public ARPOFYMXMTC(Behaviour a, float b, [Optional] Action c, [Optional] GUZFZPTTQMS d, [Optional] IZYCAHMLASH e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "9")]
		protected override bool GATHRHPHRAV(Action a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0xA35DD10", Offset = "0xA35C710", VA = "0x18A35DD10", Slot = "10")]
		protected override bool FYHAQZGQJZA(Action a)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public sealed class QUTRNZWKJQW : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class AIFYUKVZYTM : IEnumerator<KHZACSYKHRO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private KHZACSYKHRO BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public Action SJORMPSTQXK;

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private KHZACSYKHRO MMVFURGWOML
			{
				[Cpp2IlInjected.Token(Token = "0x60000DE")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x60000E0")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
			[DebuggerHidden]
			public AIFYUKVZYTM(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xA35DA70", Offset = "0xA35C470", VA = "0x18A35DA70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0xA35DAE0", Offset = "0xA35C4E0", VA = "0x18A35DAE0", Slot = "8")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		private NDLSPIRTFEP IBIMSOFZQQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		private OHMKRHMOYNJ DGWPTYIAQJX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		private Action<float> UGBPNTTKDQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private ScheduleQueueType IIUGFEPFFQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private float MSLSUYPBEQV;

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0xA368EF0", Offset = "0xA3678F0", VA = "0x18A368EF0")]
		public QUTRNZWKJQW(OHMKRHMOYNJ a, float b, Action<float> c, ScheduleQueueType d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0xA368D90", Offset = "0xA367790", VA = "0x18A368D90")]
		private void UOPTNXLKPFU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0xA368C70", Offset = "0xA367670", VA = "0x18A368C70")]
		private void TWVXKSTYNLG(string a, Action b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0xA368A90", Offset = "0xA367490", VA = "0x18A368A90")]
		[IteratorStateMachine(typeof(AIFYUKVZYTM))]
		private IEnumerator<KHZACSYKHRO> HBRXUQAANYG(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0xA368A30", Offset = "0xA367430", VA = "0x18A368A30", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0xA368B00", Offset = "0xA367500", VA = "0x18A368B00")]
		[CompilerGenerated]
		private void OWENTWCQZYN(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public sealed class YGWIFDLWKGQ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		[CompilerGenerated]
		private sealed class AJQVBGFHMUX : IEnumerator<KHZACSYKHRO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			private int NXJBPMXGHVE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private KHZACSYKHRO BZAVRIIXYAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public Action SJORMPSTQXK;

			[Cpp2IlInjected.Token(Token = "0x1700001C")]
			private KHZACSYKHRO MMVFURGWOML
			{
				[Cpp2IlInjected.Token(Token = "0x60000F4")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001D")]
			private object ERGKPVHJUQY
			{
				[Cpp2IlInjected.Token(Token = "0x60000F6")]
				[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
			[DebuggerHidden]
			public AJQVBGFHMUX(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
			[DebuggerHidden]
			private void THBUUIJWZTJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0xA35DA70", Offset = "0xA35C470", VA = "0x18A35DA70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0xA35DB20", Offset = "0xA35C520", VA = "0x18A35DB20", Slot = "8")]
			[DebuggerHidden]
			private void TVBXYVYIQIO()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private NDLSPIRTFEP IBIMSOFZQQI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private MonoBehaviour KSAQHPDZGWZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private Action PVENCTAKJED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private Action<float> UGBPNTTKDQF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private ScheduleQueueType IIUGFEPFFQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private float MSLSUYPBEQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private bool GEEJFICDXMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private readonly GUZFZPTTQMS TIZXXEFOSPV;

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0xA36EA60", Offset = "0xA36D460", VA = "0x18A36EA60")]
		public YGWIFDLWKGQ(MonoBehaviour a, Action b, ScheduleQueueType c, [Optional] GUZFZPTTQMS d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0xA36EBE0", Offset = "0xA36D5E0", VA = "0x18A36EBE0")]
		public YGWIFDLWKGQ(MonoBehaviour a, Action<float> b, ScheduleQueueType c, [Optional] GUZFZPTTQMS d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA36EDA0", Offset = "0xA36D7A0", VA = "0x18A36EDA0")]
		public YGWIFDLWKGQ(MonoBehaviour a, float b, Action<float> c, ScheduleQueueType d, bool e = true, [Optional] GUZFZPTTQMS f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xF20CB0", Offset = "0xF1F6B0", VA = "0x180F20CB0")]
		private YGWIFDLWKGQ(GUZFZPTTQMS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0xA36E160", Offset = "0xA36CB60", VA = "0x18A36E160")]
		internal static YGWIFDLWKGQ HUAPTXYDFJW(MonoBehaviour a, float b, Action<float> c, ScheduleQueueType d, bool e = true, [Optional] GUZFZPTTQMS f)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xA36E410", Offset = "0xA36CE10", VA = "0x18A36E410")]
		private void SOLNCALAXOY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xA36E6F0", Offset = "0xA36D0F0", VA = "0x18A36E6F0")]
		private void UGQIECYVZYI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0xA36E860", Offset = "0xA36D260", VA = "0x18A36E860")]
		private void UOPTNXLKPFU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA36DEE0", Offset = "0xA36C8E0", VA = "0x18A36DEE0")]
		private void FBAGSZDGHCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0xA36E5D0", Offset = "0xA36CFD0", VA = "0x18A36E5D0")]
		private void TWVXKSTYNLG(string a, Action b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0xA36E0F0", Offset = "0xA36CAF0", VA = "0x18A36E0F0")]
		[IteratorStateMachine(typeof(AJQVBGFHMUX))]
		private IEnumerator<KHZACSYKHRO> HBRXUQAANYG(Action a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0xA36DE80", Offset = "0xA36C880", VA = "0x18A36DE80", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0xA36E380", Offset = "0xA36CD80", VA = "0x18A36E380")]
		[CompilerGenerated]
		private void OYLTJTRUGFL(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xA36E540", Offset = "0xA36CF40", VA = "0x18A36E540")]
		[CompilerGenerated]
		private void SVGQZNEGHTO(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xA36E060", Offset = "0xA36CA60", VA = "0x18A36E060")]
		[CompilerGenerated]
		private void GGQYWYWFIQN(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0xA36E9D0", Offset = "0xA36D3D0", VA = "0x18A36E9D0")]
		[CompilerGenerated]
		private void WGFFPTOQRTA(string a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Flags]
	internal enum CoroutineState : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		Inactive = 0,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		Running = 1,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		Cancelled = 2,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		Paused = 4
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	internal sealed class IQDWJMHQLBL : IZYCAHMLASH
	{
		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public float WIMGRXCFESD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xA3650F0", Offset = "0xA363AF0", VA = "0x18A3650F0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float BNOWTLGKQXD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0xA365190", Offset = "0xA363B90", VA = "0x18A365190", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public double YLNYDJYGFSQ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xA365100", Offset = "0xA363B00", VA = "0x18A365100", Slot = "6")]
			get
			{
				return default(double);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA365120", Offset = "0xA363B20", VA = "0x18A365120")]
		[BQDQKYYGTTM.Root]
		internal static void TDUDTGPDFOH(TFZCSWYZDKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		[UnityEngine.Scripting.Preserve]
		internal IQDWJMHQLBL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	internal interface KLYDSDJYCQU
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void RVCCMSQOKUB(string a);

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void AJHKBVYAOLT();
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal interface NMALFNJJWAN
	{
		[Cpp2IlInjected.Token(Token = "0x17000021")]
		string EREWIERIFZH
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		bool PDOLUVAGPUY
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		bool BQPURYLUXMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal class RWOGNWMZQFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public DNVJXJNSMAY MBWBJANWPWZ;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public int YPLUQTQHWQK
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0xCD5110", Offset = "0xCD3B10", VA = "0x180CD5110", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0xCDD360", Offset = "0xCDBD60", VA = "0x180CDD360")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0xA36A4E0", Offset = "0xA368EE0", VA = "0x18A36A4E0")]
		public static KHZACSYKHRO EOZEWIDNYPG(IEnumerator<KHZACSYKHRO> a, IERKCXVGQJG b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0xA36A640", Offset = "0xA369040", VA = "0x18A36A640")]
		public KHZACSYKHRO EOZEWIDNYPG(IERKCXVGQJG[] a, IEnumerator<KHZACSYKHRO>[] b, KHZACSYKHRO[] c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0xA36A4B0", Offset = "0xA368EB0", VA = "0x18A36A4B0")]
		public void IUVWSOYSMWN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0xA36A7F0", Offset = "0xA3691F0", VA = "0x18A36A7F0")]
		public void UTAJMNRCQML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0xA36A700", Offset = "0xA369100", VA = "0x18A36A700")]
		public void IWHVPFSUJBQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0xA36A4B0", Offset = "0xA368EB0", VA = "0x18A36A4B0")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public RWOGNWMZQFL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal sealed class DNVJXJNSMAY
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct JobbedInsertionData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public RWOGNWMZQFL Routine;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public OHMKRHMOYNJ Context;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public IERKCXVGQJG Promise;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public IEnumerator<KHZACSYKHRO> Coroutine;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public KHZACSYKHRO CurrentSchedule;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public CoroutineState CoroutineState;
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public struct JobbedReinsertBuffer
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public ScheduleQueueType QueueType;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public List<JobbedInsertionData> Insertions;
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		[CompilerGenerated]
		private sealed class HZDYEWMUZJZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public IERKCXVGQJG KRDTMVFEGYP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			public DNVJXJNSMAY IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public OHMKRHMOYNJ DGWPTYIAQJX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public RWOGNWMZQFL NYBUMUYRXTM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public CoroutineState SMWKHQZGRIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public KHZACSYKHRO JKVUAEHZDBQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public IEnumerator<KHZACSYKHRO> JWVFQPUPOVO;

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public HZDYEWMUZJZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xA364620", Offset = "0xA363020", VA = "0x18A364620")]
			internal void NGSEGYACRFY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		[CompilerGenerated]
		private sealed class WIPXTJGKCVJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public RWOGNWMZQFL ZNEBITBTULN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public DNVJXJNSMAY IRZLODQIRHI;

			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public WIPXTJGKCVJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xA36DC00", Offset = "0xA36C600", VA = "0x18A36DC00")]
			internal void MHBTZXPCCHQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[CompilerGenerated]
		private sealed class QSEGWRFHNPW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public RWOGNWMZQFL ZNEBITBTULN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public DNVJXJNSMAY IRZLODQIRHI;

			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public QSEGWRFHNPW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xA3689F0", Offset = "0xA3673F0", VA = "0x18A3689F0")]
			internal void FNEZVRYXBDY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		[CompilerGenerated]
		private sealed class VLQDCVWVTON
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public RWOGNWMZQFL ZNEBITBTULN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public DNVJXJNSMAY IRZLODQIRHI;

			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public VLQDCVWVTON()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0xA36D220", Offset = "0xA36BC20", VA = "0x18A36D220")]
			internal void WXWOHJJDQUV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private const CoroutineState UGKUCZKTZCE = CoroutineState.Cancelled | CoroutineState.Paused;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private readonly ScheduleQueueType IIUGFEPFFQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		private bool[] GZJZMEZTWEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private NativeArray<CoroutineState> MQCPAJLKGQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private NativeArray<float> ORZLITVLOPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private NativeArray<int> ZUDLRAANVAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private NativeArray<int> QXDNERMFYYN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private NativeArray<int> JRMKNUNLMRC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private NativeArray<int> HKTZJJTJJEJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private NativeArray<int> TOUWKLYBWFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private RWOGNWMZQFL[] IIBDUYTYVST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private IERKCXVGQJG[] WMUVCCQCHSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private OHMKRHMOYNJ[] HIAICYNFISB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private IEnumerator<KHZACSYKHRO>[] TGDBOWOQWUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private KHZACSYKHRO[] JTOXFIKGNGU;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private int JYPUIXOTNOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private int ZRWPRDYUBAW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly int KNSYMVHLHKW;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private float NAXBWQDPRAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private ScheduleSortJob DWSHFGZRDGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private JobHandle FJIUBDIOUAX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private List<RWOGNWMZQFL> CRARZKLGAAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private bool JPEYHHFDGSR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private List<Action> EIAQVBCNZKR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private List<Action> VWGEASSAEWJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private bool TASYIHAQJCA;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public JobbedReinsertBuffer[] YHKNZWNBZGS
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0xD9C5C0", Offset = "0xD9AFC0", VA = "0x180D9C5C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0xA361230", Offset = "0xA35FC30", VA = "0x18A361230")]
		private static int OIBVPBGFZSC(ScheduleQueueType a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0xA3626A0", Offset = "0xA3610A0", VA = "0x18A3626A0")]
		public DNVJXJNSMAY(ScheduleQueueType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0xA360620", Offset = "0xA35F020", VA = "0x18A360620")]
		private void FNLPYYWIAGM(int a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0xA361AD0", Offset = "0xA3604D0", VA = "0x18A361AD0")]
		public void WUFSAZGVLFW(OHMKRHMOYNJ a, KHZACSYKHRO b, IEnumerator<KHZACSYKHRO> c, IERKCXVGQJG d, [Optional] RWOGNWMZQFL e, CoroutineState f = CoroutineState.Running)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0xA360800", Offset = "0xA35F200", VA = "0x18A360800")]
		public void Insert(IEnumerable<JobbedInsertionData> insertionDatas)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0xA361EA0", Offset = "0xA3608A0", VA = "0x18A361EA0")]
		private JobbedInsertionData XDUQCAZLIDZ(int a)
		{
			return default(JobbedInsertionData);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0xA362350", Offset = "0xA360D50", VA = "0x18A362350")]
		private void YBFRCUWBBQR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x38CD210", Offset = "0x38CBC10", VA = "0x1838CD210")]
		private static void NUJYNHKTEGP<a>(int a, a[] b, int c, [Optional] a d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x38CD260", Offset = "0x38CBC60", VA = "0x1838CD260")]
		private static void NUJYNHKTEGP<b>(int a, NativeArray<b> b, int c, [Optional] b d) where b : struct
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0xA361680", Offset = "0xA360080", VA = "0x18A361680")]
		private void RRYRIDUGROF(IEnumerable<JobbedInsertionData> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0xA361A00", Offset = "0xA360400", VA = "0x18A361A00")]
		private void WDWRWNESKGG(JobbedInsertionData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0xA361420", Offset = "0xA35FE20", VA = "0x18A361420")]
		private TickResult QQOETSKWCXT(int a)
		{
			return default(TickResult);
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0xA361CA0", Offset = "0xA3606A0", VA = "0x18A361CA0")]
		public void WUSMGEZIZAE(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0xA360440", Offset = "0xA35EE40", VA = "0x18A360440")]
		private void DBSYLBBRVCK(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0xA360A40", Offset = "0xA35F440", VA = "0x18A360A40")]
		private void KDCBFIKWGQM(Action a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xA360B20", Offset = "0xA35F520", VA = "0x18A360B20")]
		public void KMXHFUSEKGY(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0xA360520", Offset = "0xA35EF20", VA = "0x18A360520")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0xA360360", Offset = "0xA35ED60", VA = "0x18A360360")]
		public void Cancel(RWOGNWMZQFL schedule)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0xA361340", Offset = "0xA35FD40", VA = "0x18A361340")]
		public void Pause(RWOGNWMZQFL schedule)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0xA361260", Offset = "0xA35FC60", VA = "0x18A361260")]
		public void OPXYCGSYOFD(RWOGNWMZQFL a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public class Receipt : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public static readonly Receipt EDBLDZCISQT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly Action ELWZCQOXKDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private bool PRGHQFJWEHL;

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0xCE33E0", Offset = "0xCE1DE0", VA = "0x180CE33E0")]
		public Receipt(Action onDispose)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x99B9AA0", Offset = "0x99B84A0", VA = "0x1899B9AA0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public interface KEXVSTEOUOC<a>
	{
		[Cpp2IlInjected.Token(Token = "0x17000026")]
		a FCAQLXAUMLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600012D")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IDisposable HBRWCLODOZA(UnityEngine.Object a, Action<a> b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public interface FJXZWCWGCAE<a> : KEXVSTEOUOC<a>
	{
		[Cpp2IlInjected.Token(Token = "0x17000027")]
		new a FCAQLXAUMLJ
		{
			[Cpp2IlInjected.Token(Token = "0x600012F")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class UMPKBWXHNJF<a> : FJXZWCWGCAE<a>, KEXVSTEOUOC<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private sealed class QLDETKWUZQC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public UMPKBWXHNJF<a> IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			public Tuple<UnityEngine.Object, Action<a>> FWCDDFDBBDR;

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public QLDETKWUZQC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x76FCBD0", Offset = "0x76FB5D0", VA = "0x1876FCBD0")]
			internal void WBFHAVKCRYE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private static GameObject ZDIUNZIHJGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private readonly List<Tuple<UnityEngine.Object, Action<a>>> LTSPBQSRWIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private a OBUKYMDCNTG;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public a FCAQLXAUMLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0xE90550", Offset = "0xE8EF50", VA = "0x180E90550", Slot = "5")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD090", Offset = "0x7DFBA90", VA = "0x187DFD090", Slot = "7")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD6A0", Offset = "0x7DFC0A0", VA = "0x187DFD6A0")]
		private static bool ZJGEPOFVCTK(a a, a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD730", Offset = "0x7DFC130", VA = "0x187DFD730")]
		public UMPKBWXHNJF(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x7DFC770", Offset = "0x7DFB170", VA = "0x187DFC770", Slot = "6")]
		public IDisposable HBRWCLODOZA(UnityEngine.Object a, Action<a> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7DFC9D0", Offset = "0x7DFB3D0", VA = "0x187DFC9D0")]
		private void SXVKQWIFGHM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	internal class PGXTVQFFVIL : ZWVBXOSJYAY
	{
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private class ADHVIKXGXMC : IDisposable
		{
			[Cpp2IlInjected.Token(Token = "0x2000047")]
			private class NUOVTAOMLFZ : IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				private int BPSKZWIJBDR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				private ADHVIKXGXMC BZTMNTKMKMR;

				[Cpp2IlInjected.Token(Token = "0x6000149")]
				[Cpp2IlInjected.Address(RVA = "0x107C490", Offset = "0x107AE90", VA = "0x18107C490")]
				public NUOVTAOMLFZ(int a, ADHVIKXGXMC b)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600014A")]
				[Cpp2IlInjected.Address(RVA = "0xA3669F0", Offset = "0xA3653F0", VA = "0x18A3669F0", Slot = "4")]
				public void Dispose()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000048")]
			[CompilerGenerated]
			private sealed class RBAAAFPDLJX
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public int BPSKZWIJBDR;

				[Cpp2IlInjected.Token(Token = "0x600014B")]
				[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
				public RBAAAFPDLJX()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600014C")]
				[Cpp2IlInjected.Address(RVA = "0xF51D90", Offset = "0xF50790", VA = "0x180F51D90")]
				internal bool BNHRKOSZXQU(VMCBGEHRDVD a)
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000049")]
			[CompilerGenerated]
			private sealed class SKJOFQCQSYR : IEnumerator<KHZACSYKHRO>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				private int NXJBPMXGHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				private KHZACSYKHRO BZAVRIIXYAB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				public ADHVIKXGXMC IRZLODQIRHI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				public IZYCAHMLASH HQPBFQOMVGX;

				[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				private LQYBXSHKYFJ QLROSTUTOLE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				private List<VMCBGEHRDVD> URCOCOYSPWO;

				[Cpp2IlInjected.Token(Token = "0x17000029")]
				private KHZACSYKHRO MMVFURGWOML
				{
					[Cpp2IlInjected.Token(Token = "0x6000150")]
					[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002A")]
				private object ERGKPVHJUQY
				{
					[Cpp2IlInjected.Token(Token = "0x6000152")]
					[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600014D")]
				[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
				[DebuggerHidden]
				public SKJOFQCQSYR(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600014E")]
				[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
				[DebuggerHidden]
				private void THBUUIJWZTJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600014F")]
				[Cpp2IlInjected.Address(RVA = "0xA36A9E0", Offset = "0xA3693E0", VA = "0x18A36A9E0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0xA36ACC0", Offset = "0xA3696C0", VA = "0x18A36ACC0", Slot = "8")]
				[DebuggerHidden]
				private void TVBXYVYIQIO()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			private readonly ScheduleQueueType IIUGFEPFFQN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			private NDLSPIRTFEP KRDTMVFEGYP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			private readonly List<VMCBGEHRDVD> WSKJNBDWDEC;

			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xA35D9E0", Offset = "0xA35C3E0", VA = "0x18A35D9E0")]
			public ADHVIKXGXMC(ScheduleQueueType a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0xA35D600", Offset = "0xA35C000", VA = "0x18A35D600")]
			public IDisposable ERBHFXGGBJV(VMCBGEHRDVD a, GUZFZPTTQMS b, IZYCAHMLASH c)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0xA35D860", Offset = "0xA35C260", VA = "0x18A35D860")]
			private void TJCVFDQEMFI(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xA35D7D0", Offset = "0xA35C1D0", VA = "0x18A35D7D0")]
			[IteratorStateMachine(typeof(SKJOFQCQSYR))]
			private IEnumerator<KHZACSYKHRO> LUDZCPYUVXF(IZYCAHMLASH a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0xA35D5B0", Offset = "0xA35BFB0", VA = "0x18A35D5B0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		private class VMCBGEHRDVD
		{
			[Cpp2IlInjected.Token(Token = "0x200004B")]
			public enum UpdateTypes : byte
			{
				[Cpp2IlInjected.Token(Token = "0x40000E8")]
				EveryFrame,
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				Scheduled,
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				ScheduledNonFramerateLimited
			}

			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			private static int OQQJDVYBISR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public readonly int SGYXLDBUDMX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public readonly PBUFILHXHAU ODQQNFONYER;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			private readonly MonoBehaviour PIFAQLKFPER;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public readonly Action AVOZDGIRMXR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public readonly Action<float> JJVHFYSOCEW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public readonly float NDQLQIDPWMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public float ORZLITVLOPF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public readonly string EREWIERIFZH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public readonly bool SXEEJOSFAEL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x49")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public readonly UpdateTypes MNSWXJMGXFZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4A")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public bool GPBXGEXZBLQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x4B")]
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public bool JICWTWNRHLT;

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0xA36D630", Offset = "0xA36C030", VA = "0x18A36D630")]
			public VMCBGEHRDVD(PBUFILHXHAU a, Action b, bool c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xA36D4B0", Offset = "0xA36BEB0", VA = "0x18A36D4B0")]
			public VMCBGEHRDVD(PBUFILHXHAU a, Action<float> b, bool c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0xA36D7B0", Offset = "0xA36C1B0", VA = "0x18A36D7B0")]
			public VMCBGEHRDVD(PBUFILHXHAU a, float b, Action<float> c, IZYCAHMLASH d, UpdateTypes e, bool f, bool g)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0xA36D260", Offset = "0xA36BC60", VA = "0x18A36D260")]
			public bool LWTHWGVTXMS(float a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private readonly GUZFZPTTQMS TIZXXEFOSPV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private readonly IZYCAHMLASH AXBVZNQJOJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		private readonly Dictionary<ScheduleQueueType, ADHVIKXGXMC> MEBYWLEXEOL;

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0xA367030", Offset = "0xA365A30", VA = "0x18A367030")]
		[BQDQKYYGTTM.Root]
		internal static void AQJMDSEZYIX(TFZCSWYZDKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0xA367990", Offset = "0xA366390", VA = "0x18A367990")]
		[UnityEngine.Scripting.Preserve]
		internal PGXTVQFFVIL([Inject(null)] GUZFZPTTQMS scheduler, [Inject(null)] IZYCAHMLASH schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA3677B0", Offset = "0xA3661B0", VA = "0x18A3677B0", Slot = "4")]
		public IDisposable Update(PBUFILHXHAU context, Action callback, ScheduleQueueType queueType, bool validateContext = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0xA3675D0", Offset = "0xA365FD0", VA = "0x18A3675D0", Slot = "5")]
		public IDisposable Update(PBUFILHXHAU context, Action<float> callback, ScheduleQueueType queueType, bool validateContext = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0xA367310", Offset = "0xA365D10", VA = "0x18A367310", Slot = "7")]
		public IDisposable LRJOZNUOPKI(PBUFILHXHAU a, float b, Action<float> c, ScheduleQueueType d, bool e = true, bool f = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0xA3670A0", Offset = "0xA365AA0", VA = "0x18A3670A0", Slot = "8")]
		public IDisposable BFGDWKHYXAS(PBUFILHXHAU a, float b, Action<float> c, ScheduleQueueType d, bool e = true, bool f = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0xA3671A0", Offset = "0xA365BA0", VA = "0x18A3671A0", Slot = "6")]
		public IDisposable LRJOZNUOPKI(float a, Action<float> b, bool c = true)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0xA367410", Offset = "0xA365E10", VA = "0x18A367410", Slot = "9")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0xA366F00", Offset = "0xA365900", VA = "0x18A366F00")]
		private ADHVIKXGXMC AEQFCLMWUDQ(ScheduleQueueType a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public class ATROJJJVUTN : RQMTQWEXJJI, GUZFZPTTQMS, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private DNVJXJNSMAY[] BYLZGTGSJNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private KLYDSDJYCQU OBQUNVJCXAG;

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0xA35E6B0", Offset = "0xA35D0B0", VA = "0x18A35E6B0")]
		[BQDQKYYGTTM.Root]
		internal static void TDUDTGPDFOH(TFZCSWYZDKY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0xA35EB30", Offset = "0xA35D530", VA = "0x18A35EB30")]
		[UnityEngine.Scripting.Preserve]
		public ATROJJJVUTN([Inject(null)] PPZYJVSYXNF unityLifecycleEvents, [Inject(null)] IZYCAHMLASH schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0xA35E720", Offset = "0xA35D120", VA = "0x18A35E720", Slot = "20")]
		public override NDLSPIRTFEP UTLRZAYTYLX(OHMKRHMOYNJ a, IEnumerator<KHZACSYKHRO> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0xA35E320", Offset = "0xA35CD20", VA = "0x18A35E320", Slot = "21")]
		public override void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA35DE90", Offset = "0xA35C890", VA = "0x18A35DE90", Slot = "23")]
		public override void ADHVIKXGXMC(ScheduleQueueType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0xA35E850", Offset = "0xA35D250", VA = "0x18A35E850", Slot = "22")]
		protected override void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0xA35E1D0", Offset = "0xA35CBD0", VA = "0x18A35E1D0")]
		private DNVJXJNSMAY GECSZPUALKT(ScheduleQueueType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0xA35E920", Offset = "0xA35D320", VA = "0x18A35E920", Slot = "24")]
		internal override IWCAQROSKFB ZUYVKOYAECL(IEnumerator<KHZACSYKHRO> a, Behaviour b, IERKCXVGQJG c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0xA35E120", Offset = "0xA35CB20", VA = "0x18A35E120", Slot = "25")]
		internal override URGJWBKAAOW EDCXYVUXMGS(ScheduleQueueType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xA35E200", Offset = "0xA35CC00", VA = "0x18A35E200")]
		private void PHLJDRJAUCD(DNVJXJNSMAY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xA35E0C0", Offset = "0xA35CAC0", VA = "0x18A35E0C0", Slot = "26")]
		public override void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	[BurstCompile]
	internal struct ScheduleSortJob : IJob
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		[ReadOnly]
		public float Now;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		[ReadOnly]
		public int ActiveCoroutineCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private NativeArray<int> Indices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		private NativeArray<int> scratchLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private NativeArray<int> scratchRight;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		[ReadOnly]
		public NativeArray<CoroutineState> AllCoroutineStates;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		[ReadOnly]
		public NativeArray<float> AllNextUpdateTimes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[WriteOnly]
		public NativeArray<int> SortedIndices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		[WriteOnly]
		public NativeArray<int> NumberToExecute;

		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0xA36AFE0", Offset = "0xA3699E0", VA = "0x18A36AFE0")]
		public static ScheduleSortJob Create(int activeCoroutines, float currentTime, NativeArray<CoroutineState> coroutineStates, NativeArray<float> nextUpdateTimes, NativeArray<int> numToExecute, NativeArray<int> unsortedIndicies, NativeArray<int> sortedIndicies, NativeArray<int> scratchLeft, NativeArray<int> scratchRight)
		{
			return default(ScheduleSortJob);
		}

		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA36B040", Offset = "0xA369A40", VA = "0x18A36B040", Slot = "4")]
		public void Execute()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xA36AFA0", Offset = "0xA3699A0", VA = "0x18A36AFA0")]
		private bool CVQIIYTRLEA(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xA36B4B0", Offset = "0xA369EB0", VA = "0x18A36B4B0")]
		private void TDBJXIUKQHA(NativeArray<int> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0xA36B1F0", Offset = "0xA369BF0", VA = "0x18A36B1F0")]
		private int JRVCTVKGJRT(int a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0xA36B120", Offset = "0xA369B20", VA = "0x18A36B120")]
		private void FWZCYPDPOQE(NativeArray<int> a, int b, int c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xA36B270", Offset = "0xA369C70", VA = "0x18A36B270")]
		private void Merge(NativeArray<int> arr, int leftStart, int middle, int rightEnd)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public abstract class RQMTQWEXJJI : GUZFZPTTQMS, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private sealed class SRYUHQJJNXN
		{
			[Cpp2IlInjected.Token(Token = "0x2000050")]
			private sealed class QKKBMKBCNDQ : IEnumerator<KHZACSYKHRO>, IEnumerator, IDisposable
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000102")]
				private int NXJBPMXGHVE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000103")]
				private KHZACSYKHRO BZAVRIIXYAB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000104")]
				public SRYUHQJJNXN IRZLODQIRHI;

				[Cpp2IlInjected.Token(Token = "0x17000033")]
				private KHZACSYKHRO MMVFURGWOML
				{
					[Cpp2IlInjected.Token(Token = "0x6000190")]
					[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "4")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000034")]
				private object ERGKPVHJUQY
				{
					[Cpp2IlInjected.Token(Token = "0x6000192")]
					[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0", Slot = "7")]
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[Cpp2IlInjected.Token(Token = "0x600018D")]
				[Cpp2IlInjected.Address(RVA = "0xCE3050", Offset = "0xCE1A50", VA = "0x180CE3050")]
				[DebuggerHidden]
				public QKKBMKBCNDQ(int a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600018E")]
				[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
				[DebuggerHidden]
				private void THBUUIJWZTJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600018F")]
				[Cpp2IlInjected.Address(RVA = "0xA3688C0", Offset = "0xA3672C0", VA = "0x18A3688C0", Slot = "6")]
				private bool MoveNext()
				{
					return default(bool);
				}

				[Cpp2IlInjected.Token(Token = "0x6000191")]
				[Cpp2IlInjected.Address(RVA = "0xA3689B0", Offset = "0xA3673B0", VA = "0x18A3689B0", Slot = "8")]
				[DebuggerHidden]
				private void TVBXYVYIQIO()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public RQMTQWEXJJI IRZLODQIRHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public float LGUNYXIWFMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public ScheduleQueueType BZTMNTKMKMR;

			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public SRYUHQJJNXN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xA36AF30", Offset = "0xA369930", VA = "0x18A36AF30")]
			[IteratorStateMachine(typeof(QKKBMKBCNDQ))]
			internal IEnumerator<KHZACSYKHRO> LXFEXKTPKMI()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private readonly PPZYJVSYXNF BDFNIEAMAJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		protected readonly IZYCAHMLASH AXBVZNQJOJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		private URGJWBKAAOW[] WDEUQHCXKRM;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public static GUZFZPTTQMS LDHSFMFGGNH
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xA369AB0", Offset = "0xA3684B0", VA = "0x18A369AB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public static bool GVLREYKWGTW
		{
			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0xCF0C20", Offset = "0xCEF620", VA = "0x180CF0C20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public ScheduleQueueType RRRTFOVZFNK
		{
			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0xCD5110", Offset = "0xCD3B10", VA = "0x180CD5110", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(ScheduleQueueType);
			}
			[Cpp2IlInjected.Token(Token = "0x600016D")]
			[Cpp2IlInjected.Address(RVA = "0xCDD360", Offset = "0xCDBD60", VA = "0x180CDD360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public IZYCAHMLASH UPSDDETCOAP
		{
			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public KHZACSYKHRO NOLGDETKLJF
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C50", Offset = "0xCD5650", VA = "0x180CD6C50", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public KHZACSYKHRO YVXEJPNBWLY
		{
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DA0", Offset = "0xCD57A0", VA = "0x180CD6DA0", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public KHZACSYKHRO NJLBXFBPNSK
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0xCD74F0", Offset = "0xCD5EF0", VA = "0x180CD74F0", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public KHZACSYKHRO JXJUBNQSQTG
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xCD6DE0", Offset = "0xCD57E0", VA = "0x180CD6DE0", Slot = "14")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0xA369A20", Offset = "0xA368420", VA = "0x18A369A20")]
		public static NDLSPIRTFEP IGJMIKQBANW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0xA36A030", Offset = "0xA368A30", VA = "0x18A36A030")]
		[UnityEngine.Scripting.Preserve]
		protected RQMTQWEXJJI([Inject(null)] PPZYJVSYXNF unityLifecycleEvents, [Inject(null)] IZYCAHMLASH schedulerTimer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(RVA = "0xA369E10", Offset = "0xA368810", VA = "0x18A369E10", Slot = "6")]
		public NDLSPIRTFEP Run(IEnumerator<KHZACSYKHRO> coroutineToRun)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0xA369E20", Offset = "0xA368820", VA = "0x18A369E20", Slot = "7")]
		public NDLSPIRTFEP Run(Behaviour context, IEnumerator<KHZACSYKHRO> coroutineToRun)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "20")]
		public abstract NDLSPIRTFEP UTLRZAYTYLX(OHMKRHMOYNJ a, IEnumerator<KHZACSYKHRO> b);

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xA369CA0", Offset = "0xA3686A0", VA = "0x18A369CA0", Slot = "21")]
		public virtual void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA369120", Offset = "0xA367B20", VA = "0x18A369120", Slot = "9")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA36A010", Offset = "0xA368A10", VA = "0x18A36A010", Slot = "22")]
		protected virtual void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA369FF0", Offset = "0xA3689F0", VA = "0x18A369FF0")]
		private void TMKLZZSGFJS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA369B20", Offset = "0xA368520", VA = "0x18A369B20")]
		private void LTNQFXVLSGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA3698F0", Offset = "0xA3682F0", VA = "0x18A3698F0")]
		private void FixedUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0xA369B40", Offset = "0xA368540", VA = "0x18A369B40")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA369550", Offset = "0xA367F50", VA = "0x18A369550")]
		private void DJGPRILATUV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0xA369910", Offset = "0xA368310", VA = "0x18A369910")]
		private void HFEFDEJCIUV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0xA369530", Offset = "0xA367F30", VA = "0x18A369530")]
		private void DJARVLHFNPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0xA369090", Offset = "0xA367A90", VA = "0x18A369090", Slot = "23")]
		public virtual void ADHVIKXGXMC(ScheduleQueueType a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0xA369360", Offset = "0xA367D60", VA = "0x18A369360")]
		private void DEEHGEKMKPP(URGJWBKAAOW a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x2A219D0", Offset = "0x2A203D0", VA = "0x182A219D0")]
		private URGJWBKAAOW LFLVGOBXFTL(ScheduleQueueType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(Slot = "24")]
		internal abstract IWCAQROSKFB ZUYVKOYAECL(IEnumerator<KHZACSYKHRO> a, Behaviour b, IERKCXVGQJG c);

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "25")]
		internal abstract URGJWBKAAOW EDCXYVUXMGS(ScheduleQueueType a);

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0xA369570", Offset = "0xA367F70", VA = "0x18A369570", Slot = "26")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0xA369B60", Offset = "0xA368560", VA = "0x18A369B60", Slot = "15")]
		public KHZACSYKHRO NHCJGRFQOJU(ScheduleQueueType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0xA369C20", Offset = "0xA368620", VA = "0x18A369C20", Slot = "16")]
		public KHZACSYKHRO PWVSNGIGLZV(float a, ScheduleQueueType b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xA369930", Offset = "0xA368330", VA = "0x18A369930", Slot = "17")]
		public NDLSPIRTFEP IEKZMCZJUKK(float a, ScheduleQueueType b = ScheduleQueueType.Update)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0xA369BC0", Offset = "0xA3685C0", VA = "0x18A369BC0", Slot = "18")]
		public KHZACSYKHRO NPNULMOTCCS(Func<bool> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	internal sealed class IWCAQROSKFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		private readonly IERKCXVGQJG KRDTMVFEGYP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		private readonly NMALFNJJWAN DGWPTYIAQJX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private readonly bool GONBYYTIQEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private string QJLGCTXOMRL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private StackTrace IQWNYZLWINJ;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public IEnumerator<KHZACSYKHRO> OATNHBHZJMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xCD6E00", Offset = "0xCD5800", VA = "0x180CD6E00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public KHZACSYKHRO WBERTOXHXUC
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CC0", Offset = "0xCD56C0", VA = "0x180CD6CC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C00", Offset = "0xCD5600", VA = "0x180CD6C00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public bool KODVIUYYYUE
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xA365730", Offset = "0xA364130", VA = "0x18A365730")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool UWVPNUCPNAR
		{
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xD7B880", Offset = "0xD7A280", VA = "0x180D7B880")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xE700D0", Offset = "0xE6EAD0", VA = "0x180E700D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public string EREWIERIFZH
		{
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xA365580", Offset = "0xA363F80", VA = "0x18A365580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public float YRPQYWIGGER
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xF1C150", Offset = "0xF1AB50", VA = "0x180F1C150")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xF1C160", Offset = "0xF1AB60", VA = "0x180F1C160")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0xA365890", Offset = "0xA364290", VA = "0x18A365890")]
		public IWCAQROSKFB(IEnumerator<KHZACSYKHRO> a, NMALFNJJWAN b, IERKCXVGQJG c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0xA3651F0", Offset = "0xA363BF0", VA = "0x18A3651F0")]
		public KHZACSYKHRO EOZEWIDNYPG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xA365510", Offset = "0xA363F10", VA = "0x18A365510")]
		public bool FLNLYBYSHKA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xA3651A0", Offset = "0xA363BA0", VA = "0x18A3651A0")]
		public void Cancel()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xA3657B0", Offset = "0xA3641B0", VA = "0x18A3657B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0xF1A6E0", Offset = "0xF190E0", VA = "0x180F1A6E0")]
		[CompilerGenerated]
		private void RSTSFBORFVE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal sealed class IERKCXVGQJG : DMQSFVKWVUR, NDLSPIRTFEP, LEVOMZEPWVK, NKOSDRYVRPY, IEnumerator, KHZACSYKHRO, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private ScheduleQueueType LBVUNWDXVCK;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		private ScheduleQueueType DDCQOOYGLSB
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x10C5B80", Offset = "0x10C4580", VA = "0x1810C5B80", Slot = "23")]
			get
			{
				return default(ScheduleQueueType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public ScheduleQueueType MBWBJANWPWZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x10C5DE0", Offset = "0x10C47E0", VA = "0x1810C5DE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		private float LOQLWDWAGJN
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xD26890", Offset = "0xD25290", VA = "0x180D26890", Slot = "25")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public bool DRIJNNUMHJI
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "26")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0xA364D90", Offset = "0xA363790", VA = "0x18A364D90", Slot = "24")]
		private bool FDGLUMEHJAZ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xA364D80", Offset = "0xA363780", VA = "0x18A364D80", Slot = "27")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xA364DB0", Offset = "0xA3637B0", VA = "0x18A364DB0")]
		public IERKCXVGQJG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000053")]
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
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	internal sealed class URGJWBKAAOW : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000055")]
		public enum SubQueue
		{
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			Immediate,
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			Future
		}

		[Cpp2IlInjected.Token(Token = "0x2000056")]
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
			public List<IWCAQROSKFB> Coroutines;
		}

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		private static readonly SubQueue[] RGDRSOGODEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		private readonly ScheduleQueueType IIUGFEPFFQN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private bool FBQAXFDDWZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private readonly IWCAQROSKFB[] VACXVGEYFZN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private readonly List<IWCAQROSKFB> ITQXLKEUWUE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private readonly Stack<int> BCQVQJXMWOZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private readonly List<IWCAQROSKFB> MKPRPSRXZBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private readonly Stack<int> UKPFSPUNWGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private readonly KLYDSDJYCQU MKLNEQOJASP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private bool TASYIHAQJCA;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public ReinsertBuffer[,] KZJRRUYCIAF
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xCD74F0", Offset = "0xCD5EF0", VA = "0x180CD74F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xA36CDB0", Offset = "0xA36B7B0", VA = "0x18A36CDB0")]
		public URGJWBKAAOW(ScheduleQueueType a, KLYDSDJYCQU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xA36BC10", Offset = "0xA36A610", VA = "0x18A36BC10")]
		public void BDVHJQEZNFB(IWCAQROSKFB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA36C840", Offset = "0xA36B240", VA = "0x18A36C840")]
		public void PQURKDSLTPP(IList<IWCAQROSKFB> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0xA36C120", Offset = "0xA36AB20", VA = "0x18A36C120")]
		public void EDRZLEOFMDT(IList<IWCAQROSKFB> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0xA36C570", Offset = "0xA36AF70", VA = "0x18A36C570")]
		private void LJYKAYXXCSU(IWCAQROSKFB a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0xA36C6C0", Offset = "0xA36B0C0", VA = "0x18A36C6C0")]
		private void MBBYAKEIOTW(IList<IWCAQROSKFB> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0xA36C400", Offset = "0xA36AE00", VA = "0x18A36C400")]
		private TickResult FFUZLAOMDTB(IWCAQROSKFB a)
		{
			return default(TickResult);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0xA36CB20", Offset = "0xA36B520", VA = "0x18A36CB20")]
		public void Update(float currentTime)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xA36BE10", Offset = "0xA36A810", VA = "0x18A36BE10")]
		public void ClearExpiredCoroutines()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xA36B8B0", Offset = "0xA36A2B0", VA = "0x18A36B8B0")]
		private void AQLTZWYNOMF(List<IWCAQROSKFB> a, Stack<int> b, bool c, float d = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xA36C000", Offset = "0xA36AA00", VA = "0x18A36C000", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0xA36BCD0", Offset = "0xA36A6D0", VA = "0x18A36BCD0")]
		private void CIAZADQFZVB(List<IWCAQROSKFB> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	internal class SWIQWGPIQGW : KLYDSDJYCQU
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "4")]
		public void RVCCMSQOKUB(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0xCD6190", Offset = "0xCD4B90", VA = "0x180CD6190", Slot = "5")]
		public void AJHKBVYAOLT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public SWIQWGPIQGW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	internal class OGQEPWKTSQD : NMALFNJJWAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private readonly Behaviour KSAQHPDZGWZ;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public string EREWIERIFZH
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(RVA = "0xA366A20", Offset = "0xA365420", VA = "0x18A366A20", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public bool PDOLUVAGPUY
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0xA366AA0", Offset = "0xA3654A0", VA = "0x18A366AA0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool BQPURYLUXMS
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0xA366AF0", Offset = "0xA3654F0", VA = "0x18A366AF0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0xCE33E0", Offset = "0xCE1DE0", VA = "0x180CE33E0")]
		public OGQEPWKTSQD(Behaviour a)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[Unity.Jobs.DOTSCompilerGenerated]
internal class __JobReflectionRegistrationOutput__4287169157
{
	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0xA36F590", Offset = "0xA36DF90", VA = "0x18A36F590")]
	public static void ZGEXVVNGJIY()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0xA36F580", Offset = "0xA36DF80", VA = "0x18A36F580")]
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
