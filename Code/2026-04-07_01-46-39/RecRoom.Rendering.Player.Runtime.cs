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
		[Cpp2IlInjected.Address(RVA = "0xA1A7480", Offset = "0xA1A6480", VA = "0x18A1A7480", Slot = "4")]
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
		private int[] DFSWPDPJVFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset QBNLPBWZQQF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xCF4360", Offset = "0xCF3360", VA = "0x180CF4360", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9B6C7F0", Offset = "0x9B6B7F0", VA = "0x189B6C7F0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA1A8CD0", Offset = "0xA1A7CD0", VA = "0x18A1A8CD0")]
		private void ROXZSJHBEXH(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA1A9110", Offset = "0xA1A8110", VA = "0x18A1A9110", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA1A8EF0", Offset = "0xA1A7EF0", VA = "0x18A1A8EF0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA1A9170", Offset = "0xA1A8170", VA = "0x18A1A9170")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface AEBAEQOANAM
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		int? NLRLJYQLHPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool? RATSUCGYPJT
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool NJMMSKSSKCR
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void DRQFCXZWELG();
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class RenderingExperimentHelper : AEBAEQOANAM, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Log NSTUKEGGGWA;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly string YIUUEYPJFGP;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly string BUGROLHKIBM;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string OSIAADXDOSK;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly string RXAVUWALZXA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private GAVJPVRYXKY SFRLZEPEDFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int? EVYQVKAPRAF;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int? NLRLJYQLHPC
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool NJMMSKSSKCR
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xCFC420", Offset = "0xCFB420", VA = "0x180CFC420", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xCFC350", Offset = "0xCFB350", VA = "0x180CFC350")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool? RATSUCGYPJT
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA1A82D0", Offset = "0xA1A72D0", VA = "0x18A1A82D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xCF7AD0", Offset = "0xCF6AD0", VA = "0x180CF7AD0")]
		[UnityEngine.Scripting.Preserve]
		public RenderingExperimentHelper([Inject(null)][NotNull] GAVJPVRYXKY statsig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0xA1A8090", Offset = "0xA1A7090", VA = "0x18A1A8090", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0xA1A8180", Offset = "0xA1A7180", VA = "0x18A1A8180")]
		[GQJUYEPYYUG.Session.GameOnly]
		[UsedImplicitly]
		public static void EAQEZLVNLEB(RZEIGZPHMMY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA1A7FA0", Offset = "0xA1A6FA0", VA = "0x18A1A7FA0", Slot = "5")]
		public void DRQFCXZWELG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA1A8320", Offset = "0xA1A7320", VA = "0x18A1A8320")]
		private void VOXXOXASYAY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA1A81F0", Offset = "0xA1A71F0", VA = "0x18A1A81F0")]
		private bool HBCHBGNMWUY(string a, [Out] TFITJJSPDPZ b)
		{
			return default(bool);
		}
	}
}
namespace RecRoom.Rendering.Player
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface IITEPMINLKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void DFOBXVJECSO();
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PatchStudioMaterials : IITEPMINLKI
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class OEYBXMEWWZI : IEnumerator<BFNVKIYRTEQ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private int KVXTPCCUFNU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private BFNVKIYRTEQ NNNUNWANACF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public PatchStudioMaterials NJJCUEUTHZM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int AVRZTXKIQLK;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private BFNVKIYRTEQ NHKNBMQLZLJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object BVCEDTADISM
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xD03B50", Offset = "0xD02B50", VA = "0x180D03B50")]
			[DebuggerHidden]
			public OEYBXMEWWZI(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "5")]
			[DebuggerHidden]
			private void OHWWSGWCEEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA1A7580", Offset = "0xA1A6580", VA = "0x18A1A7580", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xA1A7670", Offset = "0xA1A6670", VA = "0x18A1A7670", Slot = "8")]
			[DebuggerHidden]
			private void UCVOSCIFQDQ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private TUMXXHBUICX EAYKHAXAPMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int KPNYXJQOVIX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool? RCBNDSYQVPW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private bool FVXRRGQFZXH;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static Log NXRVNYVGTMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly HashSet<string> XNAVQOIIZWX;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA1A7E80", Offset = "0xA1A6E80", VA = "0x18A1A7E80")]
		[UnityEngine.Scripting.Preserve]
		public PatchStudioMaterials()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0xA1A7CF0", Offset = "0xA1A6CF0", VA = "0x18A1A7CF0")]
		private TUMXXHBUICX TZOASNYLSMQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0xA1A7C80", Offset = "0xA1A6C80", VA = "0x18A1A7C80")]
		[IteratorStateMachine(typeof(OEYBXMEWWZI))]
		private IEnumerator<BFNVKIYRTEQ> NAYVAXWZSBQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0xA1A7890", Offset = "0xA1A6890", VA = "0x18A1A7890")]
		private void KLYTBUFLPFB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA1A7820", Offset = "0xA1A6820", VA = "0x18A1A7820")]
		[GQJUYEPYYUG.Root]
		public static void EAQEZLVNLEB(RZEIGZPHMMY a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0xA1A76B0", Offset = "0xA1A66B0", VA = "0x18A1A76B0", Slot = "4")]
		public void DFOBXVJECSO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[RegisterService(typeof(DetectSingleProbeOptimization), new string[] { "ExcludeForDataExport" })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public class DetectSingleProbeOptimization : LTQFALLCSKZ, KBDWOSKHASX
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class WMVRCYKCEYW : IEnumerator<BFNVKIYRTEQ>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private int KVXTPCCUFNU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private BFNVKIYRTEQ NNNUNWANACF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public DetectSingleProbeOptimization NJJCUEUTHZM;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private BFNVKIYRTEQ NHKNBMQLZLJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private object BVCEDTADISM
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0xCF4130", Offset = "0xCF3130", VA = "0x180CF4130", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xD03B50", Offset = "0xD02B50", VA = "0x180D03B50")]
			[DebuggerHidden]
			public WMVRCYKCEYW(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xCF6200", Offset = "0xCF5200", VA = "0x180CF6200", Slot = "5")]
			[DebuggerHidden]
			private void OHWWSGWCEEL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xA1A8A70", Offset = "0xA1A7A70", VA = "0x18A1A8A70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xA1A8C90", Offset = "0xA1A7C90", VA = "0x18A1A8C90", Slot = "8")]
			[DebuggerHidden]
			private void UCVOSCIFQDQ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static Log NSTUKEGGGWA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private AEBAEQOANAM COXHVIJPHDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private CEHSECFOKXH CTJWPRJNORF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private IDisposable WAYADHRAFGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private IDisposable SWBNHZYFEFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private HashSet<ReflectionProbe> OCQSFARIFOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool LBCYPLSAAZI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool NFHCQPNQJNX;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xA1A7400", Offset = "0xA1A6400", VA = "0x18A1A7400")]
		[UnityEngine.Scripting.Preserve]
		public DetectSingleProbeOptimization()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA1A6C00", Offset = "0xA1A5C00", VA = "0x18A1A6C00", Slot = "4")]
		public void InitExternal(GLSTNWKFOLX services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA1A6D70", Offset = "0xA1A5D70", VA = "0x18A1A6D70")]
		private void JLKHYQDIDSN(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA1A6670", Offset = "0xA1A5670", VA = "0x18A1A6670")]
		private void CreateDeserializationHandler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA1A69D0", Offset = "0xA1A59D0", VA = "0x18A1A69D0")]
		private void EGBNKGJYMPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xA1A6810", Offset = "0xA1A5810", VA = "0x18A1A6810")]
		private (ReflectionProbe, int) DGOHGTZKVMC()
		{
			return default((ReflectionProbe, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xA1A6D80", Offset = "0xA1A5D80", VA = "0x18A1A6D80")]
		[IteratorStateMachine(typeof(WMVRCYKCEYW))]
		private IEnumerator<BFNVKIYRTEQ> LBQMGPYWVBJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0xA1A7290", Offset = "0xA1A6290", VA = "0x18A1A7290")]
		private void OKWIDONXZAI([CanBeNull] ReflectionProbe reflectionProbe)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0xA1A6B00", Offset = "0xA1A5B00", VA = "0x18A1A6B00")]
		private void ICWOHCVKROT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0xA1A6AB0", Offset = "0xA1A5AB0", VA = "0x18A1A6AB0")]
		private void FVWUQZZHTON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xA1A6B30", Offset = "0xA1A5B30", VA = "0x18A1A6B30", Slot = "5")]
		public void IPPIPTCNVCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xA1A6DF0", Offset = "0xA1A5DF0", VA = "0x18A1A6DF0")]
		[CompilerGenerated]
		private void OHQIWFNOQGO()
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
