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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, JLLGIDDFMND
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class CBKKABJAPHJ<T> : IJEFPKNIKGG, KJNIMNBMNOP<T>, IPCOLFCLNPN where T : class, BHBELFGOFDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x4726B40", Offset = "0x4725F40", VA = "0x184726B40")]
			internal CBKKABJAPHJ(int PMHNHBGHHAN, float[] HOGJDJFKDJI, CIIDOIMPNDA NILOFMDAJIL = CIIDOIMPNDA.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x4726AC0", Offset = "0x4725EC0", VA = "0x184726AC0", Slot = "10")]
			public void BKKEPFPDOJH(T ECLCDMJMICA, float PFKJICHCDMG, FMGKNGKCHKA ABAKLNAOGBG = FMGKNGKCHKA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x4726AF0", Offset = "0x4725EF0", VA = "0x184726AF0", Slot = "11")]
			public void BKKEPFPDOJH(T ECLCDMJMICA, Transform GGGBGOCFEFH, float PFKJICHCDMG, FMGKNGKCHKA ABAKLNAOGBG = FMGKNGKCHKA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x4726B20", Offset = "0x4725F20", VA = "0x184726B20", Slot = "12")]
			public void HBMDGHADMGB(T LCHMMIJPJBH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class IJEFPKNIKGG : IDisposable, IPCOLFCLNPN
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum CIIDOIMPNDA : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class JLHDFEDKNDB
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public BHBELFGOFDE JIDIONOIDNP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public FMGKNGKCHKA CEIGCMDLJFN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action LEPPJFBNIPF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool DJNILHJODIN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int FFCPNJCJDLL;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
				public JLHDFEDKNDB()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class DFBOHJKDFGJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public IJEFPKNIKGG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public JLHDFEDKNDB trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
				public DFBOHJKDFGJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x5DDCD30", Offset = "0x5DDC130", VA = "0x185DDCD30")]
				internal void LLNLGIMLKEI()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int HGIBHKIHFOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int PMHNHBGHHAN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int HBCDOOFIAFP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool CIECAMCCGCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup FNIPLNKILKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] AIFPAGPGIOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] ACKELOPFKOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly NPJPOMCBDKF MNLFLOOOFMA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<BHBELFGOFDE, int> PCAAKEPOLJL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, JLHDFEDKNDB> AKDDKJKIAJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CIIDOIMPNDA NILOFMDAJIL;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool NIMGLNLHNJM
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x1AC23D0", Offset = "0x1AC17D0", VA = "0x181AC23D0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x3D13990", Offset = "0x3D12D90", VA = "0x183D13990", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x5DDEA20", Offset = "0x5DDDE20", VA = "0x185DDEA20")]
			internal IJEFPKNIKGG(int PMHNHBGHHAN, float[] HOGJDJFKDJI, CIIDOIMPNDA NILOFMDAJIL = CIIDOIMPNDA.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5DDCE80", Offset = "0x5DDC280", VA = "0x185DDCE80")]
			public void ADNPEOBHGOP(bool ALGPNNBDODD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x5DDCEB0", Offset = "0x5DDC2B0", VA = "0x185DDCEB0", Slot = "6")]
			public void BKKEPFPDOJH(BHBELFGOFDE ECLCDMJMICA, float PFKJICHCDMG, FMGKNGKCHKA ABAKLNAOGBG = FMGKNGKCHKA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5DDCF40", Offset = "0x5DDC340", VA = "0x185DDCF40", Slot = "9")]
			public void BKKEPFPDOJH(BHBELFGOFDE ECLCDMJMICA, Transform GGGBGOCFEFH, float PFKJICHCDMG, FMGKNGKCHKA ABAKLNAOGBG = FMGKNGKCHKA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5DDDB40", Offset = "0x5DDCF40", VA = "0x185DDDB40")]
			public void IOKCFGKGCNL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5DDDC90", Offset = "0x5DDD090", VA = "0x185DDDC90")]
			private void JAICAMKBMMD(int DIENMHDGFGP, [Optional] float? PFKJICHCDMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5DDD660", Offset = "0x5DDCA60", VA = "0x185DDD660", Slot = "7")]
			public void HBMDGHADMGB(BHBELFGOFDE LCHMMIJPJBH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5DDDA40", Offset = "0x5DDCE40", VA = "0x185DDDA40", Slot = "8")]
			public void HKDHABNNJGN(BHBELFGOFDE ECLCDMJMICA, FMGKNGKCHKA BHPCPJIIHLM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5DDD330", Offset = "0x5DDC730", VA = "0x185DDD330", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5DDE3F0", Offset = "0x5DDD7F0", VA = "0x185DDE3F0")]
			private void NMFIILBCJBA(JLHDFEDKNDB NADOGEAOAMI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5DDE780", Offset = "0x5DDDB80", VA = "0x185DDE780")]
			private void NNJOAHDFKDI(JLHDFEDKNDB NADOGEAOAMI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5DDDDC0", Offset = "0x5DDD1C0", VA = "0x185DDDDC0")]
			private void JEIEBHCHCHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5DDD600", Offset = "0x5DDCA00", VA = "0x185DDD600")]
			private void EBDAKHCENGC(float EMIPGAHFJBJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5DDDF90", Offset = "0x5DDD390", VA = "0x185DDDF90")]
			private void MCDCLHCPJEB(JLHDFEDKNDB NADOGEAOAMI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5DDD5F0", Offset = "0x5DDC9F0", VA = "0x185DDD5F0")]
			private void EACJBCHECHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5DDDB30", Offset = "0x5DDCF30", VA = "0x185DDDB30")]
			private void IGFPBMBKOAB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5DDE0D0", Offset = "0x5DDD4D0", VA = "0x185DDE0D0")]
			private void MOJLOJAGLKC(CullingGroupEvent PJLCDBPOOMI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5DDDE20", Offset = "0x5DDD220", VA = "0x185DDDE20")]
			private void KCNNBMLONKA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct NJDBDNHKEKH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort CDDGEJAHEDM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type BAMHCDEDHGL;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float DEKJEKBNEEG = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float KFCCPBNNHOO = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float IGMAFFLBJIJ = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float KFBNGKMAEOA = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float BAPBDGNECJG = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float GJDKNEJDLCD = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float IKEKDNPEFGK = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<NJDBDNHKEKH, IJEFPKNIKGG> EAMPKGCNFED;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable AEMLKANALHA;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable CCGGMDIMMLA;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static FCJKIAIKOOM OFBKLCEEEIN;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static FCJKIAIKOOM DGHOMFOFILF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly FCJKIAIKOOM CHDPALMJPBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly FCJKIAIKOOM FMMDGNKAIHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly FCJKIAIKOOM GJPOMFNBGDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private BDOFDMHMNPK HNPMPNFKHDA;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool ALGPNNBDODD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public FCJKIAIKOOM PDADHHCIMPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public FCJKIAIKOOM DANLBKMEPPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x775A80", Offset = "0x774E80", VA = "0x180775A80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public FCJKIAIKOOM BGNAIANAHNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x773860", Offset = "0x772C60", VA = "0x180773860", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool DOOPCINNPIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xBFA0F0", Offset = "0xBF94F0", VA = "0x180BFA0F0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool LALPPCINPFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7C7CA0", Offset = "0x7C70A0", VA = "0x1807C7CA0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7C70C0", Offset = "0x7C64C0", VA = "0x1807C70C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5DDBAB0", Offset = "0x5DDAEB0", VA = "0x185DDBAB0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5DDC3C0", Offset = "0x5DDB7C0", VA = "0x185DDC3C0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5DDC3A0", Offset = "0x5DDB7A0", VA = "0x185DDC3A0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5DDC250", Offset = "0x5DDB650", VA = "0x185DDC250")]
		private void LKCJOKMBONA(Scene CBOHDHCKOLN, LoadSceneMode LEIDKMNBCMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5DDC2C0", Offset = "0x5DDB6C0", VA = "0x185DDC2C0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5DDC7C0", Offset = "0x5DDBBC0", VA = "0x185DDC7C0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5DDC3E0", Offset = "0x5DDB7E0", VA = "0x185DDC3E0")]
		private void PFOKAPDGNAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5DDC580", Offset = "0x5DDB980", VA = "0x185DDC580")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5DDC0D0", Offset = "0x5DDB4D0", VA = "0x185DDC0D0")]
		private void JLLALLIHABJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5DDBEB0", Offset = "0x5DDB2B0", VA = "0x185DDBEB0")]
		public IPCOLFCLNPN GetOrCreateCullingGroup(Type GCJHCEIKCII, int DEEMGACJGAP, ushort KCKHPAKEMOB = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2372E80", Offset = "0x2372280", VA = "0x182372E80")]
		public KJNIMNBMNOP<T> GetOrCreateCullingGroup<T>(int DEEMGACJGAP, ushort KCKHPAKEMOB = 0) where T : class, BHBELFGOFDE
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5DDBCD0", Offset = "0x5DDB0D0", VA = "0x185DDBCD0")]
		private IPCOLFCLNPN GHOCLFKCDEK(Type GCJHCEIKCII, int DEEMGACJGAP, float[] HOGJDJFKDJI, ushort KCKHPAKEMOB = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2372C10", Offset = "0x2372010", VA = "0x182372C10")]
		private KJNIMNBMNOP<T> GHOCLFKCDEK<T>(int DEEMGACJGAP, float[] HOGJDJFKDJI, ushort KCKHPAKEMOB = 0) where T : class, BHBELFGOFDE
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5DDBB70", Offset = "0x5DDAF70", VA = "0x185DDBB70")]
		public static EFOCEKEKLEE FindClosestDefaultUpdateLod(float OGFOGECKLFI)
		{
			return default(EFOCEKEKLEE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x79F000", Offset = "0x79E400", VA = "0x18079F000")]
		public static EFOCEKEKLEE MinUpdateLod(EFOCEKEKLEE BNJLDMMNJIL, EFOCEKEKLEE KCJPEEBKIOE)
		{
			return default(EFOCEKEKLEE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5DDC2B0", Offset = "0x5DDB6B0", VA = "0x185DDC2B0")]
		public static EFOCEKEKLEE MaxUpdateLod(EFOCEKEKLEE BNJLDMMNJIL, EFOCEKEKLEE KCJPEEBKIOE)
		{
			return default(EFOCEKEKLEE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5DDCC30", Offset = "0x5DDC030", VA = "0x185DDCC30")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NPJPOMCBDKF
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool EBPKKBNBBOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera IKNCMOPMJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	FCJKIAIKOOM IMPJPMPGHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool EHONOEANDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	FCJKIAIKOOM MFHODBIIENK
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform FJKFPFCIBND
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface IPCOLFCLNPN
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool NIMGLNLHNJM
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BKKEPFPDOJH(BHBELFGOFDE ECLCDMJMICA, float PFKJICHCDMG, FMGKNGKCHKA ABAKLNAOGBG = FMGKNGKCHKA.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HBMDGHADMGB(BHBELFGOFDE LCHMMIJPJBH);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HKDHABNNJGN(BHBELFGOFDE ECLCDMJMICA, FMGKNGKCHKA MEIBMBCGGHM);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface KJNIMNBMNOP<T> : IPCOLFCLNPN where T : class, BHBELFGOFDE
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BKKEPFPDOJH(T ECLCDMJMICA, float PFKJICHCDMG, FMGKNGKCHKA ABAKLNAOGBG = FMGKNGKCHKA.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BKKEPFPDOJH(T ECLCDMJMICA, Transform GGGBGOCFEFH, float PFKJICHCDMG, FMGKNGKCHKA ABAKLNAOGBG = FMGKNGKCHKA.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HBMDGHADMGB(T LCHMMIJPJBH);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface BHBELFGOFDE
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform BMCDLFLGACJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(EFOCEKEKLEE HINODNBJLFA, EFOCEKEKLEE HBJELDNKGOL);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool AOBBJJFEJKE);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum FMGKNGKCHKA : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum EFOCEKEKLEE
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	TwoPointFiveMeters = 0,
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	FiveMeters = 1,
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	TenMeters = 2,
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	TwentyMeters = 3,
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	FiftyMeters = 4,
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	HundredMeters = 5,
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	FiveHundredMeters = 6,
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	GreaterThanFiveHundredMeters = 7,
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	Invalid = -1
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
