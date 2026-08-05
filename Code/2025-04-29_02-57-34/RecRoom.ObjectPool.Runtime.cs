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
		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private float minDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private float maxDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[Header("Impact Particle System")]
		[SerializeField]
		private ParticleSystem impactParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[Header("Impact Particle Start Size")]
		[SerializeField]
		private float impactStartSizeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private float impactStartSizeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[Header("Impact Particle Start Lifetime")]
		[SerializeField]
		private float impactStartLifetimeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xCC")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private float impactStartLifetimeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[Header("Spray Particle System")]
		[SerializeField]
		private ParticleSystem sprayParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Header("Spray Particle Burst Count")]
		[SerializeField]
		private int sprayBurstCountMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[SerializeField]
		private int sprayBurstCountMaxDamage;

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7E48F10", Offset = "0x7E48310", VA = "0x187E48F10")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles FODGKNMJPNP, float OPEKFDGKBNK, Vector3 KBPOHLLNAIG, Quaternion PNEDBEMJDJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7E48BB0", Offset = "0x7E47FB0", VA = "0x187E48BB0")]
		public void SetDamageValue(float OPEKFDGKBNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7E49050", Offset = "0x7E48450", VA = "0x187E49050")]
		public PooledDamageParticles()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NCNDMLMAJCD<T> : NDJGFNKMCGL<T>, DKABIBJEBOC, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface DAELBBFIOMG<T> : DKABIBJEBOC, IEnumerator, IDisposable where T : Component
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface HPIMIHKEODD
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OnInstantiate();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MFHMPAAIPHC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class KNCGPLFCEML<T> : DJMJGHEAECO<T>, NCNDMLMAJCD<T>, NDJGFNKMCGL<T>, DKABIBJEBOC, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class BPCBPNLMDLL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public KNCGPLFCEML<T> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public BPCBPNLMDLL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6089990", Offset = "0x6088D90", VA = "0x186089990")]
			internal void DHCBMCCGFFN(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x36EEFD0", Offset = "0x36EE3D0", VA = "0x1836EEFD0")]
			internal void CBPOBNJLAJO(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private PKCCCOBBKFK<T> BGGEGHEDGMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private ObjectPool AIKGAOGLPIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private T KBMKBMHFKMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private bool LLMGCACGBCD;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4E0F510", Offset = "0x4E0E910", VA = "0x184E0F510")]
		public KNCGPLFCEML(PKCCCOBBKFK<T> BGGEGHEDGMM, ObjectPool AIKGAOGLPIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x4E0F3A0", Offset = "0x4E0E7A0", VA = "0x184E0F3A0", Slot = "27")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private class KIKHNAOLLEO<T> : BMFFAGAJAKF, DAELBBFIOMG<T>, DKABIBJEBOC, IEnumerator, IDisposable where T : Component
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class CCOOHBMDOHJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public ObjectPool objectPool;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			public int prefillCount;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public KIKHNAOLLEO<T> <>4__this;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public CCOOHBMDOHJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6465DB0", Offset = "0x64651B0", VA = "0x186465DB0")]
			internal void DHCBMCCGFFN(T prefab)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x138E1C0", Offset = "0x138D5C0", VA = "0x18138E1C0")]
			internal void CBPOBNJLAJO(string e)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private PKCCCOBBKFK<T> BGGEGHEDGMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private bool LLMGCACGBCD;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4DF58D0", Offset = "0x4DF4CD0", VA = "0x184DF58D0")]
		public KIKHNAOLLEO(PKCCCOBBKFK<T> BGGEGHEDGMM, ObjectPool AIKGAOGLPIP, int PGKJDGLCPGI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x4DF5870", Offset = "0x4DF4C70", VA = "0x184DF5870", Slot = "19")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class KLKMLMJHPPC<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public MFHMPAAIPHC <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public DJMJGHEAECO<bool> promise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public PKCCCOBBKFK<T> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
		public KLKMLMJHPPC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4E069F0", Offset = "0x4E05DF0", VA = "0x184E069F0")]
		internal void LKKILHJLNKA(T prefab)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4E06940", Offset = "0x4E05D40", VA = "0x184E06940")]
		internal void BELPBDKNIPE(string e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x4E069A0", Offset = "0x4E05DA0", VA = "0x184E069A0")]
		internal void BLMFMIEKMIO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<HPIMIHKEODD> KHJPDENDFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private HCLAKEHEBKG IMLAAAKIGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private ObjectPool AIKGAOGLPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private bool LLMGCACGBCD;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7E47A60", Offset = "0x7E46E60", VA = "0x187E47A60")]
	private static void OCAACIFGCAO(Component FBIFMODNLFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7E47D40", Offset = "0x7E47140", VA = "0x187E47D40")]
	public MFHMPAAIPHC(string LPHIFBBKFHF, int KJBFHDPPNFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x37BD660", Offset = "0x37BCA60", VA = "0x1837BD660")]
	public NCNDMLMAJCD<T> GEKLKKKAMOM<T>(AssetReference LIHBCAHDPDP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x37BD580", Offset = "0x37BC980", VA = "0x1837BD580")]
	public DAELBBFIOMG<T> BCGEGGFBDOA<T>(AssetReference LIHBCAHDPDP, int PCGLBCNIEAP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x37BD730", Offset = "0x37BCB30", VA = "0x1837BD730")]
	public NDJGFNKMCGL<bool> OJMAIFCODDD<T>(AssetReference LIHBCAHDPDP) where T : Component
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7E477E0", Offset = "0x7E46BE0", VA = "0x187E477E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7E476A0", Offset = "0x7E46AA0", VA = "0x187E476A0")]
	private void DENINHJAGKK(UnityEngine.Object GNBCDODAKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7E478D0", Offset = "0x7E46CD0", VA = "0x187E478D0")]
	private ObjectPool JKLDBFLPAEM(string LPHIFBBKFHF)
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
		private static GlobalPool KIADLHDJGGO;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GameObject ABPALELIAGE;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static GlobalPool IADGMEFIGGI
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7E47500", Offset = "0x7E46900", VA = "0x187E47500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x36CC000", Offset = "0x36CB400", VA = "0x1836CC000")]
		public static void SafeRelease<T>(T KLANNNFBLNB) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7E47430", Offset = "0x7E46830", VA = "0x187E47430")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7E474F0", Offset = "0x7E468F0", VA = "0x187E474F0")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private readonly Dictionary<Component, MJPDKKJBOFD> OPHMDEBOPLP;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x38BBBB0", Offset = "0x38BAFB0", VA = "0x1838BBBB0")]
		public T Acquire<T>(T FODGKNMJPNP, [Optional] Action<Component> JHMOAJGHOMM) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x38BBF70", Offset = "0x38BB370", VA = "0x1838BBF70")]
		public bool Release<T>(T KLANNNFBLNB) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x38BBF00", Offset = "0x38BB300", VA = "0x1838BBF00")]
		public void Prefill<T>(T FODGKNMJPNP, int ANNMLLACLFD, [Optional] Action<Component> NMPOBGKABLF) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x38BBD20", Offset = "0x38BB120", VA = "0x1838BBD20")]
		public bool Exists<T>(T FODGKNMJPNP) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x38BBC70", Offset = "0x38BB070", VA = "0x1838BBC70")]
		public void Clear<T>(T FODGKNMJPNP) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x7E48750", Offset = "0x7E47B50", VA = "0x187E48750")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x38BBDC0", Offset = "0x38BB1C0", VA = "0x1838BBDC0")]
		private MJPDKKJBOFD LLOFIMCFLID<T>(T FODGKNMJPNP) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public void TrackInstantiation(string KHMKPONEOGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public void EnableStats(bool ONDAPLMEIAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x7E488C0", Offset = "0x7E47CC0", VA = "0x187E488C0")]
		public ObjectPool()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class MJPDKKJBOFD
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public interface HEIGMFKALIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MDNKFIENKOP(bool KOIDOLHMLNK);
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public abstract string LIPJOHOCCJK
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract int EDHJOKKJABG
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract void BCGEGGFBDOA(int PCGLBCNIEAP, Action<Component> NMPOBGKABLF);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	public abstract Component GEKLKKKAMOM(Action<Component> JHMOAJGHOMM);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	public abstract bool AOLPCAOCNBA(Component MIBGLNBAKNB);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract void ENAIKFMHAAL();

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7E48250", Offset = "0x7E47650", VA = "0x187E48250")]
	protected void OFDNGCKPJFN(Component KLANNNFBLNB, bool KOIDOLHMLNK, bool BHPBBCOKFKG, bool PCKNCAFNCHH = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x7E47FD0", Offset = "0x7E473D0", VA = "0x187E47FD0")]
	protected void DMIDLEDIMGF(Transform IOOMDGEBMHJ, bool KOIDOLHMLNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
	protected MJPDKKJBOFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class EHDIGOGJGGJ<T> : MJPDKKJBOFD where T : Component
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private T FODGKNMJPNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private ObjectPool MCONIPOPDIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private bool BHPBBCOKFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private Queue<T> PBAFCEHHBKH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public override string LIPJOHOCCJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4396570", Offset = "0x4395970", VA = "0x184396570", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public override int EDHJOKKJABG
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x4396C00", Offset = "0x4396000", VA = "0x184396C00", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4396C60", Offset = "0x4396060", VA = "0x184396C60")]
	public EHDIGOGJGGJ(T FODGKNMJPNP, ObjectPool MCONIPOPDIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4396440", Offset = "0x4395840", VA = "0x184396440", Slot = "6")]
	public override void BCGEGGFBDOA(int PCGLBCNIEAP, Action<Component> JHMOAJGHOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x43967B0", Offset = "0x4395BB0", VA = "0x1843967B0", Slot = "7")]
	public override Component GEKLKKKAMOM(Action<Component> JHMOAJGHOMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4396280", Offset = "0x4395680", VA = "0x184396280", Slot = "8")]
	public override bool AOLPCAOCNBA(Component MIBGLNBAKNB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4396590", Offset = "0x4395990", VA = "0x184396590", Slot = "9")]
	public override void ENAIKFMHAAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x4396A40", Offset = "0x4395E40", VA = "0x184396A40")]
	private T GPGELBHOGAB()
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
		public interface JEPOHFCHEEH
		{
			[Cpp2IlInjected.Token(Token = "0x17000006")]
			GameObject IAICJJEDLLH
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
		[Cpp2IlInjected.Address(RVA = "0x7E483D0", Offset = "0x7E477D0", VA = "0x187E483D0")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x7E486C0", Offset = "0x7E47AC0", VA = "0x187E486C0")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private static PersistentGlobalPool KIADLHDJGGO;

		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private static GameObject ABPALELIAGE;

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public static PersistentGlobalPool IADGMEFIGGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x7E48A10", Offset = "0x7E47E10", VA = "0x187E48A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7E48950", Offset = "0x7E47D50", VA = "0x187E48950")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7E474F0", Offset = "0x7E468F0", VA = "0x187E474F0")]
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
		public MJPDKKJBOFD PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9CB220", Offset = "0x9CA620", VA = "0x1809CB220")]
		public PooledObject()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface DKCKMNGHFEG
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int JODFFBDGPIH(PooledParticle.FPPFGPGCKCP AKJBFKHJGJP);
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		private enum CAKBMNNDDKL
		{
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			NONE,
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			POSITION,
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			ROTATION,
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			POSITION_AND_ROTATION,
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			VELOCITY
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public enum FPPFGPGCKCP
		{
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			GAMEPLAY_CRITICAL = 1,
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			GAMEPLAY_HIGH_PRI = 2,
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			GAMEPLAY_LOW_PRI = 3,
			[Cpp2IlInjected.Token(Token = "0x4000050")]
			SOCIAL_FEEDBACK = 4,
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			DEFAULT = 0
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public interface IAGHBLGPOBP
		{
			[Cpp2IlInjected.Token(Token = "0x17000013")]
			bool HENCGAIAADI
			{
				[Cpp2IlInjected.Token(Token = "0x6000079")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000014")]
			Vector3 PPGLHDAEHAI
			{
				[Cpp2IlInjected.Token(Token = "0x600007A")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000015")]
			Camera HPCJBGJIDPJ
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
			[Cpp2IlInjected.Token(Token = "0x4000052")]
			[SerializeField]
			private ParticleSystem particleSystem;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000053")]
			[SerializeField]
			private bool setStartColor;

			[Cpp2IlInjected.FieldOffset(Offset = "0x19")]
			[Cpp2IlInjected.Token(Token = "0x4000054")]
			[SerializeField]
			private bool setMinColorOverLifetime;

			[Cpp2IlInjected.FieldOffset(Offset = "0x1A")]
			[Cpp2IlInjected.Token(Token = "0x4000055")]
			[SerializeField]
			private bool setMaxColorOverLifetime;

			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0x6B01F80", Offset = "0x6B01380", VA = "0x186B01F80")]
			public ColorConfiguration(ParticleSystem IBMLALMODOD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x7E47180", Offset = "0x7E46580", VA = "0x187E47180")]
			public void IHPFFBBGFFL(Color JLFKDHGAEDA)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		[CompilerGenerated]
		private sealed class HKNBEBDIEKA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public bool enable;

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x9D3E50", Offset = "0x9D3250", VA = "0x1809D3E50")]
			public HKNBEBDIEKA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x7E47670", Offset = "0x7E46A70", VA = "0x187E47670")]
			internal void JGKHLCHEAKD(ParticleSystemRenderer pr)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		[CompilerGenerated]
		private sealed class APGEDIENEEK : IEnumerator<LCENDOCODMB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private LCENDOCODMB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private IAGHBLGPOBP <dependencies>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private Stopwatch <timer>5__3;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private Plane[] <frustumPlanes>5__4;

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			private LCENDOCODMB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600008B")]
				[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x9D51D0", Offset = "0x9D45D0", VA = "0x1809D51D0")]
			[DebuggerHidden]
			public APGEDIENEEK(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000089")]
			[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x7E46B00", Offset = "0x7E45F00", VA = "0x187E46B00", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x7E47130", Offset = "0x7E46530", VA = "0x187E47130", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		[CompilerGenerated]
		private sealed class FHADGPFFIAM : IEnumerator<LCENDOCODMB>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private LCENDOCODMB <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public float duration;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			public PooledParticle <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private LCENDOCODMB System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x9C9200", Offset = "0x9C8600", VA = "0x1809C9200", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x9D51D0", Offset = "0x9D45D0", VA = "0x1809D51D0")]
			[DebuggerHidden]
			public FHADGPFFIAM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x9CB230", Offset = "0x9CA630", VA = "0x1809CB230", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x7E47370", Offset = "0x7E46770", VA = "0x187E47370", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0x7E473E0", Offset = "0x7E467E0", VA = "0x187E473E0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public static bool OptimizeReleaseMonitoring;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> JABENIHMLMJ;

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private static readonly Lazy<DKCKMNGHFEG> CCLILDBBOBD;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static List<PooledParticle> LDJPEHDPHEE;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static DGHHBAELICH LGMLKPGDHBK;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const float IFKJPPDGBHD = 1f;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static bool NLEANABHNHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		protected int ENNEHHCHODI;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private FPPFGPGCKCP category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		protected ColorConfiguration[] colorConfigurations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private float? EPDLAJGGGDO;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public bool IsLooping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private ParticleSystem.MinMaxGradient[] NMBDCDGJIFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private bool OMJFOIANCPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private float HDJMHGDEHBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private float EGOPJFPDKOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private Transform LKOOHFOGEHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private Vector3 PKDMDMANPEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private Vector3 KJOMONOMHPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private CAKBMNNDDKL AOONBBKCFME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private DGHHBAELICH CGJNKGKINMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		protected bool DFNIECNEICP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private Transform DBIIEMKDJHO;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static IEnumerable<PooledParticle> ILHFKKJLBBP
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0x7E4CD70", Offset = "0x7E4C170", VA = "0x187E4CD70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public FPPFGPGCKCP ACGJHCCKOHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x9F2840", Offset = "0x9F1C40", VA = "0x1809F2840")]
			get
			{
				return default(FPPFGPGCKCP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int LINAKMMEDLB
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0x9D5BF0", Offset = "0x9D4FF0", VA = "0x1809D5BF0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool CAMGLHKFOFN
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x7E4CAA0", Offset = "0x7E4BEA0", VA = "0x187E4CAA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static int BNCPBCGJJEO
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7E4CC20", Offset = "0x7E4C020", VA = "0x187E4CC20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		protected static bool DDPMIINMIOI
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x7E498F0", Offset = "0x7E48CF0", VA = "0x187E498F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public ParticleSystem BKHCDPMKKAH
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9C91B0", Offset = "0x9C85B0", VA = "0x1809C91B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x9D24A0", Offset = "0x9D18A0", VA = "0x1809D24A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem[] MFNPPOEBFBH
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9C9230", Offset = "0x9C8630", VA = "0x1809C9230")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x9D24B0", Offset = "0x9D18B0", VA = "0x1809D24B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		private ParticleSystemRenderer[] HDJHJABAMGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9C91F0", Offset = "0x9C85F0", VA = "0x1809C91F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x9C9210", Offset = "0x9C8610", VA = "0x1809C9210")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private CAKBMNNDDKL DOLGFKFIJFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x9D5AD0", Offset = "0x9D4ED0", VA = "0x1809D5AD0")]
			get
			{
				return default(CAKBMNNDDKL);
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x7E498D0", Offset = "0x7E48CD0", VA = "0x187E498D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public Transform NIBJBBEPHBE
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7E4CDC0", Offset = "0x7E4C1C0", VA = "0x187E4CDC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action NBIAPABJOPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7E4CA00", Offset = "0x7E4BE00", VA = "0x187E4CA00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7E4CE10", Offset = "0x7E4C210", VA = "0x187E4CE10")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7E4C410", Offset = "0x7E4B810", VA = "0x187E4C410")]
		public static PooledParticle TryPlayPrefab(PooledParticle FODGKNMJPNP, Vector3 KBPOHLLNAIG, Quaternion PNEDBEMJDJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7E4C530", Offset = "0x7E4B930", VA = "0x187E4C530")]
		public static PooledParticle TryPlayPrefab(PooledParticle FODGKNMJPNP, Vector3 KBPOHLLNAIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7E4BA00", Offset = "0x7E4AE00", VA = "0x187E4BA00")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7E495D0", Offset = "0x7E489D0", VA = "0x187E495D0")]
		private void DHGLGLHMNOD(bool DEFBJFIEEAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7E49730", Offset = "0x7E48B30", VA = "0x187E49730")]
		[IteratorStateMachine(typeof(APGEDIENEEK))]
		private static IEnumerator<LCENDOCODMB> FLCLBFHNLOC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7E4A770", Offset = "0x7E49B70", VA = "0x187E4A770")]
		private static void OGJOMAIGFLG(Stopwatch IHAAMEONBJO, Vector3 DIPFHDIKFHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7E4AD10", Offset = "0x7E4A110", VA = "0x187E4AD10")]
		private static int PNCMFIEMFGD(PooledParticle PPPJAHNPKAO, PooledParticle DFIFINAEGII)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7E49970", Offset = "0x7E48D70", VA = "0x187E49970")]
		private static int JODFFBDGPIH(FPPFGPGCKCP AKJBFKHJGJP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7E4A580", Offset = "0x7E49980", VA = "0x187E4A580")]
		protected void OBICJOMFEON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7E49AF0", Offset = "0x7E48EF0", VA = "0x187E49AF0")]
		protected void LGIKGLEGPMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7E49350", Offset = "0x7E48750", VA = "0x187E49350", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7E4A120", Offset = "0x7E49520", VA = "0x187E4A120")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7E4AC80", Offset = "0x7E4A080", VA = "0x187E4AC80")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x7E496A0", Offset = "0x7E48AA0", VA = "0x187E496A0")]
		[IteratorStateMachine(typeof(FHADGPFFIAM))]
		private IEnumerator<LCENDOCODMB> EIOICNOLBAP(float JGFPKIBNFLI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x7E491F0", Offset = "0x7E485F0", VA = "0x187E491F0")]
		private void AOLPCAOCNBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x7E4C150", Offset = "0x7E4B550", VA = "0x187E4C150")]
		public void SetDuration(float JGFPKIBNFLI, bool BLDOOCGOMAO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x7E4ADC0", Offset = "0x7E4A1C0", VA = "0x187E4ADC0")]
		public void Play(Transform HOBKDCBAHHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7E4B670", Offset = "0x7E4AA70", VA = "0x187E4B670")]
		public void Play(Transform HOBKDCBAHHA, bool ALPACONODNB, float PNKJOKDPGLO = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7E4AF20", Offset = "0x7E4A320", VA = "0x187E4AF20")]
		public void Play(Transform HOBKDCBAHHA, Vector3 KJOMONOMHPB, bool ALPACONODNB, float PNKJOKDPGLO = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7E4B070", Offset = "0x7E4A470", VA = "0x187E4B070")]
		public void Play(Transform ILHDKBOONLH, Quaternion PNEDBEMJDJJ, bool ALPACONODNB = false, float PNKJOKDPGLO = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7E4B7E0", Offset = "0x7E4ABE0", VA = "0x187E4B7E0")]
		public void Play(Transform ILHDKBOONLH, Vector3 KJOMONOMHPB, Quaternion PNEDBEMJDJJ, bool ALPACONODNB = false, float PNKJOKDPGLO = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7E4B310", Offset = "0x7E4A710", VA = "0x187E4B310")]
		public void Play(Vector3 KBPOHLLNAIG, Quaternion PNEDBEMJDJJ, Vector3 GEIOPELMCBI, bool ALPACONODNB = false, float PNKJOKDPGLO = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7E4B1B0", Offset = "0x7E4A5B0", VA = "0x187E4B1B0")]
		public void Play(Vector3 KBPOHLLNAIG, Quaternion PNEDBEMJDJJ, bool ALPACONODNB = false, float PNKJOKDPGLO = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7E4B490", Offset = "0x7E4A890", VA = "0x187E4B490")]
		public void Play(bool ALPACONODNB = false, float PNKJOKDPGLO = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7E4C370", Offset = "0x7E4B770", VA = "0x187E4C370")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7E4C220", Offset = "0x7E4B620", VA = "0x187E4C220")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7E4AAE0", Offset = "0x7E49EE0", VA = "0x187E4AAE0")]
		private void OMHGEFOPIAL(float JGFPKIBNFLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x7E49790", Offset = "0x7E48B90", VA = "0x187E49790")]
		private void GKFFFGONLED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7E4B910", Offset = "0x7E4AD10", VA = "0x187E4B910")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7E4BB80", Offset = "0x7E4AF80", VA = "0x187E4BB80")]
		public void SetColor(Color JLFKDHGAEDA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x7E49130", Offset = "0x7E48530", VA = "0x187E49130")]
		private void AGDMGGDMIDA(float? ILKAOEMIOFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x7E49A80", Offset = "0x7E48E80", VA = "0x187E49A80")]
		private void KBCHJFKFMAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7E4A450", Offset = "0x7E49850", VA = "0x187E4A450")]
		private void MKMNMBNFOAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7E4C960", Offset = "0x7E4BD60", VA = "0x187E4C960")]
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
