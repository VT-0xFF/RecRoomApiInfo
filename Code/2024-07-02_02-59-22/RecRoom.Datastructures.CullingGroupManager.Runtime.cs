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
			[Cpp2IlInjected.Address(RVA = "0x3C5ED40", Offset = "0x3C5DD40", VA = "0x183C5ED40")]
			internal FJDOIPAHBLJ(int ENILANIDIKH, float[] FMDMMKNAMNN, GPPIGHLBFEG JBKMNFFCOLB = GPPIGHLBFEG.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x3C5ECE0", Offset = "0x3C5DCE0", VA = "0x183C5ECE0", Slot = "10")]
			public void MJFEDCBJOBF(T HBFCGFKGCAF, float AMCMIGCLHDD, AHOPCOINALC FCMOAPCIKMF = AHOPCOINALC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x3C5ED10", Offset = "0x3C5DD10", VA = "0x183C5ED10", Slot = "11")]
			public void MJFEDCBJOBF(T HBFCGFKGCAF, Transform IMKPNNKHOJF, float AMCMIGCLHDD, AHOPCOINALC FCMOAPCIKMF = AHOPCOINALC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3C5ECC0", Offset = "0x3C5DCC0", VA = "0x183C5ECC0", Slot = "12")]
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
				[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
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
				[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
				public NFEDKJLHBMO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x693FD90", Offset = "0x693ED90", VA = "0x18693FD90")]
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
				[Cpp2IlInjected.Address(RVA = "0xF4D450", Offset = "0xF4C450", VA = "0x180F4D450")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x4549F10", Offset = "0x4548F10", VA = "0x184549F10", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x693F9A0", Offset = "0x693E9A0", VA = "0x18693F9A0")]
			internal KFHJMOFNKGN(int ENILANIDIKH, float[] FMDMMKNAMNN, GPPIGHLBFEG JBKMNFFCOLB = GPPIGHLBFEG.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x693F090", Offset = "0x693E090", VA = "0x18693F090")]
			public void KAKHNLCNDCP(bool JLJBKAOLCLE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x693F510", Offset = "0x693E510", VA = "0x18693F510", Slot = "6")]
			public void MJFEDCBJOBF(FGNAADCNCCK HBFCGFKGCAF, float AMCMIGCLHDD, AHOPCOINALC FCMOAPCIKMF = AHOPCOINALC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x693F120", Offset = "0x693E120", VA = "0x18693F120", Slot = "9")]
			public void MJFEDCBJOBF(FGNAADCNCCK HBFCGFKGCAF, Transform IMKPNNKHOJF, float AMCMIGCLHDD, AHOPCOINALC FCMOAPCIKMF = AHOPCOINALC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x693DE00", Offset = "0x693CE00", VA = "0x18693DE00")]
			public void ADDAJPIBNLD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x693E4D0", Offset = "0x693D4D0", VA = "0x18693E4D0")]
			private void EMGDKADONHO(int LLPJHIPCNFD, [Optional] float? AMCMIGCLHDD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x693E600", Offset = "0x693D600", VA = "0x18693E600", Slot = "7")]
			public void GAGDAFIMOPK(FGNAADCNCCK GAPJDKEHPJH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x693E9E0", Offset = "0x693D9E0", VA = "0x18693E9E0", Slot = "8")]
			public void HIMEELIFPLE(FGNAADCNCCK HBFCGFKGCAF, AHOPCOINALC NKIGPENJMKB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x693E200", Offset = "0x693D200", VA = "0x18693E200", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x693F610", Offset = "0x693E610", VA = "0x18693F610")]
			private void PHHCHCBKBFB(KONDFFBKGHB KADMLOGDEHN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x693EAD0", Offset = "0x693DAD0", VA = "0x18693EAD0")]
			private void IFNHCOFKOIH(KONDFFBKGHB KADMLOGDEHN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x693F0C0", Offset = "0x693E0C0", VA = "0x18693F0C0")]
			private void KBHFMOKHDOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x693F5A0", Offset = "0x693E5A0", VA = "0x18693F5A0")]
			private void NCDLAILBKPF(float DGOHALMDCDO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x693DF50", Offset = "0x693CF50", VA = "0x18693DF50")]
			private void AHOJKEGJKHJ(KONDFFBKGHB KADMLOGDEHN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x693E4C0", Offset = "0x693D4C0", VA = "0x18693E4C0")]
			private void EFFJMOIOEKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x693F600", Offset = "0x693E600", VA = "0x18693F600")]
			private void OPPIOMMIHFB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x693ED70", Offset = "0x693DD70", VA = "0x18693ED70")]
			private void JPNJPBBMAIP(CullingGroupEvent AHBLFMBJMGN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x693E090", Offset = "0x693D090", VA = "0x18693E090")]
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
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public BGECMLEGDCD AKFMJMAHGBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x8687D0", Offset = "0x8677D0", VA = "0x1808687D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public BGECMLEGDCD HDOGOAOBAHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x869520", Offset = "0x868520", VA = "0x180869520", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IBEKAMBLKNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xF95340", Offset = "0xF94340", VA = "0x180F95340", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool KIDCPMOIOLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9CFAC0", Offset = "0x9CEAC0", VA = "0x1809CFAC0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA2B380", Offset = "0xA2A380", VA = "0x180A2B380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x693CB80", Offset = "0x693BB80", VA = "0x18693CB80", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x693D630", Offset = "0x693C630", VA = "0x18693D630")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x693D610", Offset = "0x693C610", VA = "0x18693D610")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x693D2E0", Offset = "0x693C2E0", VA = "0x18693D2E0")]
		private void MMKIOIKOHLB(Scene HPPMLCIIGCM, LoadSceneMode LAHMDGOAKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x693D530", Offset = "0x693C530", VA = "0x18693D530", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x693D890", Offset = "0x693C890", VA = "0x18693D890")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x693CC40", Offset = "0x693BC40", VA = "0x18693CC40")]
		private void EMKFNECIKLA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x693D650", Offset = "0x693C650", VA = "0x18693D650")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x693D160", Offset = "0x693C160", VA = "0x18693D160")]
		private void MFKCDBOBDNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x693CF40", Offset = "0x693BF40", VA = "0x18693CF40")]
		public FHGHNLIPMAB GetOrCreateCullingGroup(Type DALKPPKAIBL, int IPIIOOOHAHJ, ushort BILFKLAHACC = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x29770C0", Offset = "0x29760C0", VA = "0x1829770C0")]
		public DPOHGNMFKKN<T> GetOrCreateCullingGroup<T>(int IPIIOOOHAHJ, ushort BILFKLAHACC = 0) where T : class, FGNAADCNCCK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x693D340", Offset = "0x693C340", VA = "0x18693D340")]
		private FHGHNLIPMAB MPKIJMFLMHC(Type DALKPPKAIBL, int IPIIOOOHAHJ, float[] FMDMMKNAMNN, ushort BILFKLAHACC = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2977170", Offset = "0x2976170", VA = "0x182977170")]
		private DPOHGNMFKKN<T> MPKIJMFLMHC<T>(int IPIIOOOHAHJ, float[] FMDMMKNAMNN, ushort BILFKLAHACC = 0) where T : class, FGNAADCNCCK
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x693CDE0", Offset = "0x693BDE0", VA = "0x18693CDE0")]
		public static HPJFBALBIOJ FindClosestDefaultUpdateLod(float FHBCBKMIOEO)
		{
			return default(HPJFBALBIOJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x893160", Offset = "0x892160", VA = "0x180893160")]
		public static HPJFBALBIOJ MinUpdateLod(HPJFBALBIOJ MPPPHJNCPEA, HPJFBALBIOJ PEEOJPGEDCL)
		{
			return default(HPJFBALBIOJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x693D520", Offset = "0x693C520", VA = "0x18693D520")]
		public static HPJFBALBIOJ MaxUpdateLod(HPJFBALBIOJ MPPPHJNCPEA, HPJFBALBIOJ PEEOJPGEDCL)
		{
			return default(HPJFBALBIOJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x693DD00", Offset = "0x693CD00", VA = "0x18693DD00")]
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
