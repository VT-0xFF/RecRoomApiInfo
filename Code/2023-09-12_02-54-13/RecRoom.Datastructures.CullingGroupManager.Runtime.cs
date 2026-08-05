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
public interface HNFEGBOBIDG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool POHKGANOGIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Camera MPGAFCBBKOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	MLPFDGHACOI LKBEDFCGGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool ALMJPBCECPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	MLPFDGHACOI CNEGPJINMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	Transform PCBOAEHOJAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, GAEFMEGEODI
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class OJPLNAOCHAD<T> : HIHAPBKDMJN, IKOPLHJLDJI<T>, NBLEDJCPAGF where T : class, EGLIMKJGMKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x23E04D0", Offset = "0x23DF8D0", VA = "0x1823E04D0")]
			internal OJPLNAOCHAD(int DMJGGJFHMPM, float[] JBDAAABBOKP, CHAPHJCPNIN BAEPJCFOHFH = CHAPHJCPNIN.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x23E0470", Offset = "0x23DF870", VA = "0x1823E0470", Slot = "10")]
			public void NNFBEGDMHOD(T HFAGBIOODHL, float BJDNODMMNIO, AIAJHOEHKAH FELGINDEAAH = AIAJHOEHKAH.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x23E04A0", Offset = "0x23DF8A0", VA = "0x1823E04A0", Slot = "11")]
			public void NNFBEGDMHOD(T HFAGBIOODHL, Transform FCEEMKEPOED, float BJDNODMMNIO, AIAJHOEHKAH FELGINDEAAH = AIAJHOEHKAH.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x23E0450", Offset = "0x23DF850", VA = "0x1823E0450", Slot = "12")]
			public void LOBOHMPHNJE(T GPJPNNNPHAM)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class HIHAPBKDMJN : IDisposable, NBLEDJCPAGF
		{
			[Cpp2IlInjected.Token(Token = "0x2000006")]
			public enum CHAPHJCPNIN : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			private class IJPBPLNGPBL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public EGLIMKJGMKP ICGJOIEICNJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public AIAJHOEHKAH AJKJMJCHGNC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action EKNAPAAMNOO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool PNIGMMIIGCA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int FKHPMLNOHLM;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
				public IJPBPLNGPBL()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000008")]
			[CompilerGenerated]
			private sealed class KFJFCJGDJOI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public HIHAPBKDMJN <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public IJPBPLNGPBL trackedObject;

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
				public KFJFCJGDJOI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x71B37C0", Offset = "0x71B2BC0", VA = "0x1871B37C0")]
				internal void BHLKACNCBFL()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int BDHCBGIJNFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int DMJGGJFHMPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int HKCLKEPCHJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool IAEKIDJDAJF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup BJCLJGMIFKD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] CMPKBAOBFBA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] OILECHBKLHN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly HNFEGBOBIDG EOPIGBOAJOB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<EGLIMKJGMKP, int> HGHOEBGNCOE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, IJPBPLNGPBL> DNCDDHDLHBG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CHAPHJCPNIN BAEPJCFOHFH;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public bool KENGICDFPCA
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0x1D35DD0", Offset = "0x1D351D0", VA = "0x181D35DD0")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x1D35DB0", Offset = "0x1D351B0", VA = "0x181D35DB0", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x71B33F0", Offset = "0x71B27F0", VA = "0x1871B33F0")]
			internal HIHAPBKDMJN(int DMJGGJFHMPM, float[] JBDAAABBOKP, CHAPHJCPNIN BAEPJCFOHFH = CHAPHJCPNIN.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x71B33C0", Offset = "0x71B27C0", VA = "0x1871B33C0")]
			public void OMEEOAFJKNH(bool NFDBPIPHJHA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x71B2E50", Offset = "0x71B2250", VA = "0x1871B2E50", Slot = "6")]
			public void NNFBEGDMHOD(EGLIMKJGMKP HFAGBIOODHL, float BJDNODMMNIO, AIAJHOEHKAH FELGINDEAAH = AIAJHOEHKAH.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x71B2EE0", Offset = "0x71B22E0", VA = "0x1871B2EE0", Slot = "9")]
			public void NNFBEGDMHOD(EGLIMKJGMKP HFAGBIOODHL, Transform FCEEMKEPOED, float BJDNODMMNIO, AIAJHOEHKAH FELGINDEAAH = AIAJHOEHKAH.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x71B2510", Offset = "0x71B1910", VA = "0x1871B2510")]
			public void HOIFIMCHDOA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x71B1940", Offset = "0x71B0D40", VA = "0x1871B1940")]
			private void DAHNJKKMCBD(int BNOAGGNAMKG, [Optional] float? BJDNODMMNIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x71B26A0", Offset = "0x71B1AA0", VA = "0x1871B26A0", Slot = "7")]
			public void LOBOHMPHNJE(EGLIMKJGMKP GPJPNNNPHAM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x71B16D0", Offset = "0x71B0AD0", VA = "0x1871B16D0", Slot = "8")]
			public void AKMJBAPLJJF(EGLIMKJGMKP HFAGBIOODHL, AIAJHOEHKAH BEIFJOOBPFC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x71B1AA0", Offset = "0x71B0EA0", VA = "0x1871B1AA0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x71B2AD0", Offset = "0x71B1ED0", VA = "0x1871B2AD0")]
			private void MLHNMLGGMDC(IJPBPLNGPBL DOHCAKKJGMI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x71B2280", Offset = "0x71B1680", VA = "0x1871B2280")]
			private void HKMGNFPKCLD(IJPBPLNGPBL DOHCAKKJGMI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x71B3350", Offset = "0x71B2750", VA = "0x1871B3350")]
			private void OKACDCCOMAD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x71B1D50", Offset = "0x71B1150", VA = "0x1871B1D50")]
			private void EPHNPLKLEMC(float GBGLMAACONP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x71B1DC0", Offset = "0x71B11C0", VA = "0x1871B1DC0")]
			private void GGOKEENFFBD(IJPBPLNGPBL DOHCAKKJGMI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x71B2E40", Offset = "0x71B2240", VA = "0x1871B2E40")]
			private void NJFILNFFMIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x71B2690", Offset = "0x71B1A90", VA = "0x1871B2690")]
			private void LFLNCGPPMLH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x71B1F40", Offset = "0x71B1340", VA = "0x1871B1F40")]
			private void HJMLEAAHALE(CullingGroupEvent KJIPOCINLKN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x71B17C0", Offset = "0x71B0BC0", VA = "0x1871B17C0")]
			private void AODMGMBLBAE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private struct EBPALMMHOHB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort MKKMHMJLIED;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type BEJAFIFPGIK;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float NODKGPKKKHK = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float DBBMBAGOCBD = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float KOOHAPMNGLC = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float CEABAAGPDOD = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float IJJDIHECGAC = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float GNCMAOCGLHI = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float JOAIEJAIEFF = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<EBPALMMHOHB, HIHAPBKDMJN> MHIBGDGBADC;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable NJDLLBCMICI;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable FLILEEMEKBN;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static MLPFDGHACOI NBIKNIPIBNH;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static MLPFDGHACOI MAKBJNCOFLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly MLPFDGHACOI IKFKBKNCFAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly MLPFDGHACOI AGPCOHCBOCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly MLPFDGHACOI KIOJAAKEFEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private IMJDOMFMBGH CBAMKMDKCME;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool NFDBPIPHJHA;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public MLPFDGHACOI CKDDMCFAAND
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public MLPFDGHACOI EJDCHFMHGHH
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x823C10", Offset = "0x823010", VA = "0x180823C10", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public MLPFDGHACOI BNNIIIEPDFO
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x823B70", Offset = "0x822F70", VA = "0x180823B70", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool ODECNMKDKMJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x10E5740", Offset = "0x10E4B40", VA = "0x1810E5740", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool PJPNBCAHLBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x11AA2E0", Offset = "0x11A96E0", VA = "0x1811AA2E0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x11B7640", Offset = "0x11B6A40", VA = "0x1811B7640")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x71B0500", Offset = "0x71AF900", VA = "0x1871B0500", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1AC8DD0", Offset = "0x1AC81D0", VA = "0x181AC8DD0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x71B0F70", Offset = "0x71B0370", VA = "0x1871B0F70")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x71B0E30", Offset = "0x71B0230", VA = "0x1871B0E30")]
		private void NGCIBEOJAGK(Scene PJOBCGNOOBP, LoadSceneMode ADMMGKCBODC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x71B0E90", Offset = "0x71B0290", VA = "0x1871B0E90", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x71B11C0", Offset = "0x71B05C0", VA = "0x1871B11C0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x71B05D0", Offset = "0x71AF9D0", VA = "0x1871B05D0")]
		private void BLAOFLEEFFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x71B0F90", Offset = "0x71B0390", VA = "0x1871B0F90")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x71B0C90", Offset = "0x71B0090", VA = "0x1871B0C90")]
		private void MKNEKNKKDJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x71B0900", Offset = "0x71AFD00", VA = "0x1871B0900")]
		public NBLEDJCPAGF GetOrCreateCullingGroup(Type NCBPDBDONMN, int AMJOPICJCAK, ushort FOCBMFPAJAM = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x28B9C80", Offset = "0x28B9080", VA = "0x1828B9C80")]
		public IKOPLHJLDJI<T> GetOrCreateCullingGroup<T>(int AMJOPICJCAK, ushort FOCBMFPAJAM = 0) where T : class, EGLIMKJGMKP
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x71B0AF0", Offset = "0x71AFEF0", VA = "0x1871B0AF0")]
		private NBLEDJCPAGF LCGKOPNGPIC(Type NCBPDBDONMN, int AMJOPICJCAK, float[] JBDAAABBOKP, ushort FOCBMFPAJAM = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x28B9D30", Offset = "0x28B9130", VA = "0x1828B9D30")]
		private IKOPLHJLDJI<T> LCGKOPNGPIC<T>(int AMJOPICJCAK, float[] JBDAAABBOKP, ushort FOCBMFPAJAM = 0) where T : class, EGLIMKJGMKP
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x71B0770", Offset = "0x71AFB70", VA = "0x1871B0770")]
		public static FGLEPFCKOAH FindClosestDefaultUpdateLod(float HPICNEJOLJM)
		{
			return default(FGLEPFCKOAH);
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x71B0E20", Offset = "0x71B0220", VA = "0x1871B0E20")]
		public static FGLEPFCKOAH MinUpdateLod(FGLEPFCKOAH OBOGNDLKCAF, FGLEPFCKOAH CBJKEOJNOPN)
		{
			return default(FGLEPFCKOAH);
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x71B0E10", Offset = "0x71B0210", VA = "0x1871B0E10")]
		public static FGLEPFCKOAH MaxUpdateLod(FGLEPFCKOAH OBOGNDLKCAF, FGLEPFCKOAH CBJKEOJNOPN)
		{
			return default(FGLEPFCKOAH);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x71B15F0", Offset = "0x71B09F0", VA = "0x1871B15F0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public enum FGLEPFCKOAH
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
public interface EGLIMKJGMKP
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Transform DKKDEHMFAEC
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(FGLEPFCKOAH MKCCIDALIGJ, FGLEPFCKOAH JGAEINHKEAP);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool OAFKEEFNLAD);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface NBLEDJCPAGF
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	bool KENGICDFPCA
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NNFBEGDMHOD(EGLIMKJGMKP HFAGBIOODHL, float BJDNODMMNIO, AIAJHOEHKAH FELGINDEAAH = AIAJHOEHKAH.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LOBOHMPHNJE(EGLIMKJGMKP GPJPNNNPHAM);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AKMJBAPLJJF(EGLIMKJGMKP HFAGBIOODHL, AIAJHOEHKAH PHJIDKJBJFB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface IKOPLHJLDJI<T> : NBLEDJCPAGF where T : class, EGLIMKJGMKP
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NNFBEGDMHOD(T HFAGBIOODHL, float BJDNODMMNIO, AIAJHOEHKAH FELGINDEAAH = AIAJHOEHKAH.Off);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NNFBEGDMHOD(T HFAGBIOODHL, Transform FCEEMKEPOED, float BJDNODMMNIO, AIAJHOEHKAH FELGINDEAAH = AIAJHOEHKAH.Off);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LOBOHMPHNJE(T GPJPNNNPHAM);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum AIAJHOEHKAH : byte
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
