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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, NOMFKNGBIGI
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class FJDOIPAHBLJ<T> : KFHJMOFNKGN, DPOHGNMFKKN<T>, FHGHNLIPMAB where T : class, FGNAADCNCCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3C44350", Offset = "0x3C42950", VA = "0x183C44350")]
			internal FJDOIPAHBLJ(int ENILANIDIKH, float[] FMDMMKNAMNN, GPPIGHLBFEG JBKMNFFCOLB = GPPIGHLBFEG.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x3C442F0", Offset = "0x3C428F0", VA = "0x183C442F0", Slot = "10")]
			public void MJFEDCBJOBF(T HBFCGFKGCAF, float AMCMIGCLHDD, AHOPCOINALC FCMOAPCIKMF = AHOPCOINALC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x3C44320", Offset = "0x3C42920", VA = "0x183C44320", Slot = "11")]
			public void MJFEDCBJOBF(T HBFCGFKGCAF, Transform IMKPNNKHOJF, float AMCMIGCLHDD, AHOPCOINALC FCMOAPCIKMF = AHOPCOINALC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3C442D0", Offset = "0x3C428D0", VA = "0x183C442D0", Slot = "12")]
			public void GAGDAFIMOPK(T GAPJDKEHPJH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class KFHJMOFNKGN : IDisposable, FHGHNLIPMAB
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum GPPIGHLBFEG : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class KONDFFBKGHB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public FGNAADCNCCK EJOMCAPLLMI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public AHOPCOINALC EBLLPFCCCOO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action OFGICHLECOD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool NPIFBHPGLOB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int FPNFNABMIOF;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
				public KONDFFBKGHB()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class NFEDKJLHBMO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public KFHJMOFNKGN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public KONDFFBKGHB trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
				public NFEDKJLHBMO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x690D880", Offset = "0x690BE80", VA = "0x18690D880")]
				internal void GDMIDNAJGNM()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int MIHBFDAKBFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int ENILANIDIKH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int MFMBBAGJHLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool KIHONPKCMEM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup DMMAPDELJJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] PPPMPALNOOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] CIBJCIBIOIF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly JPPCJCNCCDN AHBNABCBLNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<FGNAADCNCCK, int> LOCLLCPKLJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, KONDFFBKGHB> BJHIPCNHEND;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly GPPIGHLBFEG JBKMNFFCOLB;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool AMKHNKNCHPE
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0xF454E0", Offset = "0xF43AE0", VA = "0x180F454E0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x4528450", Offset = "0x4526A50", VA = "0x184528450", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x690D490", Offset = "0x690BA90", VA = "0x18690D490")]
			internal KFHJMOFNKGN(int ENILANIDIKH, float[] FMDMMKNAMNN, GPPIGHLBFEG JBKMNFFCOLB = GPPIGHLBFEG.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x690CB80", Offset = "0x690B180", VA = "0x18690CB80")]
			public void KAKHNLCNDCP(bool JLJBKAOLCLE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x690D000", Offset = "0x690B600", VA = "0x18690D000", Slot = "6")]
			public void MJFEDCBJOBF(FGNAADCNCCK HBFCGFKGCAF, float AMCMIGCLHDD, AHOPCOINALC FCMOAPCIKMF = AHOPCOINALC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x690CC10", Offset = "0x690B210", VA = "0x18690CC10", Slot = "9")]
			public void MJFEDCBJOBF(FGNAADCNCCK HBFCGFKGCAF, Transform IMKPNNKHOJF, float AMCMIGCLHDD, AHOPCOINALC FCMOAPCIKMF = AHOPCOINALC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x690B8F0", Offset = "0x6909EF0", VA = "0x18690B8F0")]
			public void ADDAJPIBNLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x690BFC0", Offset = "0x690A5C0", VA = "0x18690BFC0")]
			private void EMGDKADONHO(int LLPJHIPCNFD, [Optional] float? AMCMIGCLHDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x690C0F0", Offset = "0x690A6F0", VA = "0x18690C0F0", Slot = "7")]
			public void GAGDAFIMOPK(FGNAADCNCCK GAPJDKEHPJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x690C4D0", Offset = "0x690AAD0", VA = "0x18690C4D0", Slot = "8")]
			public void HIMEELIFPLE(FGNAADCNCCK HBFCGFKGCAF, AHOPCOINALC NKIGPENJMKB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x690BCF0", Offset = "0x690A2F0", VA = "0x18690BCF0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x690D100", Offset = "0x690B700", VA = "0x18690D100")]
			private void PHHCHCBKBFB(KONDFFBKGHB KADMLOGDEHN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x690C5C0", Offset = "0x690ABC0", VA = "0x18690C5C0")]
			private void IFNHCOFKOIH(KONDFFBKGHB KADMLOGDEHN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x690CBB0", Offset = "0x690B1B0", VA = "0x18690CBB0")]
			private void KBHFMOKHDOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x690D090", Offset = "0x690B690", VA = "0x18690D090")]
			private void NCDLAILBKPF(float DGOHALMDCDO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x690BA40", Offset = "0x690A040", VA = "0x18690BA40")]
			private void AHOJKEGJKHJ(KONDFFBKGHB KADMLOGDEHN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x690BFB0", Offset = "0x690A5B0", VA = "0x18690BFB0")]
			private void EFFJMOIOEKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x690D0F0", Offset = "0x690B6F0", VA = "0x18690D0F0")]
			private void OPPIOMMIHFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x690C860", Offset = "0x690AE60", VA = "0x18690C860")]
			private void JPNJPBBMAIP(CullingGroupEvent AHBLFMBJMGN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x690BB80", Offset = "0x690A180", VA = "0x18690BB80")]
			private void CAEOFCHLLFM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct FLOMCIPALMH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort FPDOPPMIPAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type PBPKAIDKMGD;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float HPFAPJODCLO = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float HACAHPCNONB = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float FHHICELMJMG = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float BEFHINBAFFF = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float IHKKEEGIBEB = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float IIJDBJHCBHM = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float KGPMEPDICNN = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<FLOMCIPALMH, KFHJMOFNKGN> LDMJJKPPJKP;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable NPFOFJEHLCC;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable PDCMECAPGFI;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static BGECMLEGDCD BCDAMDPOEMJ;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static BGECMLEGDCD GFKBEBGFHKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly BGECMLEGDCD CNEMJAMEBBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly BGECMLEGDCD CADNMHANBHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly BGECMLEGDCD NDIAAAFAMBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private JMPIHICOHFM NLMGJPACGGK;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool JLJBKAOLCLE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public BGECMLEGDCD PHHLLLHHOOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public BGECMLEGDCD AKFMJMAHGBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x8657D0", Offset = "0x863DD0", VA = "0x1808657D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public BGECMLEGDCD HDOGOAOBAHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x866520", Offset = "0x864B20", VA = "0x180866520", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IBEKAMBLKNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xF8D5D0", Offset = "0xF8BBD0", VA = "0x180F8D5D0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool KIDCPMOIOLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9CBCB0", Offset = "0x9CA2B0", VA = "0x1809CBCB0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA26EE0", Offset = "0xA254E0", VA = "0x180A26EE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x690A670", Offset = "0x6908C70", VA = "0x18690A670", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x690B120", Offset = "0x6909720", VA = "0x18690B120")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x690B100", Offset = "0x6909700", VA = "0x18690B100")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x690ADD0", Offset = "0x69093D0", VA = "0x18690ADD0")]
		private void MMKIOIKOHLB(Scene HPPMLCIIGCM, LoadSceneMode LAHMDGOAKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x690B020", Offset = "0x6909620", VA = "0x18690B020", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x690B380", Offset = "0x6909980", VA = "0x18690B380")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x690A730", Offset = "0x6908D30", VA = "0x18690A730")]
		private void EMKFNECIKLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x690B140", Offset = "0x6909740", VA = "0x18690B140")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x690AC50", Offset = "0x6909250", VA = "0x18690AC50")]
		private void MFKCDBOBDNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x690AA30", Offset = "0x6909030", VA = "0x18690AA30")]
		public FHGHNLIPMAB GetOrCreateCullingGroup(Type DALKPPKAIBL, int IPIIOOOHAHJ, ushort BILFKLAHACC = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2966900", Offset = "0x2964F00", VA = "0x182966900")]
		public DPOHGNMFKKN<T> GetOrCreateCullingGroup<T>(int IPIIOOOHAHJ, ushort BILFKLAHACC = 0) where T : class, FGNAADCNCCK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x690AE30", Offset = "0x6909430", VA = "0x18690AE30")]
		private FHGHNLIPMAB MPKIJMFLMHC(Type DALKPPKAIBL, int IPIIOOOHAHJ, float[] FMDMMKNAMNN, ushort BILFKLAHACC = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x29669B0", Offset = "0x2964FB0", VA = "0x1829669B0")]
		private DPOHGNMFKKN<T> MPKIJMFLMHC<T>(int IPIIOOOHAHJ, float[] FMDMMKNAMNN, ushort BILFKLAHACC = 0) where T : class, FGNAADCNCCK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x690A8D0", Offset = "0x6908ED0", VA = "0x18690A8D0")]
		public static HPJFBALBIOJ FindClosestDefaultUpdateLod(float FHBCBKMIOEO)
		{
			return default(HPJFBALBIOJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x890160", Offset = "0x88E760", VA = "0x180890160")]
		public static HPJFBALBIOJ MinUpdateLod(HPJFBALBIOJ MPPPHJNCPEA, HPJFBALBIOJ PEEOJPGEDCL)
		{
			return default(HPJFBALBIOJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x690B010", Offset = "0x6909610", VA = "0x18690B010")]
		public static HPJFBALBIOJ MaxUpdateLod(HPJFBALBIOJ MPPPHJNCPEA, HPJFBALBIOJ PEEOJPGEDCL)
		{
			return default(HPJFBALBIOJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x690B7F0", Offset = "0x6909DF0", VA = "0x18690B7F0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JPPCJCNCCDN
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool ILOMLHHJHNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera MPFDIACNMIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	BGECMLEGDCD CILDDKDPBDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool APEPIPJLHEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	BGECMLEGDCD BBNMJPFMKIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform BNEGONMMFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface FHGHNLIPMAB
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool AMKHNKNCHPE
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MJFEDCBJOBF(FGNAADCNCCK HBFCGFKGCAF, float AMCMIGCLHDD, AHOPCOINALC FCMOAPCIKMF = AHOPCOINALC.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GAGDAFIMOPK(FGNAADCNCCK GAPJDKEHPJH);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HIMEELIFPLE(FGNAADCNCCK HBFCGFKGCAF, AHOPCOINALC GGJBGBIKKJG);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface DPOHGNMFKKN<T> : FHGHNLIPMAB where T : class, FGNAADCNCCK
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MJFEDCBJOBF(T HBFCGFKGCAF, float AMCMIGCLHDD, AHOPCOINALC FCMOAPCIKMF = AHOPCOINALC.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MJFEDCBJOBF(T HBFCGFKGCAF, Transform IMKPNNKHOJF, float AMCMIGCLHDD, AHOPCOINALC FCMOAPCIKMF = AHOPCOINALC.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GAGDAFIMOPK(T GAPJDKEHPJH);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FGNAADCNCCK
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform DNPKMJFBJBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(HPJFBALBIOJ BBJCFJAGFJE, HPJFBALBIOJ BNCFEMNNLIB);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool CCMANGKMKPF);
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
