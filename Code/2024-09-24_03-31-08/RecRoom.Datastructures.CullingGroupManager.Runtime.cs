using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, FHBBCAHMAHF
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class PNEGIDJACKF<T> : PKPOLGNPBII, EJOJBBEGKFK<T>, IDBCJKICNLJ where T : class, FNJKPCHPEGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x49C28E0", Offset = "0x49C12E0", VA = "0x1849C28E0")]
			internal PNEGIDJACKF(int GFNGAILHLKF, float[] KADCAKNPGMB, NGGHEBLDKIG BNNLLJMJBED = NGGHEBLDKIG.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x49C28B0", Offset = "0x49C12B0", VA = "0x1849C28B0", Slot = "10")]
			public void KDCHLCHLBCK(T FHFDEAHMMBI, float KGJKNMNONHN, JGCAFIGAFFP HAPMMCPGNHE = JGCAFIGAFFP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x49C2880", Offset = "0x49C1280", VA = "0x1849C2880", Slot = "11")]
			public void KDCHLCHLBCK(T FHFDEAHMMBI, Transform FMNJPLNFCIN, float KGJKNMNONHN, JGCAFIGAFFP HAPMMCPGNHE = JGCAFIGAFFP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x49C2860", Offset = "0x49C1260", VA = "0x1849C2860", Slot = "12")]
			public void GDFNAHCIADO(T IPKEOAMPPKF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class PKPOLGNPBII : IDisposable, IDBCJKICNLJ
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum NGGHEBLDKIG : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class JLBOKICALEB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public FNJKPCHPEGH ILOIGOCAOMI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public JGCAFIGAFFP GEBCAHDJIJO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action LPFOBCEFPCA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool AFOIJOBJBEC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int BDIPFIAMOOH;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
				public JLBOKICALEB()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class PFBBJBBIODJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public PKPOLGNPBII <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public JLBOKICALEB trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
				public PFBBJBBIODJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x6B65190", Offset = "0x6B63B90", VA = "0x186B65190")]
				internal void OEFNAGLPIFG()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int PNNFPDMJMCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int GFNGAILHLKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int BAMIDGGKEFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool PJFKAIJIJGP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup PNLKLIOMHIG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] APABHKPKEKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] LDHOMOKBHCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly BPGCPOOGGAN HILLMDJLLHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<FNJKPCHPEGH, int> KMBEADKJJGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, JLBOKICALEB> OAEOPGOMGFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly NGGHEBLDKIG BNNLLJMJBED;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool IDIPFDNHBDG
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0xAAC070", Offset = "0xAAAA70", VA = "0x180AAC070")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x477AB20", Offset = "0x4779520", VA = "0x18477AB20", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6B66E20", Offset = "0x6B65820", VA = "0x186B66E20")]
			internal PKPOLGNPBII(int GFNGAILHLKF, float[] KADCAKNPGMB, NGGHEBLDKIG BNNLLJMJBED = NGGHEBLDKIG.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6B65D10", Offset = "0x6B64710", VA = "0x186B65D10")]
			public void HHCLPHILCCC(bool CFEOBBJAIIN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6B66AB0", Offset = "0x6B654B0", VA = "0x186B66AB0", Slot = "6")]
			public void KDCHLCHLBCK(FNJKPCHPEGH FHFDEAHMMBI, float KGJKNMNONHN, JGCAFIGAFFP HAPMMCPGNHE = JGCAFIGAFFP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6B666C0", Offset = "0x6B650C0", VA = "0x186B666C0", Slot = "9")]
			public void KDCHLCHLBCK(FNJKPCHPEGH FHFDEAHMMBI, Transform FMNJPLNFCIN, float KGJKNMNONHN, JGCAFIGAFFP HAPMMCPGNHE = JGCAFIGAFFP.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6B657E0", Offset = "0x6B641E0", VA = "0x186B657E0")]
			public void EIMAACIPPMD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6B66590", Offset = "0x6B64F90", VA = "0x186B66590")]
			private void KDCDBCAKMPA(int ENMILGHAHOM, [Optional] float? KGJKNMNONHN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6B65930", Offset = "0x6B64330", VA = "0x186B65930", Slot = "7")]
			public void GDFNAHCIADO(FNJKPCHPEGH IPKEOAMPPKF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6B656F0", Offset = "0x6B640F0", VA = "0x186B656F0", Slot = "8")]
			public void EHCIOPBHPON(FNJKPCHPEGH FHFDEAHMMBI, JGCAFIGAFFP GMKDNADONOH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6B65430", Offset = "0x6B63E30", VA = "0x186B65430", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6B66060", Offset = "0x6B64A60", VA = "0x186B66060")]
			private void IAAICHOIBLN(JLBOKICALEB OBPADBHPPPC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6B66BB0", Offset = "0x6B655B0", VA = "0x186B66BB0")]
			private void NIFFLBPGJHM(JLBOKICALEB OBPADBHPPPC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6B66B50", Offset = "0x6B65550", VA = "0x186B66B50")]
			private void LMEBMNGMDAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6B663C0", Offset = "0x6B64DC0", VA = "0x186B663C0")]
			private void IDKLIDCFBLN(float CPLJOMEDMHK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6B652E0", Offset = "0x6B63CE0", VA = "0x186B652E0")]
			private void AMJFOKCKBIE(JLBOKICALEB OBPADBHPPPC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6B65420", Offset = "0x6B63E20", VA = "0x186B65420")]
			private void CKIFIEPEOOJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6B66B40", Offset = "0x6B65540", VA = "0x186B66B40")]
			private void LKIMGKDFFHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6B65D40", Offset = "0x6B64740", VA = "0x186B65D40")]
			private void HOBDMFKAGIB(CullingGroupEvent ILBJDNELAOJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6B66420", Offset = "0x6B64E20", VA = "0x186B66420")]
			private void JHILIOEEDNP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct FJCDCNNKPJH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort FJALGPDPDKM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type EOOCNPJOIMD;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float JONIOIPGGPO = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float HCEDNMAHAPH = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float EHFJKFHCJPI = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float LFLICNGIOPP = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float GOCABFGGCOC = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float OKLDGMPPAIC = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float PAFGBBCIBCD = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<FJCDCNNKPJH, PKPOLGNPBII> MELCKIHMJJG;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable EALLLMGDODB;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable EOFEFHOKDCB;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static BPJHNJKJMPB HNLNEJDJADN;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static BPJHNJKJMPB PIPNKMEHCKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly BPJHNJKJMPB BIDBFGHCMEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly BPJHNJKJMPB CNDLIKCDJOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly BPJHNJKJMPB LKHGPDAEFJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private CHBCKIOGPHP HJKIDPCIKCG;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool CFEOBBJAIIN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public BPJHNJKJMPB BAHNJHAAADM
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public BPJHNJKJMPB HBOPJPEMNBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public BPJHNJKJMPB BJDJDLPHPGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x888EA0", Offset = "0x8878A0", VA = "0x180888EA0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool KCFILBEIAKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x15F01B0", Offset = "0x15EEBB0", VA = "0x1815F01B0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool JJPFJOKJCKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xC320D0", Offset = "0xC30AD0", VA = "0x180C320D0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xD12ED0", Offset = "0xD118D0", VA = "0x180D12ED0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6B64120", Offset = "0x6B62B20", VA = "0x186B64120", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6B649F0", Offset = "0x6B633F0", VA = "0x186B649F0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6B649D0", Offset = "0x6B633D0", VA = "0x186B649D0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6B640C0", Offset = "0x6B62AC0", VA = "0x186B640C0")]
		private void ADDGEDMNGLO(Scene GAFAAAGMMJN, LoadSceneMode LKBCPIIGDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6B648F0", Offset = "0x6B632F0", VA = "0x186B648F0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6B64C40", Offset = "0x6B63640", VA = "0x186B64C40")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6B643C0", Offset = "0x6B62DC0", VA = "0x186B643C0")]
		private void DMPIDAGDMLE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6B64A10", Offset = "0x6B63410", VA = "0x186B64A10")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6B63F50", Offset = "0x6B62950", VA = "0x186B63F50")]
		private void AANGACFAJAK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6B646C0", Offset = "0x6B630C0", VA = "0x186B646C0")]
		public IDBCJKICNLJ GetOrCreateCullingGroup(Type LDAGOGINIGD, int JBFBHOIOBIH, ushort AOJLENDDNPP = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2B88040", Offset = "0x2B86A40", VA = "0x182B88040")]
		public EJOJBBEGKFK<T> GetOrCreateCullingGroup<T>(int JBFBHOIOBIH, ushort AOJLENDDNPP = 0) where T : class, FNJKPCHPEGH
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6B641E0", Offset = "0x6B62BE0", VA = "0x186B641E0")]
		private IDBCJKICNLJ DALFMEKJCMP(Type LDAGOGINIGD, int JBFBHOIOBIH, float[] KADCAKNPGMB, ushort AOJLENDDNPP = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2B87DB0", Offset = "0x2B867B0", VA = "0x182B87DB0")]
		private EJOJBBEGKFK<T> DALFMEKJCMP<T>(int JBFBHOIOBIH, float[] KADCAKNPGMB, ushort AOJLENDDNPP = 0) where T : class, FNJKPCHPEGH
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6B64560", Offset = "0x6B62F60", VA = "0x186B64560")]
		public static HDLBMLPIHPN FindClosestDefaultUpdateLod(float OGLHDNKDKCB)
		{
			return default(HDLBMLPIHPN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8B1160", Offset = "0x8AFB60", VA = "0x1808B1160")]
		public static HDLBMLPIHPN MinUpdateLod(HDLBMLPIHPN NCMJOIOFGMF, HDLBMLPIHPN FDMOONCEDPB)
		{
			return default(HDLBMLPIHPN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6B648E0", Offset = "0x6B632E0", VA = "0x186B648E0")]
		public static HDLBMLPIHPN MaxUpdateLod(HDLBMLPIHPN NCMJOIOFGMF, HDLBMLPIHPN FDMOONCEDPB)
		{
			return default(HDLBMLPIHPN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6B65090", Offset = "0x6B63A90", VA = "0x186B65090")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface BPGCPOOGGAN
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool JOLIMMBAGGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera MBBNLCIEGNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	BPJHNJKJMPB AMNKBJJMHEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool FILONHMONCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	BPJHNJKJMPB NCDJFPMAEGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform OAAIKNOMDKE
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface IDBCJKICNLJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool IDIPFDNHBDG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KDCHLCHLBCK(FNJKPCHPEGH FHFDEAHMMBI, float KGJKNMNONHN, JGCAFIGAFFP HAPMMCPGNHE = JGCAFIGAFFP.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GDFNAHCIADO(FNJKPCHPEGH IPKEOAMPPKF);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EHCIOPBHPON(FNJKPCHPEGH FHFDEAHMMBI, JGCAFIGAFFP IGJLEPBFNFK);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface EJOJBBEGKFK<T> : IDBCJKICNLJ where T : class, FNJKPCHPEGH
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KDCHLCHLBCK(T FHFDEAHMMBI, float KGJKNMNONHN, JGCAFIGAFFP HAPMMCPGNHE = JGCAFIGAFFP.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KDCHLCHLBCK(T FHFDEAHMMBI, Transform FMNJPLNFCIN, float KGJKNMNONHN, JGCAFIGAFFP HAPMMCPGNHE = JGCAFIGAFFP.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GDFNAHCIADO(T IPKEOAMPPKF);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FNJKPCHPEGH
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform ICGEMCDDICC
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(HDLBMLPIHPN KEMJDCKCHMC, HDLBMLPIHPN PDPCPICHGFG);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool ELHHPBLDOIH);
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
