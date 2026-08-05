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
		[Cpp2IlInjected.Address(RVA = "0x8CE8390", Offset = "0x8CE6990", VA = "0x188CE8390", Slot = "4")]
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
		private int[] TPUBNGGXPOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private ServiceBitset EHSYFWCIGXF;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xAAFED0", Offset = "0xAAE4D0", VA = "0x180AAFED0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x86BE6A0", Offset = "0x86BCCA0", VA = "0x1886BE6A0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x8CE9BB0", Offset = "0x8CE81B0", VA = "0x188CE9BB0")]
		private void UAFZRFJIDZJ(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8CE9B50", Offset = "0x8CE8150", VA = "0x188CE9B50", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8CE9930", Offset = "0x8CE7F30", VA = "0x188CE9930", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8CE9DD0", Offset = "0x8CE83D0", VA = "0x188CE9DD0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.Core.Rendering
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public interface WBQJMDDIBHA
	{
		[Cpp2IlInjected.Token(Token = "0x17000002")]
		int? ZIPCBCSPMAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		bool? CMXMRSUHRHV
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		bool LDLNMLFJTDF
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "3")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void EKXJLIXADMS();
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class RenderingExperimentHelper : WBQJMDDIBHA, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private static readonly string DOTVNWWHYKF;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private static readonly string CZZQRVLNRBW;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly string GAFYLIAIBII;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly string VMEJXNVIFYE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private YAEPLJOWYUO PXKGDZNICOU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private int? ENDNBEYDYKX;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int? ZIPCBCSPMAO
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool LDLNMLFJTDF
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0xAB0F20", Offset = "0xAAF520", VA = "0x180AB0F20", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xAB0F00", Offset = "0xAAF500", VA = "0x180AB0F00")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool? CMXMRSUHRHV
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8CE9620", Offset = "0x8CE7C20", VA = "0x188CE9620", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xAAC630", Offset = "0xAAAC30", VA = "0x180AAC630")]
		[UnityEngine.Scripting.Preserve]
		public RenderingExperimentHelper([Inject(null)][NotNull] YAEPLJOWYUO statsig)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x8CE9440", Offset = "0x8CE7A40", VA = "0x188CE9440", Slot = "8")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8CE9670", Offset = "0x8CE7C70", VA = "0x188CE9670")]
		[ZOKCDQOPSGU.Session.GameOnly]
		[UsedImplicitly]
		public static void KKBQTYTYCPZ(KUXAUVMITFU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8CE9530", Offset = "0x8CE7B30", VA = "0x188CE9530", Slot = "5")]
		public void EKXJLIXADMS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8CE8EA0", Offset = "0x8CE74A0", VA = "0x188CE8EA0")]
		private void AEMGWFECOHY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8CE96E0", Offset = "0x8CE7CE0", VA = "0x188CE96E0")]
		private bool YVSTZWUOMYW(string a, [Out] VMNMQIOPYIB b)
		{
			return default(bool);
		}
	}
}
namespace RecRoom.Rendering.Player
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface MIUKSQRCBFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void FFJBBGHAFYE();
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class PatchStudioMaterials : MIUKSQRCBFE
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class OCQLWLDJXFO : IEnumerator<SGCTHXNJFVM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private SGCTHXNJFVM MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public PatchStudioMaterials CDTALOACOKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int HAOYDNHAFWO;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private SGCTHXNJFVM LCQHTYTSRAN
			{
				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xAA9B40", Offset = "0xAA8140", VA = "0x180AA9B40")]
			[DebuggerHidden]
			public OCQLWLDJXFO(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8CE8490", Offset = "0x8CE6A90", VA = "0x188CE8490", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8CE8580", Offset = "0x8CE6B80", VA = "0x188CE8580", Slot = "8")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private RBEAVUYSDOZ LIYXQZFAUHV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private int GFOGWUEWFGV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private bool? OMKECGGFFOS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1E")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private bool WEOUPWSPRAX;

		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static Log EJCYMILAWTG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly HashSet<string> QJPRRDQQUWV;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8CE8D80", Offset = "0x8CE7380", VA = "0x188CE8D80")]
		[UnityEngine.Scripting.Preserve]
		public PatchStudioMaterials()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8CE8C00", Offset = "0x8CE7200", VA = "0x188CE8C00")]
		private RBEAVUYSDOZ SQRLGOMRDSG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8CE8730", Offset = "0x8CE6D30", VA = "0x188CE8730")]
		[IteratorStateMachine(typeof(OCQLWLDJXFO))]
		private IEnumerator<SGCTHXNJFVM> HLWAULOGAXS()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8CE8810", Offset = "0x8CE6E10", VA = "0x188CE8810")]
		private void OSKFTAQBXLX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x8CE87A0", Offset = "0x8CE6DA0", VA = "0x188CE87A0")]
		[ZOKCDQOPSGU.Root]
		public static void KKBQTYTYCPZ(KUXAUVMITFU a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8CE85C0", Offset = "0x8CE6BC0", VA = "0x188CE85C0", Slot = "4")]
		public void FFJBBGHAFYE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[RegisterService(typeof(DetectSingleProbeOptimization), new string[] { })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	public class DetectSingleProbeOptimization : ZGVBPXQWGAT, SPJAMBOPKUB
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class DMTCCGJSEYU : IEnumerator<SGCTHXNJFVM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private int AEMBTWPORMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private SGCTHXNJFVM MVWPOXUKILF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			public DetectSingleProbeOptimization CDTALOACOKM;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			private SGCTHXNJFVM LCQHTYTSRAN
			{
				[Cpp2IlInjected.Token(Token = "0x6000036")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			private object HLWKSVCMTHU
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0xAA7760", Offset = "0xAA5D60", VA = "0x180AA7760", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0xAA9B40", Offset = "0xAA8140", VA = "0x180AA9B40")]
			[DebuggerHidden]
			public DMTCCGJSEYU(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xAA6850", Offset = "0xAA4E50", VA = "0x180AA6850", Slot = "5")]
			[DebuggerHidden]
			private void CJOOGEZDZDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x8CE7310", Offset = "0x8CE5910", VA = "0x188CE7310", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x8CE7530", Offset = "0x8CE5B30", VA = "0x188CE7530", Slot = "8")]
			[DebuggerHidden]
			private void VIZWRAVZEQM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private static Log WOAZIZZDVRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private WBQJMDDIBHA ZUWSKAGDPSV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private QXNZJJETUHB LPMOIQASLON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private IDisposable VDVNRUUOCSP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private IDisposable RSHQIQHWJQV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private HashSet<ReflectionProbe> JKGKWEDRBXR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private bool PUKGVASUWKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private bool YTHREEWHUHB;

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8CE8310", Offset = "0x8CE6910", VA = "0x188CE8310")]
		[UnityEngine.Scripting.Preserve]
		public DetectSingleProbeOptimization()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8CE77F0", Offset = "0x8CE5DF0", VA = "0x188CE77F0", Slot = "4")]
		public void InitExternal(XRIYJCZWKCD services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8CE7570", Offset = "0x8CE5B70", VA = "0x188CE7570")]
		private void AQHNOZGPMET(Scene a, LoadSceneMode b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x8CE7580", Offset = "0x8CE5B80", VA = "0x188CE7580")]
		private void CreateDeserializationHandler()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8CE81B0", Offset = "0x8CE67B0", VA = "0x188CE81B0")]
		private void ZQLRTBFCQQQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8CE7FF0", Offset = "0x8CE65F0", VA = "0x188CE7FF0")]
		private (ReflectionProbe, int) YMODJFISUQI()
		{
			return default((ReflectionProbe, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8CE7960", Offset = "0x8CE5F60", VA = "0x188CE7960")]
		[IteratorStateMachine(typeof(DMTCCGJSEYU))]
		private IEnumerator<SGCTHXNJFVM> NPSDJTQQRAJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x8CE7F10", Offset = "0x8CE6510", VA = "0x188CE7F10")]
		private void XLTZDVQSNCS([CanBeNull] ReflectionProbe reflectionProbe)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x8CE7E90", Offset = "0x8CE6490", VA = "0x188CE7E90")]
		private void RLOGJTXWHIV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x8CE7EC0", Offset = "0x8CE64C0", VA = "0x188CE7EC0")]
		private void RXGDNNQYURN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x8CE7720", Offset = "0x8CE5D20", VA = "0x188CE7720", Slot = "5")]
		public void IPUBHZMPJRZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8CE79D0", Offset = "0x8CE5FD0", VA = "0x188CE79D0")]
		[CompilerGenerated]
		private void PHXLTQQZYHK()
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
