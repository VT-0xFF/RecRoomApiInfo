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
		[Cpp2IlInjected.Address(RVA = "0x69705E0", Offset = "0x696EFE0", VA = "0x1869705E0")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles OPBBFNOFOIK, float IPBAFHIJOEO, Vector3 PICDPPHNNLH, Quaternion IHCJBCJFELL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x69703E0", Offset = "0x696EDE0", VA = "0x1869703E0")]
		public void SetDamageValue(float IPBAFHIJOEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x69707A0", Offset = "0x696F1A0", VA = "0x1869707A0")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LDHIKCLOBJJ<T> : global::ODHJGGEEIEO<T>, JKAHJLGEFLE, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GJNLNNFLDMM<T> : JKAHJLGEFLE, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface NOPKLNDNGML
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MNCNHNFLBIL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class MHJCOJNOFPF<T> : global::GOEHKJJNHGC<T>, global::LDHIKCLOBJJ<T>, global::ODHJGGEEIEO<T>, JKAHJLGEFLE, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class MBGLCHFPBFA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public MHJCOJNOFPF<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x13760C0", Offset = "0x1374AC0", VA = "0x1813760C0")]
			public MBGLCHFPBFA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x34A6A10", Offset = "0x34A5410", VA = "0x1834A6A10")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x234C2E0", Offset = "0x234ACE0", VA = "0x18234C2E0")]
			internal void <.ctor>b__1(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private global::EBCMIJBCHOC<T> MFAEDODFEMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool EFPDIALOKDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T MLLKBCFLFJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool FCPODLMHINC;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x302B010", Offset = "0x3029A10", VA = "0x18302B010")]
		public MHJCOJNOFPF(global::EBCMIJBCHOC<T> MFAEDODFEMI, ObjectPool EFPDIALOKDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x302AED0", Offset = "0x30298D0", VA = "0x18302AED0", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class AHJCKBENELM<T> : IDFJJMAGGAN, global::GJNLNNFLDMM<T>, JKAHJLGEFLE, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class EJHPBBCDLFJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public AHJCKBENELM<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x13760C0", Offset = "0x1374AC0", VA = "0x1813760C0")]
			public EJHPBBCDLFJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x4064070", Offset = "0x4062A70", VA = "0x184064070")]
			internal void <.ctor>b__0(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x4064150", Offset = "0x4062B50", VA = "0x184064150")]
			internal void <.ctor>b__1(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private global::EBCMIJBCHOC<T> MFAEDODFEMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool FCPODLMHINC;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x360B350", Offset = "0x3609D50", VA = "0x18360B350")]
		public AHJCKBENELM(global::EBCMIJBCHOC<T> MFAEDODFEMI, ObjectPool EFPDIALOKDN, int MNKDEDOILJA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x360B300", Offset = "0x3609D00", VA = "0x18360B300", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class OPGBCCGAAPK<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public MNCNHNFLBIL <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public global::GOEHKJJNHGC<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public global::EBCMIJBCHOC<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x13760C0", Offset = "0x1374AC0", VA = "0x1813760C0")]
		public OPGBCCGAAPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3D0CD60", Offset = "0x3D0B760", VA = "0x183D0CD60")]
		internal void <Exists>b__0(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x3D0CE00", Offset = "0x3D0B800", VA = "0x183D0CE00")]
		internal void <Exists>b__1(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3D0CE60", Offset = "0x3D0B860", VA = "0x183D0CE60")]
		internal void <Exists>b__2()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<NOPKLNDNGML> CPIGMGEOMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private KJPMPIKMLDD LHMJEGDDNIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool EFPDIALOKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool FCPODLMHINC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ObjectPool BIDPMDPOGJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x696EB30", Offset = "0x696D530", VA = "0x18696EB30")]
	private static void BCMAOEGPIDF(Component AFCHMEJMNBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x696F1E0", Offset = "0x696DBE0", VA = "0x18696F1E0")]
	public MNCNHNFLBIL(string IFCELFAKOBP, int GBEPANOOBCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x28E01D0", Offset = "0x28DEBD0", VA = "0x1828E01D0")]
	public global::LDHIKCLOBJJ<T> LFLLANPBDJN<T>(AssetReference EIHGOHACAFE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x28DFE80", Offset = "0x28DE880", VA = "0x1828DFE80")]
	public global::GJNLNNFLDMM<T> DJIEFPIGLPA<T>(AssetReference EIHGOHACAFE, int EJMNNLNLAFJ) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x28DFF30", Offset = "0x28DE930", VA = "0x1828DFF30")]
	public global::ODHJGGEEIEO<bool> FIKLEKNKGJP<T>(AssetReference EIHGOHACAFE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x696ED80", Offset = "0x696D780", VA = "0x18696ED80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x696F020", Offset = "0x696DA20", VA = "0x18696F020")]
	private void GBFDIDMBGJM(UnityEngine.Object IGGLPHHHOFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x696EE90", Offset = "0x696D890", VA = "0x18696EE90")]
	private ObjectPool EPOMLCIPCIH(string IFCELFAKOBP)
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
		private static GlobalPool OIMLLCLGDFH;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject GNBDCAPFKBP;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GlobalPool AGBLMGNNIDO
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x696DEC0", Offset = "0x696C8C0", VA = "0x18696DEC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x36BA980", Offset = "0x36B9380", VA = "0x1836BA980")]
		public static void SafeRelease<T>(T NBNOMDAKOCG) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x696DDC0", Offset = "0x696C7C0", VA = "0x18696DDC0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x696DEB0", Offset = "0x696C8B0", VA = "0x18696DEB0")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, JNEFBJKEDGC> GAADFLHJNGK;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x22C25D0", Offset = "0x22C0FD0", VA = "0x1822C25D0")]
		public T Acquire<T>(T OPBBFNOFOIK, [Optional] Action<Component> ONGMPJHIFAJ) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x22C2960", Offset = "0x22C1360", VA = "0x1822C2960")]
		public bool Release<T>(T NBNOMDAKOCG) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x22C2900", Offset = "0x22C1300", VA = "0x1822C2900")]
		public void Prefill<T>(T OPBBFNOFOIK, int PFFFCDEPHLC, [Optional] Action<Component> LGJOEGHKEPI) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x22C2710", Offset = "0x22C1110", VA = "0x1822C2710")]
		public bool Exists<T>(T OPBBFNOFOIK) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x22C2660", Offset = "0x22C1060", VA = "0x1822C2660")]
		public void Clear<T>(T OPBBFNOFOIK) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x696FF30", Offset = "0x696E930", VA = "0x18696FF30")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x22C27C0", Offset = "0x22C11C0", VA = "0x1822C27C0")]
		private JNEFBJKEDGC FJCIAMBKFBD<T>(T OPBBFNOFOIK) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
		public void TrackInstantiation(string OONOMAFCFJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
		public void EnableStats(bool EPIJAGPPPIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6970080", Offset = "0x696EA80", VA = "0x186970080")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class JNEFBJKEDGC
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface AOIEMHPAACF
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void DDJHPCHLILF(bool KHJHBNPBBAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract Component CCCLCBBLCIM
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract string HOIPOKICKKE
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public abstract int MLEODILGAEP
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract void DJIEFPIGLPA(int EJMNNLNLAFJ, Action<Component> LGJOEGHKEPI);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract Component LFLLANPBDJN(Action<Component> ONGMPJHIFAJ);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool CKAJENPILHN(Component GEEDNCPBAAN);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void BONIBAPHNIO();

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x696E180", Offset = "0x696CB80", VA = "0x18696E180")]
	protected void HEOCMOBGBOI(Component NBNOMDAKOCG, bool KHJHBNPBBAJ, bool DFGCKIJHGHL, bool FHGOJPBJDDK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x696E300", Offset = "0x696CD00", VA = "0x18696E300")]
	protected void LCINBHLJJKP(Transform CIIPLLKHECB, bool KHJHBNPBBAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	protected JNEFBJKEDGC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class DAHCODCLNOP<T> : JNEFBJKEDGC where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T OPBBFNOFOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool HLOKBFEHLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool DFGCKIJHGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> DNJELEOFLPG;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override Component CCCLCBBLCIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x727010", Offset = "0x725A10", VA = "0x180727010", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override string HOIPOKICKKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x337A370", Offset = "0x3378D70", VA = "0x18337A370", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override int MLEODILGAEP
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3379F70", Offset = "0x3378970", VA = "0x183379F70", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x337A390", Offset = "0x3378D90", VA = "0x18337A390")]
	public DAHCODCLNOP(T OPBBFNOFOIK, ObjectPool HLOKBFEHLPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3379E60", Offset = "0x3378860", VA = "0x183379E60", Slot = "7")]
	public override void DJIEFPIGLPA(int EJMNNLNLAFJ, Action<Component> ONGMPJHIFAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3379FA0", Offset = "0x33789A0", VA = "0x183379FA0", Slot = "8")]
	public override Component LFLLANPBDJN(Action<Component> ONGMPJHIFAJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3379CD0", Offset = "0x33786D0", VA = "0x183379CD0", Slot = "9")]
	public override bool CKAJENPILHN(Component GEEDNCPBAAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3379AE0", Offset = "0x33784E0", VA = "0x183379AE0", Slot = "10")]
	public override void BONIBAPHNIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x337A210", Offset = "0x3378C10", VA = "0x18337A210")]
	private T LGKGHLIJOEA()
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
		public interface JPHGDMOOBHH
		{
			[Cpp2IlInjected.Token(Token = "0x17000009")]
			GameObject EOPNOIAHFAK
			{
				[Cpp2IlInjected.Token(Token = "0x6000043")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public List<PrefillDataEntry> PrefillData;

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x696FB60", Offset = "0x696E560", VA = "0x18696FB60")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x696FEB0", Offset = "0x696E8B0", VA = "0x18696FEB0")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool OIMLLCLGDFH;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject GNBDCAPFKBP;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static PersistentGlobalPool AGBLMGNNIDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x69701F0", Offset = "0x696EBF0", VA = "0x1869701F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6970100", Offset = "0x696EB00", VA = "0x186970100")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x696DEB0", Offset = "0x696C8B0", VA = "0x18696DEB0")]
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
		public JNEFBJKEDGC PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xE67660", Offset = "0xE66060", VA = "0x180E67660")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface LBJEEBFMPMD
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int PDDINDOGKAF(PooledParticle.NEIGHFLKHLG LNILHBHEFKG);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum PHDDLEDJADF
		{
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			NONE,
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			POSITION,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			ROTATION,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			POSITION_AND_ROTATION,
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			VELOCITY
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public enum NEIGHFLKHLG
		{
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			GAMEPLAY_CRITICAL = 1,
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			GAMEPLAY_HIGH_PRI = 2,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			GAMEPLAY_LOW_PRI = 3,
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			SOCIAL_FEEDBACK = 4,
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			DEFAULT = 0
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public interface FANMEJPBCAE
		{
			[Cpp2IlInjected.Token(Token = "0x17000015")]
			bool GCKKFIDELMD
			{
				[Cpp2IlInjected.Token(Token = "0x600007B")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			Vector3 KPFHPKEHDPK
			{
				[Cpp2IlInjected.Token(Token = "0x600007C")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			Camera PDKKIHHBEFF
			{
				[Cpp2IlInjected.Token(Token = "0x600007D")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public class ColorConfiguration
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			[SerializeField]
			private ParticleSystem particleSystem;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			[SerializeField]
			private bool setStartColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			[SerializeField]
			private bool setMinColorOverLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			[SerializeField]
			private bool setMaxColorOverLifetime;

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xCAB480", Offset = "0xCA9E80", VA = "0x180CAB480")]
			public ColorConfiguration(ParticleSystem NJHLGLPPAGM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0x696DBA0", Offset = "0x696C5A0", VA = "0x18696DBA0")]
			public void JKIMJFIMIIL(Color HAFGGBNGKBN)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class GDGHOFAJEOM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
			public GDGHOFAJEOM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x696DD90", Offset = "0x696C790", VA = "0x18696DD90")]
			internal void <SetRenderingEnabled>b__0(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class OMMEGHIFEDK : IEnumerator<MEOADLJIECK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private MEOADLJIECK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private FANMEJPBCAE <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private MEOADLJIECK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008D")]
				[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x80F8E0", Offset = "0x80E2E0", VA = "0x18080F8E0")]
			[DebuggerHidden]
			public OMMEGHIFEDK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x696F480", Offset = "0x696DE80", VA = "0x18696F480", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x696FB20", Offset = "0x696E520", VA = "0x18696FB20", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class IFIMPCNOCOJ : IEnumerator<MEOADLJIECK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private MEOADLJIECK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700001A")]
			private MEOADLJIECK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000093")]
				[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700001B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000095")]
				[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x80F8E0", Offset = "0x80E2E0", VA = "0x18080F8E0")]
			[DebuggerHidden]
			public IFIMPCNOCOJ(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000091")]
			[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x696E080", Offset = "0x696CA80", VA = "0x18696E080", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x696E140", Offset = "0x696CB40", VA = "0x18696E140", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> ABGGKGEBBDJ;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<LBJEEBFMPMD> PIKABGGDJPE;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static List<PooledParticle> FNOAJMEHIOE;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static GNGMNANCADP KPOCPLAOKJM;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float DMNMCNLMHBM = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static bool DEBABNKADBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected int JKLDGNOPNNB;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private NEIGHFLKHLG category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		protected ColorConfiguration[] colorConfigurations;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public bool IsLooping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private ParticleSystem.MinMaxGradient[] PEDGIJKDEHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool EAPEAFKALCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float MBDOCOBKMEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float LCJDHILMFLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform JBOFBHPJFBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 FHPOIBAGLKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 EBLJCMOGCIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private PHDDLEDJADF OFAHHIIJFBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private GNGMNANCADP JCNCLBGFENE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected bool LBGKMDGMDJB;

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static IEnumerable<PooledParticle> GHAHJHFBLGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6974090", Offset = "0x6972A90", VA = "0x186974090")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public NEIGHFLKHLG FNCNKHIAEPN
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x72C630", Offset = "0x72B030", VA = "0x18072C630")]
			get
			{
				return default(NEIGHFLKHLG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public int OLCAKPMMFMK
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x77AFB0", Offset = "0x7799B0", VA = "0x18077AFB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool OEENHAMLKEH
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x6973D80", Offset = "0x6972780", VA = "0x186973D80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public static int EIKIFEDADEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x6973F10", Offset = "0x6972910", VA = "0x186973F10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		protected static bool ONGKEKFGGLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x69720D0", Offset = "0x6970AD0", VA = "0x1869720D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public ParticleSystem DIJHDHNEHOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x72B270", Offset = "0x729C70", VA = "0x18072B270")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x752CF0", Offset = "0x7516F0", VA = "0x180752CF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public ParticleSystem[] IMIPJNAIEGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x727000", Offset = "0x725A00", VA = "0x180727000")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x7A9630", Offset = "0x7A8030", VA = "0x1807A9630")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private ParticleSystemRenderer[] FIFPHMNCEEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x731A10", Offset = "0x730410", VA = "0x180731A10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x731A20", Offset = "0x730420", VA = "0x180731A20")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private PHDDLEDJADF NKGPGAHLBHF
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x9357D0", Offset = "0x9341D0", VA = "0x1809357D0")]
			get
			{
				return default(PHDDLEDJADF);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x6971540", Offset = "0x696FF40", VA = "0x186971540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action PNKMNPEJAHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x6973CE0", Offset = "0x69726E0", VA = "0x186973CE0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x69740F0", Offset = "0x6972AF0", VA = "0x1869740F0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6973880", Offset = "0x6972280", VA = "0x186973880")]
		public static PooledParticle TryPlayPrefab(PooledParticle OPBBFNOFOIK, Vector3 PICDPPHNNLH, Quaternion IHCJBCJFELL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6973690", Offset = "0x6972090", VA = "0x186973690")]
		public static PooledParticle TryPlayPrefab(PooledParticle OPBBFNOFOIK, Vector3 PICDPPHNNLH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6972D00", Offset = "0x6971700", VA = "0x186972D00")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x69716D0", Offset = "0x69700D0", VA = "0x1869716D0")]
		private void HLIHJLABLEB(bool HEIBCIECNKO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x69717B0", Offset = "0x69701B0", VA = "0x1869717B0")]
		[IteratorStateMachine(typeof(OMMEGHIFEDK))]
		private static IEnumerator<MEOADLJIECK> LLEFEFIBMMM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6970C30", Offset = "0x696F630", VA = "0x186970C30")]
		private static void DLCFLKFPNGE(Stopwatch MJOCLEMBKBO, Vector3 GBMADFJMCKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6971490", Offset = "0x696FE90", VA = "0x186971490")]
		private static int GFGHOFMECBH(PooledParticle GBEJHLEFDJM, PooledParticle BDGBOHJLNIE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x69721E0", Offset = "0x6970BE0", VA = "0x1869721E0")]
		private static int PDDINDOGKAF(NEIGHFLKHLG LNILHBHEFKG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6971290", Offset = "0x696FC90", VA = "0x186971290")]
		protected void GCKBLGJKEHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6971AA0", Offset = "0x69704A0", VA = "0x186971AA0")]
		protected void MAGMLBBFGPJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6970840", Offset = "0x696F240", VA = "0x186970840", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6971800", Offset = "0x6970200", VA = "0x186971800")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6972160", Offset = "0x6970B60", VA = "0x186972160")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6972050", Offset = "0x6970A50", VA = "0x186972050")]
		[IteratorStateMachine(typeof(IFIMPCNOCOJ))]
		private IEnumerator<MEOADLJIECK> NGNBHCLLICB(float JDMBDIMAGHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6970A80", Offset = "0x696F480", VA = "0x186970A80")]
		private void CKAJENPILHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x69734A0", Offset = "0x6971EA0", VA = "0x1869734A0")]
		public void SetDuration(float JDMBDIMAGHM, bool HHIFKFNCJEN = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x69729E0", Offset = "0x69713E0", VA = "0x1869729E0")]
		public void Play(Transform CNMBAKEKPAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x69723C0", Offset = "0x6970DC0", VA = "0x1869723C0")]
		public void Play(Transform CNMBAKEKPAA, bool BDMKNNAMFPH, float IMBHIIPDGBF = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6972510", Offset = "0x6970F10", VA = "0x186972510")]
		public void Play(Transform CNMBAKEKPAA, Vector3 EBLJCMOGCIF, bool BDMKNNAMFPH, float IMBHIIPDGBF = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6972790", Offset = "0x6971190", VA = "0x186972790")]
		public void Play(Transform KOFBPFCJPCO, Quaternion IHCJBCJFELL, bool BDMKNNAMFPH = false, float IMBHIIPDGBF = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6972660", Offset = "0x6971060", VA = "0x186972660")]
		public void Play(Transform KOFBPFCJPCO, Vector3 EBLJCMOGCIF, Quaternion IHCJBCJFELL, bool BDMKNNAMFPH = false, float IMBHIIPDGBF = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x69722F0", Offset = "0x6970CF0", VA = "0x1869722F0")]
		public void Play(Vector3 PICDPPHNNLH, Quaternion IHCJBCJFELL, Vector3 GCAABCBBBAL, bool BDMKNNAMFPH = false, float IMBHIIPDGBF = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6972B20", Offset = "0x6971520", VA = "0x186972B20")]
		public void Play(Vector3 PICDPPHNNLH, Quaternion IHCJBCJFELL, bool BDMKNNAMFPH = false, float IMBHIIPDGBF = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x69728D0", Offset = "0x69712D0", VA = "0x1869728D0")]
		public void Play(bool BDMKNNAMFPH = false, float IMBHIIPDGBF = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6973600", Offset = "0x6972000", VA = "0x186973600")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6973570", Offset = "0x6971F70", VA = "0x186973570")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6971100", Offset = "0x696FB00", VA = "0x186971100")]
		private void EODGAJCHPGC(float JDMBDIMAGHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6971560", Offset = "0x696FF60", VA = "0x186971560")]
		private void GLEDDBNGMGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x6972BE0", Offset = "0x69715E0", VA = "0x186972BE0")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x6972EA0", Offset = "0x69718A0", VA = "0x186972EA0")]
		public void SetColor(Color HAFGGBNGKBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6970FC0", Offset = "0x696F9C0", VA = "0x186970FC0")]
		private void EGJFNEAFCEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6973C80", Offset = "0x6972680", VA = "0x186973C80")]
		public PooledParticle()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class KKMDFNBFHNC
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private static byte[] BKNPCMHFKCN;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private static int KPMJKGHHDMP;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private static int JFAKBFOPBGJ;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private static BigInteger JMHPFPLGCJL;

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public KKMDFNBFHNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x696E850", Offset = "0x696D250", VA = "0x18696E850")]
	private static string JOPJDHMEFPC(byte[] GFCGIJPPCBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x696E500", Offset = "0x696CF00", VA = "0x18696E500")]
	public static string GLIIACIKPKK(byte[] EMIAMELGKNF, bool LLPOIDPCGKE)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000066")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000023")]
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
