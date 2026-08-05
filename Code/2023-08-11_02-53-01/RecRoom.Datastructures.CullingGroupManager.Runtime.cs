using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface BAGADDKELCI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KDKDKIKMABP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Camera PEFNCEPPBNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	NJDLJLDNKHA OCALMFDGEIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool JEFJKLPIGMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	NJDLJLDNKHA AKFKIECKAGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Transform HFPIIBCFJPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, IOKCCJLHHJC
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class GCOEDFBOIAJ<T> : AHCLPJBBHIO, FHEPACOHMFG<T>, GNNADOJEIPI where T : class, EECIICGPDHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x2E7C8D0", Offset = "0x2E7B0D0", VA = "0x182E7C8D0")]
			internal GCOEDFBOIAJ(int MIPOPKAGCCP, float[] ABBDFMKNGBK, BHLLKNPADLG OFCJLLHIIBD = BHLLKNPADLG.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2E7C870", Offset = "0x2E7B070", VA = "0x182E7C870", Slot = "10")]
			public void GLILACFFLBJ(T CEPDEAHBHLF, float MMDOOKNHKEB, DMDAFLHMPLA ICLICCHIBII = DMDAFLHMPLA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x2E7C8A0", Offset = "0x2E7B0A0", VA = "0x182E7C8A0", Slot = "11")]
			public void GLILACFFLBJ(T CEPDEAHBHLF, Transform NHEKAIMOAOB, float MMDOOKNHKEB, DMDAFLHMPLA ICLICCHIBII = DMDAFLHMPLA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2E7C850", Offset = "0x2E7B050", VA = "0x182E7C850", Slot = "12")]
			public void FNJGHMKCCPI(T ALMNJBBCJBG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class AHCLPJBBHIO : IDisposable, GNNADOJEIPI
		{
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public enum BHLLKNPADLG : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			private class KEICDDDDACN
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public EECIICGPDHK JCLOAFMPDNI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public DMDAFLHMPLA NDCAFKHODFD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action POLBOGACKDN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool MIJNHPOCLJP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int JNDMMPHMODJ;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
				public KEICDDDDACN()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000008")]
			[CompilerGenerated]
			private sealed class DIDGMHBEKGC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public AHCLPJBBHIO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public KEICDDDDACN trackedObject;

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
				public DIDGMHBEKGC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x6EB0920", Offset = "0x6EAF120", VA = "0x186EB0920")]
				internal void BLAOIBNADGM()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int BFLEINOKANF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int MIPOPKAGCCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int FAPFCDOGDPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool DGDBOBKJJDN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup GHPALGLCMMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] GCPDLDIGOKI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] ODJCGIELBCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly BAGADDKELCI BOBHLPNKBHC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<EECIICGPDHK, int> EACBIOIDLAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, KEICDDDDACN> AILMHLIJEED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly BHLLKNPADLG OFCJLLHIIBD;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool HENLKKLFEBC
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x20E50B0", Offset = "0x20E38B0", VA = "0x1820E50B0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x20E5090", Offset = "0x20E3890", VA = "0x1820E5090", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6EAF380", Offset = "0x6EADB80", VA = "0x186EAF380")]
			internal AHCLPJBBHIO(int MIPOPKAGCCP, float[] ABBDFMKNGBK, BHLLKNPADLG OFCJLLHIIBD = BHLLKNPADLG.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6EAED80", Offset = "0x6EAD580", VA = "0x186EAED80")]
			public void HFIJBLCOIAI(bool GNDINBDCKBO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6EAE880", Offset = "0x6EAD080", VA = "0x186EAE880", Slot = "6")]
			public void GLILACFFLBJ(EECIICGPDHK CEPDEAHBHLF, float MMDOOKNHKEB, DMDAFLHMPLA ICLICCHIBII = DMDAFLHMPLA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6EAE910", Offset = "0x6EAD110", VA = "0x186EAE910", Slot = "9")]
			public void GLILACFFLBJ(EECIICGPDHK CEPDEAHBHLF, Transform NHEKAIMOAOB, float MMDOOKNHKEB, DMDAFLHMPLA ICLICCHIBII = DMDAFLHMPLA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6EAE130", Offset = "0x6EAC930", VA = "0x186EAE130")]
			public void FNJLHABHBAI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6EAF220", Offset = "0x6EADA20", VA = "0x186EAF220")]
			private void PHJGEADFBOC(int AMOEKOMGDLG, [Optional] float? MMDOOKNHKEB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6EADD00", Offset = "0x6EAC500", VA = "0x186EADD00", Slot = "7")]
			public void FNJGHMKCCPI(EECIICGPDHK ALMNJBBCJBG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6EAD660", Offset = "0x6EABE60", VA = "0x186EAD660", Slot = "8")]
			public void DFHLIKEHLHM(EECIICGPDHK CEPDEAHBHLF, DMDAFLHMPLA JODCBBEPODM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6EAD750", Offset = "0x6EABF50", VA = "0x186EAD750", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6EAEDB0", Offset = "0x6EAD5B0", VA = "0x186EAEDB0")]
			private void IALNINNHMCP(KEICDDDDACN BLPHCDBAOEF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6EAE2B0", Offset = "0x6EACAB0", VA = "0x186EAE2B0")]
			private void FOHKGPHPPLB(KEICDDDDACN BLPHCDBAOEF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6EAF120", Offset = "0x6EAD920", VA = "0x186EAF120")]
			private void LDBLDLALLPH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6EAF1A0", Offset = "0x6EAD9A0", VA = "0x186EAF1A0")]
			private void LLBOEPLNHEB(float KMCBFGDKCFK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6EADA00", Offset = "0x6EAC200", VA = "0x186EADA00")]
			private void FJDMFHPGLHF(KEICDDDDACN BLPHCDBAOEF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6EAF210", Offset = "0x6EADA10", VA = "0x186EAF210")]
			private void MIPOCAJJJFL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6EAF190", Offset = "0x6EAD990", VA = "0x186EAF190")]
			private void LDLGIIPPIHK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6EAE540", Offset = "0x6EACD40", VA = "0x186EAE540")]
			private void GALOJGPBMLF(CullingGroupEvent LNMDKHNCMAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6EADB80", Offset = "0x6EAC380", VA = "0x186EADB80")]
			private void FLMMOLLPHCA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private struct GGAHFPPGNIA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort GOCICEJBIAL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type BCHFPIDPIHJ;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float BAIMBHOIOOP = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float KPFAIMKHIAH = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float NNNEODNBEMM = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float NFMBMNCIBBO = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float KODLNDDFHBJ = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float MJGIAAALMCP = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float PENILPKOOLO = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<GGAHFPPGNIA, AHCLPJBBHIO> PJMJMJGFEMB;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable PDMKPOJPEFB;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable LJHKKIECMJO;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static NJDLJLDNKHA CPMCKCCOEPM;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static NJDLJLDNKHA PCIDJBIKCOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly NJDLJLDNKHA EACLCAHIDKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly NJDLJLDNKHA MOHEPDGGEBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly NJDLJLDNKHA BNGHAJOFFBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private IIFKIJJEKEP OMFMLBNJMCE;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool GNDINBDCKBO;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public NJDLJLDNKHA ECDEHCMBOOM
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public NJDLJLDNKHA JJBEICLOPAH
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x7EC6C0", Offset = "0x7EAEC0", VA = "0x1807EC6C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public NJDLJLDNKHA NAGBNOCKECA
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8A5F80", Offset = "0x8A4780", VA = "0x1808A5F80", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool PAGJGEBEBAG
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x11E06F0", Offset = "0x11DEEF0", VA = "0x1811E06F0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool FOOPPKFEDGF
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x7ECD80", Offset = "0x7EB580", VA = "0x1807ECD80", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x7ECD90", Offset = "0x7EB590", VA = "0x1807ECD90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6EAF8F0", Offset = "0x6EAE0F0", VA = "0x186EAF8F0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1A6EA30", Offset = "0x1A6D230", VA = "0x181A6EA30")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6EB01C0", Offset = "0x6EAE9C0", VA = "0x186EB01C0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6EAFCD0", Offset = "0x6EAE4D0", VA = "0x186EAFCD0")]
		private void GLNDLBCEAIB(Scene JJIAFDKCLGJ, LoadSceneMode EDGJKPJHBBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6EB00E0", Offset = "0x6EAE8E0", VA = "0x186EB00E0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6EB0410", Offset = "0x6EAEC10", VA = "0x186EB0410")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6EAFF20", Offset = "0x6EAE720", VA = "0x186EAFF20")]
		private void MBBOOEKJCFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6EB01E0", Offset = "0x6EAE9E0", VA = "0x186EB01E0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6EAF9C0", Offset = "0x6EAE1C0", VA = "0x186EAF9C0")]
		private void FHJFPFFBDPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6EAFD30", Offset = "0x6EAE530", VA = "0x186EAFD30")]
		public GNNADOJEIPI GetOrCreateCullingGroup(Type EFJLPCIEOHO, int JBHGIILBCAB, ushort LFIMBIDPGHE = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3BDF400", Offset = "0x3BDDC00", VA = "0x183BDF400")]
		public FHEPACOHMFG<T> GetOrCreateCullingGroup<T>(int JBHGIILBCAB, ushort LFIMBIDPGHE = 0) where T : class, EECIICGPDHK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6EAF750", Offset = "0x6EADF50", VA = "0x186EAF750")]
		private GNNADOJEIPI AIBAFFDENOL(Type EFJLPCIEOHO, int JBHGIILBCAB, float[] ABBDFMKNGBK, ushort LFIMBIDPGHE = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3BDF1D0", Offset = "0x3BDD9D0", VA = "0x183BDF1D0")]
		private FHEPACOHMFG<T> AIBAFFDENOL<T>(int JBHGIILBCAB, float[] ABBDFMKNGBK, ushort LFIMBIDPGHE = 0) where T : class, EECIICGPDHK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x6EAFB40", Offset = "0x6EAE340", VA = "0x186EAFB40")]
		public static DOFNHLHKMBC FindClosestDefaultUpdateLod(float LAHNPIDCONB)
		{
			return default(DOFNHLHKMBC);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6EB00D0", Offset = "0x6EAE8D0", VA = "0x186EB00D0")]
		public static DOFNHLHKMBC MinUpdateLod(DOFNHLHKMBC JPFCFIGCFOE, DOFNHLHKMBC BEJGMMKKDFN)
		{
			return default(DOFNHLHKMBC);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6EB00C0", Offset = "0x6EAE8C0", VA = "0x186EB00C0")]
		public static DOFNHLHKMBC MaxUpdateLod(DOFNHLHKMBC JPFCFIGCFOE, DOFNHLHKMBC BEJGMMKKDFN)
		{
			return default(DOFNHLHKMBC);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6EB0840", Offset = "0x6EAF040", VA = "0x186EB0840")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum DOFNHLHKMBC
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	Invalid = -1
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface EECIICGPDHK
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Transform LAMNAOAMKPM
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(DOFNHLHKMBC MFLEOKKEBPK, DOFNHLHKMBC KGDFMKBNLJD);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool BIGEBELPANE);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface GNNADOJEIPI
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool HENLKKLFEBC
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GLILACFFLBJ(EECIICGPDHK CEPDEAHBHLF, float MMDOOKNHKEB, DMDAFLHMPLA ICLICCHIBII = DMDAFLHMPLA.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FNJGHMKCCPI(EECIICGPDHK ALMNJBBCJBG);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DFHLIKEHLHM(EECIICGPDHK CEPDEAHBHLF, DMDAFLHMPLA CALEJEJIPDF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FHEPACOHMFG<T> : GNNADOJEIPI where T : class, EECIICGPDHK
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GLILACFFLBJ(T CEPDEAHBHLF, float MMDOOKNHKEB, DMDAFLHMPLA ICLICCHIBII = DMDAFLHMPLA.Off);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GLILACFFLBJ(T CEPDEAHBHLF, Transform NHEKAIMOAOB, float MMDOOKNHKEB, DMDAFLHMPLA ICLICCHIBII = DMDAFLHMPLA.Off);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FNJGHMKCCPI(T ALMNJBBCJBG);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum DMDAFLHMPLA : byte
{
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	Full
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
