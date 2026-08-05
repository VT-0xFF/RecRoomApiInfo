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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, DHIMCJCHAKB
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class PIJOGGGDNPO<T> : NHGKJPPGEKK, ACLDCOKOEGC<T>, ELDMKEBEHNG where T : class, DANNLMHLCBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3E4DD10", Offset = "0x3E4D110", VA = "0x183E4DD10")]
			internal PIJOGGGDNPO(int GDBOFJCDAOI, float[] FHFNEGDCGHD, LKNPGMJMMHO OOANKDECCEI = LKNPGMJMMHO.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x3E4DC90", Offset = "0x3E4D090", VA = "0x183E4DC90", Slot = "10")]
			public void GIHKKMKIIOJ(T IBBNLILJNEB, float ILPHNFDIOJC, EDDJKJMAGDA OIIODOIEMDO = EDDJKJMAGDA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x3E4DCC0", Offset = "0x3E4D0C0", VA = "0x183E4DCC0", Slot = "11")]
			public void GIHKKMKIIOJ(T IBBNLILJNEB, Transform DBAFEJEEGGM, float ILPHNFDIOJC, EDDJKJMAGDA OIIODOIEMDO = EDDJKJMAGDA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3E4DCF0", Offset = "0x3E4D0F0", VA = "0x183E4DCF0", Slot = "12")]
			public void HFJFDMFKDND(T AJBGMAKKHGA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class NHGKJPPGEKK : IDisposable, ELDMKEBEHNG
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum LKNPGMJMMHO : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class EHKJLNGLPBH
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public DANNLMHLCBM KNMGHOCIPIF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public EDDJKJMAGDA HNIBFPEPFIL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action BPHPPFLBPNK;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool GADIOEKNEBB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int ICOODGEKGMA;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
				public EHKJLNGLPBH()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class BBOFAJGAHKM
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public NHGKJPPGEKK <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public EHKJLNGLPBH trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
				public BBOFAJGAHKM()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x5C9F7A0", Offset = "0x5C9EBA0", VA = "0x185C9F7A0")]
				internal void NELJOJMNPJP()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int JJLOHJDEMNF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int GDBOFJCDAOI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int OLKCDCNIPNL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool CHCAJAAKAHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup BHLMANKCPAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] OCJOLJNHAFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] JAHAMMKBKLN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly NPFPEOHGGNF FDEKFCDLHEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<DANNLMHLCBM, int> MFKDLFBGAAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, EHKJLNGLPBH> NBBDEKNAECA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly LKNPGMJMMHO OOANKDECCEI;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool EKBKMGDBAPG
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x3BC1160", Offset = "0x3BC0560", VA = "0x183BC1160")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x3509AD0", Offset = "0x3508ED0", VA = "0x183509AD0", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x5CA2710", Offset = "0x5CA1B10", VA = "0x185CA2710")]
			internal NHGKJPPGEKK(int GDBOFJCDAOI, float[] FHFNEGDCGHD, LKNPGMJMMHO OOANKDECCEI = LKNPGMJMMHO.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5CA2290", Offset = "0x5CA1690", VA = "0x185CA2290")]
			public void NAMPPAEFEHG(bool KALIJOLFMCO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x5CA14E0", Offset = "0x5CA08E0", VA = "0x185CA14E0", Slot = "6")]
			public void GIHKKMKIIOJ(DANNLMHLCBM IBBNLILJNEB, float ILPHNFDIOJC, EDDJKJMAGDA OIIODOIEMDO = EDDJKJMAGDA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x5CA1570", Offset = "0x5CA0970", VA = "0x185CA1570", Slot = "9")]
			public void GIHKKMKIIOJ(DANNLMHLCBM IBBNLILJNEB, Transform DBAFEJEEGGM, float ILPHNFDIOJC, EDDJKJMAGDA OIIODOIEMDO = EDDJKJMAGDA.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x5CA1D50", Offset = "0x5CA1150", VA = "0x185CA1D50")]
			public void JGIDHDEAGJG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x5CA25E0", Offset = "0x5CA19E0", VA = "0x185CA25E0")]
			private void PPDNJANODBK(int JPEMHHILGGG, [Optional] float? ILPHNFDIOJC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x5CA1960", Offset = "0x5CA0D60", VA = "0x185CA1960", Slot = "7")]
			public void HFJFDMFKDND(DANNLMHLCBM AJBGMAKKHGA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x5CA0D40", Offset = "0x5CA0140", VA = "0x185CA0D40", Slot = "8")]
			public void BABEEFLHKJJ(DANNLMHLCBM IBBNLILJNEB, EDDJKJMAGDA CMFKJEJPJDE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x5CA1220", Offset = "0x5CA0620", VA = "0x185CA1220", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x5CA1EA0", Offset = "0x5CA12A0", VA = "0x185CA1EA0")]
			private void KBNCDKGEACL(EHKJLNGLPBH BIFEAODHDND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x5CA0F70", Offset = "0x5CA0370", VA = "0x185CA0F70")]
			private void DDGLJCDBBCA(EHKJLNGLPBH BIFEAODHDND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x5CA2230", Offset = "0x5CA1630", VA = "0x185CA2230")]
			private void LLPLKKNCNJM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x5CA0B70", Offset = "0x5C9FF70", VA = "0x185CA0B70")]
			private void AHJBCKFACFM(float PMOHIPDKHDN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x5CA0E30", Offset = "0x5CA0230", VA = "0x185CA0E30")]
			private void CEPDNPAIGNJ(EHKJLNGLPBH BIFEAODHDND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x5CA1D40", Offset = "0x5CA1140", VA = "0x185CA1D40")]
			private void IHEDHOHBEKC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x5CA1210", Offset = "0x5CA0610", VA = "0x185CA1210")]
			private void DHNHDCBBLBE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x5CA22C0", Offset = "0x5CA16C0", VA = "0x185CA22C0")]
			private void OMEKLALBFPB(CullingGroupEvent KMJBHEPBCGN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x5CA0BD0", Offset = "0x5C9FFD0", VA = "0x185CA0BD0")]
			private void AKINPJKEOGO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct OFECPOPPPDD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort OKBBGFJFANB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type KBKKIIACJKJ;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float KFKCLNFLAFA = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float HNJBOCEBNNI = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float NCPOJCHPPPL = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float NJCBMDLCDKP = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float PONOMHHFFCA = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float FMLIKLMKEJE = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float NHEOKFDPPEG = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<OFECPOPPPDD, NHGKJPPGEKK> HIFBEMNFIPI;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable OKJMKDNGFFN;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable CFHMPAEGKBO;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static HJKDHGFMLBJ DEKCLBANOBK;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static HJKDHGFMLBJ GJABDPPAICC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly HJKDHGFMLBJ HPDMNIOIIDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly HJKDHGFMLBJ LGIBDMKFDII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly HJKDHGFMLBJ KIBKJJMDJGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private GKKBBPDHGPP CCIMMAJOFKP;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool KALIJOLFMCO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public HJKDHGFMLBJ JEBKEIDILDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x767230", Offset = "0x766630", VA = "0x180767230", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public HJKDHGFMLBJ IJAFPEDACEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x76B410", Offset = "0x76A810", VA = "0x18076B410", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public HJKDHGFMLBJ NCJJKMGPKPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x767740", Offset = "0x766B40", VA = "0x180767740", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool LMBNHJJPJKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xBCB1A0", Offset = "0xBCA5A0", VA = "0x180BCB1A0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool DLEJBPDJHOE
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7B8540", Offset = "0x7B7940", VA = "0x1807B8540", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x7B7D20", Offset = "0x7B7120", VA = "0x1807B7D20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5C9FAD0", Offset = "0x5C9EED0", VA = "0x185C9FAD0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5CA0200", Offset = "0x5C9F600", VA = "0x185CA0200")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5CA01E0", Offset = "0x5C9F5E0", VA = "0x185CA01E0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5CA0090", Offset = "0x5C9F490", VA = "0x185CA0090")]
		private void MEBCDOJLJGE(Scene KJAEFLADAPH, LoadSceneMode OHCLHGENEBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5CA0100", Offset = "0x5C9F500", VA = "0x185CA0100", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5CA0600", Offset = "0x5C9FA00", VA = "0x185CA0600")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5CA0220", Offset = "0x5C9F620", VA = "0x185CA0220")]
		private void PLGGFCHOACK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5CA03C0", Offset = "0x5C9F7C0", VA = "0x185CA03C0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x5C9FB90", Offset = "0x5C9EF90", VA = "0x185C9FB90")]
		private void FEEIMPIBNAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5C9FE70", Offset = "0x5C9F270", VA = "0x185C9FE70")]
		public ELDMKEBEHNG GetOrCreateCullingGroup(Type MOMJPCLLHFN, int JIOALBADLAG, ushort DNLDIMCBOBC = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x2225BE0", Offset = "0x2224FE0", VA = "0x182225BE0")]
		public ACLDCOKOEGC<T> GetOrCreateCullingGroup<T>(int JIOALBADLAG, ushort DNLDIMCBOBC = 0) where T : class, DANNLMHLCBM
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x5C9F8F0", Offset = "0x5C9ECF0", VA = "0x185C9F8F0")]
		private ELDMKEBEHNG ADEEAJPADPE(Type MOMJPCLLHFN, int JIOALBADLAG, float[] FHFNEGDCGHD, ushort DNLDIMCBOBC = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2225970", Offset = "0x2224D70", VA = "0x182225970")]
		private ACLDCOKOEGC<T> ADEEAJPADPE<T>(int JIOALBADLAG, float[] FHFNEGDCGHD, ushort DNLDIMCBOBC = 0) where T : class, DANNLMHLCBM
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5C9FD10", Offset = "0x5C9F110", VA = "0x185C9FD10")]
		public static BNKNPIOGGJK FindClosestDefaultUpdateLod(float HGMMBHGBOLF)
		{
			return default(BNKNPIOGGJK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x790F60", Offset = "0x790360", VA = "0x180790F60")]
		public static BNKNPIOGGJK MinUpdateLod(BNKNPIOGGJK GGJLACIFDBG, BNKNPIOGGJK BHEIHBHFJDE)
		{
			return default(BNKNPIOGGJK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5CA00F0", Offset = "0x5C9F4F0", VA = "0x185CA00F0")]
		public static BNKNPIOGGJK MaxUpdateLod(BNKNPIOGGJK GGJLACIFDBG, BNKNPIOGGJK BHEIHBHFJDE)
		{
			return default(BNKNPIOGGJK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5CA0A70", Offset = "0x5C9FE70", VA = "0x185CA0A70")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface NPFPEOHGGNF
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool PPEDLIHJEIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera PEFJGJKNCHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	HJKDHGFMLBJ IPJKLMDGBHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool ELNOPHNBLHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	HJKDHGFMLBJ MOHGIADLNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform BFGPLHNANHN
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface ELDMKEBEHNG
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool EKBKMGDBAPG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GIHKKMKIIOJ(DANNLMHLCBM IBBNLILJNEB, float ILPHNFDIOJC, EDDJKJMAGDA OIIODOIEMDO = EDDJKJMAGDA.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HFJFDMFKDND(DANNLMHLCBM AJBGMAKKHGA);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BABEEFLHKJJ(DANNLMHLCBM IBBNLILJNEB, EDDJKJMAGDA OGPDFPHDMKH);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface ACLDCOKOEGC<T> : ELDMKEBEHNG where T : class, DANNLMHLCBM
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GIHKKMKIIOJ(T IBBNLILJNEB, float ILPHNFDIOJC, EDDJKJMAGDA OIIODOIEMDO = EDDJKJMAGDA.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GIHKKMKIIOJ(T IBBNLILJNEB, Transform DBAFEJEEGGM, float ILPHNFDIOJC, EDDJKJMAGDA OIIODOIEMDO = EDDJKJMAGDA.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HFJFDMFKDND(T AJBGMAKKHGA);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DANNLMHLCBM
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform IJKPFNCIDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(BNKNPIOGGJK ICFFEKPCFNB, BNKNPIOGGJK EEOPBEIAHMC);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool IIAFBMLOLMJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum EDDJKJMAGDA : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum BNKNPIOGGJK
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
