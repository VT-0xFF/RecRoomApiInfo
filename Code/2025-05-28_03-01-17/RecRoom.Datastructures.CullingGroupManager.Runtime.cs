using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Core.Culling
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[BurstCompile]
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, DCPGGKBOJAN, GCNHNEMJEGC
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[BurstCompile]
		private struct LEKECMPCFBF : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NativeArray<BoundingSphere> FFEMKICJPKP;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x7D5F6D0", Offset = "0x7D5E4D0", VA = "0x187D5F6D0", Slot = "4")]
			public void Execute(int GLAOLHCPLLG, TransformAccess MAAFBDAKBJA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private struct CNFNBGJCFOJ : IEquatable<CNFNBGJCFOJ>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public ushort CNGAKCLJPHA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Type JOFAOHDFCCC;

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x7D5C070", Offset = "0x7D5AE70", VA = "0x187D5C070", Slot = "4")]
			public bool Equals(CNFNBGJCFOJ HBLONCAMFLG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x7D5BF80", Offset = "0x7D5AD80", VA = "0x187D5BF80", Slot = "0")]
			public override bool Equals(object GLEBGNJJOHG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7D5C0F0", Offset = "0x7D5AEF0", VA = "0x187D5C0F0", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class AMOOEIHJINK<T> : IGCHLEMPPAH, GHLMGBLMLMF<T>, PJDHIPHKKMB where T : class, OCIHNCJEHMB
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x4E93A90", Offset = "0x4E92890", VA = "0x184E93A90")]
			internal AMOOEIHJINK(int ELPDIJCBGPI, float[] LDAGCNKEEEK, NFCCENLBECP EIEPGELAMHD = NFCCENLBECP.PlayerHead, bool OFPOHPHPKEO = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x4E93A20", Offset = "0x4E92820", VA = "0x184E93A20", Slot = "12")]
			public void AIKICPLLADB(T GLEBGNJJOHG, float MEHMJKKFJEH, HGOCJAJAHJN DLEGBMCAIFA = HGOCJAJAHJN.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x4E939F0", Offset = "0x4E927F0", VA = "0x184E939F0", Slot = "13")]
			public void AIKICPLLADB(T GLEBGNJJOHG, Transform CBLJEJGPOLI, float MEHMJKKFJEH, HGOCJAJAHJN DLEGBMCAIFA = HGOCJAJAHJN.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x4E93A50", Offset = "0x4E92850", VA = "0x184E93A50", Slot = "14")]
			public void FKCGDELNEED(T GKADPNILOBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x4E93A70", Offset = "0x4E92870", VA = "0x184E93A70", Slot = "15")]
			public bool IGCJECGLPNH(T GLEBGNJJOHG)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class IGCHLEMPPAH : IDisposable, PJDHIPHKKMB
		{
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			private struct GHCJNDEOAJC
			{
				[Cpp2IlInjected.Token(Token = "0x2000008")]
				public enum BDMAIKFLJEO : byte
				{
					[Cpp2IlInjected.Token(Token = "0x4000031")]
					Add,
					[Cpp2IlInjected.Token(Token = "0x4000032")]
					UpdateRadius,
					[Cpp2IlInjected.Token(Token = "0x4000033")]
					UpdatePosition,
					[Cpp2IlInjected.Token(Token = "0x4000034")]
					UpdateTrackRate,
					[Cpp2IlInjected.Token(Token = "0x4000035")]
					Remove
				}

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400002B")]
				public OCIHNCJEHMB EKMIHGEOGNM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public Transform MNFKMLBDMML;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public float LLINGMLBPPJ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public HGOCJAJAHJN BNKGOKPLGHA;

				[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public BDMAIKFLJEO KDNIOMEAELB;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public enum NFCCENLBECP : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private class DFFHDJFOBDE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public OCIHNCJEHMB EKMIHGEOGNM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public HGOCJAJAHJN CKCMGCNBHLM;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public Action LLBENDFGNON;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public bool MHOKKCEPHLB;

				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
				public DFFHDJFOBDE()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly int NMACKFEHHPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private bool OFPOHPHPKEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private bool OMPJCPABCDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CullingGroup JNEDCNFJOEA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private BoundingSphere[] EIKKHCOKPCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly MKAAJPEJMGM LKIBPKBGCOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly NFCCENLBECP EIEPGELAMHD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly Dictionary<OCIHNCJEHMB, int> CMPJLLOEJDA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<int, DFFHDJFOBDE> BNAEDNENKPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TransformAccessArray AOGDOBABMGL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private NativeList<BoundingSphere> AMKBHDCKLDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly List<GHCJNDEOAJC> KGDHNAOPPDO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private bool KFJBLKLCBCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private JobHandle JAAMMEMKHCH;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int CFOMGPFIIHM
			{
				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0xA081A0", Offset = "0xA06FA0", VA = "0x180A081A0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0xA11340", Offset = "0xA10140", VA = "0x180A11340")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public int NCCIJMDNJIC
			{
				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0xB97DF0", Offset = "0xB96BF0", VA = "0x180B97DF0", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x600002A")]
				[Cpp2IlInjected.Address(RVA = "0xC82D00", Offset = "0xC81B00", VA = "0x180C82D00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x7D5F1F0", Offset = "0x7D5DFF0", VA = "0x187D5F1F0")]
			internal IGCHLEMPPAH(int ELPDIJCBGPI, float[] LDAGCNKEEEK, NFCCENLBECP EIEPGELAMHD = NFCCENLBECP.PlayerHead, bool OFPOHPHPKEO = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7D5EFB0", Offset = "0x7D5DDB0", VA = "0x187D5EFB0")]
			public void NFPHFMEEDJG(bool LLOCMBEOOFB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x7D5D5B0", Offset = "0x7D5C3B0", VA = "0x187D5D5B0", Slot = "5")]
			public void AIKICPLLADB(OCIHNCJEHMB GLEBGNJJOHG, float MEHMJKKFJEH, HGOCJAJAHJN DLEGBMCAIFA = HGOCJAJAHJN.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7D5D6B0", Offset = "0x7D5C4B0", VA = "0x187D5D6B0", Slot = "10")]
			public void AIKICPLLADB(OCIHNCJEHMB GLEBGNJJOHG, Transform CBLJEJGPOLI, float MEHMJKKFJEH, HGOCJAJAHJN DLEGBMCAIFA = HGOCJAJAHJN.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x7D5E470", Offset = "0x7D5D270", VA = "0x187D5E470")]
			private void IAOPALMDLLL(OCIHNCJEHMB GLEBGNJJOHG, Transform CBLJEJGPOLI, float MEHMJKKFJEH, HGOCJAJAHJN DLEGBMCAIFA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x7D5E0D0", Offset = "0x7D5CED0", VA = "0x187D5E0D0", Slot = "6")]
			public void FKCGDELNEED(OCIHNCJEHMB GKADPNILOBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x7D5DC90", Offset = "0x7D5CA90", VA = "0x187D5DC90")]
			private void FENJNMHCNEB(OCIHNCJEHMB GKADPNILOBB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7D5D750", Offset = "0x7D5C550", VA = "0x187D5D750")]
			private void CGFDFHKOEAF(OCIHNCJEHMB GLEBGNJJOHG, [Optional] float? MEHMJKKFJEH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7D5E870", Offset = "0x7D5D670", VA = "0x187D5E870", Slot = "11")]
			public bool IGCJECGLPNH(OCIHNCJEHMB GLEBGNJJOHG)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9C0", Offset = "0xA097C0", VA = "0x180A0A9C0", Slot = "7")]
			public void AHFJLAHMLNB(OCIHNCJEHMB GLEBGNJJOHG, HGOCJAJAHJN PNLNPAHIAEE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7D5DBE0", Offset = "0x7D5C9E0", VA = "0x187D5DBE0")]
			private void FEDIGEPFGGP(OCIHNCJEHMB GLEBGNJJOHG, HGOCJAJAHJN PNLNPAHIAEE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7D5EFE0", Offset = "0x7D5DDE0", VA = "0x187D5EFE0")]
			public void NHOOPELFBIF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x7D5E930", Offset = "0x7D5D730", VA = "0x187D5E930")]
			public void MEEJBKNODDM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7D5ECB0", Offset = "0x7D5DAB0", VA = "0x187D5ECB0")]
			private void MGJNHACLBMO(GHCJNDEOAJC KMBJNMDOLGN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7D5F0A0", Offset = "0x7D5DEA0", VA = "0x187D5F0A0")]
			private void POIGGDGILEN(int MGDEAMEOKAC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7D5D9B0", Offset = "0x7D5C7B0", VA = "0x187D5D9B0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x7D5E460", Offset = "0x7D5D260", VA = "0x187D5E460")]
			private void HCOFGGHDDPD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x7D5E860", Offset = "0x7D5D660", VA = "0x187D5E860")]
			private void IBLHGBJDPMC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7D5E130", Offset = "0x7D5CF30", VA = "0x187D5E130")]
			private void FMKBBBIABCD(CullingGroupEvent EEMOIKIBMDB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x7D5EB40", Offset = "0x7D5D940", VA = "0x187D5EB40")]
			private void MELLPOHMAIJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float OOACCGFCECB = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float NPPNIJPFNAI = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float BNOPKHDDBLK = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float FIGDBNANHOG = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float DNBNNBHCGHH = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float IJENIEAKOBJ = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float GKPKHHFCAFH = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<CNFNBGJCFOJ, IGCHLEMPPAH> AHNODNHADHD;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable ILNOMMFOLPP;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable GNHGOCGMMCO;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static LLEAAEBCCKF HAIAAGACGII;

		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private static LLEAAEBCCKF NBGIOAKMCJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly LLEAAEBCCKF DDIIDLMDDAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly LLEAAEBCCKF CJICIPLGKCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly LLEAAEBCCKF NANFDCMOCOA;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static ProfilerMarker FHGHJNOGMFF;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ProfilerMarker PJKEIHDEBMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private BGLABEGMMJM MHPGDPMAJFJ;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static bool LLOCMBEOOFB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public bool BHAGMIIGHDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0xA0ED10", Offset = "0xA0DB10", VA = "0x180A0ED10", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0xA0ECB0", Offset = "0xA0DAB0", VA = "0x180A0ECB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public LLEAAEBCCKF PFKFDCHFKFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA0EAC0", Offset = "0xA0D8C0", VA = "0x180A0EAC0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public LLEAAEBCCKF LFBGGHDHJGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xA0ED30", Offset = "0xA0DB30", VA = "0x180A0ED30", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public LLEAAEBCCKF FFMEDJBKMGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA0EAF0", Offset = "0xA0D8F0", VA = "0x180A0EAF0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool KFJKHIEBINM
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA36800", Offset = "0xA35600", VA = "0x180A36800", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool FHAAHJPKGBA
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xC3A4D0", Offset = "0xC392D0", VA = "0x180C3A4D0", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xD17420", Offset = "0xD16220", VA = "0x180D17420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7D5C160", Offset = "0x7D5AF60", VA = "0x187D5C160", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7B3A920", Offset = "0x7B39720", VA = "0x187B3A920")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1EC9AA0", Offset = "0x1EC88A0", VA = "0x181EC9AA0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xC29C70", Offset = "0xC28A70", VA = "0x180C29C70")]
		protected void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7D5C6D0", Offset = "0x7D5B4D0", VA = "0x187D5C6D0")]
		private void LOKENOMJNGH(Scene EEMDMFPCGLE, LoadSceneMode FIAIMOBPCDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7D5CC30", Offset = "0x7D5BA30", VA = "0x187D5CC30", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7D5CFB0", Offset = "0x7D5BDB0", VA = "0x187D5CFB0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7D5C730", Offset = "0x7D5B530", VA = "0x187D5C730")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7D5CAC0", Offset = "0x7D5B8C0", VA = "0x187D5CAC0")]
		private void MKCMCKBFDME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7D5CD10", Offset = "0x7D5BB10", VA = "0x187D5CD10")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7D5C560", Offset = "0x7D5B360", VA = "0x187D5C560")]
		private void JIDMECBIBOC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7D5C380", Offset = "0x7D5B180", VA = "0x187D5C380")]
		public PJDHIPHKKMB GetOrCreateCullingGroup(Type OGPDMGAMNKL, int CLAPDOCAEMF, ushort PIAOEJABIBM = 0, bool OFPOHPHPKEO = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3751C90", Offset = "0x3750A90", VA = "0x183751C90")]
		public GHLMGBLMLMF<T> GetOrCreateCullingGroup<T>(int CLAPDOCAEMF, ushort PIAOEJABIBM = 0, bool OFPOHPHPKEO = false) where T : class, OCIHNCJEHMB
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7D5C930", Offset = "0x7D5B730", VA = "0x187D5C930")]
		private PJDHIPHKKMB MIAGLKMFJLF(Type OGPDMGAMNKL, int CLAPDOCAEMF, float[] LDAGCNKEEEK, ushort PIAOEJABIBM = 0, bool OFPOHPHPKEO = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3751D50", Offset = "0x3750B50", VA = "0x183751D50")]
		private GHLMGBLMLMF<T> MIAGLKMFJLF<T>(int CLAPDOCAEMF, float[] LDAGCNKEEEK, ushort PIAOEJABIBM = 0, bool OFPOHPHPKEO = false) where T : class, OCIHNCJEHMB
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7D5C220", Offset = "0x7D5B020", VA = "0x187D5C220")]
		public static MOCFDENFFJA FindClosestDefaultUpdateLod(float DJBNENCDOJK)
		{
			return default(MOCFDENFFJA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xA370A0", Offset = "0xA35EA0", VA = "0x180A370A0")]
		public static MOCFDENFFJA MinUpdateLod(MOCFDENFFJA DADADDJLADD, MOCFDENFFJA EONMCIIPBPN)
		{
			return default(MOCFDENFFJA);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7D5CC20", Offset = "0x7D5BA20", VA = "0x187D5CC20")]
		public static MOCFDENFFJA MaxUpdateLod(MOCFDENFFJA DADADDJLADD, MOCFDENFFJA EONMCIIPBPN)
		{
			return default(MOCFDENFFJA);
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x7D5D460", Offset = "0x7D5C260", VA = "0x187D5D460")]
		public CullingGroupManager()
		{
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xA36800", Offset = "0xA35600", VA = "0x180A36800", Slot = "11")]
		private bool IICCIPPFFJD()
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface MKAAJPEJMGM
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool ACEBCIINKJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	Camera NBHEBJDCKGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	LLEAAEBCCKF AJJFKFKCFHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	bool NDHJACDPFAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	LLEAAEBCCKF PPPPHEFNPAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform GANCILKPEFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PJDHIPHKKMB
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AIKICPLLADB(OCIHNCJEHMB GLEBGNJJOHG, float MEHMJKKFJEH, HGOCJAJAHJN DLEGBMCAIFA = HGOCJAJAHJN.Off);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FKCGDELNEED(OCIHNCJEHMB GKADPNILOBB);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AHFJLAHMLNB(OCIHNCJEHMB GLEBGNJJOHG, HGOCJAJAHJN HKHKFPJDKDH);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface GHLMGBLMLMF<T> : PJDHIPHKKMB where T : class, OCIHNCJEHMB
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AIKICPLLADB(T GLEBGNJJOHG, float MEHMJKKFJEH, HGOCJAJAHJN DLEGBMCAIFA = HGOCJAJAHJN.Off);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AIKICPLLADB(T GLEBGNJJOHG, Transform CBLJEJGPOLI, float MEHMJKKFJEH, HGOCJAJAHJN DLEGBMCAIFA = HGOCJAJAHJN.Off);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FKCGDELNEED(T GKADPNILOBB);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool IGCJECGLPNH(T GLEBGNJJOHG);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface OCIHNCJEHMB
{
	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	Transform MAAFBDAKBJA
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(MOCFDENFFJA POKFHBLLJAE, MOCFDENFFJA KCFKGDKIEEK);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool GKLLNNLGJLM);
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
