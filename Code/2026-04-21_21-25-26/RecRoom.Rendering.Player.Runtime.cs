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
		[Cpp2IlInjected.Address(RVA = "0xA1B3840", Offset = "0xA1B2240", VA = "0x18A1B3840", Slot = "4")]
		public override void CBYRPQCEVDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9B78E90", Offset = "0x9B77890", VA = "0x189B78E90", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA1B5310", Offset = "0xA1B3D10", VA = "0x18A1B5310")]
		private void TZCLDGRTUGE(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA1B52B0", Offset = "0xA1B3CB0", VA = "0x18A1B52B0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA1B5090", Offset = "0xA1B3A90", VA = "0x18A1B5090", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA1B5530", Offset = "0xA1B3F30", VA = "0x18A1B5530")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool GQSITLVYQEK
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xD11950", Offset = "0xD10350", VA = "0x180D11950", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xD12250", Offset = "0xD10C50", VA = "0x180D12250")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool? YXWQICKIFTY
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA1B45C0", Offset = "0xA1B2FC0", VA = "0x18A1B45C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xD118A0", Offset = "0xD102A0", VA = "0x180D118A0")]
		[UnityEngine.Scripting.Preserve]
		public RenderingExperimentHelper([Inject(null)][NotNull] SOLRGSEENKD statsig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA1B4610", Offset = "0xA1B3010", VA = "0x18A1B4610", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA1B4700", Offset = "0xA1B3100", VA = "0x18A1B4700")]
		[CXDXQIFYXBD.Session.GameOnly]
		[UsedImplicitly]
		public static void FQAQHNIUTYO(MZEBANDYSXL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA1B4E10", Offset = "0xA1B3810", VA = "0x18A1B4E10", Slot = "5")]
		public void OTOBZKQRPBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA1B4770", Offset = "0xA1B3170", VA = "0x18A1B4770")]
		private void NJYWHNNDLEN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA1B4D30", Offset = "0xA1B3730", VA = "0x18A1B4D30")]
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
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xD14A60", Offset = "0xD13460", VA = "0x180D14A60")]
			[DebuggerHidden]
			public QBQTLXXGYIB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "5")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA1B4490", Offset = "0xA1B2E90", VA = "0x18A1B4490", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xA1B4580", Offset = "0xA1B2F80", VA = "0x18A1B4580", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1B4370", Offset = "0xA1B2D70", VA = "0x18A1B4370")]
		[UnityEngine.Scripting.Preserve]
		public PatchStudioMaterials()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA1B3C80", Offset = "0xA1B2680", VA = "0x18A1B3C80")]
		private VOFDHKTSCRY HRQLGEEXZUR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA1B3BA0", Offset = "0xA1B25A0", VA = "0x18A1B3BA0")]
		[IteratorStateMachine(typeof(QBQTLXXGYIB))]
		private IEnumerator<IUPNMORLIQV> BNHWIATGGND()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA1B3D80", Offset = "0xA1B2780", VA = "0x18A1B3D80")]
		private void MCXFUZYXLFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA1B3C10", Offset = "0xA1B2610", VA = "0x18A1B3C10")]
		[CXDXQIFYXBD.Root]
		public static void FQAQHNIUTYO(MZEBANDYSXL a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA1B4170", Offset = "0xA1B2B70", VA = "0x18A1B4170", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xD14A60", Offset = "0xD13460", VA = "0x180D14A60")]
			[DebuggerHidden]
			public PZCMBHZPOIZ(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "5")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xA1B3940", Offset = "0xA1B2340", VA = "0x18A1B3940", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xA1B3B60", Offset = "0xA1B2560", VA = "0x18A1B3B60", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1B37C0", Offset = "0xA1B21C0", VA = "0x18A1B37C0")]
		[UnityEngine.Scripting.Preserve]
		public DetectSingleProbeOptimization()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA1B2EC0", Offset = "0xA1B18C0", VA = "0x18A1B2EC0", Slot = "4")]
		public void InitExternal(IKBIXEGYPOI services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA1B36B0", Offset = "0xA1B20B0", VA = "0x18A1B36B0")]
		private void ZJJFWNISBLO(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA1B2BF0", Offset = "0xA1B15F0", VA = "0x18A1B2BF0")]
		private void CreateDeserializationHandler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA1B2DE0", Offset = "0xA1B17E0", VA = "0x18A1B2DE0")]
		private void IYKTFWDFTXH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA1B2A30", Offset = "0xA1B1430", VA = "0x18A1B2A30")]
		private (ReflectionProbe, int) ALOWHPEXDGB()
		{
			return default((ReflectionProbe, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA1B36C0", Offset = "0xA1B20C0", VA = "0x18A1B36C0")]
		[IteratorStateMachine(typeof(PZCMBHZPOIZ))]
		private IEnumerator<IUPNMORLIQV> ZJLLLJDTHWC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA1B3100", Offset = "0xA1B1B00", VA = "0x18A1B3100")]
		private void MHKYVWQSLIV([CanBeNull] ReflectionProbe reflectionProbe)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA1B3680", Offset = "0xA1B2080", VA = "0x18A1B3680")]
		private void SFZRSLGOCLS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA1B2D90", Offset = "0xA1B1790", VA = "0x18A1B2D90")]
		private void EFMSOZWCEEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA1B3030", Offset = "0xA1B1A30", VA = "0x18A1B3030", Slot = "5")]
		public void LUFANJQDLDU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA1B31E0", Offset = "0xA1B1BE0", VA = "0x18A1B31E0")]
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
