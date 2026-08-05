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
			[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
				[Cpp2IlInjected.Address(RVA = "0x1BA2E10", Offset = "0x1BA1610", VA = "0x181BA2E10")]
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
				[Cpp2IlInjected.Address(RVA = "0x1BA2E10", Offset = "0x1BA1610", VA = "0x181BA2E10")]
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
				[Cpp2IlInjected.Address(RVA = "0x561ED0", Offset = "0x5606D0", VA = "0x180561ED0", Slot = "8")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			public override int FOGIJFGEIBA
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x585710", Offset = "0x583F10", VA = "0x180585710", Slot = "9")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1BA5EC0", Offset = "0x1BA46C0", VA = "0x181BA5EC0")]
			internal DLIEDGIAADD(int DHMCLPHLMCK, float[] LODIBIPEFNO, MFAAIGHLJAG FKPNNFDJHDH = MFAAIGHLJAG.PlayerHead)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x1BA4A50", Offset = "0x1BA3250", VA = "0x181BA4A50", Slot = "10")]
			public override void HIAKFHHPHHI(bool GKDBAHONJJB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x1BA48C0", Offset = "0x1BA30C0", VA = "0x181BA48C0", Slot = "11")]
			public FDEOJIJAJDL FNBKMFCPFNH(float CFCNLOMCAGA)
			{
				return default(FDEOJIJAJDL);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x1BA52D0", Offset = "0x1BA3AD0", VA = "0x181BA52D0", Slot = "12")]
			public void IONNJMGFDPB(T OMILIKJDDEJ, float NHDAMMAAEOM, AOMHBJDLAMC IIOPMJODECK = AOMHBJDLAMC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x1BA4E50", Offset = "0x1BA3650", VA = "0x181BA4E50", Slot = "13")]
			public void IONNJMGFDPB(T OMILIKJDDEJ, Transform BIGDLLGFHFF, float NHDAMMAAEOM, AOMHBJDLAMC IIOPMJODECK = AOMHBJDLAMC.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x1BA4110", Offset = "0x1BA2910", VA = "0x181BA4110", Slot = "14")]
			public void BBFDHGKBLKP(T OMILIKJDDEJ, [Optional] float? NHDAMMAAEOM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x1BA5D50", Offset = "0x1BA4550", VA = "0x181BA5D50")]
			private void PNNEBFCJJBL(int CFANIPEBCPB, [Optional] float? NHDAMMAAEOM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1BA5370", Offset = "0x1BA3B70", VA = "0x181BA5370", Slot = "15")]
			public void JPAMCOIJOBL(T CFKFLIEPCIJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x1BA4D30", Offset = "0x1BA3530", VA = "0x181BA4D30", Slot = "16")]
			public FDEOJIJAJDL IKMABBFANPL(T OMILIKJDDEJ)
			{
				return default(FDEOJIJAJDL);
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x1BA4920", Offset = "0x1BA3120", VA = "0x181BA4920", Slot = "17")]
			public bool GLKOIDENJME(T OMILIKJDDEJ)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x1BA59D0", Offset = "0x1BA41D0", VA = "0x181BA59D0", Slot = "18")]
			public void MPHNFBPPIKC(T OMILIKJDDEJ, AOMHBJDLAMC EOKJLFGHPKE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1BA4540", Offset = "0x1BA2D40", VA = "0x181BA4540", Slot = "7")]
			public override void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x1BA4190", Offset = "0x1BA2990", VA = "0x181BA4190")]
			private void BECNMGKKJKB(JHFKFAAGMLF DFFGEFPCBGG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x1BA5750", Offset = "0x1BA3F50", VA = "0x181BA5750")]
			private void MHKFNLEDBJD(JHFKFAAGMLF DFFGEFPCBGG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x1BA5B70", Offset = "0x1BA4370", VA = "0x181BA5B70")]
			private void OOJEODKHMDE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x1BA5AE0", Offset = "0x1BA42E0", VA = "0x181BA5AE0")]
			private void NBPKHLMGBLI(float HGLNOLEGDAA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x1BA5710", Offset = "0x1BA3F10", VA = "0x181BA5710")]
			private void KGAMBIMJIHF(JHFKFAAGMLF DFFGEFPCBGG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x1BA5B50", Offset = "0x1BA4350", VA = "0x181BA5B50")]
			private void OAGIIJOOGED()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x1BA4A20", Offset = "0x1BA3220", VA = "0x181BA4A20")]
			private void GNACMLKAANG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x1BA4A80", Offset = "0x1BA3280", VA = "0x181BA4A80")]
			private void HNIAFCGDHHO(CullingGroupEvent JIJEHKHNHLD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x1BA5BE0", Offset = "0x1BA43E0", VA = "0x181BA5BE0")]
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
			[Cpp2IlInjected.Address(RVA = "0x5611C0", Offset = "0x55F9C0", VA = "0x1805611C0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public EBEHMDGBKDH EOGMOIEEDBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x563DF0", Offset = "0x5625F0", VA = "0x180563DF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public EBEHMDGBKDH HCKFKBHAPPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x58A0C0", Offset = "0x5888C0", VA = "0x18058A0C0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool KCNHIODICAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x135E5C0", Offset = "0x135CDC0", VA = "0x18135E5C0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool JLINGICEBGL
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x75A9A0", Offset = "0x7591A0", VA = "0x18075A9A0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x75AA20", Offset = "0x759220", VA = "0x18075AA20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x4EEACF0", Offset = "0x4EE94F0", VA = "0x184EEACF0", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1042030", Offset = "0x1040830", VA = "0x181042030")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x4EEB450", Offset = "0x4EE9C50", VA = "0x184EEB450")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4EEB280", Offset = "0x4EE9A80", VA = "0x184EEB280")]
		private void JMBOHBBNMLE(Scene DGPIBFABOPJ, LoadSceneMode MLBEKKOCNDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x4EEB3A0", Offset = "0x4EE9BA0", VA = "0x184EEB3A0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4EEB0E0", Offset = "0x4EE98E0", VA = "0x184EEB0E0")]
		private void GGGLAHBGANA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x4EEB470", Offset = "0x4EE9C70", VA = "0x184EEB470")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4EEAD90", Offset = "0x4EE9590", VA = "0x184EEAD90")]
		private void EADOHHIDDCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x1E4D250", Offset = "0x1E4BA50", VA = "0x181E4D250")]
		public global::HLNIKLHJDLG<T> GetOrCreateCullingGroup<T>(int BCDEHHPDEHI, ushort NOEIGOKHEBP = 0) where T : FACGNKPJEND
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x1E4D040", Offset = "0x1E4B840", VA = "0x181E4D040")]
		private global::HLNIKLHJDLG<T> COKJHCDMICA<T>(int BCDEHHPDEHI, float[] LODIBIPEFNO, ushort NOEIGOKHEBP = 0) where T : FACGNKPJEND
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x4EEAEF0", Offset = "0x4EE96F0", VA = "0x184EEAEF0")]
		public static FDEOJIJAJDL FindClosestDefaultUpdateLod(float FGLKNPOLFNC)
		{
			return default(FDEOJIJAJDL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x4EEB340", Offset = "0x4EE9B40", VA = "0x184EEB340")]
		public static FDEOJIJAJDL MinUpdateLod(FDEOJIJAJDL DKLCNGBCPEP, FDEOJIJAJDL EEKDNNCDBNP)
		{
			return default(FDEOJIJAJDL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4EEB2E0", Offset = "0x4EE9AE0", VA = "0x184EEB2E0")]
		public static FDEOJIJAJDL MaxUpdateLod(FDEOJIJAJDL DKLCNGBCPEP, FDEOJIJAJDL EEKDNNCDBNP)
		{
			return default(FDEOJIJAJDL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4EEB800", Offset = "0x4EEA000", VA = "0x184EEB800")]
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
		[Cpp2IlInjected.Address(RVA = "0x4EEC0B0", Offset = "0x4EEA8B0", VA = "0x184EEC0B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public FDEOJIJAJDL DNDCNGPCPJG
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x561ED0", Offset = "0x5606D0", VA = "0x180561ED0")]
		get
		{
			return default(FDEOJIJAJDL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public FDEOJIJAJDL OHDIAMJKLKG
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x585710", Offset = "0x583F10", VA = "0x180585710")]
		get
		{
			return default(FDEOJIJAJDL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4EEC100", Offset = "0x4EEA900", VA = "0x184EEC100")]
	public bool OKEGCOKGHHP(object JGMHCJIBOFB, FDEOJIJAJDL MFBIHMKFNKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4EEBEE0", Offset = "0x4EEA6E0", VA = "0x184EEBEE0")]
	public bool EKLFHNDDCHK(object JGMHCJIBOFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4EEBF40", Offset = "0x4EEA740", VA = "0x184EEBF40")]
	private bool LDDLHAPPDHC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4EEC170", Offset = "0x4EEA970", VA = "0x184EEC170")]
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
	[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
	public LCEEBCMBKCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4EEB8F0", Offset = "0x4EEA0F0", VA = "0x184EEB8F0")]
	private static string AFJLFGLOHPO(byte[] FMMAACMCILJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4EEB9F0", Offset = "0x4EEA1F0", VA = "0x184EEB9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x563AB0", Offset = "0x5622B0", VA = "0x180563AB0")]
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
