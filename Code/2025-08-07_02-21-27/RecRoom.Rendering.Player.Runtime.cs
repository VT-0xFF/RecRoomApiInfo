using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.Analytics.Statsig;
using RecRoom.Core;
using RecRoom.Core.Rendering;
using RecRoom.DataLayer.Attributes;
using RecRoom.DataLayer.Registration;
using RecRoom.Foundation.Service;
using RecRoom.Initialization;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.ObjectModel;
using RecRoom.Persistence;
using UJect;
using UJect.Injection;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_Rendering_Player_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9221F20", Offset = "0x9220B20", VA = "0x189221F20", Slot = "4")]
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
namespace _AssemblyRegistry.RecRoom_Rendering_Player_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	[Obfuscation(ApplyToMembers = false)]
	public class _AssemblyIndex : AssemblyIndex
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private int[] XIOCEUOZJGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset MVEDDDGEAHK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xB131D0", Offset = "0xB11DD0", VA = "0x180B131D0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8BD3300", Offset = "0x8BD1F00", VA = "0x188BD3300", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x92243A0", Offset = "0x9222FA0", VA = "0x1892243A0")]
		private void SGYKGOYOYBS(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x9224340", Offset = "0x9222F40", VA = "0x189224340", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9224120", Offset = "0x9222D20", VA = "0x189224120", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x92245C0", Offset = "0x92231C0", VA = "0x1892245C0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface XGCYLZYWCIT
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		int? NNTDSSUEFTR
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool? EWZAQLNJQNU
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool XKXYRZBVXUC
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void WLBYPCBFCUX();
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class RenderingExperimentHelper : XGCYLZYWCIT, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Log DNBXSEXRPWR;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly string OPVFZLZRQZO;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly string TSZWXCUMVOR;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string NXDCUQMYTHB;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly string LIGWQRQGEFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private NADKVDSFRLV CLPFIGTEDBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int? DQEUEGJVEHO;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int? NNTDSSUEFTR
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool XKXYRZBVXUC
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xB13220", Offset = "0xB11E20", VA = "0x180B13220", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xB13A80", Offset = "0xB12680", VA = "0x180B13A80")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool? EWZAQLNJQNU
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x9222F60", Offset = "0x9221B60", VA = "0x189222F60", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xB19870", Offset = "0xB18470", VA = "0x180B19870")]
		[UnityEngine.Scripting.Preserve]
		public RenderingExperimentHelper([Inject(null)][NotNull] NADKVDSFRLV statsig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9222E70", Offset = "0x9221A70", VA = "0x189222E70", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9222E00", Offset = "0x9221A00", VA = "0x189222E00")]
		[IFIZWETSKCB.Session.GameOnly]
		[UsedImplicitly]
		public static void AAIGXKKQACS(DiContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9223AA0", Offset = "0x92226A0", VA = "0x189223AA0", Slot = "5")]
		public void WLBYPCBFCUX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9222FB0", Offset = "0x9221BB0", VA = "0x189222FB0")]
		private void SMZBAOOLNJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9223880", Offset = "0x9222480", VA = "0x189223880")]
		private bool UZGCEMBFMDP(string a, [Out] GNEYKOLPDQY b)
		{
			return default(bool);
		}
	}
}
namespace RecRoom.Rendering.Player
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface LMOVNJGADKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void GKFQWRKKKHX();
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class PatchStudioMaterials : LMOVNJGADKL
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class QOCTNDBRPOU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public Material CKBBLNFWGAV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public string QPAJZTESTSL;

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0xB1CF80", Offset = "0xB1BB80", VA = "0x180B1CF80")]
			public QOCTNDBRPOU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x9222D90", Offset = "0x9221990", VA = "0x189222D90")]
			internal object WVCULXRUWLV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9222C70", Offset = "0x9221870", VA = "0x189222C70")]
			internal object WUXNOQXXNAM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class JXGCPERLOSV : IEnumerator<UGECMBPSTCZ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private UGECMBPSTCZ DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public PatchStudioMaterials VISDDFDIKLJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private int NAMOISTICOB;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private UGECMBPSTCZ RADPMWRJHYU
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
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
				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
			[DebuggerHidden]
			public JXGCPERLOSV(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9221DF0", Offset = "0x92209F0", VA = "0x189221DF0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x9221EE0", Offset = "0x9220AE0", VA = "0x189221EE0", Slot = "8")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private GEUHFRHGIWS WBVITXWAECE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private int TKAROPAHVWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private bool? ZPIKMFNHXHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool UZKGWGHYIUW;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static Log TONVKURCUVT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly HashSet<string> PHOYNBXBOXW;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9222900", Offset = "0x9221500", VA = "0x189222900")]
		[DebugConsoleCommand("SetFramesToWaitForMaterialPatch", "Set the number of frames to wait before patching shaders to ones found in the app", new KeyCode[] { })]
		public static void SetFramesToWaitForMaterialPatch(int i)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9222A00", Offset = "0x9221600", VA = "0x189222A00")]
		[DebugConsoleCommand("SetWaitForMaterialPatch", "Enable studio material patching regardless of experiment values", new KeyCode[] { })]
		public static void SetWaitForMaterialPatch(bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9222980", Offset = "0x9221580", VA = "0x189222980")]
		[DebugConsoleCommand("SetMaterialPatchShaderFilter", "Restrict shader filtering to only patch terrain and sprite shaders", new KeyCode[] { })]
		public static void SetMaterialPatchShaderFilter(bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9222B50", Offset = "0x9221750", VA = "0x189222B50")]
		[UnityEngine.Scripting.Preserve]
		public PatchStudioMaterials()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9222200", Offset = "0x9220E00", VA = "0x189222200")]
		private GEUHFRHGIWS ITGDECBMGRX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9222300", Offset = "0x9220F00", VA = "0x189222300")]
		[IteratorStateMachine(typeof(JXGCPERLOSV))]
		private IEnumerator<UGECMBPSTCZ> MYYJGRWHYVH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9222370", Offset = "0x9220F70", VA = "0x189222370")]
		private void NBCECJDQVUA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9222020", Offset = "0x9220C20", VA = "0x189222020")]
		[IFIZWETSKCB.Root]
		public static void AAIGXKKQACS(DiContainer a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9222090", Offset = "0x9220C90", VA = "0x189222090", Slot = "4")]
		public void GKFQWRKKKHX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[RegisterService(typeof(DetectSingleProbeOptimization), new string[] { })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public class DetectSingleProbeOptimization : YGTTGTSBWNM, BMZVOVVGZNC
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class JDRVHYQVDPD : IEnumerator<UGECMBPSTCZ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private int JEOGOPMUBAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private UGECMBPSTCZ DPUPDOXIACG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public DetectSingleProbeOptimization VISDDFDIKLJ;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private UGECMBPSTCZ RADPMWRJHYU
			{
				[Cpp2IlInjected.Token(Token = "0x600004B")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private object APIHCGBOWUL
			{
				[Cpp2IlInjected.Token(Token = "0x600004D")]
				[Cpp2IlInjected.Address(RVA = "0xB13A30", Offset = "0xB12630", VA = "0x180B13A30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xB21F80", Offset = "0xB20B80", VA = "0x180B21F80")]
			[DebuggerHidden]
			public JDRVHYQVDPD(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xB167F0", Offset = "0xB153F0", VA = "0x180B167F0", Slot = "5")]
			[DebuggerHidden]
			private void YLGUCQLHQAY()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x9221B20", Offset = "0x9220720", VA = "0x189221B20", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x9221DB0", Offset = "0x92209B0", VA = "0x189221DB0", Slot = "8")]
			[DebuggerHidden]
			private void RALPBKOBMUN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static Log DNBXSEXRPWR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private XGCYLZYWCIT SPRCDBUWXLQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private BFGWYOYOWEM CYTZLBEPWOW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private IDisposable RFHOWXOZKEQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private IDisposable JJFNOLNXWKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private HashSet<ReflectionProbe> XGQZTWLSLMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool IPGDTDAHKMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private bool CMNQMVKIUNO;

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9221AA0", Offset = "0x92206A0", VA = "0x189221AA0")]
		[UnityEngine.Scripting.Preserve]
		public DetectSingleProbeOptimization()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9220970", Offset = "0x921F570", VA = "0x189220970", Slot = "4")]
		public void InitExternal(BVNDYEZSFBO services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9220DC0", Offset = "0x921F9C0", VA = "0x189220DC0")]
		private void MBCJHEICJSE(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9220610", Offset = "0x921F210", VA = "0x189220610")]
		private void CreateDeserializationHandler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x92218E0", Offset = "0x92204E0", VA = "0x1892218E0")]
		private void YGAQIRXYGXH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x92207B0", Offset = "0x921F3B0", VA = "0x1892207B0")]
		private (ReflectionProbe, int) DCHAMVREGQF()
		{
			return default((ReflectionProbe, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x9220DD0", Offset = "0x921F9D0", VA = "0x189220DD0")]
		[IteratorStateMachine(typeof(JDRVHYQVDPD))]
		private IEnumerator<UGECMBPSTCZ> OHMZSWXYLTE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x92214D0", Offset = "0x92200D0", VA = "0x1892214D0")]
		private void TFHMEPRNCGZ([CanBeNull] ReflectionProbe reflectionProbe)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9220C60", Offset = "0x921F860", VA = "0x189220C60")]
		private void JLDQVYZZXBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x92219C0", Offset = "0x92205C0", VA = "0x1892219C0")]
		private void YNSQRVGFUVE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x9221400", Offset = "0x9220000", VA = "0x189221400", Slot = "5")]
		public void ShutdownInternal()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9220E40", Offset = "0x921FA40", VA = "0x189220E40")]
		[CompilerGenerated]
		private void RCIJQSAFPKD()
		{
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
