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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, JMDKMEBHIKH
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class MEAPAMGDDJG<T> : OHJJKDAHNBP, OKMOJGILEIP<T>, FGIADOCIEAL where T : class, OKCPJPPOLPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3F11B90", Offset = "0x3F10D90", VA = "0x183F11B90")]
			internal MEAPAMGDDJG(int NAEGDMFLFMG, float[] HJPPPCLMEBI, ADCMHBGGJOA DNCLCLDIEJB = ADCMHBGGJOA.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x3F11B30", Offset = "0x3F10D30", VA = "0x183F11B30", Slot = "10")]
			public void GHBEENLPKLN(T GLMGCMELGFD, float MBFEDEOEGOE, DOAGAABAFKI EEJOKOBFAIG = DOAGAABAFKI.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x3F11B60", Offset = "0x3F10D60", VA = "0x183F11B60", Slot = "11")]
			public void GHBEENLPKLN(T GLMGCMELGFD, Transform BICMDJJPNHF, float MBFEDEOEGOE, DOAGAABAFKI EEJOKOBFAIG = DOAGAABAFKI.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3F11B10", Offset = "0x3F10D10", VA = "0x183F11B10", Slot = "12")]
			public void FBCLMIGJMFH(T MNCCACAKMMA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class OHJJKDAHNBP : IDisposable, FGIADOCIEAL
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum ADCMHBGGJOA : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class LOKPHBPCJGC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public OKCPJPPOLPD PAOMFBJFMLE;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public DOAGAABAFKI IPBDKOJPKIO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action GMGCFPJKIAC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool BGKNEKCOHFC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int ABDHHHCLNNL;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
				public LOKPHBPCJGC()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class BDEHGIFADMF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public OHJJKDAHNBP <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public LOKPHBPCJGC trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
				public BDEHGIFADMF()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x60FFC30", Offset = "0x60FEE30", VA = "0x1860FFC30")]
				internal void BIGAJKMEFFE()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int CCIHBMEAOML;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int NAEGDMFLFMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int HMLMMJABKEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool FKFJMFIPHOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup FEPOPKDHHPN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] BBDNGCPDAOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] OEHGKOALKJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly IAHLBEPFMHK CHEOCJAKLBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<OKCPJPPOLPD, int> EILDDACDBPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, LOKPHBPCJGC> PLIJJIFGMNJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly ADCMHBGGJOA DNCLCLDIEJB;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool NCDKBAHCEHC
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0xDEF8F0", Offset = "0xDEEAF0", VA = "0x180DEF8F0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x3F78AA0", Offset = "0x3F77CA0", VA = "0x183F78AA0", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6102B00", Offset = "0x6101D00", VA = "0x186102B00")]
			internal OHJJKDAHNBP(int NAEGDMFLFMG, float[] HJPPPCLMEBI, ADCMHBGGJOA DNCLCLDIEJB = ADCMHBGGJOA.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6102A70", Offset = "0x6101C70", VA = "0x186102A70")]
			public void MPAEAPELMIC(bool EMHHNGKPBOK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6101E40", Offset = "0x6101040", VA = "0x186101E40", Slot = "6")]
			public void GHBEENLPKLN(OKCPJPPOLPD GLMGCMELGFD, float MBFEDEOEGOE, DOAGAABAFKI EEJOKOBFAIG = DOAGAABAFKI.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6101A50", Offset = "0x6100C50", VA = "0x186101A50", Slot = "9")]
			public void GHBEENLPKLN(OKCPJPPOLPD GLMGCMELGFD, Transform BICMDJJPNHF, float MBFEDEOEGOE, DOAGAABAFKI EEJOKOBFAIG = DOAGAABAFKI.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6102460", Offset = "0x6101660", VA = "0x186102460")]
			public void KDLKKMGLENB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x61025B0", Offset = "0x61017B0", VA = "0x1861025B0")]
			private void LAAHOEKLBBP(int MBGANDEDPDN, [Optional] float? MBFEDEOEGOE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6101670", Offset = "0x6100870", VA = "0x186101670", Slot = "7")]
			public void FBCLMIGJMFH(OKCPJPPOLPD MNCCACAKMMA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6102370", Offset = "0x6101570", VA = "0x186102370", Slot = "8")]
			public void ILFGBMDNCNA(OKCPJPPOLPD GLMGCMELGFD, DOAGAABAFKI IPEMBNIDNOI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x61013B0", Offset = "0x61005B0", VA = "0x1861013B0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6101ED0", Offset = "0x61010D0", VA = "0x186101ED0")]
			private void GOGOEANALCD(LOKPHBPCJGC MDPCNAGHHAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6100FC0", Offset = "0x61001C0", VA = "0x186100FC0")]
			private void AMOCJCKKKCI(LOKPHBPCJGC MDPCNAGHHAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6102A10", Offset = "0x6101C10", VA = "0x186102A10")]
			private void MJJFNPOBMGD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6102AA0", Offset = "0x6101CA0", VA = "0x186102AA0")]
			private void NLFKHCBHFFJ(float PJADGMHMMIA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6102230", Offset = "0x6101430", VA = "0x186102230")]
			private void ICANDBONIFN(LOKPHBPCJGC MDPCNAGHHAK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6101230", Offset = "0x6100430", VA = "0x186101230")]
			private void BGBELMAKFNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x61026E0", Offset = "0x61018E0", VA = "0x1861026E0")]
			private void LNOEPAJECHN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x61026F0", Offset = "0x61018F0", VA = "0x1861026F0")]
			private void MABEPPBKNII(CullingGroupEvent ENIIBCDFPJE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6101240", Offset = "0x6100440", VA = "0x186101240")]
			private void BPPALMENINJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct HKGKIPKAECP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort EEADFLIKOCO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type FCLJJPLBOKF;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float DLDEPEPGJNC = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float OJAKGPHJHIO = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float CKDKOLEDKJC = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float KADIBIDNKMH = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float NLJLDAFBMFL = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float PHIKLIABJHN = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float HMJBDNGFJFF = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<HKGKIPKAECP, OHJJKDAHNBP> OJLJKAKOAOM;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable HHHHBDDKNJF;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable KNIFPHNJLBJ;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static DPAIEAIPOBP MKAOMDIOKBG;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static DPAIEAIPOBP NLIBJLECAAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly DPAIEAIPOBP FCEBHKCGHDH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly DPAIEAIPOBP EKAIHGKNHIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly DPAIEAIPOBP IMIGOHKGLNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private CHAGHAGMDBI IICFCFCMNKF;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool EMHHNGKPBOK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public DPAIEAIPOBP FGKCABOPDFP
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public DPAIEAIPOBP ADFNHAHLDCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7B40E0", Offset = "0x7B32E0", VA = "0x1807B40E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public DPAIEAIPOBP BJOPNPFIKJG
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7B4130", Offset = "0x7B3330", VA = "0x1807B4130", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool OHGCGAEDIFJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xD7F8B0", Offset = "0xD7EAB0", VA = "0x180D7F8B0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool IAGKLEKINDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x880780", Offset = "0x87F980", VA = "0x180880780", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x95D8F0", Offset = "0x95CAF0", VA = "0x18095D8F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x60FFEF0", Offset = "0x60FF0F0", VA = "0x1860FFEF0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6100820", Offset = "0x60FFA20", VA = "0x186100820")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6100800", Offset = "0x60FFA00", VA = "0x186100800")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6100510", Offset = "0x60FF710", VA = "0x186100510")]
		private void HBJOOPMHOAD(Scene GEPFFFNJCJE, LoadSceneMode PAIKDKBMDIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6100720", Offset = "0x60FF920", VA = "0x186100720", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6100A70", Offset = "0x60FFC70", VA = "0x186100A70")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6100570", Offset = "0x60FF770", VA = "0x186100570")]
		private void MLDPPEMDNKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6100840", Offset = "0x60FFA40", VA = "0x186100840")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x60FFD80", Offset = "0x60FEF80", VA = "0x1860FFD80")]
		private void APHJDFJFAEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x61002F0", Offset = "0x60FF4F0", VA = "0x1861002F0")]
		public FGIADOCIEAL GetOrCreateCullingGroup(Type KAKKPDBMOCB, int FONKAPLJMAH, ushort NAILOPKMLDG = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x271C500", Offset = "0x271B700", VA = "0x18271C500")]
		public OKMOJGILEIP<T> GetOrCreateCullingGroup<T>(int FONKAPLJMAH, ushort NAILOPKMLDG = 0) where T : class, OKCPJPPOLPD
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x60FFFB0", Offset = "0x60FF1B0", VA = "0x1860FFFB0")]
		private FGIADOCIEAL BMNEJJLPLBC(Type KAKKPDBMOCB, int FONKAPLJMAH, float[] HJPPPCLMEBI, ushort NAILOPKMLDG = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x271C290", Offset = "0x271B490", VA = "0x18271C290")]
		private OKMOJGILEIP<T> BMNEJJLPLBC<T>(int FONKAPLJMAH, float[] HJPPPCLMEBI, ushort NAILOPKMLDG = 0) where T : class, OKCPJPPOLPD
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6100190", Offset = "0x60FF390", VA = "0x186100190")]
		public static LABHNEIMMOD FindClosestDefaultUpdateLod(float EGGMKHJGLLJ)
		{
			return default(LABHNEIMMOD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7E20E0", Offset = "0x7E12E0", VA = "0x1807E20E0")]
		public static LABHNEIMMOD MinUpdateLod(LABHNEIMMOD JNCIEMHBLHL, LABHNEIMMOD NFPEJPAELEB)
		{
			return default(LABHNEIMMOD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6100710", Offset = "0x60FF910", VA = "0x186100710")]
		public static LABHNEIMMOD MaxUpdateLod(LABHNEIMMOD JNCIEMHBLHL, LABHNEIMMOD NFPEJPAELEB)
		{
			return default(LABHNEIMMOD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6100EC0", Offset = "0x61000C0", VA = "0x186100EC0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface IAHLBEPFMHK
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool JDKJIBKFNCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera OEHLAJLNKEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	DPAIEAIPOBP ADGOGNMPBEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool IHLJCCOJANM
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	DPAIEAIPOBP HHALJFLMOHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform CDIEIEHHLHM
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface FGIADOCIEAL
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool NCDKBAHCEHC
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GHBEENLPKLN(OKCPJPPOLPD GLMGCMELGFD, float MBFEDEOEGOE, DOAGAABAFKI EEJOKOBFAIG = DOAGAABAFKI.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FBCLMIGJMFH(OKCPJPPOLPD MNCCACAKMMA);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void ILFGBMDNCNA(OKCPJPPOLPD GLMGCMELGFD, DOAGAABAFKI OADGFDGINPP);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface OKMOJGILEIP<T> : FGIADOCIEAL where T : class, OKCPJPPOLPD
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GHBEENLPKLN(T GLMGCMELGFD, float MBFEDEOEGOE, DOAGAABAFKI EEJOKOBFAIG = DOAGAABAFKI.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GHBEENLPKLN(T GLMGCMELGFD, Transform BICMDJJPNHF, float MBFEDEOEGOE, DOAGAABAFKI EEJOKOBFAIG = DOAGAABAFKI.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FBCLMIGJMFH(T MNCCACAKMMA);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface OKCPJPPOLPD
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform DIFJEPLFOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(LABHNEIMMOD NFCAMIMIJJF, LABHNEIMMOD DAENCJNIDHN);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool IAMGENCLHPK);
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
