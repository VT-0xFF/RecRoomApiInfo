using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.ClusterLODs;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal static class IBEKGLCMBMC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6258810", Offset = "0x6257C10", VA = "0x186258810")]
	public static Bounds KEHGPHOBCFD(List<FAHPALOMNPE> BFLLAIHCPKI)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6258660", Offset = "0x6257A60", VA = "0x186258660")]
	public static int IFGCLIBNOOE(List<FAHPALOMNPE> BFLLAIHCPKI, NJEJOLDCKKD HIBHFNPJOBC)
	{
		return default(int);
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class ClusterLODManagerEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x94E2B0", Offset = "0x94D6B0", VA = "0x18094E2B0")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct GHJJCJCOCJI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int DBHMCODDJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public int CBDFEPEIFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public int CHGKJJCLAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public int EMGDKLILPEK;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6257210", Offset = "0x6256610", VA = "0x186257210")]
	public GHJJCJCOCJI(int CBDFEPEIFFE, int CHGKJJCLAKF, int DBHMCODDJGJ, int EMGDKLILPEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class BJDALOJLBEB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public NativeList<float3> MHDMGNJLIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public NativeList<int> JEDPFIFADIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public NativeList<int> JIBBGPJFEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public NativeList<GHJJCJCOCJI> BHNBAHOBPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public NativeArray<int> JLMDEJHMFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public NativeArray<float3> GGGMPFBCAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public NativeArray<float> KNONOAHICPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public JobHandle HFEJEKMIDBM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool MJGBEGPLNIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x101CA70", Offset = "0x101BE70", VA = "0x18101CA70")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x101D010", Offset = "0x101C410", VA = "0x18101D010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x624D930", Offset = "0x624CD30", VA = "0x18624D930")]
	public void CEBPBFKDMNN(FALIJOGACGN KBDFELIHDKC, NativeList<GHJJCJCOCJI> BHNBAHOBPNK, float LECHMDFLPHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x624EB40", Offset = "0x624DF40", VA = "0x18624EB40")]
	public void KBNPKDPCBNK(Transform PFMMNJCIGCA, bool HNKFMDPIKCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x624E990", Offset = "0x624DD90", VA = "0x18624E990")]
	public void GANODHIAGIL(KNCJNCGPEHA DKHCFGEENMO, bool AFPENBAPNNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x624E880", Offset = "0x624DC80", VA = "0x18624E880", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x624E850", Offset = "0x624DC50", VA = "0x18624E850")]
	public void DDMMLHIFNLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public BJDALOJLBEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BurstCompile]
public struct OIHHILGGFOF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[ReadOnly]
	private NativeList<float3> MHDMGNJLIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[ReadOnly]
	public NativeList<int> JEDPFIFADIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[ReadOnly]
	private NativeList<GHJJCJCOCJI> BGLHFDPMKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[ReadOnly]
	private NativeArray<int> JLMDEJHMFHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	private float3 HJKNKPHHHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	private NativeArray<float3> GGGMPFBCAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	private NativeArray<float> KNONOAHICPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[ReadOnly]
	private bool HNKFMDPIKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	[ReadOnly]
	private float HOKMJPDFFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	private float GBGGMJMDPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	private float IHODJLDDIPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private NativeList<int> JIBBGPJFEIE;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x625E320", Offset = "0x625D720", VA = "0x18625E320")]
	public OIHHILGGFOF(BJDALOJLBEB FFPCMHGHCBE, Vector3 HJKNKPHHHPF, bool HNKFMDPIKCL, float HOKMJPDFFMJ, float GBGGMJMDPAH, float IHODJLDDIPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x625DE80", Offset = "0x625D280", VA = "0x18625DE80", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface NIMOJLEOAJI
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	NIMOJLEOAJI JFBAOHIJIKN(Action ENOAFIICPMH);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NIMOJLEOAJI JBAFAKHALLH(Action ENOAFIICPMH);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NIMOJLEOAJI MEJEPIJINID(Action ENOAFIICPMH);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NIMOJLEOAJI BCAMPGKKEJE(Action ENOAFIICPMH);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class DMCOJHDHBIG : NIMOJLEOAJI
		{
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			[CompilerGenerated]
			private sealed class CIGGJOIDEAA
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public DMCOJHDHBIG <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
				public CIGGJOIDEAA()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x624F460", Offset = "0x624E860", VA = "0x18624F460")]
				internal void LEIHCOFPJPJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x624F4F0", Offset = "0x624E8F0", VA = "0x18624F4F0")]
				internal void OECBGEAADJH()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x624F4B0", Offset = "0x624E8B0", VA = "0x18624F4B0")]
				internal void NNBNFJEHMKM()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private Func<JobHandle> JEOCLJFABAH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private Action AFPOPAPPAAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private Action NDCNJPBNJOG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private HDBLANHGAKK DAJHOOHLFIH;

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public Action BFFGOLLMIBE
			{
				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x7F8B00", Offset = "0x7F7F00", VA = "0x1807F8B00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x80EE50", Offset = "0x80E250", VA = "0x18080EE50")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Action MLICILBCMKA
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x7F1280", Offset = "0x7F0680", VA = "0x1807F1280")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0x89EC00", Offset = "0x89E000", VA = "0x18089EC00")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x2F9BFC0", Offset = "0x2F9B3C0", VA = "0x182F9BFC0", Slot = "4")]
			public NIMOJLEOAJI JFBAOHIJIKN(Action ENOAFIICPMH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2E4DEA0", Offset = "0x2E4D2A0", VA = "0x182E4DEA0", Slot = "5")]
			public NIMOJLEOAJI JBAFAKHALLH(Action ENOAFIICPMH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x32B6E70", Offset = "0x32B6270", VA = "0x1832B6E70", Slot = "6")]
			public NIMOJLEOAJI MEJEPIJINID(Action ENOAFIICPMH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x42D9A80", Offset = "0x42D8E80", VA = "0x1842D9A80", Slot = "7")]
			public NIMOJLEOAJI BCAMPGKKEJE(Action ENOAFIICPMH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x855900", Offset = "0x854D00", VA = "0x180855900")]
			public DMCOJHDHBIG(Func<JobHandle> GMFOONJLJCN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6250E60", Offset = "0x6250260", VA = "0x186250E60")]
			public void INDKPGEMFJE(Action LCFGBDLGBMO, Action EILDLJEHCCL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6250D10", Offset = "0x6250110", VA = "0x186250D10")]
			public void AJCNBIMBJPF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class EBFMGCCAHPO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public NIMOJLEOAJI jobHandle;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
			public EBFMGCCAHPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x62510C0", Offset = "0x62504C0", VA = "0x1862510C0")]
			internal bool EOFIDFMIBDP(DMCOJHDHBIG a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class IHBLJGEGDGF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public DMCOJHDHBIG newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
			public IHBLJGEGDGF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x62589E0", Offset = "0x6257DE0", VA = "0x1862589E0")]
			internal void OPPPMHOCGBB()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Queue<DMCOJHDHBIG> BCKCMGDBMFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private List<DMCOJHDHBIG> HFIPMMJPKMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private LMKHJNMJFLJ DDHMKIOOGOF;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public OOMJEPAMCDG BAJJKJJGNJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7F1280", Offset = "0x7F0680", VA = "0x1807F1280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x89EC00", Offset = "0x89E000", VA = "0x18089EC00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6258A40", Offset = "0x6257E40", VA = "0x186258A40")]
		public NIMOJLEOAJI Add(Func<JobHandle> GMFOONJLJCN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6258D40", Offset = "0x6258140", VA = "0x186258D40")]
		public void Remove(NIMOJLEOAJI HFEJEKMIDBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6258BA0", Offset = "0x6257FA0", VA = "0x186258BA0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6258F10", Offset = "0x6258310", VA = "0x186258F10")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6259160", Offset = "0x6258560", VA = "0x186259160")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6258B90", Offset = "0x6257F90", VA = "0x186258B90")]
		[CompilerGenerated]
		private void JCKONBHDHLO()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class KNCJNCGPEHA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class KKJJKBKBDAD : IDisposable, LCBFIFLMKEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public Bounds OFDGOIDMBAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public List<FAHPALOMNPE> BFLLAIHCPKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Vector3 PLEMBNFGPEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Vector3 KKNJCIGFBAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public int FBMCNIOHDCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public FALIJOGACGN DPKJMJOFGGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public EOKCLKAPLFN IHMBDKJGOKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public Transform PFMMNJCIGCA;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int FKLONJJCPGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x625A250", Offset = "0x6259650", VA = "0x18625A250")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Mesh CPIKBNGFNBL
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x7F1280", Offset = "0x7F0680", VA = "0x1807F1280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x89EC00", Offset = "0x89E000", VA = "0x18089EC00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Mesh LEDFDDIENCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x7F83B0", Offset = "0x7F77B0", VA = "0x1807F83B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x85D510", Offset = "0x85C910", VA = "0x18085D510")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public float PBLDPAFEFAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x1D926D0", Offset = "0x1D91AD0", VA = "0x181D926D0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x12A0330", Offset = "0x129F730", VA = "0x1812A0330")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public byte EMIKLANHLAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xF30160", Offset = "0xF2F560", VA = "0x180F30160")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xF30180", Offset = "0xF2F580", VA = "0x180F30180", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int CMBIFHJFNAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xC54120", Offset = "0xC53520", VA = "0x180C54120", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xC53EB0", Offset = "0xC532B0", VA = "0x180C53EB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int NDGKNDMMPEJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xC53E80", Offset = "0xC53280", VA = "0x180C53E80", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x874FF0", Offset = "0x8743F0", VA = "0x180874FF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public float MLFEHMIEOPJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x625A230", Offset = "0x6259630", VA = "0x18625A230", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6259910", Offset = "0x6258D10", VA = "0x186259910")]
		public void DDHGGPPIJIP(NJEJOLDCKKD HIBHFNPJOBC, out int EMGDKLILPEK, out int CHGKJJCLAKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x625A080", Offset = "0x6259480", VA = "0x18625A080")]
		public void FCAGOIHDMAA(NJEJOLDCKKD HIBHFNPJOBC, BOKAALLHIPE GPMLGGKAOBP, int FJLFDFHGBBD = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6259D40", Offset = "0x6259140", VA = "0x186259D40")]
		public void ENHMFOPPAEP(NativeList<MAMEDLNPJNI> DNHJLPNKFLE, Transform IOLANPMBGGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x62597D0", Offset = "0x6258BD0", VA = "0x1862597D0")]
		public void AKEHDIFHFOL(Mesh CKHGFHPLIDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6259870", Offset = "0x6258C70", VA = "0x186259870")]
		public void BFICNJJHAPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6259B40", Offset = "0x6258F40", VA = "0x186259B40", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x625A290", Offset = "0x6259690", VA = "0x18625A290")]
		public KKJJKBKBDAD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public Bounds OFDGOIDMBAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<KKJJKBKBDAD> JEIKHHIPBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public BJDALOJLBEB BEEBINCANMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public ClusterMeshRenderer DKHCFGEENMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int BOLPNLBIDKN;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Mesh KDGAOLNBAKE
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7F8B00", Offset = "0x7F7F00", VA = "0x1807F8B00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x80EE50", Offset = "0x80E250", VA = "0x18080EE50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool HEEDDIMEPOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x854A40", Offset = "0x853E40", VA = "0x180854A40")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x877EF0", Offset = "0x8772F0", VA = "0x180877EF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int GPBCMDIPBFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x625B790", Offset = "0x625AB90", VA = "0x18625B790")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x625BF70", Offset = "0x625B370", VA = "0x18625BF70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x625C0D0", Offset = "0x625B4D0", VA = "0x18625C0D0")]
	public int ENELJGAADDC(int MFEKINLHBKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x625C2C0", Offset = "0x625B6C0", VA = "0x18625C2C0")]
	public void OLCLIJPDEPE(OIJOEPPOEOM KCKOCINJBKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x625B7E0", Offset = "0x625ABE0", VA = "0x18625B7E0")]
	public void COLBLDBMIAH(Transform IOLANPMBGGL, bool HNKFMDPIKCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x625C100", Offset = "0x625B500", VA = "0x18625C100")]
	public bool GANODHIAGIL(bool AFPENBAPNNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x625B0A0", Offset = "0x625A4A0", VA = "0x18625B0A0")]
	public void BJAAEACKHNK(Transform PFMMNJCIGCA, bool HNKFMDPIKCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x625ADF0", Offset = "0x625A1F0", VA = "0x18625ADF0")]
	public bool AJCNBIMBJPF(FAHPALOMNPE COGHLJDPMKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x625C480", Offset = "0x625B880", VA = "0x18625C480")]
	public KNCJNCGPEHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class KMPNMKLBHGP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Queue<KNCJNCGPEHA.KKJJKBKBDAD> HPOHNFLGHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private MEOEGENPLCE ONMNADBKAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<KNCJNCGPEHA.KKJJKBKBDAD> GJBBPCDMFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private int AFMDNHAABFI;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x625A720", Offset = "0x6259B20", VA = "0x18625A720", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x625A6A0", Offset = "0x6259AA0", VA = "0x18625A6A0")]
	public void DDMMLHIFNLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x625AB50", Offset = "0x6259F50", VA = "0x18625AB50")]
	public void MGOOIKEIGMG(KNCJNCGPEHA.KKJJKBKBDAD KNBOBLJHMKM, Transform PFMMNJCIGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x625A370", Offset = "0x6259770", VA = "0x18625A370")]
	public void AJCNBIMBJPF(KNCJNCGPEHA.KKJJKBKBDAD KNBOBLJHMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x625A560", Offset = "0x6259960", VA = "0x18625A560")]
	private KNCJNCGPEHA.KKJJKBKBDAD APAGHOCBANP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x625A7F0", Offset = "0x6259BF0", VA = "0x18625A7F0")]
	private bool KPCNOMEJDCP(KNCJNCGPEHA.KKJJKBKBDAD KNBOBLJHMKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x625AC10", Offset = "0x625A010", VA = "0x18625AC10")]
	private void PFAGDHBBPBF(KNCJNCGPEHA.KKJJKBKBDAD KNBOBLJHMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x625A890", Offset = "0x6259C90", VA = "0x18625A890")]
	public bool LHNNIFMAMLL(KNCJNCGPEHA.KKJJKBKBDAD KNBOBLJHMKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x625A8C0", Offset = "0x6259CC0", VA = "0x18625A8C0")]
	public bool LNCNPCEKGKH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x625A790", Offset = "0x6259B90", VA = "0x18625A790")]
	private KNCJNCGPEHA.KKJJKBKBDAD IHPBCKJOBDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x625AC70", Offset = "0x625A070", VA = "0x18625AC70")]
	public KMPNMKLBHGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class EOKCLKAPLFN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static NativeMultiHashMap<int, int> LAFGHDNMODG;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static NativeArray<int> EPNFKKPDLDJ;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static int EFNGIJONAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<int> JEDPFIFADIK;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6252040", Offset = "0x6251440", VA = "0x186252040")]
	public void CENANMIAGAJ(int AMMKFOGBIHF, Allocator NAFCEIMFOBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6252240", Offset = "0x6251640", VA = "0x186252240", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public EOKCLKAPLFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[BurstCompile]
public struct HODPFIDPEON : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[ReadOnly]
	public NativeList<int> OEBMLCFIIJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeList<int> OINGHPNBEAF;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6258630", Offset = "0x6257A30", VA = "0x186258630")]
	public HODPFIDPEON(EOKCLKAPLFN BDBMJKHFCMH, FALIJOGACGN CKHGFHPLIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6258580", Offset = "0x6257980", VA = "0x186258580", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct BDLHPLFDKNM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	[ReadOnly]
	private NativeList<float3> OJKCOBFOCAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	[ReadOnly]
	private NativeArray<float3> BPCHGGHAEPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	private NativeArray<float4> APMIJHAFHPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	private NativeArray<float2> GOMGOGOONLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[ReadOnly]
	private NativeArray<float4> NEHDHBBNGBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private NativeList<int> JEDPFIFADIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private NativeList<int> OEBMLCFIIJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private NativeList<float3> PHFCPIGLDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private NativeArray<float3> CPJFLAPFMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private NativeArray<float4> OJFNHOFBMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private NativeArray<float4> FGFOFAFPOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private NativeArray<float2> AFFANIBOGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private NativeList<int> OHHMBFHLCID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[ReadOnly]
	private float CHFJJIPACMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[ReadOnly]
	public float HFPGBFPCFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[ReadOnly]
	private float3 HJKNKPHHHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[ReadOnly]
	private float FIHJLBKHNLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[ReadOnly]
	private float DIDCBCONCBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[ReadOnly]
	public float NCEKMHDDCCP;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x624D7F0", Offset = "0x624CBF0", VA = "0x18624D7F0")]
	public BDLHPLFDKNM(EOKCLKAPLFN DGHMKPALJJN, FALIJOGACGN CKHGFHPLIDD, FALIJOGACGN PIGHAINCOAL, float DIDCBCONCBP, float NCEKMHDDCCP, Vector3 HJKNKPHHHPF, float FIHJLBKHNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x624D390", Offset = "0x624C790", VA = "0x18624D390")]
	private float3 NBPJDOJAIMA(int GGGLLOBDBOL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x624D1B0", Offset = "0x624C5B0", VA = "0x18624D1B0")]
	private void MLGDMHBGJDA(int GGGLLOBDBOL, out float3 GFAKCCFLHLN, out float3 ADCPAEFHELL, out float4 CLGNMEKGGEB, out float4 AKEDIHPGCAB, out float2 HHDGLIHKFFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x624D440", Offset = "0x624C840", VA = "0x18624D440")]
	private int ONJFODACAAJ(int JKBMLCMMJKM, int HOAGCAGEDKJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x624C2A0", Offset = "0x624B6A0", VA = "0x18624C2A0")]
	private void EAEPNLOMEPM(int JKBMLCMMJKM, int HOAGCAGEDKJ, int MMOGNKPJCHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x624CDB0", Offset = "0x624C1B0", VA = "0x18624CDB0")]
	private bool FECHNGFOGGD(int JKBMLCMMJKM, int HOAGCAGEDKJ, float LNKFCFLBFCI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x624D730", Offset = "0x624CB30", VA = "0x18624D730")]
	private bool PGEAFDNIFMJ(int JKBMLCMMJKM, int HOAGCAGEDKJ, int MMOGNKPJCHA, float LNKFCFLBFCI, bool KAIHLGLDFGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x624CF40", Offset = "0x624C340", VA = "0x18624CF40")]
	private bool IELKFHILFCO(int JKBMLCMMJKM, int HOAGCAGEDKJ, int MMOGNKPJCHA, float LNKFCFLBFCI, bool KAIHLGLDFGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x624C4B0", Offset = "0x624B8B0", VA = "0x18624C4B0")]
	private void EIMFEAHJOCE(int JKBMLCMMJKM, int HOAGCAGEDKJ, int MMOGNKPJCHA, out int DLCIMEGPBJM, out int NMNGNGMCEEE, out int OCMLMALMIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x624C4D0", Offset = "0x624B8D0", VA = "0x18624C4D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class MENPMNPFAJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private int ACIPMKNINBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private int OGKOFECPAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private float CPHOOMDOHKB;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public List<KNCJNCGPEHA> PNBJCLBIEPC
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x855AE0", Offset = "0x854EE0", VA = "0x180855AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x855AF0", Offset = "0x854EF0", VA = "0x180855AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x625CC30", Offset = "0x625C030", VA = "0x18625CC30")]
	public MENPMNPFAJF(int ACIPMKNINBH, int OGKOFECPAAG, float EPPLJGLAHJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x625C8C0", Offset = "0x625BCC0", VA = "0x18625C8C0")]
	public void DABEJHFKAFE(LAHACMNIGNC DEDNNAKMBNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x625CB80", Offset = "0x625BF80", VA = "0x18625CB80")]
	private int ONBLNOLFKBF(OIJOEPPOEOM CGDIPNGPFNP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x625C670", Offset = "0x625BA70", VA = "0x18625C670")]
	private void DABEJHFKAFE(OIJOEPPOEOM CGDIPNGPFNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x625C970", Offset = "0x625BD70", VA = "0x18625C970")]
	private void DJNHLGJKEDE(OIJOEPPOEOM CGDIPNGPFNP, KNCJNCGPEHA BGBAFPKGFHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface HMGAHIOPHGN
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	EPLDMMCPBGP LCLFKAIJIMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum MEMNFNIPGPN
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	Detail,
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	NumLayers
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface GJGJIAJAIJK
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ENPDCOANMDD();
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface LCBJDDDAIIH
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int GPBCMDIPBFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	IEnumerable<LCBFIFLMKEC> CHCLLMJIMOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	MEMNFNIPGPN NOCGCGFHKIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool UpdateVisibility();

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void UpdateClusterDistances(Vector3 GBCJGHOCJAP);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(FAHPALOMNPE COGHLJDPMKN);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface LCBFIFLMKEC
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int CMBIFHJFNAE
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int NDGKNDMMPEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float PBLDPAFEFAN
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float MLFEHMIEOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	byte EMIKLANHLAA
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class EPLDMMCPBGP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public enum MBIAKCBFPAB
	{
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		Invalid = -1,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		Waiting,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		Collecting,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		Generating,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		Running
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	[CompilerGenerated]
	private sealed class BNBKINDPHGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public MJNNFHEKAHC stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public EPLDMMCPBGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private CancellationTokenSource <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private MJNNFHEKAHC <createWorldTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public BNBKINDPHGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x624EE00", Offset = "0x624E200", VA = "0x18624EE00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class FOCBOIAKCOD : IEnumerator<IPNFOPMMOKI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private IPNFOPMMOKI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public EPLDMMCPBGP <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private IPNFOPMMOKI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x85A1C0", Offset = "0x8595C0", VA = "0x18085A1C0")]
		[DebuggerHidden]
		public FOCBOIAKCOD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x6257120", Offset = "0x6256520", VA = "0x186257120", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x62571D0", Offset = "0x62565D0", VA = "0x1862571D0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class HDABHFBNPGA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public MJNNFHEKAHC worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public EPLDMMCPBGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private MJNNFHEKAHC <waitForShapesTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private MJNNFHEKAHC <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private List<GJGJIAJAIJK>.Enumerator <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private GJGJIAJAIJK <sc>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private MJNNFHEKAHC <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private MJNNFHEKAHC <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private List<FAHPALOMNPE>.Enumerator <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private FAHPALOMNPE <c>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private MJNNFHEKAHC <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private MJNNFHEKAHC <>s__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private MJNNFHEKAHC <>s__11;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		private Exception <ex>5__12;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		private YieldAwaitable.YieldAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public HDABHFBNPGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6257230", Offset = "0x6256630", VA = "0x186257230", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class EDANOLIGEJC : IEnumerator<IPNFOPMMOKI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private IPNFOPMMOKI <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public EPLDMMCPBGP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private int <numVerts>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private List<LCBFIFLMKEC>.Enumerator <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private LCBFIFLMKEC <c>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private int <numVertsToSpare>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private int <index>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private List<LCBFIFLMKEC> <clusters>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private int <numVertsToSpare>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private int <index>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private List<LCBFIFLMKEC> <clusters>5__10;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private IPNFOPMMOKI System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x85A1C0", Offset = "0x8595C0", VA = "0x18085A1C0")]
		[DebuggerHidden]
		public EDANOLIGEJC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x62510D0", Offset = "0x62504D0", VA = "0x1862510D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6252000", Offset = "0x6251400", VA = "0x186252000", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public const int MBADLKOEDNO = 3;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly TimeSpan LHENMIGLACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public ClusterMeshRenderer IPFPHKLBLJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public MeshFilter IGBNONNKPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private GameObject BLDMNIELDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private GameObject JDNFFACEKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public KMPNMKLBHGP MNKNGMKIOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private List<FAHPALOMNPE> CGBEJFJAJBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private List<FAHPALOMNPE> GKAINPMFBIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private List<FAHPALOMNPE> DENLJAAGBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private int CIHBCLOHILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private MBIAKCBFPAB GCFDCCKGIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public List<LCBJDDDAIIH>[] FOMPKCKJCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private List<LCBFIFLMKEC>[] MKIBKJFNCPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private CancellationTokenSource ANHOAPEOJBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private bool LKHDNOOBLLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private LMKHJNMJFLJ BMEFLGAOPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private LMKHJNMJFLJ GJJCNIPIDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public int DGKNBCDHJCF;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static EPLDMMCPBGP NMNJGEDLDPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly PIHCHHJMFBA EOALOIBMHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly LGELPOEOAGM PANJIFOKBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly MonoBehaviour HCLNBLOLCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly Material BLCHJEHLPML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly List<GJGJIAJAIJK> CMBADJHFPEI;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ClusterLODConfig JCCAABFGAGA
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x856480", Offset = "0x855880", VA = "0x180856480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x87D040", Offset = "0x87C440", VA = "0x18087D040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Vector3 NIGHBIPBEBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x18758E0", Offset = "0x1874CE0", VA = "0x1818758E0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x18757F0", Offset = "0x1874BF0", VA = "0x1818757F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private MBIAKCBFPAB CHODJLPDJMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0xAC79E0", Offset = "0xAC6DE0", VA = "0x180AC79E0")]
		get
		{
			return default(MBIAKCBFPAB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6254610", Offset = "0x6253A10", VA = "0x186254610")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static EPLDMMCPBGP BGHJOACDLLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6254B10", Offset = "0x6253F10", VA = "0x186254B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static bool JNCLGJGPKIP
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x62542F0", Offset = "0x62536F0", VA = "0x1862542F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static bool ODDLEHNLGCB
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6253260", Offset = "0x6252660", VA = "0x186253260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> IDLPJOHHMNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x62539C0", Offset = "0x6252DC0", VA = "0x1862539C0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x62548D0", Offset = "0x6253CD0", VA = "0x1862548D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action ICEPBFOJLGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6254B70", Offset = "0x6253F70", VA = "0x186254B70")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6253840", Offset = "0x6252C40", VA = "0x186253840")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6254C80", Offset = "0x6254080", VA = "0x186254C80")]
	public EPLDMMCPBGP(PIHCHHJMFBA EOALOIBMHFD, LGELPOEOAGM PANJIFOKBEI, ClusterLODConfig OPOMEMOAKCC, MonoBehaviour HCLNBLOLCLO, Material BLCHJEHLPML, ClusterMeshRenderer IPFPHKLBLJA, MeshFilter IGBNONNKPPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6253610", Offset = "0x6252A10", VA = "0x186253610", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6253710", Offset = "0x6252B10", VA = "0x186253710")]
	public static void EJEGGOOKOAH(Vector3 GBLIIAIHNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6252A00", Offset = "0x6251E00", VA = "0x186252A00")]
	private void ADIGEHBFNAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x62533A0", Offset = "0x62527A0", VA = "0x1862533A0")]
	private void DHNLOCHECMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6254780", Offset = "0x6253B80", VA = "0x186254780")]
	private void LAJDENFDKGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6253A60", Offset = "0x6252E60", VA = "0x186253A60")]
	public void HPPOODGMBNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x62534A0", Offset = "0x62528A0", VA = "0x1862534A0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(BNBKINDPHGA))]
	public Task DOFOEEOKHLG(MJNNFHEKAHC BGDDJJCKMIA, CancellationToken JHFLJLAPDKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x62538E0", Offset = "0x6252CE0", VA = "0x1862538E0")]
	[IteratorStateMachine(typeof(FOCBOIAKCOD))]
	private IEnumerator<IPNFOPMMOKI> ELJAAHKHJNC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6253FC0", Offset = "0x62533C0", VA = "0x186253FC0")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(HDABHFBNPGA))]
	private Task IEJGJIEDHLG(MJNNFHEKAHC DDACGDLDEJC, CancellationToken EMJFDFLJKFG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6254410", Offset = "0x6253810", VA = "0x186254410")]
	public void JENDMBFKMPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6254970", Offset = "0x6253D70", VA = "0x186254970")]
	public void MFFMGDFGAIC(IEnumerable<LCBJDDDAIIH> ONLGIMAPKIG, MEMNFNIPGPN LOOKJAGKAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6252E00", Offset = "0x6252200", VA = "0x186252E00")]
	public void AOINOOFNBNB(IEnumerable<LCBJDDDAIIH> ONLGIMAPKIG, MEMNFNIPGPN LOOKJAGKAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6252350", Offset = "0x6251750", VA = "0x186252350")]
	public List<ClusterMeshRenderer> ADGOBCJHPLK(List<FAHPALOMNPE> BFLLAIHCPKI, IKNPDLBNFFO PFMMNJCIGCA, MEMNFNIPGPN LOOKJAGKAIG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6254740", Offset = "0x6253B40", VA = "0x186254740")]
	public MEMNFNIPGPN KEONCNFOMJG(Vector3 LIEGJFLJFDB)
	{
		return default(MEMNFNIPGPN);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6253340", Offset = "0x6252740", VA = "0x186253340")]
	public void DBMAJALAEFF(GJGJIAJAIJK KCDMJOHMHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x62549F0", Offset = "0x6253DF0", VA = "0x1862549F0")]
	public bool NIAGNIJGICB(GJGJIAJAIJK KCDMJOHMHPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6254290", Offset = "0x6253690", VA = "0x186254290")]
	public void JBAAEOMCBGA(FAHPALOMNPE OGGMKJHCFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6253080", Offset = "0x6252480", VA = "0x186253080")]
	public void BBCBDKHPPMD(LCBFIFLMKEC MJMBCEAEAHG, MEMNFNIPGPN LOOKJAGKAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6254A90", Offset = "0x6253E90", VA = "0x186254A90")]
	public void OCDKLBHGCNI(LCBFIFLMKEC MJMBCEAEAHG, MEMNFNIPGPN LOOKJAGKAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6253100", Offset = "0x6252500", VA = "0x186253100")]
	private void BGCJFOPDCJN(Vector3 GBCJGHOCJAP, MEMNFNIPGPN LOOKJAGKAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6254130", Offset = "0x6253530", VA = "0x186254130")]
	private void IKAICKGALEB(Vector3 GBCJGHOCJAP, MEMNFNIPGPN LOOKJAGKAIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6253950", Offset = "0x6252D50", VA = "0x186253950")]
	[IteratorStateMachine(typeof(EDANOLIGEJC))]
	private IEnumerator<IPNFOPMMOKI> GEHBADFIOJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6252C70", Offset = "0x6252070", VA = "0x186252C70")]
	private int AMKKGNFJOPO(int CJOLACIBAJH, int PAGDOCAGNOI, List<LCBFIFLMKEC> IOHGPODBDND, byte HIBHFNPJOBC, ref int KINIKBHJMNN, float OCAMLHJMKFA = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6252A90", Offset = "0x6251E90", VA = "0x186252A90")]
	public void AJCNBIMBJPF(FAHPALOMNPE COGHLJDPMKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6254A50", Offset = "0x6253E50", VA = "0x186254A50")]
	public bool NPGKBMNNDAN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0xF9D9C0", Offset = "0xF9CDC0", VA = "0x180F9D9C0")]
	public Material OEBDJAMDLDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6252310", Offset = "0x6251710", VA = "0x186252310")]
	public int AAJICOBCLJO()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class FIKPJJBKMKA
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private struct OOGJFMFKMBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public int DMNNCKLHEIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public int JJCADIDIKJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int OHDCAMLNGCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int KONFAGIIBGJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct FDAKGEOODLL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public int FPDHMAHJNKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public float ECMOOGLCJHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public List<FAHPALOMNPE> BFLLAIHCPKI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private enum DNIIFCANHEP
	{
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		X_AXIS,
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		Y_AXIS,
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		Z_AXIS
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private OOGJFMFKMBJ JFICNMEPICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int LOFDCFLIIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private int ACIPMKNINBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private int OGKOFECPAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private float EPPLJGLAHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private float LIIMCBFPFMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private Stack<OIJOEPPOEOM> JJFCHFJNLOD;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public LAHACMNIGNC FEBIMPNJMEC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x855AE0", Offset = "0x854EE0", VA = "0x180855AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x855AF0", Offset = "0x854EF0", VA = "0x180855AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x62570C0", Offset = "0x62564C0", VA = "0x1862570C0")]
	public FIKPJJBKMKA(int ACIPMKNINBH, int OGKOFECPAAG, float EPPLJGLAHJL, int LOFDCFLIIEL, float LIIMCBFPFMH = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6256EC0", Offset = "0x62562C0", VA = "0x186256EC0")]
	public void LEJJFHNNOKH(List<FAHPALOMNPE> BFLLAIHCPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x62553F0", Offset = "0x62547F0", VA = "0x1862553F0")]
	public bool APGJKKLFPNB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x6255D50", Offset = "0x6255150", VA = "0x186255D50")]
	private float GIDDMHMLAGH(Vector3 FIIBEGPHODD, Vector3 JBKJLHMLOKF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6255DD0", Offset = "0x62551D0", VA = "0x186255DD0")]
	private float GIDDMHMLAGH(Vector3 ABBKELIMEIN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6255460", Offset = "0x6254860", VA = "0x186255460")]
	private bool FLLFEPOLMJK(OIJOEPPOEOM KNBOBLJHMKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6256280", Offset = "0x6255680", VA = "0x186256280")]
	private FDAKGEOODLL HGIONOGAPJE(List<FAHPALOMNPE> MOIKHNOCGAH, DNIIFCANHEP PPFAPJKOLCH)
	{
		return default(FDAKGEOODLL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6255E20", Offset = "0x6255220", VA = "0x186255E20")]
	private void GJBJLPGFJAN(List<FAHPALOMNPE> BFLLAIHCPKI, Vector3[] JAOBKOJFHBB, Vector3[] LKCHLGIEILI)
	{
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class ClusterLODConfig : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public class LODSettings
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public float maxRadiusOfCluster;

			[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public int minNumVertsInCluster;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public int maxNumVertsInCluster;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public float useLowestDetailAtSmallerRadius;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public float useHighestDetailAtGreaterRadius;

			[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public float maxVertSnapDist;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public float vertexNormalCombineThresh;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public float maxSubDivideEdgeSize;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public float maxSubDivideDistance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public bool cullEncapsulated;

			[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public bool useMaterials;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public bool ShouldSubDivide
			{
				[Cpp2IlInjected.Token(Token = "0x60000D2")]
				[Cpp2IlInjected.Address(RVA = "0x625C650", Offset = "0x625BA50", VA = "0x18625C650")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x60000D3")]
				[Cpp2IlInjected.Address(RVA = "0x1DAA500", Offset = "0x1DA9900", VA = "0x181DAA500")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x625C600", Offset = "0x625BA00", VA = "0x18625C600")]
			public LODSettings()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		[Header("Layer Settings")]
		public float maxRadiusForDetailObjects;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int maxWorldLODVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public int maxWorldNearVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		public int maxDetailNearVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public int maxDetailFarVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public int maxDynamicNearVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public int maxDynamicFarVerts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[Header("Creation Settings")]
		public int minNumObjectPerCluster;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public float distributeVSminimize;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[Header("Near Settings")]
		public LODSettings near;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[Header("Far Settings")]
		public LODSettings far;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public float backfaceCullingThreshold;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public float triangleCullingDistFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public float LOD0VertCacheFrac;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x624F650", Offset = "0x624EA50", VA = "0x18624F650")]
		public LODSettings DHGIFBCINIK(NJEJOLDCKKD HIBHFNPJOBC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x624F540", Offset = "0x624E940", VA = "0x18624F540")]
		public int AAJICOBCLJO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x624F560", Offset = "0x624E960", VA = "0x18624F560")]
		public int CAOBNBJGBHL(bool AMKABLKHGCA, Vector3 NOALHCNNKID)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x624F660", Offset = "0x624EA60", VA = "0x18624F660")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface FAHPALOMNPE : GFLHKNNDKJG
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	Bounds LPGIGHJLEDA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	MAMEDLNPJNI APCJLLDDPDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class OIJOEPPOEOM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public List<FAHPALOMNPE> BFLLAIHCPKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public OIJOEPPOEOM MOHMMJFCOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public OIJOEPPOEOM MPABCDDADCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public OIJOEPPOEOM NNOGOJOOCHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public int EMGDKLILPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public Bounds OFDGOIDMBAJ;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x625E3F0", Offset = "0x625D7F0", VA = "0x18625E3F0")]
	public OIJOEPPOEOM(List<FAHPALOMNPE> BFLLAIHCPKI, [Optional] OIJOEPPOEOM MOHMMJFCOKF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class LAHACMNIGNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public List<OIJOEPPOEOM> LJNBICLOKOC;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public OIJOEPPOEOM GILDPEKDHCO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x856480", Offset = "0x855880", VA = "0x180856480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x87D040", Offset = "0x87C440", VA = "0x18087D040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x625C530", Offset = "0x625B930", VA = "0x18625C530")]
	public LAHACMNIGNC(OIJOEPPOEOM PFMMNJCIGCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class MEOEGENPLCE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private FALIJOGACGN BLBLEFIODNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private FALIJOGACGN GMHIOABHICI;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static FALIJOGACGN KBNFBLHGIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private ANGJFOBMPAI HMAGGEBAOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private BOKAALLHIPE GPMLGGKAOBP;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public JobHandle HFEJEKMIDBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x89ED30", Offset = "0x89E130", VA = "0x18089ED30")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x89ECD0", Offset = "0x89E0D0", VA = "0x18089ECD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public KNCJNCGPEHA.KKJJKBKBDAD KNBOBLJHMKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x855AE0", Offset = "0x854EE0", VA = "0x180855AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x855AF0", Offset = "0x854EF0", VA = "0x180855AF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool DCOAKGMKGNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x900830", Offset = "0x8FFC30", VA = "0x180900830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x625DCE0", Offset = "0x625D0E0", VA = "0x18625DCE0")]
	[KINJKIDOEMP(CHIFGBMHODC.ExitingPlayMode, 0)]
	private static void IEEFGHGAGKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x625D360", Offset = "0x625C760", VA = "0x18625D360")]
	public void CEBPBFKDMNN(KNCJNCGPEHA.KKJJKBKBDAD BGLHFDPMKGM, Transform KKLALCNEJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x625CC80", Offset = "0x625C080", VA = "0x18625CC80")]
	public void BMODCCDCBGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x625DC70", Offset = "0x625D070", VA = "0x18625DC70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x625DC30", Offset = "0x625D030", VA = "0x18625DC30")]
	public void DDMMLHIFNLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x625DD50", Offset = "0x625D150", VA = "0x18625DD50")]
	public MEOEGENPLCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
public struct PHPPCALCNOA : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private NativeList<float3> MHDMGNJLIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private NativeArray<float3> AIKIJDHIMMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private NativeArray<float4> BEGEDNHMJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NativeArray<float2> GEOIKBLJBHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private NativeArray<float4> KDPGGDKOPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private NativeList<int> JIBBGPJFEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	[ReadOnly]
	private NativeList<float3> KGOGHLFLDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	[ReadOnly]
	private float3 ELPHAFMGNKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[ReadOnly]
	private float AGPOPKMLAEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private NativeMultiHashMap<int, int> LAFGHDNMODG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private NativeArray<int> EPNFKKPDLDJ;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x625EB60", Offset = "0x625DF60", VA = "0x18625EB60")]
	public PHPPCALCNOA(FALIJOGACGN CKHGFHPLIDD, NativeList<float3> KGOGHLFLDEA, NativeMultiHashMap<int, int> LAFGHDNMODG, NativeArray<int> EPNFKKPDLDJ, Vector3 ELPHAFMGNKF, float AGPOPKMLAEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x625E470", Offset = "0x625D870", VA = "0x18625E470")]
	private int DOPFPPPAMMN(float3 GBCJGHOCJAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x625E900", Offset = "0x625DD00", VA = "0x18625E900")]
	private int GCAPHHIAIFK(int GGGLLOBDBOL, int LOLIOKKJLEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x625E4A0", Offset = "0x625D8A0", VA = "0x18625E4A0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface PIHCHHJMFBA
{
	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(MJNNFHEKAHC DDACGDLDEJC, CancellationToken EMJFDFLJKFG);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface HDBLANHGAKK
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HDBLANHGAKK JFBAOHIJIKN(Action ENOAFIICPMH);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HDBLANHGAKK FANAFOMFKPH(Action ENOAFIICPMH);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HDBLANHGAKK BCAMPGKKEJE(Action ENOAFIICPMH);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private class MPLIKACFNKK : HDBLANHGAKK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private JobHandle KGLDKDAOMMJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			private Action AFPOPAPPAAO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			private Action GGPACKEEHFH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			private Action MLICILBCMKA;

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public bool ECCICFEDGAO
			{
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x625DE70", Offset = "0x625D270", VA = "0x18625DE70")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x2E4DEA0", Offset = "0x2E4D2A0", VA = "0x182E4DEA0", Slot = "4")]
			public HDBLANHGAKK JFBAOHIJIKN(Action ENOAFIICPMH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x32B6E70", Offset = "0x32B6270", VA = "0x1832B6E70", Slot = "5")]
			public HDBLANHGAKK FANAFOMFKPH(Action ENOAFIICPMH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x42D9A80", Offset = "0x42D8E80", VA = "0x1842D9A80", Slot = "6")]
			public HDBLANHGAKK BCAMPGKKEJE(Action ENOAFIICPMH)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x83A2A0", Offset = "0x8396A0", VA = "0x18083A2A0")]
			public MPLIKACFNKK(JobHandle MNNHJBHPKKM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x625DE30", Offset = "0x625D230", VA = "0x18625DE30")]
			public void FABBDADBDAM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x625DDF0", Offset = "0x625D1F0", VA = "0x18625DDF0")]
			public void AJCNBIMBJPF()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private List<MPLIKACFNKK> PNABKHOJOFA;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6259620", Offset = "0x6258A20", VA = "0x186259620")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x6259240", Offset = "0x6258640", VA = "0x186259240")]
		public HDBLANHGAKK Add(JobHandle MNNHJBHPKKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x6259530", Offset = "0x6258930", VA = "0x186259530")]
		public void Remove(HDBLANHGAKK HFEJEKMIDBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x62593C0", Offset = "0x62587C0", VA = "0x1862593C0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x62592D0", Offset = "0x62586D0", VA = "0x1862592D0")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6259740", Offset = "0x6258B40", VA = "0x186259740")]
		public JobTracker()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface LGELPOEOAGM
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	Vector3 ELOOEPEGNKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class ClusterMeshAssetEditorDebug : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x94E2B0", Offset = "0x94D6B0", VA = "0x18094E2B0")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class ClusterMeshRenderer : MonoBehaviour, LCBJDDDAIIH
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class DJFCFODJNMC : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			private Renderer <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public ClusterMeshRenderer <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			private int <i>5__1;

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			Renderer IEnumerator<Renderer>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000115")]
				[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000117")]
				[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0xB93C20", Offset = "0xB93020", VA = "0x180B93C20")]
			[DebuggerHidden]
			public DJFCFODJNMC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x80EA70", Offset = "0x80DE70", VA = "0x18080EA70", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x6250B30", Offset = "0x624FF30", VA = "0x186250B30", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x6250CD0", Offset = "0x62500D0", VA = "0x186250CD0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x6250C30", Offset = "0x6250030", VA = "0x186250C30", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x6250C30", Offset = "0x6250030", VA = "0x186250C30", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public int GPBCMDIPBFG
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x6250AD0", Offset = "0x624FED0", VA = "0x186250AD0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public IEnumerable<LCBFIFLMKEC> CHCLLMJIMOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x6250AA0", Offset = "0x624FEA0", VA = "0x186250AA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public List<MeshFilter> JEIKHHIPBCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x811A60", Offset = "0x810E60", VA = "0x180811A60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public KNCJNCGPEHA KDGAOLNBAKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x855AE0", Offset = "0x854EE0", VA = "0x180855AE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x855AF0", Offset = "0x854EF0", VA = "0x180855AF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public MEMNFNIPGPN NOCGCGFHKIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x915170", Offset = "0x914570", VA = "0x180915170", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(MEMNFNIPGPN);
			}
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xA9D5F0", Offset = "0xA9C9F0", VA = "0x180A9D5F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool GHJNNEBOLLP
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x6250AC0", Offset = "0x624FEC0", VA = "0x186250AC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x624F6C0", Offset = "0x624EAC0", VA = "0x18624F6C0")]
		public static ClusterMeshRenderer Create(KNCJNCGPEHA CKHGFHPLIDD, ClusterMeshRenderer IPFPHKLBLJA, MeshFilter IGBNONNKPPL, IKNPDLBNFFO PFMMNJCIGCA, MEMNFNIPGPN LOOKJAGKAIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x624F860", Offset = "0x624EC60", VA = "0x18624F860", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6250020", Offset = "0x624F420", VA = "0x186250020", Slot = "10")]
		public bool TryRemoveClusterLODComponent(FAHPALOMNPE COGHLJDPMKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x624FE10", Offset = "0x624F210", VA = "0x18624FE10")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x624FAB0", Offset = "0x624EEB0", VA = "0x18624FAB0")]
		public void Init(KNCJNCGPEHA CKHGFHPLIDD, MeshFilter IGBNONNKPPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x624F8C0", Offset = "0x624ECC0", VA = "0x18624F8C0")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6250150", Offset = "0x624F550", VA = "0x186250150", Slot = "8")]
		public void UpdateClusterDistances(Vector3 GBCJGHOCJAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6250320", Offset = "0x624F720", VA = "0x186250320", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x624FA40", Offset = "0x624EE40", VA = "0x18624FA40")]
		[IteratorStateMachine(typeof(DJFCFODJNMC))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x624FE90", Offset = "0x624F290", VA = "0x18624FE90")]
		public void SetupTagAndLayer(string GNLDPMDJHKA, int LOOKJAGKAIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x624FE70", Offset = "0x624F270", VA = "0x18624FE70")]
		public bool Remove(FAHPALOMNPE COGHLJDPMKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x94E2B0", Offset = "0x94D6B0", VA = "0x18094E2B0")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class AOIEPJGNBNP
{
	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public AOIEPJGNBNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x8C6BB0", Offset = "0x8C5FB0", VA = "0x1808C6BB0")]
	public static string NLHKAJNPDJN(byte[] AMGPPENALAL, byte[] DKDGFKIJFBC)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class __BB_OBFUSCATOR_VERSION_3_9_9
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
