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
		[Cpp2IlInjected.Address(RVA = "0xA030AA0", Offset = "0xA02F8A0", VA = "0x18A030AA0", Slot = "4")]
		public override void CBYRPQCEVDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
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
		private int[] SSKDGXUXNDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset DGANWLFFZHC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B00", Offset = "0xCE6900", VA = "0x180CE7B00", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x99F59E0", Offset = "0x99F47E0", VA = "0x1899F59E0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA032570", Offset = "0xA031370", VA = "0x18A032570")]
		private void TZCLDGRTUGE(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA032510", Offset = "0xA031310", VA = "0x18A032510", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA0322F0", Offset = "0xA0310F0", VA = "0x18A0322F0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA032790", Offset = "0xA031590", VA = "0x18A032790")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface YDKJVHFCEWL
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		int? NLTVZXJSHMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool? YXWQICKIFTY
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool GQSITLVYQEK
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OTOBZKQRPBF();
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class RenderingExperimentHelper : YDKJVHFCEWL, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly string MBQQADYZDUA;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly string IUGFCVMXXMB;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string UGPFZPACDTV;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly string PZPPNUDQTNV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private SOLRGSEENKD LPIXLNZEUAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int? LXVTINXMPVS;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int? NLTVZXJSHMD
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool GQSITLVYQEK
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xCE7950", Offset = "0xCE6750", VA = "0x180CE7950", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xCE8250", Offset = "0xCE7050", VA = "0x180CE8250")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool? YXWQICKIFTY
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA031820", Offset = "0xA030620", VA = "0x18A031820", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xCE78A0", Offset = "0xCE66A0", VA = "0x180CE78A0")]
		[UnityEngine.Scripting.Preserve]
		public RenderingExperimentHelper([Inject(null)][NotNull] SOLRGSEENKD statsig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA031870", Offset = "0xA030670", VA = "0x18A031870", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA031960", Offset = "0xA030760", VA = "0x18A031960")]
		[CXDXQIFYXBD.Session.GameOnly]
		[UsedImplicitly]
		public static void FQAQHNIUTYO(MZEBANDYSXL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA032070", Offset = "0xA030E70", VA = "0x18A032070", Slot = "5")]
		public void OTOBZKQRPBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA0319D0", Offset = "0xA0307D0", VA = "0x18A0319D0")]
		private void NJYWHNNDLEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA031F90", Offset = "0xA030D90", VA = "0x18A031F90")]
		private bool ONXZXWEUAPL(string a, [Out] PYWZGSSTXBK b)
		{
			return default(bool);
		}
	}
}
namespace RecRoom.Rendering.Player
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface JKOZLKBNLDV
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void WAHLISEOMDT();
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PatchStudioMaterials : JKOZLKBNLDV
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class QBQTLXXGYIB : IEnumerator<IUPNMORLIQV>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private int AKEYILDVZEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private IUPNMORLIQV OCEUOVLOMMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public PatchStudioMaterials XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int GQKQQFHGMTL;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private IUPNMORLIQV BIZXNLKFYPO
			{
				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xCEAA60", Offset = "0xCE9860", VA = "0x180CEAA60")]
			[DebuggerHidden]
			public QBQTLXXGYIB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "5")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA0316F0", Offset = "0xA0304F0", VA = "0x18A0316F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xA0317E0", Offset = "0xA0305E0", VA = "0x18A0317E0", Slot = "8")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private VOFDHKTSCRY GSFJNLEOTAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int CMDPBHOEEOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool? BXEPVPFTRYR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private bool HUUZVCJXNEW;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static Log NVAILZSZCAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly HashSet<string> YSNTUXHQSMQ;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA0315D0", Offset = "0xA0303D0", VA = "0x18A0315D0")]
		[UnityEngine.Scripting.Preserve]
		public PatchStudioMaterials()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA030EE0", Offset = "0xA02FCE0", VA = "0x18A030EE0")]
		private VOFDHKTSCRY HRQLGEEXZUR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA030E00", Offset = "0xA02FC00", VA = "0x18A030E00")]
		[IteratorStateMachine(typeof(QBQTLXXGYIB))]
		private IEnumerator<IUPNMORLIQV> BNHWIATGGND()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA030FE0", Offset = "0xA02FDE0", VA = "0x18A030FE0")]
		private void MCXFUZYXLFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA030E70", Offset = "0xA02FC70", VA = "0x18A030E70")]
		[CXDXQIFYXBD.Root]
		public static void FQAQHNIUTYO(MZEBANDYSXL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA0313D0", Offset = "0xA0301D0", VA = "0x18A0313D0", Slot = "4")]
		public void WAHLISEOMDT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[RegisterService(typeof(DetectSingleProbeOptimization), new string[] { "ExcludeForDataExport" })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public class DetectSingleProbeOptimization : PVENKBCWRBE, JQVAGBYEMGQ
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class PZCMBHZPOIZ : IEnumerator<IUPNMORLIQV>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private int AKEYILDVZEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private IUPNMORLIQV OCEUOVLOMMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public DetectSingleProbeOptimization XRWOWCJVPDZ;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private IUPNMORLIQV BIZXNLKFYPO
			{
				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xCEAA60", Offset = "0xCE9860", VA = "0x180CEAA60")]
			[DebuggerHidden]
			public PZCMBHZPOIZ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "5")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xA030BA0", Offset = "0xA02F9A0", VA = "0x18A030BA0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xA030DC0", Offset = "0xA02FBC0", VA = "0x18A030DC0", Slot = "8")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static Log KNJEMMUNATP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private YDKJVHFCEWL AZAKINNYCWS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private UHLWHYEMXQU ZJJXXVVPZSO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private IDisposable HKEXGNUKMGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private IDisposable MDSXMBUPWZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private HashSet<ReflectionProbe> YWKMCTEYJVU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool WXIYJUFULIV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool UQZLCZGONMY;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA030A20", Offset = "0xA02F820", VA = "0x18A030A20")]
		[UnityEngine.Scripting.Preserve]
		public DetectSingleProbeOptimization()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA030120", Offset = "0xA02EF20", VA = "0x18A030120", Slot = "4")]
		public void InitExternal(IKBIXEGYPOI services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA030910", Offset = "0xA02F710", VA = "0x18A030910")]
		private void ZJJFWNISBLO(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA02FE50", Offset = "0xA02EC50", VA = "0x18A02FE50")]
		private void CreateDeserializationHandler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA030040", Offset = "0xA02EE40", VA = "0x18A030040")]
		private void IYKTFWDFTXH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA02FC90", Offset = "0xA02EA90", VA = "0x18A02FC90")]
		private (ReflectionProbe, int) ALOWHPEXDGB()
		{
			return default((ReflectionProbe, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA030920", Offset = "0xA02F720", VA = "0x18A030920")]
		[IteratorStateMachine(typeof(PZCMBHZPOIZ))]
		private IEnumerator<IUPNMORLIQV> ZJLLLJDTHWC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA030360", Offset = "0xA02F160", VA = "0x18A030360")]
		private void MHKYVWQSLIV([CanBeNull] ReflectionProbe reflectionProbe)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA0308E0", Offset = "0xA02F6E0", VA = "0x18A0308E0")]
		private void SFZRSLGOCLS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA02FFF0", Offset = "0xA02EDF0", VA = "0x18A02FFF0")]
		private void EFMSOZWCEEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA030290", Offset = "0xA02F090", VA = "0x18A030290", Slot = "5")]
		public void LUFANJQDLDU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA030440", Offset = "0xA02F240", VA = "0x18A030440")]
		[CompilerGenerated]
		private void QSBTWMSSILB()
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
