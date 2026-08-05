using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Mono.Math;
using Unity.Collections;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class DMBAALHIOHD : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xC6A1E0", Offset = "0xC68FE0", VA = "0x180C6A1E0")]
	public DMBAALHIOHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public abstract class HashableScriptableObject : ScriptableObject, CHMJLDKJAME, LHNLMNFPGGD, ISerializationCallbackReceiver
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[SerializeField]
	private byte[] stableHash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[SerializeField]
	private byte[] seed;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public byte[] StableHash
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7337A0", Offset = "0x7325A0", VA = "0x1807337A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6B2560", Offset = "0x6B1360", VA = "0x1806B2560", Slot = "6")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x739270", Offset = "0x738070", VA = "0x180739270", Slot = "7")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x86FF90", Offset = "0x86ED90", VA = "0x18086FF90", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash NHBPPIHNEOH);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x77E460", Offset = "0x77D260", VA = "0x18077E460")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[BLHJALMBACN]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[BLHJALMBACN]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x635A890", Offset = "0x6359690", VA = "0x18635A890")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x635A850", Offset = "0x6359650", VA = "0x18635A850")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x635A8D0", Offset = "0x63596D0", VA = "0x18635A8D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x635AAA0", Offset = "0x63598A0", VA = "0x18635AAA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x635AA10", Offset = "0x6359810", VA = "0x18635AA10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x791280", Offset = "0x790080", VA = "0x180791280")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7910C0", Offset = "0x78FEC0", VA = "0x1807910C0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x635A810", Offset = "0x6359610", VA = "0x18635A810")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x635A980", Offset = "0x6359780", VA = "0x18635A980")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x635A250", Offset = "0x6359050", VA = "0x18635A250")]
	public void CopyBounds(SavedExtents KICLNADFIEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x635A770", Offset = "0x6359570", VA = "0x18635A770")]
	public void SetLocalSpaceBounds(Bounds HHJMILAPBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x8DA920", Offset = "0x8D9720", VA = "0x1808DA920")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x635A6A0", Offset = "0x63594A0", VA = "0x18635A6A0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x635A280", Offset = "0x6359080", VA = "0x18635A280")]
	private void IAILHOPONLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x635A470", Offset = "0x6359270", VA = "0x18635A470")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6359C10", Offset = "0x6358A10", VA = "0x186359C10")]
	public static void CalculateLocalBoundsFor(GameObject NCAOMIEGHPA, out Bounds HHJMILAPBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x635A6B0", Offset = "0x63594B0", VA = "0x18635A6B0")]
	private static void PNLLCIAHCCI(Bounds OPGAGDBKIDA, Color NKNPGFCGIPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x635A790", Offset = "0x6359590", VA = "0x18635A790")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7332F0", Offset = "0x7320F0", VA = "0x1807332F0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x733300", Offset = "0x732100", VA = "0x180733300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x895170", Offset = "0x893F70", VA = "0x180895170")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x895150", Offset = "0x893F50", VA = "0x180895150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "4")]
	public virtual void JCAFFPCMODH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	[DMBAALHIOHD]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4945140", Offset = "0x4943F40", VA = "0x184945140", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4944870", Offset = "0x4943670", VA = "0x184944870", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4945680", Offset = "0x4944480", VA = "0x184945680")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private sealed class MPMKBGGGKBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
		public MPMKBGGGKBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4260360", Offset = "0x425F160", VA = "0x184260360")]
		internal int <get_Comparison>b__0(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[DMBAALHIOHD]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IReadOnlyList<TKeyVal> List
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x2CDF730", Offset = "0x2CDE530", VA = "0x182CDF730", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x2CDF760", Offset = "0x2CDE560", VA = "0x182CDF760", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x2CDF680", Offset = "0x2CDE480", VA = "0x182CDF680", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public TVal this[TKey PIIJMEAKDGO]
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2CDF6B0", Offset = "0x2CDE4B0", VA = "0x182CDF6B0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x2CDF580", Offset = "0x2CDE380", VA = "0x182CDF580", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2CDEF00", Offset = "0x2CDDD00", VA = "0x182CDEF00", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2CDE5D0", Offset = "0x2CDD3D0", VA = "0x182CDE5D0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2CDE5A0", Offset = "0x2CDD3A0", VA = "0x182CDE5A0", Slot = "14")]
	protected virtual string MPHIIEKJONH(TKeyVal NKCAJAFJAFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2CDE480", Offset = "0x2CDD280", VA = "0x182CDE480", Slot = "4")]
	public bool ContainsKey(TKey PIIJMEAKDGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2CDF470", Offset = "0x2CDE270", VA = "0x182CDF470", Slot = "5")]
	public bool TryGetValue(TKey PIIJMEAKDGO, out TVal DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2CDE4B0", Offset = "0x2CDD2B0", VA = "0x182CDE4B0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2CDE4B0", Offset = "0x2CDD2B0", VA = "0x182CDE4B0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2CDF4A0", Offset = "0x2CDE2A0", VA = "0x182CDF4A0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class EFKFICJGEOF<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class CJNLKLGPGJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
		public CJNLKLGPGJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x46ED5C0", Offset = "0x46EC3C0", VA = "0x1846ED5C0")]
		internal bool <GetSamples>b__0(global::NLMEDIENKFM<float, T> sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly float EFADKHCCHJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly float ADEHDDLBKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private List<global::NLMEDIENKFM<float, T>> PIIPEJEMDFN;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int MCOJHMBLAHA
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x3D82100", Offset = "0x3D80F00", VA = "0x183D82100")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x3D821E0", Offset = "0x3D80FE0", VA = "0x183D821E0")]
	public EFKFICJGEOF(float DPKAEMPKPOH, float IOOLHIOLIDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x3D81740", Offset = "0x3D80540", VA = "0x183D81740")]
	public bool HJNIDIJICNI(float MHEAKFKNGKB, T DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x3D82180", Offset = "0x3D80F80", VA = "0x183D82180")]
	public int ODEFPOKCDOI(float MHEAKFKNGKB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3D81D40", Offset = "0x3D80B40", VA = "0x183D81D40")]
	public IEnumerable<T> JLEFFALLGLD(float MHEAKFKNGKB, [Optional] float? AEKOJPHPAFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3D81710", Offset = "0x3D80510", VA = "0x183D81710")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3D81650", Offset = "0x3D80450", VA = "0x183D81650")]
	private void DNNIKJBNKBC(float MHEAKFKNGKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class HIDBOGGDGNI<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct IPNPNNPELPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public T FBCEGMCNEND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float PGLDLDAMIHJ;
	}

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private static float KOMPMKGLHJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private List<T> HHHHHHEKKAM;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private const int LONEOCLEALI = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	private IPNPNNPELPE[] DBOPJMNFJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private int LIJPLOMBEEP;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float PKFPKAOLLAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9474A0", Offset = "0x9462A0", VA = "0x1809474A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9476A0", Offset = "0x9464A0", VA = "0x1809476A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3B191A0", Offset = "0x3B17FA0", VA = "0x183B191A0")]
	public HIDBOGGDGNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3B191D0", Offset = "0x3B17FD0", VA = "0x183B191D0")]
	public HIDBOGGDGNI(int BDHBBDMMOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3B185A0", Offset = "0x3B173A0", VA = "0x183B185A0")]
	public void HMNAIPBHJIK(float MHEAKFKNGKB, T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3B17E40", Offset = "0x3B16C40", VA = "0x183B17E40")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3B18820", Offset = "0x3B17620", VA = "0x183B18820")]
	public bool LGKHJDICLPK(float EGGDGKGFLFK, float FBBPEGICDHA, out T DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3B18120", Offset = "0x3B16F20", VA = "0x183B18120")]
	public bool HMKLDOPOHNI(float EGGDGKGFLFK, float FBBPEGICDHA, out T DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3B18F20", Offset = "0x3B17D20", VA = "0x183B18F20")]
	public void OCAOIBKAMFK(float EGGDGKGFLFK, float FBBPEGICDHA, List<T> FAHBHODOFIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3B18DB0", Offset = "0x3B17BB0", VA = "0x183B18DB0")]
	private int MFNPBIMMHLO(int LFKADCPMMDJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3B180E0", Offset = "0x3B16EE0", VA = "0x183B180E0")]
	private void HKAJLOIABIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T CBEKBEBHJDE();

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T BAHKCJKEFPC(T JCHPGJLCOCJ, T GHMOJHOMMOK, float PHLICBNKKOO);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T BAMNADPGMPG(T DFEOJBAFBHE, float PHLICBNKKOO);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T HNFINOKIPHI(T JCHPGJLCOCJ, T GHMOJHOMMOK);

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "8")]
	protected abstract T PMIIPLLOJKM(T JCHPGJLCOCJ, T GHMOJHOMMOK);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class IFBCFJCMCGL : global::HIDBOGGDGNI<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0xD6DA00", Offset = "0xD6C800", VA = "0x180D6DA00", Slot = "4")]
	protected override Vector3 CBEKBEBHJDE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x340B550", Offset = "0x340A350", VA = "0x18340B550", Slot = "5")]
	protected override Vector3 BAHKCJKEFPC(Vector3 JCHPGJLCOCJ, Vector3 GHMOJHOMMOK, float PHLICBNKKOO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6357010", Offset = "0x6355E10", VA = "0x186357010", Slot = "6")]
	protected override Vector3 BAMNADPGMPG(Vector3 DFEOJBAFBHE, float PHLICBNKKOO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6357070", Offset = "0x6355E70", VA = "0x186357070", Slot = "7")]
	protected override Vector3 HNFINOKIPHI(Vector3 JCHPGJLCOCJ, Vector3 GHMOJHOMMOK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x63570F0", Offset = "0x6355EF0", VA = "0x1863570F0", Slot = "8")]
	protected override Vector3 PMIIPLLOJKM(Vector3 JCHPGJLCOCJ, Vector3 GHMOJHOMMOK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6357160", Offset = "0x6355F60", VA = "0x186357160")]
	public IFBCFJCMCGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class PLJLNKIJJFE : global::HIDBOGGDGNI<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6359480", Offset = "0x6358280", VA = "0x186359480")]
	public PLJLNKIJJFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x63594F0", Offset = "0x63582F0", VA = "0x1863594F0")]
	public PLJLNKIJJFE(int BDHBBDMMOKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xBD5930", Offset = "0xBD4730", VA = "0x180BD5930", Slot = "4")]
	protected override float CBEKBEBHJDE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0xD9FC20", Offset = "0xD9EA20", VA = "0x180D9FC20", Slot = "5")]
	protected override float BAHKCJKEFPC(float JCHPGJLCOCJ, float GHMOJHOMMOK, float PHLICBNKKOO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x564A8F0", Offset = "0x56496F0", VA = "0x18564A8F0", Slot = "6")]
	protected override float BAMNADPGMPG(float DFEOJBAFBHE, float PHLICBNKKOO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x980AD0", Offset = "0x97F8D0", VA = "0x180980AD0", Slot = "7")]
	protected override float HNFINOKIPHI(float JCHPGJLCOCJ, float GHMOJHOMMOK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6359470", Offset = "0x6358270", VA = "0x186359470", Slot = "8")]
	protected override float PMIIPLLOJKM(float JCHPGJLCOCJ, float GHMOJHOMMOK)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class CABAJJBOAOK
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x33E31D0", Offset = "0x33E1FD0", VA = "0x1833E31D0")]
	public static global::IEHEHDHPHDE<T1> HJNGNBALKKN<T1>(T1 DDMFFEHANLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x379EF60", Offset = "0x379DD60", VA = "0x18379EF60")]
	public static global::NLMEDIENKFM<T1, T2> HJNGNBALKKN<T1, T2>(T1 DDMFFEHANLL, T2 ONIKLPKIPDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x379EFD0", Offset = "0x379DDD0", VA = "0x18379EFD0")]
	public static global::DCACKDLBAMA<T1, T2, T3> HJNGNBALKKN<T1, T2, T3>(T1 DDMFFEHANLL, T2 ONIKLPKIPDP, T3 HNKBIFBMACP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3795B80", Offset = "0x3794980", VA = "0x183795B80")]
	public static global::PPGNBEBKLEL<T1, T2, T3, T4> HJNGNBALKKN<T1, T2, T3, T4>(T1 DDMFFEHANLL, T2 ONIKLPKIPDP, T3 HNKBIFBMACP, T4 KMBJBCECOGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x379F2A0", Offset = "0x379E0A0", VA = "0x18379F2A0")]
	public static global::KLLPCOABIAI<T1, T2, T3, T4, T5> HJNGNBALKKN<T1, T2, T3, T4, T5>(T1 DDMFFEHANLL, T2 ONIKLPKIPDP, T3 HNKBIFBMACP, T4 KMBJBCECOGM, T5 DMJOADDMDAB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x379F1F0", Offset = "0x379DFF0", VA = "0x18379F1F0")]
	public static global::IABIDEGAGEN<T1, T2, T3, T4, T5, T6> HJNGNBALKKN<T1, T2, T3, T4, T5, T6>(T1 DDMFFEHANLL, T2 ONIKLPKIPDP, T3 HNKBIFBMACP, T4 KMBJBCECOGM, T5 DMJOADDMDAB, T6 KGPIABONHCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x379F130", Offset = "0x379DF30", VA = "0x18379F130")]
	public static global::CKNJKBOHINF<T1, T2, T3, T4, T5, T6, T7> HJNGNBALKKN<T1, T2, T3, T4, T5, T6, T7>(T1 DDMFFEHANLL, T2 ONIKLPKIPDP, T3 HNKBIFBMACP, T4 KMBJBCECOGM, T5 DMJOADDMDAB, T6 KGPIABONHCK, T7 IHJOJKNEDII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x379F060", Offset = "0x379DE60", VA = "0x18379F060")]
	public static global::CKEELILFMGC<T1, T2, T3, T4, T5, T6, T7, T8> HJNGNBALKKN<T1, T2, T3, T4, T5, T6, T7, T8>(T1 DDMFFEHANLL, T2 ONIKLPKIPDP, T3 HNKBIFBMACP, T4 KMBJBCECOGM, T5 DMJOADDMDAB, T6 KGPIABONHCK, T7 IHJOJKNEDII, T8 NKOMDLHLIAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x2B0EBF0", Offset = "0x2B0D9F0", VA = "0x182B0EBF0")]
	[IteratorStateMachine(typeof(MDENJAPPCBN))]
	public static IEnumerable<global::NLMEDIENKFM<T1, T2>> DNOPNIGFBKD<T1, T2>(IEnumerable<T1> NCNGLFNLPAG, IEnumerable<T2> OPGAGDBKIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x2B0EDD0", Offset = "0x2B0DBD0", VA = "0x182B0EDD0")]
	[IteratorStateMachine(typeof(DFHDFCFBJJN))]
	public static IEnumerable<global::DCACKDLBAMA<T1, T2, T3>> DNOPNIGFBKD<T1, T2, T3>(IEnumerable<T1> NCNGLFNLPAG, IEnumerable<T2> OPGAGDBKIDA, IEnumerable<T3> NKNPGFCGIPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x121E470", Offset = "0x121D270", VA = "0x18121E470")]
	internal static int PNAKDHMCEHP(int AAICCELMFFD, int FDDFKKLBBEG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x121E460", Offset = "0x121D260", VA = "0x18121E460")]
	internal static int PNAKDHMCEHP(int AAICCELMFFD, int FDDFKKLBBEG, int GDGNLMAOKJH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x121E440", Offset = "0x121D240", VA = "0x18121E440")]
	internal static int PNAKDHMCEHP(int AAICCELMFFD, int FDDFKKLBBEG, int GDGNLMAOKJH, int OIJDNEHDCPH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6353300", Offset = "0x6352100", VA = "0x186353300")]
	internal static int PNAKDHMCEHP(int AAICCELMFFD, int FDDFKKLBBEG, int GDGNLMAOKJH, int OIJDNEHDCPH, int PLDFKBNFEOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x63532B0", Offset = "0x63520B0", VA = "0x1863532B0")]
	internal static int PNAKDHMCEHP(int AAICCELMFFD, int FDDFKKLBBEG, int GDGNLMAOKJH, int OIJDNEHDCPH, int PLDFKBNFEOB, int DLEGGOOPNOC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x63532D0", Offset = "0x63520D0", VA = "0x1863532D0")]
	internal static int PNAKDHMCEHP(int AAICCELMFFD, int FDDFKKLBBEG, int GDGNLMAOKJH, int OIJDNEHDCPH, int PLDFKBNFEOB, int DLEGGOOPNOC, int LCFLCBBJNOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6353320", Offset = "0x6352120", VA = "0x186353320")]
	internal static int PNAKDHMCEHP(int AAICCELMFFD, int FDDFKKLBBEG, int GDGNLMAOKJH, int OIJDNEHDCPH, int PLDFKBNFEOB, int DLEGGOOPNOC, int LCFLCBBJNOF, int EFEOGAOCKHL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class IEHEHDHPHDE<T1> : IComparable<global::IEHEHDHPHDE<T1>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public readonly T1 DHLPIHIJAHF;

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x2E6FB60", Offset = "0x2E6E960", VA = "0x182E6FB60")]
	public IEHEHDHPHDE(T1 DDMFFEHANLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x32D3730", Offset = "0x32D2530", VA = "0x1832D3730", Slot = "4")]
	public int CompareTo(global::IEHEHDHPHDE<T1> KICLNADFIEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x32D37A0", Offset = "0x32D25A0", VA = "0x1832D37A0", Slot = "0")]
	public override bool Equals(object KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x9B4340", Offset = "0x9B3140", VA = "0x1809B4340", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x32D3840", Offset = "0x32D2640", VA = "0x1832D3840", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class NLMEDIENKFM<T1, T2> : IComparable<global::NLMEDIENKFM<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public readonly T1 DHLPIHIJAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public readonly T2 PGNGJOEAKIB;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x390BBB0", Offset = "0x390A9B0", VA = "0x18390BBB0")]
	public NLMEDIENKFM(T1 DDMFFEHANLL, T2 ONIKLPKIPDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x42AC820", Offset = "0x42AB620", VA = "0x1842AC820", Slot = "4")]
	public int CompareTo(global::NLMEDIENKFM<T1, T2> KICLNADFIEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x42ACCD0", Offset = "0x42ABAD0", VA = "0x1842ACCD0", Slot = "0")]
	public override bool Equals(object KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x42AD440", Offset = "0x42AC240", VA = "0x1842AD440", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x42ADB90", Offset = "0x42AC990", VA = "0x1842ADB90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class DCACKDLBAMA<T1, T2, T3> : IComparable<global::DCACKDLBAMA<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public readonly T1 DHLPIHIJAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public readonly T2 PGNGJOEAKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public readonly T3 JNHHLCOFMMJ;

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4047A10", Offset = "0x4046810", VA = "0x184047A10")]
	public DCACKDLBAMA(T1 DDMFFEHANLL, T2 ONIKLPKIPDP, T3 HNKBIFBMACP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4047200", Offset = "0x4046000", VA = "0x184047200", Slot = "4")]
	public int CompareTo(global::DCACKDLBAMA<T1, T2, T3> KICLNADFIEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x40474F0", Offset = "0x40462F0", VA = "0x1840474F0", Slot = "0")]
	public override bool Equals(object KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x40476F0", Offset = "0x40464F0", VA = "0x1840476F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x4047860", Offset = "0x4046660", VA = "0x184047860", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class PPGNBEBKLEL<T1, T2, T3, T4> : IComparable<global::PPGNBEBKLEL<T1, T2, T3, T4>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public readonly T1 DHLPIHIJAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public readonly T2 PGNGJOEAKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public readonly T3 JNHHLCOFMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public readonly T4 DMDCBCLMDAD;

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x39D79D0", Offset = "0x39D67D0", VA = "0x1839D79D0")]
	public PPGNBEBKLEL(T1 DDMFFEHANLL, T2 ONIKLPKIPDP, T3 HNKBIFBMACP, T4 KMBJBCECOGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3A546E0", Offset = "0x3A534E0", VA = "0x183A546E0", Slot = "4")]
	public int CompareTo(global::PPGNBEBKLEL<T1, T2, T3, T4> KICLNADFIEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3A54820", Offset = "0x3A53620", VA = "0x183A54820", Slot = "0")]
	public override bool Equals(object KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3A54940", Offset = "0x3A53740", VA = "0x183A54940", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3A54A00", Offset = "0x3A53800", VA = "0x183A54A00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class KLLPCOABIAI<T1, T2, T3, T4, T5> : IComparable<global::KLLPCOABIAI<T1, T2, T3, T4, T5>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public readonly T1 DHLPIHIJAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public readonly T2 PGNGJOEAKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public readonly T3 JNHHLCOFMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public readonly T4 DMDCBCLMDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public readonly T5 LHCKBLGPCFM;

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x41381C0", Offset = "0x4136FC0", VA = "0x1841381C0")]
	public KLLPCOABIAI(T1 DDMFFEHANLL, T2 ONIKLPKIPDP, T3 HNKBIFBMACP, T4 KMBJBCECOGM, T5 DMJOADDMDAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4137CB0", Offset = "0x4136AB0", VA = "0x184137CB0", Slot = "4")]
	public int CompareTo(global::KLLPCOABIAI<T1, T2, T3, T4, T5> KICLNADFIEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4137E30", Offset = "0x4136C30", VA = "0x184137E30", Slot = "0")]
	public override bool Equals(object KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4137F70", Offset = "0x4136D70", VA = "0x184137F70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4138070", Offset = "0x4136E70", VA = "0x184138070", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class IABIDEGAGEN<T1, T2, T3, T4, T5, T6> : IComparable<global::IABIDEGAGEN<T1, T2, T3, T4, T5, T6>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public readonly T1 DHLPIHIJAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public readonly T2 PGNGJOEAKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public readonly T3 JNHHLCOFMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public readonly T4 DMDCBCLMDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public readonly T5 LHCKBLGPCFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public readonly T6 PKCNGMDFJIK;

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5050C50", Offset = "0x504FA50", VA = "0x185050C50")]
	public IABIDEGAGEN(T1 DDMFFEHANLL, T2 ONIKLPKIPDP, T3 HNKBIFBMACP, T4 KMBJBCECOGM, T5 DMJOADDMDAB, T6 KGPIABONHCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5050690", Offset = "0x504F490", VA = "0x185050690", Slot = "4")]
	public int CompareTo(global::IABIDEGAGEN<T1, T2, T3, T4, T5, T6> KICLNADFIEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5050850", Offset = "0x504F650", VA = "0x185050850", Slot = "0")]
	public override bool Equals(object KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x50509C0", Offset = "0x504F7C0", VA = "0x1850509C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x5050AE0", Offset = "0x504F8E0", VA = "0x185050AE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class CKNJKBOHINF<T1, T2, T3, T4, T5, T6, T7> : IComparable<global::CKNJKBOHINF<T1, T2, T3, T4, T5, T6, T7>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public readonly T1 DHLPIHIJAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public readonly T2 PGNGJOEAKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public readonly T3 JNHHLCOFMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public readonly T4 DMDCBCLMDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public readonly T5 LHCKBLGPCFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public readonly T6 PKCNGMDFJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly T7 EFLAFNBNECG;

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x46F1850", Offset = "0x46F0650", VA = "0x1846F1850")]
	public CKNJKBOHINF(T1 DDMFFEHANLL, T2 ONIKLPKIPDP, T3 HNKBIFBMACP, T4 KMBJBCECOGM, T5 DMJOADDMDAB, T6 KGPIABONHCK, T7 IHJOJKNEDII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x46F11D0", Offset = "0x46EFFD0", VA = "0x1846F11D0", Slot = "4")]
	public int CompareTo(global::CKNJKBOHINF<T1, T2, T3, T4, T5, T6, T7> KICLNADFIEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x46F13D0", Offset = "0x46F01D0", VA = "0x1846F13D0", Slot = "0")]
	public override bool Equals(object KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x46F1570", Offset = "0x46F0370", VA = "0x1846F1570", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x46F16C0", Offset = "0x46F04C0", VA = "0x1846F16C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class CKEELILFMGC<T1, T2, T3, T4, T5, T6, T7, T8> : IComparable<global::CKEELILFMGC<T1, T2, T3, T4, T5, T6, T7, T8>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly T1 DHLPIHIJAHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly T2 PGNGJOEAKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly T3 JNHHLCOFMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly T4 DMDCBCLMDAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly T5 LHCKBLGPCFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly T6 PKCNGMDFJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly T7 EFLAFNBNECG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly T8 OLBCBJPGBDH;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x46EE0F0", Offset = "0x46ECEF0", VA = "0x1846EE0F0")]
	public CKEELILFMGC(T1 DDMFFEHANLL, T2 ONIKLPKIPDP, T3 HNKBIFBMACP, T4 KMBJBCECOGM, T5 DMJOADDMDAB, T6 KGPIABONHCK, T7 IHJOJKNEDII, T8 NKOMDLHLIAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x46ED9C0", Offset = "0x46EC7C0", VA = "0x1846ED9C0", Slot = "4")]
	public int CompareTo(global::CKEELILFMGC<T1, T2, T3, T4, T5, T6, T7, T8> KICLNADFIEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x46EDC10", Offset = "0x46ECA10", VA = "0x1846EDC10", Slot = "0")]
	public override bool Equals(object KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x46EDDD0", Offset = "0x46ECBD0", VA = "0x1846EDDD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x46EDF40", Offset = "0x46ECD40", VA = "0x1846EDF40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T FBCEGMCNEND
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x158F4F0", Offset = "0x158E2F0", VA = "0x18158F4F0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x158F560", Offset = "0x158E360", VA = "0x18158F560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float FOHMBKIIFFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x783C30", Offset = "0x782A30", VA = "0x180783C30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x49FA820", Offset = "0x49F9620", VA = "0x1849FA820")]
	public T HADNJNMEOPN(float PHLICBNKKOO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x49FAC30", Offset = "0x49F9A30", VA = "0x1849FAC30")]
	public T MJGNELPKOKA(float PHLICBNKKOO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T BAHKCJKEFPC(T JCHPGJLCOCJ, T GHMOJHOMMOK, float PHLICBNKKOO);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0xD9FC20", Offset = "0xD9EA20", VA = "0x180D9FC20", Slot = "4")]
	protected override float BAHKCJKEFPC(float JCHPGJLCOCJ, float GHMOJHOMMOK, float PHLICBNKKOO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6354F50", Offset = "0x6353D50", VA = "0x186354F50")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x340B550", Offset = "0x340A350", VA = "0x18340B550", Slot = "4")]
	protected override Vector3 BAHKCJKEFPC(Vector3 JCHPGJLCOCJ, Vector3 GHMOJHOMMOK, float PHLICBNKKOO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x635B990", Offset = "0x635A790", VA = "0x18635B990")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x21CDDE0", Offset = "0x21CCBE0", VA = "0x1821CDDE0", Slot = "4")]
	protected override Color BAHKCJKEFPC(Color JCHPGJLCOCJ, Color GHMOJHOMMOK, float PHLICBNKKOO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x6353F40", Offset = "0x6352D40", VA = "0x186353F40")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public class LNILIBCCIFN : global::GGMOAHGJIJD<string>
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6358110", Offset = "0x6356F10", VA = "0x186358110")]
	public LNILIBCCIFN(int CIMAPKKBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6358160", Offset = "0x6356F60", VA = "0x186358160")]
	public LNILIBCCIFN(BOGCLLBCKAJ[] EABPBDHKJJC, bool MNMIDHFIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x63580A0", Offset = "0x6356EA0", VA = "0x1863580A0", Slot = "6")]
	protected override uint KOOFGGDDHII(uint NHBPPIHNEOH, string DFEOJBAFBHE)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class PIDKKMFILAA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly IDisposable JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public PIDKKMFILAA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public struct JNNGPGACGNO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class KJOKMBEBLLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		public TaskCompletionSource<T> tcs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
		public KJOKMBEBLLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3660170", Offset = "0x365EF70", VA = "0x183660170")]
		internal void <StartRequest>b__0()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> CJJMAMOONDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int HNNLIBPGPNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int ONMJFJIJHIG;

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0xF5A080", Offset = "0xF58E80", VA = "0x180F5A080")]
	private JNNGPGACGNO(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> IJPHJIFNABL, int PCDIDEACGEB, int GHJCGFEINCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x459F790", Offset = "0x459E590", VA = "0x18459F790")]
	public static global::JNNGPGACGNO<T> DHGKFEMNGCO()
	{
		return default(global::JNNGPGACGNO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x459FFB0", Offset = "0x459EDB0", VA = "0x18459FFB0")]
	public (int, int, Task<T>) JELLNOMLDPM(int NMIOFDCBLLN, [Optional] CancellationToken NIEOBBGKEFJ, double MDHNFEOEMPO = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x45A1150", Offset = "0x459FF50", VA = "0x1845A1150")]
	public void KJMDGGIMPLK(int NMIOFDCBLLN, int GHJCGFEINCI, in T MMPEAFKIOCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class DGLBLOBNPFI
{
	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6353F80", Offset = "0x6352D80", VA = "0x186353F80")]
	public static global::JNNGPGACGNO<PEFLLNEDEOA> DHGKFEMNGCO()
	{
		return default(global::JNNGPGACGNO<PEFLLNEDEOA>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6353FD0", Offset = "0x6352DD0", VA = "0x186353FD0")]
	public static void KJMDGGIMPLK(this in global::JNNGPGACGNO<PEFLLNEDEOA> BLHHJNENDMO, int NMIOFDCBLLN, int GHJCGFEINCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[DefaultMember("Item")]
public class JKKPJACIJEH<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Dictionary<TKey, TVal> BHKHMIPNLDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Dictionary<TVal, TKey> EPNBFJMNFDL;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3443340", Offset = "0x3442140", VA = "0x183443340", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool NMHHOIIAEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6B1E00", Offset = "0x6B0C00", VA = "0x1806B1E00", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> GLAEFLDOOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x3904CC0", Offset = "0x3903AC0", VA = "0x183904CC0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> HEJJODDBBBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x3A69540", Offset = "0x3A68340", VA = "0x183A69540", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x4599680", Offset = "0x4598480", VA = "0x184599680", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x45996C0", Offset = "0x45984C0", VA = "0x1845996C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x4598570", Offset = "0x4597370", VA = "0x184598570")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x4599360", Offset = "0x4598160", VA = "0x184599360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x45983F0", Offset = "0x45971F0", VA = "0x1845983F0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x45994B0", Offset = "0x45982B0", VA = "0x1845994B0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4598340", Offset = "0x4597140", VA = "0x184598340", Slot = "9")]
	public void Add(TKey PIIJMEAKDGO, TVal DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x4598380", Offset = "0x4597180", VA = "0x184598380", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> LBGDLICPCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4598450", Offset = "0x4597250", VA = "0x184598450", Slot = "8")]
	public bool ContainsKey(TKey PIIJMEAKDGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x4598480", Offset = "0x4597280", VA = "0x184598480", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> LBGDLICPCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4599420", Offset = "0x4598220", VA = "0x184599420", Slot = "10")]
	public bool Remove(TKey PIIJMEAKDGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x4599480", Offset = "0x4598280", VA = "0x184599480", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> LBGDLICPCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x42A9180", Offset = "0x42A7F80", VA = "0x1842A9180", Slot = "11")]
	public bool TryGetValue(TKey PIIJMEAKDGO, out TVal DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4598D30", Offset = "0x4597B30", VA = "0x184598D30", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4598510", Offset = "0x4597310", VA = "0x184598510", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] DBOPJMNFJMA, int MNHDAEDPKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4598F00", Offset = "0x4597D00", VA = "0x184598F00")]
	public void HMNAIPBHJIK(TVal EKFKNNJJKLD, TKey PIIJMEAKDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4598EC0", Offset = "0x4597CC0", VA = "0x184598EC0")]
	public void HMNAIPBHJIK(KeyValuePair<TVal, TKey> LBGDLICPCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4599060", Offset = "0x4597E60", VA = "0x184599060")]
	public bool KJCNBHBPKIJ(TVal PIIJMEAKDGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4598E20", Offset = "0x4597C20", VA = "0x184598E20")]
	public bool HGEFFBLNLHD(KeyValuePair<TVal, TKey> LBGDLICPCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4598790", Offset = "0x4597590", VA = "0x184598790")]
	public bool FAHLDBEBGON(TVal PIIJMEAKDGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4598790", Offset = "0x4597590", VA = "0x184598790")]
	public bool FAHLDBEBGON(KeyValuePair<TVal, TKey> LBGDLICPCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4598DE0", Offset = "0x4597BE0", VA = "0x184598DE0")]
	public bool HADOILGNPLN(TVal PIIJMEAKDGO, out TKey DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x45992D0", Offset = "0x45980D0", VA = "0x1845992D0")]
	public IEnumerator<KeyValuePair<TVal, TKey>> OFFOLACLLMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4599130", Offset = "0x4597F30", VA = "0x184599130")]
	private void KOCNLHLDBCG(TKey PIIJMEAKDGO, TVal EKFKNNJJKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x45985E0", Offset = "0x45973E0", VA = "0x1845985E0")]
	private void DNPHGPLALFI(TKey PIIJMEAKDGO, TVal EKFKNNJJKLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4598B20", Offset = "0x4597920", VA = "0x184598B20")]
	private bool FKCAFOAMPCI(TKey PIIJMEAKDGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x4598980", Offset = "0x4597780", VA = "0x184598980")]
	private bool FKCAFOAMPCI(TVal EKFKNNJJKLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x45995A0", Offset = "0x45983A0", VA = "0x1845995A0")]
	public JKKPJACIJEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
[DefaultMember("Item")]
public class DDIGBBBLJIA<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private global::DDIGBBBLJIA<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x423CFA0", Offset = "0x423BDA0", VA = "0x18423CFA0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3F11D80", Offset = "0x3F10B80", VA = "0x183F11D80")]
		public Enumerator(global::DDIGBBBLJIA<T> FAHBHODOFIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x42393C0", Offset = "0x42381C0", VA = "0x1842393C0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x423B610", Offset = "0x423A410", VA = "0x18423B610", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x4238BF0", Offset = "0x42379F0", VA = "0x184238BF0")]
		private void KIFGABCEKOI()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private T[] IMNHEMNOGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private int JHOHOEJNFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private int LMEADNAFMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private int IIJDDKBOPLN;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x404C2A0", Offset = "0x404B0A0", VA = "0x18404C2A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x404C370", Offset = "0x404B170", VA = "0x18404C370")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x404D2C0", Offset = "0x404C0C0", VA = "0x18404D2C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x404D5B0", Offset = "0x404C3B0", VA = "0x18404D5B0")]
	public DDIGBBBLJIA(int CIMAPKKBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x404C7D0", Offset = "0x404B5D0", VA = "0x18404C7D0")]
	public void HMNAIPBHJIK(T PHLICBNKKOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x404B670", Offset = "0x404A470", VA = "0x18404B670")]
	public void BMDGMDNJPHD(IEnumerable<T> CFMHDCICDHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x404C4F0", Offset = "0x404B2F0", VA = "0x18404C4F0")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x404C2E0", Offset = "0x404B0E0", VA = "0x18404C2E0")]
	public void CLGFLCCLAOK(int MIOCJKOOLBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x404C510", Offset = "0x404B310", VA = "0x18404C510")]
	public void FJFOOFILPIN(int MIOCJKOOLBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x404C940", Offset = "0x404B740", VA = "0x18404C940")]
	public void KEBDNMKLCMO(T[] DBOPJMNFJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x404C890", Offset = "0x404B690", VA = "0x18404C890")]
	public Enumerator HPPJKDPBNFG()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x404D530", Offset = "0x404C330", VA = "0x18404D530", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x404D530", Offset = "0x404C330", VA = "0x18404D530", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x404D060", Offset = "0x404BE60", VA = "0x18404D060")]
	private int MBKHPDEENCC(int NPDGHPHAKDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x404C270", Offset = "0x404B070", VA = "0x18404C270")]
	private int BOJCBJHOKNG(int NPDGHPHAKDK)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[DefaultMember("Item")]
public class JMHGACFPMMA<Internal, External> : IList<External>, ICollection<External>, IEnumerable<External>, IEnumerable, IReadOnlyList<External>, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly Func<Internal, External> JLJLCNPKNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Func<External, Internal> KDMLDPACOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private IList<Internal> DEEJEKFIHBB;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public IList<Internal> CKCLLMBDNPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6B2560", Offset = "0x6B1360", VA = "0x1806B2560")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x739270", Offset = "0x738070", VA = "0x180739270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public bool NMHHOIIAEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x77CC90", Offset = "0x77BA90", VA = "0x18077CC90", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x77CCA0", Offset = "0x77BAA0", VA = "0x18077CCA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public External PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x459C680", Offset = "0x459B480", VA = "0x18459C680", Slot = "18")]
		get
		{
			return (External)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x459C720", Offset = "0x459B520", VA = "0x18459C720", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x459C620", Offset = "0x459B420", VA = "0x18459C620", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x459C590", Offset = "0x459B390", VA = "0x18459C590")]
	public JMHGACFPMMA(Func<Internal, External> JLJLCNPKNHA, Func<External, Internal> KDMLDPACOFJ, bool FJBBIADFENA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x459C2B0", Offset = "0x459B0B0", VA = "0x18459C2B0", Slot = "6")]
	public int IndexOf(External LBGDLICPCAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x459BF30", Offset = "0x459AD30", VA = "0x18459BF30", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x459BF90", Offset = "0x459AD90", VA = "0x18459BF90", Slot = "13")]
	public bool Contains(External LBGDLICPCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x459C020", Offset = "0x459AE20", VA = "0x18459C020", Slot = "14")]
	public void CopyTo(External[] DBOPJMNFJMA, int MNHDAEDPKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x459BE40", Offset = "0x459AC40", VA = "0x18459BE40", Slot = "11")]
	public void Add(External LBGDLICPCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x459C3A0", Offset = "0x459B1A0", VA = "0x18459C3A0", Slot = "7")]
	public void Insert(int NPDGHPHAKDK, External LBGDLICPCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x459C500", Offset = "0x459B300", VA = "0x18459C500", Slot = "15")]
	public bool Remove(External LBGDLICPCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x459C440", Offset = "0x459B240", VA = "0x18459C440", Slot = "8")]
	public void RemoveAt(int NPDGHPHAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x459C240", Offset = "0x459B040", VA = "0x18459C240", Slot = "16")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x38FD520", Offset = "0x38FC320", VA = "0x1838FD520", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class BGCFPJOOFMG<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly Func<Internal, External> JLJLCNPKNHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private IReadOnlyList<Internal> DEEJEKFIHBB;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public IReadOnlyList<Internal> CKCLLMBDNPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x7337A0", Offset = "0x7325A0", VA = "0x1807337A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public bool NMHHOIIAEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6B17F0", Offset = "0x6B05F0", VA = "0x1806B17F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public External PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x4600BB0", Offset = "0x45FF9B0", VA = "0x184600BB0", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x4600B50", Offset = "0x45FF950", VA = "0x184600B50", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x2E6FB60", Offset = "0x2E6E960", VA = "0x182E6FB60")]
	public BGCFPJOOFMG(Func<Internal, External> JLJLCNPKNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x4600B00", Offset = "0x45FF900", VA = "0x184600B00")]
	public BGCFPJOOFMG(IReadOnlyList<Internal> DEEJEKFIHBB, Func<Internal, External> JLJLCNPKNHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x46008E0", Offset = "0x45FF6E0", VA = "0x1846008E0")]
	public void KEBDNMKLCMO(External[] DBOPJMNFJMA, int MNHDAEDPKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x4600870", Offset = "0x45FF670", VA = "0x184600870", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x3909810", Offset = "0x3908610", VA = "0x183909810", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[DefaultMember("Item")]
public class OBOMKLFOIIM<Internal, External> : IReadOnlyList<External>, IEnumerable<External>, IEnumerable, IReadOnlyCollection<External> where External : Internal
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private IReadOnlyList<Internal> DEEJEKFIHBB;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IReadOnlyList<Internal> CKCLLMBDNPG
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6B2150", Offset = "0x6B0F50", VA = "0x1806B2150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public bool NMHHOIIAEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6B17F0", Offset = "0x6B05F0", VA = "0x1806B17F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public External PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x3BC8C00", Offset = "0x3BC7A00", VA = "0x183BC8C00", Slot = "4")]
		get
		{
			return (External)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x3BC8BA0", Offset = "0x3BC79A0", VA = "0x183BC8BA0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x2E6FB60", Offset = "0x2E6E960", VA = "0x182E6FB60")]
	public OBOMKLFOIIM(IReadOnlyList<Internal> DEEJEKFIHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3BC88D0", Offset = "0x3BC76D0", VA = "0x183BC88D0")]
	public bool HGEFFBLNLHD(External LBGDLICPCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3BC8970", Offset = "0x3BC7770", VA = "0x183BC8970")]
	public void KEBDNMKLCMO(External[] DBOPJMNFJMA, int MNHDAEDPKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x3BC8860", Offset = "0x3BC7660", VA = "0x183BC8860", Slot = "6")]
	public IEnumerator<External> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x38FD520", Offset = "0x38FC320", VA = "0x1838FD520", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public abstract class LMCLBHOIDLK
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract void BDMGLGDIAIK(object[] IJPNBHGIPKF);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	protected LMCLBHOIDLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public abstract class NKCMIKBJJDI<T> : LMCLBHOIDLK
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	protected struct CJLOHOMPBBP
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public enum MOJHLFDJEJL
		{
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			ADD,
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			REMOVE,
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			CLEAR
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public MOJHLFDJEJL IGEIBCJNCHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public T KNOLDLABLMF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int PKNDEDHNFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly bool DCELNLFEJJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	protected readonly bool BELFIEMNONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	protected List<T> MGFLHOAJMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private List<CJLOHOMPBBP> LBDAFFHFIMN;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public bool DACELNFABBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x42AB480", Offset = "0x42AA280", VA = "0x1842AB480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x42ABB60", Offset = "0x42AA960", VA = "0x1842ABB60")]
	protected NKCMIKBJJDI(bool BELFIEMNONK, bool DCELNLFEJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x42AB7D0", Offset = "0x42AA5D0", VA = "0x1842AB7D0")]
	protected bool FBCGHFFPLDI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x42AB4C0", Offset = "0x42AA2C0", VA = "0x1842AB4C0")]
	protected void ELEMAPGCLOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x42AB9B0", Offset = "0x42AA7B0", VA = "0x1842AB9B0")]
	protected void NPGBKNFOMLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3C8FCC0", Offset = "0x3C8EAC0", VA = "0x183C8FCC0")]
	private static void ELKHKHMMNNJ<U>(ref List<U> DEEJEKFIHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x42AB850", Offset = "0x42AA650", VA = "0x1842AB850", Slot = "5")]
	public void HMNAIPBHJIK(T KNOLDLABLMF, bool IDPMOFNNEIO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x42AB690", Offset = "0x42AA490", VA = "0x1842AB690", Slot = "6")]
	public void FAHLDBEBGON(T KNOLDLABLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x42AB580", Offset = "0x42AA380", VA = "0x1842AB580")]
	public void EMOCNNJJBKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface ACNMGHLEGGF
{
	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HMNAIPBHJIK(Action KNOLDLABLMF, bool IDPMOFNNEIO = false);

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FAHLDBEBGON(Action KNOLDLABLMF);
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public sealed class FMJNLFCNDHK : global::NKCMIKBJJDI<Action>, ACNMGHLEGGF
{
	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6354EF0", Offset = "0x6353CF0", VA = "0x186354EF0")]
	public FMJNLFCNDHK(bool BELFIEMNONK = false, bool DCELNLFEJJK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6354CE0", Offset = "0x6353AE0", VA = "0x186354CE0")]
	public void PEAOLDLIGBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6354BB0", Offset = "0x63539B0", VA = "0x186354BB0", Slot = "4")]
	public override void BDMGLGDIAIK(object[] IJPNBHGIPKF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6354C20", Offset = "0x6353A20", VA = "0x186354C20")]
	public static FMJNLFCNDHK LGHBHOPGAGF(FMJNLFCNDHK GGMFKINHGHM, Action KNOLDLABLMF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6354C80", Offset = "0x6353A80", VA = "0x186354C80")]
	public static FMJNLFCNDHK OOOBHHMAEMO(FMJNLFCNDHK GGMFKINHGHM, Action KNOLDLABLMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public interface EIIAIBCICAJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HMNAIPBHJIK(Action<T> KNOLDLABLMF, bool IDPMOFNNEIO = false);

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FAHLDBEBGON(Action<T> KNOLDLABLMF);
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public sealed class PBGGDBDIKGA<T> : global::NKCMIKBJJDI<Action<T>>, global::EIIAIBCICAJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2E69620", Offset = "0x2E68420", VA = "0x182E69620")]
	public PBGGDBDIKGA(bool BELFIEMNONK = false, bool DCELNLFEJJK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x41E4DF0", Offset = "0x41E3BF0", VA = "0x1841E4DF0")]
	public void PEAOLDLIGBA(T PHLICBNKKOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x41E3F70", Offset = "0x41E2D70", VA = "0x1841E3F70", Slot = "4")]
	public override void BDMGLGDIAIK(object[] IJPNBHGIPKF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x41E40F0", Offset = "0x41E2EF0", VA = "0x1841E40F0")]
	public static global::PBGGDBDIKGA<T> LGHBHOPGAGF(global::PBGGDBDIKGA<T> GGMFKINHGHM, Action<T> KNOLDLABLMF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x41E4190", Offset = "0x41E2F90", VA = "0x1841E4190")]
	public static global::PBGGDBDIKGA<T> OOOBHHMAEMO(global::PBGGDBDIKGA<T> GGMFKINHGHM, Action<T> KNOLDLABLMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface MEFLFOKHJOE<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HMNAIPBHJIK(Action<T, U> KNOLDLABLMF, bool IDPMOFNNEIO = false);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FAHLDBEBGON(Action<T, U> KNOLDLABLMF);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public sealed class BKNNAJHBPLG<T, U> : global::NKCMIKBJJDI<Action<T, U>>, global::MEFLFOKHJOE<T, U>
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x2E69620", Offset = "0x2E68420", VA = "0x182E69620")]
	public BKNNAJHBPLG(bool BELFIEMNONK = false, bool DCELNLFEJJK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3BEE670", Offset = "0x3BED470", VA = "0x183BEE670")]
	public void PEAOLDLIGBA(T PHLICBNKKOO, U GNFKHCJLCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3BEBF80", Offset = "0x3BEAD80", VA = "0x183BEBF80", Slot = "4")]
	public override void BDMGLGDIAIK(object[] IJPNBHGIPKF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x3BED250", Offset = "0x3BEC050", VA = "0x183BED250")]
	public static global::BKNNAJHBPLG<T, U> LGHBHOPGAGF(global::BKNNAJHBPLG<T, U> GGMFKINHGHM, Action<T, U> KNOLDLABLMF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x3BED2F0", Offset = "0x3BEC0F0", VA = "0x183BED2F0")]
	public static global::BKNNAJHBPLG<T, U> OOOBHHMAEMO(global::BKNNAJHBPLG<T, U> GGMFKINHGHM, Action<T, U> KNOLDLABLMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface LPEFDHOOHFG<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HMNAIPBHJIK(Action<T, U, V> KNOLDLABLMF, bool IDPMOFNNEIO = false);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FAHLDBEBGON(Action<T, U, V> KNOLDLABLMF);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class OEHJHDHJDOL<T, U, V> : global::NKCMIKBJJDI<Action<T, U, V>>, global::LPEFDHOOHFG<T, U, V>
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x2E69620", Offset = "0x2E68420", VA = "0x182E69620")]
	public OEHJHDHJDOL(bool BELFIEMNONK = false, bool DCELNLFEJJK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x3BCF7F0", Offset = "0x3BCE5F0", VA = "0x183BCF7F0")]
	public void PEAOLDLIGBA(T PHLICBNKKOO, U GNFKHCJLCKF, V BGLBBPFJJCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3BCDA50", Offset = "0x3BCC850", VA = "0x183BCDA50", Slot = "4")]
	public override void BDMGLGDIAIK(object[] IJPNBHGIPKF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3BCE740", Offset = "0x3BCD540", VA = "0x183BCE740")]
	public static global::OEHJHDHJDOL<T, U, V> LGHBHOPGAGF(global::OEHJHDHJDOL<T, U, V> GGMFKINHGHM, Action<T, U, V> KNOLDLABLMF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3BCE7E0", Offset = "0x3BCD5E0", VA = "0x183BCE7E0")]
	public static global::OEHJHDHJDOL<T, U, V> OOOBHHMAEMO(global::OEHJHDHJDOL<T, U, V> GGMFKINHGHM, Action<T, U, V> KNOLDLABLMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface ECMMBIPNMBB<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HMNAIPBHJIK(Action<T, U, V, W> KNOLDLABLMF, bool IDPMOFNNEIO = false);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FAHLDBEBGON(Action<T, U, V, W> KNOLDLABLMF);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public sealed class PFNIKCICJFJ<T, U, V, W> : global::NKCMIKBJJDI<Action<T, U, V, W>>, global::ECMMBIPNMBB<T, U, V, W>
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x2E69620", Offset = "0x2E68420", VA = "0x182E69620")]
	public PFNIKCICJFJ(bool BELFIEMNONK = false, bool DCELNLFEJJK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x465CB10", Offset = "0x465B910", VA = "0x18465CB10")]
	public void PEAOLDLIGBA(T PHLICBNKKOO, U GNFKHCJLCKF, V BGLBBPFJJCJ, W AOJLCLDDLKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x465C490", Offset = "0x465B290", VA = "0x18465C490", Slot = "4")]
	public override void BDMGLGDIAIK(object[] IJPNBHGIPKF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x465C9D0", Offset = "0x465B7D0", VA = "0x18465C9D0")]
	public static global::PFNIKCICJFJ<T, U, V, W> LGHBHOPGAGF(global::PFNIKCICJFJ<T, U, V, W> GGMFKINHGHM, Action<T, U, V, W> KNOLDLABLMF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x465CA70", Offset = "0x465B870", VA = "0x18465CA70")]
	public static global::PFNIKCICJFJ<T, U, V, W> OOOBHHMAEMO(global::PFNIKCICJFJ<T, U, V, W> GGMFKINHGHM, Action<T, U, V, W> KNOLDLABLMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface KMCGBBGECED<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HMNAIPBHJIK(Action<T, U, V, W, X> KNOLDLABLMF, bool IDPMOFNNEIO = false);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FAHLDBEBGON(Action<T, U, V, W, X> KNOLDLABLMF);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class HPLHGOIIPJP<T, U, V, W, X> : global::NKCMIKBJJDI<Action<T, U, V, W, X>>, global::KMCGBBGECED<T, U, V, W, X>
{
	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x2E69620", Offset = "0x2E68420", VA = "0x182E69620")]
	public HPLHGOIIPJP(bool BELFIEMNONK = false, bool DCELNLFEJJK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x5091570", Offset = "0x5090370", VA = "0x185091570")]
	public void PEAOLDLIGBA(T PHLICBNKKOO, U GNFKHCJLCKF, V BGLBBPFJJCJ, W AOJLCLDDLKO, X JMDPDGBMGAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5090E20", Offset = "0x508FC20", VA = "0x185090E20", Slot = "4")]
	public override void BDMGLGDIAIK(object[] IJPNBHGIPKF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5091430", Offset = "0x5090230", VA = "0x185091430")]
	public static global::HPLHGOIIPJP<T, U, V, W, X> LGHBHOPGAGF(global::HPLHGOIIPJP<T, U, V, W, X> GGMFKINHGHM, Action<T, U, V, W, X> KNOLDLABLMF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x50914D0", Offset = "0x50902D0", VA = "0x1850914D0")]
	public static global::HPLHGOIIPJP<T, U, V, W, X> OOOBHHMAEMO(global::HPLHGOIIPJP<T, U, V, W, X> GGMFKINHGHM, Action<T, U, V, W, X> KNOLDLABLMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface KKEKCDMKHJG<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HMNAIPBHJIK(Action<T, U, V, W, X, Y> KNOLDLABLMF, bool IDPMOFNNEIO = false);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FAHLDBEBGON(Action<T, U, V, W, X, Y> KNOLDLABLMF);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class NOJPDCDMHAB<T, U, V, W, X, Y> : global::NKCMIKBJJDI<Action<T, U, V, W, X, Y>>, global::KKEKCDMKHJG<T, U, V, W, X, Y>
{
	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x2E69620", Offset = "0x2E68420", VA = "0x182E69620")]
	public NOJPDCDMHAB(bool BELFIEMNONK = false, bool DCELNLFEJJK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x4C3CF90", Offset = "0x4C3BD90", VA = "0x184C3CF90")]
	public void PEAOLDLIGBA(T PHLICBNKKOO, U GNFKHCJLCKF, V BGLBBPFJJCJ, W AOJLCLDDLKO, X JMDPDGBMGAA, Y GKDCJKNJEID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x4C3C450", Offset = "0x4C3B250", VA = "0x184C3C450", Slot = "4")]
	public override void BDMGLGDIAIK(object[] IJPNBHGIPKF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x4C3CE50", Offset = "0x4C3BC50", VA = "0x184C3CE50")]
	public static global::NOJPDCDMHAB<T, U, V, W, X, Y> LGHBHOPGAGF(global::NOJPDCDMHAB<T, U, V, W, X, Y> GGMFKINHGHM, Action<T, U, V, W, X, Y> KNOLDLABLMF)
	{
		return null;
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x4C3CEF0", Offset = "0x4C3BCF0", VA = "0x184C3CEF0")]
	public static global::NOJPDCDMHAB<T, U, V, W, X, Y> OOOBHHMAEMO(global::NOJPDCDMHAB<T, U, V, W, X, Y> GGMFKINHGHM, Action<T, U, V, W, X, Y> KNOLDLABLMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class JEJKEABBLJL<T>
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public readonly struct GLEMGOGMIOB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private readonly global::JEJKEABBLJL<T> NOPPIGEMPOA;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public T FBCEGMCNEND
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0x47792D0", Offset = "0x47780D0", VA = "0x1847792D0")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x47792A0", Offset = "0x47780A0", VA = "0x1847792A0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x6B0DE0", Offset = "0x6AFBE0", VA = "0x1806B0DE0")]
		public GLEMGOGMIOB(global::JEJKEABBLJL<T> NOPPIGEMPOA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[CompilerGenerated]
	private struct HHJMOCELEPB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public AsyncTaskMethodBuilder<GLEMGOGMIOB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public global::JEJKEABBLJL<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x3B11AC0", Offset = "0x3B108C0", VA = "0x183B11AC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3055AA0", Offset = "0x30548A0", VA = "0x183055AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct FDGGHNBAODI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public AsyncTaskMethodBuilder<GLEMGOGMIOB> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public global::JEJKEABBLJL<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x37CB420", Offset = "0x37CA220", VA = "0x1837CB420", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x3055AA0", Offset = "0x30548A0", VA = "0x183055AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly SemaphoreSlim OJNIKPINPPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private T GKFBLNLJAOM;

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public int NCNPANIECOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x3DCE2F0", Offset = "0x3DCD0F0", VA = "0x183DCE2F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x3DCE8B0", Offset = "0x3DCD6B0", VA = "0x183DCE8B0")]
	public JEJKEABBLJL(in T GKFBLNLJAOM, int CHEGOGGIJPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x3DCE9F0", Offset = "0x3DCD7F0", VA = "0x183DCE9F0")]
	public JEJKEABBLJL(in T GKFBLNLJAOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x3DCE270", Offset = "0x3DCD070", VA = "0x183DCE270")]
	public GLEMGOGMIOB BBNOHFILLPN()
	{
		return default(GLEMGOGMIOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3DCE2B0", Offset = "0x3DCD0B0", VA = "0x183DCE2B0")]
	public GLEMGOGMIOB BBNOHFILLPN(CancellationToken NIEOBBGKEFJ)
	{
		return default(GLEMGOGMIOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x3DCE310", Offset = "0x3DCD110", VA = "0x183DCE310")]
	[AsyncStateMachine(typeof(global::JEJKEABBLJL<>.HHJMOCELEPB))]
	public Task<GLEMGOGMIOB> MFFCMACDCCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x3DCE5D0", Offset = "0x3DCD3D0", VA = "0x183DCE5D0")]
	[AsyncStateMachine(typeof(global::JEJKEABBLJL<>.FDGGHNBAODI))]
	public Task<GLEMGOGMIOB> MFFCMACDCCJ(CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class JKCAMACMDII
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x63579A0", Offset = "0x63567A0", VA = "0x1863579A0")]
	public static global::JEJKEABBLJL<PEFLLNEDEOA> DHGKFEMNGCO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6357A00", Offset = "0x6356800", VA = "0x186357A00")]
	public static global::JEJKEABBLJL<PEFLLNEDEOA> DHGKFEMNGCO(int CHEGOGGIJPN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x33E31D0", Offset = "0x33E1FD0", VA = "0x1833E31D0")]
	public static global::JEJKEABBLJL<T> DHGKFEMNGCO<T>(in T GKFBLNLJAOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x3806D70", Offset = "0x3805B70", VA = "0x183806D70")]
	public static global::JEJKEABBLJL<T> DHGKFEMNGCO<T>(in T GKFBLNLJAOM, int CHEGOGGIJPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public class FMDELPMLIIP<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public delegate Task<TResult> ACMCHDEEEKA(TRequest KJACHHOOFKC, CancellationToken NIEOBBGKEFJ);

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public enum CPFPFPDDAIP
	{
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class BOMDDIMNHMJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private const float MMNPGHLCNIE = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private TimeSpan DLAOMPLBBCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public int ADPBMDBFFPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public CPFPFPDDAIP EIMEPHMCNCL;

		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public static readonly BOMDDIMNHMJ DCLACCPOJAP;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float OHOOMJIKAGO
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x48A46D0", Offset = "0x48A34D0", VA = "0x1848A46D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public TimeSpan EKCILDCNCGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x48A4900", Offset = "0x48A3700", VA = "0x1848A4900")]
		public BOMDDIMNHMJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private readonly struct DMKNHJCOCDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		public readonly TRequest KJACHHOOFKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		public readonly CancellationToken NIEOBBGKEFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		public readonly TaskCompletionSource<TResult> PGKECCGGAAP;

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x3AB9970", Offset = "0x3AB8770", VA = "0x183AB9970")]
		public DMKNHJCOCDB(TRequest KJACHHOOFKC, TaskCompletionSource<TResult> PGKECCGGAAP, CancellationToken NIEOBBGKEFJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class DJCIEMMLFFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public TaskCompletionSource<TResult> taskCompletionSource;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
		public DJCIEMMLFFC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x3443340", Offset = "0x3442140", VA = "0x183443340")]
		internal void <AddRequest>b__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	[CompilerGenerated]
	private struct CBBCEIKKHKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		public global::FMDELPMLIIP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x3C1EA00", Offset = "0x3C1D800", VA = "0x183C1EA00", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x77A8B0", Offset = "0x7796B0", VA = "0x18077A8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	[CompilerGenerated]
	private struct CCHDADNLHCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		public global::FMDELPMLIIP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private DMKNHJCOCDB <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x3C1FE90", Offset = "0x3C1EC90", VA = "0x183C1FE90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x77A8B0", Offset = "0x7796B0", VA = "0x18077A8B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly CancellationTokenSource PPLHONOODDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly List<DMKNHJCOCDB> LMDBGPJDMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly BOMDDIMNHMJ MAMHMNGEGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly ACMCHDEEEKA DGMNCLPFMBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private Task EHELOIBLHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private int DLHHEOOCPPD;

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x3FE3590", Offset = "0x3FE2390", VA = "0x183FE3590")]
	public FMDELPMLIIP(ACMCHDEEEKA DGMNCLPFMBC, [Optional] BOMDDIMNHMJ MAMHMNGEGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x3FE1B30", Offset = "0x3FE0930", VA = "0x183FE1B30")]
	public Task<TResult> FFPMKODNIDL(TRequest KJACHHOOFKC, CancellationToken NIEOBBGKEFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x3FE22D0", Offset = "0x3FE10D0", VA = "0x183FE22D0")]
	private void HAOEBKIAIJJ(DMKNHJCOCDB MLGBDIFGNNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3FE2BE0", Offset = "0x3FE19E0", VA = "0x183FE2BE0")]
	[AsyncStateMachine(typeof(global::FMDELPMLIIP<, >.CBBCEIKKHKO))]
	private Task KCMHKOBLJIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3FE3190", Offset = "0x3FE1F90", VA = "0x183FE3190")]
	private DMKNHJCOCDB PEFELEHEIIP()
	{
		return default(DMKNHJCOCDB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x3FE2530", Offset = "0x3FE1330", VA = "0x183FE2530")]
	[AsyncStateMachine(typeof(global::FMDELPMLIIP<, >.CCHDADNLHCM))]
	private Task IHNDBHMGEKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3FE2840", Offset = "0x3FE1640", VA = "0x183FE2840")]
	private void JKBMKIJFBCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3FE1AF0", Offset = "0x3FE08F0", VA = "0x183FE1AF0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public class NGJABPMGFNC<TKey, TVal> : global::OKOFPBCAHLM<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private int KPBOMBAEKMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	internal Dictionary<TKey, (TVal value, int size)> HLPGBJPDCPB;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	internal override int MHOGNANJKMC
	{
		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x42A4220", Offset = "0x42A3020", VA = "0x1842A4220", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	internal int JHIENKIAEFO
	{
		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x42A4250", Offset = "0x42A3050", VA = "0x1842A4250")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public override int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x42A4010", Offset = "0x42A2E10", VA = "0x1842A4010", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x42A45A0", Offset = "0x42A33A0", VA = "0x1842A45A0")]
	public NGJABPMGFNC(int CIMAPKKBLKM, [Optional] OGCIDHKEGNI GFCEKHLMHPJ, [Optional] IEqualityComparer<TKey> MEOPPHIMHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x42A3F70", Offset = "0x42A2D70", VA = "0x1842A3F70")]
	public void AEEHHPHACDE(TKey PIIJMEAKDGO, TVal DFEOJBAFBHE, bool MNMAHDIPEHO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x42A3EF0", Offset = "0x42A2CF0", VA = "0x1842A3EF0")]
	public bool ADFLHLKLIHN(TKey PIIJMEAKDGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x42A4180", Offset = "0x42A2F80", VA = "0x1842A4180", Slot = "6")]
	public override bool HADOILGNPLN(TKey AONMHIKEHCL, out TVal DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x42A4280", Offset = "0x42A3080", VA = "0x1842A4280")]
	public bool NIDCHIJKCBB(TKey PIIJMEAKDGO, TVal DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x42A4490", Offset = "0x42A3290", VA = "0x1842A4490")]
	public bool PDKFNIHLGDG(TKey PIIJMEAKDGO, TVal DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x42A4110", Offset = "0x42A2F10", VA = "0x1842A4110", Slot = "7")]
	public override void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x42A4070", Offset = "0x42A2E70", VA = "0x1842A4070")]
	private bool EDIHAMABFKK(TKey PIIJMEAKDGO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[DefaultMember("Item")]
public class OKOFPBCAHLM<TKey, TVal>
{
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public delegate int OGCIDHKEGNI(TKey PIIJMEAKDGO, TVal DFEOJBAFBHE);

	[Cpp2IlInjected.Token(Token = "0x200004D")]
	private class CJPKHHAKKLH
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public TKey GDJDAALKGJB
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x77D710", Offset = "0x77C510", VA = "0x18077D710")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public TVal FBCEGMCNEND
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x6B2560", Offset = "0x6B1360", VA = "0x1806B2560")]
			[CompilerGenerated]
			get
			{
				return (TVal)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0x739270", Offset = "0x738070", VA = "0x180739270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public int FGDMPDNAJLP
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x73BBB0", Offset = "0x73A9B0", VA = "0x18073BBB0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B3")]
			[Cpp2IlInjected.Address(RVA = "0x73C390", Offset = "0x73B190", VA = "0x18073C390")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public DateTime DGGACODGFBJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x7385B0", Offset = "0x7373B0", VA = "0x1807385B0")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x957920", Offset = "0x956720", VA = "0x180957920")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x46ED6A0", Offset = "0x46EC4A0", VA = "0x1846ED6A0")]
		public CJPKHHAKKLH(TKey PIIJMEAKDGO, TVal EKFKNNJJKLD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public const int NGCIBFNGJEN = -1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly Dictionary<TKey, LinkedListNode<CJPKHHAKKLH>> MJECDAAIIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private readonly LinkedList<CJPKHHAKKLH> AACCDJFJKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	protected readonly OGCIDHKEGNI GFCEKHLMHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly TimeSpan FOLHBICOLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly LOCLLINHKIG BGOMCGOKDIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int HHJGJNONLOJ;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int AMLADJJCJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x83CC80", Offset = "0x83BA80", VA = "0x18083CC80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private bool OHALBLFMLKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x39CC720", Offset = "0x39CB520", VA = "0x1839CC720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	internal virtual int MHOGNANJKMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x83D210", Offset = "0x83C010", VA = "0x18083D210", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private int MIOCJKOOLBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3825E70", Offset = "0x3824C70", VA = "0x183825E70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public virtual int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x3679500", Offset = "0x3678300", VA = "0x183679500", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public IEnumerable<TKey> GLAEFLDOOIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x39CC7B0", Offset = "0x39CB5B0", VA = "0x1839CC7B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public TVal PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x39CB090", Offset = "0x39C9E90", VA = "0x1839CB090")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x39CD7C0", Offset = "0x39CC5C0", VA = "0x1839CD7C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x39CE330", Offset = "0x39CD130", VA = "0x1839CE330")]
	public OKOFPBCAHLM(int CIMAPKKBLKM, [Optional] OGCIDHKEGNI GFCEKHLMHPJ, [Optional] IEqualityComparer<TKey> MEOPPHIMHHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x39CE450", Offset = "0x39CD250", VA = "0x1839CE450")]
	public OKOFPBCAHLM(TimeSpan FOLHBICOLAE, [Optional] IEqualityComparer<TKey> MEOPPHIMHHG, [Optional] LOCLLINHKIG BGOMCGOKDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x39CE400", Offset = "0x39CD200", VA = "0x1839CE400")]
	public OKOFPBCAHLM(int CIMAPKKBLKM, TimeSpan FOLHBICOLAE, [Optional] IEqualityComparer<TKey> MEOPPHIMHHG, [Optional] LOCLLINHKIG BGOMCGOKDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x39CE0B0", Offset = "0x39CCEB0", VA = "0x1839CE0B0")]
	public OKOFPBCAHLM(int CIMAPKKBLKM, OGCIDHKEGNI GFCEKHLMHPJ, TimeSpan FOLHBICOLAE, [Optional] IEqualityComparer<TKey> MEOPPHIMHHG, [Optional] LOCLLINHKIG BGOMCGOKDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x39CD1D0", Offset = "0x39CBFD0", VA = "0x1839CD1D0")]
	public void LAHNAJAJJKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x39CBB10", Offset = "0x39CA910", VA = "0x1839CBB10")]
	public void FAFPJPFNCCD(TKey PIIJMEAKDGO, TVal DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x39CBD70", Offset = "0x39CAB70", VA = "0x1839CBD70")]
	public bool FAHLDBEBGON(TKey PIIJMEAKDGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x39CAE90", Offset = "0x39C9C90", VA = "0x1839CAE90")]
	private TVal CIGAFCHFFML(TKey AONMHIKEHCL)
	{
		return (TVal)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x39CC300", Offset = "0x39CB100", VA = "0x1839CC300", Slot = "6")]
	public virtual bool HADOILGNPLN(TKey AONMHIKEHCL, out TVal DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x39CB9E0", Offset = "0x39CA7E0", VA = "0x1839CB9E0", Slot = "7")]
	public virtual void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x39CD640", Offset = "0x39CC440", VA = "0x1839CD640")]
	private bool OBNLMAKGDAG(CJPKHHAKKLH FFBOGLDBEDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x39CB790", Offset = "0x39CA590", VA = "0x1839CB790")]
	private void ELODKBAKHBH(LinkedListNode<CJPKHHAKKLH> FNELMAJLPKO, TVal ANLFJINAGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x39CDC00", Offset = "0x39CCA00", VA = "0x1839CDC00")]
	private void PAGNFDLBLPI(TKey PIIJMEAKDGO, TVal DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x39CCEC0", Offset = "0x39CBCC0", VA = "0x1839CCEC0")]
	private void LACKCJBOIMF(CJPKHHAKKLH FFBOGLDBEDF, TVal ANLFJINAGJI, int AODBOJHBLIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
[DefaultMember("Item")]
public class OBMDEILOPNL<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private readonly List<T> DEEJEKFIHBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private HashSet<T> EHBHDMJAKLC;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x3443340", Offset = "0x3442140", VA = "0x183443340", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public bool NMHHOIIAEMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x6B1E00", Offset = "0x6B0C00", VA = "0x1806B1E00", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public T PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x2F60280", Offset = "0x2F5F080", VA = "0x182F60280", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x3BC86E0", Offset = "0x3BC74E0", VA = "0x183BC86E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x3BC7D30", Offset = "0x3BC6B30", VA = "0x183BC7D30", Slot = "11")]
	public void Add(T LBGDLICPCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x3BC82B0", Offset = "0x3BC70B0", VA = "0x183BC82B0")]
	public bool PICFJGOPDMI(T LBGDLICPCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x3BC8580", Offset = "0x3BC7380", VA = "0x183BC8580", Slot = "15")]
	public bool Remove(T LBGDLICPCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x3BC7FC0", Offset = "0x3BC6DC0", VA = "0x183BC7FC0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x32CEDE0", Offset = "0x32CDBE0", VA = "0x1832CEDE0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x3BC7D60", Offset = "0x3BC6B60", VA = "0x183BC7D60", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x32E3E60", Offset = "0x32E2C60", VA = "0x1832E3E60", Slot = "13")]
	public bool Contains(T LBGDLICPCAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x3BC7DC0", Offset = "0x3BC6BC0", VA = "0x183BC7DC0", Slot = "14")]
	public void CopyTo(T[] DBOPJMNFJMA, int MNHDAEDPKMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x3BC8040", Offset = "0x3BC6E40", VA = "0x183BC8040", Slot = "6")]
	public int IndexOf(T LBGDLICPCAB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x3BC8070", Offset = "0x3BC6E70", VA = "0x183BC8070", Slot = "7")]
	public void Insert(int NPDGHPHAKDK, T LBGDLICPCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x3BC8350", Offset = "0x3BC7150", VA = "0x183BC8350", Slot = "8")]
	public void RemoveAt(int NPDGHPHAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x3BC7EC0", Offset = "0x3BC6CC0", VA = "0x183BC7EC0")]
	public void DDCLDBCGDHO(Predicate<T> ELHCNCOMOGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x3BC7F90", Offset = "0x3BC6D90", VA = "0x183BC7F90")]
	public void EEKEIPLAHKB(Comparison<T> PJBLKOCNNIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x3BC8600", Offset = "0x3BC7400", VA = "0x183BC8600")]
	public OBMDEILOPNL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class HFJEEKBFOPF
{
	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x63569B0", Offset = "0x63557B0", VA = "0x1863569B0")]
	public static Vector3 AALKFFMJOHG(this GameObject NCAOMIEGHPA, float HCDKHMHEHFM)
	{
		return default(Vector3);
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60001CD")]
			[Cpp2IlInjected.Address(RVA = "0x8DA910", Offset = "0x8D9710", VA = "0x1808DA910")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x21C9AB0", Offset = "0x21C88B0", VA = "0x1821C9AB0")]
		public SerializedGuid(in Guid FBKLHONPMNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x635AD50", Offset = "0x6359B50", VA = "0x18635AD50")]
		public static SerializedGuid MJHPIDKPELG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x635AF10", Offset = "0x6359D10", VA = "0x18635AF10")]
		public static SerializedGuid PBCPIDPDGMJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x635ACC0", Offset = "0x6359AC0", VA = "0x18635ACC0")]
		public bool HEIHABBDIFJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x21C9A80", Offset = "0x21C8880", VA = "0x1821C9A80", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x635AE70", Offset = "0x6359C70", VA = "0x18635AE70", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x635ADE0", Offset = "0x6359BE0", VA = "0x18635ADE0")]
		public bool NOHLHLNDIHM(in Guid FBKLHONPMNF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x635AB30", Offset = "0x6359930", VA = "0x18635AB30", Slot = "7")]
		public bool Equals(SerializedGuid KICLNADFIEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x635ABE0", Offset = "0x63599E0", VA = "0x18635ABE0", Slot = "0")]
		public override bool Equals(object GKCPJCKCENH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x21C99D0", Offset = "0x21C87D0", VA = "0x1821C99D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x21C9810", Offset = "0x21C8610", VA = "0x1821C9810", Slot = "6")]
		public int CompareTo(SerializedGuid KICLNADFIEK)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class ODDCEFEONEM : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public readonly Type HHJGDOONOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public readonly string DOLPENJBBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public readonly bool LLNLMOIDPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public readonly bool PFDMPOHDLOO;

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6359290", Offset = "0x6358090", VA = "0x186359290")]
	public ODDCEFEONEM(Type NPNDEAKJHMK, string GLBBOBHIGEF, bool LJBNACDNBAJ = false, bool CLPKENBFNFL = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public interface HOGBHLHLJNA
{
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface PGHPDFIAEFD<T> : HOGBHLHLJNA
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	T FBCEGMCNEND
	{
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool NFGCGLFPAIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	string NHNFMLEJKLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(Slot = "10")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	global::PGHPDFIAEFD<T> JKOEAMKPNHD(Action<T> DAHHKFPCOGH);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::PGHPDFIAEFD<T> BNKDNJFAEOF(Action<T> DAHHKFPCOGH);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "2")]
	global::PGHPDFIAEFD<T> FKGHCFALPBL(Action<T, T> JDNJBDBBLKJ);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "3")]
	global::PGHPDFIAEFD<T> IKCMDECLNGE(Action<T, T> JDNJBDBBLKJ);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "4")]
	global::PGHPDFIAEFD<T> MFFGPCKMDPP(Action<string> BOHIKNFJOLB);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	global::PGHPDFIAEFD<T> MBFCNOOKPNF(Action<string> BOHIKNFJOLB);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class GDDIJDJHJBL<T> : global::PGHPDFIAEFD<T>, HOGBHLHLJNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private global::BKNNAJHBPLG<T, T> KOCFHIDFLGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private global::PBGGDBDIKGA<T> DBAPMBGEHOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private global::PBGGDBDIKGA<string> BFCDNGBHMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private string HMOPFJALLDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private T MMPEAFKIOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool BJLEDANDLNH;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public T FBCEGMCNEND
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x7385B0", Offset = "0x7373B0", VA = "0x1807385B0", Slot = "10")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x2CCDA60", Offset = "0x2CCC860", VA = "0x182CCDA60", Slot = "11")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool NFGCGLFPAIC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x836410", Offset = "0x835210", VA = "0x180836410", Slot = "12")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public string NHNFMLEJKLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x6B2550", Offset = "0x6B1350", VA = "0x1806B2550", Slot = "13")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x37BCF10", Offset = "0x37BBD10", VA = "0x1837BCF10", Slot = "14")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x45EE240", Offset = "0x45ED040", VA = "0x1845EE240")]
	private void OMLKCIMPBMO(T BNKBFACGLIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x45EE2E0", Offset = "0x45ED0E0", VA = "0x1845EE2E0")]
	private void PHEMCMCOJAD(string LMLMHJKGDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x45EDFF0", Offset = "0x45ECDF0", VA = "0x1845EDFF0")]
	public void IOEAEKKNKLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x45EDF50", Offset = "0x45ECD50", VA = "0x1845EDF50", Slot = "6")]
	public global::PGHPDFIAEFD<T> FKGHCFALPBL(Action<T, T> JDNJBDBBLKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x45EDFA0", Offset = "0x45ECDA0", VA = "0x1845EDFA0", Slot = "7")]
	public global::PGHPDFIAEFD<T> IKCMDECLNGE(Action<T, T> JDNJBDBBLKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x45EE0A0", Offset = "0x45ECEA0", VA = "0x1845EE0A0", Slot = "4")]
	public global::PGHPDFIAEFD<T> JKOEAMKPNHD(Action<T> JDNJBDBBLKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x45EDF00", Offset = "0x45ECD00", VA = "0x1845EDF00", Slot = "5")]
	public global::PGHPDFIAEFD<T> BNKDNJFAEOF(Action<T> DAHHKFPCOGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x45EE1A0", Offset = "0x45ECFA0", VA = "0x1845EE1A0", Slot = "8")]
	public global::PGHPDFIAEFD<T> MFFGPCKMDPP(Action<string> BOHIKNFJOLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x45EE130", Offset = "0x45ECF30", VA = "0x1845EE130", Slot = "9")]
	public global::PGHPDFIAEFD<T> MBFCNOOKPNF(Action<string> BOHIKNFJOLB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x45EE390", Offset = "0x45ED190", VA = "0x1845EE390")]
	public GDDIJDJHJBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class OLAAOKFENHK
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	[CompilerGenerated]
	private sealed class PHJJPNKMHFG<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public global::PGHPDFIAEFD<T> subscribableValue;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Action<T> subscription;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public global::OHLHHHNAFPB<T> promise;

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
		public PHJJPNKMHFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x465F630", Offset = "0x465E430", VA = "0x18465F630")]
		internal void <GetValue>b__0(T t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x33CD6D0", Offset = "0x33CC4D0", VA = "0x1833CD6D0")]
	public static global::MMBCCHGMCHN<T> NAGKGPCIBKK<T>(this global::PGHPDFIAEFD<T> JDDPOOGGDFP, Action<T> KDDLOKAHKOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class FCHNJJOGFOB<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public readonly struct OAHJLKFBMHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public readonly long JKHPMALILOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public readonly long OBCLDHBFDEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public readonly int HJLGLIAOLCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public readonly int FNJLGCBIPBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public readonly bool DDBCKIBFNJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly string BBOEMCCPBPO;

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3BC4730", Offset = "0x3BC3530", VA = "0x183BC4730")]
		public OAHJLKFBMHH(long JKHPMALILOJ, int HJLGLIAOLCD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x3BC47A0", Offset = "0x3BC35A0", VA = "0x183BC47A0")]
		public OAHJLKFBMHH(long JKHPMALILOJ, long OBCLDHBFDEN, int HJLGLIAOLCD, int FNJLGCBIPBP, bool DDBCKIBFNJI, string BBOEMCCPBPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x3BC46C0", Offset = "0x3BC34C0", VA = "0x183BC46C0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("DEBUG_BUILD")]
		private void PNBPNOBIFHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x3BC45E0", Offset = "0x3BC33E0", VA = "0x183BC45E0")]
		public int LPOIABKHBBB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x3BC45C0", Offset = "0x3BC33C0", VA = "0x183BC45C0")]
		public int JBDELJPCCAN(int LOGFDHKJFAO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x3BC4550", Offset = "0x3BC3350", VA = "0x183BC4550")]
		public double FDKOCGHOFOE()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x3BC4630", Offset = "0x3BC3430", VA = "0x183BC4630")]
		public OAHJLKFBMHH MALNKALCFFP(long OBCLDHBFDEN, int FNJLGCBIPBP)
		{
			return default(OAHJLKFBMHH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public class NILMFDECOMH : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public readonly TKey GDJDAALKGJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly global::FCHNJJOGFOB<TKey> JBAEFOFJALC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private List<NILMFDECOMH> FHFABDLCEOB;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public string FPPKMBCPJKB
		{
			[Cpp2IlInjected.Token(Token = "0x600020A")]
			[Cpp2IlInjected.Address(RVA = "0x37C6500", Offset = "0x37C5300", VA = "0x1837C6500")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x3AA34A0", Offset = "0x3AA22A0", VA = "0x183AA34A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public IEnumerable<NILMFDECOMH> OAIKOAKHGFO
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x42A8E00", Offset = "0x42A7C00", VA = "0x1842A8E00")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public OAHJLKFBMHH GOGNAMDCKKO
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0xE331D0", Offset = "0xE31FD0", VA = "0x180E331D0")]
			[CompilerGenerated]
			get
			{
				return default(OAHJLKFBMHH);
			}
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x42A8B40", Offset = "0x42A7940", VA = "0x1842A8B40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x42A8F30", Offset = "0x42A7D30", VA = "0x1842A8F30")]
		internal NILMFDECOMH(global::FCHNJJOGFOB<TKey> JBAEFOFJALC, TKey PIIJMEAKDGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x42A8E20", Offset = "0x42A7C20", VA = "0x1842A8E20")]
		public NILMFDECOMH MNAIBJMIJAB(TKey PIIJMEAKDGO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x42A8B70", Offset = "0x42A7970", VA = "0x1842A8B70")]
		public void DKKKOACNPHJ(TKey PIIJMEAKDGO, Action<NILMFDECOMH> KNOLDLABLMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x3C8FA00", Offset = "0x3C8E800", VA = "0x183C8FA00")]
		public T DKKKOACNPHJ<T>(TKey PIIJMEAKDGO, Func<NILMFDECOMH, T> PNCAEBHDNMM)
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x3C8FB50", Offset = "0x3C8E950", VA = "0x183C8FB50")]
		[AsyncStateMachine(typeof(CLFOMKCHEJI))]
		public Task<T> OMHMKEMHOPP<T>(TKey PIIJMEAKDGO, Func<NILMFDECOMH, Task<T>> PNCAEBHDNMM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x42A8C50", Offset = "0x42A7A50", VA = "0x1842A8C50", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	[CompilerGenerated]
	private sealed class LCJOPLAOBKN : IEnumerable<(TKey, List<TKey>, OAHJLKFBMHH)>, IEnumerable, IEnumerator<(TKey, List<TKey>, OAHJLKFBMHH)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		private (TKey key, List<TKey> path, OAHJLKFBMHH timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public global::FCHNJJOGFOB<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private IEnumerator<(TKey key, List<TKey> path, OAHJLKFBMHH timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		private (TKey, List<TKey>, OAHJLKFBMHH) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x2E704B0", Offset = "0x2E6F2B0", VA = "0x182E704B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, OAHJLKFBMHH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x2E70550", Offset = "0x2E6F350", VA = "0x182E70550", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x2E70600", Offset = "0x2E6F400", VA = "0x182E70600")]
		[DebuggerHidden]
		public LCJOPLAOBKN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x2E6E610", Offset = "0x2E6D410", VA = "0x182E6E610", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x2E70140", Offset = "0x2E6EF40", VA = "0x182E70140", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x2E705B0", Offset = "0x2E6F3B0", VA = "0x182E705B0")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x2E70510", Offset = "0x2E6F310", VA = "0x182E70510", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x2E703F0", Offset = "0x2E6F1F0", VA = "0x182E703F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, OAHJLKFBMHH)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x2E704E0", Offset = "0x2E6F2E0", VA = "0x182E704E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class JOBGHIBGCJP : IEnumerable<(TKey, List<TKey>, OAHJLKFBMHH)>, IEnumerable, IEnumerator<(TKey, List<TKey>, OAHJLKFBMHH)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private (TKey key, List<TKey> path, OAHJLKFBMHH timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private NILMFDECOMH timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public NILMFDECOMH <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public global::FCHNJJOGFOB<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private IEnumerator<NILMFDECOMH> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private IEnumerator<(TKey key, List<TKey> path, OAHJLKFBMHH timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		private (TKey, List<TKey>, OAHJLKFBMHH) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x2E704B0", Offset = "0x2E6F2B0", VA = "0x182E704B0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, OAHJLKFBMHH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000227")]
			[Cpp2IlInjected.Address(RVA = "0x45A2550", Offset = "0x45A1350", VA = "0x1845A2550", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x2E70600", Offset = "0x2E6F400", VA = "0x182E70600")]
		[DebuggerHidden]
		public JOBGHIBGCJP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x45A25B0", Offset = "0x45A13B0", VA = "0x1845A25B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x45A1E60", Offset = "0x45A0C60", VA = "0x1845A1E60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x45A2650", Offset = "0x45A1450", VA = "0x1845A2650")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x45A26B0", Offset = "0x45A14B0", VA = "0x1845A26B0")]
		private void <>m__Finally2()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x45A2510", Offset = "0x45A1310", VA = "0x1845A2510", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x45A2400", Offset = "0x45A1200", VA = "0x1845A2400", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, OAHJLKFBMHH)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x45A24E0", Offset = "0x45A12E0", VA = "0x1845A24E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly Action<TKey, OAHJLKFBMHH> LHCKHMBNGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly Action<TKey, OAHJLKFBMHH> CBGIEHLIBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private readonly Action<global::FCHNJJOGFOB<TKey>> OAAKEMBCDNK;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private const string OGMOKKOIIKO = "Stack Timer";

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private readonly NILMFDECOMH ELKHDHJOJEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private bool JKEEGJNIPNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private int AFNNCILCJJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly Stopwatch DELOHPFEPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public readonly int NNJIKPHMBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private string AEHEKHOCHCD;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public NILMFDECOMH HFLFMGIJCNL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6B2550", Offset = "0x6B1350", VA = "0x1806B2550")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	[NotNull]
	public string FPPKMBCPJKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x6BE4D0", Offset = "0x6BD2D0", VA = "0x1806BE4D0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x37CA450", Offset = "0x37C9250", VA = "0x1837CA450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public long FIHOJLMBNCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x37CA4B0", Offset = "0x37C92B0", VA = "0x1837CA4B0")]
		get
		{
			return default(long);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public int OPLODEDHKJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x37CA370", Offset = "0x37C9170", VA = "0x1837CA370")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x37CA650", Offset = "0x37C9450", VA = "0x1837CA650")]
	public FCHNJJOGFOB(TKey FBJNOJLLOAM, [Optional] int? HJLGLIAOLCD, [Optional][CanBeNull] Stopwatch DELOHPFEPEL, [Optional] Action<TKey, OAHJLKFBMHH> LHCKHMBNGLA, [Optional] Action<TKey, OAHJLKFBMHH> CBGIEHLIBIH, [Optional] Action<global::FCHNJJOGFOB<TKey>> OAAKEMBCDNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x37CA3C0", Offset = "0x37C91C0", VA = "0x1837CA3C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x37CA3A0", Offset = "0x37C91A0", VA = "0x1837CA3A0")]
	public void CCLKNNLCIIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x37CA630", Offset = "0x37C9430", VA = "0x1837CA630")]
	public void PLNENDECPJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x37CA5A0", Offset = "0x37C93A0", VA = "0x1837CA5A0")]
	[IteratorStateMachine(typeof(global::FCHNJJOGFOB<>.LCJOPLAOBKN))]
	public IEnumerable<(TKey, List<TKey>, OAHJLKFBMHH)> NGBHIEPIOIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x37CA4D0", Offset = "0x37C92D0", VA = "0x1837CA4D0")]
	[IteratorStateMachine(typeof(global::FCHNJJOGFOB<>.JOBGHIBGCJP))]
	private IEnumerable<(TKey, List<TKey>, OAHJLKFBMHH)> NGBHIEPIOIG(List<TKey> JLGENJBOGCK, NILMFDECOMH KGNPFBLGGBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x37CA2F0", Offset = "0x37C90F0", VA = "0x1837CA2F0")]
	private (long, int) AAIHEFNLGCL()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class JJMCEGKGEMO<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut KMNMBNKNJGH(global::FCHNJJOGFOB<TKey> JBAEFOFJALC);

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
	protected JJMCEGKGEMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public abstract class ONONEANNOGA<TKey> : global::JJMCEGKGEMO<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate string JCJDGKCGEKD(TKey PIIJMEAKDGO);

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x39D8760", Offset = "0x39D7560", VA = "0x1839D8760")]
	protected string GJNKBOOOFDE(double GGOHKCCMMFE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x39D8700", Offset = "0x39D7500", VA = "0x1839D8700")]
	protected string DECLIGLOEOL(int IDLFMEJFHBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x39D87D0", Offset = "0x39D75D0", VA = "0x1839D87D0")]
	private static string IHBGCFDOLPD(TKey PIIJMEAKDGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x39D8810", Offset = "0x39D7610", VA = "0x1839D8810", Slot = "4")]
	public override string KMNMBNKNJGH(global::FCHNJJOGFOB<TKey> JBAEFOFJALC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x39D88C0", Offset = "0x39D76C0", VA = "0x1839D88C0")]
	public string KMNMBNKNJGH(global::FCHNJJOGFOB<TKey> JBAEFOFJALC, [NotNull] JCJDGKCGEKD HBHOACACMCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string PCBGBBCIPME(global::FCHNJJOGFOB<TKey> JBAEFOFJALC, [NotNull] JCJDGKCGEKD HBHOACACMCM);

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x38FD520", Offset = "0x38FC320", VA = "0x1838FD520")]
	protected ONONEANNOGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class EEDDICAIGCD<TKey> : global::JJMCEGKGEMO<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public delegate string DAFNICDKJJK(TKey PIIJMEAKDGO);

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private const int PPBHFGJDILL = 5;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly string PAAJCMMHJBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private readonly double KIHKCJEJDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private readonly bool KLOIAEDCBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private readonly int CFAJLMPOEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private readonly ISet<string> FAEHEOAIGMC;

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x3D803D0", Offset = "0x3D7F1D0", VA = "0x183D803D0")]
	private static string IHBGCFDOLPD(TKey PIIJMEAKDGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x3D80BB0", Offset = "0x3D7F9B0", VA = "0x183D80BB0")]
	public EEDDICAIGCD(string PAAJCMMHJBH = "F2", double KIHKCJEJDDG = double.MaxValue, bool KLOIAEDCBLK = false, int CFAJLMPOEAK = int.MaxValue, [Optional] ISet<string> FAEHEOAIGMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x3D80950", Offset = "0x3D7F750", VA = "0x183D80950", Slot = "4")]
	public override Dictionary<string, string> KMNMBNKNJGH(global::FCHNJJOGFOB<TKey> JBAEFOFJALC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x3D80170", Offset = "0x3D7EF70", VA = "0x183D80170")]
	private bool EBHPINLDHJH(string HKEFJKDOJEG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x3D80410", Offset = "0x3D7F210", VA = "0x183D80410")]
	public Dictionary<string, string> KMNMBNKNJGH(global::FCHNJJOGFOB<TKey> JBAEFOFJALC, DAFNICDKJJK HBHOACACMCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x3D80A00", Offset = "0x3D7F800", VA = "0x183D80A00")]
	private string ONKPNAEBLHN(StringBuilder KJMJBGBGDGP, List<TKey> MFHECOKLKDI, DAFNICDKJJK HBHOACACMCM, bool BBPNMPIGEDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x3D80250", Offset = "0x3D7F050", VA = "0x183D80250")]
	private static void HEMKNFGAKLO(StringBuilder HNJGCECEMOO, string LPMFMPJNAOH, bool OFPMIGLEBKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class PJAFCOFDDKI<TKey> : global::ONONEANNOGA<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	[CompilerGenerated]
	private struct KADOJOAFMKO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public JCJDGKCGEKD keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public static global::PJAFCOFDDKI<TKey> JKCIDAEDHPJ;

	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private const int EABOGNFEPMK = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private readonly string[] MBMPIKNJCGB;

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x4660A60", Offset = "0x465F860", VA = "0x184660A60")]
	private PJAFCOFDDKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x465FA70", Offset = "0x465E870", VA = "0x18465FA70", Slot = "5")]
	protected override string PCBGBBCIPME(global::FCHNJJOGFOB<TKey> JBAEFOFJALC, JCJDGKCGEKD HBHOACACMCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x465F980", Offset = "0x465E780", VA = "0x18465F980")]
	[CompilerGenerated]
	internal static string INKDGHJLAJO(string MMILAMMAGCG, TKey PIIJMEAKDGO, ref KADOJOAFMKO P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class FPHEGEFOOKF<TKey> : global::ONONEANNOGA<TKey>
{
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class AGAGGNLHMHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public JCJDGKCGEKD keyToStringFunc;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public Func<TKey, string> <>9__0;

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
		public AGAGGNLHMHO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x3B1A2C0", Offset = "0x3B190C0", VA = "0x183B1A2C0")]
		internal string <FormatInternal>b__0(TKey p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x4340C90", Offset = "0x433FA90", VA = "0x184340C90", Slot = "5")]
	protected override string PCBGBBCIPME(global::FCHNJJOGFOB<TKey> JBAEFOFJALC, JCJDGKCGEKD HBHOACACMCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x42A92B0", Offset = "0x42A80B0", VA = "0x1842A92B0")]
	public FPHEGEFOOKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public sealed class GGEGOGGLJPL : global::FCHNJJOGFOB<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	[CompilerGenerated]
	private sealed class AOLIMAGGEND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public Action<GGEGOGGLJPL> callback;

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public AOLIMAGGEND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x6351AB0", Offset = "0x63508B0", VA = "0x186351AB0")]
		internal void <Wrap>b__0(global::FCHNJJOGFOB<string> t)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x6355550", Offset = "0x6354350", VA = "0x186355550")]
	public GGEGOGGLJPL([Optional] string PAOCLLJLEBE, [Optional] int? HJLGLIAOLCD, [Optional] Stopwatch DELOHPFEPEL, [Optional] Action<string, OAHJLKFBMHH> LHCKHMBNGLA, [Optional] Action<string, OAHJLKFBMHH> CBGIEHLIBIH, [Optional] Action<GGEGOGGLJPL> OAAKEMBCDNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x6355470", Offset = "0x6354270", VA = "0x186355470")]
	private static Action<global::FCHNJJOGFOB<string>> DKKKOACNPHJ(Action<GGEGOGGLJPL> KDDLOKAHKOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public abstract class LOCLLINHKIG
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private class DIJMBPHLPNN : LOCLLINHKIG
	{
		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public static LOCLLINHKIG JKCIDAEDHPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x6354050", Offset = "0x6352E50", VA = "0x186354050")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public override DateTime KNMMFEGBJFK
		{
			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x63540C0", Offset = "0x6352EC0", VA = "0x1863540C0", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public override float HMPMJHLCGMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000255")]
			[Cpp2IlInjected.Address(RVA = "0x63540B0", Offset = "0x6352EB0", VA = "0x1863540B0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x63541B0", Offset = "0x6352FB0", VA = "0x1863541B0")]
		public DIJMBPHLPNN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static LOCLLINHKIG KOIJCEBCMHJ;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public static LOCLLINHKIG DCLACCPOJAP
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x63581C0", Offset = "0x6356FC0", VA = "0x1863581C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public abstract DateTime KNMMFEGBJFK
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public abstract float HMPMJHLCGMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	protected LOCLLINHKIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class GLBABLCMFCO : global::PIGMLBGGPIP<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(RVA = "0x6356970", Offset = "0x6355770", VA = "0x186356970")]
	public GLBABLCMFCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class PIGMLBGGPIP<T> : global::DMMEEHPGKIP<T>, FECLEKCPFKC, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public Task<T> CLLIFJEHONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	private Task PJLPMOENIBH
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x299DE60", Offset = "0x299CC60", VA = "0x18299DE60", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public global::MMBCCHGMCHN<T> DCCGELIINBE
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	private CCBLCAIHLNA FGFGGHKHEGO
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x366D1C0", Offset = "0x366BFC0", VA = "0x18366D1C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x465F890", Offset = "0x465E690", VA = "0x18465F890")]
	public PIGMLBGGPIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class FFINHHKKNAK : global::OHOFINJIFJG<UnityEngine.Object>
{
	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x6354390", Offset = "0x6353190", VA = "0x186354390")]
	public FFINHHKKNAK(Exception PBDFKDHMIEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class OHOFINJIFJG<T> : global::DMMEEHPGKIP<T>, FECLEKCPFKC, IDisposable where T : UnityEngine.Object
{
	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Task<T> CLLIFJEHONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	private Task PJLPMOENIBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x299DE60", Offset = "0x299CC60", VA = "0x18299DE60", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public global::MMBCCHGMCHN<T> DCCGELIINBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	private CCBLCAIHLNA FGFGGHKHEGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x366D1C0", Offset = "0x366BFC0", VA = "0x18366D1C0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x39C2FD0", Offset = "0x39C1DD0", VA = "0x1839C2FD0")]
	public OHOFINJIFJG(Exception PBDFKDHMIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "8")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public interface FECLEKCPFKC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000069")]
	[NotNull]
	Task CLLIFJEHONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	[NotNull]
	CCBLCAIHLNA DCCGELIINBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public interface DMMEEHPGKIP<T> : FECLEKCPFKC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	[NotNull]
	new Task<T> CLLIFJEHONI
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	[NotNull]
	new global::MMBCCHGMCHN<T> DCCGELIINBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public abstract class IAIFCELGNOK<TTask, T> : global::DMMEEHPGKIP<T>, FECLEKCPFKC, IDisposable where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	[CompilerGenerated]
	private sealed class NBEDIHCOIDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public global::IAIFCELGNOK<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
		public NBEDIHCOIDO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static bool DFBJBIDNPAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly Task<T> KLOLOJBLOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	protected readonly CancellationTokenSource ANGOLJLDKHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private bool JKEEGJNIPNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private SynchronizationContext DFHBOECJICB;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Task<T> CLLIFJEHONI
	{
		[Cpp2IlInjected.Token(Token = "0x600026B")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private Task PJLPMOENIBH
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public global::MMBCCHGMCHN<T> DCCGELIINBE
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	private CCBLCAIHLNA FGFGGHKHEGO
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x3853740", Offset = "0x3852540", VA = "0x183853740", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public bool NMMHNMGCMPC
	{
		[Cpp2IlInjected.Token(Token = "0x600026F")]
		[Cpp2IlInjected.Address(RVA = "0x77CC90", Offset = "0x77BA90", VA = "0x18077CC90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x50511A0", Offset = "0x504FFA0", VA = "0x1850511A0")]
	static IAIFCELGNOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x5051650", Offset = "0x5050450", VA = "0x185051650")]
	protected IAIFCELGNOK(TTask KLOLOJBLOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x5050E00", Offset = "0x504FC00", VA = "0x185050E00", Slot = "1")]
	~IAIFCELGNOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x5050DD0", Offset = "0x504FBD0", VA = "0x185050DD0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x5050FE0", Offset = "0x504FDE0", VA = "0x185050FE0")]
	private void KKDFCIPLDMN(bool CAEBOCAEOBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(Slot = "9")]
	protected abstract T BELANHOLBFL(TTask OBEFKKHJPMC);

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void GBLDEPLKPKI();

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x5051150", Offset = "0x504FF50", VA = "0x185051150")]
	[CompilerGenerated]
	private void MBAKOALBABH(object ONHHPHCFHJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public interface PENMGOCJCDO
{
	[Cpp2IlInjected.Token(Token = "0x17000072")]
	float COODNALAPFD
	{
		[Cpp2IlInjected.Token(Token = "0x600027E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event OHKJNKGALFA NHGEKJNIPNN;
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class CGCFOACLBLD : PENMGOCJCDO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public readonly struct JABJJGLEFCF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public readonly float DBEFHDBAOPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public readonly float CGABGKILPAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		internal readonly bool DOFAOAHKOHP;

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public float FGDMPDNAJLP
		{
			[Cpp2IlInjected.Token(Token = "0x600028B")]
			[Cpp2IlInjected.Address(RVA = "0x63576D0", Offset = "0x63564D0", VA = "0x1863576D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600028C")]
		[Cpp2IlInjected.Address(RVA = "0x6357860", Offset = "0x6356660", VA = "0x186357860")]
		public JABJJGLEFCF(float FHGIIAKFJFF, float APIEJLBIMAO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x63576E0", Offset = "0x63564E0", VA = "0x1863576E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class NGLBIACONEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public CGCFOACLBLD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public int newProgressableIndex;

		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public NGLBIACONEA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private readonly int CIMAPKKBLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private int LCKOCMIMECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private readonly PENMGOCJCDO[] EONMCGJCGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private readonly OHKJNKGALFA[] ACNDHAIKGGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly JABJJGLEFCF[] MCADCBFIFIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private JABJJGLEFCF GJMKOAKDMGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private readonly ACHCIGHCIHA LKDMIMKKLJL;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public JABJJGLEFCF KGMPILMHHDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x17B2BD0", Offset = "0x17B19D0", VA = "0x1817B2BD0")]
		get
		{
			return default(JABJJGLEFCF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public float COODNALAPFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x6353640", Offset = "0x6352440", VA = "0x186353640", Slot = "4")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	public event OHKJNKGALFA NHGEKJNIPNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x6353660", Offset = "0x6352460", VA = "0x186353660", Slot = "5")]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x6353350", Offset = "0x6352150", VA = "0x186353350", Slot = "6")]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x6353C00", Offset = "0x6352A00", VA = "0x186353C00")]
	public CGCFOACLBLD(int CIMAPKKBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x6353720", Offset = "0x6352520", VA = "0x186353720")]
	public ACHCIGHCIHA KIDBPNNEIAN(JABJJGLEFCF CFMHDCICDHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x63537B0", Offset = "0x63525B0", VA = "0x1863537B0")]
	public void PBJEFMOADMD(PENMGOCJCDO GJALBPMAPLM, [Optional] JABJJGLEFCF GLDANKGCKIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x63535F0", Offset = "0x63523F0", VA = "0x1863535F0")]
	internal int FIGLOCELEJH(PENMGOCJCDO HEPDJBBCBIC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x6353410", Offset = "0x6352210", VA = "0x186353410")]
	internal JABJJGLEFCF CNBJGPONNED(int NPDGHPHAKDK)
	{
		return default(JABJJGLEFCF);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x6353460", Offset = "0x6352260", VA = "0x186353460", Slot = "7")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public delegate void OHKJNKGALFA(float JLBGCGDHKHO);
[Cpp2IlInjected.Token(Token = "0x200007A")]
internal static class KILDIHIIIBD
{
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	internal const float LKLFKLHBBNP = 0.0001f;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public static class GJCDFKNIAKG
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private class GKNJEFJOMPB : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private readonly PENMGOCJCDO HEPDJBBCBIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		private readonly OHKJNKGALFA KDDLOKAHKOL;

		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x63568E0", Offset = "0x63556E0", VA = "0x1863568E0")]
		public GKNJEFJOMPB(PENMGOCJCDO HEPDJBBCBIC, OHKJNKGALFA KDDLOKAHKOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000298")]
		[Cpp2IlInjected.Address(RVA = "0x6356890", Offset = "0x6355690", VA = "0x186356890", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x6355740", Offset = "0x6354540", VA = "0x186355740")]
	internal static bool CDCCPDCAGKN(float NCNGLFNLPAG, float OPGAGDBKIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x4F18B50", Offset = "0x4F17950", VA = "0x184F18B50")]
	internal static float HKBKMOHPIKP(float NCNGLFNLPAG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x63557C0", Offset = "0x63545C0", VA = "0x1863557C0")]
	public static IDisposable OCDFIPCFIAJ(this PENMGOCJCDO HEPDJBBCBIC, OHKJNKGALFA KDDLOKAHKOL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
public class ACHCIGHCIHA : PENMGOCJCDO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private float JLBGCGDHKHO;

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public float COODNALAPFD
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x791280", Offset = "0x790080", VA = "0x180791280", Slot = "4")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x63519F0", Offset = "0x63507F0", VA = "0x1863519F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	public event OHKJNKGALFA NHGEKJNIPNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x6351950", Offset = "0x6350750", VA = "0x186351950", Slot = "5")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x63518B0", Offset = "0x63506B0", VA = "0x1863518B0", Slot = "6")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public ACHCIGHCIHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class BBNNHBKDNGB
{
	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(RVA = "0x6351ED0", Offset = "0x6350CD0", VA = "0x186351ED0")]
	[NotNull]
	public static byte[] FMMEPLKDBND(this CHMJLDKJAME CMHDAGCJLBD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(RVA = "0x6351F40", Offset = "0x6350D40", VA = "0x186351F40")]
	[NotNull]
	public static byte[] FMMEPLKDBND(this CHMJLDKJAME CMHDAGCJLBD, HashAlgorithmName MEPKCHCGNEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x6351D40", Offset = "0x6350B40", VA = "0x186351D40")]
	public static bool CENICFKKIKC([CanBeNull] this CHMJLDKJAME CMHDAGCJLBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x6351BA0", Offset = "0x63509A0", VA = "0x186351BA0")]
	public static bool CENICFKKIKC([CanBeNull] this CHMJLDKJAME CMHDAGCJLBD, out string HMOPFJALLDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x63520D0", Offset = "0x6350ED0", VA = "0x1863520D0")]
	private static string LNKJFELGOIH([CanBeNull] byte[] CCFMJPPGPDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x6351FB0", Offset = "0x6350DB0", VA = "0x186351FB0")]
	private static bool HLGLCBODIKI([NotNull] CHMJLDKJAME CMHDAGCJLBD, [CanBeNull] out byte[] GLFPGLGEHLE, [CanBeNull] out byte[] ANIAICAKNMP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public static class MIOAEMCNGHE
{
	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x6358430", Offset = "0x6357230", VA = "0x186358430")]
	[NotNull]
	public static byte[] FMMEPLKDBND(this LHNLMNFPGGD KOCGBDMJFKC, byte[] FBJMMPJHNIO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x6358470", Offset = "0x6357270", VA = "0x186358470")]
	[NotNull]
	public static byte[] FMMEPLKDBND(this LHNLMNFPGGD KOCGBDMJFKC, HashAlgorithmName MEPKCHCGNEL, byte[] FBJMMPJHNIO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public interface LHNLMNFPGGD
{
	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash NHBPPIHNEOH);
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public interface CHMJLDKJAME : LHNLMNFPGGD
{
	[Cpp2IlInjected.Token(Token = "0x17000077")]
	[CanBeNull]
	byte[] AMKDIDPJNNC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	[CanBeNull]
	byte[] NHCDGAFIMGH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	UnityEngine.Object MFEPGPDJHCA
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
public static class BMDEMKBLDFG
{
	[Cpp2IlInjected.Token(Token = "0x2000083")]
	private class MHGKFCOFKCG : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(RVA = "0x63583B0", Offset = "0x63571B0", VA = "0x1863583B0")]
		public MHGKFCOFKCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(RVA = "0x6358350", Offset = "0x6357150", VA = "0x186358350", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private const byte HLFHHOHLCCF = 1;

	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private const byte BEMIFNPKLHN = 0;

	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private static readonly ArrayPool<byte> FGONAFOACAH;

	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static bool GBLKDMDLBLD;

	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x3799340", Offset = "0x3798140", VA = "0x183799340")]
	[Conditional("UNITY_EDITOR")]
	private static void CDECIJIMMFC<T>(params T[] CNFKPPGBEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x63527A0", Offset = "0x63515A0", VA = "0x1863527A0")]
	public static IDisposable HAOHFFMMIMI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x6352A10", Offset = "0x6351810", VA = "0x186352A10")]
	public static void IIGCLLNNIAN(this IncrementalHash BJKHCFMFJAN, [CanBeNull] GameObject NCAOMIEGHPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x3799DB0", Offset = "0x3798BB0", VA = "0x183799DB0")]
	public static void IIGCLLNNIAN<T>(this IncrementalHash BJKHCFMFJAN, [CanBeNull] T KMJCJNGOPHM) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x3799D20", Offset = "0x3798B20", VA = "0x183799D20")]
	public static void GPEAPNFMFKE<T>(this IncrementalHash BJKHCFMFJAN, [CanBeNull] T KOCGBDMJFKC) where T : LHNLMNFPGGD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x3799E80", Offset = "0x3798C80", VA = "0x183799E80")]
	public static void LHAFEJLOAEL<T>(this IncrementalHash BJKHCFMFJAN, [CanBeNull] IList<T> IFHLBGACKDB) where T : LHNLMNFPGGD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x63521A0", Offset = "0x6350FA0", VA = "0x1863521A0")]
	private static bool CLNGNHODEPK([CanBeNull] LHNLMNFPGGD KOCGBDMJFKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x6352400", Offset = "0x6351200", VA = "0x186352400")]
	public static void FNLNNONBKMJ(this IncrementalHash NHBPPIHNEOH, [CanBeNull] string MOOPPHNCKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x6352840", Offset = "0x6351640", VA = "0x186352840")]
	public static void HJCLNJBCBCP(this IncrementalHash NHBPPIHNEOH, long CKBMFMBNAKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x6352F70", Offset = "0x6351D70", VA = "0x186352F70")]
	public static void PKBFANDHHBO(this IncrementalHash NHBPPIHNEOH, int FMHAGAADDNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x6352460", Offset = "0x6351260", VA = "0x186352460")]
	public static void FODBKCJHINP(this IncrementalHash NHBPPIHNEOH, short JFBMJEKHDOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x6352290", Offset = "0x6351090", VA = "0x186352290")]
	public static void EDAONCFGCJL(this IncrementalHash NHBPPIHNEOH, byte GBCILJKLDBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x6352D30", Offset = "0x6351B30", VA = "0x186352D30")]
	public static void OLMCAMNIMED(this IncrementalHash NHBPPIHNEOH, bool LMHFHBHPPJM, bool JHCPLIFNHEP = false, bool ADKKLJBEHGC = false, bool EBEGHPEHEAI = false, bool PEJLIPJNDHE = false, bool JIKJIFCGPCL = false, bool KHIMBDFDBCE = false, bool HPFOCOBAIBI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x3799630", Offset = "0x3798430", VA = "0x183799630")]
	public static void GBMDIEHNMGO<T>(this IncrementalHash NHBPPIHNEOH, T NPAJHANNMDG) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x6353140", Offset = "0x6351F40", VA = "0x186353140")]
	public static void PKHCELFEDMO(this IncrementalHash NHBPPIHNEOH, float ALHAPPCLDHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x6352140", Offset = "0x6350F40", VA = "0x186352140")]
	public static void AKNNNBFKJHC(this IncrementalHash NHBPPIHNEOH, double DILGBHEFMHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x6352F00", Offset = "0x6351D00", VA = "0x186352F00")]
	public static void PBAMFIFFDAH(this IncrementalHash NHBPPIHNEOH, ulong ECMEIGJCKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x6352230", Offset = "0x6351030", VA = "0x186352230")]
	public static void DKGENBFHAEJ(this IncrementalHash NHBPPIHNEOH, uint EKEABEOKBNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x6352B00", Offset = "0x6351900", VA = "0x186352B00")]
	public static void LAOBNJHNBGG(this IncrementalHash NHBPPIHNEOH, ushort IAJBDKHFPHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x6352630", Offset = "0x6351430", VA = "0x186352630")]
	public static void GJIBDNBNNPF(this IncrementalHash NHBPPIHNEOH, Vector3 PEKHGKEACMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x6352B70", Offset = "0x6351970", VA = "0x186352B70")]
	public static void MFMBIKGHMBH(this IncrementalHash NHBPPIHNEOH, Quaternion NJJOJLEDHDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public class GBFCMHPLPIJ : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public readonly Type HHJGDOONOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public readonly string DOLPENJBBFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public readonly bool LLNLMOIDPDH;

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(RVA = "0x6354F90", Offset = "0x6353D90", VA = "0x186354F90")]
	public GBFCMHPLPIJ(Type NPNDEAKJHMK, string GLBBOBHIGEF, bool LJBNACDNBAJ = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public class GKGLHMNCGEE : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(RVA = "0x6356820", Offset = "0x6355620", VA = "0x186356820")]
	public GKGLHMNCGEE(string LMLMHJKGDCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(RVA = "0x63567A0", Offset = "0x63555A0", VA = "0x1863567A0")]
	public GKGLHMNCGEE(string LMLMHJKGDCH, Exception ACPNJFGCPAG)
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000087")]
	public abstract class Array2D<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		[SerializeField]
		private uint width;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		[SerializeField]
		private uint height;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		private readonly uint size;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		[SerializeField]
		public T[] data;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public uint Width
		{
			[Cpp2IlInjected.Token(Token = "0x60002CA")]
			[Cpp2IlInjected.Address(RVA = "0x7332F0", Offset = "0x7320F0", VA = "0x1807332F0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public uint Height
		{
			[Cpp2IlInjected.Token(Token = "0x60002CB")]
			[Cpp2IlInjected.Address(RVA = "0x73A2B0", Offset = "0x7390B0", VA = "0x18073A2B0")]
			get
			{
				return default(uint);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public T this[int MNBBHFLLBID, int AKDMBOIHBGA]
		{
			[Cpp2IlInjected.Token(Token = "0x60002CD")]
			[Cpp2IlInjected.Address(RVA = "0x46D33F0", Offset = "0x46D21F0", VA = "0x1846D33F0")]
			get
			{
				return (T)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60002CE")]
			[Cpp2IlInjected.Address(RVA = "0x46D3490", Offset = "0x46D2290", VA = "0x1846D3490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x46D3360", Offset = "0x46D2160", VA = "0x1846D3360")]
		public Array2D(uint LBHCEBCJMEF, uint MMPBKAKMEAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x46D32E0", Offset = "0x46D20E0", VA = "0x1846D32E0")]
		public void EMOCNNJJBKM()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000088")]
	public class Array2DVector3 : Array2D<Vector3>
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0x6351B40", Offset = "0x6350940", VA = "0x186351B40")]
		public Array2DVector3(uint LBHCEBCJMEF, uint MMPBKAKMEAK)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public struct FIOHBCOBILP
{
	[Cpp2IlInjected.Token(Token = "0x200008A")]
	public delegate bool PCPCPIMEOFG(string IDFBCGLAFJI, FIOHBCOBILP CALNMCFMNMH);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public int NPAJHANNMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public string GPNPAEMAEFL;

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x6354590", Offset = "0x6353390", VA = "0x186354590")]
	public static Dictionary<string, FIOHBCOBILP> NBAGPEEBOJH(Type MJEIMDLKOAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x6354880", Offset = "0x6353680", VA = "0x186354880")]
	public static Dictionary<string, FIOHBCOBILP> NBKBJDLGAFK(Type MJEIMDLKOAI, PCPCPIMEOFG OPABAOKCFIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x63543E0", Offset = "0x63531E0", VA = "0x1863543E0")]
	public static Dictionary<int, string> MOLJPHOLIIG(Dictionary<string, FIOHBCOBILP> JFBGEPNCFEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
internal static class HIAFHCILFML
{
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public const int JGPBOJFCMCN = -1;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public const int FJPABEMJFBF = 0;
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[DefaultMember("Item")]
public class JAGKIEIPGFG<THandle, TValue> : IDisposable where THandle : struct, BCAIPGNNKGO where TValue : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private readonly List<THandle> ANAONBGCBEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private readonly List<TValue> GPJMEADJCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private readonly Func<TValue> IKIIBNGNLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private readonly Action<TValue> ONMMKJGOBJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private int CBAOIFGGBHE;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public TValue PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x40E5EB0", Offset = "0x40E4CB0", VA = "0x1840E5EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x40E68A0", Offset = "0x40E56A0", VA = "0x1840E68A0")]
	public JAGKIEIPGFG(Action<TValue> ONMMKJGOBJI, [Optional] Func<TValue> IKIIBNGNLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x40E5EE0", Offset = "0x40E4CE0", VA = "0x1840E5EE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x40E6290", Offset = "0x40E5090", VA = "0x1840E6290")]
	public THandle HJNGNBALKKN()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x40E6470", Offset = "0x40E5270", VA = "0x1840E6470")]
	public THandle HMNAIPBHJIK(TValue DFEOJBAFBHE)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(RVA = "0x40E6040", Offset = "0x40E4E40", VA = "0x1840E6040")]
	public bool FAHLDBEBGON(THandle DCLMHANFEGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(RVA = "0x40E64F0", Offset = "0x40E52F0", VA = "0x1840E64F0")]
	public bool KGNKLNCMPDI(THandle DCLMHANFEGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(RVA = "0x40E6760", Offset = "0x40E5560", VA = "0x1840E6760")]
	public bool MDMOKHFDALA(THandle DCLMHANFEGK, out TValue DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x40E5E60", Offset = "0x40E4C60", VA = "0x1840E5E60")]
	public TValue CIGAFCHFFML(THandle DCLMHANFEGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x40E6670", Offset = "0x40E5470", VA = "0x1840E6670")]
	public bool LCJCOLBECPG(THandle DCLMHANFEGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x40E6870", Offset = "0x40E5670", VA = "0x1840E6870")]
	private THandle POEHCFIKMHG(int NPDGHPHAKDK)
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x40E6800", Offset = "0x40E5600", VA = "0x1840E6800")]
	private TValue NAGKGPCIBKK(int NPDGHPHAKDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x40E6720", Offset = "0x40E5520", VA = "0x1840E6720")]
	private void LOFOALDBIBB(int NPDGHPHAKDK, in THandle DCLMHANFEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x40E6830", Offset = "0x40E5630", VA = "0x1840E6830")]
	private void OMLKCIMPBMO(int NPDGHPHAKDK, in TValue DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x40E5CF0", Offset = "0x40E4AF0", VA = "0x1840E5CF0")]
	private THandle ADLGJPHOFCG()
	{
		return (THandle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x40E65C0", Offset = "0x40E53C0", VA = "0x1840E65C0")]
	private void LAMBGBGGJEB(THandle DCLMHANFEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x40E6030", Offset = "0x40E4E30", VA = "0x1840E6030")]
	private int EOPJBIGFFMC(int IIJDDKBOPLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x40E64E0", Offset = "0x40E52E0", VA = "0x1840E64E0")]
	private bool JEPJKHOAEGJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x73C470", Offset = "0x73B270", VA = "0x18073C470")]
	private void DACKAOJJPJF(THandle DCLMHANFEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x40E6210", Offset = "0x40E5010", VA = "0x1840E6210")]
	private bool FIEEBHMACFK(out THandle DCLMHANFEGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x40E5F60", Offset = "0x40E4D60", VA = "0x1840E5F60")]
	private bool ENFKINLJGFP(out THandle DCLMHANFEGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x40E5E00", Offset = "0x40E4C00", VA = "0x1840E5E00")]
	private void CAPKJFFCDII(THandle DCLMHANFEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x40E60F0", Offset = "0x40E4EF0", VA = "0x1840E60F0")]
	private void FDOKKKKGMAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public interface BCAIPGNNKGO
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	int EBAKNIMBLHM
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	int DKBOPEOPEBA
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public interface GAMKFLDBKPP<T> : BCAIPGNNKGO, IEquatable<T>
{
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class CPPKBBJGNAO
{
	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x1DD5360", Offset = "0x1DD4160", VA = "0x181DD5360")]
	public static bool JLLIFBNBAKK<T>(this T DCLMHANFEGK, T KICLNADFIEK) where T : struct, BCAIPGNNKGO
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x3984CC0", Offset = "0x3983AC0", VA = "0x183984CC0")]
	public static bool DOFAOAHKOHP<T>(this T DCLMHANFEGK) where T : struct, BCAIPGNNKGO
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x6353E30", Offset = "0x6352C30", VA = "0x186353E30")]
	public static string LNHCBGDCJLG(this BCAIPGNNKGO DCLMHANFEGK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public class GJJNDNKNJJM
{
	[Cpp2IlInjected.Token(Token = "0x2000092")]
	private enum HIOHMNDHFJF : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		Empty,
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		Building,
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		Finalized
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private int NHBPPIHNEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private bool MJIOMEDLNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private HIOHMNDHFJF IDIIBDOHICE;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public bool BCIDCKMIEOC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x63558F0", Offset = "0x63546F0", VA = "0x1863558F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public bool DPPKLEOANBO
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x6355DE0", Offset = "0x6354BE0", VA = "0x186355DE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x6356770", Offset = "0x6355570", VA = "0x186356770")]
	public GJJNDNKNJJM(bool MJIOMEDLNCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x6355DF0", Offset = "0x6354BF0", VA = "0x186355DF0")]
	public void LKLLINMODCO(object GKCPJCKCENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x6356520", Offset = "0x6355320", VA = "0x186356520")]
	public void NLGBIDBHMLG(int DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x6355910", Offset = "0x6354710", VA = "0x186355910")]
	public void IJLCNLGMLDB(uint HCKJEGFDPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x6355C90", Offset = "0x6354A90", VA = "0x186355C90")]
	public void IMLACJKGPOL(bool NFPPBMLGOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x63564E0", Offset = "0x63552E0", VA = "0x1863564E0")]
	public void NFEAOOMNCNB(long MKOHADONNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x63566C0", Offset = "0x63554C0", VA = "0x1863566C0")]
	public void PAIAFHLMODJ(ulong NEEHGLOEKFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x6355880", Offset = "0x6354680", VA = "0x186355880")]
	public void CHJJFAFCBLE(string HCJLPANMOCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x6356630", Offset = "0x6355430", VA = "0x186356630")]
	public void OMMNHNMGOIO(Enum PBDFKDHMIEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x6355CB0", Offset = "0x6354AB0", VA = "0x186355CB0")]
	public void IMMGFPEMBGM(IList DEEJEKFIHBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x3A1EBD0", Offset = "0x3A1D9D0", VA = "0x183A1EBD0")]
	public void HKEAMHCDBEN<T, U>(Dictionary<T, U> JOFBGDIJCFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x6355920", Offset = "0x6354720", VA = "0x186355920")]
	private void IKJIOKNFHLF(IDictionary JOFBGDIJCFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x6356700", Offset = "0x6355500", VA = "0x186356700")]
	public int PFKCFNOJPFD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x63565C0", Offset = "0x63553C0", VA = "0x1863565C0")]
	public short NMPNIHGJMEK()
	{
		return default(short);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x6355900", Offset = "0x6354700", VA = "0x186355900")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x6356470", Offset = "0x6355270", VA = "0x186356470")]
	private void MMGAKIBPGBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public abstract class HAGJIMABILE<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000094")]
	internal class FFPAFLPFDCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public TNode BLHHJNENDMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public TNode ICMEPOIJCJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public GCAIKFILGPD KKBMLPHFFPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public List<GCAIKFILGPD> EGOAIMIKMNF;

		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
		public FFPAFLPFDCL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000095")]
	internal struct GCAIKFILGPD : IComparable<GCAIKFILGPD>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public int BBCHOGHICAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public TClaimant AFAEPPFLPJF;

		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0xB49000", Offset = "0xB47E00", VA = "0x180B49000")]
		public GCAIKFILGPD(int BBCHOGHICAO, TClaimant AFAEPPFLPJF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x45EC310", Offset = "0x45EB110", VA = "0x1845EC310")]
		public bool GGHOIPJFMFL(in GCAIKFILGPD KICLNADFIEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x45EC370", Offset = "0x45EB170", VA = "0x1845EC370")]
		public bool POAHHAPMNPG(in GCAIKFILGPD KICLNADFIEK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x45EC300", Offset = "0x45EB100", VA = "0x1845EC300", Slot = "4")]
		public int CompareTo(GCAIKFILGPD KICLNADFIEK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x45EC380", Offset = "0x45EB180", VA = "0x1845EC380", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000096")]
	public enum JDCBBGEIMGI
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000097")]
	[CompilerGenerated]
	private sealed class PPMJEGCJBCF : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public global::HAGJIMABILE<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000328")]
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600032A")]
			[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x2CD6200", Offset = "0x2CD5000", VA = "0x182CD6200")]
		[DebuggerHidden]
		public PPMJEGCJBCF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x3A54B30", Offset = "0x3A53930", VA = "0x183A54B30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x3A54CF0", Offset = "0x3A53AF0", VA = "0x183A54CF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(RVA = "0x3A54C10", Offset = "0x3A53A10", VA = "0x183A54C10", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x3843C90", Offset = "0x3842A90", VA = "0x183843C90", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static readonly global::GDKLBHINFJL<FFPAFLPFDCL> BGCAJHDEECK;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static readonly global::GDKLBHINFJL<List<GCAIKFILGPD>> HPJJIDJFMGH;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static int PKMCOLDKLBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	internal readonly Dictionary<TClaimant, TNode> NAHPHGPEFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	internal readonly Dictionary<TNode, FFPAFLPFDCL> CNOJJLJOLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	private JDCBBGEIMGI HOEJODOFJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private bool HJIBKFJJOMP;

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode EKMEMACGALM(TNode ABKPGPJAFGM);

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void ONCPJLDEGAD(TNode ABKPGPJAFGM, TClaimant MKLBCGGLLIB, TClaimant CLOJHMHPHEJ);

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x4501B10", Offset = "0x4500910", VA = "0x184501B10")]
	public HAGJIMABILE(JDCBBGEIMGI HOEJODOFJHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x4501650", Offset = "0x4500450", VA = "0x184501650")]
	public void LLNIIHNOMHA(TNode ABKPGPJAFGM, TNode LCCGHHJFGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x4501330", Offset = "0x4500130", VA = "0x184501330")]
	public void JHDMLMCOAFF(TClaimant AFAEPPFLPJF, TNode ABMPDDKOOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x4500AF0", Offset = "0x44FF8F0", VA = "0x184500AF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x4501290", Offset = "0x4500090", VA = "0x184501290")]
	private void IBFGONJICPL(TClaimant AFAEPPFLPJF, TNode IAHHHLBKAGO, TNode ABMPDDKOOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x4500A90", Offset = "0x44FF890", VA = "0x184500A90")]
	private int DIJJINCEEBD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x45003C0", Offset = "0x44FF1C0", VA = "0x1845003C0")]
	private void AIGGOGKCPKM(TClaimant AFAEPPFLPJF, TNode MFEAABGOOLB, TNode OLFCKPDOOKF, int KOOIKJAFDHK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x4501430", Offset = "0x4500230", VA = "0x184501430")]
	private void KIOGMGLCNDM(GCAIKFILGPD GIHEIABIDBA, FFPAFLPFDCL GGCLNKGONMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x4500670", Offset = "0x44FF470", VA = "0x184500670")]
	private void BCJBCJFGCHF(TClaimant AFAEPPFLPJF, TNode MFEAABGOOLB, TNode OLFCKPDOOKF, int KOOIKJAFDHK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x4501180", Offset = "0x44FFF80", VA = "0x184501180")]
	private void IAJIAAGPBKA(GCAIKFILGPD GIHEIABIDBA, TNode ABKPGPJAFGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x45016D0", Offset = "0x45004D0", VA = "0x1845016D0")]
	private void NJIHJPMPLCF(GCAIKFILGPD GIHEIABIDBA, FFPAFLPFDCL GGCLNKGONMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x45017D0", Offset = "0x45005D0", VA = "0x1845017D0")]
	private void PHLCDBGJIJM(FFPAFLPFDCL GGCLNKGONMF, bool DELEFHPFPEA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x4500E10", Offset = "0x44FFC10", VA = "0x184500E10")]
	private void HHPPAKOEDEP(FFPAFLPFDCL GGCLNKGONMF, TNode LCCGHHJFGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x45018E0", Offset = "0x45006E0", VA = "0x1845018E0")]
	[IteratorStateMachine(typeof(global::HAGJIMABILE<, >.PPMJEGCJBCF))]
	private IEnumerable<TNode> PMJPPFCPJDP(TNode MFEAABGOOLB, TNode OLFCKPDOOKF, bool GCCIPPCJFBE = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x4500D50", Offset = "0x44FFB50", VA = "0x184500D50")]
	private FFPAFLPFDCL GBBMEONDHPK(TNode ABKPGPJAFGM, TNode ICMEPOIJCJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x45014C0", Offset = "0x45002C0", VA = "0x1845014C0")]
	private FFPAFLPFDCL LLCDMJGKHFN(TNode ABKPGPJAFGM, TNode ICMEPOIJCJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x45008D0", Offset = "0x44FF6D0", VA = "0x1845008D0")]
	private void BHDJHFNJODJ(FFPAFLPFDCL GGCLNKGONMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public class GGMOAHGJIJD<T> : IEnumerable<global::GGMOAHGJIJD<T>.BOGCLLBCKAJ>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	public struct BOGCLLBCKAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public T DFEOJBAFBHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public int NPDGHPHAKDK;
	}

	[Cpp2IlInjected.Token(Token = "0x200009A")]
	public class BLAMBBBAKIE : IEnumerator<BOGCLLBCKAJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private global::GGMOAHGJIJD<T> LLHCHDMLAEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private int NPDGHPHAKDK;

		[Cpp2IlInjected.Token(Token = "0x17000086")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000344")]
			[Cpp2IlInjected.Address(RVA = "0x27D0AF0", Offset = "0x27CF8F0", VA = "0x1827D0AF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public BOGCLLBCKAJ JLIFGAJEJIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000345")]
			[Cpp2IlInjected.Address(RVA = "0x3BEFD90", Offset = "0x3BEEB90", VA = "0x183BEFD90", Slot = "4")]
			get
			{
				return default(BOGCLLBCKAJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0xA45C10", Offset = "0xA44A10", VA = "0x180A45C10")]
		public BLAMBBBAKIE(global::GGMOAHGJIJD<T> LLHCHDMLAEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x3BEFD10", Offset = "0x3BEEB10", VA = "0x183BEFD10", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0xA45C00", Offset = "0xA44A00", VA = "0x180A45C00", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x12AF520", Offset = "0x12AE320", VA = "0x1812AF520", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009B")]
	private struct GFKOHILIKME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public bool JGKMKPHAIOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public T DFEOJBAFBHE;
	}

	[Cpp2IlInjected.Token(Token = "0x4000162")]
	private const int ILPGNPICNKJ = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	private readonly Dictionary<T, int> DEDDDIPEDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	private GFKOHILIKME[] EPDKIAILIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	private int EBDCDFEFBGC;

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public int PCDCDCNEAHI
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x7335E0", Offset = "0x7323E0", VA = "0x1807335E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x733790", Offset = "0x732590", VA = "0x180733790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x3443340", Offset = "0x3442140", VA = "0x183443340")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000330")]
	[Cpp2IlInjected.Address(RVA = "0x428C230", Offset = "0x428B030", VA = "0x18428C230")]
	public GGMOAHGJIJD(int CIMAPKKBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x428BA50", Offset = "0x428A850", VA = "0x18428BA50")]
	public GGMOAHGJIJD(BOGCLLBCKAJ[] EABPBDHKJJC, bool MNMIDHFIJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x428B290", Offset = "0x428A090", VA = "0x18428B290")]
	public int HGFENCIFCFH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x428A7A0", Offset = "0x42895A0", VA = "0x18428A7A0")]
	private int ANGPJBGMIFC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x428B3D0", Offset = "0x428A1D0", VA = "0x18428B3D0", Slot = "6")]
	protected virtual uint KOOFGGDDHII(uint NHBPPIHNEOH, T DFEOJBAFBHE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000335")]
	[Cpp2IlInjected.Address(RVA = "0x428A9D0", Offset = "0x42897D0", VA = "0x18428A9D0")]
	public bool CBNAAKOFFOO(T DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x428B350", Offset = "0x428A150", VA = "0x18428B350")]
	public bool HNGHDKPCOGD(int NPDGHPHAKDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x428B110", Offset = "0x4289F10", VA = "0x18428B110")]
	public bool HGEFFBLNLHD(Func<T, bool> DBADFKHLJMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x428B440", Offset = "0x428A240", VA = "0x18428B440")]
	public int LABEIDIDGOE(T DFEOJBAFBHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(RVA = "0x428B4A0", Offset = "0x428A2A0", VA = "0x18428B4A0")]
	public T NAGKGPCIBKK(int NPDGHPHAKDK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x428ADB0", Offset = "0x4289BB0", VA = "0x18428ADB0")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x428B790", Offset = "0x428A590", VA = "0x18428B790")]
	public bool PICFJGOPDMI(T DFEOJBAFBHE, bool PCCLFNCBDBA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x428B590", Offset = "0x428A390", VA = "0x18428B590")]
	public bool PICFJGOPDMI(T DFEOJBAFBHE, int NPDGHPHAKDK, bool PCCLFNCBDBA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x428AEB0", Offset = "0x4289CB0", VA = "0x18428AEB0")]
	public bool FAHLDBEBGON(T DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x428ACC0", Offset = "0x4289AC0", VA = "0x18428ACC0")]
	public bool CCGFPBPKEDH(int NPDGHPHAKDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(RVA = "0x428B020", Offset = "0x4289E20", VA = "0x18428B020")]
	private void FKCAFOAMPCI(int NPDGHPHAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(RVA = "0x428AA10", Offset = "0x4289810", VA = "0x18428AA10")]
	public BOGCLLBCKAJ[] CCDPKGMDNKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(RVA = "0x428AD10", Offset = "0x4289B10", VA = "0x18428AD10")]
	private int DPBPFLDDAGG(int JHOHOEJNFBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(RVA = "0x428B9D0", Offset = "0x428A7D0", VA = "0x18428B9D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x428B9D0", Offset = "0x428A7D0", VA = "0x18428B9D0", Slot = "4")]
	private IEnumerator<BOGCLLBCKAJ> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public struct BOJMANGKCAI<Handle> where Handle : BCAIPGNNKGO, new()
{
	[Cpp2IlInjected.Token(Token = "0x200009D")]
	private struct CIOJGEMBPKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private readonly global::BOJMANGKCAI<Handle> OCHEBLLDOAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private int NPDGHPHAKDK;

		[Cpp2IlInjected.Token(Token = "0x1700008E")]
		public int IBNJNCPFKDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000368")]
			[Cpp2IlInjected.Address(RVA = "0x47DD600", Offset = "0x47DC400", VA = "0x1847DD600")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008F")]
		public Handle CDACAOKDPBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000369")]
			[Cpp2IlInjected.Address(RVA = "0x47DE100", Offset = "0x47DCF00", VA = "0x1847DE100")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(RVA = "0x46E77C0", Offset = "0x46E65C0", VA = "0x1846E77C0")]
		public CIOJGEMBPKA(global::BOJMANGKCAI<Handle> OCHEBLLDOAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(RVA = "0x46E7360", Offset = "0x46E6160", VA = "0x1846E7360")]
		public FPLHIBPGMEF DHGKFEMNGCO(in FPLHIBPGMEF GJBHFPJIHBB)
		{
			return default(FPLHIBPGMEF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(RVA = "0x46E7400", Offset = "0x46E6200", VA = "0x1846E7400")]
		public HKHIGBLCMNB DHGKFEMNGCO(in HKHIGBLCMNB GJBHFPJIHBB)
		{
			return default(HKHIGBLCMNB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x47DD9F0", Offset = "0x47DC7F0", VA = "0x1847DD9F0")]
		public bool GGDHMJEBLDB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(RVA = "0x47DDD50", Offset = "0x47DCB50", VA = "0x1847DDD50")]
		private int JDBFPFJDLCF(string LMLMHJKGDCH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(RVA = "0x47DD950", Offset = "0x47DC750", VA = "0x1847DD950")]
		private Handle FGLKOMLMLGL(string LMLMHJKGDCH)
		{
			return (Handle)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009E")]
	public struct FPLHIBPGMEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		private CIOJGEMBPKA MDKELAAILKF;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public int JLIFGAJEJIJ
		{
			[Cpp2IlInjected.Token(Token = "0x600036D")]
			[Cpp2IlInjected.Address(RVA = "0x4341A80", Offset = "0x4340880", VA = "0x184341A80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(RVA = "0x3B1B130", Offset = "0x3B19F30", VA = "0x183B1B130")]
		public FPLHIBPGMEF(global::BOJMANGKCAI<Handle> OCHEBLLDOAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(RVA = "0x3B1AFF0", Offset = "0x3B19DF0", VA = "0x183B1AFF0")]
		public bool GGDHMJEBLDB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x4341AC0", Offset = "0x43408C0", VA = "0x184341AC0")]
		public FPLHIBPGMEF HPPJKDPBNFG()
		{
			return default(FPLHIBPGMEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200009F")]
	public struct HKHIGBLCMNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private CIOJGEMBPKA MDKELAAILKF;

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		public Handle JLIFGAJEJIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000371")]
			[Cpp2IlInjected.Address(RVA = "0x3B1AEF0", Offset = "0x3B19CF0", VA = "0x183B1AEF0")]
			get
			{
				return (Handle)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000370")]
		[Cpp2IlInjected.Address(RVA = "0x3B1B130", Offset = "0x3B19F30", VA = "0x183B1B130")]
		public HKHIGBLCMNB(global::BOJMANGKCAI<Handle> OCHEBLLDOAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(RVA = "0x3B1AFF0", Offset = "0x3B19DF0", VA = "0x183B1AFF0")]
		public bool GGDHMJEBLDB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(RVA = "0x3B1B0B0", Offset = "0x3B19EB0", VA = "0x183B1B0B0")]
		public HKHIGBLCMNB HPPJKDPBNFG()
		{
			return default(HKHIGBLCMNB);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	private NativeList<int> OIOHKJMDOFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	private NativeList<int> FINENEBMGBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	private int OPEEFEMGHHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private int IHHCHHAKLGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	private bool BCKANAMNCJA;

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	public bool CAJAJNAMICK
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x77CC90", Offset = "0x77BA90", VA = "0x18077CC90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	public int AMLADJJCJHM
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x489FF90", Offset = "0x489ED90", VA = "0x18489FF90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public int POIJALBHBEP
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x734720", Offset = "0x733520", VA = "0x180734720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	public int FONEHMJPKPN
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x734720", Offset = "0x733520", VA = "0x180734720")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public FPLHIBPGMEF JFJIIAFIBFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x48A0C50", Offset = "0x489FA50", VA = "0x1848A0C50")]
		get
		{
			return default(FPLHIBPGMEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public HKHIGBLCMNB JLKMFALGJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(RVA = "0x48A0E70", Offset = "0x489FC70", VA = "0x1848A0E70")]
		get
		{
			return default(HKHIGBLCMNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x48A4610", Offset = "0x48A3410", VA = "0x1848A4610")]
	public BOJMANGKCAI(int EILLENDCLPG, Allocator AEPJLHDIHPH = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x48A2470", Offset = "0x48A1270", VA = "0x1848A2470")]
	public void KKDFCIPLDMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(RVA = "0x3922540", Offset = "0x3921340", VA = "0x183922540")]
	public static int EOPJBIGFFMC(int BGLBBPFJJCJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x48A10A0", Offset = "0x489FEA0", VA = "0x1848A10A0")]
	public static bool EEEOLFMLPON(int BGLBBPFJJCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x48A1370", Offset = "0x48A0170", VA = "0x1848A1370")]
	public static bool JBGMGPDFNHO(int BGLBBPFJJCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x48A3BF0", Offset = "0x48A29F0", VA = "0x1848A3BF0")]
	public bool ONBOGFLLBFO(int NPDGHPHAKDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x48A3F50", Offset = "0x48A2D50", VA = "0x1848A3F50")]
	public bool PBKJDLPJFDE(int NPDGHPHAKDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x48A3830", Offset = "0x48A2630", VA = "0x1848A3830")]
	public bool OGOOEALLGCK(Handle DCLMHANFEGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(RVA = "0x48A0010", Offset = "0x489EE10", VA = "0x1848A0010")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void BIHEFNCICKH(Handle DCLMHANFEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(RVA = "0x48A25F0", Offset = "0x48A13F0", VA = "0x1848A25F0")]
	public Handle KMHFGGKEJDD()
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(RVA = "0x48A1B80", Offset = "0x48A0980", VA = "0x1848A1B80")]
	public void JJAPGPLEGNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(RVA = "0x48A1480", Offset = "0x48A0280", VA = "0x1848A1480")]
	public void JIHCMGJBFDG(Handle DCLMHANFEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(RVA = "0x48A10B0", Offset = "0x489FEB0", VA = "0x1848A10B0")]
	public bool GGNKKLMPHJB(Handle DCLMHANFEGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(RVA = "0x77CC90", Offset = "0x77BA90", VA = "0x18077CC90")]
	private bool ONCLHNOJHIO()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(RVA = "0x48A0CF0", Offset = "0x489FAF0", VA = "0x1848A0CF0")]
	private bool DKFONKEBBMA(int NPDGHPHAKDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(RVA = "0x48A3040", Offset = "0x48A1E40", VA = "0x1848A3040")]
	private void MGIAMGLLLMB(out int NPDGHPHAKDK, out int IIJDDKBOPLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(RVA = "0x48A31B0", Offset = "0x48A1FB0", VA = "0x1848A31B0")]
	private void OAKAOHEGFJK(Handle DCLMHANFEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x48A2200", Offset = "0x48A1000", VA = "0x1848A2200")]
	private void JLNPDKAGPCJ(int NPDGHPHAKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x48A2A90", Offset = "0x48A1890", VA = "0x1848A2A90")]
	private bool MCPEJGMMILF(out int NPDGHPHAKDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x48A1000", Offset = "0x489FE00", VA = "0x1848A1000")]
	private static Handle EDCKEGHBLOJ(int NPDGHPHAKDK, int IIJDDKBOPLN)
	{
		return (Handle)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
[DefaultMember("Item")]
public struct AOPGFFKJFJG<Handle, T> where Handle : BCAIPGNNKGO, new() where T : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private global::BOJMANGKCAI<Handle> EKHMPFOOOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private T[] IFKDFNCPIAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private Action<T> GHDICMHAJOO;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public bool CAJAJNAMICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x418B880", Offset = "0x418A680", VA = "0x18418B880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public int AMLADJJCJHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000377")]
		[Cpp2IlInjected.Address(RVA = "0x4188800", Offset = "0x4187600", VA = "0x184188800")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x41889F0", Offset = "0x41877F0", VA = "0x1841889F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public T PGMGPNCDKFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(RVA = "0x41893A0", Offset = "0x41881A0", VA = "0x1841893A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x418B9B0", Offset = "0x418A7B0", VA = "0x18418B9B0")]
	public AOPGFFKJFJG(int EILLENDCLPG, [Optional] Action<T> GHDICMHAJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x418ABF0", Offset = "0x41899F0", VA = "0x18418ABF0")]
	public void KKDFCIPLDMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(RVA = "0x418B830", Offset = "0x418A630", VA = "0x18418B830")]
	public bool OGOOEALLGCK(Handle DCLMHANFEGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
	[Conditional("UNITY_EDITOR")]
	[Conditional("DEBUG_BUILD")]
	public void BIHEFNCICKH(Handle DCLMHANFEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x4188A20", Offset = "0x4187820", VA = "0x184188A20")]
	public T CIGAFCHFFML(Handle DCLMHANFEGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x418AF50", Offset = "0x4189D50", VA = "0x18418AF50")]
	public bool MDMOKHFDALA(Handle DCLMHANFEGK, out T GKCPJCKCENH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x4189F40", Offset = "0x4188D40", VA = "0x184189F40")]
	public void FAFPJPFNCCD(Handle DCLMHANFEGK, T BDHNGFEHAEC, out T PEEAFOHPBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x4189E20", Offset = "0x4188C20", VA = "0x184189E20")]
	public void FAFPJPFNCCD(Handle DCLMHANFEGK, T BDHNGFEHAEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x4189940", Offset = "0x4188740", VA = "0x184189940")]
	public bool EIHINOPMEGD(Handle DCLMHANFEGK, T BDHNGFEHAEC, out T PEEAFOHPBND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x4189580", Offset = "0x4188380", VA = "0x184189580")]
	public bool EIHINOPMEGD(Handle DCLMHANFEGK, T BDHNGFEHAEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x418A9D0", Offset = "0x41897D0", VA = "0x18418A9D0")]
	public Handle HMNAIPBHJIK(T GKCPJCKCENH)
	{
		return (Handle)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x4188D10", Offset = "0x4187B10", VA = "0x184188D10")]
	public void DDCLDBCGDHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(RVA = "0x418A3F0", Offset = "0x41891F0", VA = "0x18418A3F0")]
	public void FAHLDBEBGON(Handle DCLMHANFEGK, out T PEEAFOHPBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x418A180", Offset = "0x4188F80", VA = "0x18418A180")]
	public void FAHLDBEBGON(Handle DCLMHANFEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x418B580", Offset = "0x418A380", VA = "0x18418B580")]
	public bool NLMLMECNDCH(Handle DCLMHANFEGK, out T PEEAFOHPBND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x418B4A0", Offset = "0x418A2A0", VA = "0x18418B4A0")]
	public bool NLMLMECNDCH(Handle DCLMHANFEGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x4188990", Offset = "0x4187790", VA = "0x184188990")]
	private T CCGFPBPKEDH(int NPDGHPHAKDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x41888C0", Offset = "0x41876C0", VA = "0x1841888C0")]
	private void AGBJIBCDJKP(int IEGDCAKJBPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public class GDKLBHINFJL<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private readonly Stack<T> OCHEBLLDOAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private readonly List<T> PIDPDCBGCFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private readonly int INEHFFCGIBJ;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public int CHAHMNGCELK
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x37C6500", Offset = "0x37C5300", VA = "0x1837C6500")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public int HGPJECKDMGP
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x3D88CE0", Offset = "0x3D87AE0", VA = "0x183D88CE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x45EE890", Offset = "0x45ED690", VA = "0x1845EE890")]
	public static global::GDKLBHINFJL<T> GOMMDIKPAKI(int CIMAPKKBLKM = 0, int INEHFFCGIBJ = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x45EEBF0", Offset = "0x45ED9F0", VA = "0x1845EEBF0")]
	public static global::GDKLBHINFJL<T> PDDIHHPAEGM(int CIMAPKKBLKM = 0, int INEHFFCGIBJ = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x45EECC0", Offset = "0x45EDAC0", VA = "0x1845EECC0")]
	public GDKLBHINFJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x45EED00", Offset = "0x45EDB00", VA = "0x1845EED00")]
	public GDKLBHINFJL(int CIMAPKKBLKM, int INEHFFCGIBJ = int.MaxValue, bool KENKJMOBMOJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x45EE780", Offset = "0x45ED580", VA = "0x1845EE780")]
	public T FDGDPBGFHNH()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x45EEAB0", Offset = "0x45ED8B0", VA = "0x1845EEAB0")]
	public void MCFEKKLCLLO(T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x45EE9E0", Offset = "0x45ED7E0", VA = "0x1845EE9E0")]
	private void JOBMLJOKCPH(T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x45EE4D0", Offset = "0x45ED2D0", VA = "0x1845EE4D0")]
	private void DAMNEEKNKHK(T DFEOJBAFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x45EE960", Offset = "0x45ED760", VA = "0x1845EE960")]
	[Conditional("DEBUG_BUILD")]
	private void JCJPHJNAILP(T MFDBEKACMBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x45EEB60", Offset = "0x45ED960", VA = "0x1845EEB60")]
	[Conditional("DEBUG_BUILD")]
	private void OILJLNNLCOB(T MFDBEKACMBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x45EE690", Offset = "0x45ED490", VA = "0x1845EE690", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x45EE4F0", Offset = "0x45ED2F0", VA = "0x1845EE4F0")]
	private void DIGFIKBBDEL(IEnumerable<T> GPJMEADJCFO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public class CAFMOANLKFK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private Dictionary<int, T> HEFFNNIBIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private T KCGNLOFCJMH;

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public virtual T DHEAEOAFAIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x7337A0", Offset = "0x7325A0", VA = "0x1807337A0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool LIHICEFPCAP
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x3C1E1F0", Offset = "0x3C1CFF0", VA = "0x183C1E1F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x3C1E910", Offset = "0x3C1D710", VA = "0x183C1E910")]
	public bool PAGNFDLBLPI(T DFEOJBAFBHE, int BBCHOGHICAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x3C1E850", Offset = "0x3C1D650", VA = "0x183C1E850")]
	public bool JFPCPHHFBIN(int BBCHOGHICAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x3C1E660", Offset = "0x3C1D460", VA = "0x183C1E660")]
	public T HOIIGIAMKMP(int DMMLPGHJNOD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x3C1E3D0", Offset = "0x3C1D1D0", VA = "0x183C1E3D0")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x3C1E340", Offset = "0x3C1D140", VA = "0x183C1E340")]
	private bool DILCFEOGGNC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x3C1E430", Offset = "0x3C1D230", VA = "0x183C1E430")]
	public bool HADOILGNPLN(int BBCHOGHICAO, out T DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x3C1E970", Offset = "0x3C1D770", VA = "0x183C1E970")]
	public CAFMOANLKFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
public class DOBMNJODFFG<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000A4")]
	protected struct OMBMHCNMJDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		public T FBCEGMCNEND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		public int IMPMIBBFHDB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	protected readonly List<OMBMHCNMJDE> IMNHEMNOGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private T MDHFJBNDLLJ;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x3443340", Offset = "0x3442140", VA = "0x183443340")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB1E0", Offset = "0x3AB9FE0", VA = "0x183ABB1E0")]
	public bool HGEFFBLNLHD(T DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB3F0", Offset = "0x3ABA1F0", VA = "0x183ABB3F0")]
	public void HMNAIPBHJIK(T DFEOJBAFBHE, int BBCHOGHICAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB0C0", Offset = "0x3AB9EC0", VA = "0x183ABB0C0")]
	public bool FAHLDBEBGON(T DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB060", Offset = "0x3AB9E60", VA = "0x183ABB060")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB650", Offset = "0x3ABA450", VA = "0x183ABB650")]
	public T OIPGIFJHBLJ()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB6C0", Offset = "0x3ABA4C0", VA = "0x183ABB6C0")]
	public T PEFELEHEIIP()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB490", Offset = "0x3ABA290", VA = "0x183ABB490")]
	private void LNOOMCBAEHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x3ABB730", Offset = "0x3ABA530", VA = "0x183ABB730")]
	public DOBMNJODFFG()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A5")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		[SerializeField]
		[OBCALLPEFCG(CABHOIOLNCF.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700009B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60003AB")]
			[Cpp2IlInjected.Address(RVA = "0x6359690", Offset = "0x6358490", VA = "0x186359690")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60003AC")]
			[Cpp2IlInjected.Address(RVA = "0x6359A20", Offset = "0x6358820", VA = "0x186359A20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60003AD")]
			[Cpp2IlInjected.Address(RVA = "0x63598A0", Offset = "0x63586A0", VA = "0x1863598A0")]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60003AE")]
			[Cpp2IlInjected.Address(RVA = "0x6359B80", Offset = "0x6358980", VA = "0x186359B80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60003AF")]
			[Cpp2IlInjected.Address(RVA = "0x63595B0", Offset = "0x63583B0", VA = "0x1863595B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60003B0")]
			[Cpp2IlInjected.Address(RVA = "0x6359940", Offset = "0x6358740", VA = "0x186359940")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60003B1")]
			[Cpp2IlInjected.Address(RVA = "0x63597C0", Offset = "0x63585C0", VA = "0x1863597C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x6359560", Offset = "0x6358360", VA = "0x186359560")]
		public ReferencePoint()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public interface EJILIECFOPD
{
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000A7")]
	public abstract class ResourcePrefabReference<T> : EJILIECFOPD where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x3974E90", Offset = "0x3973C90", VA = "0x183974E90", Slot = "4")]
		public virtual T OFNGKJJFMNB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x27D26D0", Offset = "0x27D14D0", VA = "0x1827D26D0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public class NILLHBHCDMM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private readonly Dictionary<byte, GDJDOLMHIKP> NNOEPDCOBBH;

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public GDJDOLMHIKP PKMPJDOJICD
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x6AE8E0", Offset = "0x6AD6E0", VA = "0x1806AE8E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x6B2150", Offset = "0x6B0F50", VA = "0x1806B2150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public Vector2 GJMNKFLMPKF
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x78AEA0", Offset = "0x789CA0", VA = "0x18078AEA0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x851390", Offset = "0x850190", VA = "0x180851390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public Vector2 CNAGDMFLKLA
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x78AE80", Offset = "0x789C80", VA = "0x18078AE80")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0xCAD460", Offset = "0xCAC260", VA = "0x180CAD460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public Vector2 MDHDOAHHBBA
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x6358890", Offset = "0x6357690", VA = "0x186358890")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x8513C0", Offset = "0x8501C0", VA = "0x1808513C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int IPOHPCGLPAO
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x73BBA0", Offset = "0x73A9A0", VA = "0x18073BBA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x73C470", Offset = "0x73B270", VA = "0x18073C470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x6358E30", Offset = "0x6357C30", VA = "0x186358E30")]
	public NILLHBHCDMM(Bounds MLPDBGEJDGD, Vector2[] BJEBGAMAIGH, int ONBMOMMDMAC, byte JHOHOEJNFBB, float PBCPKBHELHB = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x63588B0", Offset = "0x63576B0", VA = "0x1863588B0")]
	public GDJDOLMHIKP GAGMOJEEHKD(byte NPDGHPHAKDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x6358910", Offset = "0x6357710", VA = "0x186358910")]
	public void GANKGIAKJDP(Vector3 IJBELJOFGFA, float POKACKNENPM, float PJEHEEGEBPO, ref List<byte> COLDHDIMPGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x6358A10", Offset = "0x6357810", VA = "0x186358A10")]
	public void ILOGPBDIHME(GDJDOLMHIKP.DLKDOODJJHF KAHLOPILKKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x6358730", Offset = "0x6357530", VA = "0x186358730")]
	private GDJDOLMHIKP CPOGNLJFLJA(byte NPDGHPHAKDK, GDJDOLMHIKP.BFIOHNJJALI EMOOKJAHNFG, GDJDOLMHIKP ICMEPOIJCJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x6358A30", Offset = "0x6357830", VA = "0x186358A30")]
	private void JFPMBCGMHCF(GDJDOLMHIKP ICMEPOIJCJO, Vector2[] BJEBGAMAIGH, int FKJCCNIBGOI, int PGOAADFBHDM, int OMPHMPHINMI, int GADNOEADAHN, float PBCPKBHELHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public class GDJDOLMHIKP
{
	[Cpp2IlInjected.Token(Token = "0x20000AA")]
	public enum BFIOHNJJALI
	{
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x20000AB")]
	public enum DLKDOODJJHF
	{
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public byte OIMEPCKLHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public Vector3 HNOHDNLONIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	public Vector3 FGDMPDNAJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	public Vector3 GJPDODFKMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	public Vector3 MHPNGHKBMIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	public BFIOHNJJALI FJHFHNBPOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	public GDJDOLMHIKP JAGJOAIDNHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public List<GDJDOLMHIKP> BBKHPAPGNLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public bool JDFECHBFKDB;

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x6355450", Offset = "0x6354250", VA = "0x186355450")]
	public GDJDOLMHIKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x63553F0", Offset = "0x63541F0", VA = "0x1863553F0")]
	public GDJDOLMHIKP(byte KCHLIHHPAKF, BFIOHNJJALI EMOOKJAHNFG, GDJDOLMHIKP ICMEPOIJCJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x63552E0", Offset = "0x63540E0", VA = "0x1863552E0")]
	public void HLPNFHFHFFD(GDJDOLMHIKP ELFIACEEOOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
	public void ILOGPBDIHME(int AKDHDKELPJA, DLKDOODJJHF KAHLOPILKKD, int MBNPAAJIBGL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x6355030", Offset = "0x6353E30", VA = "0x186355030")]
	public void GANKGIAKJDP(List<byte> COLDHDIMPGE, Vector3 IJBELJOFGFA, float POKACKNENPM, float PJEHEEGEBPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x63553A0", Offset = "0x63541A0", VA = "0x1863553A0")]
	public bool PFNFGCBENJD(Vector3 LMABBBKCION)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x6354FF0", Offset = "0x6353DF0", VA = "0x186354FF0")]
	public bool DFNELGKGFPO(Vector3 LMABBBKCION, float JPINNKECINB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public class EHNJCDNGBMO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private readonly Dictionary<T, object> PHPKGHDKIGM;

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x3B1A2C0", Offset = "0x3B190C0", VA = "0x183B1A2C0")]
	public bool FCKPKFIKHKN(T HFIAEBCEENB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x3D880F0", Offset = "0x3D86EF0", VA = "0x183D880F0")]
	public bool FCKPKFIKHKN(T HFIAEBCEENB, object KCCFEDJJGAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x3D88130", Offset = "0x3D86F30", VA = "0x183D88130")]
	public bool FCKPKFIKHKN(T HFIAEBCEENB, object KCCFEDJJGAN, out object MFOCOHFHAML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x3D88260", Offset = "0x3D87060", VA = "0x183D88260")]
	public bool PCKJKADFNHP(T HFIAEBCEENB, object KCCFEDJJGAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x3D880B0", Offset = "0x3D86EB0", VA = "0x183D880B0")]
	public bool AOPJDILKCCN(T HFIAEBCEENB, object KCCFEDJJGAN, out object MFOCOHFHAML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x3D882A0", Offset = "0x3D870A0", VA = "0x183D882A0")]
	public bool PCKJKADFNHP(T HFIAEBCEENB, object KCCFEDJJGAN, out object MFOCOHFHAML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x3D88190", Offset = "0x3D86F90", VA = "0x183D88190")]
	public void HNHIKLLNOGI(T HFIAEBCEENB, object KCCFEDJJGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x3D881C0", Offset = "0x3D86FC0", VA = "0x183D881C0")]
	public void OLCHOBGJECE(T HFIAEBCEENB, object KCCFEDJJGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x3D88330", Offset = "0x3D87130", VA = "0x183D88330")]
	public EHNJCDNGBMO()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x20000AD")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x20000AE")]
		public struct ENHELGDMBCM<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A4")]
			private readonly List<Component> DEEJEKFIHBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A5")]
			private readonly bool BKEBANKBFBE;

			[Cpp2IlInjected.Token(Token = "0x60003E5")]
			[Cpp2IlInjected.Address(RVA = "0x1380940", Offset = "0x137F740", VA = "0x181380940")]
			public ENHELGDMBCM(List<Component> DEEJEKFIHBB, bool BKEBANKBFBE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003E6")]
			[Cpp2IlInjected.Address(RVA = "0x2CCEDA0", Offset = "0x2CCDBA0", VA = "0x182CCEDA0")]
			public DMFHKEKDNCJ<T> HPPJKDPBNFG()
			{
				return default(DMFHKEKDNCJ<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60003E7")]
			[Cpp2IlInjected.Address(RVA = "0x2CCEE10", Offset = "0x2CCDC10", VA = "0x182CCEE10", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60003E8")]
			[Cpp2IlInjected.Address(RVA = "0x2CCEE10", Offset = "0x2CCDC10", VA = "0x182CCEE10", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x20000AF")]
		public struct DMFHKEKDNCJ<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A6")]
			private readonly List<Component> DEEJEKFIHBB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A7")]
			private readonly bool BKEBANKBFBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001A8")]
			private int NPDGHPHAKDK;

			[Cpp2IlInjected.Token(Token = "0x170000A6")]
			public T JLIFGAJEJIJ
			{
				[Cpp2IlInjected.Token(Token = "0x60003EA")]
				[Cpp2IlInjected.Address(RVA = "0x3AB8640", Offset = "0x3AB7440", VA = "0x183AB8640", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x170000A7")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60003EB")]
				[Cpp2IlInjected.Address(RVA = "0x3AB85D0", Offset = "0x3AB73D0", VA = "0x183AB85D0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60003E9")]
			[Cpp2IlInjected.Address(RVA = "0x3AB8610", Offset = "0x3AB7410", VA = "0x183AB8610")]
			public DMFHKEKDNCJ(List<Component> DEEJEKFIHBB, bool BKEBANKBFBE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003EC")]
			[Cpp2IlInjected.Address(RVA = "0x3AB8500", Offset = "0x3AB7300", VA = "0x183AB8500", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60003ED")]
			[Cpp2IlInjected.Address(RVA = "0x3AB8510", Offset = "0x3AB7310", VA = "0x183AB8510", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60003EE")]
			[Cpp2IlInjected.Address(RVA = "0x3AB85C0", Offset = "0x3AB73C0", VA = "0x183AB85C0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x170000A5")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60003D5")]
			[Cpp2IlInjected.Address(RVA = "0x635B830", Offset = "0x635A630", VA = "0x18635B830")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x635B7F0", Offset = "0x635A5F0", VA = "0x18635B7F0")]
		public ToolHierarchyCache(GameObject JLMCLCAPEFE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x635B200", Offset = "0x635A000", VA = "0x18635B200")]
		private void NAGCBALDEME(GameObject JLMCLCAPEFE, bool PAKHNBOHLFK = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x635B360", Offset = "0x635A160", VA = "0x18635B360")]
		public static void NAGCBALDEME(GameObject JLMCLCAPEFE, ref ToolHierarchyCache KEJPIFGMADN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x635B020", Offset = "0x6359E20", VA = "0x18635B020")]
		public void GFBDCONMNLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x635B720", Offset = "0x635A520", VA = "0x18635B720")]
		public void PHMALINLNIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x3803B90", Offset = "0x3802990", VA = "0x183803B90")]
		public void PNPCGIKFEKI<T>(Action<T> KNOLDLABLMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60003DD")]
		[Cpp2IlInjected.Address(RVA = "0x635B0B0", Offset = "0x6359EB0", VA = "0x18635B0B0")]
		public Component LKLGPHJLPGH(Type IGEIBCJNCHF, bool BKEBANKBFBE = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DE")]
		[Cpp2IlInjected.Address(RVA = "0x3803A40", Offset = "0x3802840", VA = "0x183803A40")]
		public T LKLGPHJLPGH<T>(bool BKEBANKBFBE = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003DF")]
		[Cpp2IlInjected.Address(RVA = "0x635B180", Offset = "0x6359F80", VA = "0x18635B180")]
		public ENHELGDMBCM<Component> MOAIHJDGBHJ(Type IGEIBCJNCHF, bool BKEBANKBFBE = false)
		{
			return default(ENHELGDMBCM<Component>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E0")]
		[Cpp2IlInjected.Address(RVA = "0x3803AC0", Offset = "0x38028C0", VA = "0x183803AC0")]
		public ENHELGDMBCM<T> MOAIHJDGBHJ<T>(bool BKEBANKBFBE = false) where T : class
		{
			return default(ENHELGDMBCM<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E1")]
		[Cpp2IlInjected.Address(RVA = "0x635B3F0", Offset = "0x635A1F0", VA = "0x18635B3F0")]
		public List<Component> NMBNENDJGMA(Type IGEIBCJNCHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60003E2")]
		[Cpp2IlInjected.Address(RVA = "0x635AFA0", Offset = "0x6359DA0", VA = "0x18635AFA0", Slot = "4")]
		public bool Equals(ToolHierarchyCache JMDPDGBMGAA, ToolHierarchyCache GKDCJKNJEID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60003E3")]
		[Cpp2IlInjected.Address(RVA = "0x635B030", Offset = "0x6359E30", VA = "0x18635B030", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache GKCPJCKCENH)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public class KODOMBIHEOG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private int CIMAPKKBLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private int MOHKPCELMKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private List<T> FKFMFNKJNOH;

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003EF")]
		[Cpp2IlInjected.Address(RVA = "0x37C6500", Offset = "0x37C5300", VA = "0x1837C6500")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public T DEAMFGIIJDN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F0")]
		[Cpp2IlInjected.Address(RVA = "0x4149800", Offset = "0x4148600", VA = "0x184149800")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public T DECJOHDIDNK
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(RVA = "0x4149520", Offset = "0x4148320", VA = "0x184149520")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public T NCAHPGGLIEH
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(RVA = "0x4149470", Offset = "0x4148270", VA = "0x184149470")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x41499C0", Offset = "0x41487C0", VA = "0x1841499C0")]
	public KODOMBIHEOG(int CIMAPKKBLKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x4149600", Offset = "0x4148400", VA = "0x184149600")]
	public void HMNAIPBHJIK(T HHJBJIHEGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x41495C0", Offset = "0x41483C0", VA = "0x1841495C0")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x4149920", Offset = "0x4148720", VA = "0x184149920")]
	public void MIMDMHMKAMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(RVA = "0x41497B0", Offset = "0x41485B0", VA = "0x1841497B0")]
	public void IIBHANJHHFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(RVA = "0x4149910", Offset = "0x4148710", VA = "0x184149910")]
	public void LDPCFHDJFMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public class GIJKPMPBNOM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	private bool IKCBJAJKEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private Action KNOLDLABLMF;

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public static GIJKPMPBNOM AHAINBALHEC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(RVA = "0x63556C0", Offset = "0x63544C0", VA = "0x1863556C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool MIHBCEKGEFO
	{
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(RVA = "0x73B600", Offset = "0x73A400", VA = "0x18073B600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(RVA = "0xAC3EA0", Offset = "0xAC2CA0", VA = "0x180AC3EA0")]
	public GIJKPMPBNOM(Action KNOLDLABLMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(RVA = "0x63556A0", Offset = "0x63544A0", VA = "0x1863556A0")]
	public void NNHOADFEBDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(RVA = "0x63556A0", Offset = "0x63544A0", VA = "0x1863556A0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public static class EPJJMMBLBNG
{
	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(RVA = "0x6354210", Offset = "0x6353010", VA = "0x186354210")]
	public static void DGJDPPPHDAI(ILPPPAONIDE CICMPKOIDDD, string AGINFBGHHKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(RVA = "0x6BE300", Offset = "0x6BD100", VA = "0x1806BE300")]
	public static void DGJDPPPHDAI(IEnumerable<object> BHBEGJLFINL, string AGINFBGHHKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public class BGBABIIPLEN<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000B4")]
	private struct ILHANJBJDFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public int IMPMIBBFHDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		public T FBCEGMCNEND;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private readonly Dictionary<object, ILHANJBJDFB> HEFFNNIBIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private readonly EqualityComparer<T> OBNGNJGELAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private T KCGNLOFCJMH;

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public virtual T DHEAEOAFAIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000400")]
		[Cpp2IlInjected.Address(RVA = "0x77C370", Offset = "0x77B170", VA = "0x18077C370", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000401")]
		[Cpp2IlInjected.Address(RVA = "0x9EF390", Offset = "0x9EE190", VA = "0x1809EF390", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public bool LIHICEFPCAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000402")]
		[Cpp2IlInjected.Address(RVA = "0x45FB780", Offset = "0x45FA580", VA = "0x1845FB780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public object KGCHJOFBCNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(RVA = "0x7385B0", Offset = "0x7373B0", VA = "0x1807385B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(RVA = "0x738030", Offset = "0x736E30", VA = "0x180738030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x45FFED0", Offset = "0x45FECD0", VA = "0x1845FFED0")]
	public bool PAGNFDLBLPI(T DFEOJBAFBHE, object KCCFEDJJGAN, int BBCHOGHICAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x45FFE30", Offset = "0x45FEC30", VA = "0x1845FFE30")]
	public bool JFPCPHHFBIN(object KCCFEDJJGAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x45FF960", Offset = "0x45FE760", VA = "0x1845FF960")]
	public bool HADOILGNPLN(object KCCFEDJJGAN, out T DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x3904DA0", Offset = "0x3903BA0", VA = "0x183904DA0")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x45FECD0", Offset = "0x45FDAD0", VA = "0x1845FECD0")]
	private bool DILCFEOGGNC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x46007C0", Offset = "0x45FF5C0", VA = "0x1846007C0")]
	public BGBABIIPLEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public class HMPFAJJPMIG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	private Dictionary<object, float> HEFFNNIBIBN;

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public float CDHLGCKGACJ
	{
		[Cpp2IlInjected.Token(Token = "0x600040B")]
		[Cpp2IlInjected.Address(RVA = "0x791280", Offset = "0x790080", VA = "0x180791280")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600040C")]
		[Cpp2IlInjected.Address(RVA = "0x89DEC0", Offset = "0x89CCC0", VA = "0x18089DEC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x6356E10", Offset = "0x6355C10", VA = "0x186356E10")]
	public void PAGNFDLBLPI(float DFEOJBAFBHE, object KCCFEDJJGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x6356DA0", Offset = "0x6355BA0", VA = "0x186356DA0")]
	public void JFPCPHHFBIN(object KCCFEDJJGAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x6356C80", Offset = "0x6355A80", VA = "0x186356C80")]
	private void BBKOLOOHJCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x6356E80", Offset = "0x6355C80", VA = "0x186356E80")]
	public HMPFAJJPMIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public class HPDGKDBFFPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public readonly string BIKMAPNDGFC;

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x85B5D0", Offset = "0x85A3D0", VA = "0x18085B5D0")]
	public HPDGKDBFFPK(string JLPHNMPIALE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x6356F50", Offset = "0x6355D50", VA = "0x186356F50")]
	public HPDGKDBFFPK(UnityEngine.Object MIFBFGFOODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x6356F00", Offset = "0x6355D00", VA = "0x186356F00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public sealed class ILPPPAONIDE
{
	[Cpp2IlInjected.Token(Token = "0x20000B8")]
	[CompilerGenerated]
	private sealed class CINJJBOHHMD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		public StringBuilder sb;

		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public CINJJBOHHMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(RVA = "0x6353D80", Offset = "0x6352B80", VA = "0x186353D80")]
		internal int <ToString>b__0(int i, object token)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	private HashSet<object> BHBEGJLFINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private int ICCKNLNJPLL;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public IReadOnlyCollection<object> EGKGPIFPHMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000414")]
		[Cpp2IlInjected.Address(RVA = "0x6357440", Offset = "0x6356240", VA = "0x186357440")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool MMFCMIFFGPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(RVA = "0x6357240", Offset = "0x6356040", VA = "0x186357240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public int BCBDBMHFMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(RVA = "0x73AA60", Offset = "0x739860", VA = "0x18073AA60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x6357350", Offset = "0x6356150", VA = "0x186357350")]
	public bool HMNAIPBHJIK(object KCCFEDJJGAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x6357250", Offset = "0x6356050", VA = "0x186357250")]
	public bool FAHLDBEBGON(object KCCFEDJJGAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x63572F0", Offset = "0x63560F0", VA = "0x1863572F0")]
	public bool HGEFFBLNLHD(object KCCFEDJJGAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x63571D0", Offset = "0x6355FD0", VA = "0x1863571D0")]
	public void ADCILDKHDOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x6357510", Offset = "0x6356310", VA = "0x186357510", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public ILPPPAONIDE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public class PFINOCCENEE<T>
{
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
	private struct MMIODFFFGIO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public float PGLDLDAMIHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public T FBCEGMCNEND;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private Dictionary<object, MMIODFFFGIO> HEFFNNIBIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private T ADKMANMMEGC;

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public virtual T AJPEAJLONCP
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(RVA = "0x97F790", Offset = "0x97E590", VA = "0x18097F790", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(RVA = "0x2BEA210", Offset = "0x2BE9010", VA = "0x182BEA210", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public object LLLMCNBOGOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(RVA = "0x7385B0", Offset = "0x7373B0", VA = "0x1807385B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(RVA = "0x738030", Offset = "0x736E30", VA = "0x180738030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool LIHICEFPCAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000426")]
		[Cpp2IlInjected.Address(RVA = "0x4654190", Offset = "0x4652F90", VA = "0x184654190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x4655E20", Offset = "0x4654C20", VA = "0x184655E20")]
	public bool PAGNFDLBLPI(T DFEOJBAFBHE, object KCCFEDJJGAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x4655AA0", Offset = "0x46548A0", VA = "0x184655AA0")]
	public bool JFPCPHHFBIN(object KCCFEDJJGAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x3904DA0", Offset = "0x3903BA0", VA = "0x183904DA0")]
	public void EMOCNNJJBKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x46558F0", Offset = "0x46546F0", VA = "0x1846558F0")]
	public bool HADOILGNPLN(object KCCFEDJJGAN, out T DFEOJBAFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x46544F0", Offset = "0x46532F0", VA = "0x1846544F0")]
	private bool DILCFEOGGNC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x46560D0", Offset = "0x4654ED0", VA = "0x1846560D0")]
	public PFINOCCENEE()
	{
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000BB")]
public class KJPGGDKBIND
{
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static byte[] CFKIOPKCLEE;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static int PODCBGNELNF;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private static int DIHMJLLDPDD;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private static BigInteger MMOCJBNMKFM;

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
	public KJPGGDKBIND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x6357DC0", Offset = "0x6356BC0", VA = "0x186357DC0")]
	private static string EAILEDEPOEM(byte[] OPGAGDBKIDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x6357A70", Offset = "0x6356870", VA = "0x186357A70")]
	public static string AMGIJLDMAAM(byte[] CCFMJPPGPDK, bool IEFNHKOPNBP)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000BC")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x20000BD")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40001C3")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(RVA = "0x6B1820", Offset = "0x6B0620", VA = "0x1806B1820")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000BE")]
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
