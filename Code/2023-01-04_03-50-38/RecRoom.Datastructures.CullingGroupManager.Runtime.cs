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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, BODFKLNNGKK
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class HLIPDADKIHC<T> : LEKJMLDCCKF, global::LDFACNGNLCE<T>, MKGJHDNFCEE where T : class, DJGKFKHPHGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x2A4AF40", Offset = "0x2A4A340", VA = "0x182A4AF40")]
			internal HLIPDADKIHC(int COHPLFMHPPB, float[] ONLIKADOLGF, EGEPJIKPJJD GLODEAPKDLM = EGEPJIKPJJD.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x2A4AE70", Offset = "0x2A4A270", VA = "0x182A4AE70", Slot = "15")]
			public void AKBMAMDKLNI(T JLBINKLPHKJ, float MPJOCGGPJFF, EHGHHHPBJOG GCHJEPGGNBI = EHGHHHPBJOG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x2A4AE40", Offset = "0x2A4A240", VA = "0x182A4AE40", Slot = "16")]
			public void AKBMAMDKLNI(T JLBINKLPHKJ, Transform FPBLCKPMGJP, float MPJOCGGPJFF, EHGHHHPBJOG GCHJEPGGNBI = EHGHHHPBJOG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2A4AF00", Offset = "0x2A4A300", VA = "0x182A4AF00", Slot = "17")]
			public void OCGAHAILOMO(T JLBINKLPHKJ, [Optional] float? MPJOCGGPJFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x2A4AEC0", Offset = "0x2A4A2C0", VA = "0x182A4AEC0", Slot = "18")]
			public void GKDAOIMBAHJ(T AGAKBPAIILL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x2A4AF20", Offset = "0x2A4A320", VA = "0x182A4AF20", Slot = "19")]
			public IJGKBFNAJFK PMPBKHLIHAD(T JLBINKLPHKJ)
			{
				return default(IJGKBFNAJFK);
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2A4AEA0", Offset = "0x2A4A2A0", VA = "0x182A4AEA0", Slot = "20")]
			public bool AMNIIINMFAK(T JLBINKLPHKJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2A4AEE0", Offset = "0x2A4A2E0", VA = "0x182A4AEE0", Slot = "21")]
			public void MGNABJMKJAC(T JLBINKLPHKJ, EHGHHHPBJOG DMIICIGAEOE)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class LEKJMLDCCKF : IDisposable, MKGJHDNFCEE
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum EGEPJIKPJJD : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class GKEPNPPAEED
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public DJGKFKHPHGC GIAADHNLHOF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public EHGHHHPBJOG KDIMILGOJMF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public Action NNBNIJDPMLF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public bool PBHGPPMMNNL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public int IJHDILKKDIL;

				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
				public GKEPNPPAEED()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class DBFAHEAOODI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public LEKJMLDCCKF <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public GKEPNPPAEED trackedObject;

				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
				public DBFAHEAOODI()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int OJNKNGIBMKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int COHPLFMHPPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int BAFJBCBEPBN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool DAIKPAIAHEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly CullingGroup AKOAMEAHIPB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private BoundingSphere[] MPEGMAIDMPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private Transform[] OABPFKIMOJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly GFAHLLHENLF GEEOPHADFKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly Dictionary<DJGKFKHPHGC, int> HLACEBGLCOC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<int, GKEPNPPAEED> LEOCANKFAAI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly EGEPJIKPJJD GLODEAPKDLM;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public int ONPGGECMEPN
			{
				[Cpp2IlInjected.Token(Token = "0x6000021")]
				[Cpp2IlInjected.Address(RVA = "0x678040", Offset = "0x677440", VA = "0x180678040", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int GHNFOEAAHIO
			{
				[Cpp2IlInjected.Token(Token = "0x6000022")]
				[Cpp2IlInjected.Address(RVA = "0x68E790", Offset = "0x68DB90", VA = "0x18068E790", Slot = "6")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x605D8C0", Offset = "0x605CCC0", VA = "0x18605D8C0")]
			internal LEKJMLDCCKF(int COHPLFMHPPB, float[] ONLIKADOLGF, EGEPJIKPJJD GLODEAPKDLM = EGEPJIKPJJD.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x605C640", Offset = "0x605BA40", VA = "0x18605C640")]
			public void GABOOOBGODF(bool MIGIMAIIMPO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x605C140", Offset = "0x605B540", VA = "0x18605C140", Slot = "7")]
			public IJGKBFNAJFK DFDGIBGPDOL(float JAIDHIGECJH)
			{
				return default(IJGKBFNAJFK);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x605BE30", Offset = "0x605B230", VA = "0x18605BE30", Slot = "8")]
			public void AKBMAMDKLNI(DJGKFKHPHGC JLBINKLPHKJ, float MPJOCGGPJFF, EHGHHHPBJOG GCHJEPGGNBI = EHGHHHPBJOG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x605B9E0", Offset = "0x605ADE0", VA = "0x18605B9E0", Slot = "9")]
			public void AKBMAMDKLNI(DJGKFKHPHGC JLBINKLPHKJ, Transform FPBLCKPMGJP, float MPJOCGGPJFF, EHGHHHPBJOG GCHJEPGGNBI = EHGHHHPBJOG.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x605B860", Offset = "0x605AC60", VA = "0x18605B860")]
			public void ABEEFJJEIHI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x605D370", Offset = "0x605C770", VA = "0x18605D370", Slot = "10")]
			public void OCGAHAILOMO(DJGKFKHPHGC JLBINKLPHKJ, [Optional] float? MPJOCGGPJFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x605CB50", Offset = "0x605BF50", VA = "0x18605CB50")]
			private void HLFHLOCANED(int HMJKJGLHFKE, [Optional] float? MPJOCGGPJFF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x605C710", Offset = "0x605BB10", VA = "0x18605C710", Slot = "11")]
			public void GKDAOIMBAHJ(DJGKFKHPHGC AGAKBPAIILL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x605D7B0", Offset = "0x605CBB0", VA = "0x18605D7B0", Slot = "12")]
			public IJGKBFNAJFK PMPBKHLIHAD(DJGKFKHPHGC JLBINKLPHKJ)
			{
				return default(IJGKBFNAJFK);
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x605BEC0", Offset = "0x605B2C0", VA = "0x18605BEC0", Slot = "13")]
			public bool AMNIIINMFAK(DJGKFKHPHGC JLBINKLPHKJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x605CF40", Offset = "0x605C340", VA = "0x18605CF40", Slot = "14")]
			public void MGNABJMKJAC(DJGKFKHPHGC JLBINKLPHKJ, EHGHHHPBJOG IHKOCPIPHBL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x605C330", Offset = "0x605B730", VA = "0x18605C330", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x605D3F0", Offset = "0x605C7F0", VA = "0x18605D3F0")]
			private void PJCAOKINKIJ(GKEPNPPAEED JIOMIKGCPJO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x605CCB0", Offset = "0x605C0B0", VA = "0x18605CCB0")]
			private void JHEGBAAICKP(GKEPNPPAEED JIOMIKGCPJO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x605C5D0", Offset = "0x605B9D0", VA = "0x18605C5D0")]
			private void EFJGEKOOBIF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x605C670", Offset = "0x605BA70", VA = "0x18605C670")]
			private void GCPLKJGDLDH(float FPKCMGNGBAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x605C6E0", Offset = "0x605BAE0", VA = "0x18605C6E0")]
			private void GEACBCCGHCJ(GKEPNPPAEED JIOMIKGCPJO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x605C320", Offset = "0x605B720", VA = "0x18605C320")]
			private void DLIAIGMPMGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x605CB40", Offset = "0x605BF40", VA = "0x18605CB40")]
			private void GLKHGEJLAGM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x605D030", Offset = "0x605C430", VA = "0x18605D030")]
			private void NFGCLIHAAEM(CullingGroupEvent FMGPFDIEKBG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x605BFC0", Offset = "0x605B3C0", VA = "0x18605BFC0")]
			private void CKCDHOBOJGI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct GDIBOHKAOFC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public ushort MPAGMODMDAK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Type BLMJBELLJEH;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float ADHANMOHPAN = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float JALGBCHECKH = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float FKBHMBHCMHE = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float HFNPAFJEFHI = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float JCIFHFMBMJG = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float FFBHFJBLFCI = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float JALPFPCNNMC = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<GDIBOHKAOFC, LEKJMLDCCKF> OEGCGKCNPNF;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable MOLBDEFGMGG;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable CMCJNABLFPE;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static PENMMECJMBL LAJJDPBOBHM;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static PENMMECJMBL DNOINIMADAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly PENMMECJMBL HMHPHHIGKAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly PENMMECJMBL NAAOCOJFDOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly PENMMECJMBL BOFLFHFEHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private OFJDMAJBJNN KHJFLMCPIHL;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool MIGIMAIIMPO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public PENMMECJMBL ALBDKOOAIBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x6780C0", Offset = "0x6774C0", VA = "0x1806780C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public PENMMECJMBL MBPFBIGMGOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x679120", Offset = "0x678520", VA = "0x180679120", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public PENMMECJMBL PJFHKKBOPNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6928E0", Offset = "0x691CE0", VA = "0x1806928E0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool AMJCOALAMOL
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x17DF430", Offset = "0x17DE830", VA = "0x1817DF430", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool EEHLHILNECG
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x678030", Offset = "0x677430", VA = "0x180678030", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x813720", Offset = "0x812B20", VA = "0x180813720")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x605A310", Offset = "0x6059710", VA = "0x18605A310", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x10F1AF0", Offset = "0x10F0EF0", VA = "0x1810F1AF0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x605AD90", Offset = "0x605A190", VA = "0x18605AD90")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x605AC50", Offset = "0x605A050", VA = "0x18605AC50")]
		private void NPIIHDLFLOP(Scene MJJNOEJBKMP, LoadSceneMode JHDOIDGIHDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x605ACB0", Offset = "0x605A0B0", VA = "0x18605ACB0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x605AFE0", Offset = "0x605A3E0", VA = "0x18605AFE0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x605A3E0", Offset = "0x60597E0", VA = "0x18605A3E0")]
		private void DFAJBCMONPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x605ADB0", Offset = "0x605A1B0", VA = "0x18605ADB0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x605A720", Offset = "0x6059B20", VA = "0x18605A720")]
		private void GNGHHFMIMGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x605A8A0", Offset = "0x6059CA0", VA = "0x18605A8A0")]
		public MKGJHDNFCEE GetOrCreateCullingGroup(Type EPPJALAIAGB, int FOLEGNNPEIK, ushort CEDAEFALBOJ = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x26BD090", Offset = "0x26BC490", VA = "0x1826BD090")]
		public global::LDFACNGNLCE<T> GetOrCreateCullingGroup<T>(int FOLEGNNPEIK, ushort CEDAEFALBOJ = 0) where T : class, DJGKFKHPHGC
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x605AA90", Offset = "0x6059E90", VA = "0x18605AA90")]
		private MKGJHDNFCEE JFJDCIILPDC(Type EPPJALAIAGB, int FOLEGNNPEIK, float[] ONLIKADOLGF, ushort CEDAEFALBOJ = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x26BD140", Offset = "0x26BC540", VA = "0x1826BD140")]
		private global::LDFACNGNLCE<T> JFJDCIILPDC<T>(int FOLEGNNPEIK, float[] ONLIKADOLGF, ushort CEDAEFALBOJ = 0) where T : class, DJGKFKHPHGC
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x605A580", Offset = "0x6059980", VA = "0x18605A580")]
		public static IJGKBFNAJFK FindClosestDefaultUpdateLod(float DDJEBENKIJE)
		{
			return default(IJGKBFNAJFK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x605AC40", Offset = "0x605A040", VA = "0x18605AC40")]
		public static IJGKBFNAJFK MinUpdateLod(IJGKBFNAJFK FLKKOCBLJOE, IJGKBFNAJFK GGGOHOPLBDD)
		{
			return default(IJGKBFNAJFK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x605AC30", Offset = "0x605A030", VA = "0x18605AC30")]
		public static IJGKBFNAJFK MaxUpdateLod(IJGKBFNAJFK FLKKOCBLJOE, IJGKBFNAJFK GGGOHOPLBDD)
		{
			return default(IJGKBFNAJFK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x605B410", Offset = "0x605A810", VA = "0x18605B410")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GFAHLLHENLF
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool HJNHJBMDKEF
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Camera NEOFDGCIPMI
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	PENMMECJMBL JAAINMLEHLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool HCFICECJFFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	PENMMECJMBL BLLDPBJKELJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Transform DKIJOGFPLOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MKGJHDNFCEE
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	int ONPGGECMEPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int GHNFOEAAHIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IJGKBFNAJFK DFDGIBGPDOL(float JAIDHIGECJH);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AKBMAMDKLNI(DJGKFKHPHGC JLBINKLPHKJ, float MPJOCGGPJFF, EHGHHHPBJOG GCHJEPGGNBI = EHGHHHPBJOG.Off);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AKBMAMDKLNI(DJGKFKHPHGC JLBINKLPHKJ, Transform FPBLCKPMGJP, float MPJOCGGPJFF, EHGHHHPBJOG GCHJEPGGNBI = EHGHHHPBJOG.Off);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OCGAHAILOMO(DJGKFKHPHGC JLBINKLPHKJ, [Optional] float? MPJOCGGPJFF);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GKDAOIMBAHJ(DJGKFKHPHGC AGAKBPAIILL);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IJGKBFNAJFK PMPBKHLIHAD(DJGKFKHPHGC JLBINKLPHKJ);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool AMNIIINMFAK(DJGKFKHPHGC JLBINKLPHKJ);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MGNABJMKJAC(DJGKFKHPHGC JLBINKLPHKJ, EHGHHHPBJOG DMIICIGAEOE);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface LDFACNGNLCE<T> : MKGJHDNFCEE where T : class, DJGKFKHPHGC
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AKBMAMDKLNI(T JLBINKLPHKJ, float MPJOCGGPJFF, EHGHHHPBJOG GCHJEPGGNBI = EHGHHHPBJOG.Off);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AKBMAMDKLNI(T JLBINKLPHKJ, Transform FPBLCKPMGJP, float MPJOCGGPJFF, EHGHHHPBJOG GCHJEPGGNBI = EHGHHHPBJOG.Off);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OCGAHAILOMO(T JLBINKLPHKJ, [Optional] float? MPJOCGGPJFF);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GKDAOIMBAHJ(T AGAKBPAIILL);

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	IJGKBFNAJFK PMPBKHLIHAD(T JLBINKLPHKJ);

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool AMNIIINMFAK(T JLBINKLPHKJ);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MGNABJMKJAC(T JLBINKLPHKJ, EHGHHHPBJOG DMIICIGAEOE);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface DJGKFKHPHGC
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	Transform KFAGMEKKLDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(IJGKBFNAJFK PHCIBHAPAEA, IJGKBFNAJFK HOINOFOELCN);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool DAJDNICIJIC);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum EHGHHHPBJOG : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum IJGKBFNAJFK
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
public class KPHMJCMFBAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private IJGKBFNAJFK CMBNEELHPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private IJGKBFNAJFK HKHDBDONGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<object, IJGKBFNAJFK> JEEILLKJJFK;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool JNPAKENCLIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x605B560", Offset = "0x605A960", VA = "0x18605B560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public IJGKBFNAJFK DBBBLFMHGGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x678040", Offset = "0x677440", VA = "0x180678040")]
		get
		{
			return default(IJGKBFNAJFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public IJGKBFNAJFK LLDGOGLIAKM
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x68E790", Offset = "0x68DB90", VA = "0x18068E790")]
		get
		{
			return default(IJGKBFNAJFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x605B710", Offset = "0x605AB10", VA = "0x18605B710")]
	public bool NLLNELGPFFC(object MJNGPHMPILM, IJGKBFNAJFK IGDJJEECDAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x605B780", Offset = "0x605AB80", VA = "0x18605B780")]
	public bool OLBCNDJLEDE(object MJNGPHMPILM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x605B5B0", Offset = "0x605A9B0", VA = "0x18605B5B0")]
	private bool GGPMBFPEDAF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x605B7E0", Offset = "0x605ABE0", VA = "0x18605B7E0")]
	public KPHMJCMFBAG()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class NLJAGALCJKH
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static byte[] JCLCDCCNAPM;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int BKAHGFCDIKL;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int GJMNCFGIJLO;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static BigInteger MOEAOMJCPNL;

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
	public NLJAGALCJKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x605DC80", Offset = "0x605D080", VA = "0x18605DC80")]
	private static string EMKPABEMONO(byte[] IKDBBHHKFLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x605DD90", Offset = "0x605D190", VA = "0x18605DD90")]
	public static string NJEIEMNKMPN(byte[] EEMDNKKFCBK, bool DIMJIPPBEJB)
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
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
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
