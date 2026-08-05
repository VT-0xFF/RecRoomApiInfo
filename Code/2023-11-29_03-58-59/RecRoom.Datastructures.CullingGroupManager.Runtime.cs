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
			[Cpp2IlInjected.Address(RVA = "0x4725720", Offset = "0x4724B20", VA = "0x184725720")]
			internal CBKKABJAPHJ(int PMHNHBGHHAN, float[] HOGJDJFKDJI, CIIDOIMPNDA NILOFMDAJIL = CIIDOIMPNDA.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x47256A0", Offset = "0x4724AA0", VA = "0x1847256A0", Slot = "10")]
			public void BKKEPFPDOJH(T ECLCDMJMICA, float PFKJICHCDMG, FMGKNGKCHKA ABAKLNAOGBG = FMGKNGKCHKA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x47256D0", Offset = "0x4724AD0", VA = "0x1847256D0", Slot = "11")]
			public void BKKEPFPDOJH(T ECLCDMJMICA, Transform GGGBGOCFEFH, float PFKJICHCDMG, FMGKNGKCHKA ABAKLNAOGBG = FMGKNGKCHKA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x4725700", Offset = "0x4724B00", VA = "0x184725700", Slot = "12")]
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
				[Cpp2IlInjected.Address(RVA = "0x5DDCE10", Offset = "0x5DDC210", VA = "0x185DDCE10")]
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
				[Cpp2IlInjected.Address(RVA = "0x1AC21D0", Offset = "0x1AC15D0", VA = "0x181AC21D0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x3D12540", Offset = "0x3D11940", VA = "0x183D12540", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x5DDEB00", Offset = "0x5DDDF00", VA = "0x185DDEB00")]
			internal IJEFPKNIKGG(int PMHNHBGHHAN, float[] HOGJDJFKDJI, CIIDOIMPNDA NILOFMDAJIL = CIIDOIMPNDA.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5DDCF60", Offset = "0x5DDC360", VA = "0x185DDCF60")]
			public void ADNPEOBHGOP(bool ALGPNNBDODD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x5DDCF90", Offset = "0x5DDC390", VA = "0x185DDCF90", Slot = "6")]
			public void BKKEPFPDOJH(BHBELFGOFDE ECLCDMJMICA, float PFKJICHCDMG, FMGKNGKCHKA ABAKLNAOGBG = FMGKNGKCHKA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5DDD020", Offset = "0x5DDC420", VA = "0x185DDD020", Slot = "9")]
			public void BKKEPFPDOJH(BHBELFGOFDE ECLCDMJMICA, Transform GGGBGOCFEFH, float PFKJICHCDMG, FMGKNGKCHKA ABAKLNAOGBG = FMGKNGKCHKA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5DDDC20", Offset = "0x5DDD020", VA = "0x185DDDC20")]
			public void IOKCFGKGCNL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5DDDD70", Offset = "0x5DDD170", VA = "0x185DDDD70")]
			private void JAICAMKBMMD(int DIENMHDGFGP, [Optional] float? PFKJICHCDMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5DDD740", Offset = "0x5DDCB40", VA = "0x185DDD740", Slot = "7")]
			public void HBMDGHADMGB(BHBELFGOFDE LCHMMIJPJBH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5DDDB20", Offset = "0x5DDCF20", VA = "0x185DDDB20", Slot = "8")]
			public void HKDHABNNJGN(BHBELFGOFDE ECLCDMJMICA, FMGKNGKCHKA BHPCPJIIHLM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5DDD410", Offset = "0x5DDC810", VA = "0x185DDD410", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5DDE4D0", Offset = "0x5DDD8D0", VA = "0x185DDE4D0")]
			private void NMFIILBCJBA(JLHDFEDKNDB NADOGEAOAMI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5DDE860", Offset = "0x5DDDC60", VA = "0x185DDE860")]
			private void NNJOAHDFKDI(JLHDFEDKNDB NADOGEAOAMI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5DDDEA0", Offset = "0x5DDD2A0", VA = "0x185DDDEA0")]
			private void JEIEBHCHCHL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5DDD6E0", Offset = "0x5DDCAE0", VA = "0x185DDD6E0")]
			private void EBDAKHCENGC(float EMIPGAHFJBJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5DDE070", Offset = "0x5DDD470", VA = "0x185DDE070")]
			private void MCDCLHCPJEB(JLHDFEDKNDB NADOGEAOAMI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5DDD6D0", Offset = "0x5DDCAD0", VA = "0x185DDD6D0")]
			private void EACJBCHECHC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5DDDC10", Offset = "0x5DDD010", VA = "0x185DDDC10")]
			private void IGFPBMBKOAB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5DDE1B0", Offset = "0x5DDD5B0", VA = "0x185DDE1B0")]
			private void MOJLOJAGLKC(CullingGroupEvent PJLCDBPOOMI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5DDDF00", Offset = "0x5DDD300", VA = "0x185DDDF00")]
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
			[Cpp2IlInjected.Address(RVA = "0xBFA040", Offset = "0xBF9440", VA = "0x180BFA040", Slot = "9")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DDBB90", Offset = "0x5DDAF90", VA = "0x185DDBB90", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5DDC4A0", Offset = "0x5DDB8A0", VA = "0x185DDC4A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5DDC480", Offset = "0x5DDB880", VA = "0x185DDC480")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5DDC330", Offset = "0x5DDB730", VA = "0x185DDC330")]
		private void LKCJOKMBONA(Scene CBOHDHCKOLN, LoadSceneMode LEIDKMNBCMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5DDC3A0", Offset = "0x5DDB7A0", VA = "0x185DDC3A0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5DDC8A0", Offset = "0x5DDBCA0", VA = "0x185DDC8A0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5DDC4C0", Offset = "0x5DDB8C0", VA = "0x185DDC4C0")]
		private void PFOKAPDGNAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5DDC660", Offset = "0x5DDBA60", VA = "0x185DDC660")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5DDC1B0", Offset = "0x5DDB5B0", VA = "0x185DDC1B0")]
		private void JLLALLIHABJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5DDBF90", Offset = "0x5DDB390", VA = "0x185DDBF90")]
		public IPCOLFCLNPN GetOrCreateCullingGroup(Type GCJHCEIKCII, int DEEMGACJGAP, ushort KCKHPAKEMOB = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2372DD0", Offset = "0x23721D0", VA = "0x182372DD0")]
		public KJNIMNBMNOP<T> GetOrCreateCullingGroup<T>(int DEEMGACJGAP, ushort KCKHPAKEMOB = 0) where T : class, BHBELFGOFDE
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5DDBDB0", Offset = "0x5DDB1B0", VA = "0x185DDBDB0")]
		private IPCOLFCLNPN GHOCLFKCDEK(Type GCJHCEIKCII, int DEEMGACJGAP, float[] HOGJDJFKDJI, ushort KCKHPAKEMOB = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2372B60", Offset = "0x2371F60", VA = "0x182372B60")]
		private KJNIMNBMNOP<T> GHOCLFKCDEK<T>(int DEEMGACJGAP, float[] HOGJDJFKDJI, ushort KCKHPAKEMOB = 0) where T : class, BHBELFGOFDE
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5DDBC50", Offset = "0x5DDB050", VA = "0x185DDBC50")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DDC390", Offset = "0x5DDB790", VA = "0x185DDC390")]
		public static EFOCEKEKLEE MaxUpdateLod(EFOCEKEKLEE BNJLDMMNJIL, EFOCEKEKLEE KCJPEEBKIOE)
		{
			return default(EFOCEKEKLEE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5DDCD10", Offset = "0x5DDC110", VA = "0x185DDCD10")]
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
