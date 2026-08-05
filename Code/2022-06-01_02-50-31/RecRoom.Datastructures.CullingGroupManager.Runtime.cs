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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, JGALIOBJCGI
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private abstract class OHEDLLIOILP : IDisposable, GDKMCNAPHEF
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public abstract int ANLCNJFOEFF
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(Slot = "8")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public abstract int EMPBPOCIBHI
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
			public abstract void KCAONHHKDMN(bool PBGCOGCBHJN);

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
			protected OHEDLLIOILP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class PEMKNCNFGEK<T> : OHEDLLIOILP, global::AEPMBONFIDF<T>, GDKMCNAPHEF where T : AGBGEAMPHNL
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum ALAGIJAIBPL : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class BAFGANHFCME
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public T PJELALKEFJC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public MMHOOHHJEDF PAFMDFNAAJJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public Action MOKHLKPPDMC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public bool DLGMNAGABBF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public int LJFCMJHPBPF;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x218A560", Offset = "0x2188F60", VA = "0x18218A560")]
				public BAFGANHFCME()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class GKPPNJICKFM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public PEMKNCNFGEK<T> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public BAFGANHFCME trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x218A560", Offset = "0x2188F60", VA = "0x18218A560")]
				public GKPPNJICKFM()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int OKAPJBEAGOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int DJLBKHBOLAB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int MJJGNEHCLBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool NPBJPMMAPDK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly CullingGroup BOEPPPFPKGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private BoundingSphere[] OGCNPOEBFJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private Transform[] BNPBPFFHHDI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly MJHDNPODMLJ LNJKINMJMME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly Dictionary<T, int> IKJKPIFOADB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<int, BAFGANHFCME> ICAEKCEJLCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly ALAGIJAIBPL CGMJIIEEBJI;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public override int ANLCNJFOEFF
			{
				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x54F010", Offset = "0x54DA10", VA = "0x18054F010", Slot = "8")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public override int EMPBPOCIBHI
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x59B370", Offset = "0x599D70", VA = "0x18059B370", Slot = "9")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x25A4B50", Offset = "0x25A3550", VA = "0x1825A4B50")]
			internal PEMKNCNFGEK(int DJLBKHBOLAB, float[] FFBILPONMDE, ALAGIJAIBPL CGMJIIEEBJI = ALAGIJAIBPL.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x25A4950", Offset = "0x25A3350", VA = "0x1825A4950", Slot = "10")]
			public override void KCAONHHKDMN(bool PBGCOGCBHJN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x25A2D40", Offset = "0x25A1740", VA = "0x1825A2D40", Slot = "11")]
			public ICADDILGGHK AGFKNKOHHEF(float FBJPJICFPMB)
			{
				return default(ICADDILGGHK);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x25A2E50", Offset = "0x25A1850", VA = "0x1825A2E50", Slot = "12")]
			public void CEGAKGBDODP(T FBOGCDJOCBP, float HANLHANBIHK, MMHOOHHJEDF LMOCADCFPCA = MMHOOHHJEDF.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x25A2EF0", Offset = "0x25A18F0", VA = "0x1825A2EF0", Slot = "13")]
			public void CEGAKGBDODP(T FBOGCDJOCBP, Transform NEFHPIILHIN, float HANLHANBIHK, MMHOOHHJEDF LMOCADCFPCA = MMHOOHHJEDF.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x25A4980", Offset = "0x25A3380", VA = "0x1825A4980", Slot = "14")]
			public void LBJJOMIHNDH(T FBOGCDJOCBP, [Optional] float? HANLHANBIHK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x25A3370", Offset = "0x25A1D70", VA = "0x1825A3370")]
			private void CLKCDMNHELD(int LGBFGOJBLFK, [Optional] float? HANLHANBIHK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x25A35E0", Offset = "0x25A1FE0", VA = "0x1825A35E0", Slot = "15")]
			public void DFDJPGANONL(T KIACIOJCJGJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x25A4A00", Offset = "0x25A3400", VA = "0x1825A4A00", Slot = "16")]
			public ICADDILGGHK LHEDGBPFNOM(T FBOGCDJOCBP)
			{
				return default(ICADDILGGHK);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x25A34E0", Offset = "0x25A1EE0", VA = "0x1825A34E0", Slot = "17")]
			public bool CNJJNPPPNKI(T FBOGCDJOCBP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x25A4210", Offset = "0x25A2C10", VA = "0x1825A4210", Slot = "18")]
			public void HLBPHHEGHOP(T FBOGCDJOCBP, MMHOOHHJEDF NODMKINDALI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x25A39F0", Offset = "0x25A23F0", VA = "0x1825A39F0", Slot = "7")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x25A45A0", Offset = "0x25A2FA0", VA = "0x1825A45A0")]
			private void JCKGFAMBOME(BAFGANHFCME KHADIHCANFP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x25A4320", Offset = "0x25A2D20", VA = "0x1825A4320")]
			private void JBOFAKCDCAJ(BAFGANHFCME KHADIHCANFP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x25A2DE0", Offset = "0x25A17E0", VA = "0x1825A2DE0")]
			private void BALKEIDHGBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x25A3980", Offset = "0x25A2380", VA = "0x1825A3980")]
			private void DJHDPBKJDJG(float IOHNEIJDHEF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x25A2DA0", Offset = "0x25A17A0", VA = "0x1825A2DA0")]
			private void AHOIJIKBFCH(BAFGANHFCME KHADIHCANFP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x25A3D70", Offset = "0x25A2770", VA = "0x1825A3D70")]
			private void FNCEHFBAOGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x25A4B20", Offset = "0x25A3520", VA = "0x1825A4B20")]
			private void OAMNHBCPDJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x25A3F00", Offset = "0x25A2900", VA = "0x1825A3F00")]
			private void HBICIJLECBJ(CullingGroupEvent GBPNIBJBEHP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x25A3D90", Offset = "0x25A2790", VA = "0x1825A3D90")]
			private void FOIHDEFJPPM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct BOHODEEGIMH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public ushort CAINPOMKFCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Type PKLBKAJBKJJ;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float HAKMNCBJEPJ = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float OJJHJPDMKBL = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float JOPIDCINJLC = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float NPPNGIIMBNN = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float AEJEPNCAKAO = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float CLKINFFPJKF = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float MHBJFMKCAPB = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<BOHODEEGIMH, OHEDLLIOILP> BGMBJCPPPFA;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable JJHAFEAIAEH;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable OGNENPHMGOG;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static HDFEEIPOLMP PKNFGLAGEGN;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static HDFEEIPOLMP AIOCIIAOIOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly HDFEEIPOLMP JIDDKFJKOOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly HDFEEIPOLMP FDKHALFBPEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly HDFEEIPOLMP AIKAOEGFKHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private LMANBCGFHOA MHEMPACFAKP;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool PBGCOGCBHJN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public HDFEEIPOLMP LKEOHOPJDBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x553080", Offset = "0x551A80", VA = "0x180553080", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public HDFEEIPOLMP INDGGPMFDDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x5534B0", Offset = "0x551EB0", VA = "0x1805534B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public HDFEEIPOLMP FJLBKFAHIMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x553490", Offset = "0x551E90", VA = "0x180553490", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool MELNBBBOHKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x1B38DB0", Offset = "0x1B377B0", VA = "0x181B38DB0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool FIHNJBEJADP
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7045A0", Offset = "0x702FA0", VA = "0x1807045A0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7046C0", Offset = "0x7030C0", VA = "0x1807046C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4D77110", Offset = "0x4D75B10", VA = "0x184D77110", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1410500", Offset = "0x140EF00", VA = "0x181410500")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4D77710", Offset = "0x4D76110", VA = "0x184D77710")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4D771B0", Offset = "0x4D75BB0", VA = "0x184D771B0")]
		private void DFKFOICPCIB(Scene CAEKOHCNJCA, LoadSceneMode OMMBLABNACO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4D77660", Offset = "0x4D76060", VA = "0x184D77660", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4D77400", Offset = "0x4D75E00", VA = "0x184D77400")]
		private void GKIMMDLHFNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4D77730", Offset = "0x4D76130", VA = "0x184D77730")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4D76FB0", Offset = "0x4D759B0", VA = "0x184D76FB0")]
		private void AOKIIEIEOBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2623900", Offset = "0x2622300", VA = "0x182623900")]
		public global::AEPMBONFIDF<T> GetOrCreateCullingGroup<T>(int EJFJFAOELAJ, ushort OMKCNAHFCDO = 0) where T : AGBGEAMPHNL
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x26236F0", Offset = "0x26220F0", VA = "0x1826236F0")]
		private global::AEPMBONFIDF<T> ELIPLBNLHBK<T>(int EJFJFAOELAJ, float[] FFBILPONMDE, ushort OMKCNAHFCDO = 0) where T : AGBGEAMPHNL
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x4D77210", Offset = "0x4D75C10", VA = "0x184D77210")]
		public static ICADDILGGHK FindClosestDefaultUpdateLod(float GIFMCMNDCIN)
		{
			return default(ICADDILGGHK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4D77600", Offset = "0x4D76000", VA = "0x184D77600")]
		public static ICADDILGGHK MinUpdateLod(ICADDILGGHK ELGGBACOIJK, ICADDILGGHK BAMBCEJAEFE)
		{
			return default(ICADDILGGHK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4D775A0", Offset = "0x4D75FA0", VA = "0x184D775A0")]
		public static ICADDILGGHK MaxUpdateLod(ICADDILGGHK ELGGBACOIJK, ICADDILGGHK BAMBCEJAEFE)
		{
			return default(ICADDILGGHK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4D77AC0", Offset = "0x4D764C0", VA = "0x184D77AC0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MJHDNPODMLJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool MAKDGGFKIMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Camera HAHBOMMEHDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	HDFEEIPOLMP PIJEEGDGKAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool IOKNOFNEHLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	HDFEEIPOLMP LEOEILDHJKI
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform FJOHNPGCOGO
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface GDKMCNAPHEF
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int ANLCNJFOEFF
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int EMPBPOCIBHI
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface AEPMBONFIDF<T> : GDKMCNAPHEF where T : AGBGEAMPHNL
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ICADDILGGHK AGFKNKOHHEF(float FBJPJICFPMB);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CEGAKGBDODP(T FBOGCDJOCBP, float HANLHANBIHK, MMHOOHHJEDF LMOCADCFPCA = MMHOOHHJEDF.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CEGAKGBDODP(T FBOGCDJOCBP, Transform NEFHPIILHIN, float HANLHANBIHK, MMHOOHHJEDF LMOCADCFPCA = MMHOOHHJEDF.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LBJJOMIHNDH(T FBOGCDJOCBP, [Optional] float? HANLHANBIHK);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DFDJPGANONL(T KIACIOJCJGJ);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ICADDILGGHK LHEDGBPFNOM(T FBOGCDJOCBP);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool CNJJNPPPNKI(T FBOGCDJOCBP);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HLBPHHEGHOP(T FBOGCDJOCBP, MMHOOHHJEDF LGCDAPDFONB);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface AGBGEAMPHNL
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Transform NHLOMEFHHNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(ICADDILGGHK MIDOHEEKKPM, ICADDILGGHK MIMOIBINNHF);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool LMCMNPCGBNA);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum MMHOOHHJEDF : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum ICADDILGGHK
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
public class JLOEFCCHIIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private ICADDILGGHK CJILIEPCADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private ICADDILGGHK AOLLHLFGLAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<object, ICADDILGGHK> EDAHPJOJLJD;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool BMFBMPCPNAP
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4D77C20", Offset = "0x4D76620", VA = "0x184D77C20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ICADDILGGHK BBKCNBJJDCL
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x54F010", Offset = "0x54DA10", VA = "0x18054F010")]
		get
		{
			return default(ICADDILGGHK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public ICADDILGGHK CIGDOLDHAOK
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x59B370", Offset = "0x599D70", VA = "0x18059B370")]
		get
		{
			return default(ICADDILGGHK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4D77BB0", Offset = "0x4D765B0", VA = "0x184D77BB0")]
	public bool FJPEKBFHMIJ(object LBAGELALLHA, ICADDILGGHK HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4D77C70", Offset = "0x4D76670", VA = "0x184D77C70")]
	public bool JBHAMDMNDIL(object LBAGELALLHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4D77CD0", Offset = "0x4D766D0", VA = "0x184D77CD0")]
	private bool JOOLMJNFDMB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4D77E40", Offset = "0x4D76840", VA = "0x184D77E40")]
	public JLOEFCCHIIH()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class LGGEBEFKHFL
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static byte[] BNGJCABJHMJ;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int DABHOAMPMJG;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int JKHLNLJIIMI;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static BigInteger DBPEINBOKAP;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
	public LGGEBEFKHFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4D781F0", Offset = "0x4D76BF0", VA = "0x184D781F0")]
	private static string OGKENCFMFPL(byte[] ODMIEFIFOGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4D77EC0", Offset = "0x4D768C0", VA = "0x184D77EC0")]
	public static string KDPIBNPAHEL(byte[] MCBNAPIFOAJ, bool LELELDJDMBB)
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
		[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
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
