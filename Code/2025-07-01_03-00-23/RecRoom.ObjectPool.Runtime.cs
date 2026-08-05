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
		[Cpp2IlInjected.Address(RVA = "0x8355A80", Offset = "0x8354080", VA = "0x188355A80")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles KFAEMGBGGCC, float NJNOHHHLPDJ, Vector3 NHLFNDFGAHK, Quaternion CFFPEJBOBIA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8355720", Offset = "0x8353D20", VA = "0x188355720")]
		public void SetDamageValue(float NJNOHHHLPDJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8355BC0", Offset = "0x83541C0", VA = "0x188355BC0")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KKOGGIBFIEA<T> : EHBLMFNEKIG<T>, NCBJFOCOMOJ, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface KKBOIHCMGCF<T> : NCBJFOCOMOJ, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface HAEEDKEGHML
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class IFIHDFNEAPL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class KCAKONKFLBB<T> : JHKDGOCDKKC<T>, KKOGGIBFIEA<T>, EHBLMFNEKIG<T>, NCBJFOCOMOJ, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class OHJDGCDFPLH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public KCAKONKFLBB<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public OHJDGCDFPLH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x57CE670", Offset = "0x57CCC70", VA = "0x1857CE670")]
			internal void NFGNFMIJEJA(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x3D8CD10", Offset = "0x3D8B310", VA = "0x183D8CD10")]
			internal void FFKCNBPCPMP(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MODONOMENDG<T> FIHDOPJOKIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool MGOECPNDODO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T EFKLKBOLJNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool DNDJADKEJII;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5290120", Offset = "0x528E720", VA = "0x185290120")]
		public KCAKONKFLBB(MODONOMENDG<T> FIHDOPJOKIO, ObjectPool MGOECPNDODO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x528FFE0", Offset = "0x528E5E0", VA = "0x18528FFE0", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class ICAFGKDBDIN<T> : KIAJLCGDOBP, KKBOIHCMGCF<T>, NCBJFOCOMOJ, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class HAHECOMPINL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public ICAFGKDBDIN<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public HAHECOMPINL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x4DD3FA0", Offset = "0x4DD25A0", VA = "0x184DD3FA0")]
			internal void NFGNFMIJEJA(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x15C2E60", Offset = "0x15C1460", VA = "0x1815C2E60")]
			internal void FFKCNBPCPMP(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private MODONOMENDG<T> FIHDOPJOKIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool DNDJADKEJII;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4F46D90", Offset = "0x4F45390", VA = "0x184F46D90")]
		public ICAFGKDBDIN(MODONOMENDG<T> FIHDOPJOKIO, ObjectPool MGOECPNDODO, int PCGDBLKKPKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4F46D30", Offset = "0x4F45330", VA = "0x184F46D30", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class DGPPMEILIPH<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public IFIHDFNEAPL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public JHKDGOCDKKC<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public MODONOMENDG<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public DGPPMEILIPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6CD5820", Offset = "0x6CD3E20", VA = "0x186CD5820")]
		internal void EAECGNCKJIM(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6CD5770", Offset = "0x6CD3D70", VA = "0x186CD5770")]
		internal void CFIPHEPNKJE(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6CD57D0", Offset = "0x6CD3DD0", VA = "0x186CD57D0")]
		internal void DDJOGOOILAN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<HAEEDKEGHML> DCKKCKGBAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EMOFEHENLBC KODPLPBCPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool MGOECPNDODO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool DNDJADKEJII;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8354020", Offset = "0x8352620", VA = "0x188354020")]
	private static void BCBMFIKOANM(Component DNCHHBPCLHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8354580", Offset = "0x8352B80", VA = "0x188354580")]
	public IFIHDFNEAPL(string JNBBFCFPNMI, int KGOFPCKAPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3B7D330", Offset = "0x3B7B930", VA = "0x183B7D330")]
	public KKOGGIBFIEA<T> PMCFFHGKNGL<T>(AssetReference NENONFJNKDF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3B7D280", Offset = "0x3B7B880", VA = "0x183B7D280")]
	public KKBOIHCMGCF<T> IINFFFFNIGB<T>(AssetReference NENONFJNKDF, int FOAMCIPOLAA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3B7CE80", Offset = "0x3B7B480", VA = "0x183B7CE80")]
	public EHBLMFNEKIG<bool> FMHHEEPBJPF<T>(AssetReference NENONFJNKDF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8354270", Offset = "0x8352870", VA = "0x188354270", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8353ED0", Offset = "0x83524D0", VA = "0x188353ED0")]
	private void ALGFAGCBIEG(UnityEngine.Object BLEJDLNCGOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8354360", Offset = "0x8352960", VA = "0x188354360")]
	private ObjectPool FBNLLAINCON(string JNBBFCFPNMI)
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
		private static GlobalPool CNPKAEPPLJM;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject CFMHECACAJK;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static GlobalPool FNIBPMLJKFE
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8353D60", Offset = "0x8352360", VA = "0x188353D60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3B5C520", Offset = "0x3B5AB20", VA = "0x183B5C520")]
		public static void SafeRelease<T>(T ODCICEDDLMB) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8353C90", Offset = "0x8352290", VA = "0x188353C90")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8353D50", Offset = "0x8352350", VA = "0x188353D50")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, EFDILLAHDFI> FBIOGOHHPKO;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3CF34E0", Offset = "0x3CF1AE0", VA = "0x183CF34E0")]
		public T Acquire<T>(T KFAEMGBGGCC, [Optional] Action<Component> BLFNDAJJABA) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3CF3850", Offset = "0x3CF1E50", VA = "0x183CF3850")]
		public bool Release<T>(T ODCICEDDLMB) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3CF3800", Offset = "0x3CF1E00", VA = "0x183CF3800")]
		public void Prefill<T>(T KFAEMGBGGCC, int MKAGEJAPMIL, [Optional] Action<Component> AHLEGHOBPKG) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3CF3620", Offset = "0x3CF1C20", VA = "0x183CF3620")]
		public bool Exists<T>(T KFAEMGBGGCC) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3CF3570", Offset = "0x3CF1B70", VA = "0x183CF3570")]
		public void Clear<T>(T KFAEMGBGGCC) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x83552C0", Offset = "0x83538C0", VA = "0x1883552C0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3CF36C0", Offset = "0x3CF1CC0", VA = "0x183CF36C0")]
		private EFDILLAHDFI NOCKDJKNGJL<T>(T KFAEMGBGGCC) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public void TrackInstantiation(string OKBNKGCJLAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public void EnableStats(bool BMOIDPNKBCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x8355430", Offset = "0x8353A30", VA = "0x188355430")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class EFDILLAHDFI
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface NPLGIHKNNLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BBDBFPGCPNC(bool FHAKDPIOOJJ);
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public abstract string GKIMNFGPLMB
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract int NDGODKDALNF
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void IINFFFFNIGB(int FOAMCIPOLAA, Action<Component> AHLEGHOBPKG);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component PMCFFHGKNGL(Action<Component> BLFNDAJJABA);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool MFOHPABGFFE(Component NCBHPDBBCIG);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void HHCEOPNNHLH();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x8353890", Offset = "0x8351E90", VA = "0x188353890")]
	protected void FLDIDLGPPPF(Component ODCICEDDLMB, bool FHAKDPIOOJJ, bool KKMBCBIHIHI, bool PNHKFFGPMMP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x8353A10", Offset = "0x8352010", VA = "0x188353A10")]
	protected void GFAFIJOCAML(Transform BGODKGDLDAH, bool FHAKDPIOOJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	protected EFDILLAHDFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JDKOIGPDLNF<T> : EFDILLAHDFI where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T KFAEMGBGGCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool AFHOHCHJMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool KKMBCBIHIHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> KNOPLFPBMMO;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public override string GKIMNFGPLMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5189270", Offset = "0x5187870", VA = "0x185189270", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override int NDGODKDALNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x5189230", Offset = "0x5187830", VA = "0x185189230", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5189B50", Offset = "0x5188150", VA = "0x185189B50")]
	public JDKOIGPDLNF(T KFAEMGBGGCC, ObjectPool AFHOHCHJMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5189630", Offset = "0x5187C30", VA = "0x185189630", Slot = "6")]
	public override void IINFFFFNIGB(int FOAMCIPOLAA, Action<Component> BLFNDAJJABA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x51898E0", Offset = "0x5187EE0", VA = "0x1851898E0", Slot = "7")]
	public override Component PMCFFHGKNGL(Action<Component> BLFNDAJJABA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5189740", Offset = "0x5187D40", VA = "0x185189740", Slot = "8")]
	public override bool MFOHPABGFFE(Component NCBHPDBBCIG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5189290", Offset = "0x5187890", VA = "0x185189290", Slot = "9")]
	public override void HHCEOPNNHLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5189480", Offset = "0x5187A80", VA = "0x185189480")]
	private T HOGLKDCCHAC()
	{
		return null;
	}
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class ObjectPoolPreFill : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public struct PrefillDataEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public Component prefab;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public int numInstances;
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public interface PPJIELNMKAF
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			GameObject MPFPEEAEPEG
			{
				[Cpp2IlInjected.Token(Token = "0x600003F")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public List<PrefillDataEntry> PrefillData;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x8354F40", Offset = "0x8353540", VA = "0x188354F40")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8355230", Offset = "0x8353830", VA = "0x188355230")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool CNPKAEPPLJM;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject CFMHECACAJK;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static PersistentGlobalPool FNIBPMLJKFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x8355580", Offset = "0x8353B80", VA = "0x188355580")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x83554C0", Offset = "0x8353AC0", VA = "0x1883554C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8353D50", Offset = "0x8352350", VA = "0x188353D50")]
		public PersistentGlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class PooledObject : MonoBehaviour
	{
		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public EFDILLAHDFI PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA469E0", Offset = "0xA44FE0", VA = "0x180A469E0")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface BOLHAAMPJPA
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int HLEGGPJPJCC(PooledParticle.PHEHFMBDBKO BAIHHLMIMOE);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum BOFFGOFACBP
		{
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			NONE,
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			POSITION,
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			ROTATION,
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			POSITION_AND_ROTATION,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			VELOCITY
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public enum PHEHFMBDBKO
		{
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			GAMEPLAY_CRITICAL = 1,
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			GAMEPLAY_HIGH_PRI = 2,
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			GAMEPLAY_LOW_PRI = 3,
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			SOCIAL_FEEDBACK = 4,
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			DEFAULT = 0
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public interface IBHDLAMABIM
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			bool EAMDHIMAAIC
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Vector3 ODIKICAFNNL
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Camera BHKPFBJAIBE
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public class ColorConfiguration
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			[SerializeField]
			private ParticleSystem particleSystem;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			[SerializeField]
			private bool setStartColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			[SerializeField]
			private bool setMinColorOverLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			[SerializeField]
			private bool setMaxColorOverLifetime;

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x6F531A0", Offset = "0x6F517A0", VA = "0x186F531A0")]
			public ColorConfiguration(ParticleSystem NKLLDDFIGPN)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x8353670", Offset = "0x8351C70", VA = "0x188353670")]
			public void IMFGGCLPHDH(Color HFIMNHFKOFL)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class DGIKIPEPHJK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
			public DGIKIPEPHJK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x8353860", Offset = "0x8351E60", VA = "0x188353860")]
			internal void IOBNLPGFLIH(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class INJLMMGLNKD : IEnumerator<HPILNDONOCO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private HPILNDONOCO <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private IBHDLAMABIM <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private HPILNDONOCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xA4C2C0", Offset = "0xA4A8C0", VA = "0x180A4C2C0")]
			[DebuggerHidden]
			public INJLMMGLNKD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x8354810", Offset = "0x8352E10", VA = "0x188354810", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x8354E30", Offset = "0x8353430", VA = "0x188354E30", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class KPBEIIHJODC : IEnumerator<HPILNDONOCO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private HPILNDONOCO <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private HPILNDONOCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xA4C2C0", Offset = "0xA4A8C0", VA = "0x180A4C2C0")]
			[DebuggerHidden]
			public KPBEIIHJODC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x8354E80", Offset = "0x8353480", VA = "0x188354E80", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x8354EF0", Offset = "0x83534F0", VA = "0x188354EF0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public static bool OptimizeReleaseMonitoring;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> ODLAGHHKDJF;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Lazy<BOLHAAMPJPA> MDEGLDACHNF;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static List<PooledParticle> NCAEONKLALB;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static LLKKGNCPLNM HNKIONACMKH;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const float ABAKBJIOLNJ = 1f;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static bool IANNKJELEEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		protected int DKIMBBBGMDL;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private PHEHFMBDBKO category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		protected ColorConfiguration[] colorConfigurations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private float? MEIBFCLBIEE;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public bool IsLooping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private ParticleSystem.MinMaxGradient[] CKEPCIGLLGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private ParticleSystem.MinMaxGradient[] AOKFKAPDDIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool NPJJLALJLCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private float CBHDGPPDHEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private float NDLMEFHLCFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private Transform AJHFIJHLIEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private Vector3 MIHBJKEOMKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private Vector3 KBAKFGJGMGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private BOFFGOFACBP CDAHCEGMCEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private LLKKGNCPLNM JDFDLMHBKAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		protected bool PMBDODNIDPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private Transform NIHFOINEKDF;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static IEnumerable<PooledParticle> OOFHNIBDKJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x83599A0", Offset = "0x8357FA0", VA = "0x1883599A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public PHEHFMBDBKO PKMOLLDNDCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA6D9C0", Offset = "0xA6BFC0", VA = "0x180A6D9C0")]
			get
			{
				return default(PHEHFMBDBKO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int KFAJPJNHKPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA4C4A0", Offset = "0xA4AAA0", VA = "0x180A4C4A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool BKEBDEOALME
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x83596D0", Offset = "0x8357CD0", VA = "0x1883596D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static int LCAHEEDIOLM
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x8359850", Offset = "0x8357E50", VA = "0x188359850")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected static bool GEKEPNEEEPN
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x8356F80", Offset = "0x8355580", VA = "0x188356F80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ParticleSystem IJCHMOFIMFF
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA47A10", Offset = "0xA46010", VA = "0x180A47A10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem[] ODJOLBEHAPA
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private ParticleSystemRenderer[] CKNPFLELLMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA50E00", Offset = "0xA4F400", VA = "0x180A50E00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private BOFFGOFACBP LHOONJIGLLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xE746E0", Offset = "0xE72CE0", VA = "0x180E746E0")]
			get
			{
				return default(BOFFGOFACBP);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x8357530", Offset = "0x8355B30", VA = "0x188357530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Transform DFOHJKCGEGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x83599F0", Offset = "0x8357FF0", VA = "0x1883599F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action NIBLANPODGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x8359630", Offset = "0x8357C30", VA = "0x188359630")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x8359A40", Offset = "0x8358040", VA = "0x188359A40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8359040", Offset = "0x8357640", VA = "0x188359040")]
		public static PooledParticle TryPlayPrefab(PooledParticle KFAEMGBGGCC, Vector3 NHLFNDFGAHK, Quaternion CFFPEJBOBIA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8359160", Offset = "0x8357760", VA = "0x188359160")]
		public static PooledParticle TryPlayPrefab(PooledParticle KFAEMGBGGCC, Vector3 NHLFNDFGAHK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x8358750", Offset = "0x8356D50", VA = "0x188358750")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x8356A00", Offset = "0x8355000", VA = "0x188356A00")]
		private void ELCLJPNLMAL(bool IKCKHHEBILP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x8356630", Offset = "0x8354C30", VA = "0x188356630")]
		[IteratorStateMachine(typeof(INJLMMGLNKD))]
		private static IEnumerator<HPILNDONOCO> DMKOEGPGAGD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x8356690", Offset = "0x8354C90", VA = "0x188356690")]
		private static void DPNGMMNMJFF(Stopwatch GPIJGKLDGAC, Vector3 AJOAOIEBODI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x8357550", Offset = "0x8355B50", VA = "0x188357550")]
		private static int NEBDNPKHOIG(PooledParticle IAPIHBICBOE, PooledParticle FJDIHEBKFED)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x8356AD0", Offset = "0x83550D0", VA = "0x188356AD0")]
		private static int HLEGGPJPJCC(PHEHFMBDBKO BAIHHLMIMOE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x8357880", Offset = "0x8355E80", VA = "0x188357880")]
		protected void PKFKCHPNAME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8356020", Offset = "0x8354620", VA = "0x188356020")]
		protected void DFGJHDALGDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x8355CA0", Offset = "0x83542A0", VA = "0x188355CA0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x8357000", Offset = "0x8355600", VA = "0x188357000")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x83577F0", Offset = "0x8355DF0", VA = "0x1883577F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8355F90", Offset = "0x8354590", VA = "0x188355F90")]
		[IteratorStateMachine(typeof(KPBEIIHJODC))]
		private IEnumerator<HPILNDONOCO> CNINACGHNIO(float EMDIBPDBFEG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x8357330", Offset = "0x8355930", VA = "0x188357330")]
		private void MFOHPABGFFE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x8358D80", Offset = "0x8357380", VA = "0x188358D80")]
		public void SetDuration(float EMDIBPDBFEG, bool LDOCHAGGDKA = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8357A70", Offset = "0x8356070", VA = "0x188357A70")]
		public void Play(Transform FAGHFLKMDCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x8358320", Offset = "0x8356920", VA = "0x188358320")]
		public void Play(Transform FAGHFLKMDCP, bool POHMHAMGANA, float JJDLPLBOMKA = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x8357BD0", Offset = "0x83561D0", VA = "0x188357BD0")]
		public void Play(Transform FAGHFLKMDCP, Vector3 KBAKFGJGMGM, bool POHMHAMGANA, float JJDLPLBOMKA = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8357D20", Offset = "0x8356320", VA = "0x188357D20")]
		public void Play(Transform FNABALIAKGJ, Quaternion CFFPEJBOBIA, bool POHMHAMGANA = false, float JJDLPLBOMKA = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8358490", Offset = "0x8356A90", VA = "0x188358490")]
		public void Play(Transform FNABALIAKGJ, Vector3 KBAKFGJGMGM, Quaternion CFFPEJBOBIA, bool POHMHAMGANA = false, float JJDLPLBOMKA = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8357FC0", Offset = "0x83565C0", VA = "0x188357FC0")]
		public void Play(Vector3 NHLFNDFGAHK, Quaternion CFFPEJBOBIA, Vector3 OFCFOGHNCGN, bool POHMHAMGANA = false, float JJDLPLBOMKA = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8357E60", Offset = "0x8356460", VA = "0x188357E60")]
		public void Play(Vector3 NHLFNDFGAHK, Quaternion CFFPEJBOBIA, bool POHMHAMGANA = false, float JJDLPLBOMKA = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8358140", Offset = "0x8356740", VA = "0x188358140")]
		public void Play(bool POHMHAMGANA = false, float JJDLPLBOMKA = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8358FA0", Offset = "0x83575A0", VA = "0x188358FA0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8358E50", Offset = "0x8357450", VA = "0x188358E50")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x8356BE0", Offset = "0x83551E0", VA = "0x188356BE0")]
		private void IGMJBLANOGG(float EMDIBPDBFEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x8356D70", Offset = "0x8355370", VA = "0x188356D70")]
		private void KKIGGJDGLJO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x83585C0", Offset = "0x8356BC0", VA = "0x1883585C0")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x83588D0", Offset = "0x8356ED0", VA = "0x1883588D0")]
		public void SetColor(Color HFIMNHFKOFL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x8357730", Offset = "0x8355D30", VA = "0x188357730")]
		private void NOACOPAFHEL(float? PHDJLKIIBIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8355F20", Offset = "0x8354520", VA = "0x188355F20")]
		private void CGCFEJLNAGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8357600", Offset = "0x8355C00", VA = "0x188357600")]
		private void NGCFKFLKGEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8359590", Offset = "0x8357B90", VA = "0x188359590")]
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
