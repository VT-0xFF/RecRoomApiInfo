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
		[Header("Impact Particle System")]
		[SerializeField]
		private ParticleSystem impactParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[Header("Impact Particle Start Size")]
		[SerializeField]
		private float impactStartSizeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private float impactStartSizeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[Header("Impact Particle Start Lifetime")]
		[SerializeField]
		private float impactStartLifetimeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private float impactStartLifetimeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Header("Spray Particle System")]
		[SerializeField]
		private ParticleSystem sprayParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Header("Spray Particle Burst Count")]
		[SerializeField]
		private int sprayBurstCountMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private int sprayBurstCountMaxDamage;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5E9C940", Offset = "0x5E9B140", VA = "0x185E9C940")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles NDAADLGGBHN, float IGHDLKPKBJE, Vector3 OBAACBLACLC, Quaternion AHLHKGGFBGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5E9C5E0", Offset = "0x5E9ADE0", VA = "0x185E9C5E0")]
		public void SetDamageValue(float IGHDLKPKBJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x5E9CAC0", Offset = "0x5E9B2C0", VA = "0x185E9CAC0")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NFMHMLPEFGH<T> : FNFCBJEHDPL<T>, DFJLMOHJECJ, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface IHLILECMCHA<T> : DFJLMOHJECJ, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface MAGOFLHOHIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class HBBPIGOMDND : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class JJLKKGHBDII<T> : KEACBFFGLIO<T>, NFMHMLPEFGH<T>, FNFCBJEHDPL<T>, DFJLMOHJECJ, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class GHDLACGAKCI
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public JJLKKGHBDII<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
			public GHDLACGAKCI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x3494F70", Offset = "0x3493770", VA = "0x183494F70")]
			internal void GCCBPAJHLKB(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2BEB160", Offset = "0x2BE9960", VA = "0x182BEB160")]
			internal void OGLGMONJHJB(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private LPPJOFCADCB<T> FIOGHDKLGEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool KDHEODGDKMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T AOCDGMDEJCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool CFJBGEMDAGC;

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3858F80", Offset = "0x3857780", VA = "0x183858F80")]
		public JJLKKGHBDII(LPPJOFCADCB<T> FIOGHDKLGEB, ObjectPool KDHEODGDKMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3858E40", Offset = "0x3857640", VA = "0x183858E40", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class JJKJCPBJAAP<T> : MPIIFDIEJMJ, IHLILECMCHA<T>, DFJLMOHJECJ, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class AFLJPMALLAC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public JJKJCPBJAAP<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
			public AFLJPMALLAC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x35A0080", Offset = "0x359E880", VA = "0x1835A0080")]
			internal void GCCBPAJHLKB(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8A05F0", Offset = "0x89EDF0", VA = "0x1808A05F0")]
			internal void OGLGMONJHJB(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private LPPJOFCADCB<T> FIOGHDKLGEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool CFJBGEMDAGC;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x38589E0", Offset = "0x38571E0", VA = "0x1838589E0")]
		public JJKJCPBJAAP(LPPJOFCADCB<T> FIOGHDKLGEB, ObjectPool KDHEODGDKMC, int OFFCKCIBMMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x3858980", Offset = "0x3857180", VA = "0x183858980", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class GOEMFFEGOCM<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public HBBPIGOMDND <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public KEACBFFGLIO<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public LPPJOFCADCB<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public GOEMFFEGOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x34C9550", Offset = "0x34C7D50", VA = "0x1834C9550")]
		internal void OPEBNLFAAMF(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x34C9600", Offset = "0x34C7E00", VA = "0x1834C9600")]
		internal void PHFEGNOAIBF(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x34C9500", Offset = "0x34C7D00", VA = "0x1834C9500")]
		internal void LONGICNIOJH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<MAGOFLHOHIJ> KMHKAANIGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private KDANHIOAKDL CMKOEICECCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool KDHEODGDKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool CFJBGEMDAGC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public ObjectPool GNIJGGOOLJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B400", Offset = "0x5E99C00", VA = "0x185E9B400")]
	private static void DCCLFEELLEO(Component ENFAJMDKEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5E9BA80", Offset = "0x5E9A280", VA = "0x185E9BA80")]
	public HBBPIGOMDND(string PMFEOHBFPBF, int FDKFAMHLNAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2396940", Offset = "0x2395140", VA = "0x182396940")]
	public NFMHMLPEFGH<T> LDCEKDCBEDK<T>(AssetReference HPKAKFJAOBB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2396890", Offset = "0x2395090", VA = "0x182396890")]
	public IHLILECMCHA<T> JLDFMGOHAMD<T>(AssetReference HPKAKFJAOBB, int JEDNJDDHFHB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2396570", Offset = "0x2394D70", VA = "0x182396570")]
	public FNFCBJEHDPL<bool> CHBJDEDBAAF<T>(AssetReference HPKAKFJAOBB) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B640", Offset = "0x5E99E40", VA = "0x185E9B640", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B730", Offset = "0x5E99F30", VA = "0x185E9B730")]
	private void LADILGEALBC(UnityEngine.Object CBDIGJMOBPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B860", Offset = "0x5E9A060", VA = "0x185E9B860")]
	private ObjectPool PBINHDMCIKD(string PMFEOHBFPBF)
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
		private static GlobalPool CKEFBCOPKNM;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject HBJKDNICAHE;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static GlobalPool LNAOMADBHGP
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x5E9B290", Offset = "0x5E99A90", VA = "0x185E9B290")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x23953C0", Offset = "0x2393BC0", VA = "0x1823953C0")]
		public static void SafeRelease<T>(T ELOCHLKHPBP) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x5E9B1C0", Offset = "0x5E999C0", VA = "0x185E9B1C0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x5E9B280", Offset = "0x5E99A80", VA = "0x185E9B280")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, GKLIMBGBBOG> HPINMBALIMH;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x24F6020", Offset = "0x24F4820", VA = "0x1824F6020")]
		public T Acquire<T>(T NDAADLGGBHN, [Optional] Action<Component> DFDACLBKPAK) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x24F6390", Offset = "0x24F4B90", VA = "0x1824F6390")]
		public bool Release<T>(T ELOCHLKHPBP) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x24F6340", Offset = "0x24F4B40", VA = "0x1824F6340")]
		public void Prefill<T>(T NDAADLGGBHN, int COEIBNIJKPK, [Optional] Action<Component> HNMEJPDHMCH) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x24F6160", Offset = "0x24F4960", VA = "0x1824F6160")]
		public bool Exists<T>(T NDAADLGGBHN) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x24F60B0", Offset = "0x24F48B0", VA = "0x1824F60B0")]
		public void Clear<T>(T NDAADLGGBHN) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5E9C180", Offset = "0x5E9A980", VA = "0x185E9C180")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x24F6200", Offset = "0x24F4A00", VA = "0x1824F6200")]
		private GKLIMBGBBOG OEAFOHBHNJA<T>(T NDAADLGGBHN) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0")]
		public void TrackInstantiation(string GIMDNACEJGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0")]
		public void EnableStats(bool ANHHAEHBGPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5E9C2F0", Offset = "0x5E9AAF0", VA = "0x185E9C2F0")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class GKLIMBGBBOG
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface MGCDNCGGCEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void EJDKNJPJIMN(bool MGALCAEGIBE);
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract string MJLCABAKOPI
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public abstract int CGAILAFOKDA
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void JLDFMGOHAMD(int JEDNJDDHFHB, Action<Component> HNMEJPDHMCH);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component LDCEKDCBEDK(Action<Component> DFDACLBKPAK);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool FBKBPDEEJFF(Component GNBHLGDNMIM);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void PAMPKEGOCOB();

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B040", Offset = "0x5E99840", VA = "0x185E9B040")]
	protected void FIOLKMEOPIP(Component ELOCHLKHPBP, bool MGALCAEGIBE, bool GEKINFMIGNE, bool LFMIGJPAKBA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5E9ADC0", Offset = "0x5E995C0", VA = "0x185E9ADC0")]
	protected void EMOPFMEBEAG(Transform LNANMKALDPJ, bool MGALCAEGIBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
	protected GKLIMBGBBOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class IBKNAKICJHD<T> : GKLIMBGBBOG where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T NDAADLGGBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool JJKFJKACNHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool GEKINFMIGNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> DECIGNKOFHF;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override string MJLCABAKOPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x3652A70", Offset = "0x3651270", VA = "0x183652A70", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override int CGAILAFOKDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x3652C30", Offset = "0x3651430", VA = "0x183652C30", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x36531D0", Offset = "0x36519D0", VA = "0x1836531D0")]
	public IBKNAKICJHD(T NDAADLGGBHN, ObjectPool JJKFJKACNHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3652C70", Offset = "0x3651470", VA = "0x183652C70", Slot = "6")]
	public override void JLDFMGOHAMD(int JEDNJDDHFHB, Action<Component> DFDACLBKPAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x3652D80", Offset = "0x3651580", VA = "0x183652D80", Slot = "7")]
	public override Component LDCEKDCBEDK(Action<Component> DFDACLBKPAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3652A90", Offset = "0x3651290", VA = "0x183652A90", Slot = "8")]
	public override bool FBKBPDEEJFF(Component GNBHLGDNMIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3652FF0", Offset = "0x36517F0", VA = "0x183652FF0", Slot = "9")]
	public override void PAMPKEGOCOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3652900", Offset = "0x3651100", VA = "0x183652900")]
	private T BGPDGNOFMOM()
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
		public interface CFBGCNCEDLD
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			GameObject BLNGLHDAFMG
			{
				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public List<PrefillDataEntry> PrefillData;

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5E9BE00", Offset = "0x5E9A600", VA = "0x185E9BE00")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5E9C0F0", Offset = "0x5E9A8F0", VA = "0x185E9C0F0")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool CKEFBCOPKNM;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject HBJKDNICAHE;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static PersistentGlobalPool LNAOMADBHGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x5E9C440", Offset = "0x5E9AC40", VA = "0x185E9C440")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5E9C380", Offset = "0x5E9AB80", VA = "0x185E9C380")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5E9B280", Offset = "0x5E99A80", VA = "0x185E9B280")]
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
		public GKLIMBGBBOG PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x761FB0", Offset = "0x7607B0", VA = "0x180761FB0")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface MPDJDJCGBDL
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int GJGHHKMAOAL(PooledParticle.EOHNBCEDONE FBDKFOBLJKP);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum LLDKFILPADF
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
		public enum EOHNBCEDONE
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
		public interface IEFMCMMAGNH
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			bool IGJPJEEFKLG
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Vector3 LGPBLLDECKF
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Camera BKJCIFDCBMI
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
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

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x4FE3350", Offset = "0x4FE1B50", VA = "0x184FE3350")]
			public ColorConfiguration(ParticleSystem JBHGOFLGGOF)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x5E9ABD0", Offset = "0x5E993D0", VA = "0x185E9ABD0")]
			public void COOOEFKANMB(Color JFJPGCGPBNP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class MKKKCJAGKKE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
			public MKKKCJAGKKE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x5E9BDD0", Offset = "0x5E9A5D0", VA = "0x185E9BDD0")]
			internal void OOMGMLFICJH(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class AOPFAOENMPM : IEnumerator<JCNDEIPBHJP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private JCNDEIPBHJP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private IEFMCMMAGNH <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private JCNDEIPBHJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x76E060", Offset = "0x76C860", VA = "0x18076E060")]
			[DebuggerHidden]
			public AOPFAOENMPM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x5E9A570", Offset = "0x5E98D70", VA = "0x185E9A570", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x5E9AB80", Offset = "0x5E99380", VA = "0x185E9AB80", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class LMDMMGOCMAE : IEnumerator<JCNDEIPBHJP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private JCNDEIPBHJP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private JCNDEIPBHJP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x762A60", Offset = "0x761260", VA = "0x180762A60", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x76E060", Offset = "0x76C860", VA = "0x18076E060")]
			[DebuggerHidden]
			public LMDMMGOCMAE(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x761FC0", Offset = "0x7607C0", VA = "0x180761FC0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x5E9BD10", Offset = "0x5E9A510", VA = "0x185E9BD10", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x5E9BD80", Offset = "0x5E9A580", VA = "0x185E9BD80", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> FIJNCHLJNNN;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<MPDJDJCGBDL> CHEHGACIKON;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static List<PooledParticle> DGAFNOFDKGE;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static CEKHBJPKCPE BMFLFJFJGJM;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float LCDNADJPCDE = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static bool MOMBHBBPCFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected int ONEAIEKGIDL;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private EOHNBCEDONE category;

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
		private ParticleSystem.MinMaxGradient[] HNCOGBHIOMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool DCGOLDLHMGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float ELJCIMAFDGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float APFEEEFEJID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform JMPGBGOHDIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 EJHCGPEALOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 MEKCEKGGIKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private LLDKFILPADF KFHALNKDHCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private CEKHBJPKCPE EIDHHIBHEDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected bool AAOFBMOILPE;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static IEnumerable<PooledParticle> DOOIDOICFHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x5EA0310", Offset = "0x5E9EB10", VA = "0x185EA0310")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public EOHNBCEDONE PAOFNMEBJMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x789800", Offset = "0x788000", VA = "0x180789800")]
			get
			{
				return default(EOHNBCEDONE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int GIDBDLOMCDF
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x76CBA0", Offset = "0x76B3A0", VA = "0x18076CBA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool HAOKFJJANAB
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x5EA0040", Offset = "0x5E9E840", VA = "0x185EA0040")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static int LNIMFJCLLMC
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x5EA01C0", Offset = "0x5E9E9C0", VA = "0x185EA01C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected static bool ANJBKCPCIBC
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x5E9D1D0", Offset = "0x5E9B9D0", VA = "0x185E9D1D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem AACKIPHNIKB
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x762AE0", Offset = "0x7612E0", VA = "0x180762AE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x7658E0", Offset = "0x7640E0", VA = "0x1807658E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ParticleSystem[] HECGLNEBLMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x762D60", Offset = "0x761560", VA = "0x180762D60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x76B2A0", Offset = "0x769AA0", VA = "0x18076B2A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private ParticleSystemRenderer[] DONBPPKBFCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x762D40", Offset = "0x761540", VA = "0x180762D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x762AF0", Offset = "0x7612F0", VA = "0x180762AF0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		private LLDKFILPADF IALDFMBGIOK
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xCE2A90", Offset = "0xCE1290", VA = "0x180CE2A90")]
			get
			{
				return default(LLDKFILPADF);
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x5E9DB20", Offset = "0x5E9C320", VA = "0x185E9DB20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action BLAMNBOOBOB
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x5E9FFA0", Offset = "0x5E9E7A0", VA = "0x185E9FFA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x5EA0360", Offset = "0x5E9EB60", VA = "0x185EA0360")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5E9F930", Offset = "0x5E9E130", VA = "0x185E9F930")]
		public static PooledParticle TryPlayPrefab(PooledParticle NDAADLGGBHN, Vector3 OBAACBLACLC, Quaternion AHLHKGGFBGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5E9FAA0", Offset = "0x5E9E2A0", VA = "0x185E9FAA0")]
		public static PooledParticle TryPlayPrefab(PooledParticle NDAADLGGBHN, Vector3 OBAACBLACLC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5E9EFE0", Offset = "0x5E9D7E0", VA = "0x185E9EFE0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5E9DBD0", Offset = "0x5E9C3D0", VA = "0x185E9DBD0")]
		private void JPOGJGBCGFB(bool JOHPJDFABPN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D570", Offset = "0x5E9BD70", VA = "0x185E9D570")]
		[IteratorStateMachine(typeof(AOPFAOENMPM))]
		private static IEnumerator<JCNDEIPBHJP> HGGMPCMELNG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D7D0", Offset = "0x5E9BFD0", VA = "0x185E9D7D0")]
		private static void ICPFJAABDND(Stopwatch HCIPJNOFOCL, Vector3 OLAMACKCMJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D3B0", Offset = "0x5E9BBB0", VA = "0x185E9D3B0")]
		private static int GFDJCEBAGOL(PooledParticle LCFOIJICGNF, PooledParticle CEDMGMKLGHI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D460", Offset = "0x5E9BC60", VA = "0x185E9D460")]
		private static int GJGHHKMAOAL(EOHNBCEDONE FBDKFOBLJKP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D5D0", Offset = "0x5E9BDD0", VA = "0x185E9D5D0")]
		protected void HKKJHMCCLPD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5E9DF10", Offset = "0x5E9C710", VA = "0x185E9DF10")]
		protected void NCPGFPAOILP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x5E9CCE0", Offset = "0x5E9B4E0", VA = "0x185E9CCE0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5E9DCA0", Offset = "0x5E9C4A0", VA = "0x185E9DCA0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E520", Offset = "0x5E9CD20", VA = "0x185E9E520")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5E9DB40", Offset = "0x5E9C340", VA = "0x185E9DB40")]
		[IteratorStateMachine(typeof(LMDMMGOCMAE))]
		private IEnumerator<JCNDEIPBHJP> JHAGDEEFIFM(float AIKHKAOPEOH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D250", Offset = "0x5E9BA50", VA = "0x185E9D250")]
		private void FBKBPDEEJFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x5E9F740", Offset = "0x5E9DF40", VA = "0x185E9F740")]
		public void SetDuration(float AIKHKAOPEOH, bool BIKDLOAAHKL = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E5A0", Offset = "0x5E9CDA0", VA = "0x185E9E5A0")]
		public void Play(Transform IEFAFPEFOOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5E9EC50", Offset = "0x5E9D450", VA = "0x185E9EC50")]
		public void Play(Transform IEFAFPEFOOD, bool DJGLJMBDIOL, float DOFDKAPAJEG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E700", Offset = "0x5E9CF00", VA = "0x185E9E700")]
		public void Play(Transform IEFAFPEFOOD, Vector3 MEKCEKGGIKP, bool DJGLJMBDIOL, float DOFDKAPAJEG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E850", Offset = "0x5E9D050", VA = "0x185E9E850")]
		public void Play(Transform BBCFJEEPNIO, Quaternion AHLHKGGFBGH, bool DJGLJMBDIOL = false, float DOFDKAPAJEG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5E9EDC0", Offset = "0x5E9D5C0", VA = "0x185E9EDC0")]
		public void Play(Transform BBCFJEEPNIO, Vector3 MEKCEKGGIKP, Quaternion AHLHKGGFBGH, bool DJGLJMBDIOL = false, float DOFDKAPAJEG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x5E9EA70", Offset = "0x5E9D270", VA = "0x185E9EA70")]
		public void Play(Vector3 OBAACBLACLC, Quaternion AHLHKGGFBGH, Vector3 NKFCPJHMPBB, bool DJGLJMBDIOL = false, float DOFDKAPAJEG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E9B0", Offset = "0x5E9D1B0", VA = "0x185E9E9B0")]
		public void Play(Vector3 OBAACBLACLC, Quaternion AHLHKGGFBGH, bool DJGLJMBDIOL = false, float DOFDKAPAJEG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x5E9EB40", Offset = "0x5E9D340", VA = "0x185E9EB40")]
		public void Play(bool DJGLJMBDIOL = false, float DOFDKAPAJEG = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x5E9F8A0", Offset = "0x5E9E0A0", VA = "0x185E9F8A0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5E9F810", Offset = "0x5E9E010", VA = "0x185E9F810")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5E9CF10", Offset = "0x5E9B710", VA = "0x185E9CF10")]
		private void CLCGGIFHBEG(float AIKHKAOPEOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5E9CBA0", Offset = "0x5E9B3A0", VA = "0x185E9CBA0")]
		private void AJLCDBCFKOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5E9EEF0", Offset = "0x5E9D6F0", VA = "0x185E9EEF0")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x5E9F160", Offset = "0x5E9D960", VA = "0x185E9F160")]
		public void SetColor(Color JFJPGCGPBNP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D0A0", Offset = "0x5E9B8A0", VA = "0x185E9D0A0")]
		private void DKDIBIGDHDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5E9FF10", Offset = "0x5E9E710", VA = "0x185E9FF10")]
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
