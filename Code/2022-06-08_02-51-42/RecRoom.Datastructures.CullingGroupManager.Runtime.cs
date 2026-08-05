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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, OBOJOLAHPAP
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		private abstract class KMGFMFODLHG : IDisposable, FDEPBIOFADJ
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public abstract int IKHCEMKPGHM
			{
				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(Slot = "8")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public abstract int FOGIJFGEIBA
			{
				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(Slot = "9")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(Slot = "7")]
			public abstract void Dispose();

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "10")]
			public abstract void HIAKFHHPHHI(bool GKDBAHONJJB);

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
			protected KMGFMFODLHG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private class DLIEDGIAADD<T> : KMGFMFODLHG, global::HLNIKLHJDLG<T>, FDEPBIOFADJ where T : FACGNKPJEND
		{
			[Cpp2IlInjected.Token(Token = "0x2000005")]
			public enum MFAAIGHLJAG : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000021")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000022")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x2000006")]
			private class JHFKFAAGMLF
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public T BGNDHHCHOJF;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public AOMHBJDLAMC NLDLEEJGPOG;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public Action CPBFFDDPCDD;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public bool HOIPLNFMHIN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public int MPBCIHFGEMC;

				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x1407010", Offset = "0x1406010", VA = "0x181407010")]
				public JHFKFAAGMLF()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x2000007")]
			[CompilerGenerated]
			private sealed class MPOGNDAHEKD
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public DLIEDGIAADD<T> <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public JHFKFAAGMLF trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000033")]
				[Cpp2IlInjected.Address(RVA = "0x1407010", Offset = "0x1406010", VA = "0x181407010")]
				public MPOGNDAHEKD()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000015")]
			private int BDKKHEFGPEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private int DHMCLPHLMCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private readonly int CMCFLBCDONO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private bool MGKCHJEDODG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private readonly CullingGroup JPKOGJLCJAD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private BoundingSphere[] PFDCFLCBAOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private Transform[] HGHJHCLMPII;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private readonly CHJFFNFBELM KFFAFDBPAEP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly Dictionary<T, int> FJCEPFDKPNP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private readonly Dictionary<int, JHFKFAAGMLF> KDPKPLMGELI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private readonly MFAAIGHLJAG FKPNNFDJHDH;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public override int IKHCEMKPGHM
			{
				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x594770", Offset = "0x593770", VA = "0x180594770", Slot = "8")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public override int FOGIJFGEIBA
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x5B25B0", Offset = "0x5B15B0", VA = "0x1805B25B0", Slot = "9")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x246D760", Offset = "0x246C760", VA = "0x18246D760")]
			internal DLIEDGIAADD(int DHMCLPHLMCK, float[] LODIBIPEFNO, MFAAIGHLJAG FKPNNFDJHDH = MFAAIGHLJAG.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x246C290", Offset = "0x246B290", VA = "0x18246C290", Slot = "10")]
			public override void HIAKFHHPHHI(bool GKDBAHONJJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x246C100", Offset = "0x246B100", VA = "0x18246C100", Slot = "11")]
			public FDEOJIJAJDL FNBKMFCPFNH(float CFCNLOMCAGA)
			{
				return default(FDEOJIJAJDL);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x246CB70", Offset = "0x246BB70", VA = "0x18246CB70", Slot = "12")]
			public void IONNJMGFDPB(T OMILIKJDDEJ, float NHDAMMAAEOM, AOMHBJDLAMC IIOPMJODECK = AOMHBJDLAMC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x246C6F0", Offset = "0x246B6F0", VA = "0x18246C6F0", Slot = "13")]
			public void IONNJMGFDPB(T OMILIKJDDEJ, Transform BIGDLLGFHFF, float NHDAMMAAEOM, AOMHBJDLAMC IIOPMJODECK = AOMHBJDLAMC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x246B950", Offset = "0x246A950", VA = "0x18246B950", Slot = "14")]
			public void BBFDHGKBLKP(T OMILIKJDDEJ, [Optional] float? NHDAMMAAEOM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x246D5F0", Offset = "0x246C5F0", VA = "0x18246D5F0")]
			private void PNNEBFCJJBL(int CFANIPEBCPB, [Optional] float? NHDAMMAAEOM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x246CC10", Offset = "0x246BC10", VA = "0x18246CC10", Slot = "15")]
			public void JPAMCOIJOBL(T CFKFLIEPCIJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x246C5D0", Offset = "0x246B5D0", VA = "0x18246C5D0", Slot = "16")]
			public FDEOJIJAJDL IKMABBFANPL(T OMILIKJDDEJ)
			{
				return default(FDEOJIJAJDL);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x246C160", Offset = "0x246B160", VA = "0x18246C160", Slot = "17")]
			public bool GLKOIDENJME(T OMILIKJDDEJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x246D270", Offset = "0x246C270", VA = "0x18246D270", Slot = "18")]
			public void MPHNFBPPIKC(T OMILIKJDDEJ, AOMHBJDLAMC EOKJLFGHPKE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x246BD80", Offset = "0x246AD80", VA = "0x18246BD80", Slot = "7")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x246B9D0", Offset = "0x246A9D0", VA = "0x18246B9D0")]
			private void BECNMGKKJKB(JHFKFAAGMLF DFFGEFPCBGG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x246CFF0", Offset = "0x246BFF0", VA = "0x18246CFF0")]
			private void MHKFNLEDBJD(JHFKFAAGMLF DFFGEFPCBGG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x246D410", Offset = "0x246C410", VA = "0x18246D410")]
			private void OOJEODKHMDE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x246D380", Offset = "0x246C380", VA = "0x18246D380")]
			private void NBPKHLMGBLI(float HGLNOLEGDAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x246CFB0", Offset = "0x246BFB0", VA = "0x18246CFB0")]
			private void KGAMBIMJIHF(JHFKFAAGMLF DFFGEFPCBGG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x246D3F0", Offset = "0x246C3F0", VA = "0x18246D3F0")]
			private void OAGIIJOOGED()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x246C260", Offset = "0x246B260", VA = "0x18246C260")]
			private void GNACMLKAANG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x246C2C0", Offset = "0x246B2C0", VA = "0x18246C2C0")]
			private void HNIAFCGDHHO(CullingGroupEvent JIJEHKHNHLD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x246D480", Offset = "0x246C480", VA = "0x18246D480")]
			private void PCNIGNPCDHA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		private struct ANBLIKMOLLH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			public ushort DBJMHOHPPDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public Type MLIBJMAECGK;
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float ENLEDDCJCIH = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float ILDFEPDLAMO = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float BKLMCIHEIIJ = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float CHJOGJCIFOO = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float BIHCMNBCGEO = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float HEJDBJADKNJ = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float AGNKCLEFKHJ = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private static readonly Dictionary<ANBLIKMOLLH, KMGFMFODLHG> EOJFJNCJOAO;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable BJOMLJHBKBI;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable KFDJILEGFML;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static EBEHMDGBKDH IPHDJOPEAGN;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static EBEHMDGBKDH KEPFGANHJCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly EBEHMDGBKDH JMOFMAOICGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly EBEHMDGBKDH KBHDALFLHMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly EBEHMDGBKDH LINLJMDCMIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private NGEEMJOOCBL EEHPNHMOILK;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static bool GKDBAHONJJB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public EBEHMDGBKDH IOCGJGKDEEH
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x5835A0", Offset = "0x5825A0", VA = "0x1805835A0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public EBEHMDGBKDH EOGMOIEEDBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x584B30", Offset = "0x583B30", VA = "0x180584B30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public EBEHMDGBKDH HCKFKBHAPPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x58BFF0", Offset = "0x58AFF0", VA = "0x18058BFF0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool KCNHIODICAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xD91270", Offset = "0xD90270", VA = "0x180D91270", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool JLINGICEBGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x584B00", Offset = "0x583B00", VA = "0x180584B00", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x584AD0", Offset = "0x583AD0", VA = "0x180584AD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4D81890", Offset = "0x4D80890", VA = "0x184D81890", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x666A20", Offset = "0x665A20", VA = "0x180666A20")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4D81FF0", Offset = "0x4D80FF0", VA = "0x184D81FF0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4D81E20", Offset = "0x4D80E20", VA = "0x184D81E20")]
		private void JMBOHBBNMLE(Scene DGPIBFABOPJ, LoadSceneMode MLBEKKOCNDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4D81F40", Offset = "0x4D80F40", VA = "0x184D81F40", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4D81C80", Offset = "0x4D80C80", VA = "0x184D81C80")]
		private void GGGLAHBGANA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4D82010", Offset = "0x4D81010", VA = "0x184D82010")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4D81930", Offset = "0x4D80930", VA = "0x184D81930")]
		private void EADOHHIDDCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1723DD0", Offset = "0x1722DD0", VA = "0x181723DD0")]
		public global::HLNIKLHJDLG<T> GetOrCreateCullingGroup<T>(int BCDEHHPDEHI, ushort NOEIGOKHEBP = 0) where T : FACGNKPJEND
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1723BC0", Offset = "0x1722BC0", VA = "0x181723BC0")]
		private global::HLNIKLHJDLG<T> COKJHCDMICA<T>(int BCDEHHPDEHI, float[] LODIBIPEFNO, ushort NOEIGOKHEBP = 0) where T : FACGNKPJEND
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x4D81A90", Offset = "0x4D80A90", VA = "0x184D81A90")]
		public static FDEOJIJAJDL FindClosestDefaultUpdateLod(float FGLKNPOLFNC)
		{
			return default(FDEOJIJAJDL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4D81EE0", Offset = "0x4D80EE0", VA = "0x184D81EE0")]
		public static FDEOJIJAJDL MinUpdateLod(FDEOJIJAJDL DKLCNGBCPEP, FDEOJIJAJDL EEKDNNCDBNP)
		{
			return default(FDEOJIJAJDL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4D81E80", Offset = "0x4D80E80", VA = "0x184D81E80")]
		public static FDEOJIJAJDL MaxUpdateLod(FDEOJIJAJDL DKLCNGBCPEP, FDEOJIJAJDL EEKDNNCDBNP)
		{
			return default(FDEOJIJAJDL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4D823A0", Offset = "0x4D813A0", VA = "0x184D823A0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface CHJFFNFBELM
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	bool CNEJDECBIEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	Camera FOOFFIOEJBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	EBEHMDGBKDH IKMJEOFJHIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	bool PFGDJOEOOEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	EBEHMDGBKDH EEMGKDFNCAA
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform DLMBAJBEOKO
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface FDEPBIOFADJ
{
	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int IKHCEMKPGHM
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	int FOGIJFGEIBA
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface HLNIKLHJDLG<T> : FDEPBIOFADJ where T : FACGNKPJEND
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FDEOJIJAJDL FNBKMFCPFNH(float CFCNLOMCAGA);

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IONNJMGFDPB(T OMILIKJDDEJ, float NHDAMMAAEOM, AOMHBJDLAMC IIOPMJODECK = AOMHBJDLAMC.Off);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IONNJMGFDPB(T OMILIKJDDEJ, Transform BIGDLLGFHFF, float NHDAMMAAEOM, AOMHBJDLAMC IIOPMJODECK = AOMHBJDLAMC.Off);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BBFDHGKBLKP(T OMILIKJDDEJ, [Optional] float? NHDAMMAAEOM);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JPAMCOIJOBL(T CFKFLIEPCIJ);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FDEOJIJAJDL IKMABBFANPL(T OMILIKJDDEJ);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool GLKOIDENJME(T OMILIKJDDEJ);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MPHNFBPPIKC(T OMILIKJDDEJ, AOMHBJDLAMC IEGEDINCAEM);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface FACGNKPJEND
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Transform AGPJKNMIGHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(FDEOJIJAJDL IEABCFHNEGK, FDEOJIJAJDL DLCLOKPDEHD);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool EMCMCEFIBNK);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public enum AOMHBJDLAMC : byte
{
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	Off,
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	Limited,
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	Full
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public enum FDEOJIJAJDL
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
public class NJIPEIPLGFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private FDEOJIJAJDL OBJPCHOBPAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private FDEOJIJAJDL JDMPDBLFGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private Dictionary<object, FDEOJIJAJDL> CGPNMLMGPCF;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool PGBNKFDCFHL
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x4D82C50", Offset = "0x4D81C50", VA = "0x184D82C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public FDEOJIJAJDL DNDCNGPCPJG
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x594770", Offset = "0x593770", VA = "0x180594770")]
		get
		{
			return default(FDEOJIJAJDL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public FDEOJIJAJDL OHDIAMJKLKG
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5B25B0", Offset = "0x5B15B0", VA = "0x1805B25B0")]
		get
		{
			return default(FDEOJIJAJDL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4D82CA0", Offset = "0x4D81CA0", VA = "0x184D82CA0")]
	public bool OKEGCOKGHHP(object JGMHCJIBOFB, FDEOJIJAJDL MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4D82A80", Offset = "0x4D81A80", VA = "0x184D82A80")]
	public bool EKLFHNDDCHK(object JGMHCJIBOFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4D82AE0", Offset = "0x4D81AE0", VA = "0x184D82AE0")]
	private bool LDDLHAPPDHC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4D82D10", Offset = "0x4D81D10", VA = "0x184D82D10")]
	public NJIPEIPLGFL()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class LCEEBCMBKCD
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static byte[] FOBLDOOIPBJ;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int MKBJJHBJLOC;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int IFDBKDIOMPI;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static BigInteger GDKMPNMIOJK;

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
	public LCEEBCMBKCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4D82490", Offset = "0x4D81490", VA = "0x184D82490")]
	private static string AFJLFGLOHPO(byte[] FMMAACMCILJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4D82590", Offset = "0x4D81590", VA = "0x184D82590")]
	public static string CAJPNALAKAJ(byte[] JNPIAJHKCKB, bool GKIDOBEBBAE)
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
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x54F0C0", Offset = "0x54E0C0", VA = "0x18054F0C0")]
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
