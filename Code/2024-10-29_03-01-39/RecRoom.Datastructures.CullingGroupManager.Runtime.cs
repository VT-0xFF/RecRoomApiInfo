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
	public class CullingGroupManager : SingletonMonoBehaviour<CullingGroupManager>, BGLICCIOOAL
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		[BurstCompile]
		private struct FONAGOOGLCP : IJobParallelForTransform
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public NativeArray<BoundingSphere> CONAFKKIHKL;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6E70A30", Offset = "0x6E6FA30", VA = "0x186E70A30", Slot = "4")]
			public void Execute(int KHAIDMGPIED, TransformAccess IMCFIOFNLHP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000004")]
		private struct HKDBPEMGILK : IEquatable<HKDBPEMGILK>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public ushort JJLCCHEMLMF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public Type JOGFAHKKLEP;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6E70BA0", Offset = "0x6E6FBA0", VA = "0x186E70BA0", Slot = "4")]
			public bool Equals(HKDBPEMGILK DFABCHNPEEM)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6E70AB0", Offset = "0x6E6FAB0", VA = "0x186E70AB0", Slot = "0")]
			public override bool Equals(object IFPBFCLBBDP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6E70C20", Offset = "0x6E6FC20", VA = "0x186E70C20", Slot = "2")]
			public override int GetHashCode()
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000005")]
		private class GBMJFEHLGKJ<T> : MMDIBAAPAHO, JEAJJDEJHCP<T>, OICHLINLOOD where T : class, LKBGBEKOGHP
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x40E82A0", Offset = "0x40E72A0", VA = "0x1840E82A0")]
			internal GBMJFEHLGKJ(int CEHFJJIDIAE, float[] PDPDFPDGLCG, HBPJHCFDBLN BGNGCCBMOCG = HBPJHCFDBLN.PlayerHead, bool BGIBIHOOENE = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x40E8240", Offset = "0x40E7240", VA = "0x1840E8240", Slot = "12")]
			public void OPFOFHIGBEE(T IFPBFCLBBDP, float PEGACPFCNHH, HJCFABINHDE NJOPLCGKLHH = HJCFABINHDE.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x40E8270", Offset = "0x40E7270", VA = "0x1840E8270", Slot = "13")]
			public void OPFOFHIGBEE(T IFPBFCLBBDP, Transform DAJPJINHLIM, float PEGACPFCNHH, HJCFABINHDE NJOPLCGKLHH = HJCFABINHDE.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x40E8220", Offset = "0x40E7220", VA = "0x1840E8220", Slot = "14")]
			public void CAKBCGBONLK(T HBEEEGFHKCB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x40E8200", Offset = "0x40E7200", VA = "0x1840E8200", Slot = "15")]
			public bool ADAFLBKAJPO(T IFPBFCLBBDP)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		private class MMDIBAAPAHO : IDisposable, OICHLINLOOD
		{
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			private struct IOMMEHNMLMP
			{
				[Cpp2IlInjected.Token(Token = "0x2000008")]
				public enum PPEFBPGPAFL : byte
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
				public LKBGBEKOGHP FHMIHKKAAMI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public Transform JAFJFBMIFFH;

				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400002D")]
				public float FFDPGNIGBDB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public HJCFABINHDE ECADMLGHOCB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public PPEFBPGPAFL BFKMCKBKOAJ;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public enum HBPJHCFDBLN : byte
			{
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				PlayerHead,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				Camera
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			private class NELPJCLNPID
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				public LKBGBEKOGHP FHMIHKKAAMI;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				public HJCFABINHDE CCKBDIKCDBB;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				public Action AKEPPIJBKLN;

				[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				public bool KPFMFNAOANC;

				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
				public NELPJCLNPID()
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			[CompilerGenerated]
			private sealed class JAEJGJBKHCE
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x400003D")]
				public MMDIBAAPAHO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x400003E")]
				public NELPJCLNPID trackedObject;

				[Cpp2IlInjected.Token(Token = "0x6000041")]
				[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
				public JAEJGJBKHCE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x6E70C90", Offset = "0x6E6FC90", VA = "0x186E70C90")]
				internal void NFNDFBDJFIK()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private readonly int GBJJLLONKID;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private bool BGIBIHOOENE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1D")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private bool GNHIBNEGODJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly CullingGroup JMHJAGOPIIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private BoundingSphere[] HFNBOAEDLFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly PFEDGBLEGPB LAFNKOLGHIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private readonly HBPJHCFDBLN BGNGCCBMOCG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private readonly Dictionary<LKBGBEKOGHP, int> BGOOECMGICM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private readonly Dictionary<int, NELPJCLNPID> PDGKJBNIBPC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private TransformAccessArray BEAILLNCAMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private NativeList<BoundingSphere> KBGKKINLJLH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private readonly List<IOMMEHNMLMP> AAPBPCFKHHP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private bool DLJBCLAJFKF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private JobHandle CGOCMLLNHDP;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public int GADDIGIMKNN
			{
				[Cpp2IlInjected.Token(Token = "0x6000023")]
				[Cpp2IlInjected.Address(RVA = "0x8B41A0", Offset = "0x8B31A0", VA = "0x1808B41A0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000024")]
				[Cpp2IlInjected.Address(RVA = "0x8B6600", Offset = "0x8B5600", VA = "0x1808B6600")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public int CKOGINBGBKH
			{
				[Cpp2IlInjected.Token(Token = "0x6000025")]
				[Cpp2IlInjected.Address(RVA = "0xAC50D0", Offset = "0xAC40D0", VA = "0x180AC50D0", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0xAC50C0", Offset = "0xAC40C0", VA = "0x180AC50C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6E733F0", Offset = "0x6E723F0", VA = "0x186E733F0")]
			internal MMDIBAAPAHO(int CEHFJJIDIAE, float[] PDPDFPDGLCG, HBPJHCFDBLN BGNGCCBMOCG = HBPJHCFDBLN.PlayerHead, bool BGIBIHOOENE = false)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6E725E0", Offset = "0x6E715E0", VA = "0x186E725E0")]
			public void KAHEFCGEMHD(bool BFKLCFNPCAG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6E730E0", Offset = "0x6E720E0", VA = "0x186E730E0", Slot = "5")]
			public void OPFOFHIGBEE(LKBGBEKOGHP IFPBFCLBBDP, float PEGACPFCNHH, HJCFABINHDE NJOPLCGKLHH = HJCFABINHDE.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6E73040", Offset = "0x6E72040", VA = "0x186E73040", Slot = "10")]
			public void OPFOFHIGBEE(LKBGBEKOGHP IFPBFCLBBDP, Transform DAJPJINHLIM, float PEGACPFCNHH, HJCFABINHDE NJOPLCGKLHH = HJCFABINHDE.Off)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6E720A0", Offset = "0x6E710A0", VA = "0x186E720A0")]
			private void GIFBNGIGNBB(LKBGBEKOGHP IFPBFCLBBDP, Transform DAJPJINHLIM, float PEGACPFCNHH, HJCFABINHDE NJOPLCGKLHH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6E70DE0", Offset = "0x6E6FDE0", VA = "0x186E70DE0", Slot = "6")]
			public void CAKBCGBONLK(LKBGBEKOGHP HBEEEGFHKCB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6E711A0", Offset = "0x6E701A0", VA = "0x186E711A0")]
			private void DPBJKBEEELA(LKBGBEKOGHP HBEEEGFHKCB)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6E71E60", Offset = "0x6E70E60", VA = "0x186E71E60")]
			private void GHBOLHJPIPH(LKBGBEKOGHP IFPBFCLBBDP, [Optional] float? PEGACPFCNHH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6E70D10", Offset = "0x6E6FD10", VA = "0x186E70D10", Slot = "11")]
			public bool ADAFLBKAJPO(LKBGBEKOGHP IFPBFCLBBDP)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6E70E40", Offset = "0x6E6FE40", VA = "0x186E70E40", Slot = "7")]
			public void CDOACKLAFKD(LKBGBEKOGHP IFPBFCLBBDP, HJCFABINHDE ODNOADLLLMJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6E71D90", Offset = "0x6E70D90", VA = "0x186E71D90")]
			private void FPJBCJGOMLE(LKBGBEKOGHP IFPBFCLBBDP, HJCFABINHDE ODNOADLLLMJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x6E72A90", Offset = "0x6E71A90", VA = "0x186E72A90")]
			public void NKAMKPOEEGA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6E731E0", Offset = "0x6E721E0", VA = "0x186E731E0")]
			public void PNGJFOLIKKP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x6E72610", Offset = "0x6E71610", VA = "0x186E72610")]
			private void KCODMGDOCPM(IOMMEHNMLMP JGODMBGCENL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x6E72940", Offset = "0x6E71940", VA = "0x186E72940")]
			private void KOBBPELHJNF(int IFLOCEBFOEM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6E715C0", Offset = "0x6E705C0", VA = "0x186E715C0", Slot = "4")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6E72CB0", Offset = "0x6E71CB0", VA = "0x186E72CB0")]
			private void OJPJPDEACKH(NELPJCLNPID PFHHLEBBHOG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x6E70F10", Offset = "0x6E6FF10", VA = "0x186E70F10")]
			private static void DIHGFEDMEPA(NELPJCLNPID PFHHLEBBHOG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x6E724A0", Offset = "0x6E714A0", VA = "0x186E724A0")]
			private void HBFMKKIEBCM(NELPJCLNPID PFHHLEBBHOG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x6E72570", Offset = "0x6E71570", VA = "0x186E72570")]
			private static void HNEGIBPFJNH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6E72510", Offset = "0x6E71510", VA = "0x186E72510")]
			private static void HHKMPCJDBIA(float MLPBAIIBHBN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x6E70DD0", Offset = "0x6E6FDD0", VA = "0x186E70DD0")]
			private void BHPLAOEDDGI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6E725D0", Offset = "0x6E715D0", VA = "0x186E725D0")]
			private void JJKALIJCCEI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x6E718F0", Offset = "0x6E708F0", VA = "0x186E718F0")]
			private void ELFGBKGOIDC(CullingGroupEvent LOLDPFLMJGL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x6E71C20", Offset = "0x6E70C20", VA = "0x186E71C20")]
			private void EOGOIMNBIEI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private const float OILEJFGAKHM = 2.5f;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private const float KFHLDNPGGCA = 5f;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private const float DJGIHOEFONG = 10f;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private const float OIAGNNMDJNM = 20f;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private const float LCOAHMHLPNC = 50f;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private const float BLHKPJDLGOO = 100f;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private const float NIFAHDFDNJI = 500f;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public const ushort DEFAULT_CULLING_GROUP_ID = 0;

		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly float[] DefaultDistanceBands;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly Dictionary<HKDBPEMGILK, MMDIBAAPAHO> MIMMJCDIKAJ;

		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private static IDisposable PLPAJNCBPJK;

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static IDisposable DEDABDNCCDC;

		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static GDBINPMHEFP JFGOIIMLGBP;

		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private static GDBINPMHEFP PNAMOLMLJEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private readonly GDBINPMHEFP JEHPMADMGNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly GDBINPMHEFP NCGDMEJDJPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly GDBINPMHEFP ILDMHONGFHF;

		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public static bool UseJobs;

		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static ProfilerMarker HBHCPNKLBKB;

		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static ProfilerMarker CFPFACNABDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private DDGDFMBPLHP EJLOOINIFPM;

		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private static bool BFKLCFNPCAG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public GDBINPMHEFP MDPIADCNNDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public GDBINPMHEFP BEKDOCANHGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x8B9E60", Offset = "0x8B8E60", VA = "0x1808B9E60", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public GDBINPMHEFP OJOAGIKLDMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x8BA030", Offset = "0x8B9030", VA = "0x1808BA030", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool AOFJBINLLDB
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xA24140", Offset = "0xA23140", VA = "0x180A24140", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool NMEKMCIJDBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA24150", Offset = "0xA23150", VA = "0x180A24150", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA23D90", Offset = "0xA22D90", VA = "0x180A23D90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F690", Offset = "0x6E6E690", VA = "0x186E6F690", Slot = "4")]
		protected override void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6E702A0", Offset = "0x6E6F2A0", VA = "0x186E702A0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6E70280", Offset = "0x6E6F280", VA = "0x186E70280")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6E6FA10", Offset = "0x6E6EA10", VA = "0x186E6FA10")]
		private void GDJJGIPFMKL(Scene NLEJIHGAKCB, LoadSceneMode CGGPIBJAEKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6E701A0", Offset = "0x6E6F1A0", VA = "0x186E701A0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6E704E0", Offset = "0x6E6F4E0", VA = "0x186E704E0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6E6FDE0", Offset = "0x6E6EDE0", VA = "0x186E6FDE0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F750", Offset = "0x6E6E750", VA = "0x186E6F750")]
		private void DEKGLEHEBNF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6E702C0", Offset = "0x6E6F2C0", VA = "0x186E702C0")]
		public void PauseUntilEndOfFrame()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6E70030", Offset = "0x6E6F030", VA = "0x186E70030")]
		private void NFJGAKNEJNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6E6FA70", Offset = "0x6E6EA70", VA = "0x186E6FA70")]
		public OICHLINLOOD GetOrCreateCullingGroup(Type FBINKPGJOPK, int LEJFLHBMJAF, ushort OACILKAOLFM = 0, bool BGIBIHOOENE = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2DB50B0", Offset = "0x2DB40B0", VA = "0x182DB50B0")]
		public JEAJJDEJHCP<T> GetOrCreateCullingGroup<T>(int LEJFLHBMJAF, ushort OACILKAOLFM = 0, bool BGIBIHOOENE = false) where T : class, LKBGBEKOGHP
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6E6FC50", Offset = "0x6E6EC50", VA = "0x186E6FC50")]
		private OICHLINLOOD KFHKFNKEBBG(Type FBINKPGJOPK, int LEJFLHBMJAF, float[] PDPDFPDGLCG, ushort OACILKAOLFM = 0, bool BGIBIHOOENE = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x2DB5170", Offset = "0x2DB4170", VA = "0x182DB5170")]
		private JEAJJDEJHCP<T> KFHKFNKEBBG<T>(int LEJFLHBMJAF, float[] PDPDFPDGLCG, ushort OACILKAOLFM = 0, bool BGIBIHOOENE = false) where T : class, LKBGBEKOGHP
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F8B0", Offset = "0x6E6E8B0", VA = "0x186E6F8B0")]
		public static DJFOEHMHKBO FindClosestDefaultUpdateLod(float HKHJANLEKLP)
		{
			return default(DJFOEHMHKBO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8E3180", Offset = "0x8E2180", VA = "0x1808E3180")]
		public static DJFOEHMHKBO MinUpdateLod(DJFOEHMHKBO DEOHNJIBPFH, DJFOEHMHKBO FDJCBHDJDNI)
		{
			return default(DJFOEHMHKBO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6E70020", Offset = "0x6E6F020", VA = "0x186E70020")]
		public static DJFOEHMHKBO MaxUpdateLod(DJFOEHMHKBO DEOHNJIBPFH, DJFOEHMHKBO FDJCBHDJDNI)
		{
			return default(DJFOEHMHKBO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6E708E0", Offset = "0x6E6F8E0", VA = "0x186E708E0")]
		public CullingGroupManager()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface PFEDGBLEGPB
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool EPHOBFBNIDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	Camera KHKHJEMBCOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	GDBINPMHEFP FICCEGNINCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	bool EOEKCHPGODO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	GDBINPMHEFP ENACCNEHPJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	Transform KNDDJHDMBLO
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface OICHLINLOOD
{
	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OPFOFHIGBEE(LKBGBEKOGHP IFPBFCLBBDP, float PEGACPFCNHH, HJCFABINHDE NJOPLCGKLHH = HJCFABINHDE.Off);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CAKBCGBONLK(LKBGBEKOGHP HBEEEGFHKCB);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CDOACKLAFKD(LKBGBEKOGHP IFPBFCLBBDP, HJCFABINHDE BOMAONNHJON);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface JEAJJDEJHCP<T> : OICHLINLOOD where T : class, LKBGBEKOGHP
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OPFOFHIGBEE(T IFPBFCLBBDP, float PEGACPFCNHH, HJCFABINHDE NJOPLCGKLHH = HJCFABINHDE.Off);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OPFOFHIGBEE(T IFPBFCLBBDP, Transform DAJPJINHLIM, float PEGACPFCNHH, HJCFABINHDE NJOPLCGKLHH = HJCFABINHDE.Off);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CAKBCGBONLK(T HBEEEGFHKCB);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool ADAFLBKAJPO(T IFPBFCLBBDP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface LKBGBEKOGHP
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	Transform IMCFIOFNLHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OnChangedDistanceBand(DJFOEHMHKBO OGCIJEGBFAE, DJFOEHMHKBO LEAOHHOLMLI);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OnChangedVisibility(bool IMEKHNJIOGP);
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
