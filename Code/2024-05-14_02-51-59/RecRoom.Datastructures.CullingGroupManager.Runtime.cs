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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, MJKAACKICKG
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private class KKGPICBCLKK<T> : ABKIOIKFLBD, PLNKJGJLOBN<T>, PAENFKLKNDA where T : class, ICMCGDFALFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3D703B0", Offset = "0x3D6EDB0", VA = "0x183D703B0")]
			internal KKGPICBCLKK(int NDPHFODCHHB, float[] EBKNLFELEIM, APBIFGEIKHM KOCNMJOLOOE = APBIFGEIKHM.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x3D70330", Offset = "0x3D6ED30", VA = "0x183D70330", Slot = "10")]
			public void BIPEDCDHLGG(T COMOOAEHALC, float JMJINJAJLIO, OKAPGIDMLME DOMCICCMAOP = OKAPGIDMLME.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x3D70360", Offset = "0x3D6ED60", VA = "0x183D70360", Slot = "11")]
			public void BIPEDCDHLGG(T COMOOAEHALC, Transform GCKAEBNNLFG, float JMJINJAJLIO, OKAPGIDMLME DOMCICCMAOP = OKAPGIDMLME.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3D70390", Offset = "0x3D6ED90", VA = "0x183D70390", Slot = "12")]
			public void MDELFCPLFEE(T PACIPMNIMMN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class ABKIOIKFLBD : IDisposable, PAENFKLKNDA
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum APBIFGEIKHM : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class IEPDHFOKFLL
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public ICMCGDFALFC BHEGPEPPGLL;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public OKAPGIDMLME LBDBHDDANOA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action GNKBDMKGKHC;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public bool ANNOLCIHNJG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public int JIFJFCOEJGO;

				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
				public IEPDHFOKFLL()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class MIACFGEHJEI
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public ABKIOIKFLBD <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public IEPDHFOKFLL trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
				public MIACFGEHJEI()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x630B510", Offset = "0x6309F10", VA = "0x18630B510")]
				internal void IJCPPMIKDFM()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int OPCJOBNLALC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int NDPHFODCHHB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int HDHELNINKNH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool OGOJAHMCHNJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private readonly CullingGroup NGENBBFNLBH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private BoundingSphere[] EEGEBCBKNEE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private Transform[] CNDMPJFDMGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly MMGILAHDGEL NJALJHMFPEI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<ICMCGDFALFC, int> DGFFKDKAGFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly Dictionary<int, IEPDHFOKFLL> FJBMJKPCKCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly APBIFGEIKHM KOCNMJOLOOE;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public bool ANPLJLJBJFA
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0xE20660", Offset = "0xE1F060", VA = "0x180E20660")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x40A9700", Offset = "0x40A8100", VA = "0x1840A9700", Slot = "5")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6309EA0", Offset = "0x63088A0", VA = "0x186309EA0")]
			internal ABKIOIKFLBD(int NDPHFODCHHB, float[] EBKNLFELEIM, APBIFGEIKHM KOCNMJOLOOE = APBIFGEIKHM.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6309D20", Offset = "0x6308720", VA = "0x186309D20")]
			public void PKNJJKNEAPI(bool KGKCFPOOODB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6308830", Offset = "0x6307230", VA = "0x186308830", Slot = "6")]
			public void BIPEDCDHLGG(ICMCGDFALFC COMOOAEHALC, float JMJINJAJLIO, OKAPGIDMLME DOMCICCMAOP = OKAPGIDMLME.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6308440", Offset = "0x6306E40", VA = "0x186308440", Slot = "9")]
			public void BIPEDCDHLGG(ICMCGDFALFC COMOOAEHALC, Transform GCKAEBNNLFG, float JMJINJAJLIO, OKAPGIDMLME DOMCICCMAOP = OKAPGIDMLME.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6309D50", Offset = "0x6308750", VA = "0x186309D50")]
			public void PPJBDOKHOHE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6309930", Offset = "0x6308330", VA = "0x186309930")]
			private void MIDGIJPIHBB(int ABBNIPHGMGH, [Optional] float? JMJINJAJLIO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6309550", Offset = "0x6307F50", VA = "0x186309550", Slot = "7")]
			public void MDELFCPLFEE(ICMCGDFALFC PACIPMNIMMN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x63088C0", Offset = "0x63072C0", VA = "0x1863088C0", Slot = "8")]
			public void BMMBNMJHFNL(ICMCGDFALFC COMOOAEHALC, OKAPGIDMLME IGAIAEGIKME)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6308B20", Offset = "0x6307520", VA = "0x186308B20", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6308DE0", Offset = "0x63077E0", VA = "0x186308DE0")]
			private void GJMJGBKKIBL(IEPDHFOKFLL OPCAIKOEKON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6309A80", Offset = "0x6308480", VA = "0x186309A80")]
			private void PBBHDJAPKII(IEPDHFOKFLL OPCAIKOEKON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6309170", Offset = "0x6307B70", VA = "0x186309170")]
			private void HFNJAPHJFAK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x63091D0", Offset = "0x6307BD0", VA = "0x1863091D0")]
			private void IJCMNBLNKEC(float JFNONBMGLIA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6308300", Offset = "0x6306D00", VA = "0x186308300")]
			private void AKKKLAMEPNN(IEPDHFOKFLL OPCAIKOEKON)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6309A70", Offset = "0x6308470", VA = "0x186309A70")]
			private void OKFPPDOLEEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6309A60", Offset = "0x6308460", VA = "0x186309A60")]
			private void OFFNKMAFFNL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6309230", Offset = "0x6307C30", VA = "0x186309230")]
			private void LCPGAEIBMJA(CullingGroupEvent HMDEENAJGOD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x63089B0", Offset = "0x63073B0", VA = "0x1863089B0")]
			private void DLNPFEIHPML()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct IHKMJAKDAHC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public ushort CFFBLLPMOBP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public Type AIFFIGEPBFM;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float BHPNINPHLLH = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float IKDIIELAMBC = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float LDHPOKAFCPM = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float HMLAKEGDKPP = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float NNHIGLPBBDK = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float FNEEKNBJLKO = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float AKGPNKOINFK = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<IHKMJAKDAHC, ABKIOIKFLBD> PHEBKBOEIOO;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable PLENPAINDIA;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable FBEKDIPHDIE;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static KMHDPFOFGLH ILIKHNCCCPK;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static KMHDPFOFGLH JJJCOCGKCHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly KMHDPFOFGLH COMNEDICGDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly KMHDPFOFGLH CJFNAHOLNKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly KMHDPFOFGLH OPIIJBJAKFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private GLCHHLNPLCE NKBNMFPCELI;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool KGKCFPOOODB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public KMHDPFOFGLH LAHNDPDLHHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7C2320", Offset = "0x7C0D20", VA = "0x1807C2320", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public KMHDPFOFGLH OAKGJLLAJKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x7C5500", Offset = "0x7C3F00", VA = "0x1807C5500", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public KMHDPFOFGLH BNOADCIMDBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7C5AA0", Offset = "0x7C44A0", VA = "0x1807C5AA0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool KBKMBPJDCII
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xD73890", Offset = "0xD72290", VA = "0x180D73890", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool BJEMFPLCMGO
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x886CD0", Offset = "0x8856D0", VA = "0x180886CD0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x979270", Offset = "0x977C70", VA = "0x180979270")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x630A290", Offset = "0x6308C90", VA = "0x18630A290", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x630AD40", Offset = "0x6309740", VA = "0x18630AD40")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x630AD20", Offset = "0x6309720", VA = "0x18630AD20")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x630AA30", Offset = "0x6309430", VA = "0x18630AA30")]
		private void HFGGCONENOD(Scene OCOLBAAFGJP, LoadSceneMode MMMGCOBDJOC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x630AC40", Offset = "0x6309640", VA = "0x18630AC40", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x630AFA0", Offset = "0x63099A0", VA = "0x18630AFA0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x630AAA0", Offset = "0x63094A0", VA = "0x18630AAA0")]
		private void OANMEJBLAHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x630AD60", Offset = "0x6309760", VA = "0x18630AD60")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x630A350", Offset = "0x6308D50", VA = "0x18630A350")]
		private void FMLCKKKDCBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x630A810", Offset = "0x6309210", VA = "0x18630A810")]
		public PAENFKLKNDA GetOrCreateCullingGroup(Type AFFEGINEAAE, int IEEBKOEEHMN, ushort MIHGOMPMFMA = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x27DE470", Offset = "0x27DCE70", VA = "0x1827DE470")]
		public PLNKJGJLOBN<T> GetOrCreateCullingGroup<T>(int IEEBKOEEHMN, ushort MIHGOMPMFMA = 0) where T : class, ICMCGDFALFC
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x630A630", Offset = "0x6309030", VA = "0x18630A630")]
		private PAENFKLKNDA GNBMKNICNBO(Type AFFEGINEAAE, int IEEBKOEEHMN, float[] EBKNLFELEIM, ushort MIHGOMPMFMA = 0)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x27DE200", Offset = "0x27DCC00", VA = "0x1827DE200")]
		private PLNKJGJLOBN<T> GNBMKNICNBO<T>(int IEEBKOEEHMN, float[] EBKNLFELEIM, ushort MIHGOMPMFMA = 0) where T : class, ICMCGDFALFC
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x630A4D0", Offset = "0x6308ED0", VA = "0x18630A4D0")]
		public static NGCLDJOGPMC FindClosestDefaultUpdateLod(float OBPKLEEFEIL)
		{
			return default(NGCLDJOGPMC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7F0450", Offset = "0x7EEE50", VA = "0x1807F0450")]
		public static NGCLDJOGPMC MinUpdateLod(NGCLDJOGPMC IICLPLIMMIO, NGCLDJOGPMC LPNPIKLFJLF)
		{
			return default(NGCLDJOGPMC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x630AA90", Offset = "0x6309490", VA = "0x18630AA90")]
		public static NGCLDJOGPMC MaxUpdateLod(NGCLDJOGPMC IICLPLIMMIO, NGCLDJOGPMC LPNPIKLFJLF)
		{
			return default(NGCLDJOGPMC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x630B410", Offset = "0x6309E10", VA = "0x18630B410")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface MMGILAHDGEL
{
	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool BBKAGMHAFCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	Camera JHHAAJLEFGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	KMHDPFOFGLH HCGCICHGILJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool JOHCOCLKFGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	KMHDPFOFGLH HNDAGAKNIDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	Transform BIMNKKCIDFO
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface PAENFKLKNDA
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool ANPLJLJBJFA
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BIPEDCDHLGG(ICMCGDFALFC COMOOAEHALC, float JMJINJAJLIO, OKAPGIDMLME DOMCICCMAOP = OKAPGIDMLME.Off);

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MDELFCPLFEE(ICMCGDFALFC PACIPMNIMMN);

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BMMBNMJHFNL(ICMCGDFALFC COMOOAEHALC, OKAPGIDMLME GLLCCLAANJF);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface PLNKJGJLOBN<T> : PAENFKLKNDA where T : class, ICMCGDFALFC
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BIPEDCDHLGG(T COMOOAEHALC, float JMJINJAJLIO, OKAPGIDMLME DOMCICCMAOP = OKAPGIDMLME.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BIPEDCDHLGG(T COMOOAEHALC, Transform GCKAEBNNLFG, float JMJINJAJLIO, OKAPGIDMLME DOMCICCMAOP = OKAPGIDMLME.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MDELFCPLFEE(T PACIPMNIMMN);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface ICMCGDFALFC
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform OEIDOHJNAOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(NGCLDJOGPMC BPNOEBOCJLD, NGCLDJOGPMC PMNBEIGDOGE);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool NPDFIGMPMJH);
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
