using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.Core.Pools;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Rendering.Universal;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class PooledDamageParticles : PooledParticle
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private float minDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private float maxDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[Header("Impact Particle System")]
		[SerializeField]
		private ParticleSystem impactParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[Header("Impact Particle Start Size")]
		[SerializeField]
		private float impactStartSizeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private float impactStartSizeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[Header("Impact Particle Start Lifetime")]
		[SerializeField]
		private float impactStartLifetimeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private float impactStartLifetimeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Header("Spray Particle System")]
		[SerializeField]
		private ParticleSystem sprayParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Header("Spray Particle Burst Count")]
		[SerializeField]
		private int sprayBurstCountMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private int sprayBurstCountMaxDamage;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8661250", Offset = "0x8660650", VA = "0x188661250")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles MKFMLBCIMEB, float GMHIEDCJKEF, Vector3 LBCFHLNAPLC, Quaternion EMLGDFFEJED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8660EF0", Offset = "0x86602F0", VA = "0x188660EF0")]
		public void SetDamageValue(float GMHIEDCJKEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8661390", Offset = "0x8660790", VA = "0x188661390")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NOOAOCGPJIA<T> : FHMCAMOMJOP<T>, IHCAHILICGC, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface MEJGKJGLFKJ<T> : IHCAHILICGC, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface NKJAENBOIPA
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MAGEDDBMFEP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class HIGKBLPNFMH<T> : JICDMGFPJIM<T>, NOOAOCGPJIA<T>, FHMCAMOMJOP<T>, IHCAHILICGC, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class GLIOJJJEIMF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public HIGKBLPNFMH<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public GLIOJJJEIMF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x4F62FC0", Offset = "0x4F623C0", VA = "0x184F62FC0")]
			internal void CHCOOHFKFHN(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x3DB9210", Offset = "0x3DB8610", VA = "0x183DB9210")]
			internal void KAGNNAFOLGP(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private JAKNEJKGEIC<T> ONEEBFLKONK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool EJDCKMAGDLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T CDEDDCLKCCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool GJNOCMLAONB;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4FDAE30", Offset = "0x4FDA230", VA = "0x184FDAE30")]
		public HIGKBLPNFMH(JAKNEJKGEIC<T> ONEEBFLKONK, ObjectPool EJDCKMAGDLL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4FDACF0", Offset = "0x4FDA0F0", VA = "0x184FDACF0", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class NFIJMKHGPEK<T> : HJHGLMLAFFL, MEJGKJGLFKJ<T>, IHCAHILICGC, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class DLIEEOMEADJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public NFIJMKHGPEK<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public DLIEEOMEADJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x4562CD0", Offset = "0x45620D0", VA = "0x184562CD0")]
			internal void CHCOOHFKFHN(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x16A4B40", Offset = "0x16A3F40", VA = "0x1816A4B40")]
			internal void KAGNNAFOLGP(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private JAKNEJKGEIC<T> ONEEBFLKONK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool GJNOCMLAONB;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x57F5A40", Offset = "0x57F4E40", VA = "0x1857F5A40")]
		public NFIJMKHGPEK(JAKNEJKGEIC<T> ONEEBFLKONK, ObjectPool EJDCKMAGDLL, int JLBPCPLEEBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x57F59E0", Offset = "0x57F4DE0", VA = "0x1857F59E0", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class APCDHACHEKL<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public MAGEDDBMFEP <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public JICDMGFPJIM<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public JAKNEJKGEIC<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public APCDHACHEKL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x53A9F50", Offset = "0x53A9350", VA = "0x1853A9F50")]
		internal void OLDKFPKBIPG(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x53A9EA0", Offset = "0x53A92A0", VA = "0x1853A9EA0")]
		internal void CAPGGHLBNFM(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x53A9F00", Offset = "0x53A9300", VA = "0x1853A9F00")]
		internal void MIBKEGOAMPE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<NKJAENBOIPA> LFFNLMADIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private ABHEAHKJBID NAMECGLBJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool EJDCKMAGDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool GJNOCMLAONB;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x86601A0", Offset = "0x865F5A0", VA = "0x1886601A0")]
	private static void LCKGOOBODPO(Component FCIHIIPNCLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8660480", Offset = "0x865F880", VA = "0x188660480")]
	public MAGEDDBMFEP(string OGMPNBFOIII, int FNHHBIIEPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3DDF6A0", Offset = "0x3DDEAA0", VA = "0x183DDF6A0")]
	public NOOAOCGPJIA<T> OGMDNDFHLGF<T>(AssetReference FIGPNLNBDKH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3DDF5F0", Offset = "0x3DDE9F0", VA = "0x183DDF5F0")]
	public MEJGKJGLFKJ<T> NANPIDKMCMK<T>(AssetReference FIGPNLNBDKH, int PPNAGMANAKJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3DDF1F0", Offset = "0x3DDE5F0", VA = "0x183DDF1F0")]
	public FHMCAMOMJOP<bool> KNLAECGHIJO<T>(AssetReference FIGPNLNBDKH) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x865FDD0", Offset = "0x865F1D0", VA = "0x18865FDD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8660050", Offset = "0x865F450", VA = "0x188660050")]
	private void FPAJLMFNCAK(UnityEngine.Object OBIOPHMKHBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x865FEC0", Offset = "0x865F2C0", VA = "0x18865FEC0")]
	private ObjectPool EGMAOCDAFIG(string OGMPNBFOIII)
	{
		return null;
	}
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class GlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static GlobalPool OMAABCNJOHH;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject KPOONBHGPJN;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static GlobalPool NKAKNKMIPPI
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x865FBA0", Offset = "0x865EFA0", VA = "0x18865FBA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3CBC7A0", Offset = "0x3CBBBA0", VA = "0x183CBC7A0")]
		public static void SafeRelease<T>(T DEJGDIIDCDN) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x865FAD0", Offset = "0x865EED0", VA = "0x18865FAD0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x865FB90", Offset = "0x865EF90", VA = "0x18865FB90")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public readonly struct IMGFIHKDEGP<T> : IDisposable where T : Component
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private readonly T OMMONOBJAMN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private readonly ObjectPool ONFDFPDBLBF;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public T JCMAOCOGHGO
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0xAF6920", Offset = "0xAF5D20", VA = "0x180AF6920")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xBFDA60", Offset = "0xBFCE60", VA = "0x180BFDA60")]
			internal IMGFIHKDEGP(T CBMEHPPMEEA, ObjectPool ONFDFPDBLBF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x50F05D0", Offset = "0x50EF9D0", VA = "0x1850F05D0", Slot = "4")]
			void IDisposable.Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, EBDOFDOAPJF> PMPEDBLKBJK;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3EC2850", Offset = "0x3EC1C50", VA = "0x183EC2850")]
		public T Acquire<T>(T MKFMLBCIMEB, [Optional] Action<Component> JHCIAKAIBLK) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3EC27D0", Offset = "0x3EC1BD0", VA = "0x183EC27D0")]
		public IMGFIHKDEGP<T> AcquirePooledObject<T>(T MKFMLBCIMEB, [Optional] Action<Component> JHCIAKAIBLK) where T : Component
		{
			return default(IMGFIHKDEGP<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3EC2BC0", Offset = "0x3EC1FC0", VA = "0x183EC2BC0")]
		public bool Release<T>(T DEJGDIIDCDN) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3EC2B70", Offset = "0x3EC1F70", VA = "0x183EC2B70")]
		public void Prefill<T>(T MKFMLBCIMEB, int PJCNIGABPEE, [Optional] Action<Component> OGCFCFONDNF) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3EC2AD0", Offset = "0x3EC1ED0", VA = "0x183EC2AD0")]
		public bool Exists<T>(T MKFMLBCIMEB) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3EC28E0", Offset = "0x3EC1CE0", VA = "0x183EC28E0")]
		public void Clear<T>(T MKFMLBCIMEB) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8660A90", Offset = "0x865FE90", VA = "0x188660A90")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3EC2990", Offset = "0x3EC1D90", VA = "0x183EC2990")]
		private EBDOFDOAPJF DPGJENFDDGE<T>(T MKFMLBCIMEB) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public void TrackInstantiation(string FNIEPGCGHKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public void EnableStats(bool NCDFKAPPCAN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8660C00", Offset = "0x8660000", VA = "0x188660C00")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public abstract class EBDOFDOAPJF
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public interface DMHONICJPOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void LPIFOOFNPPM(bool BAMGENIDGGK);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract int DDJHLFAOKBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void NANPIDKMCMK(int PPNAGMANAKJ, Action<Component> OGCFCFONDNF);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component OGMDNDFHLGF(Action<Component> JHCIAKAIBLK);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool LLLHPAIEGMF(Component IAGOCCCICAO);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void HBLMHKLDBPD();

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x865F950", Offset = "0x865ED50", VA = "0x18865F950")]
	protected void KCIHHNEJELD(Component DEJGDIIDCDN, bool BAMGENIDGGK, bool POEPCBMCFGD, bool IAHMKNHLANA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x865F6D0", Offset = "0x865EAD0", VA = "0x18865F6D0")]
	protected void EBJHKCFHHJF(Transform FJCDPDLLJIB, bool BAMGENIDGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	protected EBDOFDOAPJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class GCEJGBFGALF<T> : EBDOFDOAPJF where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private T MKFMLBCIMEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private ObjectPool AMCLPEKGIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private bool POEPCBMCFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private Queue<T> OIOMCILNABD;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override string GODGCHFEMGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x4F40A70", Offset = "0x4F3FE70", VA = "0x184F40A70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override int DDJHLFAOKBI
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4F40410", Offset = "0x4F3F810", VA = "0x184F40410", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4F40CF0", Offset = "0x4F400F0", VA = "0x184F40CF0")]
	public GCEJGBFGALF(T MKFMLBCIMEB, ObjectPool AMCLPEKGIEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4F40970", Offset = "0x4F3FD70", VA = "0x184F40970", Slot = "6")]
	public override void NANPIDKMCMK(int PPNAGMANAKJ, Action<Component> JHCIAKAIBLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x4F40A90", Offset = "0x4F3FE90", VA = "0x184F40A90", Slot = "7")]
	public override Component OGMDNDFHLGF(Action<Component> JHCIAKAIBLK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x4F40630", Offset = "0x4F3FA30", VA = "0x184F40630", Slot = "8")]
	public override bool LLLHPAIEGMF(Component IAGOCCCICAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4F40450", Offset = "0x4F3F850", VA = "0x184F40450", Slot = "9")]
	public override void HBLMHKLDBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4F407C0", Offset = "0x4F3FBC0", VA = "0x184F407C0")]
	private T LNAJJFHLPBD()
	{
		return null;
	}
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class ObjectPoolPreFill : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public struct PrefillDataEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public Component prefab;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public int numInstances;
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public interface PKAEDJKBGGF
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			GameObject CHBFNEOBGOP
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public List<PrefillDataEntry> PrefillData;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8660710", Offset = "0x865FB10", VA = "0x188660710")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8660A00", Offset = "0x865FE00", VA = "0x188660A00")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private static PersistentGlobalPool OMAABCNJOHH;

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static GameObject KPOONBHGPJN;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static PersistentGlobalPool NKAKNKMIPPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x8660D50", Offset = "0x8660150", VA = "0x188660D50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8660C90", Offset = "0x8660090", VA = "0x188660C90")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x865FB90", Offset = "0x865EF90", VA = "0x18865FB90")]
		public PersistentGlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class PooledObject : MonoBehaviour
	{
		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public EBDOFDOAPJF PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED60", Offset = "0xA6E160", VA = "0x180A6ED60")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface FMANGPJGCHG
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int LAONBAKHBFK(PooledParticle.HHDIIHEFBOA AEKNMLHGMDI);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		private enum AHLNHLACFDE
		{
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			NONE,
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			POSITION,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			ROTATION,
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			POSITION_AND_ROTATION,
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			VELOCITY
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public enum HHDIIHEFBOA
		{
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			GAMEPLAY_CRITICAL = 1,
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			GAMEPLAY_HIGH_PRI = 2,
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			GAMEPLAY_LOW_PRI = 3,
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			SOCIAL_FEEDBACK = 4,
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			DEFAULT = 0
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public interface POJAKPMLOJE
		{
			[Cpp2IlInjected.Token(Token = "0x17000014")]
			bool LOBCKFGOAHE
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Vector3 LCMMEBCGOGM
			{
				[Cpp2IlInjected.Token(Token = "0x600007E")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			Camera JCEIKNKKKLC
			{
				[Cpp2IlInjected.Token(Token = "0x600007F")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public class ColorConfiguration
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			[SerializeField]
			private ParticleSystem particleSystem;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			[SerializeField]
			private bool setStartColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			[SerializeField]
			private bool setMinColorOverLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			[SerializeField]
			private bool setMaxColorOverLifetime;

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x7200E10", Offset = "0x7200210", VA = "0x187200E10")]
			public ColorConfiguration(ParticleSystem FNDOCCJHDNI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x865F4E0", Offset = "0x865E8E0", VA = "0x18865F4E0")]
			public void FEBHBPCBCFF(Color IFBOGFLAOGG)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class AKJPGBJLNKJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public AKJPGBJLNKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x865EE40", Offset = "0x865E240", VA = "0x18865EE40")]
			internal void HMLLKHACDIK(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class BGAMEPHGODM : IEnumerator<KHJLACPAINM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private KHJLACPAINM <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private POJAKPMLOJE <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			private KHJLACPAINM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xA7AA30", Offset = "0xA79E30", VA = "0x180A7AA30")]
			[DebuggerHidden]
			public BGAMEPHGODM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x865EE70", Offset = "0x865E270", VA = "0x18865EE70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x865F490", Offset = "0x865E890", VA = "0x18865F490", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class LJPIIIBLICD : IEnumerator<KHJLACPAINM>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			private KHJLACPAINM <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private KHJLACPAINM System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000097")]
				[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xA7AA30", Offset = "0xA79E30", VA = "0x180A7AA30")]
			[DebuggerHidden]
			public LJPIIIBLICD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x865FD10", Offset = "0x865F110", VA = "0x18865FD10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x865FD80", Offset = "0x865F180", VA = "0x18865FD80", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public static bool OptimizeReleaseMonitoring;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> MKOALGEOMOB;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly Lazy<FMANGPJGCHG> AILJHPOAEPC;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static List<PooledParticle> EEBANGOBNOK;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static LDBPABGAEKE KKNCIIGPIJJ;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const float PJHBPBEEIGA = 1f;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static bool LPCLMDINKEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		protected int PECGMOHCCJH;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private HHDIIHEFBOA category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		protected ColorConfiguration[] colorConfigurations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float? MFJJKMEMMKO;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public bool IsLooping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private ParticleSystem.MinMaxGradient[] DDBKOGGNPOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private ParticleSystem.MinMaxGradient[] NAOKAIOMMIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private bool EFKFMABLEHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private float DPMCACLNGAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private float AHPCDANEGKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private Transform HAMAGJACAEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private Vector3 BOBMDLANDIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Vector3 ELAHDHLDLPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private AHLNHLACFDE IOJGJHPOMEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private LDBPABGAEKE NCEEGDCOLKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		protected bool NGFAEDEEOCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private Transform IHGGOBCKNGM;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static IEnumerable<PooledParticle> DKHFNKOKFCO
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8665160", Offset = "0x8664560", VA = "0x188665160")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public HHDIIHEFBOA FMLJOKNLKHP
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xA97100", Offset = "0xA96500", VA = "0x180A97100")]
			get
			{
				return default(HHDIIHEFBOA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int DKICBAMGKKK
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA72120", Offset = "0xA71520", VA = "0x180A72120")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool HDAANLJCHBA
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x8664E90", Offset = "0x8664290", VA = "0x188664E90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static int NKLLHCEENKL
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x8665010", Offset = "0x8664410", VA = "0x188665010")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected static bool IKBLPKOIPIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x86626A0", Offset = "0x8661AA0", VA = "0x1886626A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem LBJOODFNIFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA78E10", Offset = "0xA78210", VA = "0x180A78E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ParticleSystem[] LAMICPEBFON
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private ParticleSystemRenderer[] CJJHBMOGLFI
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA702C0", Offset = "0xA6F6C0", VA = "0x180A702C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private AHLNHLACFDE ALMMODLIFAK
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xF001C0", Offset = "0xEFF5C0", VA = "0x180F001C0")]
			get
			{
				return default(AHLNHLACFDE);
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8662680", Offset = "0x8661A80", VA = "0x188662680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public Transform GANAIKEBLIG
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x86651B0", Offset = "0x86645B0", VA = "0x1886651B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action PGAKOPDGIFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x8664DF0", Offset = "0x86641F0", VA = "0x188664DF0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x8665200", Offset = "0x8664600", VA = "0x188665200")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x8664800", Offset = "0x8663C00", VA = "0x188664800")]
		public static PooledParticle TryPlayPrefab(PooledParticle MKFMLBCIMEB, Vector3 LBCFHLNAPLC, Quaternion EMLGDFFEJED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8664920", Offset = "0x8663D20", VA = "0x188664920")]
		public static PooledParticle TryPlayPrefab(PooledParticle MKFMLBCIMEB, Vector3 LBCFHLNAPLC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8663F10", Offset = "0x8663310", VA = "0x188663F10")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8662C40", Offset = "0x8662040", VA = "0x188662C40")]
		private void LMMMMAHKOBD(bool MOELHOCKLNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8663140", Offset = "0x8662540", VA = "0x188663140")]
		[IteratorStateMachine(typeof(BGAMEPHGODM))]
		private static IEnumerator<KHJLACPAINM> OLDFKMOAKEJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8662310", Offset = "0x8661710", VA = "0x188662310")]
		private static void FOFLBAMJBDM(Stopwatch LLOEFCNKADN, Vector3 CNEBBJFNONE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8661B30", Offset = "0x8660F30", VA = "0x188661B30")]
		private static int DPMAGKCHKKD(PooledParticle KEHFCBFJCMA, PooledParticle KGECIONKOCO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8662930", Offset = "0x8661D30", VA = "0x188662930")]
		private static int LAONBAKHBFK(HHDIIHEFBOA AEKNMLHGMDI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x86617B0", Offset = "0x8660BB0", VA = "0x1886617B0")]
		protected void DIKEAPPJOIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8661D10", Offset = "0x8661110", VA = "0x188661D10")]
		protected void FABDLAOAKJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8661470", Offset = "0x8660870", VA = "0x188661470", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8662D10", Offset = "0x8662110", VA = "0x188662D10")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x86631A0", Offset = "0x86625A0", VA = "0x1886631A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x86630B0", Offset = "0x86624B0", VA = "0x1886630B0")]
		[IteratorStateMachine(typeof(LJPIIIBLICD))]
		private IEnumerator<KHJLACPAINM> OKLIMDPMOAC(float DLCLIHPGOLF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8662A40", Offset = "0x8661E40", VA = "0x188662A40")]
		private void LLLHPAIEGMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8664540", Offset = "0x8663940", VA = "0x188664540")]
		public void SetDuration(float DLCLIHPGOLF, bool APOKKKEENEF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8663230", Offset = "0x8662630", VA = "0x188663230")]
		public void Play(Transform GBAMNGGLOLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8663AE0", Offset = "0x8662EE0", VA = "0x188663AE0")]
		public void Play(Transform GBAMNGGLOLF, bool DCLOMOKIKMO, float HIIBMDMNJDP = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8663390", Offset = "0x8662790", VA = "0x188663390")]
		public void Play(Transform GBAMNGGLOLF, Vector3 ELAHDHLDLPL, bool DCLOMOKIKMO, float HIIBMDMNJDP = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x86634E0", Offset = "0x86628E0", VA = "0x1886634E0")]
		public void Play(Transform GOGPNEANHLN, Quaternion EMLGDFFEJED, bool DCLOMOKIKMO = false, float HIIBMDMNJDP = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8663C50", Offset = "0x8663050", VA = "0x188663C50")]
		public void Play(Transform GOGPNEANHLN, Vector3 ELAHDHLDLPL, Quaternion EMLGDFFEJED, bool DCLOMOKIKMO = false, float HIIBMDMNJDP = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8663780", Offset = "0x8662B80", VA = "0x188663780")]
		public void Play(Vector3 LBCFHLNAPLC, Quaternion EMLGDFFEJED, Vector3 PODFFOEBFLC, bool DCLOMOKIKMO = false, float HIIBMDMNJDP = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8663620", Offset = "0x8662A20", VA = "0x188663620")]
		public void Play(Vector3 LBCFHLNAPLC, Quaternion EMLGDFFEJED, bool DCLOMOKIKMO = false, float HIIBMDMNJDP = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8663900", Offset = "0x8662D00", VA = "0x188663900")]
		public void Play(bool DCLOMOKIKMO = false, float HIIBMDMNJDP = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x8664760", Offset = "0x8663B60", VA = "0x188664760")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x8664610", Offset = "0x8663A10", VA = "0x188664610")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x86619A0", Offset = "0x8660DA0", VA = "0x1886619A0")]
		private void DJBGNFCAEJK(float DLCLIHPGOLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8662720", Offset = "0x8661B20", VA = "0x188662720")]
		private void KBHKENMMJOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8663D80", Offset = "0x8663180", VA = "0x188663D80")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8664090", Offset = "0x8663490", VA = "0x188664090")]
		public void SetColor(Color IFBOGFLAOGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x86616F0", Offset = "0x8660AF0", VA = "0x1886616F0")]
		private void BFGGFLNICEM(float? GIKDKPMHFDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8663040", Offset = "0x8662440", VA = "0x188663040")]
		private void NBFIHDLGHDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8661BE0", Offset = "0x8660FE0", VA = "0x188661BE0")]
		private void FAABKJEIPGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8664D50", Offset = "0x8664150", VA = "0x188664D50")]
		public PooledParticle()
		{
		}
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
