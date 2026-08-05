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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0xD19850", Offset = "0xD18450", VA = "0x180D19850")]
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
		[Cpp2IlInjected.Address(RVA = "0x9C2A200", Offset = "0x9C28E00", VA = "0x189C2A200")]
		public static PooledDamageParticles TryPlayDamageParticlePrefab(PooledDamageParticles prefab, float damage, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9C29EA0", Offset = "0x9C28AA0", VA = "0x189C29EA0")]
		public void SetDamageValue(float damage)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9C2A340", Offset = "0x9C28F40", VA = "0x189C2A340")]
		public PooledDamageParticles()
		{
		}
	}
}
namespace RecRoom.Core.Pools
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public interface KBIDIDHLQVQ<a> : IMNXFPWKHPJ<a>, GMTKWIVSBCA, IEnumerator, IDisposable where a : Component
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface GGQNAOUSQJH<a> : GMTKWIVSBCA, IEnumerator, IDisposable where a : Component
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface WZBKMBYOMMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void OnInstantiate();
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class QTXZTIQAVSO : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class SRZDPVPPELD<a> : GLBOOOEYLYS<a>, KBIDIDHLQVQ<a>, IMNXFPWKHPJ<a>, GMTKWIVSBCA, IEnumerator, IDisposable where a : Component
		{
			[Cpp2IlInjected.Token(Token = "0x200000A")]
			[CompilerGenerated]
			private sealed class LZUZORPWDSO
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000014")]
				public SRZDPVPPELD<a> DIJXGYBMMZW;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000015")]
				public ObjectPool GVNBLBDIWPP;

				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public LZUZORPWDSO()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000013")]
				[Cpp2IlInjected.Address(RVA = "0x68B4470", Offset = "0x68B3070", VA = "0x1868B4470")]
				internal void HULOWDNKMXU(a a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000014")]
				[Cpp2IlInjected.Address(RVA = "0x68B4570", Offset = "0x68B3170", VA = "0x1868B4570")]
				internal void HUQVTKHHWJD(string a)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			private DVNZWAEHOWC<a> PCQJNKPSXMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000011")]
			private ObjectPool GVNBLBDIWPP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000012")]
			private a CYXBXYXEPKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000013")]
			private bool IXEHIPWMHET;

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x792E980", Offset = "0x792D580", VA = "0x18792E980")]
			public SRZDPVPPELD(DVNZWAEHOWC<a> a, ObjectPool b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x792E840", Offset = "0x792D440", VA = "0x18792E840", Slot = "27")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		private class NLRQFAHZPHW<a> : YNVUIOBZBUF, GGQNAOUSQJH<a>, GMTKWIVSBCA, IEnumerator, IDisposable where a : Component
		{
			[Cpp2IlInjected.Token(Token = "0x200000C")]
			[CompilerGenerated]
			private sealed class UFMXOEVUXJC
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000018")]
				public ObjectPool GVNBLBDIWPP;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000019")]
				public int VGQDMPCZAFR;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public NLRQFAHZPHW<a> DIJXGYBMMZW;

				[Cpp2IlInjected.Token(Token = "0x6000017")]
				[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
				public UFMXOEVUXJC()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000018")]
				[Cpp2IlInjected.Address(RVA = "0x7D2F0F0", Offset = "0x7D2DCF0", VA = "0x187D2F0F0")]
				internal void HULOWDNKMXU(a a)
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000019")]
				[Cpp2IlInjected.Address(RVA = "0x176BF70", Offset = "0x176AB70", VA = "0x18176BF70")]
				internal void HUQVTKHHWJD(string a)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000016")]
			private DVNZWAEHOWC<a> PCQJNKPSXMG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000017")]
			private bool IXEHIPWMHET;

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7155C00", Offset = "0x7154800", VA = "0x187155C00")]
			public NLRQFAHZPHW(DVNZWAEHOWC<a> a, ObjectPool b, int c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7155BA0", Offset = "0x71547A0", VA = "0x187155BA0", Slot = "19")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private sealed class ZGTUVCHEGWQ<a> where a : Component
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public QTXZTIQAVSO DIJXGYBMMZW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public GLBOOOEYLYS<bool> MXZXSYNLTDH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public DVNZWAEHOWC<a> PCQJNKPSXMG;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public ZGTUVCHEGWQ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x51411C0", Offset = "0x513FDC0", VA = "0x1851411C0")]
			internal void TMVACIQZLXU(a a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5141250", Offset = "0x513FE50", VA = "0x185141250")]
			internal void TNAGZPKWVJD(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x5141170", Offset = "0x513FD70", VA = "0x185141170")]
			internal void TMKMHVDETBC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private static readonly List<WZBKMBYOMMI> JJQPMKJMJXW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private GMHXBZMLFPE EEWZIQOAVQO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private ObjectPool GVNBLBDIWPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private bool IXEHIPWMHET;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9C2E460", Offset = "0x9C2D060", VA = "0x189C2E460")]
		private static void UALYQPOIENA(Component a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9C2E8C0", Offset = "0x9C2D4C0", VA = "0x189C2E8C0")]
		public QTXZTIQAVSO(string a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x3E3B3E0", Offset = "0x3E39FE0", VA = "0x183E3B3E0")]
		public KBIDIDHLQVQ<T> Acquire<T>(AssetReference assetReference) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x3E3B730", Offset = "0x3E3A330", VA = "0x183E3B730")]
		public GGQNAOUSQJH<a> NDMELFFZPEI<a>(AssetReference a, int b) where a : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x3E3B490", Offset = "0x3E3A090", VA = "0x183E3B490")]
		public IMNXFPWKHPJ<bool> Exists<T>(AssetReference assetReference) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9C2E230", Offset = "0x9C2CE30", VA = "0x189C2E230", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9C2E320", Offset = "0x9C2CF20", VA = "0x189C2E320")]
		private void SXKYIYMBBVM(UnityEngine.Object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9C2E6B0", Offset = "0x9C2D2B0", VA = "0x189C2E6B0")]
		private ObjectPool VRULZFTUBDM(string a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class GlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static GlobalPool CUYIASSGSRY;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static GameObject XVYOXQGORCC;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static GlobalPool UXEDIFVFAQD
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x9C29020", Offset = "0x9C27C20", VA = "0x189C29020")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x3AE4960", Offset = "0x3AE3560", VA = "0x183AE4960")]
		public static void SafeRelease<T>(T obj) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9C28F50", Offset = "0x9C27B50", VA = "0x189C28F50")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9C29010", Offset = "0x9C27C10", VA = "0x189C29010")]
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
			public T YMGSSSXYISN
			{
				[Cpp2IlInjected.Token(Token = "0x600002E")]
				[Cpp2IlInjected.Address(RVA = "0xEC8090", Offset = "0xEC6C90", VA = "0x180EC8090")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x10DD600", Offset = "0x10DC200", VA = "0x1810DD600")]
			internal PooledObject(T value, ObjectPool pool)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x741ABF0", Offset = "0x74197F0", VA = "0x18741ABF0", Slot = "4")]
			private void PEABEYBFILL()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private readonly Dictionary<Component, ZEMNOGIHXLJ> BKUYEKQEKDY;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3D8CA20", Offset = "0x3D8B620", VA = "0x183D8CA20")]
		public T Acquire<T>(T prefab, [Optional] Action<Component> invokeOnNewInstance) where T : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x3D8C920", Offset = "0x3D8B520", VA = "0x183D8C920")]
		public PooledObject<T> AcquirePooledObject<T>(T prefab, [Optional] Action<Component> invokeOnNewInstance) where T : Component
		{
			return default(PooledObject<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x3D8CE00", Offset = "0x3D8BA00", VA = "0x183D8CE00")]
		public bool Release<T>(T obj) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x3D8CD70", Offset = "0x3D8B970", VA = "0x183D8CD70")]
		public void Prefill<T>(T prefab, int numInstances, [Optional] Action<Component> invokePerNewInstance) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x3D8CB90", Offset = "0x3D8B790", VA = "0x183D8CB90")]
		public bool Exists<T>(T prefab) where T : Component
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3D8CAE0", Offset = "0x3D8B6E0", VA = "0x183D8CAE0")]
		public void Clear<T>(T prefab) where T : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9C29A60", Offset = "0x9C28660", VA = "0x189C29A60")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3D8CC30", Offset = "0x3D8B830", VA = "0x183D8CC30")]
		private ZEMNOGIHXLJ FBUUIJJROLG<a>(a a) where a : Component
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
		public void TrackInstantiation(string objectName)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
		public void EnableStats(bool shouldEnable)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
		public void ResetStats()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9C29BD0", Offset = "0x9C287D0", VA = "0x189C29BD0")]
		public ObjectPool()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public abstract class ZEMNOGIHXLJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public interface OIKQPVEMWGG
		{
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(Slot = "0")]
			void OFTKCNYXLVU(bool a);
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public abstract string AZGBUIWNJKT
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public abstract int PZRZKGZQOZY
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "6")]
		public abstract void NDMELFFZPEI(int a, Action<Component> b);

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
		[Cpp2IlInjected.Address(RVA = "0x9C2EF70", Offset = "0x9C2DB70", VA = "0x189C2EF70")]
		protected void GAUKSMQYBHE(Component a, bool b, bool c, bool d = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9C2ECF0", Offset = "0x9C2D8F0", VA = "0x189C2ECF0")]
		protected void EXNZKYXNJKO(Transform a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		protected ZEMNOGIHXLJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class XBAMXEZEWQI<a> : ZEMNOGIHXLJ where a : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private a LZVVFGRLGYC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private ObjectPool KARXGIBODLU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private bool AYAQTAUXKDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private Queue<a> JXILKRBVQPT;

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public override string AZGBUIWNJKT
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x50BAC30", Offset = "0x50B9830", VA = "0x1850BAC30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public override int PZRZKGZQOZY
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x50BAE90", Offset = "0x50B9A90", VA = "0x1850BAE90", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x50BB030", Offset = "0x50B9C30", VA = "0x1850BB030")]
		public XBAMXEZEWQI(a a, ObjectPool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x50BAC50", Offset = "0x50B9850", VA = "0x1850BAC50", Slot = "6")]
		public override void NDMELFFZPEI(int a, Action<Component> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x50BA840", Offset = "0x50B9440", VA = "0x1850BA840", Slot = "7")]
		public override Component Acquire(Action<Component> invokeOnNewInstance)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x50BAEB0", Offset = "0x50B9AB0", VA = "0x1850BAEB0", Slot = "8")]
		public override bool Release(Component behaviour)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x50BAA60", Offset = "0x50B9660", VA = "0x1850BAA60", Slot = "9")]
		public override void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x50BA6A0", Offset = "0x50B92A0", VA = "0x1850BA6A0")]
		private a APUJMXSUJNW()
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
		public interface YJXQRLKAZLJ
		{
			[Cpp2IlInjected.Token(Token = "0x17000007")]
			GameObject LXLHHFKVPFB
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
		[Cpp2IlInjected.Address(RVA = "0x9C29700", Offset = "0x9C28300", VA = "0x189C29700")]
		private void Start()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9C299E0", Offset = "0x9C285E0", VA = "0x189C299E0")]
		public ObjectPoolPreFill()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class PersistentGlobalPool : ObjectPool
	{
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private static PersistentGlobalPool CUYIASSGSRY;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static GameObject XVYOXQGORCC;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static PersistentGlobalPool UXEDIFVFAQD
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x9C29D10", Offset = "0x9C28910", VA = "0x189C29D10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9C29C50", Offset = "0x9C28850", VA = "0x189C29C50")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9C29010", Offset = "0x9C27C10", VA = "0x189C29010")]
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
		public ZEMNOGIHXLJ PoolEntry;

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF20", Offset = "0xCEEB20", VA = "0x180CEFF20")]
		public PooledObject()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public interface HTAYWECWWOP
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
		public interface XHAQDSJZAHQ
		{
			[Cpp2IlInjected.Token(Token = "0x17000015")]
			bool OKLJVYYUXXA
			{
				[Cpp2IlInjected.Token(Token = "0x6000081")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000016")]
			Vector3 CLXUDIGEFEZ
			{
				[Cpp2IlInjected.Token(Token = "0x6000082")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x17000017")]
			Camera IXKTFHEQQDL
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
			[Cpp2IlInjected.Address(RVA = "0x87EBF20", Offset = "0x87EAB20", VA = "0x1887EBF20")]
			public ColorConfiguration(ParticleSystem mainParticles)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x9C28D60", Offset = "0x9C27960", VA = "0x189C28D60")]
			public void IEEQCUQYPXV(Color a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private sealed class HGUMHNVAPLL : IEnumerator<NVIJVYVFXPY>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400005C")]
			private int NSYFVIOVDQI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private NVIJVYVFXPY PGYMGSMZHLZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			private XHAQDSJZAHQ DNHGSOUTQBS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			private Stopwatch KRFVSYMTIMD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private Plane[] WPECIQTLMNA;

			[Cpp2IlInjected.Token(Token = "0x17000018")]
			private NVIJVYVFXPY YPZFRLKUQEB
			{
				[Cpp2IlInjected.Token(Token = "0x600008F")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000019")]
			private object RTHQPUQEOJM
			{
				[Cpp2IlInjected.Token(Token = "0x6000091")]
				[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0940", VA = "0x180CF1D40", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0xCFA1C0", Offset = "0xCF8DC0", VA = "0x180CFA1C0")]
			[DebuggerHidden]
			public HGUMHNVAPLL(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "5")]
			[DebuggerHidden]
			private void PEABEYBFILL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x9C291C0", Offset = "0x9C27DC0", VA = "0x189C291C0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000090")]
			[Cpp2IlInjected.Address(RVA = "0x9C29180", Offset = "0x9C27D80", VA = "0x189C29180", Slot = "8")]
			[DebuggerHidden]
			private void KTHCATTUQZC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static readonly Lazy<IRecRoomQualityConfigProvider> SLKOIRXSJHZ;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly Lazy<HTAYWECWWOP> TGTWABWQQGR;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static List<PooledParticle> QRLGFISSYHH;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static YDHSMJLFZLP SBGULHNVGPK;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const float DWHLXMCLQRB = 1f;

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private static bool ZWATRSYPQWX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		protected int TFGDUQUCUDZ;

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
		private float? SKCDRSTAADT;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public bool IsLooping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private ParticleSystem.MinMaxGradient[] CJYOOEIVTJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private ParticleSystem.MinMaxGradient[] YEDUBOFDIEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private bool ABETURWPAJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private float WLDZUHXBLFY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private float AYPXYTUMAFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private Transform PNROEWGLXCY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private Vector3 KGVVAMQNVOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		private Vector3 TTQTNJPOQVK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private FollowType FSVVALWEFPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private YDHSMJLFZLP WFAZPIGUEUV;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		protected bool WIKPCHAEJDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private Transform XFIJVIXCQYS;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static IEnumerable<PooledParticle> DZGZAOBIWMW
		{
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x9C2E0F0", Offset = "0x9C2CCF0", VA = "0x189C2E0F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public ParticleCategory CUQAANCYHBC
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xD17080", Offset = "0xD15C80", VA = "0x180D17080")]
			get
			{
				return default(ParticleCategory);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public int PWDQCATJYOD
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xD00670", Offset = "0xCFF270", VA = "0x180D00670")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool CXRGWAGXVPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x9C2B720", Offset = "0x9C2A320", VA = "0x189C2B720")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static int FWWIFSWYIUH
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x9C2DFA0", Offset = "0x9C2CBA0", VA = "0x189C2DFA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		protected static bool NSORZAXPFKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x9C2A870", Offset = "0x9C29470", VA = "0x189C2A870")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public ParticleSystem XFKESYQTQSV
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF3820", VA = "0x180CF4C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xCF64C0", Offset = "0xCF50C0", VA = "0x180CF64C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public ParticleSystem[] ASHMRDTJNKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xCF4300", Offset = "0xCF2F00", VA = "0x180CF4300")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xCF4530", Offset = "0xCF3130", VA = "0x180CF4530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		private ParticleSystemRenderer[] FSLOFTRAWTK
		{
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xCF43A0", Offset = "0xCF2FA0", VA = "0x180CF43A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xCF4370", Offset = "0xCF2F70", VA = "0x180CF4370")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public float OLRLDNADIGO
		{
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0xD26190", Offset = "0xD24D90", VA = "0x180D26190")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private FollowType HPRJCHOAONL
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xCF76C0", Offset = "0xCF62C0", VA = "0x180CF76C0")]
			get
			{
				return default(FollowType);
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x9C2DAF0", Offset = "0x9C2C6F0", VA = "0x189C2DAF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public Transform VVUQJWBKDSM
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x9C2E140", Offset = "0x9C2CD40", VA = "0x189C2E140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event Action UAKQVQZQNUP
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x9C2DF00", Offset = "0x9C2CB00", VA = "0x189C2DF00")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x9C2E190", Offset = "0x9C2CD90", VA = "0x189C2E190")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9C2D2F0", Offset = "0x9C2BEF0", VA = "0x189C2D2F0")]
		public static PooledParticle TryPlayPrefab(PooledParticle prefab, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9C2D410", Offset = "0x9C2C010", VA = "0x189C2D410")]
		public static PooledParticle TryPlayPrefab(PooledParticle prefab, Vector3 position)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9C2C740", Offset = "0x9C2B340", VA = "0x189C2C740")]
		private void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x9C2AC60", Offset = "0x9C29860", VA = "0x189C2AC60")]
		private void KIOHGKMLLZL(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x9C2B720", Offset = "0x9C2A320", VA = "0x189C2B720")]
		private bool OGAJPZOJRHO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9C2AD30", Offset = "0x9C29930", VA = "0x189C2AD30")]
		private Bounds LWPLZCDUQLU()
		{
			return default(Bounds);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x9C2DB10", Offset = "0x9C2C710", VA = "0x189C2DB10")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private static void ZDENPSAYSKZ(ParticleSystemRenderer a, int b, UnityEngine.Object c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x9C2D590", Offset = "0x9C2C190", VA = "0x189C2D590")]
		[IteratorStateMachine(typeof(HGUMHNVAPLL))]
		private static IEnumerator<NVIJVYVFXPY> UROSTFCSEWP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9C2A8F0", Offset = "0x9C294F0", VA = "0x189C2A8F0")]
		private static void KGNSMCETGPE(Stopwatch a, Vector3 b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9C2A700", Offset = "0x9C29300", VA = "0x189C2A700")]
		private static int GRLSZXESGAI(PooledParticle a, PooledParticle b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9C2B610", Offset = "0x9C2A210", VA = "0x189C2B610")]
		private static int NSXYRJFFDEQ(ParticleCategory a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9C2C9E0", Offset = "0x9C2B5E0", VA = "0x189C2C9E0")]
		protected void SQNVFKFVUQC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9C2D5E0", Offset = "0x9C2C1E0", VA = "0x189C2D5E0")]
		protected void UWHQNFBRMQX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9C2A420", Offset = "0x9C29020", VA = "0x189C2A420", Slot = "4")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9C2B0C0", Offset = "0x9C29CC0", VA = "0x189C2B0C0")]
		private void LateUpdate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9C2B800", Offset = "0x9C2A400", VA = "0x189C2B800")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x9C2C3B0", Offset = "0x9C2AFB0", VA = "0x189C2C3B0")]
		private void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9C2D080", Offset = "0x9C2BC80", VA = "0x189C2D080")]
		public void SetDuration(float duration, bool setStartLifetime = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9C2B890", Offset = "0x9C2A490", VA = "0x189C2B890")]
		public void Play(Transform followTransform)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x9C2C110", Offset = "0x9C2AD10", VA = "0x189C2C110")]
		public void Play(Transform followTransform, bool loop, float sizeMultiplier = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x9C2B9F0", Offset = "0x9C2A5F0", VA = "0x189C2B9F0")]
		public void Play(Transform followTransform, Vector3 followWorldSpaceOffset, bool loop, float sizeMultiplier = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9C2BB40", Offset = "0x9C2A740", VA = "0x189C2BB40")]
		public void Play(Transform followPosition, Quaternion rotation, bool loop = false, float sizeMultiplier = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9C2C280", Offset = "0x9C2AE80", VA = "0x189C2C280")]
		public void Play(Transform followPosition, Vector3 followWorldSpaceOffset, Quaternion rotation, bool loop = false, float sizeMultiplier = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9C2BDF0", Offset = "0x9C2A9F0", VA = "0x189C2BDF0")]
		public void Play(Vector3 position, Quaternion rotation, Vector3 velocity, bool loop = false, float sizeMultiplier = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9C2BC90", Offset = "0x9C2A890", VA = "0x189C2BC90")]
		public void Play(Vector3 position, Quaternion rotation, bool loop = false, float sizeMultiplier = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9C2BF70", Offset = "0x9C2AB70", VA = "0x189C2BF70")]
		public void Play(bool loop = false, float sizeMultiplier = -1f)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x9C2D250", Offset = "0x9C2BE50", VA = "0x189C2D250")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9C2D150", Offset = "0x9C2BD50", VA = "0x189C2D150")]
		public void StopAfterExistingLifetime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9C2B400", Offset = "0x9C2A000", VA = "0x189C2B400")]
		private void MPPGXCYENRM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9C2C5B0", Offset = "0x9C2B1B0", VA = "0x189C2C5B0")]
		public void ResetColors()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9C2CBD0", Offset = "0x9C2B7D0", VA = "0x189C2CBD0")]
		public void SetColor(Color color)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9C2A7B0", Offset = "0x9C293B0", VA = "0x189C2A7B0")]
		private void HJKHKNTORDP(float? a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x9C2A690", Offset = "0x9C29290", VA = "0x189C2A690")]
		private void DOQCBBZGZNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9C2C8B0", Offset = "0x9C2B4B0", VA = "0x189C2C8B0")]
		private void SKGZLWQPZIC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9C2DE60", Offset = "0x9C2CA60", VA = "0x189C2DE60")]
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
