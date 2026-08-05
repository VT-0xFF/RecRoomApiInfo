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
internal static class EJBBPECDBOL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6081070", Offset = "0x6080070", VA = "0x186081070")]
	public static Bounds KBFIMGCEHJE(List<INEOICAMCJM> PKGHFOMJNFP)
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6080ED0", Offset = "0x607FED0", VA = "0x186080ED0")]
	public static int JICOMBGOCJC(List<INEOICAMCJM> PKGHFOMJNFP, DFCJNAGAOHO MIIMEHOHOHP)
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
		[Cpp2IlInjected.Address(RVA = "0x85F0C0", Offset = "0x85E0C0", VA = "0x18085F0C0")]
		public ClusterLODManagerEditorDebug()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct ACILMJADCDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int NJLFCPIHBMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public int PDAGAKEPNHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public int DGPCBLOMIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public int FGIBBGFLOHG;

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6078ED0", Offset = "0x6077ED0", VA = "0x186078ED0")]
	public ACILMJADCDC(int PDAGAKEPNHP, int DGPCBLOMIDK, int NJLFCPIHBMB, int FGIBBGFLOHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class HNDHICMKOOB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public NativeList<float3> IMLCBBKKMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public NativeList<int> EIKDGFJMLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public NativeList<int> JLHJKOHEHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public NativeList<ACILMJADCDC> LICNKFCDNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public NativeArray<int> HGJDGOPJAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public NativeArray<float3> CCLBFLIJPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public NativeArray<float> OFBHBMGHPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public JobHandle AAPDDMNNEHG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool DFBOGFJEIOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x991FD0", Offset = "0x990FD0", VA = "0x180991FD0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xA23940", Offset = "0xA22940", VA = "0x180A23940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x60864A0", Offset = "0x60854A0", VA = "0x1860864A0")]
	public void HOCOANJGOKB(GKDOHBEKBBP CFFOFNJHMLO, NativeList<ACILMJADCDC> LICNKFCDNNP, float KFEAJPAHNFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x60873D0", Offset = "0x60863D0", VA = "0x1860873D0")]
	public void PCECLJGFFHM(Transform EMIPEAKIENF, bool MMNONDLENDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x60862F0", Offset = "0x60852F0", VA = "0x1860862F0")]
	public void GDPJLENAAGJ(CJPAMJBMFNF CPJMENEJDJH, bool LIGJIMNMKPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x60861E0", Offset = "0x60851E0", VA = "0x1860861E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6087690", Offset = "0x6086690", VA = "0x186087690")]
	public void PPNJFNMKMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public HNDHICMKOOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BurstCompile]
public struct KIJFBELMECB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[ReadOnly]
	private NativeList<float3> IMLCBBKKMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[ReadOnly]
	public NativeList<int> EIKDGFJMLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[ReadOnly]
	private NativeList<ACILMJADCDC> EHHNDJFJIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[ReadOnly]
	private NativeArray<int> HGJDGOPJAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	private float3 NPDFNOJGKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	private NativeArray<float3> CCLBFLIJPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	private NativeArray<float> OFBHBMGHPAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[ReadOnly]
	private bool MMNONDLENDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	[ReadOnly]
	private float AJOOJEAPFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	[ReadOnly]
	private float DGLDPEOFGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	[ReadOnly]
	private float MKGANGABPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private NativeList<int> JLHJKOHEHCG;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6088BF0", Offset = "0x6087BF0", VA = "0x186088BF0")]
	public KIJFBELMECB(HNDHICMKOOB KEBAKCMLOLH, Vector3 NPDFNOJGKKN, bool MMNONDLENDD, float AJOOJEAPFKB, float DGLDPEOFGBG, float MKGANGABPBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6088750", Offset = "0x6087750", VA = "0x186088750", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface HKHCKEGFFGD
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HKHCKEGFFGD EKILPDLOHII(Action OKCPFPFJOFL);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HKHCKEGFFGD GMLPENDMMOD(Action OKCPFPFJOFL);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HKHCKEGFFGD OLBGNELEEIB(Action OKCPFPFJOFL);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HKHCKEGFFGD OFJCBLABANL(Action OKCPFPFJOFL);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class JobQueue : SingletonMonoBehaviour<JobQueue>
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class GCEDPIHNBMO : HKHCKEGFFGD
		{
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			[CompilerGenerated]
			private sealed class JKGJHICGJLK
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public Action removeJob;

				[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public GCEDPIHNBMO <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public Action startNext;

				[Cpp2IlInjected.Token(Token = "0x6000026")]
				[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
				public JKGJHICGJLK()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000027")]
				[Cpp2IlInjected.Address(RVA = "0x60878A0", Offset = "0x60868A0", VA = "0x1860878A0")]
				internal void FBHDPKPCCFC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000028")]
				[Cpp2IlInjected.Address(RVA = "0x6087930", Offset = "0x6086930", VA = "0x186087930")]
				internal void KAMHOGBDKNE()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000029")]
				[Cpp2IlInjected.Address(RVA = "0x60878F0", Offset = "0x60868F0", VA = "0x1860878F0")]
				internal void GPJJGCONNOC()
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private Func<JobHandle> JJEJCAKKEIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private Action JECPFOMKAIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private Action NCICDNINLCI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private OPGCMOLAGMK LJDBCCFBMDJ;

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public Action ADLNHNEPPIF
			{
				[Cpp2IlInjected.Token(Token = "0x600001B")]
				[Cpp2IlInjected.Address(RVA = "0x9132D0", Offset = "0x9122D0", VA = "0x1809132D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x9132B0", Offset = "0x9122B0", VA = "0x1809132B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public Action HCKIDAEIPGP
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x9132C0", Offset = "0x9122C0", VA = "0x1809132C0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600001E")]
				[Cpp2IlInjected.Address(RVA = "0xA8F810", Offset = "0xA8E810", VA = "0x180A8F810")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x36CF610", Offset = "0x36CE610", VA = "0x1836CF610", Slot = "4")]
			public HKHCKEGFFGD EKILPDLOHII(Action OKCPFPFJOFL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x20E1760", Offset = "0x20E0760", VA = "0x1820E1760", Slot = "5")]
			public HKHCKEGFFGD GMLPENDMMOD(Action OKCPFPFJOFL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x221C7B0", Offset = "0x221B7B0", VA = "0x18221C7B0", Slot = "6")]
			public HKHCKEGFFGD OLBGNELEEIB(Action OKCPFPFJOFL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x3BF6450", Offset = "0x3BF5450", VA = "0x183BF6450", Slot = "7")]
			public HKHCKEGFFGD OFJCBLABANL(Action OKCPFPFJOFL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x919D70", Offset = "0x918D70", VA = "0x180919D70")]
			public GCEDPIHNBMO(Func<JobHandle> NEPNBCCGKKL)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6084510", Offset = "0x6083510", VA = "0x186084510")]
			public void PLLHAMBOEGA(Action JCOKEOBKNHC, Action GJPFOKFMIJI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x60843C0", Offset = "0x60833C0", VA = "0x1860843C0")]
			public void DNDEJFPIDIA()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class PGKCLNAKKFD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public HKHCKEGFFGD jobHandle;

			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public PGKCLNAKKFD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x608BA90", Offset = "0x608AA90", VA = "0x18608BA90")]
			internal bool HDFHPAFELNF(GCEDPIHNBMO a)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private sealed class PACIOOANPHJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public GCEDPIHNBMO newJob;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public JobQueue <>4__this;

			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
			public PACIOOANPHJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x608BA30", Offset = "0x608AA30", VA = "0x18608BA30")]
			internal void DDPBJPMLPOO()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private Queue<GCEDPIHNBMO> FLAAHOPEHIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private List<GCEDPIHNBMO> KFANBEEDFFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private HKMCLDHFALI FOKJAJEDPGB;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public CMJBEHOFKGH HBCMPGILIEO
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x9132C0", Offset = "0x9122C0", VA = "0x1809132C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA8F810", Offset = "0xA8E810", VA = "0x180A8F810")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6087980", Offset = "0x6086980", VA = "0x186087980")]
		public HKHCKEGFFGD Add(Func<JobHandle> NEPNBCCGKKL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6087CB0", Offset = "0x6086CB0", VA = "0x186087CB0")]
		public void Remove(HKHCKEGFFGD AAPDDMNNEHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6087AF0", Offset = "0x6086AF0", VA = "0x186087AF0", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6087E80", Offset = "0x6086E80", VA = "0x186087E80")]
		public void ScheduleQueuedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x60880E0", Offset = "0x60870E0", VA = "0x1860880E0")]
		public JobQueue()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6087AE0", Offset = "0x6086AE0", VA = "0x186087AE0")]
		[CompilerGenerated]
		private void JMFACFOKLFC()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class CJPAMJBMFNF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class CPBFHLBCLPG : IDisposable, GHDLBNMAPLC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public Bounds EFLBJLIBMOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public List<INEOICAMCJM> PKGHFOMJNFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public Vector3 NJJGCIEBJPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public Vector3 GDKJJBMMNAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public int OHHGIIDPNFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public GKDOHBEKBBP NCAALPPIMKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public GHMEOFHFMKI KAMOFMHLABP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public Transform EMIPEAKIENF;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int JMJHCEFNGGF
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x607F750", Offset = "0x607E750", VA = "0x18607F750")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public Mesh OOLHNDJBGEM
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x9132C0", Offset = "0x9122C0", VA = "0x1809132C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA8F810", Offset = "0xA8E810", VA = "0x180A8F810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public Mesh CKCELBEMNIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x871190", Offset = "0x870190", VA = "0x180871190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x871150", Offset = "0x870150", VA = "0x180871150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public float IAILECHGHGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x10B4DB0", Offset = "0x10B3DB0", VA = "0x1810B4DB0", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x2360190", Offset = "0x235F190", VA = "0x182360190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public byte HLCOCGBGPNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x90AF40", Offset = "0x909F40", VA = "0x18090AF40")]
			[CompilerGenerated]
			get
			{
				return default(byte);
			}
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xC9A990", Offset = "0xC99990", VA = "0x180C9A990", Slot = "9")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int DOPBOOCCACB
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xCE6810", Offset = "0xCE5810", VA = "0x180CE6810", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0xCE5890", Offset = "0xCE4890", VA = "0x180CE5890")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public int JCEJLJDGPFH
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x9B9B00", Offset = "0x9B8B00", VA = "0x1809B9B00", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x185FF30", Offset = "0x185EF30", VA = "0x18185FF30")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public float BCBMHBLJCHD
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x607F730", Offset = "0x607E730", VA = "0x18607F730", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x607F500", Offset = "0x607E500", VA = "0x18607F500")]
		public void JDHEODDKADF(DFCJNAGAOHO MIIMEHOHOHP, out int FGIBBGFLOHG, out int DGPCBLOMIDK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x607F150", Offset = "0x607E150", VA = "0x18607F150")]
		public void DHBKEKLMDMK(DFCJNAGAOHO MIIMEHOHOHP, GFJOMOPMDPO NADNFMJCGMD, int OCJLFGBNHEM = -1)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x607ED80", Offset = "0x607DD80", VA = "0x18607ED80")]
		public void BHGLEFDBOLL(NativeList<EBAGCCGNCIL> POOGFJHACJJ, Transform PADEFKCDJKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x607F0B0", Offset = "0x607E0B0", VA = "0x18607F0B0")]
		public void DEGEAMIGFEJ(Mesh CAFDMHFNNHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x607ECE0", Offset = "0x607DCE0", VA = "0x18607ECE0")]
		public void AEKIKJAFKHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x607F300", Offset = "0x607E300", VA = "0x18607F300", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x607F790", Offset = "0x607E790", VA = "0x18607F790")]
		public CPBFHLBCLPG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public Bounds EFLBJLIBMOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public List<CPBFHLBCLPG> JLFPEEPLJLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public HNDHICMKOOB BGCOGDJHDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public ClusterMeshRenderer CPJMENEJDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int KCLGEMODIIH;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Mesh JHBJADCDBMI
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9132D0", Offset = "0x9122D0", VA = "0x1809132D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9132B0", Offset = "0x9122B0", VA = "0x1809132B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public bool ONCJFKHIGNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x90AA90", Offset = "0x909A90", VA = "0x18090AA90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x90AAA0", Offset = "0x909AA0", VA = "0x18090AAA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int IKFGBDMHEEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x607EBE0", Offset = "0x607DBE0", VA = "0x18607EBE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x607E0F0", Offset = "0x607D0F0", VA = "0x18607E0F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x607E260", Offset = "0x607D260", VA = "0x18607E260")]
	public int EBNOJIBIJHM(int BMNLKHOOKCC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x607D570", Offset = "0x607C570", VA = "0x18607D570")]
	public void BNMGBJNFHFG(BGMOJICMDII IACNHNANJPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x607E450", Offset = "0x607D450", VA = "0x18607E450")]
	public void LCMLBGPGOEI(Transform PADEFKCDJKB, bool MMNONDLENDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x607E290", Offset = "0x607D290", VA = "0x18607E290")]
	public bool GDPJLENAAGJ(bool LIGJIMNMKPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x607D9F0", Offset = "0x607C9F0", VA = "0x18607D9F0")]
	public void DPCCKLNBNAA(Transform EMIPEAKIENF, bool MMNONDLENDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x607D740", Offset = "0x607C740", VA = "0x18607D740")]
	public bool DNDEJFPIDIA(INEOICAMCJM GDOIACLJEDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x607EC30", Offset = "0x607DC30", VA = "0x18607EC30")]
	public CJPAMJBMFNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class BEPCKBMLOEF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private Queue<CJPAMJBMFNF.CPBFHLBCLPG> DOANPBEENBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private GHDFGBEABPL MLPGLNPBHOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<CJPAMJBMFNF.CPBFHLBCLPG> KBNCMHANHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private int JEBHBLPEJOP;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x607A280", Offset = "0x6079280", VA = "0x18607A280", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x607A710", Offset = "0x6079710", VA = "0x18607A710")]
	public void PPNJFNMKMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6079E90", Offset = "0x6078E90", VA = "0x186079E90")]
	public void AMLBOIMHPGF(CJPAMJBMFNF.CPBFHLBCLPG LALNEMCNLEJ, Transform EMIPEAKIENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x607A090", Offset = "0x6079090", VA = "0x18607A090")]
	public void DNDEJFPIDIA(CJPAMJBMFNF.CPBFHLBCLPG LALNEMCNLEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6079F50", Offset = "0x6078F50", VA = "0x186079F50")]
	private CJPAMJBMFNF.CPBFHLBCLPG CHEBGHDDCEA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x607A5E0", Offset = "0x60795E0", VA = "0x18607A5E0")]
	private bool OFFNKCDCONC(CJPAMJBMFNF.CPBFHLBCLPG LALNEMCNLEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x607A2F0", Offset = "0x60792F0", VA = "0x18607A2F0")]
	private void GDGPLNOMFBF(CJPAMJBMFNF.CPBFHLBCLPG LALNEMCNLEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x607A6E0", Offset = "0x60796E0", VA = "0x18607A6E0")]
	public bool PKKBCEIDEBK(CJPAMJBMFNF.CPBFHLBCLPG LALNEMCNLEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x607A350", Offset = "0x6079350", VA = "0x18607A350")]
	public bool MCCBAFPODDI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x607A680", Offset = "0x6079680", VA = "0x18607A680")]
	private CJPAMJBMFNF.CPBFHLBCLPG OMJJBCDMHPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x607A790", Offset = "0x6079790", VA = "0x18607A790")]
	public BEPCKBMLOEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class GHMEOFHFMKI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static NativeParallelMultiHashMap<int, int> NNEOOMLCKKL;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static NativeArray<int> NLPHOPIDCFB;

	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private static int ABKBAOGEPFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public NativeList<int> EIKDGFJMLFJ;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x60858F0", Offset = "0x60848F0", VA = "0x1860858F0")]
	public void DHIEAFKKHLI(int BKDICOGELCP, Allocator HFHMLIPGBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6085AF0", Offset = "0x6084AF0", VA = "0x186085AF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public GHMEOFHFMKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[BurstCompile]
public struct LGKABEEGMOP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[ReadOnly]
	public NativeList<int> LDDIHCEAPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeList<int> JOJFNOJDHLD;

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6089410", Offset = "0x6088410", VA = "0x186089410")]
	public LGKABEEGMOP(GHMEOFHFMKI BBGNAIBNEPN, GKDOHBEKBBP CAFDMHFNNHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6089360", Offset = "0x6088360", VA = "0x186089360", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct CHANIMPKKNH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	[ReadOnly]
	private NativeList<float3> OCCCHFMOOEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	[ReadOnly]
	private NativeArray<float3> BFHNFOJCLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	private NativeArray<float4> JNGFGPCNLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	private NativeArray<float2> HFAJHCKPEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[ReadOnly]
	private NativeArray<float4> FGDECMOBGNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private NativeList<int> EIKDGFJMLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private NativeList<int> LDDIHCEAPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private NativeList<float3> PJKDJPDBJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private NativeArray<float3> EOEHHECJOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private NativeArray<float4> KFJODIDPBEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private NativeArray<float4> ALNPOKEHIMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private NativeArray<float2> HCHJKCJNCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private NativeList<int> HALNAEMBLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[ReadOnly]
	private float DJCKPGJGJKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[ReadOnly]
	public float NCGFBJACAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[ReadOnly]
	private float3 NPDFNOJGKKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[ReadOnly]
	private float HPCMGJMFFNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[ReadOnly]
	private float CHMLFOIDGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[ReadOnly]
	public float FJDPGBJBEDI;

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x607D430", Offset = "0x607C430", VA = "0x18607D430")]
	public CHANIMPKKNH(GHMEOFHFMKI DHNDLHOILAG, GKDOHBEKBBP CAFDMHFNNHI, GKDOHBEKBBP HCEECPGBFMI, float CHMLFOIDGCA, float FJDPGBJBEDI, Vector3 NPDFNOJGKKN, float HPCMGJMFFNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x607CF40", Offset = "0x607BF40", VA = "0x18607CF40")]
	private float3 KAMIFMGEKGH(int KJPGMJFNNHE)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x607D250", Offset = "0x607C250", VA = "0x18607D250")]
	private void NNILLIGHPOP(int KJPGMJFNNHE, out float3 EPOPMAHBHEE, out float3 ABENIJEKJKF, out float4 JKGAPFKMBOE, out float4 DPMFCGOMDAP, out float2 NDBEIFNEMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x607C360", Offset = "0x607B360", VA = "0x18607C360")]
	private int EEBCOOLELNE(int LNBDOMAPGHF, int MLDBAJLBPCN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x607C140", Offset = "0x607B140", VA = "0x18607C140")]
	private void CKMLGHPAHHE(int LNBDOMAPGHF, int MLDBAJLBPCN, int KMIPGNBJFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x607BFC0", Offset = "0x607AFC0", VA = "0x18607BFC0")]
	private bool CBAMIONCMMH(int LNBDOMAPGHF, int MLDBAJLBPCN, float IDFFJHIFAGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x607BF00", Offset = "0x607AF00", VA = "0x18607BF00")]
	private bool BLMCGKKGFAA(int LNBDOMAPGHF, int MLDBAJLBPCN, int KMIPGNBJFNF, float IDFFJHIFAGF, bool APCOFHBBIFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x607CFF0", Offset = "0x607BFF0", VA = "0x18607CFF0")]
	private bool KDBDPDGOMNC(int LNBDOMAPGHF, int MLDBAJLBPCN, int KMIPGNBJFNF, float IDFFJHIFAGF, bool APCOFHBBIFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x607C340", Offset = "0x607B340", VA = "0x18607C340")]
	private void DGNLLIOAMOP(int LNBDOMAPGHF, int MLDBAJLBPCN, int KMIPGNBJFNF, out int OJOEJMAAOCA, out int EMMJCFPLOFL, out int KPCOHDLJPNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x607C650", Offset = "0x607B650", VA = "0x18607C650", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class HKJDNNOEOHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private int ILMMDCLLKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	private int MJOJNPOOGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private float HNBDMDMPNIE;

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public List<CJPAMJBMFNF> FOOJBFNBOHL
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x85E980", Offset = "0x85D980", VA = "0x18085E980")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x913240", Offset = "0x912240", VA = "0x180913240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6086190", Offset = "0x6085190", VA = "0x186086190")]
	public HKJDNNOEOHH(int ILMMDCLLKPJ, int MJOJNPOOGND, float ACCLGPHGPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6086030", Offset = "0x6085030", VA = "0x186086030")]
	public void MEPIDMLODBP(GACCICIMPLJ JIHJHLGLJEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x60860E0", Offset = "0x60850E0", VA = "0x1860860E0")]
	private int NEHKJNLLMKF(BGMOJICMDII IKGBLMLJFLF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6085DE0", Offset = "0x6084DE0", VA = "0x186085DE0")]
	private void MEPIDMLODBP(BGMOJICMDII IKGBLMLJFLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6085BC0", Offset = "0x6084BC0", VA = "0x186085BC0")]
	private void DJEKGKGDOGB(BGMOJICMDII IKGBLMLJFLF, CJPAMJBMFNF IEIEHGBGOOF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface FKBENGAKCFG
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	EJHDBNLKMDB JBMMBHICNFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum IMLFFDOMCPA
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
public interface LLEGFGPJOLH
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OFEEDNLDJAI();
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface HLMOHFMBKOB
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	int IKFGBDMHEEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	IEnumerable<GHDLBNMAPLC> EHICDOBNBML
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	IMLFFDOMCPA GEMKGOMJNKH
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
	void UpdateClusterDistances(Vector3 EHELKFGJCKP);

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DestroyObject();

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool TryRemoveClusterLODComponent(INEOICAMCJM GDOIACLJEDE);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public interface GHDLBNMAPLC
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int DOPBOOCCACB
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int JCEJLJDGPFH
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float IAILECHGHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float BCBMHBLJCHD
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	byte HLCOCGBGPNB
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class EJHDBNLKMDB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public enum AAGCIODFHHJ
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
	private sealed class LGAOPKGFLAL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH stackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public CancellationToken externalToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public EJHDBNLKMDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private CancellationTokenSource <>s__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <createWorldTimer>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public LGAOPKGFLAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6088CC0", Offset = "0x6087CC0", VA = "0x186088CC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[CompilerGenerated]
	private sealed class OMJOHIFHGCJ : IEnumerator<OJAHJFHMFIA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private OJAHJFHMFIA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public EJHDBNLKMDB <>4__this;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private OJAHJFHMFIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0xA80FD0", Offset = "0xA7FFD0", VA = "0x180A80FD0")]
		[DebuggerHidden]
		public OMJOHIFHGCJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x608B940", Offset = "0x608A940", VA = "0x18608B940", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x608B9F0", Offset = "0x608A9F0", VA = "0x18608B9F0", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class CCGCLAMPOLO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public MNKIABAIHBN<string>.JJAEKMMDGKH worldStackTimer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public EJHDBNLKMDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <waitForShapesTimer>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <>s__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private List<LLEGFGPJOLH>.Enumerator <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private LLEGFGPJOLH <sc>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <>s__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <>s__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private List<INEOICAMCJM>.Enumerator <>s__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		private INEOICAMCJM <c>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <>s__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <>s__10;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private MNKIABAIHBN<string>.JJAEKMMDGKH <>s__11;

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
		[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
		public CCGCLAMPOLO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x607A990", Offset = "0x6079990", VA = "0x18607A990", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class AFJNCLPCCHE : IEnumerator<OJAHJFHMFIA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private OJAHJFHMFIA <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public EJHDBNLKMDB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private int <numVerts>5__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private int <extraVerts>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		private List<GHDLBNMAPLC>.Enumerator <>s__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		private GHDLBNMAPLC <c>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		private int <numVertsToSpare>5__5;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x40000B1")]
		private int <index>5__6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private List<GHDLBNMAPLC> <clusters>5__7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		private int <numVertsToSpare>5__8;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private int <index>5__9;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private List<GHDLBNMAPLC> <clusters>5__10;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private OJAHJFHMFIA System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0xA80FD0", Offset = "0xA7FFD0", VA = "0x180A80FD0")]
		[DebuggerHidden]
		public AFJNCLPCCHE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6078EF0", Offset = "0x6077EF0", VA = "0x186078EF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6079E50", Offset = "0x6078E50", VA = "0x186079E50", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public const int DPADMKOIIFI = 3;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private static readonly TimeSpan CCJGADPBHKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public ClusterMeshRenderer IDHMHHPHHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public MeshFilter GKPDJHDOKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private GameObject KMLEJJIPNBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private GameObject JEECMLKGGFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public BEPCKBMLOEF HGJHIHIMCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private List<INEOICAMCJM> PMMCDJPOOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private List<INEOICAMCJM> OPBBGCAOJNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private List<INEOICAMCJM> IKMBFCKDBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private int DONIEAOFIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private AAGCIODFHHJ JJEJAAFMCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public List<HLMOHFMBKOB>[] IGAJGLPPGCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private List<GHDLBNMAPLC>[] DIDBIFNIFIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private CancellationTokenSource DDMLIMMPOLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private bool MPAKGNHHKHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private HKMCLDHFALI JDKEJJLEEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private HKMCLDHFALI GGKLCBMNIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public int JLNCAOBHGGB;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private static EJHDBNLKMDB HPHEIPDJOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly FAOEMAFPHCK JJHENGEEHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private readonly FBJEBMGBKAH JHIHNOFMLEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly MonoBehaviour ILANDCGEAKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	private readonly Material LDNNCLBNADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private readonly List<LLEGFGPJOLH> BMFDFMPOJCP;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ClusterLODConfig MBHLDAHAOEA
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x85E070", Offset = "0x85D070", VA = "0x18085E070")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9132F0", Offset = "0x9122F0", VA = "0x1809132F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public Vector3 AKCKCEBLHNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0xFC1120", Offset = "0xFC0120", VA = "0x180FC1120")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0xFC0D30", Offset = "0xFBFD30", VA = "0x180FC0D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	private AAGCIODFHHJ JGBBKGJBOME
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x20F60F0", Offset = "0x20F50F0", VA = "0x1820F60F0")]
		get
		{
			return default(AAGCIODFHHJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x6083980", Offset = "0x6082980", VA = "0x186083980")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static EJHDBNLKMDB HIEJPGCOIBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x60827A0", Offset = "0x60817A0", VA = "0x1860827A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static bool NDIAKEBDNFE
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6081560", Offset = "0x6080560", VA = "0x186081560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public static bool OHBMODKJCAP
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6081960", Offset = "0x6080960", VA = "0x186081960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event Action<Vector3> LKNHKHHEGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x6081DD0", Offset = "0x6080DD0", VA = "0x186081DD0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x60838E0", Offset = "0x60828E0", VA = "0x1860838E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event Action BACOHAEGLFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x60821B0", Offset = "0x60811B0", VA = "0x1860821B0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6081AA0", Offset = "0x6080AA0", VA = "0x186081AA0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6083B80", Offset = "0x6082B80", VA = "0x186083B80")]
	public EJHDBNLKMDB(FAOEMAFPHCK JJHENGEEHCA, FBJEBMGBKAH JHIHNOFMLEK, ClusterLODConfig PELCBFNKHHF, MonoBehaviour ILANDCGEAKJ, Material LDNNCLBNADC, ClusterMeshRenderer IDHMHHPHHCK, MeshFilter GKPDJHDOKEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6081860", Offset = "0x6080860", VA = "0x186081860", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x60813B0", Offset = "0x60803B0", VA = "0x1860813B0")]
	public static void ACEIDPOPFLB(Vector3 OFHGGCPLFPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6083810", Offset = "0x6082810", VA = "0x186083810")]
	private void NIPPDPAKMOP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6082420", Offset = "0x6081420", VA = "0x186082420")]
	private void HGPCDKKPCBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6082F00", Offset = "0x6081F00", VA = "0x186082F00")]
	private void KALFKOKANDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6082800", Offset = "0x6081800", VA = "0x186082800")]
	public void IOOBHLEPGCJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6081240", Offset = "0x6080240", VA = "0x186081240")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(LGAOPKGFLAL))]
	public Task AANKHMGDEBM(MNKIABAIHBN<string>.JJAEKMMDGKH OIOLLBANPGL, CancellationToken JCAANINIIFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x60830D0", Offset = "0x60820D0", VA = "0x1860830D0")]
	[IteratorStateMachine(typeof(OMJOHIFHGCJ))]
	private IEnumerator<OJAHJFHMFIA> MOODGBJGJDF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6082040", Offset = "0x6081040", VA = "0x186082040")]
	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(CCGCLAMPOLO))]
	private Task FPHNHKBNDIM(MNKIABAIHBN<string>.JJAEKMMDGKH BCHPKNNNCFF, CancellationToken OAGBBBCDIGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x6081B40", Offset = "0x6080B40", VA = "0x186081B40")]
	public void FFHLFPOCOCO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6083050", Offset = "0x6082050", VA = "0x186083050")]
	public void MJIGAPFOIEL(IEnumerable<HLMOHFMBKOB> KFOPIIFJJJO, IMLFFDOMCPA KFHMEIJCMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6082520", Offset = "0x6081520", VA = "0x186082520")]
	public void IICKKPAGKOL(IEnumerable<HLMOHFMBKOB> KFOPIIFJJJO, IMLFFDOMCPA KFHMEIJCMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6083140", Offset = "0x6082140", VA = "0x186083140")]
	public List<ClusterMeshRenderer> NAAPLCCNMNI(List<INEOICAMCJM> PKGHFOMJNFP, ACILLLOIMMI EMIPEAKIENF, IMLFFDOMCPA KFHMEIJCMFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6082EC0", Offset = "0x6081EC0", VA = "0x186082EC0")]
	public IMLFFDOMCPA JKEPNFFPNNP(Vector3 NPMEABPGIGM)
	{
		return default(IMLFFDOMCPA);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6083AB0", Offset = "0x6082AB0", VA = "0x186083AB0")]
	public void PAIDDMGGNJD(LLEGFGPJOLH JIMNBAHALIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6081D70", Offset = "0x6080D70", VA = "0x186081D70")]
	public bool FHCNNFIGLOI(LLEGFGPJOLH JIMNBAHALIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6081A40", Offset = "0x6080A40", VA = "0x186081A40")]
	public void FBOGCGAAIFF(INEOICAMCJM ONELKLDGAEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6083790", Offset = "0x6082790", VA = "0x186083790")]
	public void NFMKODFANIJ(GHDLBNMAPLC OAACCGHGNDI, IMLFFDOMCPA KFHMEIJCMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x60814E0", Offset = "0x60804E0", VA = "0x1860814E0")]
	public void AMGDJIGONAL(GHDLBNMAPLC OAACCGHGNDI, IMLFFDOMCPA KFHMEIJCMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6082250", Offset = "0x6081250", VA = "0x186082250")]
	private void GFFKCHNOJMA(Vector3 EHELKFGJCKP, IMLFFDOMCPA KFHMEIJCMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6082D60", Offset = "0x6081D60", VA = "0x186082D60")]
	private void JBDHBJLFFMI(Vector3 EHELKFGJCKP, IMLFFDOMCPA KFHMEIJCMFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x60823B0", Offset = "0x60813B0", VA = "0x1860823B0")]
	[IteratorStateMachine(typeof(AFJNCLPCCHE))]
	private IEnumerator<OJAHJFHMFIA> GIGJMOKIIGF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6081EB0", Offset = "0x6080EB0", VA = "0x186081EB0")]
	private int FNJAEAKFNDN(int CCELBNKPBGB, int KKMENIGKEGF, List<GHDLBNMAPLC> BMBPIPMAFHC, byte MIIMEHOHOHP, ref int JJLNIKEDPMB, float PLGJMEHBBDA = 0f)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6081680", Offset = "0x6080680", VA = "0x186081680")]
	public void DNDEJFPIDIA(INEOICAMCJM GDOIACLJEDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6081E70", Offset = "0x6080E70", VA = "0x186081E70")]
	public bool FMEHOPOGBKO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x864CE0", Offset = "0x863CE0", VA = "0x180864CE0")]
	public Material AELBGHLBPFA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x60838A0", Offset = "0x60828A0", VA = "0x1860838A0")]
	public int NMOFFGJCBHH()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class OLKGKCNAOFM
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	private struct GBPEPEGIEKL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public int DPFMFCEMFCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public int BLNKENBEAOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public int CAKOLFBFBDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int MHCJKFAKLPN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	private struct EJFCOEEJNLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public int PGJMLJEAHDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public float NPKLCGCABLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public List<INEOICAMCJM> PKGHFOMJNFP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private enum GLPJCJMECPN
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
	private GBPEPEGIEKL CIKKJHAAAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private int KJMCOHNDCGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private int ILMMDCLLKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private int MJOJNPOOGND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private float ACCLGPHGPNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private float LPGDHHKBKOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private Stack<BGMOJICMDII> CPMNPHLEACN;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public GACCICIMPLJ BJMCJDLPMCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x85E980", Offset = "0x85D980", VA = "0x18085E980")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x913240", Offset = "0x912240", VA = "0x180913240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x608B8E0", Offset = "0x608A8E0", VA = "0x18608B8E0")]
	public OLKGKCNAOFM(int ILMMDCLLKPJ, int MJOJNPOOGND, float ACCLGPHGPNB, int KJMCOHNDCGA, float LPGDHHKBKOI = 0.5f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x6089C50", Offset = "0x6088C50", VA = "0x186089C50")]
	public void AGLILLOGEEH(List<INEOICAMCJM> PKGHFOMJNFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x608B870", Offset = "0x608A870", VA = "0x18608B870")]
	public bool PKNEALDHKFE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x608B800", Offset = "0x608A800", VA = "0x18608B800")]
	private float MCOEMNJLNEN(Vector3 LMBLJACJEIN, Vector3 KHIOAKAGFFK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x608B7C0", Offset = "0x608A7C0", VA = "0x18608B7C0")]
	private float MCOEMNJLNEN(Vector3 BKMCHKCIDOC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6089E50", Offset = "0x6088E50", VA = "0x186089E50")]
	private bool DKKFCHPICIK(BGMOJICMDII LALNEMCNLEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x608ABC0", Offset = "0x6089BC0", VA = "0x18608ABC0")]
	private EJFCOEEJNLK LHOLBGKAMHA(List<INEOICAMCJM> NLIJEODNBLO, GLPJCJMECPN KJEDFOFMLLE)
	{
		return default(EJFCOEEJNLK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x608A740", Offset = "0x6089740", VA = "0x18608A740")]
	private void KJAIOMBDJPE(List<INEOICAMCJM> PKGHFOMJNFP, Vector3[] JDJNEDOFNMB, Vector3[] NLPAJIOEFCB)
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
				[Cpp2IlInjected.Address(RVA = "0x6089490", Offset = "0x6088490", VA = "0x186089490")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			public bool UseTangents
			{
				[Cpp2IlInjected.Token(Token = "0x60000D3")]
				[Cpp2IlInjected.Address(RVA = "0x1B36B70", Offset = "0x1B35B70", VA = "0x181B36B70")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x6089440", Offset = "0x6088440", VA = "0x186089440")]
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
		[Cpp2IlInjected.Address(RVA = "0x607F940", Offset = "0x607E940", VA = "0x18607F940")]
		public LODSettings JMONLHKDOOH(DFCJNAGAOHO MIIMEHOHOHP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x607F950", Offset = "0x607E950", VA = "0x18607F950")]
		public int NMOFFGJCBHH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x607F870", Offset = "0x607E870", VA = "0x18607F870")]
		public int BFKLHHLBFKI(bool ICINKIBPEAF, Vector3 GDGBDAKEEPK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x607F970", Offset = "0x607E970", VA = "0x18607F970")]
		public ClusterLODConfig()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface INEOICAMCJM : DENCHOJPCHA
{
	[Cpp2IlInjected.Token(Token = "0x17000027")]
	Bounds CKMEDMIOMAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	EBAGCCGNCIL NNPJNCBNBFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public class BGMOJICMDII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public List<INEOICAMCJM> PKGHFOMJNFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	public BGMOJICMDII DJAGPEDCGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	public BGMOJICMDII GHNKJMIKFJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	public BGMOJICMDII CDFCAHNKHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	public int FGIBBGFLOHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public Bounds EFLBJLIBMOH;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x607A910", Offset = "0x6079910", VA = "0x18607A910")]
	public BGMOJICMDII(List<INEOICAMCJM> PKGHFOMJNFP, [Optional] BGMOJICMDII DJAGPEDCGHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class GACCICIMPLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	public List<BGMOJICMDII> NHGGCLKAODP;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public BGMOJICMDII LGIBJPCGOGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x85E070", Offset = "0x85D070", VA = "0x18085E070")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x9132F0", Offset = "0x9122F0", VA = "0x1809132F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x60842F0", Offset = "0x60832F0", VA = "0x1860842F0")]
	public GACCICIMPLJ(BGMOJICMDII EMIPEAKIENF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class GHDFGBEABPL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private GKDOHBEKBBP DBFINIPCJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private GKDOHBEKBBP CHOEOPNFNKF;

	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public static GKDOHBEKBBP EGBOFCAEGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private MONPJKCDKNK BIGDNJLEHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private GFJOMOPMDPO NADNFMJCGMD;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public JobHandle AAPDDMNNEHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0xA76DE0", Offset = "0xA75DE0", VA = "0x180A76DE0")]
		[CompilerGenerated]
		get
		{
			return default(JobHandle);
		}
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0xC28170", Offset = "0xC27170", VA = "0x180C28170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public CJPAMJBMFNF.CPBFHLBCLPG LALNEMCNLEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x85E980", Offset = "0x85D980", VA = "0x18085E980")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x913240", Offset = "0x912240", VA = "0x180913240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool JAJNHCFMMII
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x2985350", Offset = "0x2984350", VA = "0x182985350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6084770", Offset = "0x6083770", VA = "0x186084770")]
	[JOOLBCFGFFN(LLJHODDJBDJ.ExitingPlayMode, 0)]
	private static void BIBIAOMMAPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6084F30", Offset = "0x6083F30", VA = "0x186084F30")]
	public void HOCOANJGOKB(CJPAMJBMFNF.CPBFHLBCLPG EHHNDJFJIGN, Transform JNHAINEFAAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6084850", Offset = "0x6083850", VA = "0x186084850")]
	public void HDBJJDJFCII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x60847E0", Offset = "0x60837E0", VA = "0x1860847E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6085810", Offset = "0x6084810", VA = "0x186085810")]
	public void PPNJFNMKMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6085850", Offset = "0x6084850", VA = "0x186085850")]
	public GHDFGBEABPL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
public struct OBFJNDJLGPC : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private NativeList<float3> IMLCBBKKMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private NativeArray<float3> EHDNIIKEAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private NativeArray<float4> ABNEAPOHDHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NativeArray<float2> AFOJPCHANKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private NativeArray<float4> FIDLBCNEACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private NativeList<int> JLHJKOHEHCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	[ReadOnly]
	private NativeList<float3> JIFJPMHDGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	[ReadOnly]
	private float3 PCEBAEKFAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[ReadOnly]
	private float KCIPHLOIFLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private NativeParallelMultiHashMap<int, int> NNEOOMLCKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private NativeArray<int> NLPHOPIDCFB;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6089B90", Offset = "0x6088B90", VA = "0x186089B90")]
	public OBFJNDJLGPC(GKDOHBEKBBP CAFDMHFNNHI, NativeList<float3> JIFJPMHDGKE, NativeParallelMultiHashMap<int, int> NNEOOMLCKKL, NativeArray<int> NLPHOPIDCFB, Vector3 PCEBAEKFAGG, float KCIPHLOIFLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6089B60", Offset = "0x6088B60", VA = "0x186089B60")]
	private int LHKIJFPJGGC(float3 EHELKFGJCKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6089910", Offset = "0x6088910", VA = "0x186089910")]
	private int JLKLCDIBKHJ(int KJPGMJFNNHE, int LOHIKDGDMPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x60894B0", Offset = "0x60884B0", VA = "0x1860894B0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface FAOEMAFPHCK
{
	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task WaitForShapes(MNKIABAIHBN<string>.JJAEKMMDGKH BCHPKNNNCFF, CancellationToken OAGBBBCDIGC);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface OPGCMOLAGMK
{
	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OPGCMOLAGMK EKILPDLOHII(Action OKCPFPFJOFL);

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	OPGCMOLAGMK PKMJABJGNBC(Action OKCPFPFJOFL);

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OPGCMOLAGMK OFJCBLABANL(Action OKCPFPFJOFL);
}
namespace RecRoom.ClusterLODs
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class JobTracker : SingletonMonoBehaviour<JobTracker>
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		private class DBEMAANBEOM : OPGCMOLAGMK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private JobHandle FJJOMGEMMBF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000102")]
			private Action JECPFOMKAIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			private Action JPFHJMJBCJJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			private Action HCKIDAEIPGP;

			[Cpp2IlInjected.Token(Token = "0x1700002D")]
			public bool OLALHFPGCFA
			{
				[Cpp2IlInjected.Token(Token = "0x60000F8")]
				[Cpp2IlInjected.Address(RVA = "0x6080EC0", Offset = "0x607FEC0", VA = "0x186080EC0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x20E1760", Offset = "0x20E0760", VA = "0x1820E1760", Slot = "4")]
			public OPGCMOLAGMK EKILPDLOHII(Action OKCPFPFJOFL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x221C7B0", Offset = "0x221B7B0", VA = "0x18221C7B0", Slot = "5")]
			public OPGCMOLAGMK PKMJABJGNBC(Action OKCPFPFJOFL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x3BF6450", Offset = "0x3BF5450", VA = "0x183BF6450", Slot = "6")]
			public OPGCMOLAGMK OFJCBLABANL(Action OKCPFPFJOFL)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x20BB670", Offset = "0x20BA670", VA = "0x1820BB670")]
			public DBEMAANBEOM(JobHandle MKCJEPPJFMG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x6080E40", Offset = "0x607FE40", VA = "0x186080E40")]
			public void DGCOAPBJKNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x6080E80", Offset = "0x607FE80", VA = "0x186080E80")]
			public void DNDEJFPIDIA()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private List<DBEMAANBEOM> NJGGGNDKPPC;

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x60885A0", Offset = "0x60875A0", VA = "0x1860885A0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x60881C0", Offset = "0x60871C0", VA = "0x1860881C0")]
		public OPGCMOLAGMK Add(JobHandle MKCJEPPJFMG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x60884B0", Offset = "0x60874B0", VA = "0x1860884B0")]
		public void Remove(OPGCMOLAGMK AAPDDMNNEHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x6088340", Offset = "0x6087340", VA = "0x186088340", Slot = "5")]
		protected override void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x6088250", Offset = "0x6087250", VA = "0x186088250")]
		public void FinalizeCompletedJobs()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x60886C0", Offset = "0x60876C0", VA = "0x1860886C0")]
		public JobTracker()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public interface FBJEBMGBKAH
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	Vector3 FFKHCBIHIFA
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
		[Cpp2IlInjected.Address(RVA = "0x85F0C0", Offset = "0x85E0C0", VA = "0x18085F0C0")]
		public ClusterMeshAssetEditorDebug()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class ClusterMeshRenderer : MonoBehaviour, HLMOHFMBKOB
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private sealed class JCLIDACPLHL : IEnumerable<Renderer>, IEnumerable, IEnumerator<Renderer>, IEnumerator, IDisposable
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
				[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0xC531B0", Offset = "0xC521B0", VA = "0x180C531B0")]
			[DebuggerHidden]
			public JCLIDACPLHL(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x60876C0", Offset = "0x60866C0", VA = "0x1860876C0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x6087860", Offset = "0x6086860", VA = "0x186087860", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x60877C0", Offset = "0x60867C0", VA = "0x1860877C0", Slot = "4")]
			[DebuggerHidden]
			IEnumerator<Renderer> IEnumerable<Renderer>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000119")]
			[Cpp2IlInjected.Address(RVA = "0x60877C0", Offset = "0x60867C0", VA = "0x1860877C0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public int IKFGBDMHEEF
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x6080DE0", Offset = "0x607FDE0", VA = "0x186080DE0", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public IEnumerable<GHDLBNMAPLC> EHICDOBNBML
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x6080DB0", Offset = "0x607FDB0", VA = "0x186080DB0", Slot = "5")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public List<MeshFilter> JLFPEEPLJLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x9132E0", Offset = "0x9122E0", VA = "0x1809132E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public CJPAMJBMFNF JHBJADCDBMI
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x85E980", Offset = "0x85D980", VA = "0x18085E980")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x913240", Offset = "0x912240", VA = "0x180913240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public IMLFFDOMCPA GEMKGOMJNKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x9B5030", Offset = "0x9B4030", VA = "0x1809B5030", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return default(IMLFFDOMCPA);
			}
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0xC87120", Offset = "0xC86120", VA = "0x180C87120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public bool EILPIEJGOFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x6080DD0", Offset = "0x607FDD0", VA = "0x186080DD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x607F9D0", Offset = "0x607E9D0", VA = "0x18607F9D0")]
		public static ClusterMeshRenderer Create(CJPAMJBMFNF CAFDMHFNNHI, ClusterMeshRenderer IDHMHHPHHCK, MeshFilter GKPDJHDOKEL, ACILLLOIMMI EMIPEAKIENF, IMLFFDOMCPA KFHMEIJCMFI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x607FB70", Offset = "0x607EB70", VA = "0x18607FB70", Slot = "9")]
		public void DestroyObject()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6080330", Offset = "0x607F330", VA = "0x186080330", Slot = "10")]
		public bool TryRemoveClusterLODComponent(INEOICAMCJM GDOIACLJEDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6080120", Offset = "0x607F120", VA = "0x186080120")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x607FDC0", Offset = "0x607EDC0", VA = "0x18607FDC0")]
		public void Init(CJPAMJBMFNF CAFDMHFNNHI, MeshFilter GKPDJHDOKEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x607FBD0", Offset = "0x607EBD0", VA = "0x18607FBD0")]
		public void GenerateLOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6080450", Offset = "0x607F450", VA = "0x186080450", Slot = "8")]
		public void UpdateClusterDistances(Vector3 EHELKFGJCKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6080620", Offset = "0x607F620", VA = "0x186080620", Slot = "7")]
		public bool UpdateVisibility()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x607FD50", Offset = "0x607ED50", VA = "0x18607FD50")]
		[IteratorStateMachine(typeof(JCLIDACPLHL))]
		public IEnumerable<Renderer> GetOutlineRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x60801A0", Offset = "0x607F1A0", VA = "0x1860801A0")]
		public void SetupTagAndLayer(string NFGFAGCLOCD, int KFHMEIJCMFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6080180", Offset = "0x607F180", VA = "0x186080180")]
		public bool Remove(INEOICAMCJM GDOIACLJEDE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x85F0C0", Offset = "0x85E0C0", VA = "0x18085F0C0")]
		public ClusterMeshRenderer()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class MHGFMJKAFPI
{
	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public MHGFMJKAFPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0xBB9C20", Offset = "0xBB8C20", VA = "0x180BB9C20")]
	public static string KILOLNAHAFI(byte[] BKIADALNNFJ, byte[] EEICCMPLMOJ)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
