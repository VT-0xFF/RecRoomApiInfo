using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.AssetBundles;
using RecRoom.Async;
using RecRoom.Core.Pools;
using RecRoom.DataStructures.ResourceHandles;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Rendering.Universal;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD100C0", Offset = "0xD0EEC0", VA = "0x180D100C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecRoom.Activities
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class PooledDamageParticles : PooledParticle
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private float minDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private float maxDamageValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[Header("Impact Particle System")]
		[SerializeField]
		private ParticleSystem impactParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[Header("Impact Particle Start Size")]
		[SerializeField]
		private float impactStartSizeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		private float impactStartSizeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[Header("Impact Particle Start Lifetime")]
		[SerializeField]
		private float impactStartLifetimeMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xDC")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private float impactStartLifetimeMaxDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[Header("Spray Particle System")]
		[SerializeField]
		private ParticleSystem sprayParticleSystem;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		[Header("Spray Particle Burst Count")]
		[SerializeField]
		private int sprayBurstCountMinDamage;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		[SerializeField]
		private int sprayBurstCountMaxDamage;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x9C11E20", Offset = "0x9C10C20", VA = "0x189C11E20")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles prefab, float damage, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9C11AC0", Offset = "0x9C108C0", VA = "0x189C11AC0")]
		public void SetDamageValue(float damage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9C11F60", Offset = "0x9C10D60", VA = "0x189C11F60")]
		public PooledDamageParticles()
		{
		}
	}
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface MDJFNXOPSIZ<a> : CCAFLELIKTY<a>, NFPDGBDVXFD, IEnumerator, IDisposable where a : Component
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface EMMEAWRLCEY<a> : NFPDGBDVXFD, IEnumerator, IDisposable where a : Component
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface LAFDXEHAYEV
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnInstantiate();
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class BNZEZUAERBT : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class YEJITSQEWWE<a> : LAVOWZFLROR<a>, MDJFNXOPSIZ<a>, CCAFLELIKTY<a>, NFPDGBDVXFD, IEnumerator, IDisposable where a : Component
		{
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			[CompilerGenerated]
			private sealed class FXRJPUNQTQT
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public YEJITSQEWWE<a> XRWOWCJVPDZ;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public ObjectPool GALYRMGWSHO;

				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public FXRJPUNQTQT()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000013")]
				[Cpp2IlInjected.Address(RVA = "0x62AE020", Offset = "0x62ACE20", VA = "0x1862AE020")]
				internal void ACZJUZCAUSN(a a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x62ADFF0", Offset = "0x62ACDF0", VA = "0x1862ADFF0")]
				internal void ACUCXSIDLHE(string a)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private OIRALRYLARL<a> ZSKYGQRHQNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private ObjectPool GALYRMGWSHO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private a OUAYFCUQLSG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private bool DZPJVTCESGG;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x5097120", Offset = "0x5095F20", VA = "0x185097120")]
			public YEJITSQEWWE(OIRALRYLARL<a> a, ObjectPool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x5096FE0", Offset = "0x5095DE0", VA = "0x185096FE0", Slot = "27")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class MKOAWLIRVFF<a> : WSVTGTOMDSW, EMMEAWRLCEY<a>, NFPDGBDVXFD, IEnumerator, IDisposable where a : Component
		{
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			[CompilerGenerated]
			private sealed class FUIFISZXLYJ
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public ObjectPool GALYRMGWSHO;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000019")]
				public int DLARFRUNRWW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public MKOAWLIRVFF<a> XRWOWCJVPDZ;

				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
				public FUIFISZXLYJ()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0x62AC8B0", Offset = "0x62AB6B0", VA = "0x1862AC8B0")]
				internal void ACZJUZCAUSN(a a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0x174D680", Offset = "0x174C480", VA = "0x18174D680")]
				internal void ACUCXSIDLHE(string a)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private OIRALRYLARL<a> ZSKYGQRHQNN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private bool DZPJVTCESGG;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6ED4F90", Offset = "0x6ED3D90", VA = "0x186ED4F90")]
			public MKOAWLIRVFF(OIRALRYLARL<a> a, ObjectPool b, int c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6ED4F30", Offset = "0x6ED3D30", VA = "0x186ED4F30", Slot = "19")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class ZDDDZQHUXAH<a> where a : Component
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public BNZEZUAERBT XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public LAVOWZFLROR<bool> HPPUAAUZLNQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public OIRALRYLARL<a> ZSKYGQRHQNN;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
			public ZDDDZQHUXAH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x50FF610", Offset = "0x50FE410", VA = "0x1850FF610")]
			internal void KAFKWKIQETV(a a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x50FF5B0", Offset = "0x50FE3B0", VA = "0x1850FF5B0")]
			internal void KAADZDOSVIM(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x50FF6A0", Offset = "0x50FE4A0", VA = "0x1850FF6A0")]
			internal void KAPYQXWKXQN()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly List<LAFDXEHAYEV> JVTQXWIJNRD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private TIRCQWBTTJD YTHFMBKYZLV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private ObjectPool GALYRMGWSHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private bool DZPJVTCESGG;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9C0FD70", Offset = "0x9C0EB70", VA = "0x189C0FD70")]
		private static void RIHREYZTDPH(Component a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9C10310", Offset = "0x9C0F110", VA = "0x189C10310")]
		public BNZEZUAERBT(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3718F50", Offset = "0x3717D50", VA = "0x183718F50")]
		public MDJFNXOPSIZ<T> Acquire<T>(AssetReference assetReference) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x37193C0", Offset = "0x37181C0", VA = "0x1837193C0")]
		public EMMEAWRLCEY<a> OGWKGXMDLBJ<a>(AssetReference a, int b) where a : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3719000", Offset = "0x3717E00", VA = "0x183719000")]
		public CCAFLELIKTY<bool> Exists<T>(AssetReference assetReference) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9C0FC80", Offset = "0x9C0EA80", VA = "0x189C0FC80", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9C0FFC0", Offset = "0x9C0EDC0", VA = "0x189C0FFC0")]
		private void SXNMTIFJZBR(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9C10100", Offset = "0x9C0EF00", VA = "0x189C10100")]
		private ObjectPool ZWIODIIPCOB(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class GlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GlobalPool HBCZULAESVD;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static GameObject SATZNNQHVTZ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static GlobalPool GFQGJWBHKJM
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x9C111C0", Offset = "0x9C0FFC0", VA = "0x189C111C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3ACA780", Offset = "0x3AC9580", VA = "0x183ACA780")]
		public static void SafeRelease<T>(T obj) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9C110F0", Offset = "0x9C0FEF0", VA = "0x189C110F0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9C111B0", Offset = "0x9C0FFB0", VA = "0x189C111B0")]
		public GlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class ObjectPool : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public readonly struct PooledObject<T> : IDisposable where T : Component
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private readonly T toReturn;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private readonly ObjectPool pool;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public T PGGBLURLEPI
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0xEBF7B0", Offset = "0xEBE5B0", VA = "0x180EBF7B0")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x10D4C40", Offset = "0x10D3A40", VA = "0x1810D4C40")]
			internal PooledObject(T value, ObjectPool pool)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x74005B0", Offset = "0x73FF3B0", VA = "0x1874005B0", Slot = "4")]
			private void QRJGYHJVBJO()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly Dictionary<Component, GYZYZYAOQYQ> JIKLRMFICMF;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3D79E80", Offset = "0x3D78C80", VA = "0x183D79E80")]
		public T Acquire<T>(T prefab, [Optional] Action<Component> invokeOnNewInstance) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3D79D80", Offset = "0x3D78B80", VA = "0x183D79D80")]
		public PooledObject<T> AcquirePooledObject<T>(T prefab, [Optional] Action<Component> invokeOnNewInstance) where T : Component
		{
			return default(PooledObject<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3D7A260", Offset = "0x3D79060", VA = "0x183D7A260")]
		public bool Release<T>(T obj) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3D7A1D0", Offset = "0x3D78FD0", VA = "0x183D7A1D0")]
		public void Prefill<T>(T prefab, int numInstances, [Optional] Action<Component> invokePerNewInstance) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3D79FF0", Offset = "0x3D78DF0", VA = "0x183D79FF0")]
		public bool Exists<T>(T prefab) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3D79F40", Offset = "0x3D78D40", VA = "0x183D79F40")]
		public void Clear<T>(T prefab) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9C11680", Offset = "0x9C10480", VA = "0x189C11680")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3D7A090", Offset = "0x3D78E90", VA = "0x183D7A090")]
		private GYZYZYAOQYQ OZPAYRDKAGN<a>(a a) where a : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
		public void TrackInstantiation(string objectName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
		public void EnableStats(bool shouldEnable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9C117F0", Offset = "0x9C105F0", VA = "0x189C117F0")]
		public ObjectPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public abstract class GYZYZYAOQYQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public interface NJJFBFCELHL
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void EBLYWHGGOEB(bool a);
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public abstract string CTZDLOJAEUK
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public abstract int EYMWZDWSJJX
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void OGWKGXMDLBJ(int a, Action<Component> b);

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract Component Acquire(Action<Component> invokeOnNewInstance);

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract bool Release(Component behaviour);

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "9")]
		public abstract void Clear();

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9C10F70", Offset = "0x9C0FD70", VA = "0x189C10F70")]
		protected void TZDHCVHMCZT(Component a, bool b, bool c, bool d = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9C10CF0", Offset = "0x9C0FAF0", VA = "0x189C10CF0")]
		protected void LLCGVTDTYCX(Transform a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		protected GYZYZYAOQYQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class BBCIWUGVBVF<a> : GYZYZYAOQYQ where a : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private a OTBMMJMUKXZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private ObjectPool FMGCVEVFYBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool OHYRMMCYIZA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private Queue<a> KIRQSFJVNFW;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override string CTZDLOJAEUK
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x4EB07A0", Offset = "0x4EAF5A0", VA = "0x184EB07A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override int EYMWZDWSJJX
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x4EB0D20", Offset = "0x4EAFB20", VA = "0x184EB0D20", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4EB0D40", Offset = "0x4EAFB40", VA = "0x184EB0D40")]
		public BBCIWUGVBVF(a a, ObjectPool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4EB07C0", Offset = "0x4EAF5C0", VA = "0x184EB07C0", Slot = "6")]
		public override void OGWKGXMDLBJ(int a, Action<Component> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x4EB03B0", Offset = "0x4EAF1B0", VA = "0x184EB03B0", Slot = "7")]
		public override Component Acquire(Action<Component> invokeOnNewInstance)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x4EB0A00", Offset = "0x4EAF800", VA = "0x184EB0A00", Slot = "8")]
		public override bool Release(Component behaviour)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x4EB05D0", Offset = "0x4EAF3D0", VA = "0x184EB05D0", Slot = "9")]
		public override void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x4EB0B80", Offset = "0x4EAF980", VA = "0x184EB0B80")]
		private a TDZDFRKEWOJ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class ObjectPoolPreFill : MonoBehaviour
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public struct PrefillDataEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			public Component prefab;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			public int numInstances;
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public interface WSUHMORANTU
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			GameObject GBROGOAMMCM
			{
				[Cpp2IlInjected.Token(Token = "0x6000045")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public List<PrefillDataEntry> PrefillData;

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9C11320", Offset = "0x9C10120", VA = "0x189C11320")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9C11600", Offset = "0x9C10400", VA = "0x189C11600")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static PersistentGlobalPool HBCZULAESVD;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static GameObject SATZNNQHVTZ;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static PersistentGlobalPool GFQGJWBHKJM
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x9C11930", Offset = "0x9C10730", VA = "0x189C11930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9C11870", Offset = "0x9C10670", VA = "0x189C11870")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9C111B0", Offset = "0x9C0FFB0", VA = "0x189C111B0")]
		public PersistentGlobalPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class PooledObject : MonoBehaviour
	{
		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public GYZYZYAOQYQ PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xCE6140", Offset = "0xCE4F40", VA = "0x180CE6140")]
		public PooledObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface CLYZIBUHXSQ
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		int GetCategoryPriority(PooledParticle.ParticleCategory category);
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[RequireComponent(typeof(ParticleSystem))]
	public class PooledParticle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001B")]
		private enum FollowType
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

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public enum ParticleCategory
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

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public interface VGKDWJTDDZL
		{
			[Cpp2IlInjected.Token(Token = "0x17000015")]
			bool KUCWUKTQWXL
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			Vector3 QETVYOBMLAK
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			Camera CIDRBNZPOPG
			{
				[Cpp2IlInjected.Token(Token = "0x6000083")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}
		}

		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x200001E")]
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

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x87D2D50", Offset = "0x87D1B50", VA = "0x1887D2D50")]
			public ColorConfiguration(ParticleSystem mainParticles)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x9C10580", Offset = "0x9C0F380", VA = "0x189C10580")]
			public void ZXHLQYKLNRY(Color a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class FGLJBEMHRCE : IEnumerator<IUPNMORLIQV>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private int AKEYILDVZEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private IUPNMORLIQV OCEUOVLOMMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private VGKDWJTDDZL GUWBNTUIRWR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private Stopwatch VRPFEOPKIIE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private Plane[] RVAXDTZLZKZ;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private IUPNMORLIQV BIZXNLKFYPO
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0xCE7B30", Offset = "0xCE6930", VA = "0x180CE7B30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xCEAA60", Offset = "0xCE9860", VA = "0x180CEAA60")]
			[DebuggerHidden]
			public FGLJBEMHRCE(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "5")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x9C10770", Offset = "0x9C0F570", VA = "0x189C10770", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x9C10CB0", Offset = "0x9C0FAB0", VA = "0x189C10CB0", Slot = "8")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> CKAUNVROXIY;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly Lazy<CLYZIBUHXSQ> ZKPOZPPAMBG;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static List<PooledParticle> EDAZSVGJFOA;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static VOFDHKTSCRY FZUERPSPAVV;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const float FHNIGEMBETY = 1f;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static bool QJILCHIJIBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		protected int TSYZZLLCRRU;

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public static int MaximumParticleCountOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private ParticleCategory category;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		protected ColorConfiguration[] colorConfigurations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private float? WZOJTBLODDG;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public bool IsLooping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private ParticleSystem.MinMaxGradient[] SCODCWXOFHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private ParticleSystem.MinMaxGradient[] RSYFTFYIKJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private bool FOTFJUGOKQL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private float YABJUPQLAWN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private float DNFUHUPYOZT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private Transform GXRXFPXBHER;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private Vector3 ABOBELOZKBV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Vector3 IXSILSFXSOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private FollowType QIGAAIQVXOV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private VOFDHKTSCRY ZJWNPQHUPEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		protected bool ZXRKXCUUTGZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private Transform GZAWWSQTFEF;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static IEnumerable<PooledParticle> WQEEOYVASBX
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9C15D10", Offset = "0x9C14B10", VA = "0x189C15D10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ParticleCategory AGQCPAQCEAV
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xD0DFF0", Offset = "0xD0CDF0", VA = "0x180D0DFF0")]
			get
			{
				return default(ParticleCategory);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int VHUTOIREZWC
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xCF75E0", Offset = "0xCF63E0", VA = "0x180CF75E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool TKCLWUCJLDQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x9C13580", Offset = "0x9C12380", VA = "0x189C13580")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static int JHQTIBCTHNY
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9C15BC0", Offset = "0x9C149C0", VA = "0x189C15BC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected static bool BNDJVKNDJVJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x9C15450", Offset = "0x9C14250", VA = "0x189C15450")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem EHFPZYUALBQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xCE7A20", Offset = "0xCE6820", VA = "0x180CE7A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xCED340", Offset = "0xCEC140", VA = "0x180CED340")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ParticleSystem[] GXIVFNUCIJW
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xCE8280", Offset = "0xCE7080", VA = "0x180CE8280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xCE7B50", Offset = "0xCE6950", VA = "0x180CE7B50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private ParticleSystemRenderer[] WDTJDJNIDCX
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xCE7A30", Offset = "0xCE6830", VA = "0x180CE7A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xCE8260", Offset = "0xCE7060", VA = "0x180CE8260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float ZWSDMIDRVNH
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xD1D090", Offset = "0xD1BE90", VA = "0x180D1D090")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private FollowType EGGQFFPYVEA
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xCF4940", Offset = "0xCF3740", VA = "0x180CF4940")]
			get
			{
				return default(FollowType);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x9C13920", Offset = "0x9C12720", VA = "0x189C13920")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Transform TKCNCOJLDNZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x9C15D60", Offset = "0x9C14B60", VA = "0x189C15D60")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action SBMUNZRNPSS
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x9C15B20", Offset = "0x9C14920", VA = "0x189C15B20")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x9C15DB0", Offset = "0x9C14BB0", VA = "0x189C15DB0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9C151B0", Offset = "0x9C13FB0", VA = "0x189C151B0")]
		public static PooledParticle TryPlayPrefab(PooledParticle prefab, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9C152D0", Offset = "0x9C140D0", VA = "0x189C152D0")]
		public static PooledParticle TryPlayPrefab(PooledParticle prefab, Vector3 position)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9C14920", Offset = "0x9C13720", VA = "0x189C14920")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9C12D20", Offset = "0x9C11B20", VA = "0x189C12D20")]
		private void ITUMBTEEKTY(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9C13580", Offset = "0x9C12380", VA = "0x189C13580")]
		private bool MGWSKBQHWTP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9C12EB0", Offset = "0x9C11CB0", VA = "0x189C12EB0")]
		private Bounds JBZJCFIATUN()
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9C154D0", Offset = "0x9C142D0", VA = "0x189C154D0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private static void WBHRQOKTIUG(ParticleSystemRenderer a, int b, UnityEngine.Object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9C157C0", Offset = "0x9C145C0", VA = "0x189C157C0")]
		[IteratorStateMachine(typeof(FGLJBEMHRCE))]
		private static IEnumerator<IUPNMORLIQV> YLJYGERNMKA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9C129B0", Offset = "0x9C117B0", VA = "0x189C129B0")]
		private static void FELKTMJQMWR(Stopwatch a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9C13770", Offset = "0x9C12570", VA = "0x189C13770")]
		private static int MPNAUGAXLIN(PooledParticle a, PooledParticle b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9C13660", Offset = "0x9C12460", VA = "0x189C13660")]
		private static int MNKBXRSEEDJ(ParticleCategory a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9C12040", Offset = "0x9C10E40", VA = "0x189C12040")]
		protected void ADLENEWIXEV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9C124A0", Offset = "0x9C112A0", VA = "0x189C124A0")]
		protected void CHAYDROWLLU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9C12230", Offset = "0x9C11030", VA = "0x189C12230", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9C13240", Offset = "0x9C12040", VA = "0x189C13240")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9C13820", Offset = "0x9C12620", VA = "0x189C13820")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9C14590", Offset = "0x9C13390", VA = "0x189C14590")]
		private void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9C14F40", Offset = "0x9C13D40", VA = "0x189C14F40")]
		public void SetDuration(float duration, bool setStartLifetime = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9C13940", Offset = "0x9C12740", VA = "0x189C13940")]
		public void Play(Transform followTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9C141C0", Offset = "0x9C12FC0", VA = "0x189C141C0")]
		public void Play(Transform followTransform, bool loop, float sizeMultiplier = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9C13AA0", Offset = "0x9C128A0", VA = "0x189C13AA0")]
		public void Play(Transform followTransform, Vector3 followWorldSpaceOffset, bool loop, float sizeMultiplier = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9C13BF0", Offset = "0x9C129F0", VA = "0x189C13BF0")]
		public void Play(Transform followPosition, Quaternion rotation, bool loop = false, float sizeMultiplier = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9C14330", Offset = "0x9C13130", VA = "0x189C14330")]
		public void Play(Transform followPosition, Vector3 followWorldSpaceOffset, Quaternion rotation, bool loop = false, float sizeMultiplier = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9C13EA0", Offset = "0x9C12CA0", VA = "0x189C13EA0")]
		public void Play(Vector3 position, Quaternion rotation, Vector3 velocity, bool loop = false, float sizeMultiplier = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9C13D40", Offset = "0x9C12B40", VA = "0x189C13D40")]
		public void Play(Vector3 position, Quaternion rotation, bool loop = false, float sizeMultiplier = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9C14020", Offset = "0x9C12E20", VA = "0x189C14020")]
		public void Play(bool loop = false, float sizeMultiplier = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x9C15110", Offset = "0x9C13F10", VA = "0x189C15110")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9C15010", Offset = "0x9C13E10", VA = "0x189C15010")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9C155B0", Offset = "0x9C143B0", VA = "0x189C155B0")]
		private void XHOEIUGWOGJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9C14790", Offset = "0x9C13590", VA = "0x189C14790")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9C14A90", Offset = "0x9C13890", VA = "0x189C14A90")]
		public void SetColor(Color color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9C12DF0", Offset = "0x9C11BF0", VA = "0x189C12DF0")]
		private void IVJHJRRCXDE(float? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x9C138B0", Offset = "0x9C126B0", VA = "0x189C138B0")]
		private void PLFSYNTJOMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9C14460", Offset = "0x9C13260", VA = "0x189C14460")]
		private void RZZHCCPERBB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9C15A80", Offset = "0x9C14880", VA = "0x189C15A80")]
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
