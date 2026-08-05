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
using Microsoft.CodeAnalysis;
using RecRoom.Attributes;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7DEB30", Offset = "0x7DDD30", VA = "0x1807DEB30")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x61C1CA0", Offset = "0x61C0EA0", VA = "0x1861C1CA0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7DF880", Offset = "0x7DEA80", VA = "0x1807DF880")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7DF8C0", Offset = "0x7DEAC0", VA = "0x1807DF8C0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class IAKGLKIJFPB : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7C4110", Offset = "0x7C3310", VA = "0x1807C4110")]
	public IAKGLKIJFPB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, HFPIHMCNNKJ, EKDGCJOEMJL, ISerializationCallbackReceiver
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[SerializeField]
	private byte[] stableHash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	private byte[] seed;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public byte[] StableHash
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7B6290", Offset = "0x7B5490", VA = "0x1807B6290", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7B9960", Offset = "0x7B8B60", VA = "0x1807B9960", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7B84D0", Offset = "0x7B76D0", VA = "0x1807B84D0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x81F220", Offset = "0x81E420", VA = "0x18081F220", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash LNOOCJJIMOE);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x89ADA0", Offset = "0x899FA0", VA = "0x18089ADA0")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[ReadOnlyField]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[ReadOnlyField]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x61C3360", Offset = "0x61C2560", VA = "0x1861C3360")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x61C3320", Offset = "0x61C2520", VA = "0x1861C3320")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x61C33A0", Offset = "0x61C25A0", VA = "0x1861C33A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x61C3550", Offset = "0x61C2750", VA = "0x1861C3550")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x61C34C0", Offset = "0x61C26C0", VA = "0x1861C34C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x94A870", Offset = "0x949A70", VA = "0x18094A870")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA03990", Offset = "0xA02B90", VA = "0x180A03990")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x61C32E0", Offset = "0x61C24E0", VA = "0x1861C32E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x61C3430", Offset = "0x61C2630", VA = "0x1861C3430")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x61C2D50", Offset = "0x61C1F50", VA = "0x1861C2D50")]
	public void CopyBounds(SavedExtents NOBJAPGNDAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x61C3230", Offset = "0x61C2430", VA = "0x1861C3230")]
	public void SetLocalSpaceBounds(Bounds HPGJHNNJPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA3F850", Offset = "0xA3EA50", VA = "0x180A3F850")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x61C3220", Offset = "0x61C2420", VA = "0x1861C3220")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x61C2E40", Offset = "0x61C2040", VA = "0x1861C2E40")]
	private void KMHOGNDDOFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x61C3000", Offset = "0x61C2200", VA = "0x1861C3000")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x61C2710", Offset = "0x61C1910", VA = "0x1861C2710")]
	public static void CalculateLocalBoundsFor(GameObject OPEBICILKJE, [Out] Bounds HPGJHNNJPBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x61C2D80", Offset = "0x61C1F80", VA = "0x1861C2D80")]
	private static void KABIIPJLMOF(Bounds HGMCBKHHGFH, Color MOAAELBABJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x61C3250", Offset = "0x61C2450", VA = "0x1861C3250")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7B3110", Offset = "0x7B2310", VA = "0x1807B3110")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7B9910", Offset = "0x7B8B10", VA = "0x1807B9910")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xE809B0", Offset = "0xE7FBB0", VA = "0x180E809B0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x443D0E0", Offset = "0x443C2E0", VA = "0x18443D0E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "4")]
	public virtual void DIDHNICJJNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[IAKGLKIJFPB]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x443CD10", Offset = "0x443BF10", VA = "0x18443CD10", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x443BB00", Offset = "0x443AD00", VA = "0x18443BB00", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x443D020", Offset = "0x443C220", VA = "0x18443D020")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class JLDCMPGFCJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public JLDCMPGFCJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3C29D50", Offset = "0x3C28F50", VA = "0x183C29D50")]
		internal int BAMFKCGFDFN(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[IAKGLKIJFPB]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x34B0B90", Offset = "0x34AFD90", VA = "0x1834B0B90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x34B0BD0", Offset = "0x34AFDD0", VA = "0x1834B0BD0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x34B0AB0", Offset = "0x34AFCB0", VA = "0x1834B0AB0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey GOBGGNLGONA]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x34B0B30", Offset = "0x34AFD30", VA = "0x1834B0B30", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x34B09B0", Offset = "0x34AFBB0", VA = "0x1834B09B0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x34B0700", Offset = "0x34AF900", VA = "0x1834B0700", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x34AFC40", Offset = "0x34AEE40", VA = "0x1834AFC40", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x34AFBE0", Offset = "0x34AEDE0", VA = "0x1834AFBE0", Slot = "14")]
	protected virtual string HGNJEGDNJPF(TKeyVal JMPHEPIPJAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x34AFAD0", Offset = "0x34AECD0", VA = "0x1834AFAD0", Slot = "4")]
	public bool ContainsKey(TKey GOBGGNLGONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x34B0880", Offset = "0x34AFA80", VA = "0x1834B0880", Slot = "5")]
	public bool TryGetValue(TKey GOBGGNLGONA, [Out] TVal NICEPFIEJED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x34AFB10", Offset = "0x34AED10", VA = "0x1834AFB10", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x34AFB10", Offset = "0x34AED10", VA = "0x1834AFB10", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x34B08C0", Offset = "0x34AFAC0", VA = "0x1834B08C0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class IDPCILHPAEH<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class ODCDKGPMFJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public float PFCEOFNNDAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public T FJJHODHBEGH;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public ODCDKGPMFJA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class NPGBEPFAJOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public NPGBEPFAJOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4084A60", Offset = "0x4083C60", VA = "0x184084A60")]
		internal bool GNMMEMKCBGI(ODCDKGPMFJA sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly float GEAGCDKBHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly float LBLGKFAOCIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<ODCDKGPMFJA> BFNEOKOCLNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private GHBMIANENLM<ODCDKGPMFJA> MALAKBCEBNG;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int POPAMHFGHEB
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3A3B750", Offset = "0x3A3A950", VA = "0x183A3B750")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3A3B7C0", Offset = "0x3A3A9C0", VA = "0x183A3B7C0")]
	public IDPCILHPAEH(float MJKBMCKDEEL, float JFBJDNIBEGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3A3B3B0", Offset = "0x3A3A5B0", VA = "0x183A3B3B0")]
	public bool LGGIDKNAAFE(float HOGBMKKOGBI, T NICEPFIEJED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3A3B0D0", Offset = "0x3A3A2D0", VA = "0x183A3B0D0")]
	public IEnumerable<T> KCIGICCJPEA(float HOGBMKKOGBI, [Optional] float? NOFBPBJDCFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3A3B680", Offset = "0x3A3A880", VA = "0x183A3B680")]
	public void NDGKPACNNFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3A3ACB0", Offset = "0x3A39EB0", VA = "0x183A3ACB0")]
	private void JIDMFOHEABN(float HOGBMKKOGBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class DKPAPOCBKAG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct JFOGACNGHMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public T FJJHODHBEGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public float LKDHPLDPOFE;
	}

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static float LIJCKAGLDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private List<T> IJIAFFFEDJE;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private const int DPJOGOGINPJ = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private JFOGACNGHMF[] GEHAOEPMDJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int OIOEKHNJOEM;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float BFLLOFIPJGM
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x85FFA0", Offset = "0x85F1A0", VA = "0x18085FFA0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x862100", Offset = "0x861300", VA = "0x180862100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x512E460", Offset = "0x512D660", VA = "0x18512E460")]
	public DKPAPOCBKAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x512E370", Offset = "0x512D570", VA = "0x18512E370")]
	public DKPAPOCBKAG(int MKJBDDDPMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x512E260", Offset = "0x512D460", VA = "0x18512E260")]
	public void OEOPOJPHCNL(float HOGBMKKOGBI, T NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x512DFD0", Offset = "0x512D1D0", VA = "0x18512DFD0")]
	public void NDGKPACNNFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x512D550", Offset = "0x512C750", VA = "0x18512D550")]
	public bool ALACLDMEJOF(float BNADALKONFJ, float BPMJPKKNCCP, [Out] T NICEPFIEJED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x512DC30", Offset = "0x512CE30", VA = "0x18512DC30")]
	public bool INALNGMEBAP(float BNADALKONFJ, float BPMJPKKNCCP, [Out] T NICEPFIEJED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x512D9C0", Offset = "0x512CBC0", VA = "0x18512D9C0")]
	public void FDOGNJFIHPP(float BNADALKONFJ, float BPMJPKKNCCP, List<T> BCDEBAAMJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x512D990", Offset = "0x512CB90", VA = "0x18512D990")]
	private int ECLJBEKLAPD(int PPPGKPDDOPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x512DF90", Offset = "0x512D190", VA = "0x18512DF90")]
	private void MOELHLFJFEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T HNMBGJDIJEP();

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T NJIHDCBLLBN(T NICEPFIEJED, float MOAGOANMCEN);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T HJGJBMGPLJO(T EFLJLNCMHDD, T DJDKOLONKNI);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T FDCMFNJHBPN(T EFLJLNCMHDD, T DJDKOLONKNI);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class OLCOGANEMNM : DKPAPOCBKAG<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7C49A0", Offset = "0x7C3BA0", VA = "0x1807C49A0", Slot = "4")]
	protected override Vector3 HNMBGJDIJEP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x61C1F30", Offset = "0x61C1130", VA = "0x1861C1F30", Slot = "5")]
	protected override Vector3 NJIHDCBLLBN(Vector3 NICEPFIEJED, float MOAGOANMCEN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x61C1EE0", Offset = "0x61C10E0", VA = "0x1861C1EE0", Slot = "6")]
	protected override Vector3 HJGJBMGPLJO(Vector3 EFLJLNCMHDD, Vector3 DJDKOLONKNI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x61C1E60", Offset = "0x61C1060", VA = "0x1861C1E60", Slot = "7")]
	protected override Vector3 FDCMFNJHBPN(Vector3 EFLJLNCMHDD, Vector3 DJDKOLONKNI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x61C1F70", Offset = "0x61C1170", VA = "0x1861C1F70")]
	public OLCOGANEMNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class CMPPIGIKKBD
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x271E5C0", Offset = "0x271D7C0", VA = "0x18271E5C0")]
	public static JKALCKGLJHM<T1, T2> LAFNMEJJDLL<T1, T2>(T1 MAEPKJNOPDD, T2 DPDHAFBBJBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x271E640", Offset = "0x271D840", VA = "0x18271E640")]
	public static JOIDLLLJEKC<T1, T2, T3> LAFNMEJJDLL<T1, T2, T3>(T1 MAEPKJNOPDD, T2 DPDHAFBBJBN, T3 BFELPPPNPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3FD3700", Offset = "0x3FD2900", VA = "0x183FD3700")]
	internal static int NNOLAEMHFBF(int IDOGPIEMHFK, int EKIADLAEEPE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x55CF450", Offset = "0x55CE650", VA = "0x1855CF450")]
	internal static int NNOLAEMHFBF(int IDOGPIEMHFK, int EKIADLAEEPE, int JBALIGJADNL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class JKALCKGLJHM<T1, T2> : IComparable<JKALCKGLJHM<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly T1 PFCPBEKJABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly T2 IBANIIMOACA;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3C29750", Offset = "0x3C28950", VA = "0x183C29750")]
	public JKALCKGLJHM(T1 MAEPKJNOPDD, T2 DPDHAFBBJBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3C280D0", Offset = "0x3C272D0", VA = "0x183C280D0", Slot = "4")]
	public int CompareTo(JKALCKGLJHM<T1, T2> NOBJAPGNDAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3C28710", Offset = "0x3C27910", VA = "0x183C28710", Slot = "0")]
	public override bool Equals(object NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3C28BA0", Offset = "0x3C27DA0", VA = "0x183C28BA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3C28E50", Offset = "0x3C28050", VA = "0x183C28E50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class JOIDLLLJEKC<T1, T2, T3> : IComparable<JOIDLLLJEKC<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly T1 PFCPBEKJABP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly T2 IBANIIMOACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly T3 FNMPNJDPFFD;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3C34760", Offset = "0x3C33960", VA = "0x183C34760")]
	public JOIDLLLJEKC(T1 MAEPKJNOPDD, T2 DPDHAFBBJBN, T3 BFELPPPNPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3C33E80", Offset = "0x3C33080", VA = "0x183C33E80", Slot = "4")]
	public int CompareTo(JOIDLLLJEKC<T1, T2, T3> NOBJAPGNDAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3C341E0", Offset = "0x3C333E0", VA = "0x183C341E0", Slot = "0")]
	public override bool Equals(object NOBJAPGNDAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3C34400", Offset = "0x3C33600", VA = "0x183C34400", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3C344A0", Offset = "0x3C336A0", VA = "0x183C344A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T FJJHODHBEGH
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2195B90", Offset = "0x2194D90", VA = "0x182195B90")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2195A40", Offset = "0x2194C40", VA = "0x182195A40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float MJCGHPCGJDK
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x89ED90", Offset = "0x89DF90", VA = "0x18089ED90")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x462E640", Offset = "0x462D840", VA = "0x18462E640")]
	public T LCOJKGOAJHP(float MOAGOANMCEN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x462E3C0", Offset = "0x462D5C0", VA = "0x18462E3C0")]
	public T KENIAHNLNLA(float MOAGOANMCEN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T OHPMGLCLBID(T EFLJLNCMHDD, T DJDKOLONKNI, float MOAGOANMCEN);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x61C0870", Offset = "0x61BFA70", VA = "0x1861C0870", Slot = "4")]
	protected override float OHPMGLCLBID(float EFLJLNCMHDD, float DJDKOLONKNI, float MOAGOANMCEN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x61C08B0", Offset = "0x61BFAB0", VA = "0x1861C08B0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xD071D0", Offset = "0xD063D0", VA = "0x180D071D0", Slot = "4")]
	protected override Vector3 OHPMGLCLBID(Vector3 EFLJLNCMHDD, Vector3 DJDKOLONKNI, float MOAGOANMCEN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x61C4250", Offset = "0x61C3450", VA = "0x1861C4250")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x61BF0B0", Offset = "0x61BE2B0", VA = "0x1861BF0B0", Slot = "4")]
	protected override Color OHPMGLCLBID(Color EFLJLNCMHDD, Color DJDKOLONKNI, float MOAGOANMCEN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x61BF170", Offset = "0x61BE370", VA = "0x1861BF170")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class BJNFAIMMNHG : LDCIELNJEIC<string>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x61BEEA0", Offset = "0x61BE0A0", VA = "0x1861BEEA0")]
	public BJNFAIMMNHG(int DIHLAEIGMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x61BEE30", Offset = "0x61BE030", VA = "0x1861BEE30", Slot = "6")]
	protected override uint PNOLNLEHKFG(uint LNOOCJJIMOE, string NICEPFIEJED)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class GIFENBFLCDO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly IDisposable KMGHIJMKCHH;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	public GIFENBFLCDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct FAANGALDPCG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> PHJHLFCDKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int KGJAPGILPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int OMJNCLDPCLD;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x37D35A0", Offset = "0x37D27A0", VA = "0x1837D35A0")]
	private FAANGALDPCG(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> NFDLEFCCCNO, int LAJPMHGDDPN, int CFBKFFNGANL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x37D34B0", Offset = "0x37D26B0", VA = "0x1837D34B0")]
	public static FAANGALDPCG<T> MIJABIECKKD()
	{
		return default(FAANGALDPCG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x37D20F0", Offset = "0x37D12F0", VA = "0x1837D20F0")]
	public (int, int, Task<T>) AOMNEIFILJP(int BMIJGDHAHBI, [Optional] CancellationToken AIHJHMPAHCH, double IJJNDFLLAHB = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x37D2FC0", Offset = "0x37D21C0", VA = "0x1837D2FC0")]
	public void JBEJDMNEDHG(int BMIJGDHAHBI, int CFBKFFNGANL, [In] T HCIDHCBMOPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class KABKMAKNIBF
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x61C1A10", Offset = "0x61C0C10", VA = "0x1861C1A10")]
	public static FAANGALDPCG<LKEAICJEMFK> MIJABIECKKD()
	{
		return default(FAANGALDPCG<LKEAICJEMFK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x61C1990", Offset = "0x61C0B90", VA = "0x1861C1990")]
	public static void JBEJDMNEDHG([In] this FAANGALDPCG<LKEAICJEMFK> KNKOEEEKHDK, int BMIJGDHAHBI, int CFBKFFNGANL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class FDIAKNNBCDL<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<TKey, TVal> KONPJBNOIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly Dictionary<TVal, TKey> JFCHICDABON;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int PIKJCOKEANP
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3287A60", Offset = "0x3286C60", VA = "0x183287A60", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool EABCDIJODPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ICollection<TKey> EIAJNMLLEND
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x37F6400", Offset = "0x37F5600", VA = "0x1837F6400", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> FPJNCEHDNAP
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x37F6440", Offset = "0x37F5640", VA = "0x1837F6440", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal HEPLFNAANJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x37F63A0", Offset = "0x37F55A0", VA = "0x1837F63A0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x37F64A0", Offset = "0x37F56A0", VA = "0x1837F64A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey HEPLFNAANJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x37F5D30", Offset = "0x37F4F30", VA = "0x1837F5D30")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x37F5900", Offset = "0x37F4B00", VA = "0x1837F5900", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x37F6140", Offset = "0x37F5340", VA = "0x1837F6140", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x37F56F0", Offset = "0x37F48F0", VA = "0x1837F56F0", Slot = "9")]
	public void Add(TKey GOBGGNLGONA, TVal NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x37F56A0", Offset = "0x37F48A0", VA = "0x1837F56A0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> DMLEKJCHBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x37F5960", Offset = "0x37F4B60", VA = "0x1837F5960", Slot = "8")]
	public bool ContainsKey(TKey GOBGGNLGONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x37F59A0", Offset = "0x37F4BA0", VA = "0x1837F59A0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> DMLEKJCHBDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x37F60C0", Offset = "0x37F52C0", VA = "0x1837F60C0", Slot = "10")]
	public bool Remove(TKey GOBGGNLGONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x37F6110", Offset = "0x37F5310", VA = "0x1837F6110", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> DMLEKJCHBDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x37F6230", Offset = "0x37F5430", VA = "0x1837F6230", Slot = "11")]
	public bool TryGetValue(TKey GOBGGNLGONA, [Out] TVal NICEPFIEJED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x37F5E00", Offset = "0x37F5000", VA = "0x1837F5E00", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x37F5A20", Offset = "0x37F4C20", VA = "0x1837F5A20", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] GEHAOEPMDJB, int NENFDGMLFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x37F6070", Offset = "0x37F5270", VA = "0x1837F6070")]
	public bool PEFGNEHBCPG(TVal GOBGGNLGONA, [Out] TKey NICEPFIEJED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x37F57E0", Offset = "0x37F49E0", VA = "0x1837F57E0")]
	private void COJADFKDMKO(TKey GOBGGNLGONA, TVal LJPPKNAEGOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x37F5E90", Offset = "0x37F5090", VA = "0x1837F5E90")]
	private void LPGJKKPJLKL(TKey GOBGGNLGONA, TVal LJPPKNAEGOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x37F5C20", Offset = "0x37F4E20", VA = "0x1837F5C20")]
	private bool FFKLEGDPMKI(TKey GOBGGNLGONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x37F6270", Offset = "0x37F5470", VA = "0x1837F6270")]
	public FDIAKNNBCDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[DefaultMember("Item")]
public class EEMAMNGLNGM<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private EEMAMNGLNGM<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x34F7810", Offset = "0x34F6A10", VA = "0x1834F7810", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x3508F50", Offset = "0x3508150", VA = "0x183508F50", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3509D90", Offset = "0x3508F90", VA = "0x183509D90")]
		public Enumerator(EEMAMNGLNGM<T> BCDEBAAMJOP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x35077D0", Offset = "0x35069D0", VA = "0x1835077D0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x3508460", Offset = "0x3507660", VA = "0x183508460", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x3506620", Offset = "0x3505820", VA = "0x183506620")]
		private void FMHCDECBBFM()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private T[] EGFAOPNPDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private int LCKACGDGBMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int HGIEKMMOBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int LOGOABBJBAN;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int PIKJCOKEANP
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3464CE0", Offset = "0x3463EE0", VA = "0x183464CE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T HEPLFNAANJH
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3464B70", Offset = "0x3463D70", VA = "0x183464B70")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x3464FC0", Offset = "0x34641C0", VA = "0x183464FC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3465940", Offset = "0x3464B40", VA = "0x183465940")]
	public EEMAMNGLNGM(int DIHLAEIGMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3465570", Offset = "0x3464770", VA = "0x183465570")]
	public void OEOPOJPHCNL(T MOAGOANMCEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3464D50", Offset = "0x3463F50", VA = "0x183464D50")]
	public void NDGKPACNNFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3464C40", Offset = "0x3463E40", VA = "0x183464C40")]
	public void GHPCMALAODE(int KIGJDGACGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3463E00", Offset = "0x3463000", VA = "0x183463E00")]
	public void CCAMFGMMEBE(T[] GEHAOEPMDJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3465120", Offset = "0x3464320", VA = "0x183465120")]
	public Enumerator ODDJKKOCOEI()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x34657E0", Offset = "0x34649E0", VA = "0x1834657E0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x34657E0", Offset = "0x34649E0", VA = "0x1834657E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x34645C0", Offset = "0x34637C0", VA = "0x1834645C0")]
	private int FICMBGIMBIP(int HMFNCGHECPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3464D20", Offset = "0x3463F20", VA = "0x183464D20")]
	private int KAGIGLHNFMA(int HMFNCGHECPG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class AEKLEFMOAPE<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate Task<TResult> KIPNAAKNAKK(TRequest AIJPHINHCJO, CancellationToken AIHJHMPAHCH);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public enum ONPLLDGEFMD
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class BFMNJMPFECM
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private const float COJBIMPGIAF = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TimeSpan LBADDHKHPDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int PHAINAPHJHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public ONPLLDGEFMD LPNDPNIJEIO;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static readonly BFMNJMPFECM CGCFGJJDBDI;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float NLMONEHIDAK
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x4897A80", Offset = "0x4896C80", VA = "0x184897A80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public TimeSpan KJEOADDFGFB
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x4897CB0", Offset = "0x4896EB0", VA = "0x184897CB0")]
		public BFMNJMPFECM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private readonly struct OCAGIBEOMNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly TRequest AIJPHINHCJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly CancellationToken AIHJHMPAHCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly TaskCompletionSource<TResult> AFOILHIOOGC;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x412EDE0", Offset = "0x412DFE0", VA = "0x18412EDE0")]
		public OCAGIBEOMNG(TRequest AIJPHINHCJO, TaskCompletionSource<TResult> AFOILHIOOGC, CancellationToken AIHJHMPAHCH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct KGPLNAMHJGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AEKLEFMOAPE<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3C922D0", Offset = "0x3C914D0", VA = "0x183C922D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x3C92A50", Offset = "0x3C91C50", VA = "0x183C92A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct MIFBGJBIGHJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public AEKLEFMOAPE<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private OCAGIBEOMNG <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x3F5E6A0", Offset = "0x3F5D8A0", VA = "0x183F5E6A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x3F5EC10", Offset = "0x3F5DE10", VA = "0x183F5EC10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly CancellationTokenSource BHHLNEGICIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly List<OCAGIBEOMNG> NJNBHNOBJDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly BFMNJMPFECM DPHADMNANEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly KIPNAAKNAKK HDLGEBNOMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Task PLMMKEDFCCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private int NCNLKILAPFA;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x388BB60", Offset = "0x388AD60", VA = "0x18388BB60")]
	public AEKLEFMOAPE(KIPNAAKNAKK HDLGEBNOMOG, [Optional] BFMNJMPFECM DPHADMNANEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x388A7C0", Offset = "0x38899C0", VA = "0x18388A7C0")]
	public Task<TResult> FAHGCIDCMJH(TRequest AIJPHINHCJO, CancellationToken AIHJHMPAHCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x388A500", Offset = "0x3889700", VA = "0x18388A500")]
	private void CJJJMBNEJOG(OCAGIBEOMNG ALICLLJPJAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x388B340", Offset = "0x388A540", VA = "0x18388B340")]
	[AsyncStateMachine(typeof(AEKLEFMOAPE<, >.KGPLNAMHJGJ))]
	private Task LPLOAEHBAAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x388ABD0", Offset = "0x3889DD0", VA = "0x18388ABD0")]
	private OCAGIBEOMNG HOINOEOCJMJ()
	{
		return default(OCAGIBEOMNG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x388A2D0", Offset = "0x38894D0", VA = "0x18388A2D0")]
	[AsyncStateMachine(typeof(AEKLEFMOAPE<, >.MIFBGJBIGHJ))]
	private Task CJCLODNLDNG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x388B790", Offset = "0x388A990", VA = "0x18388B790")]
	private void NHCHHPCONID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x388A590", Offset = "0x3889790", VA = "0x18388A590", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class ICEJALCNEDD<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly List<T> JLCIFHJMGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private HashSet<T> CKBLHLKNOID;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int PIKJCOKEANP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3287A60", Offset = "0x3286C60", VA = "0x183287A60", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool EABCDIJODPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7FD130", Offset = "0x7FC330", VA = "0x1807FD130", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public T HEPLFNAANJH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3A36130", Offset = "0x3A35330", VA = "0x183A36130", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3A36170", Offset = "0x3A35370", VA = "0x183A36170", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x37FE160", Offset = "0x37FD360", VA = "0x1837FE160", Slot = "11")]
	public void Add(T DMLEKJCHBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3A35CB0", Offset = "0x3A34EB0", VA = "0x183A35CB0")]
	public bool PBCOJKEDMAJ(T DMLEKJCHBDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3A35F20", Offset = "0x3A35120", VA = "0x183A35F20", Slot = "15")]
	public bool Remove(T DMLEKJCHBDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3A359A0", Offset = "0x3A34BA0", VA = "0x183A359A0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x384EB70", Offset = "0x384DD70", VA = "0x18384EB70", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3A358D0", Offset = "0x3A34AD0", VA = "0x183A358D0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3A35930", Offset = "0x3A34B30", VA = "0x183A35930", Slot = "13")]
	public bool Contains(T DMLEKJCHBDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3A35970", Offset = "0x3A34B70", VA = "0x183A35970", Slot = "14")]
	public void CopyTo(T[] GEHAOEPMDJB, int NENFDGMLFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3A35A20", Offset = "0x3A34C20", VA = "0x183A35A20", Slot = "6")]
	public int IndexOf(T DMLEKJCHBDC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3A35B30", Offset = "0x3A34D30", VA = "0x183A35B30", Slot = "7")]
	public void Insert(int HMFNCGHECPG, T DMLEKJCHBDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3A35E40", Offset = "0x3A35040", VA = "0x183A35E40", Slot = "8")]
	public void RemoveAt(int HMFNCGHECPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3A36040", Offset = "0x3A35240", VA = "0x183A36040")]
	public ICEJALCNEDD()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x2012BA0", Offset = "0x2011DA0", VA = "0x182012BA0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x61C38F0", Offset = "0x61C2AF0", VA = "0x1861C38F0")]
		public SerializedGuid([In] Guid IKOKEKHMFKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x61C3610", Offset = "0x61C2810", VA = "0x1861C3610")]
		public static SerializedGuid DBELIIMMINF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x61C3690", Offset = "0x61C2890", VA = "0x1861C3690")]
		public static SerializedGuid DKLLJBAOGAA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x61C3890", Offset = "0x61C2A90", VA = "0x1861C3890")]
		public bool PPFMDOGEELH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x61C3860", Offset = "0x61C2A60", VA = "0x1861C3860", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x61C37E0", Offset = "0x61C29E0", VA = "0x1861C37E0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x61C3700", Offset = "0x61C2900", VA = "0x1861C3700", Slot = "7")]
		public bool Equals(SerializedGuid NOBJAPGNDAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x61C3740", Offset = "0x61C2940", VA = "0x1861C3740", Slot = "0")]
		public override bool Equals(object JFJMICPDNDH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x61C37D0", Offset = "0x61C29D0", VA = "0x1861C37D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x61C35E0", Offset = "0x61C27E0", VA = "0x1861C35E0", Slot = "6")]
		public int CompareTo(SerializedGuid NOBJAPGNDAK)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class DAMOPIACLGC : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly Type MEOJLCLMGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly string IJLNODJOOMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool BPEFGFGGMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool FAEIIOIEJDH;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x61BF1B0", Offset = "0x61BE3B0", VA = "0x1861BF1B0")]
	public DAMOPIACLGC(Type GPNHEAICDPB, string OAKBEEPHIBK, bool JAJJBADPECG = false, bool JCDEFEBLLAB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class OPAMPAFNBOH<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public readonly struct DOJKMOJNLEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly long DPODLCOCCFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly long HDIMFIDANBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly int CENFHJDDCLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly int NKAELBIOFJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly bool JPGIBHLLKME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly string GOLJDKGAFNA;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5139310", Offset = "0x5138510", VA = "0x185139310")]
		public DOJKMOJNLEB(long DPODLCOCCFN, int CENFHJDDCLK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x51392E0", Offset = "0x51384E0", VA = "0x1851392E0")]
		public DOJKMOJNLEB(long DPODLCOCCFN, long HDIMFIDANBL, int CENFHJDDCLK, int NKAELBIOFJN, bool JPGIBHLLKME, string GOLJDKGAFNA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x5139290", Offset = "0x5138490", VA = "0x185139290")]
		public int HMKAHAAFBKJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5139270", Offset = "0x5138470", VA = "0x185139270")]
		public int DKHOHCMFIGJ(int AMDPAHDEKFF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5139170", Offset = "0x5138370", VA = "0x185139170")]
		public double AHCCJJKKOIB()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x51391D0", Offset = "0x51383D0", VA = "0x1851391D0")]
		public DOJKMOJNLEB BFDFHBNOEBC(long HDIMFIDANBL, int NKAELBIOFJN)
		{
			return default(DOJKMOJNLEB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class GMFJCEOBAKO : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private struct DOCGMBCGBMD<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public GMFJCEOBAKO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Func<GMFJCEOBAKO, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private GMFJCEOBAKO <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x5138C80", Offset = "0x5137E80", VA = "0x185138C80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x3A0ED20", Offset = "0x3A0DF20", VA = "0x183A0ED20", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly TKey OGJDOBGGLGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly OPAMPAFNBOH<TKey> NEKANGAICOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly JJNHGMIGPBK OMJOPGOBIEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private List<GMFJCEOBAKO> NLMLEPNMMMB;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public string ANBDFBNGEJE
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x38C6D20", Offset = "0x38C5F20", VA = "0x1838C6D20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public IEnumerable<GMFJCEOBAKO> JHNAJOHIHFJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x38C6B80", Offset = "0x38C5D80", VA = "0x1838C6B80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public DOJKMOJNLEB GJGBPFGOIJB
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x38C6D00", Offset = "0x38C5F00", VA = "0x1838C6D00")]
			[CompilerGenerated]
			get
			{
				return default(DOJKMOJNLEB);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x38C6D50", Offset = "0x38C5F50", VA = "0x1838C6D50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x38C6D80", Offset = "0x38C5F80", VA = "0x1838C6D80")]
		internal GMFJCEOBAKO(OPAMPAFNBOH<TKey> NEKANGAICOD, TKey GOBGGNLGONA, JJNHGMIGPBK OMJOPGOBIEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x38C6BB0", Offset = "0x38C5DB0", VA = "0x1838C6BB0")]
		public GMFJCEOBAKO FHCMFCPGGEK(TKey GOBGGNLGONA, [Optional] JJNHGMIGPBK? NKFBPINLDOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x257BFB0", Offset = "0x257B1B0", VA = "0x18257BFB0")]
		[AsyncStateMachine(typeof(DOCGMBCGBMD<>))]
		public Task<T> PNDOBGJBHIG<T>(TKey GOBGGNLGONA, Func<GMFJCEOBAKO, Task<T>> MGNENKLDBLN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x38C69A0", Offset = "0x38C5BA0", VA = "0x1838C69A0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class NGMJMGGODII : IEnumerable<(TKey, List<TKey>, DOJKMOJNLEB)>, IEnumerable, IEnumerator<(TKey, List<TKey>, DOJKMOJNLEB)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private (TKey key, List<TKey> path, DOJKMOJNLEB timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public OPAMPAFNBOH<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IEnumerator<(TKey key, List<TKey> path, DOJKMOJNLEB timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private (TKey, List<TKey>, DOJKMOJNLEB) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x2017F20", Offset = "0x2017120", VA = "0x182017F20", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, DOJKMOJNLEB));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x4040E60", Offset = "0x4040060", VA = "0x184040E60", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2018010", Offset = "0x2017210", VA = "0x182018010")]
		[DebuggerHidden]
		public NGMJMGGODII(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x37E03F0", Offset = "0x37DF5F0", VA = "0x1837E03F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x40409D0", Offset = "0x403FBD0", VA = "0x1840409D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4040980", Offset = "0x403FB80", VA = "0x184040980")]
		private void IDEOPKLEDEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4040E10", Offset = "0x4040010", VA = "0x184040E10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x4040D50", Offset = "0x403FF50", VA = "0x184040D50", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, DOJKMOJNLEB)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x37E8240", Offset = "0x37E7440", VA = "0x1837E8240", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class KICEFNIGLHI : IEnumerable<(TKey, List<TKey>, DOJKMOJNLEB)>, IEnumerable, IEnumerator<(TKey, List<TKey>, DOJKMOJNLEB)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private (TKey key, List<TKey> path, DOJKMOJNLEB timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private GMFJCEOBAKO timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public GMFJCEOBAKO <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public OPAMPAFNBOH<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private IEnumerator<GMFJCEOBAKO> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private IEnumerator<(TKey key, List<TKey> path, DOJKMOJNLEB timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, DOJKMOJNLEB) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x2017F20", Offset = "0x2017120", VA = "0x182017F20", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, DOJKMOJNLEB));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x3C949B0", Offset = "0x3C93BB0", VA = "0x183C949B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2018010", Offset = "0x2017210", VA = "0x182018010")]
		[DebuggerHidden]
		public KICEFNIGLHI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3C94A10", Offset = "0x3C93C10", VA = "0x183C94A10", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3C94090", Offset = "0x3C93290", VA = "0x183C94090", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3C94030", Offset = "0x3C93230", VA = "0x183C94030")]
		private void IDEOPKLEDEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3C947F0", Offset = "0x3C939F0", VA = "0x183C947F0")]
		private void OFANLJKOCDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3C94960", Offset = "0x3C93B60", VA = "0x183C94960", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3C94850", Offset = "0x3C93A50", VA = "0x183C94850", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, DOJKMOJNLEB)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x3C94930", Offset = "0x3C93B30", VA = "0x183C94930", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly Action<TKey, DOJKMOJNLEB, JJNHGMIGPBK> OHNOFNPECLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Action<TKey, DOJKMOJNLEB, JJNHGMIGPBK> CIDAJLBDBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly Action<OPAMPAFNBOH<TKey>, JJNHGMIGPBK> ONMAGGHNFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly JJNHGMIGPBK OMJOPGOBIEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly GMFJCEOBAKO LKDIDNCGFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private bool HBNMNOFGLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int BKJACKNGPBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly Stopwatch IFGMPBFMODD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly int EHJGMKBGANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string KNFELCBHFIJ;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public GMFJCEOBAKO PJHJKINFMMI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	[NotNull]
	public string ANBDFBNGEJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7B8D00", Offset = "0x7B7F00", VA = "0x1807B8D00")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x41CBB80", Offset = "0x41CAD80", VA = "0x1841CBB80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x41CBC60", Offset = "0x41CAE60", VA = "0x1841CBC60")]
	public OPAMPAFNBOH(TKey FKEFBGOKEDK, JJNHGMIGPBK OMJOPGOBIEL, [Optional] int? CENFHJDDCLK, [Optional][CanBeNull] Stopwatch IFGMPBFMODD, [Optional] Action<TKey, DOJKMOJNLEB, JJNHGMIGPBK> OHNOFNPECLN, [Optional] Action<TKey, DOJKMOJNLEB, JJNHGMIGPBK> CIDAJLBDBBO, [Optional] Action<OPAMPAFNBOH<TKey>, JJNHGMIGPBK> ONMAGGHNFDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x41CBAF0", Offset = "0x41CACF0", VA = "0x1841CBAF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x41CB990", Offset = "0x41CAB90", VA = "0x1841CB990")]
	[IteratorStateMachine(typeof(OPAMPAFNBOH<>.NGMJMGGODII))]
	public IEnumerable<(TKey, List<TKey>, DOJKMOJNLEB)> AKGLOICGNLK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x41CBA20", Offset = "0x41CAC20", VA = "0x1841CBA20")]
	[IteratorStateMachine(typeof(OPAMPAFNBOH<>.KICEFNIGLHI))]
	private IEnumerable<(TKey, List<TKey>, DOJKMOJNLEB)> AKGLOICGNLK(List<TKey> INJNFIJDPLP, GMFJCEOBAKO JFKCIBICPHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x41CBBE0", Offset = "0x41CADE0", VA = "0x1841CBBE0")]
	private (long, int) KHEHPLKGJJB()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public abstract class FCKDOOMANFN<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut IJMBJHAEDKN(OPAMPAFNBOH<TKey> NEKANGAICOD);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	protected FCKDOOMANFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public abstract class FEOPHHHNOBM<TKey> : FCKDOOMANFN<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate string GJFCPFAPAJM(TKey GOBGGNLGONA);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x37FA0F0", Offset = "0x37F92F0", VA = "0x1837FA0F0")]
	private static string GMEPOHENAGP(TKey GOBGGNLGONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x37FA270", Offset = "0x37F9470", VA = "0x1837FA270", Slot = "4")]
	public override string IJMBJHAEDKN(OPAMPAFNBOH<TKey> NEKANGAICOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x37FA130", Offset = "0x37F9330", VA = "0x1837FA130")]
	public string IJMBJHAEDKN(OPAMPAFNBOH<TKey> NEKANGAICOD, [NotNull] GJFCPFAPAJM DBPAOANMNLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string FBHDALBCAML(OPAMPAFNBOH<TKey> NEKANGAICOD, [NotNull] GJFCPFAPAJM DBPAOANMNLA);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x37FA320", Offset = "0x37F9520", VA = "0x1837FA320")]
	protected FEOPHHHNOBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class FJLGGCCEJAK<TKey> : FCKDOOMANFN<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public delegate string JDNGLIFDHNB(TKey GOBGGNLGONA);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly string EMFDPDCDIIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly double HMPENJNBLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly bool JNCPMAJOAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly int CGJDLNLAPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly ISet<string> PHNDJHHJKPA;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3805A90", Offset = "0x3804C90", VA = "0x183805A90")]
	private static string GMEPOHENAGP(TKey GOBGGNLGONA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3806580", Offset = "0x3805780", VA = "0x183806580")]
	public FJLGGCCEJAK(string EMFDPDCDIIC = "F2", double HMPENJNBLPH = double.MaxValue, bool JNCPMAJOAPF = false, int CGJDLNLAPGC = int.MaxValue, [Optional] ISet<string> PHNDJHHJKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3805CE0", Offset = "0x3804EE0", VA = "0x183805CE0", Slot = "4")]
	public override Dictionary<string, string> IJMBJHAEDKN(OPAMPAFNBOH<TKey> NEKANGAICOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x38064A0", Offset = "0x38056A0", VA = "0x1838064A0")]
	private bool MHDEMLOCPOH(string BGANOCMPFBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3805D90", Offset = "0x3804F90", VA = "0x183805D90")]
	public Dictionary<string, string> IJMBJHAEDKN(OPAMPAFNBOH<TKey> NEKANGAICOD, JDNGLIFDHNB DBPAOANMNLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3805AD0", Offset = "0x3804CD0", VA = "0x183805AD0")]
	private string HOHNFGCCJKG(StringBuilder OCCOABHHNAL, List<TKey> LLCLOCPMMFL, JDNGLIFDHNB DBPAOANMNLA, bool EBKFPDKDIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3806340", Offset = "0x3805540", VA = "0x183806340")]
	private static void JEIABLIGHLC(StringBuilder OJIHKKIDCHI, string FCOKBMGGIJB, bool CMIKJJJDDJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class BHPKOLJILGM<TKey> : FEOPHHHNOBM<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct CNKJOEOJLJF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public GJFCPFAPAJM keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static BHPKOLJILGM<TKey> KMGHIJMKCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly string[] LGDEHKINPCF;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x489C3A0", Offset = "0x489B5A0", VA = "0x18489C3A0")]
	private BHPKOLJILGM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x489B370", Offset = "0x489A570", VA = "0x18489B370", Slot = "5")]
	protected override string FBHDALBCAML(OPAMPAFNBOH<TKey> NEKANGAICOD, GJFCPFAPAJM DBPAOANMNLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x489C180", Offset = "0x489B380", VA = "0x18489C180")]
	[CompilerGenerated]
	internal static string OKPKOPKJMAA(string BFLKDGGFCCD, TKey GOBGGNLGONA, CNKJOEOJLJF P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class PEKCEDDILIB : OPAMPAFNBOH<string>
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class BAMFNAGHHBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Action<PEKCEDDILIB, JJNHGMIGPBK> callback;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public BAMFNAGHHBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x61BEDA0", Offset = "0x61BDFA0", VA = "0x1861BEDA0")]
		internal void HFAAPDBBIEP(OPAMPAFNBOH<string> timer, JJNHGMIGPBK log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x61C2090", Offset = "0x61C1290", VA = "0x1861C2090")]
	public PEKCEDDILIB(JJNHGMIGPBK OMJOPGOBIEL, [Optional] string ICMGFDLIOBM, [Optional] int? CENFHJDDCLK, [Optional] Stopwatch IFGMPBFMODD, [Optional] Action<string, DOJKMOJNLEB, JJNHGMIGPBK> OHNOFNPECLN, [Optional] Action<string, DOJKMOJNLEB, JJNHGMIGPBK> CIDAJLBDBBO, [Optional] Action<PEKCEDDILIB, JJNHGMIGPBK> ONMAGGHNFDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x61C1FD0", Offset = "0x61C11D0", VA = "0x1861C1FD0")]
	private static Action<OPAMPAFNBOH<string>, JJNHGMIGPBK> GIBLGELIOEM(Action<PEKCEDDILIB, JJNHGMIGPBK> IAPBAMILEGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class CNBEHLJKMKO
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private class OHKDMMFMION : CNBEHLJKMKO
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public static CNBEHLJKMKO KMGHIJMKCHH
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x61C1D20", Offset = "0x61C0F20", VA = "0x1861C1D20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override float BGAEIJEBNDN
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x8432D0", Offset = "0x8424D0", VA = "0x1808432D0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x61C1E10", Offset = "0x61C1010", VA = "0x1861C1E10")]
		public OHKDMMFMION()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static CNBEHLJKMKO CJJPGBPKNAH;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static CNBEHLJKMKO CGCFGJJDBDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x61BEF50", Offset = "0x61BE150", VA = "0x1861BEF50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public abstract float BGAEIJEBNDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
	protected CNBEHLJKMKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface JOOIKNJLOAP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool CBEJMOMNALI
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface IKCNFNMPLNN<T> : JOOIKNJLOAP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	[NotNull]
	Task<T> HHDLJJOPIDF
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	[NotNull]
	JGFOKFMCODN<T> CMPFEKILCEI
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class IOKIOFAHEMJ
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private sealed class NGHFDGNADLG<T> : GCMEMNGCFAM<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override Task<T?> HHDLJJOPIDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override JGFOKFMCODN<T?> CMPFEKILCEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x7B9960", Offset = "0x7B8B60", VA = "0x1807B9960", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x4040100", Offset = "0x403F300", VA = "0x184040100")]
		public NGHFDGNADLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "10")]
		protected override void KBMHJLMLMHA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private sealed class NMIDBOJLBDD<T> : GCMEMNGCFAM<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override Task<T> HHDLJJOPIDF
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override JGFOKFMCODN<T> CMPFEKILCEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x7B9960", Offset = "0x7B8B60", VA = "0x1807B9960", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x407F600", Offset = "0x407E800", VA = "0x18407F600")]
		public NMIDBOJLBDD(Exception HBHCJPCIBAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "10")]
		protected override void KBMHJLMLMHA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private sealed class GKOGBEAPPNA<T> : GCMEMNGCFAM<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private struct NDMGFPPLGMN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public Task<IKCNFNMPLNN<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			private TaskAwaiter<IKCNFNMPLNN<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x4003200", Offset = "0x4002400", VA = "0x184003200", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x40036C0", Offset = "0x40028C0", VA = "0x1840036C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private struct CBGLNIAEDHC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public Task<IKCNFNMPLNN<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private TaskAwaiter<IKCNFNMPLNN<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x4A851D0", Offset = "0x4A843D0", VA = "0x184A851D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x4A853F0", Offset = "0x4A845F0", VA = "0x184A853F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly Task<IKCNFNMPLNN<T>> OHBKOCMGHPN;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override Task<T> HHDLJJOPIDF
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x7B9960", Offset = "0x7B8B60", VA = "0x1807B9960", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override JGFOKFMCODN<T> CMPFEKILCEI
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x7B6010", Offset = "0x7B5210", VA = "0x1807B6010", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x38C65A0", Offset = "0x38C57A0", VA = "0x1838C65A0")]
		public GKOGBEAPPNA(Task<IKCNFNMPLNN<T>> OCAKELEHPCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x38C63D0", Offset = "0x38C55D0", VA = "0x1838C63D0", Slot = "10")]
		protected override void KBMHJLMLMHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x38C6450", Offset = "0x38C5650", VA = "0x1838C6450")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(GKOGBEAPPNA<>.NDMGFPPLGMN))]
		internal static Task<T> PFBPNJEDNIH(Task<IKCNFNMPLNN<T>> OCAKELEHPCL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x38C62F0", Offset = "0x38C54F0", VA = "0x1838C62F0")]
		[AsyncStateMachine(typeof(GKOGBEAPPNA<>.CBGLNIAEDHC))]
		[CompilerGenerated]
		internal static Task BIMHNMCFCOP(Task<IKCNFNMPLNN<T>> OCAKELEHPCL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2932130", Offset = "0x2931330", VA = "0x182932130")]
	public static IKCNFNMPLNN<T> CLJCIKPCCEE<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x271FBA0", Offset = "0x271EDA0", VA = "0x18271FBA0")]
	public static IKCNFNMPLNN<T> DMPBHINALMJ<T>(Exception HBHCJPCIBAB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x271FBA0", Offset = "0x271EDA0", VA = "0x18271FBA0")]
	public static IKCNFNMPLNN<T> IAKOEIBDGHK<T>(Task<IKCNFNMPLNN<T>> OCAKELEHPCL) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public abstract class GCMEMNGCFAM<T> : IKCNFNMPLNN<T>, JOOIKNJLOAP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly string CDMDLKALHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly HNAEADEHOKP LODIAFCGKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private bool HBNMNOFGLDE;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool CBEJMOMNALI
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xA339A0", Offset = "0xA32BA0", VA = "0x180A339A0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public abstract Task<T> HHDLJJOPIDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public abstract JGFOKFMCODN<T> CMPFEKILCEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x38A5FA0", Offset = "0x38A51A0", VA = "0x1838A5FA0")]
	public GCMEMNGCFAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x38A5CC0", Offset = "0x38A4EC0", VA = "0x1838A5CC0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void KBMHJLMLMHA();
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public abstract class HCOGJJELLOG<TTask, T> : GCMEMNGCFAM<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class DBIGHAAAIBO
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public DBIGHAAAIBO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x3277D80", Offset = "0x3276F80", VA = "0x183277D80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x32782D0", Offset = "0x32774D0", VA = "0x1832782D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public HCOGJJELLOG<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public DBIGHAAAIBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x5103B00", Offset = "0x5102D00", VA = "0x185103B00")]
		[AsyncStateMachine(typeof(HCOGJJELLOG<, >.DBIGHAAAIBO.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> JIFJLOEEGPB(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly Task<T> OCAKELEHPCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	protected readonly CancellationTokenSource MODHBCLCLKC;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public override Task<T> HHDLJJOPIDF
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public override JGFOKFMCODN<T> CMPFEKILCEI
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7B9960", Offset = "0x7B8B60", VA = "0x1807B9960", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x391D790", Offset = "0x391C990", VA = "0x18391D790")]
	protected HCOGJJELLOG(TTask OCAKELEHPCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x391D740", Offset = "0x391C940", VA = "0x18391D740", Slot = "10")]
	protected override void KBMHJLMLMHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T GJIKPBACMGO(TTask ICLINGFAPBK);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void IOMPALJAJPM();
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class AMFDKFKHJBF<T> : GCMEMNGCFAM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly IFNEFIDKPAH<Task<T>> INMMDDKMGNB;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public override Task<T> HHDLJJOPIDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x3AFA890", Offset = "0x3AF9A90", VA = "0x183AFA890", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public override JGFOKFMCODN<T> CMPFEKILCEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7B9960", Offset = "0x7B8B60", VA = "0x1807B9960", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3AFA8D0", Offset = "0x3AF9AD0", VA = "0x183AFA8D0")]
	public AMFDKFKHJBF(IFNEFIDKPAH<Task<T>> FPKDGJENBMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x3AFA870", Offset = "0x3AF9A70", VA = "0x183AFA870", Slot = "10")]
	protected override void KBMHJLMLMHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class DGBANEBDNMH
{
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x61BFB00", Offset = "0x61BED00", VA = "0x1861BFB00")]
	[NotNull]
	public static byte[] HLOKPAMFIBA(this HFPIHMCNNKJ BAMNIOGAJPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x61BFB70", Offset = "0x61BED70", VA = "0x1861BFB70")]
	[NotNull]
	public static byte[] HLOKPAMFIBA(this HFPIHMCNNKJ BAMNIOGAJPA, HashAlgorithmName JCONFNLFKHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x61BF970", Offset = "0x61BEB70", VA = "0x1861BF970")]
	public static bool GDHEBEMKABB([CanBeNull] this HFPIHMCNNKJ BAMNIOGAJPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x61BF7D0", Offset = "0x61BE9D0", VA = "0x1861BF7D0")]
	public static bool GDHEBEMKABB([CanBeNull] this HFPIHMCNNKJ BAMNIOGAJPA, [Out] string BKDLFDLOKJH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x61BF6B0", Offset = "0x61BE8B0", VA = "0x1861BF6B0")]
	private static bool CIJHAMPDCFI([NotNull] HFPIHMCNNKJ BAMNIOGAJPA, [Out][CanBeNull] byte[] DIIEKNFLCPC, [Out][CanBeNull] byte[] KNOHHOACHLB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class MLEFEMHGAOC
{
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x61C1A60", Offset = "0x61C0C60", VA = "0x1861C1A60")]
	[NotNull]
	public static byte[] HLOKPAMFIBA(this EKDGCJOEMJL GJNCPAALEII, HashAlgorithmName JCONFNLFKHK, byte[] GPBCMIGPLFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface EKDGCJOEMJL
{
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash LNOOCJJIMOE);
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface HFPIHMCNNKJ : EKDGCJOEMJL
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	[CanBeNull]
	byte[] COMOOEAPNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	[CanBeNull]
	byte[] OFCCNGLCLHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class DHINDFBAIAG
{
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static readonly ArrayPool<byte> JDHOGMMGNFL;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static bool MABPJGOOHAH;

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2757040", Offset = "0x2756240", VA = "0x182757040")]
	public static void LPBLOCAFBFC<T>(this IncrementalHash GKIAKIBCJHB, [CanBeNull] T EFNFBPDAPGP) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x2756FB0", Offset = "0x27561B0", VA = "0x182756FB0")]
	public static void LDOMBJIFIFO<T>(this IncrementalHash GKIAKIBCJHB, [CanBeNull] T GJNCPAALEII) where T : EKDGCJOEMJL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2757100", Offset = "0x2756300", VA = "0x182757100")]
	public static void ONLAOFCHFIE<T>(this IncrementalHash GKIAKIBCJHB, [CanBeNull] IList<T> LKELNHGPGEK) where T : EKDGCJOEMJL
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x61BFC40", Offset = "0x61BEE40", VA = "0x1861BFC40")]
	private static bool CEIGELKAPDJ([CanBeNull] EKDGCJOEMJL GJNCPAALEII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x61BFF00", Offset = "0x61BF100", VA = "0x1861BFF00")]
	public static void FFPPANNNMGB(this IncrementalHash LNOOCJJIMOE, [CanBeNull] string HLNGGAAKGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x61BFF60", Offset = "0x61BF160", VA = "0x1861BFF60")]
	public static void FMHDLBACOCO(this IncrementalHash LNOOCJJIMOE, long LDOILAIHNJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x61BFD30", Offset = "0x61BEF30", VA = "0x1861BFD30")]
	public static void FDNJCMAONLF(this IncrementalHash LNOOCJJIMOE, int CAMOALKNLDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x61C0430", Offset = "0x61BF630", VA = "0x1861C0430")]
	public static void LKFJPIANJLA(this IncrementalHash LNOOCJJIMOE, short HDJKCPELPNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x61C0260", Offset = "0x61BF460", VA = "0x1861C0260")]
	public static void IAKDGEDBLDO(this IncrementalHash LNOOCJJIMOE, byte PDDLGMDLFCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x61C0600", Offset = "0x61BF800", VA = "0x1861C0600")]
	public static void MNIPECAHIDG(this IncrementalHash LNOOCJJIMOE, bool CPIPPINGOLL, bool FKNNCAOEPDO = false, bool OALALOOIFLK = false, bool PJPFDDHCICJ = false, bool DCOFHAPPLIE = false, bool LLMEJFPDKKO = false, bool CCPEBGBKIJB = false, bool NCGIGAEHDJD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2756980", Offset = "0x2755B80", VA = "0x182756980")]
	public static void BFOGGCPODHE<T>(this IncrementalHash LNOOCJJIMOE, T LILHNKAIGNI) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x61BFBE0", Offset = "0x61BEDE0", VA = "0x1861BFBE0")]
	public static void CEIAIAIDLFL(this IncrementalHash LNOOCJJIMOE, float LHANOJPHMED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x61C03D0", Offset = "0x61BF5D0", VA = "0x1861C03D0")]
	public static void KMGKPFHIDEO(this IncrementalHash LNOOCJJIMOE, ulong IJDHEKLGOON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x61C0370", Offset = "0x61BF570", VA = "0x1861C0370")]
	public static void IPAHCILJHCA(this IncrementalHash LNOOCJJIMOE, uint ONALEGBCCHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x61BFCD0", Offset = "0x61BEED0", VA = "0x1861BFCD0")]
	public static void CLDOCFECGPJ(this IncrementalHash LNOOCJJIMOE, ushort DCNKGFDIMCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x61C0130", Offset = "0x61BF330", VA = "0x1861C0130")]
	public static void GGPLECHIDPB(this IncrementalHash LNOOCJJIMOE, Vector3 LNHFGPICMEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class CKJKCAGPGNI : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x61BEEF0", Offset = "0x61BE0F0", VA = "0x1861BEEF0")]
	public CKJKCAGPGNI(string JGNAJPMGGNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class OIGLAGPKLMK<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	internal class CBKDAPAMGDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public TNode KNKOEEEKHDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public TNode BHNONFFBKHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public BOPBAEFMNGM NMBNNEFKAJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public List<BOPBAEFMNGM> JFCKKFGJNBN;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public CBKDAPAMGDG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal struct BOPBAEFMNGM : IComparable<BOPBAEFMNGM>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int GFPJHDGNEBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public TClaimant COOMHIBKADC;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xC46070", Offset = "0xC45270", VA = "0x180C46070")]
		public BOPBAEFMNGM(int GFPJHDGNEBO, TClaimant COOMHIBKADC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x48BAE00", Offset = "0x48BA000", VA = "0x1848BAE00")]
		public bool JAFKJJBABBD([In] BOPBAEFMNGM NOBJAPGNDAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x48BADE0", Offset = "0x48B9FE0", VA = "0x1848BADE0")]
		public bool BJEDDFOMKJM([In] BOPBAEFMNGM NOBJAPGNDAK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x48BADF0", Offset = "0x48B9FF0", VA = "0x1848BADF0", Slot = "4")]
		public int CompareTo(BOPBAEFMNGM NOBJAPGNDAK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x48BAE60", Offset = "0x48BA060", VA = "0x1848BAE60", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public enum AKDNACKPIJO
	{
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class JLMHLGEKKGJ : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public OIGLAGPKLMK<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x801C80", Offset = "0x800E80", VA = "0x180801C80")]
		[DebuggerHidden]
		public JLMHLGEKKGJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3C2E240", Offset = "0x3C2D440", VA = "0x183C2E240", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3C2E400", Offset = "0x3C2D600", VA = "0x183C2E400", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3C2E320", Offset = "0x3C2D520", VA = "0x183C2E320", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x37E1880", Offset = "0x37E0A80", VA = "0x1837E1880", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly GHBMIANENLM<CBKDAPAMGDG> PBGMCLGGMOI;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly GHBMIANENLM<List<BOPBAEFMNGM>> OHHNAOGOEGA;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static int MPKIKELMBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	internal readonly Dictionary<TClaimant, TNode> KFKPKGIMPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	internal readonly Dictionary<TNode, CBKDAPAMGDG> AEIMPLMGFPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private AKDNACKPIJO MAGPNICKDGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private bool OEJOJKGONDA;

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode ENFGANHBDNA(TNode CLKPBALPCKM);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void HACCJDBKHPJ(TNode CLKPBALPCKM, TClaimant FJOFGAGAPDI, TClaimant IIMKKBMMAKK);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x418AA70", Offset = "0x4189C70", VA = "0x18418AA70")]
	public OIGLAGPKLMK(AKDNACKPIJO MAGPNICKDGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x418A020", Offset = "0x4189220", VA = "0x18418A020")]
	public void EFFEPAFNDLJ(TNode CLKPBALPCKM, TNode MHAMFGHDGFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x4189450", Offset = "0x4188650", VA = "0x184189450")]
	public void AJOFFOPFMKP(TClaimant COOMHIBKADC, TNode PDHFCHAGJOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x4189E80", Offset = "0x4189080", VA = "0x184189E80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x418A2E0", Offset = "0x41894E0", VA = "0x18418A2E0")]
	private void GCKIICFOCLN(TClaimant COOMHIBKADC, TNode IGBEFCDDKPL, TNode PDHFCHAGJOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x4189570", Offset = "0x4188770", VA = "0x184189570")]
	private int APOLNHJEJMB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x418A380", Offset = "0x4189580", VA = "0x18418A380")]
	private void HCEAGPKNPCM(TClaimant COOMHIBKADC, TNode ENBNKCPFMEB, TNode PBHEBDNHMAN, int AAPDENEHMKP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x41895E0", Offset = "0x41887E0", VA = "0x1841895E0")]
	private void BPFMAIGFPBB(BOPBAEFMNGM HHDKJMIPAPL, CBKDAPAMGDG BGFJJEOBCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x4189BC0", Offset = "0x4188DC0", VA = "0x184189BC0")]
	private void DMNDKPMKNLL(TClaimant COOMHIBKADC, TNode ENBNKCPFMEB, TNode PBHEBDNHMAN, int AAPDENEHMKP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x418A1D0", Offset = "0x41893D0", VA = "0x18418A1D0")]
	private void FPEFDALMNBP(BOPBAEFMNGM HHDKJMIPAPL, TNode CLKPBALPCKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x4189AE0", Offset = "0x4188CE0", VA = "0x184189AE0")]
	private void DMIEGNPKCOD(BOPBAEFMNGM HHDKJMIPAPL, CBKDAPAMGDG BGFJJEOBCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x418A0B0", Offset = "0x41892B0", VA = "0x18418A0B0")]
	private void FLMLGGMCFLJ(CBKDAPAMGDG BGFJJEOBCAB, bool PDIFAPGACDG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x4189660", Offset = "0x4188860", VA = "0x184189660")]
	private void CJEOIOCCJIM(CBKDAPAMGDG BGFJJEOBCAB, TNode MHAMFGHDGFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x4189380", Offset = "0x4188580", VA = "0x184189380")]
	[IteratorStateMachine(typeof(OIGLAGPKLMK<, >.JLMHLGEKKGJ))]
	private IEnumerable<TNode> AHNIHNJFJCA(TNode ENBNKCPFMEB, TNode PBHEBDNHMAN, bool ANFOBJBCBKH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x418A7F0", Offset = "0x41899F0", VA = "0x18418A7F0")]
	private CBKDAPAMGDG LEPBFENFAPI(TNode CLKPBALPCKM, TNode BHNONFFBKHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x418A6A0", Offset = "0x41898A0", VA = "0x18418A6A0")]
	private CBKDAPAMGDG KHFMGOALMMD(TNode CLKPBALPCKM, TNode BHNONFFBKHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x4189980", Offset = "0x4188B80", VA = "0x184189980")]
	private void DHOLCDFLLOF(CBKDAPAMGDG BGFJJEOBCAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class LDCIELNJEIC<T> : IEnumerable<LDCIELNJEIC<T>.CIGHMCOPPKJ>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct CIGHMCOPPKJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public T NICEPFIEJED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int HMFNCGHECPG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public class PEMCGCMBHFL : IEnumerator<CIGHMCOPPKJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private LDCIELNJEIC<T> MMIHEHFLHMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private int HMFNCGHECPG;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x34B0FF0", Offset = "0x34B01F0", VA = "0x1834B0FF0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public CIGHMCOPPKJ DCJELCPGFEP
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x4268A20", Offset = "0x4267C20", VA = "0x184268A20", Slot = "4")]
			get
			{
				return default(CIGHMCOPPKJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4268930", Offset = "0x4267B30", VA = "0x184268930")]
		public PEMCGCMBHFL(LDCIELNJEIC<T> MMIHEHFLHMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x4268830", Offset = "0x4267A30", VA = "0x184268830", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3503980", Offset = "0x3502B80", VA = "0x183503980", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8956E0", Offset = "0x8948E0", VA = "0x1808956E0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private struct FPPMFPOENPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public bool OPPBBAMCJIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public T NICEPFIEJED;
	}

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private const int BEMGALACHFN = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly Dictionary<T, int> KHFGMIMCFMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private FPPMFPOENPI[] HOBCBKJHOLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int ENBGBHODCNK;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int EMLHKGLLLJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7F40C0", Offset = "0x7F32C0", VA = "0x1807F40C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x7F36B0", Offset = "0x7F28B0", VA = "0x1807F36B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int PIKJCOKEANP
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3287A60", Offset = "0x3286C60", VA = "0x183287A60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x3D21580", Offset = "0x3D20780", VA = "0x183D21580")]
	public LDCIELNJEIC(int DIHLAEIGMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x3D21650", Offset = "0x3D20850", VA = "0x183D21650")]
	public LDCIELNJEIC(CIGHMCOPPKJ[] KPENBIJOGHP, bool PMLMIIHCKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x3D209B0", Offset = "0x3D1FBB0", VA = "0x183D209B0")]
	public int KDBEMGCNKPJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x3D20C90", Offset = "0x3D1FE90", VA = "0x183D20C90")]
	private int MNBHMHHCKOK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x3D214E0", Offset = "0x3D206E0", VA = "0x183D214E0", Slot = "6")]
	protected virtual uint PNOLNLEHKFG(uint LNOOCJJIMOE, T NICEPFIEJED)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x3D20A30", Offset = "0x3D1FC30", VA = "0x183D20A30")]
	public bool KHCBIMCENPA(T NICEPFIEJED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x3D21440", Offset = "0x3D20640", VA = "0x183D21440")]
	public int PDCECLDILLH(T NICEPFIEJED)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x3D20940", Offset = "0x3D1FB40", VA = "0x183D20940")]
	public T EPDDJIJHIDF(int HMFNCGHECPG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x3D20F00", Offset = "0x3D20100", VA = "0x183D20F00")]
	public bool PBCOJKEDMAJ(T NICEPFIEJED, bool JEDEIIBMKND = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x3D20F50", Offset = "0x3D20150", VA = "0x183D20F50")]
	public bool PBCOJKEDMAJ(T NICEPFIEJED, int HMFNCGHECPG, bool JEDEIIBMKND = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x3D20E60", Offset = "0x3D20060", VA = "0x183D20E60")]
	private int OBCOOKIABBM(int LCKACGDGBMN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x3D21500", Offset = "0x3D20700", VA = "0x183D21500", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x3D21500", Offset = "0x3D20700", VA = "0x183D21500", Slot = "4")]
	private IEnumerator<CIGHMCOPPKJ> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class GHBMIANENLM<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly Stack<T> FBFDMDNDHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly List<T> FEFOPKEKLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly int FPOAFPKJINE;

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x38B4BD0", Offset = "0x38B3DD0", VA = "0x1838B4BD0")]
	public static GHBMIANENLM<T> HHAKLBIDGOJ(int DIHLAEIGMPG = 0, int FPOAFPKJINE = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x38B4CB0", Offset = "0x38B3EB0", VA = "0x1838B4CB0")]
	public static GHBMIANENLM<T> KJACELMAMIF(int DIHLAEIGMPG = 0, int FPOAFPKJINE = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x38B51B0", Offset = "0x38B43B0", VA = "0x1838B51B0")]
	public GHBMIANENLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x38B51E0", Offset = "0x38B43E0", VA = "0x1838B51E0")]
	public GHBMIANENLM(int DIHLAEIGMPG, int FPOAFPKJINE = int.MaxValue, bool HNFECLINEKA = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x38B5050", Offset = "0x38B4250", VA = "0x1838B5050")]
	public T NCBKMOIGMJN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x38B4B00", Offset = "0x38B3D00", VA = "0x1838B4B00")]
	public void EJBBKCPFFPM(T NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x38B4F80", Offset = "0x38B4180", VA = "0x1838B4F80")]
	private void NANCACJCCMD(T NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x38B49B0", Offset = "0x38B3BB0", VA = "0x1838B49B0")]
	private void BNJMIEHLOMH(T NICEPFIEJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x38B49D0", Offset = "0x38B3BD0", VA = "0x1838B49D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x38B4D90", Offset = "0x38B3F90", VA = "0x1838B4D90")]
	private void MGIDGPGOPEM(IEnumerable<T> NGOGJHGFHFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class OOCBGDDCFPA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private Dictionary<int, T> FOGKLDABGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private T IAHFHOFCFFO;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual T HCGANPCFBEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7B6290", Offset = "0x7B5490", VA = "0x1807B6290", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x41CAAA0", Offset = "0x41C9CA0", VA = "0x1841CAAA0")]
	public bool CBHGKBMPIGJ(T NICEPFIEJED, int GFPJHDGNEBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x34753C0", Offset = "0x34745C0", VA = "0x1834753C0")]
	public bool MANDAODFEFB(int GFPJHDGNEBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x41CACB0", Offset = "0x41C9EB0", VA = "0x1841CACB0")]
	public T NEHOCFLLLJD(int LPFCJLEDKEI)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x41CAB10", Offset = "0x41C9D10", VA = "0x1841CAB10")]
	private bool DDKBMLHNBGJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x41CB050", Offset = "0x41CA250", VA = "0x1841CB050")]
	public bool PEFGNEHBCPG(int GFPJHDGNEBO, [Out] T NICEPFIEJED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x41CB090", Offset = "0x41CA290", VA = "0x1841CB090")]
	public OOCBGDDCFPA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class CKFKOHGOIEP<T>
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	protected struct HGPDMBOPICI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public T FJJHODHBEGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public int HPMBCBPFPON;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	protected readonly List<HGPDMBOPICI> EGFAOPNPDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private T IFIBGMBBACI;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int PIKJCOKEANP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3287A60", Offset = "0x3286C60", VA = "0x183287A60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x4C39080", Offset = "0x4C38280", VA = "0x184C39080")]
	public bool GIIBKAKCCGO(T NICEPFIEJED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x4C39400", Offset = "0x4C38600", VA = "0x184C39400")]
	public void OEOPOJPHCNL(T NICEPFIEJED, int GFPJHDGNEBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x4C39270", Offset = "0x4C38470", VA = "0x184C39270")]
	public bool MFEEKLGJAPH(T NICEPFIEJED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x4C393A0", Offset = "0x4C385A0", VA = "0x184C393A0")]
	public void NDGKPACNNFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x4C391F0", Offset = "0x4C383F0", VA = "0x184C391F0")]
	public T MFDJDKLCFCH()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x4C38F20", Offset = "0x4C38120", VA = "0x184C38F20")]
	private void BLOAPGJGBIF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x4C394A0", Offset = "0x4C386A0", VA = "0x184C394A0")]
	public CKFKOHGOIEP()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[SerializeField]
		[MGMFHFICAPM(OILHINDHMGI.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x61C2310", Offset = "0x61C1510", VA = "0x1861C2310")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x61C25E0", Offset = "0x61C17E0", VA = "0x1861C25E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x61C24F0", Offset = "0x61C16F0", VA = "0x1861C24F0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x61C2260", Offset = "0x61C1460", VA = "0x1861C2260")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x61C2530", Offset = "0x61C1730", VA = "0x1861C2530")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x61C2440", Offset = "0x61C1640", VA = "0x1861C2440")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x61C21E0", Offset = "0x61C13E0", VA = "0x1861C21E0")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x4407FB0", Offset = "0x44071B0", VA = "0x184407FB0", Slot = "4")]
		public virtual T OJOHBLIKHIK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class JAODLGAJNHA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private Dictionary<byte, DBBDLEIEGNA> HLPDINDBBJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly GHBMIANENLM<DBBDLEIEGNA> GDLJHFCDDGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly bool PJNFKFDLPJL;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public DBBDLEIEGNA GKLAHJGKPFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7B6320", Offset = "0x7B5520", VA = "0x1807B6320")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7B6300", Offset = "0x7B5500", VA = "0x1807B6300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public Vector2 HKMKEMPDIML
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xBC8470", Offset = "0xBC7670", VA = "0x180BC8470")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xEAF0D0", Offset = "0xEAE2D0", VA = "0x180EAF0D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private Vector2 IAHFGEBJHJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xF26B70", Offset = "0xF25D70", VA = "0x180F26B70")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public Vector2 HEIHIBPOGFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x61C10C0", Offset = "0x61C02C0", VA = "0x1861C10C0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7B62C0", Offset = "0x7B54C0", VA = "0x1807B62C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public int PHKFINHCPEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7BFCF0", Offset = "0x7BEEF0", VA = "0x1807BFCF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7BFEF0", Offset = "0x7BF0F0", VA = "0x1807BFEF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x61C18D0", Offset = "0x61C0AD0", VA = "0x1861C18D0")]
	public JAODLGAJNHA(Bounds GJAMLPKDCMF, Vector2[] OEINJHHEEOJ, int HADPCOJCMCH, byte LCKACGDGBMN, float NHENGEIOMDP = 0f, [Optional] GHBMIANENLM<DBBDLEIEGNA> GDLJHFCDDGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x61C1230", Offset = "0x61C0430", VA = "0x1861C1230")]
	public void MCMBEJDJAMM(Bounds GJAMLPKDCMF, Vector2[] OEINJHHEEOJ, int HADPCOJCMCH, byte LCKACGDGBMN, float NHENGEIOMDP = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x61C10E0", Offset = "0x61C02E0", VA = "0x1861C10E0")]
	public DBBDLEIEGNA JKOIOCCOPJC(byte HMFNCGHECPG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x61C0F90", Offset = "0x61C0190", VA = "0x1861C0F90")]
	public void FGIDLIABOGO(Vector3 DHMMMGDKPCG, float EPDBIKOOFJB, float APKABLLIFKL, List<byte> BJNKEGKPPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x5929A40", Offset = "0x5928C40", VA = "0x185929A40")]
	public void FIKJPGCNONA(DBBDLEIEGNA.APDIGLCFDHJ PKJIMLNGEGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x61C1140", Offset = "0x61C0340", VA = "0x1861C1140")]
	public static int KGKEDBIIDLN(Vector2[] OEINJHHEEOJ, int HADPCOJCMCH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x61C16D0", Offset = "0x61C08D0", VA = "0x1861C16D0")]
	private DBBDLEIEGNA NDIAEAEALGA(byte HMFNCGHECPG, DBBDLEIEGNA.MAHOJHOCCEB FFAJFFHPFIE, DBBDLEIEGNA BHNONFFBKHO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x61C0BE0", Offset = "0x61BFDE0", VA = "0x1861C0BE0")]
	private void EOICBMFJEMO(DBBDLEIEGNA BHNONFFBKHO, Vector2[] OEINJHHEEOJ, int MMDBBAILHID, int MDIGEJIPHCN, int KJMFADGHABE, int BKDICNCBOIN, float NHENGEIOMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x61C0960", Offset = "0x61BFB60", VA = "0x1861C0960")]
	private void BBMJHNAMNFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x61C0B80", Offset = "0x61BFD80", VA = "0x1861C0B80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x61C1060", Offset = "0x61C0260", VA = "0x1861C1060", Slot = "1")]
	~JAODLGAJNHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class DBBDLEIEGNA
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public enum MAHOJHOCCEB
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public enum APDIGLCFDHJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public byte GHMLFHHEGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public Vector3 OIHICKOEEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public Vector3 JPOIEEJJKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public Vector3 LNNIJKHEOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public Vector3 LCPLNHCNEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public MAHOJHOCCEB JGKFDMMPEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public DBBDLEIEGNA ANNFPHELCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public List<DBBDLEIEGNA> FFFDOPNAIIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public bool EMGFBPBIGMP;

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x61BF690", Offset = "0x61BE890", VA = "0x1861BF690")]
	public DBBDLEIEGNA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x61BF220", Offset = "0x61BE420", VA = "0x1861BF220")]
	public void EIMOOLAODCJ(DBBDLEIEGNA DEGINJHPGFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7B45E0", Offset = "0x7B37E0", VA = "0x1807B45E0")]
	public void FIKJPGCNONA(int LFOAAKKBECL, APDIGLCFDHJ PKJIMLNGEGI, int ENKMBGKFHPI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x61BF340", Offset = "0x61BE540", VA = "0x1861BF340")]
	public void FGIDLIABOGO(List<byte> BJNKEGKPPLL, Vector3 DHMMMGDKPCG, float EPDBIKOOFJB, float APKABLLIFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x61BF630", Offset = "0x61BE830", VA = "0x1861BF630")]
	public bool MIFMLHCAHFB(Vector3 LJBCIKIPLBF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x61BF660", Offset = "0x61BE860", VA = "0x1861BF660")]
	public bool NOHKMELDHAC(Vector3 LJBCIKIPLBF, float DCGOCDCOHGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x61BF5A0", Offset = "0x61BE7A0", VA = "0x1861BF5A0")]
	public void GEJAFFIMNGM()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		public struct CNCJHDLEKDH<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			private readonly List<Component> JLCIFHJMGPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			private readonly bool OKKICIFNNCK;

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x398C940", Offset = "0x398BB40", VA = "0x18398C940")]
			public CNCJHDLEKDH(List<Component> JLCIFHJMGPA, bool OKKICIFNNCK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x4C3D060", Offset = "0x4C3C260", VA = "0x184C3D060")]
			public OJEKEIAGALK<T> ODDJKKOCOEI()
			{
				return default(OJEKEIAGALK<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x4C3D0C0", Offset = "0x4C3C2C0", VA = "0x184C3D0C0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x4C3D0C0", Offset = "0x4C3C2C0", VA = "0x184C3D0C0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		public struct OJEKEIAGALK<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			private readonly List<Component> JLCIFHJMGPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			private readonly bool OKKICIFNNCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			private int HMFNCGHECPG;

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public T DCJELCPGFEP
			{
				[Cpp2IlInjected.Token(Token = "0x60001F9")]
				[Cpp2IlInjected.Address(RVA = "0x41A19D0", Offset = "0x41A0BD0", VA = "0x1841A19D0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001FA")]
				[Cpp2IlInjected.Address(RVA = "0x41A1960", Offset = "0x41A0B60", VA = "0x1841A1960", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x41A19A0", Offset = "0x41A0BA0", VA = "0x1841A19A0")]
			public OJEKEIAGALK(List<Component> JLCIFHJMGPA, bool OKKICIFNNCK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x41A18A0", Offset = "0x41A0AA0", VA = "0x1841A18A0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x41A18B0", Offset = "0x41A0AB0", VA = "0x1841A18B0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x34F4F80", Offset = "0x34F4180", VA = "0x1834F4F80", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x61C3B60", Offset = "0x61C2D60", VA = "0x1861C3B60")]
		private void GEJAFFIMNGM(GameObject IEMCJEEOMLG, bool FCLAIJBMLJG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x61C39A0", Offset = "0x61C2BA0", VA = "0x1861C39A0")]
		public static void GEJAFFIMNGM(GameObject IEMCJEEOMLG, ToolHierarchyCache EFHIGOEKJMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA610", Offset = "0x2BA9810", VA = "0x182BAA610")]
		public void LEFCNOKFIDP<T>(Action<T> GKGLDBAJJCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA830", Offset = "0x2BA9A30", VA = "0x182BAA830")]
		public T PAPEJMPLGLH<T>(bool OKKICIFNNCK = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x2BAA550", Offset = "0x2BA9750", VA = "0x182BAA550")]
		public CNCJHDLEKDH<T> BDCDGIAIFFA<T>(bool OKKICIFNNCK = false) where T : class
		{
			return default(CNCJHDLEKDH<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x61C3D40", Offset = "0x61C2F40", VA = "0x1861C3D40")]
		public List<Component> ONLOMGMJMMK(Type FLPJMDMACMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x61C3920", Offset = "0x61C2B20", VA = "0x1861C3920", Slot = "4")]
		public bool Equals(ToolHierarchyCache KPEEHKEJDAP, ToolHierarchyCache OEKGMAOIIKN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x61C3CD0", Offset = "0x61C2ED0", VA = "0x1861C3CD0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache JFJMICPDNDH)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class LEHNHHKHDMC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private int DIHLAEIGMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private int FANFMMHAKLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private List<T> HGPCNIDKMCF;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int PIKJCOKEANP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3AFA890", Offset = "0x3AF9A90", VA = "0x183AFA890")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public T GNHHBJIJMBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3D25830", Offset = "0x3D24A30", VA = "0x183D25830")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public T CCPFENJOHCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x3D25420", Offset = "0x3D24620", VA = "0x183D25420")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public T NNHAEMIMJFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3D255B0", Offset = "0x3D247B0", VA = "0x183D255B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x3D259D0", Offset = "0x3D24BD0", VA = "0x183D259D0")]
	public LEHNHHKHDMC(int DIHLAEIGMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x3D25660", Offset = "0x3D24860", VA = "0x183D25660")]
	public void OEOPOJPHCNL(T BJAKMDECJMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x3D25620", Offset = "0x3D24820", VA = "0x183D25620")]
	public void NDGKPACNNFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x3D254A0", Offset = "0x3D246A0", VA = "0x183D254A0")]
	public void DEEHBKIJODO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x3D25980", Offset = "0x3D24B80", VA = "0x183D25980")]
	public void OMPLNHJACFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x3D25490", Offset = "0x3D24690", VA = "0x183D25490")]
	public void CHLLMJPEBNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class OCGCPFBGPJP<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private struct MFIADEBJJNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public int HPMBCBPFPON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public T FJJHODHBEGH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly Dictionary<object, MFIADEBJJNC> FOGKLDABGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly EqualityComparer<T> AKJEFEAILJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private T IAHFHOFCFFO;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public virtual T HCGANPCFBEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x103B500", Offset = "0x103A700", VA = "0x18103B500", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x41328A0", Offset = "0x4131AA0", VA = "0x1841328A0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool NNMCPIBGCJH
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x4132860", Offset = "0x4131A60", VA = "0x184132860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public object BHEPPIPIHIA
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x7B6280", Offset = "0x7B5480", VA = "0x1807B6280")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7BC990", Offset = "0x7BBB90", VA = "0x1807BC990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x412FC40", Offset = "0x412EE40", VA = "0x18412FC40")]
	public bool CBHGKBMPIGJ(T NICEPFIEJED, object FCKLPDKGPKE, int GFPJHDGNEBO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x4132990", Offset = "0x4131B90", VA = "0x184132990")]
	public bool MANDAODFEFB(object FCKLPDKGPKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x4132BC0", Offset = "0x4131DC0", VA = "0x184132BC0")]
	public bool PEFGNEHBCPG(object FCKLPDKGPKE, [Out] T NICEPFIEJED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x4132A10", Offset = "0x4131C10", VA = "0x184132A10")]
	public void NDGKPACNNFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x41314A0", Offset = "0x41306A0", VA = "0x1841314A0")]
	private bool DDKBMLHNBGJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x41331E0", Offset = "0x41323E0", VA = "0x1841331E0")]
	public OCGCPFBGPJP()
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
