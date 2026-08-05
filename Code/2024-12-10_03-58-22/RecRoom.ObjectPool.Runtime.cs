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
		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private float minDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private float maxDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[Header("Impact Particle System")]
		[SerializeField]
		private ParticleSystem impactParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		[Header("Impact Particle Start Size")]
		private float impactStartSizeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private float impactStartSizeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[Header("Impact Particle Start Lifetime")]
		[SerializeField]
		private float impactStartLifetimeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private float impactStartLifetimeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Header("Spray Particle System")]
		[SerializeField]
		private ParticleSystem sprayParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Header("Spray Particle Burst Count")]
		[SerializeField]
		private int sprayBurstCountMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private int sprayBurstCountMaxDamage;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4E40", Offset = "0x6EF3A40", VA = "0x186EF4E40")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles LNKGJNJHIPL, float EKMJBOEDHLI, Vector3 GKJAMFFKDLE, Quaternion EAGKGJHHIJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4AE0", Offset = "0x6EF36E0", VA = "0x186EF4AE0")]
		public void SetDamageValue(float EKMJBOEDHLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5010", Offset = "0x6EF3C10", VA = "0x186EF5010")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MAIIFDBHMOC<T> : HHDNLBNGHMC<T>, DMMKPEDFDBF, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BOLOOEHCIDN<T> : DMMKPEDFDBF, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JJPODJPIPPK
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ENACLAMBLBH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class CBPMNKFGLBA<T> : NNIDDNFNEIC<T>, MAIIFDBHMOC<T>, HHDNLBNGHMC<T>, DMMKPEDFDBF, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class PLPMOJDJHLN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public CBPMNKFGLBA<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public PLPMOJDJHLN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x48B6CB0", Offset = "0x48B58B0", VA = "0x1848B6CB0")]
			internal void LPJHGCEDCFM(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2B3E480", Offset = "0x2B3D080", VA = "0x182B3E480")]
			internal void HGCOEELFGPL(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MGEGMLPKNPK<T> EBLBJGNDFID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool KJHFCDIHCCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T CMIAKAKADAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool HINLMPLCGEB;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x523B830", Offset = "0x523A430", VA = "0x18523B830")]
		public CBPMNKFGLBA(MGEGMLPKNPK<T> EBLBJGNDFID, ObjectPool KJHFCDIHCCP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x523B6C0", Offset = "0x523A2C0", VA = "0x18523B6C0", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class CIGONDBLAPP<T> : OKALCPGKGOK, BOLOOEHCIDN<T>, DMMKPEDFDBF, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class GNFDEKJEJBF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public CIGONDBLAPP<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public GNFDEKJEJBF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x3EF25C0", Offset = "0x3EF11C0", VA = "0x183EF25C0")]
			internal void LPJHGCEDCFM(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xD72030", Offset = "0xD70C30", VA = "0x180D72030")]
			internal void HGCOEELFGPL(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private MGEGMLPKNPK<T> EBLBJGNDFID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool HINLMPLCGEB;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x55DA670", Offset = "0x55D9270", VA = "0x1855DA670")]
		public CIGONDBLAPP(MGEGMLPKNPK<T> EBLBJGNDFID, ObjectPool KJHFCDIHCCP, int EGDPKLLBPEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x55DA610", Offset = "0x55D9210", VA = "0x1855DA610", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class NHMLMKOOPOI<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public ENACLAMBLBH <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public NNIDDNFNEIC<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public MGEGMLPKNPK<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public NHMLMKOOPOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x46709B0", Offset = "0x466F5B0", VA = "0x1846709B0")]
		internal void CKIODLFDCEP(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4670AB0", Offset = "0x466F6B0", VA = "0x184670AB0")]
		internal void PICBMINMANI(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4670A60", Offset = "0x466F660", VA = "0x184670A60")]
		internal void JCNDGMMNGDN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<JJPODJPIPPK> EHBJNJCBDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private HEPFAPNIGMN HGLNCOGLMCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool KJHFCDIHCCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool HINLMPLCGEB;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6EF2EA0", Offset = "0x6EF1AA0", VA = "0x186EF2EA0")]
	private static void GLBAIOJHCHN(Component BHEFEMNBEDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6EF3300", Offset = "0x6EF1F00", VA = "0x186EF3300")]
	public ENACLAMBLBH(string CMFAFEIOEHB, int NBDHIOPJCCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2C63B00", Offset = "0x2C62700", VA = "0x182C63B00")]
	public MAIIFDBHMOC<T> DGNCLAFGAIG<T>(AssetReference DEJCHAIOGJA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2C63BD0", Offset = "0x2C627D0", VA = "0x182C63BD0")]
	public BOLOOEHCIDN<T> KDFGOCLCMFM<T>(AssetReference DEJCHAIOGJA, int KNHHBEFLJAF) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2C636D0", Offset = "0x2C622D0", VA = "0x182C636D0")]
	public HHDNLBNGHMC<bool> AMOCDEJOLHN<T>(AssetReference DEJCHAIOGJA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6EF2DB0", Offset = "0x6EF19B0", VA = "0x186EF2DB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6EF2C70", Offset = "0x6EF1870", VA = "0x186EF2C70")]
	private void CAFHGAADMKA(UnityEngine.Object MDOODAHDBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6EF30E0", Offset = "0x6EF1CE0", VA = "0x186EF30E0")]
	private ObjectPool LDHHGBDFBHC(string CMFAFEIOEHB)
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
		private static GlobalPool MIGLNGCGHPM;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject JNLLNJBFFGL;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static GlobalPool AAGIFLNDKEI
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6EF3660", Offset = "0x6EF2260", VA = "0x186EF3660")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x2E128D0", Offset = "0x2E114D0", VA = "0x182E128D0")]
		public static void SafeRelease<T>(T PLAMADMDGIO) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3590", Offset = "0x6EF2190", VA = "0x186EF3590")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3650", Offset = "0x6EF2250", VA = "0x186EF3650")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, MLLBOKKBHAO> BCOFHKPAEEI;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x2FCF330", Offset = "0x2FCDF30", VA = "0x182FCF330")]
		public T Acquire<T>(T LNKGJNJHIPL, [Optional] Action<Component> AEADFAPPAMC) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x2FCF6F0", Offset = "0x2FCE2F0", VA = "0x182FCF6F0")]
		public bool Release<T>(T PLAMADMDGIO) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x2FCF680", Offset = "0x2FCE280", VA = "0x182FCF680")]
		public void Prefill<T>(T LNKGJNJHIPL, int OHEPJDJDDLG, [Optional] Action<Component> OJIOLLOCPCI) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x2FCF4A0", Offset = "0x2FCE0A0", VA = "0x182FCF4A0")]
		public bool Exists<T>(T LNKGJNJHIPL) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x2FCF3F0", Offset = "0x2FCDFF0", VA = "0x182FCF3F0")]
		public void Clear<T>(T LNKGJNJHIPL) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4020", Offset = "0x6EF2C20", VA = "0x186EF4020")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x2FCF540", Offset = "0x2FCE140", VA = "0x182FCF540")]
		private MLLBOKKBHAO JICGCCBHMME<T>(T LNKGJNJHIPL) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140")]
		public void TrackInstantiation(string JKABJLPLDGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140")]
		public void EnableStats(bool CIABJBIPGCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6EF4190", Offset = "0x6EF2D90", VA = "0x186EF4190")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class MLLBOKKBHAO
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface LDMJLIMJBBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OKMLMEDJIIF(bool ACJNCMDHMAI);
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public abstract string IHBMAHBKJLG
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract int OCHLMAKGBLE
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void KDFGOCLCMFM(int KNHHBEFLJAF, Action<Component> OJIOLLOCPCI);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component DGNCLAFGAIG(Action<Component> AEADFAPPAMC);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool BIODNPDBBKO(Component GLPBHNBBHOB);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void ANKOMBFBDGF();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6EF38A0", Offset = "0x6EF24A0", VA = "0x186EF38A0")]
	protected void ANMOJGMMMAF(Component PLAMADMDGIO, bool ACJNCMDHMAI, bool BGHIDHKKGGO, bool MOAGHAFFGIE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6EF3A20", Offset = "0x6EF2620", VA = "0x186EF3A20")]
	protected void GFELPHNOPLE(Transform HEGBFDMFDGM, bool ACJNCMDHMAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	protected MLLBOKKBHAO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class OBMMHEFDGNF<T> : MLLBOKKBHAO where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T LNKGJNJHIPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool FJBMDBNEFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool BGHIDHKKGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> AMAFDKEBFGK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public override string IHBMAHBKJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4796CA0", Offset = "0x47958A0", VA = "0x184796CA0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override int OCHLMAKGBLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x47969C0", Offset = "0x47955C0", VA = "0x1847969C0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4796DF0", Offset = "0x47959F0", VA = "0x184796DF0")]
	public OBMMHEFDGNF(T LNKGJNJHIPL, ObjectPool FJBMDBNEFCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4796CC0", Offset = "0x47958C0", VA = "0x184796CC0", Slot = "6")]
	public override void KDFGOCLCMFM(int KNHHBEFLJAF, Action<Component> AEADFAPPAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4796A10", Offset = "0x4795610", VA = "0x184796A10", Slot = "7")]
	public override Component DGNCLAFGAIG(Action<Component> AEADFAPPAMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4796810", Offset = "0x4795410", VA = "0x184796810", Slot = "8")]
	public override bool BIODNPDBBKO(Component GLPBHNBBHOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4796480", Offset = "0x4795080", VA = "0x184796480", Slot = "9")]
	public override void ANKOMBFBDGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4796690", Offset = "0x4795290", VA = "0x184796690")]
	private T BFDBEFKMOHC()
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
		public interface DFLNLEAGAFJ
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			GameObject LJAICODKJDP
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
		[Cpp2IlInjected.Address(RVA = "0x6EF3CA0", Offset = "0x6EF28A0", VA = "0x186EF3CA0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3F90", Offset = "0x6EF2B90", VA = "0x186EF3F90")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool MIGLNGCGHPM;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject JNLLNJBFFGL;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static PersistentGlobalPool AAGIFLNDKEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x6EF4960", Offset = "0x6EF3560", VA = "0x186EF4960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6EF48A0", Offset = "0x6EF34A0", VA = "0x186EF48A0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6EF3650", Offset = "0x6EF2250", VA = "0x186EF3650")]
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
		public MLLBOKKBHAO PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x88A130", Offset = "0x888D30", VA = "0x18088A130")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface BIJMKGLJNMA
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int BADOLBHADCN(PooledParticle.AIJPAKFIKPM GGOHEOEPIEI);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum NFFKLJCIAPH
		{
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			NONE,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			POSITION,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			ROTATION,
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			POSITION_AND_ROTATION,
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			VELOCITY
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public enum AIJPAKFIKPM
		{
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			GAMEPLAY_CRITICAL = 1,
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			GAMEPLAY_HIGH_PRI = 2,
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			GAMEPLAY_LOW_PRI = 3,
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			SOCIAL_FEEDBACK = 4,
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			DEFAULT = 0
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public interface DEEKJJKEHLF
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			bool GNHIKFEHDIL
			{
				[Cpp2IlInjected.Token(Token = "0x6000077")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Vector3 GFMMOAIHKBC
			{
				[Cpp2IlInjected.Token(Token = "0x6000078")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Camera HMEEHKBADAF
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
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			[SerializeField]
			private ParticleSystem particleSystem;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			[SerializeField]
			private bool setStartColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			[SerializeField]
			private bool setMinColorOverLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			[SerializeField]
			private bool setMaxColorOverLifetime;

			[Cpp2IlInjected.Token(Token = "0x600007A")]
			[Cpp2IlInjected.Address(RVA = "0x5D9BB70", Offset = "0x5D9A770", VA = "0x185D9BB70")]
			public ColorConfiguration(ParticleSystem HJJHCPCODIG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0x6EF2A80", Offset = "0x6EF1680", VA = "0x186EF2A80")]
			public void HKBEOFBOMCA(Color NKKLIFIFGAP)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class KNLPAJENAIE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
			public KNLPAJENAIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6EF37B0", Offset = "0x6EF23B0", VA = "0x186EF37B0")]
			internal void OONIGFLLIPN(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class PIGACMLJEJO : IEnumerator<HGHICIBNEGP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			private HGHICIBNEGP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private DEEKJJKEHLF <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private HGHICIBNEGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000089")]
				[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x891CE0", Offset = "0x8908E0", VA = "0x180891CE0")]
			[DebuggerHidden]
			public PIGACMLJEJO(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6EF4220", Offset = "0x6EF2E20", VA = "0x186EF4220", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x6EF4850", Offset = "0x6EF3450", VA = "0x186EF4850", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class MKPBAKBOIKF : IEnumerator<HGHICIBNEGP>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private HGHICIBNEGP <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private HGHICIBNEGP System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x891CE0", Offset = "0x8908E0", VA = "0x180891CE0")]
			[DebuggerHidden]
			public MKPBAKBOIKF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x6EF37E0", Offset = "0x6EF23E0", VA = "0x186EF37E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x6EF3850", Offset = "0x6EF2450", VA = "0x186EF3850", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> NEGNENLADHL;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<BIJMKGLJNMA> PIKHFAHBKEH;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static List<PooledParticle> CAGJCNILKJM;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static EIIBBDFHPAD LBBAIOEPOLM;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const float EEAFHPCPLJB = 1f;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static bool AIJDFDAOPCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		protected int HOAEIKBABKC;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private AIJPAKFIKPM category;

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
		private ParticleSystem.MinMaxGradient[] FENIKBNOJNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private bool JNACIPICJBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float GPOOKBNPCHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private float FKJKMBAPHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private Transform DCAJLIGCMFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private Vector3 LODLICJDLBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Vector3 OIIFBAELEMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private NFFKLJCIAPH NGIDNCOKGCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private EIIBBDFHPAD PDCDIBMPDLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		protected bool EIOBPENBGPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private Transform EHGNFGDCBEP;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static IEnumerable<PooledParticle> JCKMHLKLGFN
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x6EF8AF0", Offset = "0x6EF76F0", VA = "0x186EF8AF0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public AIJPAKFIKPM DIOFPOLPNMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x8B07C0", Offset = "0x8AF3C0", VA = "0x1808B07C0")]
			get
			{
				return default(AIJPAKFIKPM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int CPOHHCCFPPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x887AB0", Offset = "0x8866B0", VA = "0x180887AB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool ONEKHMHADID
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6EF8830", Offset = "0x6EF7430", VA = "0x186EF8830")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static int FNJDDDGBFOO
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x6EF89A0", Offset = "0x6EF75A0", VA = "0x186EF89A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected static bool PFJAIDLIJPB
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x6EF6740", Offset = "0x6EF5340", VA = "0x186EF6740")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ParticleSystem FDFLDMKDIPA
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x88ABD0", Offset = "0x8897D0", VA = "0x18088ABD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x88ABC0", Offset = "0x8897C0", VA = "0x18088ABC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem[] GFPOHGLPKKF
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x887B10", Offset = "0x886710", VA = "0x180887B10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x887AE0", Offset = "0x8866E0", VA = "0x180887AE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private ParticleSystemRenderer[] BLMHIKAJJFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x88C720", Offset = "0x88B320", VA = "0x18088C720")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x88C510", Offset = "0x88B110", VA = "0x18088C510")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private NFFKLJCIAPH DKPOJBKBBGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x114BFD0", Offset = "0x114ABD0", VA = "0x18114BFD0")]
			get
			{
				return default(NFFKLJCIAPH);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6EF58E0", Offset = "0x6EF44E0", VA = "0x186EF58E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Transform OHCKGBMFMEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6EF8B40", Offset = "0x6EF7740", VA = "0x186EF8B40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action PMBMHFFGLNN
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x6EF8790", Offset = "0x6EF7390", VA = "0x186EF8790")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x6EF8B90", Offset = "0x6EF7790", VA = "0x186EF8B90")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6EF80D0", Offset = "0x6EF6CD0", VA = "0x186EF80D0")]
		public static PooledParticle TryPlayPrefab(PooledParticle LNKGJNJHIPL, Vector3 GKJAMFFKDLE, Quaternion EAGKGJHHIJH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8280", Offset = "0x6EF6E80", VA = "0x186EF8280")]
		public static PooledParticle TryPlayPrefab(PooledParticle LNKGJNJHIPL, Vector3 GKJAMFFKDLE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7790", Offset = "0x6EF6390", VA = "0x186EF7790")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6EF68F0", Offset = "0x6EF54F0", VA = "0x186EF68F0")]
		private void PCJIBBPFPFJ(bool BFJLCIKEACO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6EF6210", Offset = "0x6EF4E10", VA = "0x186EF6210")]
		[IteratorStateMachine(typeof(PIGACMLJEJO))]
		private static IEnumerator<HGHICIBNEGP> JIOIJJMKOOH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5570", Offset = "0x6EF4170", VA = "0x186EF5570")]
		private static void CIBLNPMIKIA(Stopwatch MDMPBKGCCHN, Vector3 APGJHNDPPBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6EF6840", Offset = "0x6EF5440", VA = "0x186EF6840")]
		private static int PAHNLJJMMGD(PooledParticle CKONCFGMELN, PooledParticle GAAMPOEMOPE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5300", Offset = "0x6EF3F00", VA = "0x186EF5300")]
		private static int BADOLBHADCN(AIJPAKFIKPM GGOHEOEPIEI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x6EF6550", Offset = "0x6EF5150", VA = "0x186EF6550")]
		protected void MHHHIIEBPDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5B70", Offset = "0x6EF4770", VA = "0x186EF5B70")]
		protected void IBLIDGIBCBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6EF50E0", Offset = "0x6EF3CE0", VA = "0x186EF50E0", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6EF6270", Offset = "0x6EF4E70", VA = "0x186EF6270")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6EF67C0", Offset = "0x6EF53C0", VA = "0x186EF67C0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6EF6180", Offset = "0x6EF4D80", VA = "0x186EF6180")]
		[IteratorStateMachine(typeof(MKPBAKBOIKF))]
		private IEnumerator<HGHICIBNEGP> JCCHMOFJAMO(float CPOOPJBHGMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5410", Offset = "0x6EF4010", VA = "0x186EF5410")]
		private void BIODNPDBBKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7EE0", Offset = "0x6EF6AE0", VA = "0x186EF7EE0")]
		public void SetDuration(float CPOOPJBHGMD, bool PCPOHLHAOFC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x6EF6B60", Offset = "0x6EF5760", VA = "0x186EF6B60")]
		public void Play(Transform IHMGLJEAAFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7360", Offset = "0x6EF5F60", VA = "0x186EF7360")]
		public void Play(Transform IHMGLJEAAFF, bool NKEHBNLCCDN, float AKEBGLDOILI = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6EF6D00", Offset = "0x6EF5900", VA = "0x186EF6D00")]
		public void Play(Transform IHMGLJEAAFF, Vector3 OIIFBAELEMC, bool NKEHBNLCCDN, float AKEBGLDOILI = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6EF6E90", Offset = "0x6EF5A90", VA = "0x186EF6E90")]
		public void Play(Transform AGAIICKNFLD, Quaternion EAGKGJHHIJH, bool NKEHBNLCCDN = false, float AKEBGLDOILI = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7520", Offset = "0x6EF6120", VA = "0x186EF7520")]
		public void Play(Transform AGAIICKNFLD, Vector3 OIIFBAELEMC, Quaternion EAGKGJHHIJH, bool NKEHBNLCCDN = false, float AKEBGLDOILI = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7130", Offset = "0x6EF5D30", VA = "0x186EF7130")]
		public void Play(Vector3 GKJAMFFKDLE, Quaternion EAGKGJHHIJH, Vector3 MDMLBPNGPMJ, bool NKEHBNLCCDN = false, float AKEBGLDOILI = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7030", Offset = "0x6EF5C30", VA = "0x186EF7030")]
		public void Play(Vector3 GKJAMFFKDLE, Quaternion EAGKGJHHIJH, bool NKEHBNLCCDN = false, float AKEBGLDOILI = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7250", Offset = "0x6EF5E50", VA = "0x186EF7250")]
		public void Play(bool NKEHBNLCCDN = false, float AKEBGLDOILI = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8040", Offset = "0x6EF6C40", VA = "0x186EF8040")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7FB0", Offset = "0x6EF6BB0", VA = "0x186EF7FB0")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6EF69C0", Offset = "0x6EF55C0", VA = "0x186EF69C0")]
		private void PIGJLEOJDBD(float CPOOPJBHGMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5A30", Offset = "0x6EF4630", VA = "0x186EF5A30")]
		private void GNAHHECLJAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6EF76A0", Offset = "0x6EF62A0", VA = "0x186EF76A0")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6EF7910", Offset = "0x6EF6510", VA = "0x186EF7910")]
		public void SetColor(Color NKKLIFIFGAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6EF5900", Offset = "0x6EF4500", VA = "0x186EF5900")]
		private void FCCKMCICIFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6EF8700", Offset = "0x6EF7300", VA = "0x186EF8700")]
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
