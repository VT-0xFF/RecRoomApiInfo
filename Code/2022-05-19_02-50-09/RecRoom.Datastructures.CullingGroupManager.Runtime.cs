using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, KPONONJDOFL
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private abstract class EBPNNCKJFPE : IDisposable, KFANCAOEPCB
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public abstract int NDEDOIKCBHA
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(Slot = "8")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public abstract int HKLJFPICPDE
			{
				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(Slot = "9")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract void Dispose();

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "10")]
			public abstract void IMDIDDCJMHB(bool ALKAINDNFNM);

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
			protected EBPNNCKJFPE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class MIIFAJNEABH<T> : EBPNNCKJFPE, global::PJIDMGENMKK<T>, KFANCAOEPCB where T : OGHGGEEOAHF
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum HAPFMKFBHJA : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class FPKFDEKLCBC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public T IBJFKDDIMDG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public EHDPHGGPPBO OAFKECAEFEJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public Action INNCCMPIJNA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public bool NFEPOEOIHIM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public int BPILIAKMPMN;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760490", VA = "0x180761890")]
				public FPKFDEKLCBC()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class BJMEKPOEECN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public MIIFAJNEABH<T> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public FPKFDEKLCBC trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760490", VA = "0x180761890")]
				public BJMEKPOEECN()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int LPDDMOKJAGO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int AJKKODAAAOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int LIHINPBMMKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool KNMBINEJEHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly CullingGroup BKMHJGFJFNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private BoundingSphere[] AOFLPPNCNKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private Transform[] JPMKAAIJMNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly IHLKPFIOCMJ LHLELLOMELP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly Dictionary<T, int> KOLKLEMBDDD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<int, FPKFDEKLCBC> MHDJNCELPDB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly HAPFMKFBHJA MKHJKAKLMGO;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public override int NDEDOIKCBHA
			{
				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x54F010", Offset = "0x54DC10", VA = "0x18054F010", Slot = "8")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public override int HKLJFPICPDE
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x59B370", Offset = "0x599F70", VA = "0x18059B370", Slot = "9")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2714C00", Offset = "0x2713800", VA = "0x182714C00")]
			internal MIIFAJNEABH(int AJKKODAAAOF, float[] HCHOBMPPDEN, HAPFMKFBHJA MKHJKAKLMGO = HAPFMKFBHJA.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2714490", Offset = "0x2713090", VA = "0x182714490", Slot = "10")]
			public override void IMDIDDCJMHB(bool ALKAINDNFNM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2714100", Offset = "0x2712D00", VA = "0x182714100", Slot = "11")]
			public GPPOKHICGPH GONPPGHFHKA(float EJCGLICPFHP)
			{
				return default(GPPOKHICGPH);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2713B00", Offset = "0x2712700", VA = "0x182713B00", Slot = "12")]
			public void DLPDCPCMKFM(T KLDDDNGBABC, float KMHFJPBFKJO, EHDPHGGPPBO PJNEMJHOFJD = EHDPHGGPPBO.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x2713680", Offset = "0x2712280", VA = "0x182713680", Slot = "13")]
			public void DLPDCPCMKFM(T KLDDDNGBABC, Transform DBCKMNLPNOD, float KMHFJPBFKJO, EHDPHGGPPBO PJNEMJHOFJD = EHDPHGGPPBO.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2714410", Offset = "0x2713010", VA = "0x182714410", Slot = "14")]
			public void ILDKIIHGLMM(T KLDDDNGBABC, [Optional] float? KMHFJPBFKJO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x27144C0", Offset = "0x27130C0", VA = "0x1827144C0")]
			private void MAEEBIMDKEA(int KMCFICBBFCD, [Optional] float? KMHFJPBFKJO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2712FA0", Offset = "0x2711BA0", VA = "0x182712FA0", Slot = "15")]
			public void AFEKNPNIBII(T NPHEJDEPHLJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x2714630", Offset = "0x2713230", VA = "0x182714630", Slot = "16")]
			public GPPOKHICGPH NGJPEMDHHFD(T KLDDDNGBABC)
			{
				return default(GPPOKHICGPH);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2714B00", Offset = "0x2713700", VA = "0x182714B00", Slot = "17")]
			public bool PPGJMDOOCDJ(T KLDDDNGBABC)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2712E50", Offset = "0x2711A50", VA = "0x182712E50", Slot = "18")]
			public void ABLBNPDOHPO(T KLDDDNGBABC, EHDPHGGPPBO LPNLKIEIAMP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2713BA0", Offset = "0x27127A0", VA = "0x182713BA0", Slot = "7")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2714750", Offset = "0x2713350", VA = "0x182714750")]
			private void OAIFACLGGCH(FPKFDEKLCBC DDKBBALDGMM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2713400", Offset = "0x2712000", VA = "0x182713400")]
			private void DHGKPMKJGLC(FPKFDEKLCBC DDKBBALDGMM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x2713390", Offset = "0x2711F90", VA = "0x182713390")]
			private void CLHNABLKLKL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x2714090", Offset = "0x2712C90", VA = "0x182714090")]
			private void GEKECODCIAI(float MGNFBGKNNLO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x2712F60", Offset = "0x2711B60", VA = "0x182712F60")]
			private void ADBMEFHGBHK(FPKFDEKLCBC DDKBBALDGMM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x2713340", Offset = "0x2711F40", VA = "0x182713340")]
			private void BCKFELPKNKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x2713360", Offset = "0x2711F60", VA = "0x182713360")]
			private void CAHFBAEHKKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x2714160", Offset = "0x2712D60", VA = "0x182714160")]
			private void IDOGMEJBHPP(CullingGroupEvent BEOBPDNPJHK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x2713F20", Offset = "0x2712B20", VA = "0x182713F20")]
			private void FOJLEEBANHN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct IJPEOBJMOOL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public ushort BFOCJOEHHLO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Type AFFBGFHOMGD;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float GBJFEIOIJLE = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float LHEOBCOKFFB = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float AENAOJDCIGF = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float GBHPJAFHFIJ = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float CLKEDLINDOK = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float PBJFJGEHOAC = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float MMLKFDBHLMK = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<IJPEOBJMOOL, EBPNNCKJFPE> DGFOPGPGEIA;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable OCMDDAJNKAI;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable GDFPBEJFOMG;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static GGJPBMMBEKM ICDBNNGMJOP;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static GGJPBMMBEKM OFNLHEDOLBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly GGJPBMMBEKM LHJHKHADKGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly GGJPBMMBEKM ENGHMOAOPBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly GGJPBMMBEKM NOIBHIDLPBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private OLAOJJPOAKP GPLAMAGCCHE;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool ALKAINDNFNM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public GGJPBMMBEKM EOEDFPEGLGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551C80", VA = "0x180553080", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GGJPBMMBEKM PLEBJGOBHHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x5534B0", Offset = "0x5520B0", VA = "0x1805534B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public GGJPBMMBEKM EMDPIGLJPPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x553490", Offset = "0x552090", VA = "0x180553490", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool NLMCILGPMLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xBCB6C0", Offset = "0xBCA2C0", VA = "0x180BCB6C0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool DELIABLELFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x695C60", Offset = "0x694860", VA = "0x180695C60", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x695C80", Offset = "0x694880", VA = "0x180695C80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x17C6BB0", Offset = "0x17C57B0", VA = "0x1817C6BB0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x17C7330", Offset = "0x17C5F30", VA = "0x1817C7330")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x17C7310", Offset = "0x17C5F10", VA = "0x1817C7310")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x17C6C50", Offset = "0x17C5850", VA = "0x1817C6C50")]
		private void BJJCLIGPNCM(Scene NIFMLODPLFJ, LoadSceneMode KGGLFNEDFOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x17C7260", Offset = "0x17C5E60", VA = "0x1817C7260", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x17C6CB0", Offset = "0x17C58B0", VA = "0x1817C6CB0")]
		private void DEIFKCBDLAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x17C7350", Offset = "0x17C5F50", VA = "0x1817C7350")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x17C7040", Offset = "0x17C5C40", VA = "0x1817C7040")]
		private void LHCJPMIEKHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2F14AA0", Offset = "0x2F136A0", VA = "0x182F14AA0")]
		public global::PJIDMGENMKK<T> GetOrCreateCullingGroup<T>(int JGOCDKEDMDM, ushort JOEDBDJMBMH = 0) where T : OGHGGEEOAHF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2F14B50", Offset = "0x2F13750", VA = "0x182F14B50")]
		private global::PJIDMGENMKK<T> PAFHBIIMPKL<T>(int JGOCDKEDMDM, float[] HCHOBMPPDEN, ushort JOEDBDJMBMH = 0) where T : OGHGGEEOAHF
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x17C6E50", Offset = "0x17C5A50", VA = "0x1817C6E50")]
		public static GPPOKHICGPH FindClosestDefaultUpdateLod(float LEAFNIKEMCI)
		{
			return default(GPPOKHICGPH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x17C7200", Offset = "0x17C5E00", VA = "0x1817C7200")]
		public static GPPOKHICGPH MinUpdateLod(GPPOKHICGPH LLODJPKIADN, GPPOKHICGPH FJIGEMILFGB)
		{
			return default(GPPOKHICGPH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x17C71A0", Offset = "0x17C5DA0", VA = "0x1817C71A0")]
		public static GPPOKHICGPH MaxUpdateLod(GPPOKHICGPH LLODJPKIADN, GPPOKHICGPH FJIGEMILFGB)
		{
			return default(GPPOKHICGPH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x17C76E0", Offset = "0x17C62E0", VA = "0x1817C76E0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface IHLKPFIOCMJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool CAFJNDFHAMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Camera BFMHHCFLPPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	GGJPBMMBEKM DAEDNMAODDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool LDOGCJMCDAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	GGJPBMMBEKM GLLDJCNBPGL
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform AADFNEECONK
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KFANCAOEPCB
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int NDEDOIKCBHA
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int HKLJFPICPDE
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface PJIDMGENMKK<T> : KFANCAOEPCB where T : OGHGGEEOAHF
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GPPOKHICGPH GONPPGHFHKA(float EJCGLICPFHP);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DLPDCPCMKFM(T KLDDDNGBABC, float KMHFJPBFKJO, EHDPHGGPPBO PJNEMJHOFJD = EHDPHGGPPBO.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DLPDCPCMKFM(T KLDDDNGBABC, Transform DBCKMNLPNOD, float KMHFJPBFKJO, EHDPHGGPPBO PJNEMJHOFJD = EHDPHGGPPBO.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ILDKIIHGLMM(T KLDDDNGBABC, [Optional] float? KMHFJPBFKJO);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AFEKNPNIBII(T NPHEJDEPHLJ);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GPPOKHICGPH NGJPEMDHHFD(T KLDDDNGBABC);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PPGJMDOOCDJ(T KLDDDNGBABC);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ABLBNPDOHPO(T KLDDDNGBABC, EHDPHGGPPBO AHCKANGFIKM);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface OGHGGEEOAHF
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Transform NCBCHKMGJIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(GPPOKHICGPH PBMHABMKGHD, GPPOKHICGPH MIELCBBPIBJ);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool MEFADDKNBHH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum EHDPHGGPPBO : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum GPPOKHICGPH
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	Invalid = -1
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class BNDLLDEFJKD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private GPPOKHICGPH CDKHOMPCPAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private GPPOKHICGPH HHNPPNHMFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<object, GPPOKHICGPH> PIAFNNPBJLO;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool AFFBEKBPCNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x17C68A0", Offset = "0x17C54A0", VA = "0x1817C68A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public GPPOKHICGPH FNCCMANDLFL
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x54F010", Offset = "0x54DC10", VA = "0x18054F010")]
		get
		{
			return default(GPPOKHICGPH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public GPPOKHICGPH LBHEGPJPBKK
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x59B370", Offset = "0x599F70", VA = "0x18059B370")]
		get
		{
			return default(GPPOKHICGPH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x17C68F0", Offset = "0x17C54F0", VA = "0x1817C68F0")]
	public bool CPPEMODJEHC(object BCFIBCIPMFN, GPPOKHICGPH JHEBJPCMJGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x17C6960", Offset = "0x17C5560", VA = "0x1817C6960")]
	public bool EINMKINKIBF(object BCFIBCIPMFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x17C69C0", Offset = "0x17C55C0", VA = "0x1817C69C0")]
	private bool OPFKPLNLLCL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x17C6B30", Offset = "0x17C5730", VA = "0x1817C6B30")]
	public BNDLLDEFJKD()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class DFHLNHOECAE
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static byte[] BPCJOEHDNHL;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int JGOMGPKCOBP;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int EJPBFKNOMCK;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static BigInteger DKHAKAEJLPK;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
	public DFHLNHOECAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x17C77D0", Offset = "0x17C63D0", VA = "0x1817C77D0")]
	private static string ALAJABKKJNA(byte[] JCHDICMDCKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x17C78D0", Offset = "0x17C64D0", VA = "0x1817C78D0")]
	public static string NBAPPGOEMPA(byte[] GLAICJAMEED, bool NFOOKAPIMMN)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
