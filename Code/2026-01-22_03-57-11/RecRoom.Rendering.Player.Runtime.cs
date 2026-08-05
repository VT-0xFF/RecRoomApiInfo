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
		[Cpp2IlInjected.Address(RVA = "0x8AD6690", Offset = "0x8AD4E90", VA = "0x188AD6690", Slot = "4")]
		public override void JPLRKQDWIBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		private int[] GGRLHWHSZPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset ERVRXHKVDYW;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAAD0F0", Offset = "0xAAB8F0", VA = "0x180AAD0F0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x84A6090", Offset = "0x84A4890", VA = "0x1884A6090", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8AD7EA0", Offset = "0x8AD66A0", VA = "0x188AD7EA0")]
		private void LJCGTCDSEAS(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8AD82E0", Offset = "0x8AD6AE0", VA = "0x188AD82E0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8AD80C0", Offset = "0x8AD68C0", VA = "0x188AD80C0", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8AD8340", Offset = "0x8AD6B40", VA = "0x188AD8340")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface DOQNKTKJJYN
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		int? FTYZBCHJQTD
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool? PPJSAKYRWII
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool KISAVFYNBLS
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void BFRRUVQQRBH();
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class RenderingExperimentHelper : DOQNKTKJJYN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly string RFLWEXKZIEW;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly string DMXYJFOEXHJ;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string ANRCKCVJHTD;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly string TTMHBCBAUTD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private SMMLIKUSWFX CFUDTBWGFOX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int? ISGLNFCNKYK;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int? FTYZBCHJQTD
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool KISAVFYNBLS
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xAACA90", Offset = "0xAAB290", VA = "0x180AACA90", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAACB00", Offset = "0xAAB300", VA = "0x180AACB00")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool? PPJSAKYRWII
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8AD7160", Offset = "0x8AD5960", VA = "0x188AD7160", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xAB2E40", Offset = "0xAB1640", VA = "0x180AB2E40")]
		[UnityEngine.Scripting.Preserve]
		public RenderingExperimentHelper([Inject(null)][NotNull] SMMLIKUSWFX statsig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8AD71B0", Offset = "0x8AD59B0", VA = "0x188AD71B0", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8AD72A0", Offset = "0x8AD5AA0", VA = "0x188AD72A0")]
		[SLGIUIECCXF.Session.GameOnly]
		[UsedImplicitly]
		public static void JWRZAPCZPAI(MUPQGBSCKZR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8AD7070", Offset = "0x8AD5870", VA = "0x188AD7070", Slot = "5")]
		public void BFRRUVQQRBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8AD7310", Offset = "0x8AD5B10", VA = "0x188AD7310")]
		private void WHHGIWPAKTR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8AD78C0", Offset = "0x8AD60C0", VA = "0x188AD78C0")]
		private bool ZJGZOUNGDTV(string a, [Out] EFFHBNICWMO b)
		{
			return default(bool);
		}
	}
}
namespace RecRoom.Rendering.Player
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface KABQBEICFIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ZDUGHYAMJLN();
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PatchStudioMaterials : KABQBEICFIN
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class YBLCUBNAVMX : IEnumerator<ZCECIALXIMT>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private int RXIHLDXPFTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private ZCECIALXIMT VMXRQLYYOUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public PatchStudioMaterials BDLWXAGXLOZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int BWHCZIMPJCX;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private ZCECIALXIMT NOLEYVPTISW
			{
				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object BXTOFOKJAZT
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xAB5F80", Offset = "0xAB4780", VA = "0x180AB5F80")]
			[DebuggerHidden]
			public YBLCUBNAVMX(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
			[DebuggerHidden]
			private void QMTXDIUIKRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8AD7DB0", Offset = "0x8AD65B0", VA = "0x188AD7DB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8AD7D70", Offset = "0x8AD6570", VA = "0x188AD7D70", Slot = "8")]
			[DebuggerHidden]
			private void FKDUCXAGPJJ()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private BFFPISQCYKM OOTBJKYVOKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int PTHLRMZVUGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool? IRNXMIDRMZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private bool VXTTRAIPJIA;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static Log VWVPTUNGWGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly HashSet<string> LBOISUTFYCW;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8AD6F50", Offset = "0x8AD5750", VA = "0x188AD6F50")]
		[UnityEngine.Scripting.Preserve]
		public PatchStudioMaterials()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8AD6800", Offset = "0x8AD5000", VA = "0x188AD6800")]
		private BFFPISQCYKM GWPXXFJIDMX()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8AD6790", Offset = "0x8AD4F90", VA = "0x188AD6790")]
		[IteratorStateMachine(typeof(YBLCUBNAVMX))]
		private IEnumerator<ZCECIALXIMT> EXAVANDHSYT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8AD6970", Offset = "0x8AD5170", VA = "0x188AD6970")]
		private void MFTXJIXNZGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8AD6900", Offset = "0x8AD5100", VA = "0x188AD6900")]
		[SLGIUIECCXF.Root]
		public static void JWRZAPCZPAI(MUPQGBSCKZR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8AD6D60", Offset = "0x8AD5560", VA = "0x188AD6D60", Slot = "4")]
		public void ZDUGHYAMJLN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[RegisterService(typeof(DetectSingleProbeOptimization), new string[] { })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public class DetectSingleProbeOptimization : DPQPSOGQUSE, LYHFQGWTPJE
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class TVZAWFQVFRB : IEnumerator<ZCECIALXIMT>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private int RXIHLDXPFTB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private ZCECIALXIMT VMXRQLYYOUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public DetectSingleProbeOptimization BDLWXAGXLOZ;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private ZCECIALXIMT NOLEYVPTISW
			{
				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private object BXTOFOKJAZT
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0xAACA70", Offset = "0xAAB270", VA = "0x180AACA70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAB5F80", Offset = "0xAB4780", VA = "0x180AB5F80")]
			[DebuggerHidden]
			public TVZAWFQVFRB(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "5")]
			[DebuggerHidden]
			private void QMTXDIUIKRI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8AD7B50", Offset = "0x8AD6350", VA = "0x188AD7B50", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8AD7B10", Offset = "0x8AD6310", VA = "0x188AD7B10", Slot = "8")]
			[DebuggerHidden]
			private void FKDUCXAGPJJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static Log WKLAFLLOLVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private DOQNKTKJJYN LICTGQYXYZS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private DZROOIMJMUK GRCSSGUUZVO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private IDisposable PNRRJVVBTHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private IDisposable AFXBANMSJIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private HashSet<ReflectionProbe> NJCPMJGMLYQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool ZUIBYJIRQIT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool TIUHIIFPLVY;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8AD6610", Offset = "0x8AD4E10", VA = "0x188AD6610")]
		[UnityEngine.Scripting.Preserve]
		public DetectSingleProbeOptimization()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8AD5C60", Offset = "0x8AD4460", VA = "0x188AD5C60", Slot = "4")]
		public void InitExternal(MZUBMRWQSAC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8AD6580", Offset = "0x8AD4D80", VA = "0x188AD6580")]
		private void VRGDFWNHMUW(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8AD5870", Offset = "0x8AD4070", VA = "0x188AD5870")]
		private void CreateDeserializationHandler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8AD5A40", Offset = "0x8AD4240", VA = "0x188AD5A40")]
		private void EUKVANHFZUP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8AD5E20", Offset = "0x8AD4620", VA = "0x188AD5E20")]
		private (ReflectionProbe, int) NTSPTXYPBTZ()
		{
			return default((ReflectionProbe, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8AD5BF0", Offset = "0x8AD43F0", VA = "0x188AD5BF0")]
		[IteratorStateMachine(typeof(TVZAWFQVFRB))]
		private IEnumerator<ZCECIALXIMT> HFJBSARUTPW()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8AD5FE0", Offset = "0x8AD47E0", VA = "0x188AD5FE0")]
		private void PNHYRDVXVSH([CanBeNull] ReflectionProbe reflectionProbe)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8AD5A10", Offset = "0x8AD4210", VA = "0x188AD5A10")]
		private void DIQELDCZMBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8AD5DD0", Offset = "0x8AD45D0", VA = "0x188AD5DD0")]
		private void NBJWDIBLNYY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8AD5B20", Offset = "0x8AD4320", VA = "0x188AD5B20", Slot = "5")]
		public void GGOPOLDMLPS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8AD60C0", Offset = "0x8AD48C0", VA = "0x188AD60C0")]
		[CompilerGenerated]
		private void QGZJLEDLUKR()
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
