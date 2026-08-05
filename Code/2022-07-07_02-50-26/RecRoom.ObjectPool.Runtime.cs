using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
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
		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private float minDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private float maxDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		[Header("Impact Particle System")]
		private ParticleSystem impactParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		[Header("Impact Particle Start Size")]
		private float impactStartSizeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private float impactStartSizeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		[Header("Impact Particle Start Lifetime")]
		private float impactStartLifetimeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private float impactStartLifetimeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		[Header("Spray Particle System")]
		private ParticleSystem sprayParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		[Header("Spray Particle Burst Count")]
		private int sprayBurstCountMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private int sprayBurstCountMaxDamage;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5188CA0", Offset = "0x5187EA0", VA = "0x185188CA0")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles HAAOGJGGGGK, float PPMEJGICIEJ, Vector3 PNBJGABNCHL, Quaternion EOMKAGCDDCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5188A10", Offset = "0x5187C10", VA = "0x185188A10")]
		public void SetDamageValue(float PPMEJGICIEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5188E40", Offset = "0x5188040", VA = "0x185188E40")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HAFOIJBKFKJ<T> : global::FJLAHCBCPIJ<T>, KJNBDKOEMOC, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface MLBIFNHALOH<T> : KJNBDKOEMOC, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface EJDCNDODABP
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class COJLKNNGCOD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class MAHGPPPPNOJ<T> : global::EJFMGPECAAO<T>, global::HAFOIJBKFKJ<T>, global::FJLAHCBCPIJ<T>, KJNBDKOEMOC, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class MGGMEFHBOJI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public MAHGPPPPNOJ<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x1D6C580", Offset = "0x1D6B780", VA = "0x181D6C580")]
			public MGGMEFHBOJI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x408E5B0", Offset = "0x408D7B0", VA = "0x18408E5B0")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x321C950", Offset = "0x321BB50", VA = "0x18321C950")]
			internal void <.ctor>b__1(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private global::CECHLNGIBOA<T> ILKENBNGHGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool ILFDGFIENLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T BOEMCOCFPJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool KKMPIABJNOM;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x408E380", Offset = "0x408D580", VA = "0x18408E380")]
		public MAHGPPPPNOJ(global::CECHLNGIBOA<T> ILKENBNGHGK, ObjectPool ILFDGFIENLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x408E240", Offset = "0x408D440", VA = "0x18408E240", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class MJELLEMOBEP<T> : JLGLDFIOJOP, global::MLBIFNHALOH<T>, KJNBDKOEMOC, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class KGBPFDOGHOO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public MJELLEMOBEP<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x1D6C580", Offset = "0x1D6B780", VA = "0x181D6C580")]
			public KGBPFDOGHOO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x408E080", Offset = "0x408D280", VA = "0x18408E080")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x1A953B0", Offset = "0x1A945B0", VA = "0x181A953B0")]
			internal void <.ctor>b__1(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private global::CECHLNGIBOA<T> ILKENBNGHGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool KKMPIABJNOM;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x408E6F0", Offset = "0x408D8F0", VA = "0x18408E6F0")]
		public MJELLEMOBEP(global::CECHLNGIBOA<T> ILKENBNGHGK, ObjectPool ILFDGFIENLH, int PILIOHNHFMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x408E6A0", Offset = "0x408D8A0", VA = "0x18408E6A0", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class FPGDPCADLBO<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public COJLKNNGCOD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::EJFMGPECAAO<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::CECHLNGIBOA<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1D6C580", Offset = "0x1D6B780", VA = "0x181D6C580")]
		public FPGDPCADLBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x40892A0", Offset = "0x40884A0", VA = "0x1840892A0")]
		internal void <Exists>b__0(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4089330", Offset = "0x4088530", VA = "0x184089330")]
		internal void <Exists>b__1(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x4089390", Offset = "0x4088590", VA = "0x184089390")]
		internal void <Exists>b__2()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<EJDCNDODABP> BOPOONPKDDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private EEJHADDDFLO AIGJHAHDBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool ILFDGFIENLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool KKMPIABJNOM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ObjectPool APHNFNHKLNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5186430", Offset = "0x5185630", VA = "0x185186430")]
	private static void IDEEDBDHDFO(Component HELLEBCPPCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5186690", Offset = "0x5185890", VA = "0x185186690")]
	public COJLKNNGCOD(string JAFHCDMKNGJ, int BCEDKLBLGPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x208A8E0", Offset = "0x2089AE0", VA = "0x18208A8E0")]
	public global::HAFOIJBKFKJ<T> BOJMFGCMAEA<T>(AssetReference JMMOCDKBHMF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x208A970", Offset = "0x2089B70", VA = "0x18208A970")]
	public global::MLBIFNHALOH<T> NBIMBFLLBKO<T>(AssetReference JMMOCDKBHMF, int NAOLJMJHENM) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1C96B70", Offset = "0x1C95D70", VA = "0x181C96B70")]
	public global::FJLAHCBCPIJ<bool> BDOEAIKIIHP<T>(AssetReference JMMOCDKBHMF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x51861F0", Offset = "0x51853F0", VA = "0x1851861F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5186300", Offset = "0x5185500", VA = "0x185186300")]
	private void HNOPNCFAOAE(UnityEngine.Object KLPPBKNJNLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x51860A0", Offset = "0x51852A0", VA = "0x1851860A0")]
	private ObjectPool DDFGAEBEIAP(string JAFHCDMKNGJ)
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
		private static GlobalPool KCHMEDBFKBH;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject KLMCCLHJFLE;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GlobalPool LHIDCGAAEOA
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x5187090", Offset = "0x5186290", VA = "0x185187090")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x5186F40", Offset = "0x5186140", VA = "0x185186F40")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5187020", Offset = "0x5186220", VA = "0x185187020")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, DKBLFDGHMDM> DACFKMJJGMC;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x1F07440", Offset = "0x1F06640", VA = "0x181F07440")]
		public T Acquire<T>(T HAAOGJGGGGK, [Optional] Action<Component> DHEDMFBJCDB) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x23E41C0", Offset = "0x23E33C0", VA = "0x1823E41C0")]
		public bool Release<T>(T ANFJLMLDELH) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1CF0E60", Offset = "0x1CF0060", VA = "0x181CF0E60")]
		public void Prefill<T>(T HAAOGJGGGGK, int KLGPDPHCHKK, [Optional] Action<Component> FBGHDPPNNGN) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x23E4120", Offset = "0x23E3320", VA = "0x1823E4120")]
		public bool Exists<T>(T HAAOGJGGGGK) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x1CF0DC0", Offset = "0x1CEFFC0", VA = "0x181CF0DC0")]
		public void Clear<T>(T HAAOGJGGGGK) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5188630", Offset = "0x5187830", VA = "0x185188630")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1C9D7B0", Offset = "0x1C9C9B0", VA = "0x181C9D7B0")]
		private DKBLFDGHMDM FLCIIFCONMF<T>(T HAAOGJGGGGK) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80")]
		public void TrackInstantiation(string GFCLHECHAMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80")]
		public void EnableStats(bool PGJPPJDHIJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5187020", Offset = "0x5186220", VA = "0x185187020")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class DKBLFDGHMDM
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface MLNGBBGIKMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void PEGDHJGMBIH(bool AHHIIFACKLF);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract Component MCDPGFOBLKC
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract string NKAGADDFNIH
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int FJHECMNPBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract void NBIMBFLLBKO(int NAOLJMJHENM, Action<Component> FBGHDPPNNGN);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract Component BOJMFGCMAEA(Action<Component> DHEDMFBJCDB);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool GGCIONGPJEH(Component FBECIMFMPPP);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void OAHGKPPJHGI();

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5186AC0", Offset = "0x5185CC0", VA = "0x185186AC0")]
	protected void DAGCLFGNCDM(Component ANFJLMLDELH, bool AHHIIFACKLF, bool MHHCBEKGNKA, bool PCAFAEABCGP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5186C40", Offset = "0x5185E40", VA = "0x185186C40")]
	protected void EDEEKAGBIDE(Transform BCDDFGNLJBP, bool AHHIIFACKLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	protected DKBLFDGHMDM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class LGCOKILJLMO<T> : DKBLFDGHMDM where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T HAAOGJGGGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool CNKKHBGHKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool MHHCBEKGNKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> LJHAIKIEOGK;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override Component MCDPGFOBLKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x58A1D0", Offset = "0x5893D0", VA = "0x18058A1D0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override string NKAGADDFNIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x2E55230", Offset = "0x2E54430", VA = "0x182E55230", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override int FJHECMNPBBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x2E555A0", Offset = "0x2E547A0", VA = "0x182E555A0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2E555D0", Offset = "0x2E547D0", VA = "0x182E555D0")]
	public LGCOKILJLMO(T HAAOGJGGGGK, ObjectPool CNKKHBGHKMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2E55250", Offset = "0x2E54450", VA = "0x182E55250", Slot = "7")]
	public override void NBIMBFLLBKO(int NAOLJMJHENM, Action<Component> DHEDMFBJCDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x2E54D20", Offset = "0x2E53F20", VA = "0x182E54D20", Slot = "8")]
	public override Component BOJMFGCMAEA(Action<Component> DHEDMFBJCDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x2E550A0", Offset = "0x2E542A0", VA = "0x182E550A0", Slot = "9")]
	public override bool GGCIONGPJEH(Component FBECIMFMPPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2E55360", Offset = "0x2E54560", VA = "0x182E55360", Slot = "10")]
	public override void OAHGKPPJHGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x2E54F50", Offset = "0x2E54150", VA = "0x182E54F50")]
	private T CHIIAFKABCN()
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
		public interface BLMKBCELPBF
		{
			[Cpp2IlInjected.Token(Token = "0x17000009")]
			GameObject KELDLBJOHHF
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public List<PrefillDataEntry> PrefillData;

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x51882E0", Offset = "0x51874E0", VA = "0x1851882E0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x51885C0", Offset = "0x51877C0", VA = "0x1851885C0")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool KCHMEDBFKBH;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject KLMCCLHJFLE;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static PersistentGlobalPool LHIDCGAAEOA
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x5188850", Offset = "0x5187A50", VA = "0x185188850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5188770", Offset = "0x5187970", VA = "0x185188770")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5187020", Offset = "0x5186220", VA = "0x185187020")]
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
		public DKBLFDGHMDM PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xDD9CF0", Offset = "0xDD8EF0", VA = "0x180DD9CF0")]
		public PooledObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000017")]
		private enum FKAIHNLJNCB
		{
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			NONE,
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			POSITION,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			ROTATION,
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			POSITION_AND_ROTATION,
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			VELOCITY
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public interface BPLLDCFFMEE
		{
			[Cpp2IlInjected.Token(Token = "0x17000010")]
			bool LKOGAINGBGD
			{
				[Cpp2IlInjected.Token(Token = "0x6000072")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000011")]
			Vector3 LNEBMCHDJAC
			{
				[Cpp2IlInjected.Token(Token = "0x6000073")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000012")]
			Camera BOPLJGKFAGI
			{
				[Cpp2IlInjected.Token(Token = "0x6000074")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public class ColorConfiguration
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			[SerializeField]
			private ParticleSystem particleSystem;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			[SerializeField]
			private bool setStartColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			[SerializeField]
			private bool setMinColorOverLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			[SerializeField]
			private bool setMaxColorOverLifetime;

			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xA18900", Offset = "0xA17B00", VA = "0x180A18900")]
			public ColorConfiguration(ParticleSystem GNOBLCMFCND)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x51868B0", Offset = "0x5185AB0", VA = "0x1851868B0")]
			public void ADJFODBOEJP(Color HNBBMICLPEF)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		[CompilerGenerated]
		private sealed class KANBJIBDMCC : IEnumerator<KIKOFGNMMEC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			private KIKOFGNMMEC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private BPLLDCFFMEE <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000013")]
			private KIKOFGNMMEC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0x69B7D0", Offset = "0x69A9D0", VA = "0x18069B7D0")]
			[DebuggerHidden]
			public KANBJIBDMCC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x5187810", Offset = "0x5186A10", VA = "0x185187810", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5188290", Offset = "0x5187490", VA = "0x185188290", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class DNNBIHMHHCB : IEnumerator<KIKOFGNMMEC>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			private KIKOFGNMMEC <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			private KIKOFGNMMEC System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000087")]
				[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x58A1C0", Offset = "0x5893C0", VA = "0x18058A1C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x69B7D0", Offset = "0x69A9D0", VA = "0x18069B7D0")]
			[DebuggerHidden]
			public DNNBIHMHHCB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x58AE80", Offset = "0x58A080", VA = "0x18058AE80", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x5186E30", Offset = "0x5186030", VA = "0x185186E30", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x5186EF0", Offset = "0x51860F0", VA = "0x185186EF0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> PKBHIPAEMGB;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static List<PooledParticle> FJJFECIEIHC;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static NOIGHMHHCPP CFCDOHNGEFJ;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const float MPGHDAOADKA = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static bool HGIJCPINMOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		protected int BFLMKGHMBNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[SerializeField]
		protected ColorConfiguration[] colorConfigurations;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public bool IsLooping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private ParticleSystem.MinMaxGradient[] KLCIJPIJOHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private bool JKLJNDIKNFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private float FPPLPPNNMMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private float CBCLPHHOHOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private Transform HNMNPMDJJHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private Vector3 NPEDGGKJGHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private Vector3 NMPEMIEHLFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private FKAIHNLJNCB JDIAEFPALED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private NOIGHMHHCPP KKGMPOEJFIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		protected bool IDNNHENEMMM;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		protected static bool NDJKMEDLJLE
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x5188F20", Offset = "0x5188120", VA = "0x185188F20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public ParticleSystem EKBPLLPHFID
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5B30C0", Offset = "0x5B22C0", VA = "0x1805B30C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6ADCC0", Offset = "0x6ACEC0", VA = "0x1806ADCC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public ParticleSystem[] AGBNFPICJAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5B2A30", Offset = "0x5B1C30", VA = "0x1805B2A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x6C2580", Offset = "0x6C1780", VA = "0x1806C2580")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		private ParticleSystemRenderer[] BDCKAJEEKCN
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x58B010", Offset = "0x58A210", VA = "0x18058B010")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x58B020", Offset = "0x58A220", VA = "0x18058B020")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		private FKAIHNLJNCB FKNPGHJAIDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x655380", Offset = "0x654580", VA = "0x180655380")]
			get
			{
				return default(FKAIHNLJNCB);
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5189BA0", Offset = "0x5188DA0", VA = "0x185189BA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action IPDOJLDLPLF
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x518BB00", Offset = "0x518AD00", VA = "0x18518BB00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x518BBA0", Offset = "0x518ADA0", VA = "0x18518BBA0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x518B7A0", Offset = "0x518A9A0", VA = "0x18518B7A0")]
		public static PooledParticle TryPlayPrefab(PooledParticle HAAOGJGGGGK, Vector3 PNBJGABNCHL, Quaternion EOMKAGCDDCE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x518B5B0", Offset = "0x518A7B0", VA = "0x18518B5B0")]
		public static PooledParticle TryPlayPrefab(PooledParticle HAAOGJGGGGK, Vector3 PNBJGABNCHL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x518ADF0", Offset = "0x5189FF0", VA = "0x18518ADF0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5189ED0", Offset = "0x51890D0", VA = "0x185189ED0")]
		private void MBODBBCJFLI(bool MECGBLBGBCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x518A250", Offset = "0x5189450", VA = "0x18518A250")]
		[IteratorStateMachine(typeof(KANBJIBDMCC))]
		private static IEnumerator<KIKOFGNMMEC> NLBGIFIJJPM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5189F50", Offset = "0x5189150", VA = "0x185189F50")]
		protected void MDEGLAEPJJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x51893B0", Offset = "0x51885B0", VA = "0x1851893B0")]
		protected void DBDMEEHGDDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5189140", Offset = "0x5188340", VA = "0x185189140", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5189BF0", Offset = "0x5188DF0", VA = "0x185189BF0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x518A2A0", Offset = "0x51894A0", VA = "0x18518A2A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5189330", Offset = "0x5188530", VA = "0x185189330")]
		[IteratorStateMachine(typeof(DNNBIHMHHCB))]
		private IEnumerator<KIKOFGNMMEC> CGPDIMDKEHA(float PHHEPBHPBIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5189A00", Offset = "0x5188C00", VA = "0x185189A00")]
		private void GGCIONGPJEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x518B390", Offset = "0x518A590", VA = "0x18518B390")]
		public void SetDuration(float PHHEPBHPBIN, bool ALABGJGALHE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x518AB50", Offset = "0x5189D50", VA = "0x18518AB50")]
		public void Play(Transform NGMOAJPOOGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x518A9C0", Offset = "0x5189BC0", VA = "0x18518A9C0")]
		public void Play(Transform NGMOAJPOOGP, bool GECBOIGCBPE, float BKOCPAILGOK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x518A630", Offset = "0x5189830", VA = "0x18518A630")]
		public void Play(Transform NGMOAJPOOGP, Vector3 NMPEMIEHLFO, bool GECBOIGCBPE, float BKOCPAILGOK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x518A3E0", Offset = "0x51895E0", VA = "0x18518A3E0")]
		public void Play(Transform JBHEMHAOLFB, Quaternion EOMKAGCDDCE, bool GECBOIGCBPE = false, float BKOCPAILGOK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x518A780", Offset = "0x5189980", VA = "0x18518A780")]
		public void Play(Transform JBHEMHAOLFB, Vector3 NMPEMIEHLFO, Quaternion EOMKAGCDDCE, bool GECBOIGCBPE = false, float BKOCPAILGOK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x518A560", Offset = "0x5189760", VA = "0x18518A560")]
		public void Play(Vector3 PNBJGABNCHL, Quaternion EOMKAGCDDCE, Vector3 FEJMGDOPEPL, bool GECBOIGCBPE = false, float BKOCPAILGOK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x518A320", Offset = "0x5189520", VA = "0x18518A320")]
		public void Play(Vector3 PNBJGABNCHL, Quaternion EOMKAGCDDCE, bool GECBOIGCBPE = false, float BKOCPAILGOK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x518A8B0", Offset = "0x5189AB0", VA = "0x18518A8B0")]
		public void Play(bool GECBOIGCBPE = false, float BKOCPAILGOK = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x518B520", Offset = "0x518A720", VA = "0x18518B520")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x518B470", Offset = "0x518A670", VA = "0x18518B470")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x518A0D0", Offset = "0x51892D0", VA = "0x18518A0D0")]
		private void MPMANLMMAHG(float PHHEPBHPBIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5188FD0", Offset = "0x51881D0", VA = "0x185188FD0")]
		private void ACFPCAAONAJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x518ACD0", Offset = "0x5189ED0", VA = "0x18518ACD0")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x518AF70", Offset = "0x518A170", VA = "0x18518AF70")]
		public void SetColor(Color HNBBMICLPEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5189860", Offset = "0x5188A60", VA = "0x185189860")]
		private void GAAOHBLPMBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x518BA70", Offset = "0x518AC70", VA = "0x18518BA70")]
		public PooledParticle()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5189BC0", Offset = "0x5188DC0", VA = "0x185189BC0")]
		[CompilerGenerated]
		private void IODMGDCLAOB(ParticleSystemRenderer JLEPLEPPGJO)
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class JABMDOENCKP
{
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private static byte[] CDGDAHNLLDM;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private static int FDPMPGKGLAJ;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private static int LAEDHJMCKNO;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private static BigInteger CJEJEKHBKEN;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
	public JABMDOENCKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x5187550", Offset = "0x5186750", VA = "0x185187550")]
	private static string DMHFLPDODAP(byte[] DLFOEJDCAKP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x5187220", Offset = "0x5186420", VA = "0x185187220")]
	public static string AJIDJKNPAKB(byte[] NGIBJOEMFPL, bool MFLHBEHGGNL)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2)]
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x400005C")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x58CAB0", Offset = "0x58BCB0", VA = "0x18058CAB0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
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
