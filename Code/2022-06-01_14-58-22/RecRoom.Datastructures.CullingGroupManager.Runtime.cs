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
			[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
				[Cpp2IlInjected.Address(RVA = "0x17067C0", Offset = "0x17051C0", VA = "0x1817067C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x17067C0", Offset = "0x17051C0", VA = "0x1817067C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x560010", Offset = "0x55EA10", VA = "0x180560010", Slot = "8")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public override int EMPBPOCIBHI
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x5AC370", Offset = "0x5AAD70", VA = "0x1805AC370", Slot = "9")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2A85670", Offset = "0x2A84070", VA = "0x182A85670")]
			internal PEMKNCNFGEK(int DJLBKHBOLAB, float[] FFBILPONMDE, ALAGIJAIBPL CGMJIIEEBJI = ALAGIJAIBPL.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2A85470", Offset = "0x2A83E70", VA = "0x182A85470", Slot = "10")]
			public override void KCAONHHKDMN(bool PBGCOGCBHJN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2A83860", Offset = "0x2A82260", VA = "0x182A83860", Slot = "11")]
			public ICADDILGGHK AGFKNKOHHEF(float FBJPJICFPMB)
			{
				return default(ICADDILGGHK);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2A83970", Offset = "0x2A82370", VA = "0x182A83970", Slot = "12")]
			public void CEGAKGBDODP(T FBOGCDJOCBP, float HANLHANBIHK, MMHOOHHJEDF LMOCADCFPCA = MMHOOHHJEDF.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x2A83A10", Offset = "0x2A82410", VA = "0x182A83A10", Slot = "13")]
			public void CEGAKGBDODP(T FBOGCDJOCBP, Transform NEFHPIILHIN, float HANLHANBIHK, MMHOOHHJEDF LMOCADCFPCA = MMHOOHHJEDF.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x2A854A0", Offset = "0x2A83EA0", VA = "0x182A854A0", Slot = "14")]
			public void LBJJOMIHNDH(T FBOGCDJOCBP, [Optional] float? HANLHANBIHK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x2A83E90", Offset = "0x2A82890", VA = "0x182A83E90")]
			private void CLKCDMNHELD(int LGBFGOJBLFK, [Optional] float? HANLHANBIHK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x2A84100", Offset = "0x2A82B00", VA = "0x182A84100", Slot = "15")]
			public void DFDJPGANONL(T KIACIOJCJGJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x2A85520", Offset = "0x2A83F20", VA = "0x182A85520", Slot = "16")]
			public ICADDILGGHK LHEDGBPFNOM(T FBOGCDJOCBP)
			{
				return default(ICADDILGGHK);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x2A84000", Offset = "0x2A82A00", VA = "0x182A84000", Slot = "17")]
			public bool CNJJNPPPNKI(T FBOGCDJOCBP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x2A84D30", Offset = "0x2A83730", VA = "0x182A84D30", Slot = "18")]
			public void HLBPHHEGHOP(T FBOGCDJOCBP, MMHOOHHJEDF NODMKINDALI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x2A84510", Offset = "0x2A82F10", VA = "0x182A84510", Slot = "7")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x2A850C0", Offset = "0x2A83AC0", VA = "0x182A850C0")]
			private void JCKGFAMBOME(BAFGANHFCME KHADIHCANFP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x2A84E40", Offset = "0x2A83840", VA = "0x182A84E40")]
			private void JBOFAKCDCAJ(BAFGANHFCME KHADIHCANFP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x2A83900", Offset = "0x2A82300", VA = "0x182A83900")]
			private void BALKEIDHGBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x2A844A0", Offset = "0x2A82EA0", VA = "0x182A844A0")]
			private void DJHDPBKJDJG(float IOHNEIJDHEF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x2A838C0", Offset = "0x2A822C0", VA = "0x182A838C0")]
			private void AHOIJIKBFCH(BAFGANHFCME KHADIHCANFP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x2A84890", Offset = "0x2A83290", VA = "0x182A84890")]
			private void FNCEHFBAOGN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x2A85640", Offset = "0x2A84040", VA = "0x182A85640")]
			private void OAMNHBCPDJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x2A84A20", Offset = "0x2A83420", VA = "0x182A84A20")]
			private void HBICIJLECBJ(CullingGroupEvent GBPNIBJBEHP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x2A848B0", Offset = "0x2A832B0", VA = "0x182A848B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x564080", Offset = "0x562A80", VA = "0x180564080", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public HDFEEIPOLMP INDGGPMFDDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x5644B0", Offset = "0x562EB0", VA = "0x1805644B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public HDFEEIPOLMP FJLBKFAHIMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x564490", Offset = "0x562E90", VA = "0x180564490", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool MELNBBBOHKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xCB0F00", Offset = "0xCAF900", VA = "0x180CB0F00", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool FIHNJBEJADP
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7739A0", Offset = "0x7723A0", VA = "0x1807739A0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x773AC0", Offset = "0x7724C0", VA = "0x180773AC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1912F80", Offset = "0x1911980", VA = "0x181912F80", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x19135A0", Offset = "0x1911FA0", VA = "0x1819135A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1913580", Offset = "0x1911F80", VA = "0x181913580")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1913020", Offset = "0x1911A20", VA = "0x181913020")]
		private void DFKFOICPCIB(Scene CAEKOHCNJCA, LoadSceneMode OMMBLABNACO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x19134D0", Offset = "0x1911ED0", VA = "0x1819134D0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1913270", Offset = "0x1911C70", VA = "0x181913270")]
		private void GKIMMDLHFNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x19135C0", Offset = "0x1911FC0", VA = "0x1819135C0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1912E20", Offset = "0x1911820", VA = "0x181912E20")]
		private void AOKIIEIEOBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x2B991E0", Offset = "0x2B97BE0", VA = "0x182B991E0")]
		public global::AEPMBONFIDF<T> GetOrCreateCullingGroup<T>(int EJFJFAOELAJ, ushort OMKCNAHFCDO = 0) where T : AGBGEAMPHNL
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x2B98FD0", Offset = "0x2B979D0", VA = "0x182B98FD0")]
		private global::AEPMBONFIDF<T> ELIPLBNLHBK<T>(int EJFJFAOELAJ, float[] FFBILPONMDE, ushort OMKCNAHFCDO = 0) where T : AGBGEAMPHNL
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x1913080", Offset = "0x1911A80", VA = "0x181913080")]
		public static ICADDILGGHK FindClosestDefaultUpdateLod(float GIFMCMNDCIN)
		{
			return default(ICADDILGGHK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1913470", Offset = "0x1911E70", VA = "0x181913470")]
		public static ICADDILGGHK MinUpdateLod(ICADDILGGHK ELGGBACOIJK, ICADDILGGHK BAMBCEJAEFE)
		{
			return default(ICADDILGGHK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1913410", Offset = "0x1911E10", VA = "0x181913410")]
		public static ICADDILGGHK MaxUpdateLod(ICADDILGGHK ELGGBACOIJK, ICADDILGGHK BAMBCEJAEFE)
		{
			return default(ICADDILGGHK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1913950", Offset = "0x1912350", VA = "0x181913950")]
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
		[Cpp2IlInjected.Address(RVA = "0x1913AB0", Offset = "0x19124B0", VA = "0x181913AB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public ICADDILGGHK BBKCNBJJDCL
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x560010", Offset = "0x55EA10", VA = "0x180560010")]
		get
		{
			return default(ICADDILGGHK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public ICADDILGGHK CIGDOLDHAOK
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5AC370", Offset = "0x5AAD70", VA = "0x1805AC370")]
		get
		{
			return default(ICADDILGGHK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1913A40", Offset = "0x1912440", VA = "0x181913A40")]
	public bool FJPEKBFHMIJ(object LBAGELALLHA, ICADDILGGHK HPIAFNBPEPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1913B00", Offset = "0x1912500", VA = "0x181913B00")]
	public bool JBHAMDMNDIL(object LBAGELALLHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x1913B60", Offset = "0x1912560", VA = "0x181913B60")]
	private bool JOOLMJNFDMB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x1913CD0", Offset = "0x19126D0", VA = "0x181913CD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
	public LGGEBEFKHFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1914080", Offset = "0x1912A80", VA = "0x181914080")]
	private static string OGKENCFMFPL(byte[] ODMIEFIFOGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1913D50", Offset = "0x1912750", VA = "0x181913D50")]
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
		[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
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
