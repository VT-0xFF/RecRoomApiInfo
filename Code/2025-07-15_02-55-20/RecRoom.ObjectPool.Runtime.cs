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
		[Cpp2IlInjected.Address(RVA = "0x84AEDF0", Offset = "0x84AD9F0", VA = "0x1884AEDF0")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles JBPODHEOMGI, float IKMCJBGJIBJ, Vector3 FEMJLOIOGIK, Quaternion DINDLKHALMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x84AEA90", Offset = "0x84AD690", VA = "0x1884AEA90")]
		public void SetDamageValue(float IKMCJBGJIBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x84AEF30", Offset = "0x84ADB30", VA = "0x1884AEF30")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BFKOKCFPCNE<T> : AIDGEFHMIOM<T>, IPNMFPLCPOG, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface LKJGAJBEMLO<T> : IPNMFPLCPOG, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface CLKGODDDDBO
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class IMIMLEMFCNI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class FOMONNAKEMI<T> : FPHFKMKFBPH<T>, BFKOKCFPCNE<T>, AIDGEFHMIOM<T>, IPNMFPLCPOG, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class HMLJJHNINOE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public FOMONNAKEMI<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
			public HMLJJHNINOE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x4FA5770", Offset = "0x4FA4370", VA = "0x184FA5770")]
			internal void GEHOIAPHLML(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x3EAC2E0", Offset = "0x3EAAEE0", VA = "0x183EAC2E0")]
			internal void EAALGDEJIFP(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private MNDBKMIALLI<T> NAHDMAKNNGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool CICJDMMMMIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T MIOFGENCPDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool BNHFKKOIPKI;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4D86BB0", Offset = "0x4D857B0", VA = "0x184D86BB0")]
		public FOMONNAKEMI(MNDBKMIALLI<T> NAHDMAKNNGE, ObjectPool CICJDMMMMIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4D86A10", Offset = "0x4D85610", VA = "0x184D86A10", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class HNANAAHKFPI<T> : PHNKDLMBHEO, LKJGAJBEMLO<T>, IPNMFPLCPOG, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class GLBBFILLHFN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public HNANAAHKFPI<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
			public GLBBFILLHFN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x4EAD070", Offset = "0x4EABC70", VA = "0x184EAD070")]
			internal void GEHOIAPHLML(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x16653F0", Offset = "0x1663FF0", VA = "0x1816653F0")]
			internal void EAALGDEJIFP(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private MNDBKMIALLI<T> NAHDMAKNNGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool BNHFKKOIPKI;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4FAB700", Offset = "0x4FAA300", VA = "0x184FAB700")]
		public HNANAAHKFPI(MNDBKMIALLI<T> NAHDMAKNNGE, ObjectPool CICJDMMMMIK, int GMCOOHGFNHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4FAB6A0", Offset = "0x4FAA2A0", VA = "0x184FAB6A0", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class CJMAHKJFDEI<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public IMIMLEMFCNI <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public FPHFKMKFBPH<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public MNDBKMIALLI<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
		public CJMAHKJFDEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6C2FBD0", Offset = "0x6C2E7D0", VA = "0x186C2FBD0")]
		internal void OODIEOCIJND(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6C2FB20", Offset = "0x6C2E720", VA = "0x186C2FB20")]
		internal void MBMONILLGLC(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6C2FB80", Offset = "0x6C2E780", VA = "0x186C2FB80")]
		internal void MEDMNOJKLBN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<CLKGODDDDBO> IIIMIJBAGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private DGMMEMPNOHO HHNMAJAAKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool CICJDMMMMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool BNHFKKOIPKI;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x84AD470", Offset = "0x84AC070", VA = "0x1884AD470")]
	private static void FNLMFEEKMDJ(Component GCOJJLDOHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x84AD8E0", Offset = "0x84AC4E0", VA = "0x1884AD8E0")]
	public IMIMLEMFCNI(string JOMHOLNGBJJ, int JBCFCBIEGJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3CAE790", Offset = "0x3CAD390", VA = "0x183CAE790")]
	public BFKOKCFPCNE<T> PKHHFIDGGFC<T>(AssetReference NDMLDBHAIJA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3CAE6E0", Offset = "0x3CAD2E0", VA = "0x183CAE6E0")]
	public LKJGAJBEMLO<T> HFPBIMMPFBM<T>(AssetReference NDMLDBHAIJA, int NKGPOLKDIPE) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x3CAE2F0", Offset = "0x3CACEF0", VA = "0x183CAE2F0")]
	public AIDGEFHMIOM<bool> GDLGKCEKPAD<T>(AssetReference NDMLDBHAIJA) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x84AD380", Offset = "0x84ABF80", VA = "0x1884AD380", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x84AD240", Offset = "0x84ABE40", VA = "0x1884AD240")]
	private void CPCOEDEAJMD(UnityEngine.Object DBMJCCGHNMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x84AD6C0", Offset = "0x84AC2C0", VA = "0x1884AD6C0")]
	private ObjectPool NKGKGGAEDKH(string JOMHOLNGBJJ)
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
		private static GlobalPool CFLGCHMMNOH;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject GPEPOCNKJLG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static GlobalPool MFAGMJBMEEP
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x84AD0D0", Offset = "0x84ABCD0", VA = "0x1884AD0D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3C509C0", Offset = "0x3C4F5C0", VA = "0x183C509C0")]
		public static void SafeRelease<T>(T KOJLNGLNBMH) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x84AD000", Offset = "0x84ABC00", VA = "0x1884AD000")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x84AD0C0", Offset = "0x84ABCC0", VA = "0x1884AD0C0")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, CDLKKNJGDHN> PENBHPDECLB;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x3E044C0", Offset = "0x3E030C0", VA = "0x183E044C0")]
		public T Acquire<T>(T JBPODHEOMGI, [Optional] Action<Component> PIKLKCMOIMH) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3E04830", Offset = "0x3E03430", VA = "0x183E04830")]
		public bool Release<T>(T KOJLNGLNBMH) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3E047E0", Offset = "0x3E033E0", VA = "0x183E047E0")]
		public void Prefill<T>(T JBPODHEOMGI, int KGMPHCJCPMP, [Optional] Action<Component> HHFGFCCBGMK) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3E04600", Offset = "0x3E03200", VA = "0x183E04600")]
		public bool Exists<T>(T JBPODHEOMGI) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3E04550", Offset = "0x3E03150", VA = "0x183E04550")]
		public void Clear<T>(T JBPODHEOMGI) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x84AE630", Offset = "0x84AD230", VA = "0x1884AE630")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3E046A0", Offset = "0x3E032A0", VA = "0x183E046A0")]
		private CDLKKNJGDHN KNMFPBHPADG<T>(T JBPODHEOMGI) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020")]
		public void TrackInstantiation(string DDJMIODJIME)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020")]
		public void EnableStats(bool IDNAIKFHJNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x84AE7A0", Offset = "0x84AD3A0", VA = "0x1884AE7A0")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class CDLKKNJGDHN
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface OPEOOOBMHEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void JDJHMFPIDOB(bool MOFPHEHMCLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public abstract string FEGHCLOCPPH
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract int DGOOAGBHPMB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void HFPBIMMPFBM(int NKGPOLKDIPE, Action<Component> HHFGFCCBGMK);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component PKHHFIDGGFC(Action<Component> PIKLKCMOIMH);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool NCHKMOJJHLK(Component EHAANMPGLOP);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void HAGLLFMPLGJ();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x84AC9E0", Offset = "0x84AB5E0", VA = "0x1884AC9E0")]
	protected void NIKDLNPJOKA(Component KOJLNGLNBMH, bool MOFPHEHMCLJ, bool BFCCKEAKKPE, bool LNJJGLJJGKH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x84ACB60", Offset = "0x84AB760", VA = "0x1884ACB60")]
	protected void ODKAGBKOCIC(Transform IFPKDEBBHKC, bool MOFPHEHMCLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
	protected CDLKKNJGDHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class FLFMNBEKHHC<T> : CDLKKNJGDHN where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T JBPODHEOMGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool JGKLBBJCEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool BFCCKEAKKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> DMOADIBCFJH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public override string FEGHCLOCPPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4D7D840", Offset = "0x4D7C440", VA = "0x184D7D840", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override int DGOOAGBHPMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4D7D800", Offset = "0x4D7C400", VA = "0x184D7D800", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4D7DAC0", Offset = "0x4D7C6C0", VA = "0x184D7DAC0")]
	public FLFMNBEKHHC(T JBPODHEOMGI, ObjectPool JGKLBBJCEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4D7D3C0", Offset = "0x4D7BFC0", VA = "0x184D7D3C0", Slot = "6")]
	public override void HFPBIMMPFBM(int NKGPOLKDIPE, Action<Component> PIKLKCMOIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4D7D860", Offset = "0x4D7C460", VA = "0x184D7D860", Slot = "7")]
	public override Component PKHHFIDGGFC(Action<Component> PIKLKCMOIMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4D7D670", Offset = "0x4D7C270", VA = "0x184D7D670", Slot = "8")]
	public override bool NCHKMOJJHLK(Component EHAANMPGLOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4D7D1E0", Offset = "0x4D7BDE0", VA = "0x184D7D1E0", Slot = "9")]
	public override void HAGLLFMPLGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4D7D4C0", Offset = "0x4D7C0C0", VA = "0x184D7D4C0")]
	private T JFDPDGODLPN()
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
		public interface AMDEKDCHDMI
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			GameObject ABPDPFDBHDN
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
		[Cpp2IlInjected.Address(RVA = "0x84AE2B0", Offset = "0x84ACEB0", VA = "0x1884AE2B0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x84AE5A0", Offset = "0x84AD1A0", VA = "0x1884AE5A0")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool CFLGCHMMNOH;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject GPEPOCNKJLG;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static PersistentGlobalPool MFAGMJBMEEP
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x84AE8F0", Offset = "0x84AD4F0", VA = "0x1884AE8F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x84AE830", Offset = "0x84AD430", VA = "0x1884AE830")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x84AD0C0", Offset = "0x84ABCC0", VA = "0x1884AD0C0")]
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
		public CDLKKNJGDHN PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0xA5E010", Offset = "0xA5CC10", VA = "0x180A5E010")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface CBEGNHIHEFD
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int EDKGNIKCCAM(PooledParticle.COHODOPOBJN CJIPCCCFEPA);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum DGFPNAAGJMJ
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
		public enum COHODOPOBJN
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
		public interface FOLIBEEJOPA
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			bool KKDPJIGJFCG
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Vector3 KPGKECOOFJK
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Camera HIAMLDNBIEM
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
			[Cpp2IlInjected.Address(RVA = "0x70772E0", Offset = "0x7075EE0", VA = "0x1870772E0")]
			public ColorConfiguration(ParticleSystem DEKAKPDHDAD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x84ACDE0", Offset = "0x84AB9E0", VA = "0x1884ACDE0")]
			public void GFGHMNGGOEK(Color MGBNCENPLKH)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class FLEBDFNJLNF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xA65A20", Offset = "0xA64620", VA = "0x180A65A20")]
			public FLEBDFNJLNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x84ACFD0", Offset = "0x84ABBD0", VA = "0x1884ACFD0")]
			internal void CJHFFDGGPKE(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class LAHBAANOIGH : IEnumerator<LIPOFPKAEIK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private LIPOFPKAEIK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private FOLIBEEJOPA <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private LIPOFPKAEIK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0xA62C00", Offset = "0xA61800", VA = "0x180A62C00")]
			[DebuggerHidden]
			public LAHBAANOIGH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x84ADB70", Offset = "0x84AC770", VA = "0x1884ADB70", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x84AE1A0", Offset = "0x84ACDA0", VA = "0x1884AE1A0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class OBEOEODHKMI : IEnumerator<LIPOFPKAEIK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			private LIPOFPKAEIK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private LIPOFPKAEIK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0xA5B610", Offset = "0xA5A210", VA = "0x180A5B610", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0xA62C00", Offset = "0xA61800", VA = "0x180A62C00")]
			[DebuggerHidden]
			public OBEOEODHKMI(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0xA5E020", Offset = "0xA5CC20", VA = "0x180A5E020", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x84AE1F0", Offset = "0x84ACDF0", VA = "0x1884AE1F0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x84AE260", Offset = "0x84ACE60", VA = "0x1884AE260", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public static bool OptimizeReleaseMonitoring;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> MLIDLINNLGN;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Lazy<CBEGNHIHEFD> CJCKOCEKEAD;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static List<PooledParticle> HDLFIMCBKMF;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static CCGDPHBOCPE FBCMJACELLF;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const float EKJOCDEJDAH = 1f;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static bool MOIOCIMOEAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		protected int ILHLMNNLFGK;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private COHODOPOBJN category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		protected ColorConfiguration[] colorConfigurations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private float? LDGLCGBPGAH;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public bool IsLooping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private ParticleSystem.MinMaxGradient[] GPJLDKEGDHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private ParticleSystem.MinMaxGradient[] ONJHNFHHLCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private bool LBCBGEPMJLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private float DMBKALONKEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private float DGGLLNFIKDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private Transform NBBIEJLFHEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private Vector3 HIMCHPIJDHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private Vector3 MMNCBFJAHOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private DGFPNAAGJMJ JHIOEKCEAIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private CCGDPHBOCPE OGDBJCGPEBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		protected bool FEIMGFFILFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private Transform AMEHDMMJIGH;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static IEnumerable<PooledParticle> NBBEDBPIMJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x84B2D10", Offset = "0x84B1910", VA = "0x1884B2D10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public COHODOPOBJN CKGBPFJBOHA
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA85600", Offset = "0xA84200", VA = "0x180A85600")]
			get
			{
				return default(COHODOPOBJN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int APKBIGMKCKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA5EBA0", Offset = "0xA5D7A0", VA = "0x180A5EBA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool FDGMPPBDHLI
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x84B2A40", Offset = "0x84B1640", VA = "0x1884B2A40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static int JILDPHFFBFB
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x84B2BC0", Offset = "0x84B17C0", VA = "0x1884B2BC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected static bool MMANLNEKHEG
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x84AFDD0", Offset = "0x84AE9D0", VA = "0x1884AFDD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ParticleSystem HNLNMEMEABP
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA5B5E0", Offset = "0xA5A1E0", VA = "0x180A5B5E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA683D0", Offset = "0xA66FD0", VA = "0x180A683D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem[] DCGBNKHIFCA
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xA5B5A0", Offset = "0xA5A1A0", VA = "0x180A5B5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA5FCB0", Offset = "0xA5E8B0", VA = "0x180A5FCB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private ParticleSystemRenderer[] PIDOPIJEACC
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA5B560", Offset = "0xA5A160", VA = "0x180A5B560")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA5B5D0", Offset = "0xA5A1D0", VA = "0x180A5B5D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private DGFPNAAGJMJ PKFPKKOOCKO
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xEC6320", Offset = "0xEC4F20", VA = "0x180EC6320")]
			get
			{
				return default(DGFPNAAGJMJ);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x84AF420", Offset = "0x84AE020", VA = "0x1884AF420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Transform LMGPODOPMIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x84B2D60", Offset = "0x84B1960", VA = "0x1884B2D60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action HEPKJLHOKAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x84B29A0", Offset = "0x84B15A0", VA = "0x1884B29A0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x84B2DB0", Offset = "0x84B19B0", VA = "0x1884B2DB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x84B23B0", Offset = "0x84B0FB0", VA = "0x1884B23B0")]
		public static PooledParticle TryPlayPrefab(PooledParticle JBPODHEOMGI, Vector3 FEMJLOIOGIK, Quaternion DINDLKHALMD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x84B24D0", Offset = "0x84B10D0", VA = "0x1884B24D0")]
		public static PooledParticle TryPlayPrefab(PooledParticle JBPODHEOMGI, Vector3 FEMJLOIOGIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x84B1AC0", Offset = "0x84B06C0", VA = "0x1884B1AC0")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x84AFD00", Offset = "0x84AE900", VA = "0x1884AFD00")]
		private void KGOKJJMMBLA(bool MNGLOBMLMGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x84AF290", Offset = "0x84ADE90", VA = "0x1884AF290")]
		[IteratorStateMachine(typeof(LAHBAANOIGH))]
		private static IEnumerator<LIPOFPKAEIK> CBFFBAHDCDP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x84AF780", Offset = "0x84AE380", VA = "0x1884AF780")]
		private static void JNJDEDHGMIG(Stopwatch LFPPCCOIMLK, Vector3 BBGHKAGDANG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x84B0D30", Offset = "0x84AF930", VA = "0x1884B0D30")]
		private static int POAFJBLHKPK(PooledParticle OHEOONFKODG, PooledParticle GOPANKCDGOD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x84AF440", Offset = "0x84AE040", VA = "0x1884AF440")]
		private static int EDKGNIKCCAM(COHODOPOBJN CJIPCCCFEPA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x84B0440", Offset = "0x84AF040", VA = "0x1884B0440")]
		protected void OCCDOEBHLAD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x84B0730", Offset = "0x84AF330", VA = "0x1884B0730")]
		protected void PMIMJHAHGHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x84AF010", Offset = "0x84ADC10", VA = "0x1884AF010", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x84AFE50", Offset = "0x84AEA50", VA = "0x1884AFE50")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x84B06A0", Offset = "0x84AF2A0", VA = "0x1884B06A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x84AF6F0", Offset = "0x84AE2F0", VA = "0x1884AF6F0")]
		[IteratorStateMachine(typeof(OBEOEODHKMI))]
		private IEnumerator<LIPOFPKAEIK> JGDOLEEFAMF(float AADMIAHAPGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x84B0180", Offset = "0x84AED80", VA = "0x1884B0180")]
		private void NCHKMOJJHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x84B20F0", Offset = "0x84B0CF0", VA = "0x1884B20F0")]
		public void SetDuration(float AADMIAHAPGN, bool IMNJBONPHDE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x84B0DE0", Offset = "0x84AF9E0", VA = "0x1884B0DE0")]
		public void Play(Transform LEBEMACFJAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x84B1690", Offset = "0x84B0290", VA = "0x1884B1690")]
		public void Play(Transform LEBEMACFJAF, bool CFAHNABNFMK, float MFKCDJIDJFB = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x84B0F40", Offset = "0x84AFB40", VA = "0x1884B0F40")]
		public void Play(Transform LEBEMACFJAF, Vector3 MMNCBFJAHOI, bool CFAHNABNFMK, float MFKCDJIDJFB = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x84B1090", Offset = "0x84AFC90", VA = "0x1884B1090")]
		public void Play(Transform ALEIJJDAHPK, Quaternion DINDLKHALMD, bool CFAHNABNFMK = false, float MFKCDJIDJFB = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x84B1800", Offset = "0x84B0400", VA = "0x1884B1800")]
		public void Play(Transform ALEIJJDAHPK, Vector3 MMNCBFJAHOI, Quaternion DINDLKHALMD, bool CFAHNABNFMK = false, float MFKCDJIDJFB = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x84B1330", Offset = "0x84AFF30", VA = "0x1884B1330")]
		public void Play(Vector3 FEMJLOIOGIK, Quaternion DINDLKHALMD, Vector3 ANDGMPFHLOF, bool CFAHNABNFMK = false, float MFKCDJIDJFB = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x84B11D0", Offset = "0x84AFDD0", VA = "0x1884B11D0")]
		public void Play(Vector3 FEMJLOIOGIK, Quaternion DINDLKHALMD, bool CFAHNABNFMK = false, float MFKCDJIDJFB = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x84B14B0", Offset = "0x84B00B0", VA = "0x1884B14B0")]
		public void Play(bool CFAHNABNFMK = false, float MFKCDJIDJFB = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x84B2310", Offset = "0x84B0F10", VA = "0x1884B2310")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x84B21C0", Offset = "0x84B0DC0", VA = "0x1884B21C0")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x84AF550", Offset = "0x84AE150", VA = "0x1884AF550")]
		private void ENIIGIHKOCA(float AADMIAHAPGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x84AFAF0", Offset = "0x84AE6F0", VA = "0x1884AFAF0")]
		private void JPPMHLLFJMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x84B1930", Offset = "0x84B0530", VA = "0x1884B1930")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x84B1C40", Offset = "0x84B0840", VA = "0x1884B1C40")]
		public void SetColor(Color MGBNCENPLKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x84B0380", Offset = "0x84AEF80", VA = "0x1884B0380")]
		private void NDOAAKLOJLN(float? HCMFNJGJPMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x84B0630", Offset = "0x84AF230", VA = "0x1884B0630")]
		private void OCEGLOJOMNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x84AF2F0", Offset = "0x84ADEF0", VA = "0x1884AF2F0")]
		private void CBGOLFFLEAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x84B2900", Offset = "0x84B1500", VA = "0x1884B2900")]
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
