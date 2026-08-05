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
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
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
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x68A5760", Offset = "0x68A4360", VA = "0x1868A5760")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86E660", Offset = "0x86D260", VA = "0x18086E660")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x86E6A0", Offset = "0x86D2A0", VA = "0x18086E6A0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class DAMBLGKNLPE : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x14BF290", Offset = "0x14BDE90", VA = "0x1814BF290")]
	public DAMBLGKNLPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, EIFKGMCOLPJ, BCKDFJDFIHG, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x843330", Offset = "0x841F30", VA = "0x180843330", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x844500", Offset = "0x843100", VA = "0x180844500", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x90B600", Offset = "0x90A200", VA = "0x18090B600", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash LNMBFIMPMFA);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8B3240", Offset = "0x8B1E40", VA = "0x1808B3240")]
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
	[HideInInspector]
	[ReadOnlyField]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x68A6A20", Offset = "0x68A5620", VA = "0x1868A6A20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x68A69E0", Offset = "0x68A55E0", VA = "0x1868A69E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x68A6A60", Offset = "0x68A5660", VA = "0x1868A6A60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x68A6C10", Offset = "0x68A5810", VA = "0x1868A6C10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x68A6B80", Offset = "0x68A5780", VA = "0x1868A6B80")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8B3230", Offset = "0x8B1E30", VA = "0x1808B3230")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8B31F0", Offset = "0x8B1DF0", VA = "0x1808B31F0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x68A69A0", Offset = "0x68A55A0", VA = "0x1868A69A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x68A6AF0", Offset = "0x68A56F0", VA = "0x1868A6AF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x68A6410", Offset = "0x68A5010", VA = "0x1868A6410")]
	public void CopyBounds(SavedExtents OCNJFCPHJLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x68A68F0", Offset = "0x68A54F0", VA = "0x1868A68F0")]
	public void SetLocalSpaceBounds(Bounds FBMMHOEJOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xB845C0", Offset = "0xB831C0", VA = "0x180B845C0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x68A68E0", Offset = "0x68A54E0", VA = "0x1868A68E0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x68A6440", Offset = "0x68A5040", VA = "0x1868A6440")]
	private void DDDIMEBKGPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x68A66C0", Offset = "0x68A52C0", VA = "0x1868A66C0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x68A5DA0", Offset = "0x68A49A0", VA = "0x1868A5DA0")]
	public static void CalculateLocalBoundsFor(GameObject OLFFLDPKCIP, [Out] Bounds FBMMHOEJOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x68A6600", Offset = "0x68A5200", VA = "0x1868A6600")]
	private static void DFIEKEOGBMI(Bounds EIKHFLMLKJH, Color PIIKINJOJMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x68A6910", Offset = "0x68A5510", VA = "0x1868A6910")]
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
		[Cpp2IlInjected.Address(RVA = "0x8431A0", Offset = "0x841DA0", VA = "0x1808431A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8444C0", Offset = "0x8430C0", VA = "0x1808444C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xFC6B40", Offset = "0xFC5740", VA = "0x180FC6B40")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x495E480", Offset = "0x495D080", VA = "0x18495E480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "4")]
	public virtual void ADOMCJMLLAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
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
	[SerializeField]
	[DAMBLGKNLPE]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x495DFF0", Offset = "0x495CBF0", VA = "0x18495DFF0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x495C7B0", Offset = "0x495B3B0", VA = "0x18495C7B0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x495E380", Offset = "0x495CF80", VA = "0x18495E380")]
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
	private sealed class MLCGFFNDGOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public MLCGFFNDGOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4411110", Offset = "0x440FD10", VA = "0x184411110")]
		internal int MBFBABILFDJ(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[DAMBLGKNLPE]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x382BBB0", Offset = "0x382A7B0", VA = "0x18382BBB0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x382BC10", Offset = "0x382A810", VA = "0x18382BC10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x382BA90", Offset = "0x382A690", VA = "0x18382BA90", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey DPHIOKCFMFC]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x382BB50", Offset = "0x382A750", VA = "0x18382BB50", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x382B940", Offset = "0x382A540", VA = "0x18382B940", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x382B600", Offset = "0x382A200", VA = "0x18382B600", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x382AA30", Offset = "0x3829630", VA = "0x18382AA30", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x382A930", Offset = "0x3829530", VA = "0x18382A930", Slot = "14")]
	protected virtual string EBIMDGKCCIM(TKeyVal IJFLOGOPBHG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x382A8A0", Offset = "0x38294A0", VA = "0x18382A8A0", Slot = "4")]
	public bool ContainsKey(TKey DPHIOKCFMFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x382B7C0", Offset = "0x382A3C0", VA = "0x18382B7C0", Slot = "5")]
	public bool TryGetValue(TKey DPHIOKCFMFC, [Out] TVal GLMEMJNJKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x382A990", Offset = "0x3829590", VA = "0x18382A990", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x382A990", Offset = "0x3829590", VA = "0x18382A990", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x382B820", Offset = "0x382A420", VA = "0x18382B820")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class EDKKBIKJJJP<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class BDFLMKLBFDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public float LEEBANNKJLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public T EPAONLOANJK;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public BDFLMKLBFDO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class BBINJPADNCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public BBINJPADNCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4E21900", Offset = "0x4E20500", VA = "0x184E21900")]
		internal bool JMOCAOKOJIK(BDFLMKLBFDO sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly float CEFPKNDIEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly float FCABCBJCLDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<BDFLMKLBFDO> FDDAMMCNEAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private GOJAECNACIA<BDFLMKLBFDO> NFMCPDAPNKG;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int JCNDGCLKFBL
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x37B08D0", Offset = "0x37AF4D0", VA = "0x1837B08D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x37B1680", Offset = "0x37B0280", VA = "0x1837B1680")]
	public EDKKBIKJJJP(float PDBACFBEGIL, float DANHDOGPHJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x37B1240", Offset = "0x37AFE40", VA = "0x1837B1240")]
	public bool NMDEIENHINI(float PHNMPHLDABI, T GLMEMJNJKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x37B0B60", Offset = "0x37AF760", VA = "0x1837B0B60")]
	public IEnumerable<T> LILGBHDHACA(float PHNMPHLDABI, [Optional] float? HFEDNEPLOGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x37B15D0", Offset = "0x37B01D0", VA = "0x1837B15D0")]
	public void ONDHHAABKMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x37B09B0", Offset = "0x37AF5B0", VA = "0x1837B09B0")]
	private void KOENDCJBFOF(float PHNMPHLDABI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class JDBHJDMCMDE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct OLKABEKBNME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public T EPAONLOANJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public float MPBCDLPLLLO;
	}

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static float AJNHOIKNOLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private List<T> NIAKHPNBJIL;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private const int FHGCAPKPEGD = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private OLKABEKBNME[] CHPEIOMPEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int KEMCJMLNJCH;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float FBGHKHNMFBA
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x981590", Offset = "0x980190", VA = "0x180981590")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x99CE90", Offset = "0x99BA90", VA = "0x18099CE90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4017310", Offset = "0x4015F10", VA = "0x184017310")]
	public JDBHJDMCMDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4017350", Offset = "0x4015F50", VA = "0x184017350")]
	public JDBHJDMCMDE(int AEOJMEBJNPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x4016960", Offset = "0x4015560", VA = "0x184016960")]
	public void MPFJKDGCCNN(float PHNMPHLDABI, T GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4017170", Offset = "0x4015D70", VA = "0x184017170")]
	public void ONDHHAABKMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4016E30", Offset = "0x4015A30", VA = "0x184016E30")]
	public bool NLLFEBLIBKG(float PALEMBNPKFN, float PHDNJKFMJDM, [Out] T GLMEMJNJKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4016570", Offset = "0x4015170", VA = "0x184016570")]
	public bool MFMIHJLDIOD(float PALEMBNPKFN, float PHDNJKFMJDM, [Out] T GLMEMJNJKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4016220", Offset = "0x4014E20", VA = "0x184016220")]
	public void LBEGPBJGKPJ(float PALEMBNPKFN, float PHDNJKFMJDM, List<T> BKHGNPANPPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4016540", Offset = "0x4015140", VA = "0x184016540")]
	private int LINDLFAEDDI(int NINBJELJDPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4017260", Offset = "0x4015E60", VA = "0x184017260")]
	private void OONGBGPOOLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T OJCNCNCFEDC();

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T PCKIPKONONO(T GLMEMJNJKAN, float NEAJEANMBOG);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T HNGFLLBFMJK(T HLHDFJDLHFM, T GIHDHONABPM);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T NJLJEAOCGCE(T HLHDFJDLHFM, T GIHDHONABPM);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class EGLOONAEBOO : JDBHJDMCMDE<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x853CF0", Offset = "0x8528F0", VA = "0x180853CF0", Slot = "4")]
	protected override Vector3 OJCNCNCFEDC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x68A4640", Offset = "0x68A3240", VA = "0x1868A4640", Slot = "5")]
	protected override Vector3 PCKIPKONONO(Vector3 GLMEMJNJKAN, float NEAJEANMBOG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x68A4570", Offset = "0x68A3170", VA = "0x1868A4570", Slot = "6")]
	protected override Vector3 HNGFLLBFMJK(Vector3 HLHDFJDLHFM, Vector3 GIHDHONABPM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x68A45C0", Offset = "0x68A31C0", VA = "0x1868A45C0", Slot = "7")]
	protected override Vector3 NJLJEAOCGCE(Vector3 HLHDFJDLHFM, Vector3 GIHDHONABPM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x68A4680", Offset = "0x68A3280", VA = "0x1868A4680")]
	public EGLOONAEBOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class ICDNDJABEJN
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2B2D040", Offset = "0x2B2BC40", VA = "0x182B2D040")]
	public static LENOMOJALKL<T1, T2> GADNMLFOLLL<T1, T2>(T1 HCGOPPEBDAK, T2 GAJKHMBEMID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2B2D0E0", Offset = "0x2B2BCE0", VA = "0x182B2D0E0")]
	public static AOJANHHPFFM<T1, T2, T3> GADNMLFOLLL<T1, T2, T3>(T1 HCGOPPEBDAK, T2 GAJKHMBEMID, T3 BIGOLEGKECI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x446DD60", Offset = "0x446C960", VA = "0x18446DD60")]
	internal static int GMLNAMEAFME(int OEEKNPILOPO, int BOBCGEJAMPL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5C90850", Offset = "0x5C8F450", VA = "0x185C90850")]
	internal static int GMLNAMEAFME(int OEEKNPILOPO, int BOBCGEJAMPL, int MCIHIKGPJFJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class LENOMOJALKL<T1, T2> : IComparable<LENOMOJALKL<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly T1 EICBCJBEDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly T2 BGCLPKPEDCK;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x41F5D80", Offset = "0x41F4980", VA = "0x1841F5D80")]
	public LENOMOJALKL(T1 HCGOPPEBDAK, T2 GAJKHMBEMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x41F3FD0", Offset = "0x41F2BD0", VA = "0x1841F3FD0", Slot = "4")]
	public int CompareTo(LENOMOJALKL<T1, T2> OCNJFCPHJLD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x41F46B0", Offset = "0x41F32B0", VA = "0x1841F46B0", Slot = "0")]
	public override bool Equals(object OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x41F5350", Offset = "0x41F3F50", VA = "0x1841F5350", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x41F5490", Offset = "0x41F4090", VA = "0x1841F5490", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class AOJANHHPFFM<T1, T2, T3> : IComparable<AOJANHHPFFM<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly T1 EICBCJBEDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly T2 BGCLPKPEDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly T3 HGAOGBCDADN;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3DF06A0", Offset = "0x3DEF2A0", VA = "0x183DF06A0")]
	public AOJANHHPFFM(T1 HCGOPPEBDAK, T2 GAJKHMBEMID, T3 BIGOLEGKECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3DEFD70", Offset = "0x3DEE970", VA = "0x183DEFD70", Slot = "4")]
	public int CompareTo(AOJANHHPFFM<T1, T2, T3> OCNJFCPHJLD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3DF0020", Offset = "0x3DEEC20", VA = "0x183DF0020", Slot = "0")]
	public override bool Equals(object OCNJFCPHJLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3DF02B0", Offset = "0x3DEEEB0", VA = "0x183DF02B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3DF04F0", Offset = "0x3DEF0F0", VA = "0x183DF04F0", Slot = "3")]
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
	public T EPAONLOANJK
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x22F42E0", Offset = "0x22F2EE0", VA = "0x1822F42E0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x22F41F0", Offset = "0x22F2DF0", VA = "0x1822F41F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float OJMHPOGHPNH
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8B3190", Offset = "0x8B1D90", VA = "0x1808B3190")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4B95C70", Offset = "0x4B94870", VA = "0x184B95C70")]
	public T HOIPLNANFAD(float NEAJEANMBOG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4B95970", Offset = "0x4B94570", VA = "0x184B95970")]
	public T HJIGAJKDNNG(float NEAJEANMBOG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T CGMFAPODNCI(T HLHDFJDLHFM, T GIHDHONABPM, float NEAJEANMBOG);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x68A5380", Offset = "0x68A3F80", VA = "0x1868A5380", Slot = "4")]
	protected override float CGMFAPODNCI(float HLHDFJDLHFM, float GIHDHONABPM, float NEAJEANMBOG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x68A53C0", Offset = "0x68A3FC0", VA = "0x1868A53C0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xE5D210", Offset = "0xE5BE10", VA = "0x180E5D210", Slot = "4")]
	protected override Vector3 CGMFAPODNCI(Vector3 HLHDFJDLHFM, Vector3 GIHDHONABPM, float NEAJEANMBOG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x68A7850", Offset = "0x68A6450", VA = "0x1868A7850")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x68A31B0", Offset = "0x68A1DB0", VA = "0x1868A31B0", Slot = "4")]
	protected override Color CGMFAPODNCI(Color HLHDFJDLHFM, Color GIHDHONABPM, float NEAJEANMBOG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x68A3270", Offset = "0x68A1E70", VA = "0x1868A3270")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class NPGPJGFJJHM : FBELLGDGAMI<string>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x68A5710", Offset = "0x68A4310", VA = "0x1868A5710")]
	public NPGPJGFJJHM(int ECCOECALPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x68A56A0", Offset = "0x68A42A0", VA = "0x1868A56A0", Slot = "6")]
	protected override uint BNLFDNIKHFO(uint LNMBFIMPMFA, string GLMEMJNJKAN)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class PAEBHFMPOJA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly IDisposable GGKBGANLBLD;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public PAEBHFMPOJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct HJLKKAJGLNL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> JKKLCGCGBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int PAAEMKNDHDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int LHGDIDICNIC;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3D4ED60", Offset = "0x3D4D960", VA = "0x183D4ED60")]
	private HJLKKAJGLNL(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> KJOPCGHHNKJ, int DCLOCBIHLHL, int OMLBMJPOGDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3D4EC60", Offset = "0x3D4D860", VA = "0x183D4EC60")]
	public static HJLKKAJGLNL<T> PPOPBMPFEOP()
	{
		return default(HJLKKAJGLNL<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3D4D700", Offset = "0x3D4C300", VA = "0x183D4D700")]
	public (int, int, Task<T>) CKOPGMMPGEH(int OPBLCCPLEKK, [Optional] CancellationToken MPLCHGMFENA, double EACMJFLDLDP = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3D4CDD0", Offset = "0x3D4B9D0", VA = "0x183D4CDD0")]
	public void AIGFGELDJCI(int OPBLCCPLEKK, int OMLBMJPOGDN, [In] T JFBAIGMLPKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class HCMFNKHHAAC
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x68A5480", Offset = "0x68A4080", VA = "0x1868A5480")]
	public static HJLKKAJGLNL<LOGIJBPEHJN> PPOPBMPFEOP()
	{
		return default(HJLKKAJGLNL<LOGIJBPEHJN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x68A5400", Offset = "0x68A4000", VA = "0x1868A5400")]
	public static void AIGFGELDJCI([In] this HJLKKAJGLNL<LOGIJBPEHJN> HNFMOHFACKF, int OPBLCCPLEKK, int OMLBMJPOGDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class MJFODILCEAC<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<TKey, TVal> DCCCNKBFFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly Dictionary<TVal, TKey> ONOGOIOHCLF;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int FPIENNPNDKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3551D00", Offset = "0x3550900", VA = "0x183551D00", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool LJENBABOAFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ICollection<TKey> LHBMEDHPNHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x4065990", Offset = "0x4064590", VA = "0x184065990", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> AAKCJJGLPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3802960", Offset = "0x3801560", VA = "0x183802960", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal ENBJMEPMEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x43FDFF0", Offset = "0x43FCBF0", VA = "0x1843FDFF0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x43FE050", Offset = "0x43FCC50", VA = "0x1843FE050", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey ENBJMEPMEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x43FD970", Offset = "0x43FC570", VA = "0x1843FD970")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x43FD090", Offset = "0x43FBC90", VA = "0x1843FD090", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x43FDD80", Offset = "0x43FC980", VA = "0x1843FDD80", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x43FCEE0", Offset = "0x43FBAE0", VA = "0x1843FCEE0", Slot = "9")]
	public void Add(TKey DPHIOKCFMFC, TVal GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x43FCF30", Offset = "0x43FBB30", VA = "0x1843FCF30", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> LBACBPHHKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3C741E0", Offset = "0x3C72DE0", VA = "0x183C741E0", Slot = "8")]
	public bool ContainsKey(TKey DPHIOKCFMFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x43FD170", Offset = "0x43FBD70", VA = "0x1843FD170", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> LBACBPHHKAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x43FDCC0", Offset = "0x43FC8C0", VA = "0x1843FDCC0", Slot = "10")]
	public bool Remove(TKey DPHIOKCFMFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x43FDD00", Offset = "0x43FC900", VA = "0x1843FDD00", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> LBACBPHHKAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x43FDE70", Offset = "0x43FCA70", VA = "0x1843FDE70", Slot = "11")]
	public bool TryGetValue(TKey DPHIOKCFMFC, [Out] TVal GLMEMJNJKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x43FD8D0", Offset = "0x43FC4D0", VA = "0x1843FD8D0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x43FD1F0", Offset = "0x43FBDF0", VA = "0x1843FD1F0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] CHPEIOMPEEH, int JNGLDMDNOGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x43FD030", Offset = "0x43FBC30", VA = "0x1843FD030")]
	public bool CMBHFEACNLN(TVal DPHIOKCFMFC, [Out] TKey GLMEMJNJKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x43FDA30", Offset = "0x43FC630", VA = "0x1843FDA30")]
	private void PPAOPCNCFHO(TKey DPHIOKCFMFC, TVal CLJFFIBMODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x43FD270", Offset = "0x43FBE70", VA = "0x1843FD270")]
	private void FGAMFEMNAAI(TKey DPHIOKCFMFC, TVal CLJFFIBMODC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x43FD720", Offset = "0x43FC320", VA = "0x1843FD720")]
	private bool FGHCBLLEHPO(TKey DPHIOKCFMFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x43FDED0", Offset = "0x43FCAD0", VA = "0x1843FDED0")]
	public MJFODILCEAC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[DefaultMember("Item")]
public class FONBBAEEDLP<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private FONBBAEEDLP<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x3878190", Offset = "0x3876D90", VA = "0x183878190", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x387F930", Offset = "0x387E530", VA = "0x18387F930", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3880C60", Offset = "0x387F860", VA = "0x183880C60")]
		public Enumerator(FONBBAEEDLP<T> BKHGNPANPPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x387E1C0", Offset = "0x387CDC0", VA = "0x18387E1C0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x387EBD0", Offset = "0x387D7D0", VA = "0x18387EBD0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x387CF50", Offset = "0x387BB50", VA = "0x18387CF50")]
		private void IIHLGAPJBNH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private T[] NNPPNIHAGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private int PAGNMFPMINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int DEBHHNDJNKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int IDPOJNOELJM;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int FPIENNPNDKO
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3BDD850", Offset = "0x3BDC450", VA = "0x183BDD850")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T ENBJMEPMEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3BDD050", Offset = "0x3BDBC50", VA = "0x183BDD050")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x3BDBCD0", Offset = "0x3BDA8D0", VA = "0x183BDBCD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3BDDCA0", Offset = "0x3BDC8A0", VA = "0x183BDDCA0")]
	public FONBBAEEDLP(int ECCOECALPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3BDD350", Offset = "0x3BDBF50", VA = "0x183BDD350")]
	public void MPFJKDGCCNN(T NEAJEANMBOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3BDD9A0", Offset = "0x3BDC5A0", VA = "0x183BDD9A0")]
	public void ONDHHAABKMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3BDC5E0", Offset = "0x3BDB1E0", VA = "0x183BDC5E0")]
	public void HENJMBKCNLD(int HDFABDCMCAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3BDCB00", Offset = "0x3BDB700", VA = "0x183BDCB00")]
	public void HFACIDFKBCD(T[] CHPEIOMPEEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3BDD890", Offset = "0x3BDC490", VA = "0x183BDD890")]
	public Enumerator NDANHGBCNEI()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3BDDBE0", Offset = "0x3BDC7E0", VA = "0x183BDDBE0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3BDDBE0", Offset = "0x3BDC7E0", VA = "0x183BDDBE0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3BDC380", Offset = "0x3BDAF80", VA = "0x183BDC380")]
	private int FFFHMONNINF(int OPDMGNJCACB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3BDBE90", Offset = "0x3BDAA90", VA = "0x183BDBE90")]
	private int DFGKBDINBBL(int OPDMGNJCACB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class MNNNHMPELMA<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate Task<TResult> GIKOJODLIDF(TRequest CLBGLGJCBEB, CancellationToken MPLCHGMFENA);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public enum PIJCMNNHJPN
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class MAPPGOAPPKA
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private const float GMNCLBHPIJO = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TimeSpan BMIHDNJGGBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int LGJCAIPJPDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public PIJCMNNHJPN LGEFCAOHDOI;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static readonly MAPPGOAPPKA IOGFCHMIMPG;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float NDMLBGBPIOA
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x43E3600", Offset = "0x43E2200", VA = "0x1843E3600")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public TimeSpan LCJGDCAANNF
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x43E3830", Offset = "0x43E2430", VA = "0x1843E3830")]
		public MAPPGOAPPKA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private readonly struct EGDHIEKJPOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly TRequest CLBGLGJCBEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly CancellationToken MPLCHGMFENA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly TaskCompletionSource<TResult> LDHFNFOBHGO;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x37EDF30", Offset = "0x37ECB30", VA = "0x1837EDF30")]
		public EGDHIEKJPOF(TRequest CLBGLGJCBEB, TaskCompletionSource<TResult> LDHFNFOBHGO, CancellationToken MPLCHGMFENA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct KLHFOAPDMJK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public MNNNHMPELMA<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4155EE0", Offset = "0x4154AE0", VA = "0x184155EE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4156B40", Offset = "0x4155740", VA = "0x184156B40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct LNHLCDCMOGI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public MNNNHMPELMA<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private EGDHIEKJPOF <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x42241A0", Offset = "0x4222DA0", VA = "0x1842241A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x4225470", Offset = "0x4224070", VA = "0x184225470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly CancellationTokenSource FKJEAEJLOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly List<EGDHIEKJPOF> AJHIGIFNPNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly MAPPGOAPPKA KIOEIDEJBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly GIKOJODLIDF NFFHNMKJBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Task OBJMDOENOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private int BJKJGPFHIHI;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x44241E0", Offset = "0x4422DE0", VA = "0x1844241E0")]
	public MNNNHMPELMA(GIKOJODLIDF NFFHNMKJBBA, [Optional] MAPPGOAPPKA KIOEIDEJBDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4422700", Offset = "0x4421300", VA = "0x184422700")]
	public Task<TResult> ENEIHKBICDO(TRequest CLBGLGJCBEB, CancellationToken MPLCHGMFENA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4423270", Offset = "0x4421E70", VA = "0x184423270")]
	private void KMCLBCMMPHP(EGDHIEKJPOF DEGPEKDEAIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4422E50", Offset = "0x4421A50", VA = "0x184422E50")]
	[AsyncStateMachine(typeof(MNNNHMPELMA<, >.KLHFOAPDMJK))]
	private Task JGAAGCFHIOH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x44238F0", Offset = "0x44224F0", VA = "0x1844238F0")]
	private EGDHIEKJPOF OPNMNEAICIO()
	{
		return default(EGDHIEKJPOF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4423530", Offset = "0x4422130", VA = "0x184423530")]
	[AsyncStateMachine(typeof(MNNNHMPELMA<, >.LNHLCDCMOGI))]
	private Task MFNNACEDAFP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4422B50", Offset = "0x4421750", VA = "0x184422B50")]
	private void HPJMHHMMFFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4422440", Offset = "0x4421040", VA = "0x184422440", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class EANADAMBCGL<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly List<T> KNDOIJDCKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private HashSet<T> DGGKLAIOBLP;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int FPIENNPNDKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3551D00", Offset = "0x3550900", VA = "0x183551D00", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool LJENBABOAFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x88BE10", Offset = "0x88AA10", VA = "0x18088BE10", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public T ENBJMEPMEBJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x26D2720", Offset = "0x26D1320", VA = "0x1826D2720", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x37AA0D0", Offset = "0x37A8CD0", VA = "0x1837AA0D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x37A9300", Offset = "0x37A7F00", VA = "0x1837A9300", Slot = "11")]
	public void Add(T LBACBPHHKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x37A9490", Offset = "0x37A8090", VA = "0x1837A9490")]
	public bool GOFOFMOGKHH(T LBACBPHHKAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x37A9D70", Offset = "0x37A8970", VA = "0x1837A9D70", Slot = "15")]
	public bool Remove(T LBACBPHHKAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x37A9690", Offset = "0x37A8290", VA = "0x1837A9690", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x37A9E30", Offset = "0x37A8A30", VA = "0x1837A9E30", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x37A9340", Offset = "0x37A7F40", VA = "0x1837A9340", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x37A93E0", Offset = "0x37A7FE0", VA = "0x1837A93E0", Slot = "13")]
	public bool Contains(T LBACBPHHKAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x37A9430", Offset = "0x37A8030", VA = "0x1837A9430", Slot = "14")]
	public void CopyTo(T[] CHPEIOMPEEH, int JNGLDMDNOGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x37A9720", Offset = "0x37A8320", VA = "0x1837A9720", Slot = "6")]
	public int IndexOf(T LBACBPHHKAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x37A9780", Offset = "0x37A8380", VA = "0x1837A9780", Slot = "7")]
	public void Insert(int OPDMGNJCACB, T LBACBPHHKAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x37A9A10", Offset = "0x37A8610", VA = "0x1837A9A10", Slot = "8")]
	public void RemoveAt(int OPDMGNJCACB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x37A9E70", Offset = "0x37A8A70", VA = "0x1837A9E70")]
	public EANADAMBCGL()
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
			[Cpp2IlInjected.Address(RVA = "0x216E030", Offset = "0x216CC30", VA = "0x18216E030")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x68A6FB0", Offset = "0x68A5BB0", VA = "0x1868A6FB0")]
		public SerializedGuid([In] Guid CICFLOBNFHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x68A6E80", Offset = "0x68A5A80", VA = "0x1868A6E80")]
		public static SerializedGuid MIMHDHHJLAE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x68A6E10", Offset = "0x68A5A10", VA = "0x1868A6E10")]
		public static SerializedGuid LAJJHDKFEFL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x68A6DB0", Offset = "0x68A59B0", VA = "0x1868A6DB0")]
		public bool IHNECOIEJHB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x68A6F80", Offset = "0x68A5B80", VA = "0x1868A6F80", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x68A6F00", Offset = "0x68A5B00", VA = "0x1868A6F00", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x68A6CD0", Offset = "0x68A58D0", VA = "0x1868A6CD0", Slot = "7")]
		public bool Equals(SerializedGuid OCNJFCPHJLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x68A6D10", Offset = "0x68A5910", VA = "0x1868A6D10", Slot = "0")]
		public override bool Equals(object HAHECKLGOJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x68A6DA0", Offset = "0x68A59A0", VA = "0x1868A6DA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x68A6CA0", Offset = "0x68A58A0", VA = "0x1868A6CA0", Slot = "6")]
		public int CompareTo(SerializedGuid OCNJFCPHJLD)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class BLBOKHOKHAL : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly Type JAFAJLICCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly string EPOHMOMIDIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool MICJNAGPIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool LJGCBECMEKB;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x68A2FF0", Offset = "0x68A1BF0", VA = "0x1868A2FF0")]
	public BLBOKHOKHAL(Type EIINHAEMPPE, string AMFKLDAHAPL, bool BKICJOPDDGD = false, bool EEKEDOJBDED = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class GDCBCFBEPNI<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public readonly struct JGCGKDEDHAB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly long NNAHABIKBKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly long PJGCGBDHDNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly int EFEFMFLPMEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly int CJBGPBAMOAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly bool IGBKLCKCDFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly string CEJAICKLEMG;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x4032C90", Offset = "0x4031890", VA = "0x184032C90")]
		public JGCGKDEDHAB(long NNAHABIKBKB, int EFEFMFLPMEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x4032C60", Offset = "0x4031860", VA = "0x184032C60")]
		public JGCGKDEDHAB(long NNAHABIKBKB, long PJGCGBDHDNH, int EFEFMFLPMEP, int CJBGPBAMOAH, bool IGBKLCKCDFB, string CEJAICKLEMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x4032AF0", Offset = "0x40316F0", VA = "0x184032AF0")]
		public int FNFCENADIFL()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x4032C40", Offset = "0x4031840", VA = "0x184032C40")]
		public int MJMCJMDECJO(int BDHBGEBMKBN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4032B40", Offset = "0x4031740", VA = "0x184032B40")]
		public double IOODCDEAGJP()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x4032BA0", Offset = "0x40317A0", VA = "0x184032BA0")]
		public JGCGKDEDHAB JCAAFBHHDLE(long PJGCGBDHDNH, int CJBGPBAMOAH)
		{
			return default(JGCGKDEDHAB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class LHHFCPKIPMG : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private struct IJKFNKICMFF<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public LHHFCPKIPMG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Func<LHHFCPKIPMG, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private LHHFCPKIPMG <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x3E37120", Offset = "0x3E35D20", VA = "0x183E37120", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x3B969F0", Offset = "0x3B955F0", VA = "0x183B969F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly TKey NEMDOAJKGDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly GDCBCFBEPNI<TKey> JKELFCJBEII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public readonly KEDKJKIEEGM MIIBHDDJGII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private List<LHHFCPKIPMG> KLGAIJGBDNL;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public string KCODMHGJHFE
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x42000A0", Offset = "0x41FECA0", VA = "0x1842000A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public IEnumerable<LHHFCPKIPMG> ENJDMAIPEGJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x41FFE10", Offset = "0x41FEA10", VA = "0x1841FFE10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public JGCGKDEDHAB GFAAHKKJKAP
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x42000F0", Offset = "0x41FECF0", VA = "0x1842000F0")]
			[CompilerGenerated]
			get
			{
				return default(JGCGKDEDHAB);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x4200110", Offset = "0x41FED10", VA = "0x184200110")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x42002F0", Offset = "0x41FEEF0", VA = "0x1842002F0")]
		internal LHHFCPKIPMG(GDCBCFBEPNI<TKey> JKELFCJBEII, TKey DPHIOKCFMFC, KEDKJKIEEGM MIIBHDDJGII)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4200140", Offset = "0x41FED40", VA = "0x184200140")]
		public LHHFCPKIPMG ONFFJCNGGAF(TKey DPHIOKCFMFC, [Optional] KEDKJKIEEGM? DFLMBHOGOGN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2816290", Offset = "0x2814E90", VA = "0x182816290")]
		[AsyncStateMachine(typeof(IJKFNKICMFF<>))]
		public Task<T> LBJCIKLMKPH<T>(TKey DPHIOKCFMFC, Func<LHHFCPKIPMG, Task<T>> DFEAGIPALPH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x41FFE50", Offset = "0x41FEA50", VA = "0x1841FFE50", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class OEEMFOJFLMK : IEnumerable<(TKey, List<TKey>, JGCGKDEDHAB)>, IEnumerable, IEnumerator<(TKey, List<TKey>, JGCGKDEDHAB)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private (TKey key, List<TKey> path, JGCGKDEDHAB timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public GDCBCFBEPNI<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IEnumerator<(TKey key, List<TKey> path, JGCGKDEDHAB timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private (TKey, List<TKey>, JGCGKDEDHAB) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x2171530", Offset = "0x2170130", VA = "0x182171530", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, JGCGKDEDHAB));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x45814B0", Offset = "0x45800B0", VA = "0x1845814B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2171620", Offset = "0x2170220", VA = "0x182171620")]
		[DebuggerHidden]
		public OEEMFOJFLMK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x3A51170", Offset = "0x3A4FD70", VA = "0x183A51170", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x4580FF0", Offset = "0x457FBF0", VA = "0x184580FF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4580FA0", Offset = "0x457FBA0", VA = "0x184580FA0")]
		private void FMFBFJNMNDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4581460", Offset = "0x4580060", VA = "0x184581460", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x4581390", Offset = "0x457FF90", VA = "0x184581390", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, JGCGKDEDHAB)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3A594A0", Offset = "0x3A580A0", VA = "0x183A594A0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class CNJMBCLCCNB : IEnumerable<(TKey, List<TKey>, JGCGKDEDHAB)>, IEnumerable, IEnumerator<(TKey, List<TKey>, JGCGKDEDHAB)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private (TKey key, List<TKey> path, JGCGKDEDHAB timerEntry) <>2__current;

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
		private LHHFCPKIPMG timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public LHHFCPKIPMG <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public GDCBCFBEPNI<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private IEnumerator<LHHFCPKIPMG> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private IEnumerator<(TKey key, List<TKey> path, JGCGKDEDHAB timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, JGCGKDEDHAB) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x2171530", Offset = "0x2170130", VA = "0x182171530", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, JGCGKDEDHAB));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x5380A60", Offset = "0x537F660", VA = "0x185380A60", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2171620", Offset = "0x2170220", VA = "0x182171620")]
		[DebuggerHidden]
		public CNJMBCLCCNB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5380AC0", Offset = "0x537F6C0", VA = "0x185380AC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5380150", Offset = "0x537ED50", VA = "0x185380150", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x53800F0", Offset = "0x537ECF0", VA = "0x1853800F0")]
		private void FMFBFJNMNDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5380090", Offset = "0x537EC90", VA = "0x185380090")]
		private void CJOPDLOOCAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5380A10", Offset = "0x537F610", VA = "0x185380A10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x5380910", Offset = "0x537F510", VA = "0x185380910", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, JGCGKDEDHAB)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x4972C10", Offset = "0x4971810", VA = "0x184972C10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly Action<TKey, JGCGKDEDHAB, KEDKJKIEEGM> NFLBENAPPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Action<TKey, JGCGKDEDHAB, KEDKJKIEEGM> BLCFKPIBIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly Action<GDCBCFBEPNI<TKey>, KEDKJKIEEGM> CMNIFBAEIDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly KEDKJKIEEGM MIIBHDDJGII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly LHHFCPKIPMG EFINLGKOGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private bool JAMLMCMFMMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int GDNLDMIGALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly Stopwatch LKGMJIHFHIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly int NDLBBCFDCOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string GPBBAENFOIG;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public LHHFCPKIPMG POAFDFEDKPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	[NotNull]
	public string KCODMHGJHFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x8433B0", Offset = "0x841FB0", VA = "0x1808433B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x3C72E60", Offset = "0x3C71A60", VA = "0x183C72E60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x3C73040", Offset = "0x3C71C40", VA = "0x183C73040")]
	public GDCBCFBEPNI(TKey JDFKGHEOHJA, KEDKJKIEEGM MIIBHDDJGII, [Optional] int? EFEFMFLPMEP, [Optional][CanBeNull] Stopwatch LKGMJIHFHIB, [Optional] Action<TKey, JGCGKDEDHAB, KEDKJKIEEGM> NFLBENAPPBM, [Optional] Action<TKey, JGCGKDEDHAB, KEDKJKIEEGM> BLCFKPIBIME, [Optional] Action<GDCBCFBEPNI<TKey>, KEDKJKIEEGM> CMNIFBAEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x3C72D90", Offset = "0x3C71990", VA = "0x183C72D90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x3C72FA0", Offset = "0x3C71BA0", VA = "0x183C72FA0")]
	[IteratorStateMachine(typeof(GDCBCFBEPNI<>.OEEMFOJFLMK))]
	public IEnumerable<(TKey, List<TKey>, JGCGKDEDHAB)> ONDHDONEKIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x3C72EC0", Offset = "0x3C71AC0", VA = "0x183C72EC0")]
	[IteratorStateMachine(typeof(GDCBCFBEPNI<>.CNJMBCLCCNB))]
	private IEnumerable<(TKey, List<TKey>, JGCGKDEDHAB)> ONDHDONEKIH(List<TKey> OMBOFKDENLD, LHHFCPKIPMG FKAHALBBJEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x3C72D10", Offset = "0x3C71910", VA = "0x183C72D10")]
	private (long, int) DMIFOFPCDOA()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public abstract class FCPMOJPDOAN<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut PFMBDNMMLIP(GDCBCFBEPNI<TKey> JKELFCJBEII);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	protected FCPMOJPDOAN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public abstract class FLGACICHHCB<TKey> : FCPMOJPDOAN<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate string FCNABLPOHLJ(TKey DPHIOKCFMFC);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3BAC040", Offset = "0x3BAAC40", VA = "0x183BAC040")]
	private static string EHPBNBOJPKF(TKey DPHIOKCFMFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3BAC1D0", Offset = "0x3BAADD0", VA = "0x183BAC1D0", Slot = "4")]
	public override string PFMBDNMMLIP(GDCBCFBEPNI<TKey> JKELFCJBEII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3BAC080", Offset = "0x3BAAC80", VA = "0x183BAC080")]
	public string PFMBDNMMLIP(GDCBCFBEPNI<TKey> JKELFCJBEII, [NotNull] FCNABLPOHLJ BBOBPCMFONP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string INDKGOBLHOI(GDCBCFBEPNI<TKey> JKELFCJBEII, [NotNull] FCNABLPOHLJ BBOBPCMFONP);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3BAC2B0", Offset = "0x3BAAEB0", VA = "0x183BAC2B0")]
	protected FLGACICHHCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class GLGLJOICFAP<TKey> : FCPMOJPDOAN<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public delegate string GNKCIHPFIEL(TKey DPHIOKCFMFC);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly string GBPNILFCPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly double IKJNLNFLJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly bool ABAFEGIKGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly int PGKJDBFPAFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly ISet<string> KPCPEBHJKCG;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3CE2E90", Offset = "0x3CE1A90", VA = "0x183CE2E90")]
	private static string EHPBNBOJPKF(TKey DPHIOKCFMFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3CE3AA0", Offset = "0x3CE26A0", VA = "0x183CE3AA0")]
	public GLGLJOICFAP(string GBPNILFCPBP = "F2", double IKJNLNFLJKD = double.MaxValue, bool ABAFEGIKGNI = false, int PGKJDBFPAFC = int.MaxValue, [Optional] ISet<string> KPCPEBHJKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3CE3380", Offset = "0x3CE1F80", VA = "0x183CE3380", Slot = "4")]
	public override Dictionary<string, string> PFMBDNMMLIP(GDCBCFBEPNI<TKey> JKELFCJBEII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3CE32A0", Offset = "0x3CE1EA0", VA = "0x183CE32A0")]
	private bool KJLJHKFDHEP(string BJMEIACFJKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3CE3460", Offset = "0x3CE2060", VA = "0x183CE3460")]
	public Dictionary<string, string> PFMBDNMMLIP(GDCBCFBEPNI<TKey> JKELFCJBEII, GNKCIHPFIEL BBOBPCMFONP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3CE2ED0", Offset = "0x3CE1AD0", VA = "0x183CE2ED0")]
	private string HGMFAHCMEBE(StringBuilder NCICINOANDH, List<TKey> HIJGLEAJMOD, GNKCIHPFIEL BBOBPCMFONP, bool HBFHCDPALEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3CE3140", Offset = "0x3CE1D40", VA = "0x183CE3140")]
	private static void IIMGENJGLLH(StringBuilder IDJFIKMHFAJ, string ELKLKNABJKI, bool JEDJFMIBIFI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class NLEGEKFPIJH<TKey> : FLGACICHHCB<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct CBLEHHBDAJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public FCNABLPOHLJ keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static NLEGEKFPIJH<TKey> GGKBGANLBLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly string[] DOMNEMLHEHC;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x449CC60", Offset = "0x449B860", VA = "0x18449CC60")]
	private NLEGEKFPIJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x449BBE0", Offset = "0x449A7E0", VA = "0x18449BBE0", Slot = "5")]
	protected override string INDKGOBLHOI(GDCBCFBEPNI<TKey> JKELFCJBEII, FCNABLPOHLJ BBOBPCMFONP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x449CA20", Offset = "0x449B620", VA = "0x18449CA20")]
	[CompilerGenerated]
	internal static string KEMBJEDEDLO(string DFPEIIDOAOP, TKey DPHIOKCFMFC, CBLEHHBDAJD P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class BDIFONCEBOA : GDCBCFBEPNI<string>
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class AGJKLOBLJKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Action<BDIFONCEBOA, KEDKJKIEEGM> callback;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public AGJKLOBLJKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x68A2820", Offset = "0x68A1420", VA = "0x1868A2820")]
		internal void KBHHDBHDFPN(GDCBCFBEPNI<string> timer, KEDKJKIEEGM log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x68A2EA0", Offset = "0x68A1AA0", VA = "0x1868A2EA0")]
	public BDIFONCEBOA(KEDKJKIEEGM MIIBHDDJGII, [Optional] string KFGBLBBEKMO, [Optional] int? EFEFMFLPMEP, [Optional] Stopwatch LKGMJIHFHIB, [Optional] Action<string, JGCGKDEDHAB, KEDKJKIEEGM> NFLBENAPPBM, [Optional] Action<string, JGCGKDEDHAB, KEDKJKIEEGM> BLCFKPIBIME, [Optional] Action<BDIFONCEBOA, KEDKJKIEEGM> CMNIFBAEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x68A2DE0", Offset = "0x68A19E0", VA = "0x1868A2DE0")]
	private static Action<GDCBCFBEPNI<string>, KEDKJKIEEGM> AJJPMOIEBCB(Action<BDIFONCEBOA, KEDKJKIEEGM> LHMNAJJOJLL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class LDEOCCLAPBA
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private class CKOIILIKPOM : LDEOCCLAPBA
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public static LDEOCCLAPBA GGKBGANLBLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x68A3060", Offset = "0x68A1C60", VA = "0x1868A3060")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override float GFAPMOHAOAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x98CD40", Offset = "0x98B940", VA = "0x18098CD40", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x68A3160", Offset = "0x68A1D60", VA = "0x1868A3160")]
		public CKOIILIKPOM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static LDEOCCLAPBA OLHCHDNGKBI;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static LDEOCCLAPBA IOGFCHMIMPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x68A5530", Offset = "0x68A4130", VA = "0x1868A5530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public abstract float GFAPMOHAOAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	protected LDEOCCLAPBA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface MFIADEKAGDN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool INNHKJOMFBL
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface OBOGMAPJNLF<T> : MFIADEKAGDN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	[NotNull]
	Task<T> JEAFLJMJAPP
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	[NotNull]
	NDHCMKMDIDG<T> PBELOHMCGHN
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class BJOCNCDJGEE
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2887200", Offset = "0x2885E00", VA = "0x182887200")]
	public static OBOGMAPJNLF<TResource> PAGHEEMGOIN<TResource, TId>(this CACHKFGGKGF<TId, TResource> EMPAPNNPHEJ, TId EPKGPGILADI, [Optional] Func<TId, CancellationToken, Task<TResource>>? LEDFPAMHEIF) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class GEKCGLHHPAN
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private sealed class CANPOHLDOBD<T> : OOLEBKHFHKL<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override Task<T?> JEAFLJMJAPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NDHCMKMDIDG<T?> PBELOHMCGHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x50C14A0", Offset = "0x50C00A0", VA = "0x1850C14A0")]
		public CANPOHLDOBD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "10")]
		protected override void JCJBLJHFBNB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private sealed class NGKDFFGKKAH<T> : OOLEBKHFHKL<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly T NKEPKJIGEMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly Action<T>? KFIPJKHLHKG;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override Task<T> JEAFLJMJAPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x843220", Offset = "0x841E20", VA = "0x180843220", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NDHCMKMDIDG<T> PBELOHMCGHN
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x843210", Offset = "0x841E10", VA = "0x180843210", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x448E7B0", Offset = "0x448D3B0", VA = "0x18448E7B0")]
		public NGKDFFGKKAH(T JAKEDICJBKP, Action<T>? OJBPIBKEGDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x448E5C0", Offset = "0x448D1C0", VA = "0x18448E5C0", Slot = "10")]
		protected override void JCJBLJHFBNB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private sealed class LCAAALBIFFF<T> : OOLEBKHFHKL<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override Task<T> JEAFLJMJAPP
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override NDHCMKMDIDG<T> PBELOHMCGHN
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x41EE3E0", Offset = "0x41ECFE0", VA = "0x1841EE3E0")]
		public LCAAALBIFFF(Exception INCJNHFIGKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "10")]
		protected override void JCJBLJHFBNB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private sealed class DGKCKFEKKLO<T> : OOLEBKHFHKL<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct KKAFKOGEFGC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public Task<OBOGMAPJNLF<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private TaskAwaiter<OBOGMAPJNLF<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x41542F0", Offset = "0x4152EF0", VA = "0x1841542F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x4154CD0", Offset = "0x41538D0", VA = "0x184154CD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct KLOEGLGGDCI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public Task<OBOGMAPJNLF<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private TaskAwaiter<OBOGMAPJNLF<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x4158360", Offset = "0x4156F60", VA = "0x184158360", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x4158590", Offset = "0x4157190", VA = "0x184158590", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly Task<OBOGMAPJNLF<T>> IKNCGLKCFEF;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override Task<T> JEAFLJMJAPP
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override NDHCMKMDIDG<T> PBELOHMCGHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x843500", Offset = "0x842100", VA = "0x180843500", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x57D0D20", Offset = "0x57CF920", VA = "0x1857D0D20")]
		public DGKCKFEKKLO(Task<OBOGMAPJNLF<T>> HPIAAAJAFJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x57D0C00", Offset = "0x57CF800", VA = "0x1857D0C00", Slot = "10")]
		protected override void JCJBLJHFBNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x57D08D0", Offset = "0x57CF4D0", VA = "0x1857D08D0")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(DGKCKFEKKLO<>.KKAFKOGEFGC))]
		internal static Task<T> DHNBDCPFMIH(Task<OBOGMAPJNLF<T>> HPIAAAJAFJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x57D0B20", Offset = "0x57CF720", VA = "0x1857D0B20")]
		[AsyncStateMachine(typeof(DGKCKFEKKLO<>.KLOEGLGGDCI))]
		[CompilerGenerated]
		internal static Task EJIAJAFGOAC(Task<OBOGMAPJNLF<T>> HPIAAAJAFJD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private sealed class GCOJPOJMGLF<TIn, TOut> : OOLEBKHFHKL<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct KKIFFFAKBBG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public AsyncTaskMethodBuilder<TOut> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public Func<TIn, TOut> transformFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public Task<TIn> innerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private Func<TIn, TOut> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private TaskAwaiter<TIn> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x41551C0", Offset = "0x4153DC0", VA = "0x1841551C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x3CA6DD0", Offset = "0x3CA59D0", VA = "0x183CA6DD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly OBOGMAPJNLF<TIn> IKBOPDJEEEA;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override Task<TOut> JEAFLJMJAPP
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override NDHCMKMDIDG<TOut> PBELOHMCGHN
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x843500", Offset = "0x842100", VA = "0x180843500", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3C72A60", Offset = "0x3C71660", VA = "0x183C72A60")]
		public GCOJPOJMGLF(OBOGMAPJNLF<TIn> CMHKFOLNCOM, Func<TIn, TOut> IGCGPCKOJFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3C726C0", Offset = "0x3C712C0", VA = "0x183C726C0", Slot = "10")]
		protected override void JCJBLJHFBNB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3C72760", Offset = "0x3C71360", VA = "0x183C72760")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(GCOJPOJMGLF<, >.KKIFFFAKBBG))]
		internal static Task<TOut> OBKCMHDNIDI(Task<TIn> JGOBBFOLLGJ, Func<TIn, TOut> IGCGPCKOJFD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2B0CC00", Offset = "0x2B0B800", VA = "0x182B0CC00")]
	public static OBOGMAPJNLF<T> BBCAMDNMADI<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2B0CC80", Offset = "0x2B0B880", VA = "0x182B0CC80")]
	public static OBOGMAPJNLF<T> LFDKBDOIKCH<T>(T JFBAIGMLPKE, [Optional] Action<T>? OJBPIBKEGDN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x292BA60", Offset = "0x292A660", VA = "0x18292BA60")]
	public static OBOGMAPJNLF<T> OBDMGMBJDLK<T>(Exception INCJNHFIGKH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x292BA60", Offset = "0x292A660", VA = "0x18292BA60")]
	public static OBOGMAPJNLF<T> LMMBGANPMCE<T>(Task<OBOGMAPJNLF<T>> HPIAAAJAFJD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x288AB30", Offset = "0x2889730", VA = "0x18288AB30")]
	public static OBOGMAPJNLF<TOut> KIMEAEOEPFL<TOut, TIn>(OBOGMAPJNLF<TIn> POAHFHMMEAF, Func<TIn, TOut> IGCGPCKOJFD) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public abstract class OOLEBKHFHKL<T> : OBOGMAPJNLF<T>, MFIADEKAGDN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static readonly string EPHAGBPLGPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly DEAGKENLJKN FLHNMKEJPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private bool JAMLMCMFMMA;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool INNHKJOMFBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xB6AC20", Offset = "0xB69820", VA = "0x180B6AC20", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public abstract Task<T> JEAFLJMJAPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public abstract NDHCMKMDIDG<T> PBELOHMCGHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x4655A10", Offset = "0x4654610", VA = "0x184655A10")]
	public OOLEBKHFHKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x4655560", Offset = "0x4654160", VA = "0x184655560", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void JCJBLJHFBNB();
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public abstract class LGLOBCOFOMM<TTask, T> : OOLEBKHFHKL<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class ENEFLONGFPA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public ENEFLONGFPA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x353F880", Offset = "0x353E480", VA = "0x18353F880", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x353FDD0", Offset = "0x353E9D0", VA = "0x18353FDD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public LGLOBCOFOMM<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public ENEFLONGFPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x380D0A0", Offset = "0x380BCA0", VA = "0x18380D0A0")]
		[AsyncStateMachine(typeof(LGLOBCOFOMM<, >.ENEFLONGFPA.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> IDDGKKLGAOA(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly Task<T> HPIAAAJAFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	protected readonly CancellationTokenSource BMBBMOBAEFA;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public override Task<T> JEAFLJMJAPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public override NDHCMKMDIDG<T> PBELOHMCGHN
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x41F6B70", Offset = "0x41F5770", VA = "0x1841F6B70")]
	protected LGLOBCOFOMM(TTask HPIAAAJAFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x41F6920", Offset = "0x41F5520", VA = "0x1841F6920", Slot = "10")]
	protected override void JCJBLJHFBNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T CEIMIANEIHK(TTask PCPOPIJAJCI);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void BHGHIILGJPG();
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class KIFNPHCAALE<T> : OOLEBKHFHKL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly BLPMMPOKDIJ<Task<T>> LCCGAKAHNDN;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public override Task<T> JEAFLJMJAPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3D45D20", Offset = "0x3D44920", VA = "0x183D45D20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public override NDHCMKMDIDG<T> PBELOHMCGHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x4151990", Offset = "0x4150590", VA = "0x184151990")]
	public KIFNPHCAALE(BLPMMPOKDIJ<Task<T>> HIHGCPNOLMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x4151970", Offset = "0x4150570", VA = "0x184151970", Slot = "10")]
	protected override void JCJBLJHFBNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class APHANFIJLLK
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x68A2D00", Offset = "0x68A1900", VA = "0x1868A2D00")]
	[NotNull]
	public static byte[] GFFLJMFFJAA(this EIFKGMCOLPJ IFDGOFLAMFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x68A2D70", Offset = "0x68A1970", VA = "0x1868A2D70")]
	[NotNull]
	public static byte[] GFFLJMFFJAA(this EIFKGMCOLPJ IFDGOFLAMFM, HashAlgorithmName IBBLLPOIMOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x68A28B0", Offset = "0x68A14B0", VA = "0x1868A28B0")]
	public static bool BJBJBDODKFA([CanBeNull] this EIFKGMCOLPJ IFDGOFLAMFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x68A2A40", Offset = "0x68A1640", VA = "0x1868A2A40")]
	public static bool BJBJBDODKFA([CanBeNull] this EIFKGMCOLPJ IFDGOFLAMFM, [Out] string MCOFJPDPPAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x68A2BE0", Offset = "0x68A17E0", VA = "0x1868A2BE0")]
	private static bool FDDHBFMOCKN([NotNull] EIFKGMCOLPJ IFDGOFLAMFM, [Out][CanBeNull] byte[] HDPMKNGJJKB, [Out][CanBeNull] byte[] NCMPIDOIIKL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class DMHDGMBEJND
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x68A32B0", Offset = "0x68A1EB0", VA = "0x1868A32B0")]
	[NotNull]
	public static byte[] GFFLJMFFJAA(this BCKDFJDFIHG EHNJPHDJHEH, HashAlgorithmName IBBLLPOIMOG, byte[] DEBFKMMMKPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface BCKDFJDFIHG
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash LNMBFIMPMFA);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface EIFKGMCOLPJ : BCKDFJDFIHG
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	[CanBeNull]
	byte[] HIGEAINBAAK
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	[CanBeNull]
	byte[] LHPLBOIMLCH
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class FNDAMHCOPKJ
{
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly ArrayPool<byte> OKMKHGEOJJD;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static bool ELAGNNKDHGN;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2AF68A0", Offset = "0x2AF54A0", VA = "0x182AF68A0")]
	public static void JEDGNHNHKNA<T>(this IncrementalHash PHDBGKOFOFL, [CanBeNull] T KDODEFMCLKH) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2AF62F0", Offset = "0x2AF4EF0", VA = "0x182AF62F0")]
	public static void FLIJOFOBIDC<T>(this IncrementalHash PHDBGKOFOFL, [CanBeNull] T EHNJPHDJHEH) where T : BCKDFJDFIHG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2AF6380", Offset = "0x2AF4F80", VA = "0x182AF6380")]
	public static void HKFMDODICFN<T>(this IncrementalHash PHDBGKOFOFL, [CanBeNull] IList<T> NJCLMDGBGLH) where T : BCKDFJDFIHG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x68A4800", Offset = "0x68A3400", VA = "0x1868A4800")]
	private static bool DKJDPEIHFBN([CanBeNull] BCKDFJDFIHG EHNJPHDJHEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x68A4740", Offset = "0x68A3340", VA = "0x1868A4740")]
	public static void BBKFCMKPILG(this IncrementalHash LNMBFIMPMFA, [CanBeNull] string PLDAIAGCNJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x68A50A0", Offset = "0x68A3CA0", VA = "0x1868A50A0")]
	public static void NNFCAGFNGNI(this IncrementalHash LNMBFIMPMFA, long MNNBHNGIHCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x68A48F0", Offset = "0x68A34F0", VA = "0x1868A48F0")]
	public static void EPJGHFAJBIP(this IncrementalHash LNMBFIMPMFA, int GBKNGINNOCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x68A4C30", Offset = "0x68A3830", VA = "0x1868A4C30")]
	public static void LKLBHAOJEID(this IncrementalHash LNMBFIMPMFA, short HEDMDOKKKEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x68A4B20", Offset = "0x68A3720", VA = "0x1868A4B20")]
	public static void IFAGGMIEOEA(this IncrementalHash LNMBFIMPMFA, byte BKDACBJJPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x68A4F30", Offset = "0x68A3B30", VA = "0x1868A4F30")]
	public static void NHIHFOGCPEI(this IncrementalHash LNMBFIMPMFA, bool OEHGEOINEFC, bool FKBLHLGPAPH = false, bool FPFBHLJHOFB = false, bool KEBHDOHHKMG = false, bool FAPMKAFLADH = false, bool EPMNDJCBIHA = false, bool MFFPOPHMCKH = false, bool KCEPMDKJDDI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x2AF6960", Offset = "0x2AF5560", VA = "0x182AF6960")]
	public static void KIMANCOAENN<T>(this IncrementalHash LNMBFIMPMFA, T APNFGFBFBNA) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x68A46E0", Offset = "0x68A32E0", VA = "0x1868A46E0")]
	public static void AAOONOOLNLF(this IncrementalHash LNMBFIMPMFA, float HGHCMBEOOFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x68A4AC0", Offset = "0x68A36C0", VA = "0x1868A4AC0")]
	public static void HPLCPGDMLHP(this IncrementalHash LNMBFIMPMFA, ulong IAKFAHKJEKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x68A4890", Offset = "0x68A3490", VA = "0x1868A4890")]
	public static void EDPLOGGCIBH(this IncrementalHash LNMBFIMPMFA, uint DLDBNFMHEBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x68A47A0", Offset = "0x68A33A0", VA = "0x1868A47A0")]
	public static void COICMDPODID(this IncrementalHash LNMBFIMPMFA, ushort KBKMOKHKCLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x68A4E00", Offset = "0x68A3A00", VA = "0x1868A4E00")]
	public static void MGDECKHIFKE(this IncrementalHash LNMBFIMPMFA, Vector3 CIILPODEDLF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class HFAOJMJOIDC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x68A54D0", Offset = "0x68A40D0", VA = "0x1868A54D0")]
	public HFAOJMJOIDC(string JIMAFLGJGFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public abstract class IIMJJKGKMPP<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	internal class ABLFDNALHLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public TNode HNFMOHFACKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public TNode GPMGJNAOOEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public EAEGHFDFMJB ONIAHHAAJEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public List<EAEGHFDFMJB> GEALMLOAGOI;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public ABLFDNALHLI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal struct EAEGHFDFMJB : IComparable<EAEGHFDFMJB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int BBABGOPLEMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public TClaimant ANDNCMANJHA;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xD86720", Offset = "0xD85320", VA = "0x180D86720")]
		public EAEGHFDFMJB(int BBABGOPLEMJ, TClaimant ANDNCMANJHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x37A7970", Offset = "0x37A6570", VA = "0x1837A7970")]
		public bool BNGKBKELHKP([In] EAEGHFDFMJB OCNJFCPHJLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x37A7960", Offset = "0x37A6560", VA = "0x1837A7960")]
		public bool ALNBILIFJEK([In] EAEGHFDFMJB OCNJFCPHJLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x37A79D0", Offset = "0x37A65D0", VA = "0x1837A79D0", Slot = "4")]
		public int CompareTo(EAEGHFDFMJB OCNJFCPHJLD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x37A79E0", Offset = "0x37A65E0", VA = "0x1837A79E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public enum DKCOFHHCPCH
	{
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class AHOMONGLBLG : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public IIMJJKGKMPP<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x8A2840", Offset = "0x8A1440", VA = "0x1808A2840")]
		[DebuggerHidden]
		public AHOMONGLBLG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3CE06F0", Offset = "0x3CDF2F0", VA = "0x183CE06F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3CE08D0", Offset = "0x3CDF4D0", VA = "0x183CE08D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3CE07D0", Offset = "0x3CDF3D0", VA = "0x183CE07D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3A52720", Offset = "0x3A51320", VA = "0x183A52720", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly GOJAECNACIA<ABLFDNALHLI> NBIGPPPFEMP;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly GOJAECNACIA<List<EAEGHFDFMJB>> AJPCMEJHHKF;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static int ONJKDAFPOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	internal readonly Dictionary<TClaimant, TNode> APODOODCMHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	internal readonly Dictionary<TNode, ABLFDNALHLI> DFHNNNCJAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private DKCOFHHCPCH CMLBPDKMHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private bool NGFFCCFEDBO;

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode JBKFGMBCAFH(TNode LNFMEAPGAAK);

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void MBLLCONLAGM(TNode LNFMEAPGAAK, TClaimant NJKIDKMJFMJ, TClaimant PBEDFGMAAMK);

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x3E34410", Offset = "0x3E33010", VA = "0x183E34410")]
	public IIMJJKGKMPP(DKCOFHHCPCH CMLBPDKMHGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x3E32E10", Offset = "0x3E31A10", VA = "0x183E32E10")]
	public void HCLPBFLOEJG(TNode LNFMEAPGAAK, TNode IAAJMIGCLIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x3E335E0", Offset = "0x3E321E0", VA = "0x183E335E0")]
	public void JBKGMCNLPNB(TClaimant ANDNCMANJHA, TNode OFDLLHGHJMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x3E32C00", Offset = "0x3E31800", VA = "0x183E32C00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x3E32930", Offset = "0x3E31530", VA = "0x183E32930")]
	private void AHLFJMAJNAC(TClaimant ANDNCMANJHA, TNode LBJJFANJJCG, TNode OFDLLHGHJMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x3E33BD0", Offset = "0x3E327D0", VA = "0x183E33BD0")]
	private int LFHNNBDFBGO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x3E32ED0", Offset = "0x3E31AD0", VA = "0x183E32ED0")]
	private void ICMNAEFCDML(TClaimant ANDNCMANJHA, TNode MLKIJIJCLOM, TNode EDBAEOCEHON, int JNIPGIGKOJM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x3E33220", Offset = "0x3E31E20", VA = "0x183E33220")]
	private void IGNNKFBPJOA(EAEGHFDFMJB APFOIBADHCG, ABLFDNALHLI BGLILLMPOMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x3E332F0", Offset = "0x3E31EF0", VA = "0x183E332F0")]
	private void IIGKIDNGGLJ(TClaimant ANDNCMANJHA, TNode MLKIJIJCLOM, TNode EDBAEOCEHON, int JNIPGIGKOJM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x3E33F90", Offset = "0x3E32B90", VA = "0x183E33F90")]
	private void MBKMPLNODPO(EAEGHFDFMJB APFOIBADHCG, TNode LNFMEAPGAAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x3E338B0", Offset = "0x3E324B0", VA = "0x183E338B0")]
	private void KELFKEJCIKJ(EAEGHFDFMJB APFOIBADHCG, ABLFDNALHLI BGLILLMPOMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x3E33760", Offset = "0x3E32360", VA = "0x183E33760")]
	private void JFGGNNIHMMJ(ABLFDNALHLI BGLILLMPOMB, bool AIDHOPBOOBL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3E33C40", Offset = "0x3E32840", VA = "0x183E33C40")]
	private void LHJPCBAHDLK(ABLFDNALHLI BGLILLMPOMB, TNode IAAJMIGCLIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3E32B10", Offset = "0x3E31710", VA = "0x183E32B10")]
	[IteratorStateMachine(typeof(IIMJJKGKMPP<, >.AHOMONGLBLG))]
	private IEnumerable<TNode> DPPBKIMAFPE(TNode MLKIJIJCLOM, TNode EDBAEOCEHON, bool JCCGGPIFNHI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x3E32A00", Offset = "0x3E31600", VA = "0x183E32A00")]
	private ABLFDNALHLI DOCGCCJKAJN(TNode LNFMEAPGAAK, TNode GPMGJNAOOEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x3E340C0", Offset = "0x3E32CC0", VA = "0x183E340C0")]
	private ABLFDNALHLI PLNCJEOMFMM(TNode LNFMEAPGAAK, TNode GPMGJNAOOEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x3E33A10", Offset = "0x3E32610", VA = "0x183E33A10")]
	private void KMOJCEMJAPI(ABLFDNALHLI BGLILLMPOMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class FBELLGDGAMI<T> : IEnumerable<FBELLGDGAMI<T>.DMAMOPIGPIG>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct DMAMOPIGPIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public T GLMEMJNJKAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public int OPDMGNJCACB;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class DFNCEMPHLAG : IEnumerator<DMAMOPIGPIG>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private FBELLGDGAMI<T> KIGGFALNMEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private int OPDMGNJCACB;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x382C010", Offset = "0x382AC10", VA = "0x18382C010", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public DMAMOPIGPIG KDHPDJIABMO
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x57CDA20", Offset = "0x57CC620", VA = "0x1857CDA20", Slot = "4")]
			get
			{
				return default(DMAMOPIGPIG);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x57CD930", Offset = "0x57CC530", VA = "0x1857CD930")]
		public DFNCEMPHLAG(FBELLGDGAMI<T> KIGGFALNMEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x57CD8B0", Offset = "0x57CC4B0", VA = "0x1857CD8B0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x3882510", Offset = "0x3881110", VA = "0x183882510", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x920600", Offset = "0x91F200", VA = "0x180920600", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	private struct DHEBKGHLJDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public bool LMHCEMHIADI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public T GLMEMJNJKAN;
	}

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private const int DDGLFKECABJ = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly Dictionary<T, int> LNDNNDICHKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private DHEBKGHLJDO[] ICJLLLFJFEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private int BFBIMPMHJIH;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public int IDNOANJLKFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8832B0", Offset = "0x881EB0", VA = "0x1808832B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x882E60", Offset = "0x881A60", VA = "0x180882E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int FPIENNPNDKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3551D00", Offset = "0x3550900", VA = "0x183551D00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x3B7C8C0", Offset = "0x3B7B4C0", VA = "0x183B7C8C0")]
	public FBELLGDGAMI(int ECCOECALPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x3B7CDD0", Offset = "0x3B7B9D0", VA = "0x183B7CDD0")]
	public FBELLGDGAMI(DMAMOPIGPIG[] PIEFNNGEJCK, bool FJBBOGLAABP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x3B7BB00", Offset = "0x3B7A700", VA = "0x183B7BB00")]
	public int BNAINFDJEEI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x3B7C2C0", Offset = "0x3B7AEC0", VA = "0x183B7C2C0")]
	private int JPBBDBNDAKD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x3B7BBF0", Offset = "0x3B7A7F0", VA = "0x183B7BBF0", Slot = "6")]
	protected virtual uint BNLFDNIKHFO(uint LNMBFIMPMFA, T GLMEMJNJKAN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x3B7C720", Offset = "0x3B7B320", VA = "0x183B7C720")]
	public bool KDIGHAFIHNG(T GLMEMJNJKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x3B7C240", Offset = "0x3B7AE40", VA = "0x183B7C240")]
	public int IFGFAFPIDAP(T GLMEMJNJKAN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x3B7BA90", Offset = "0x3B7A690", VA = "0x183B7BA90")]
	public T BIKHNENFGLC(int OPDMGNJCACB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x3B7BEC0", Offset = "0x3B7AAC0", VA = "0x183B7BEC0")]
	public bool GOFOFMOGKHH(T GLMEMJNJKAN, bool MENBPCCAAJP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x3B7BC60", Offset = "0x3B7A860", VA = "0x183B7BC60")]
	public bool GOFOFMOGKHH(T GLMEMJNJKAN, int OPDMGNJCACB, bool MENBPCCAAJP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x3B7C7D0", Offset = "0x3B7B3D0", VA = "0x183B7C7D0")]
	private int PMHPFLBFLOL(int PAGNMFPMINA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x3B7C820", Offset = "0x3B7B420", VA = "0x183B7C820", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x3B7C820", Offset = "0x3B7B420", VA = "0x183B7C820", Slot = "4")]
	private IEnumerator<DMAMOPIGPIG> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class GOJAECNACIA<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly Stack<T> IAAILOLPPHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly List<T> NADMJMCNJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly int GHEBMBCOFCM;

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x3CE6410", Offset = "0x3CE5010", VA = "0x183CE6410")]
	public static GOJAECNACIA<T> CGGLFDJCIIK(int ECCOECALPKO = 0, int GHEBMBCOFCM = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x3CE6BE0", Offset = "0x3CE57E0", VA = "0x183CE6BE0")]
	public static GOJAECNACIA<T> LEHHHFMGAFH(int ECCOECALPKO = 0, int GHEBMBCOFCM = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x3CE6D10", Offset = "0x3CE5910", VA = "0x183CE6D10")]
	public GOJAECNACIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x3CE6D60", Offset = "0x3CE5960", VA = "0x183CE6D60")]
	public GOJAECNACIA(int ECCOECALPKO, int GHEBMBCOFCM = int.MaxValue, bool EPLMFBAMIKJ = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x3CE6750", Offset = "0x3CE5350", VA = "0x183CE6750")]
	public T GMGHCKPCEIM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x3CE6680", Offset = "0x3CE5280", VA = "0x183CE6680")]
	public void FDHMEOLOKLG(T GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x3CE68F0", Offset = "0x3CE54F0", VA = "0x183CE68F0")]
	private void HFBLICKEGIG(T GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x3CE6CD0", Offset = "0x3CE58D0", VA = "0x183CE6CD0")]
	private void OKAALAPONJH(T GLMEMJNJKAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x3CE6500", Offset = "0x3CE5100", VA = "0x183CE6500", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x3CE69F0", Offset = "0x3CE55F0", VA = "0x183CE69F0")]
	private void KJPMLEIHAMD(IEnumerable<T> DJGHJNNEKKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class DMFLHLEMLKG<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private Dictionary<int, T> JBCLENIHHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private T JNDBFDHFPBE;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public virtual T LIPDADFHDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x843330", Offset = "0x841F30", VA = "0x180843330", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x57F2DF0", Offset = "0x57F19F0", VA = "0x1857F2DF0")]
	public bool ALBFOOANFLI(T GLMEMJNJKAN, int BBABGOPLEMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x3E6D920", Offset = "0x3E6C520", VA = "0x183E6D920")]
	public bool FGLGFDGEHMO(int BBABGOPLEMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x57F2EF0", Offset = "0x57F1AF0", VA = "0x1857F2EF0")]
	public T FHGLJPGGKNP(int CBNLHAPLPKJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x57F3390", Offset = "0x57F1F90", VA = "0x1857F3390")]
	private bool IELGFFOMKBN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x57F2E90", Offset = "0x57F1A90", VA = "0x1857F2E90")]
	public bool CMBHFEACNLN(int BBABGOPLEMJ, [Out] T GLMEMJNJKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x3E6F120", Offset = "0x3E6DD20", VA = "0x183E6F120")]
	public DMFLHLEMLKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class DHKEGMBOJKA<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	protected struct ENPKDAAIPLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public T EPAONLOANJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int OINDKHLECKK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly List<ENPKDAAIPLH> NNPPNIHAGDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private T ONMHBMNCMFO;

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public int FPIENNPNDKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x3551D00", Offset = "0x3550900", VA = "0x183551D00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x57D8330", Offset = "0x57D6F30", VA = "0x1857D8330")]
	public bool CPCALDGNEHE(T GLMEMJNJKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x57D88C0", Offset = "0x57D74C0", VA = "0x1857D88C0")]
	public void MPFJKDGCCNN(T GLMEMJNJKAN, int BBABGOPLEMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x57D8550", Offset = "0x57D7150", VA = "0x1857D8550")]
	public bool IFPALOLJLCH(T GLMEMJNJKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x57D8A50", Offset = "0x57D7650", VA = "0x1857D8A50")]
	public void ONDHHAABKMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x57D8110", Offset = "0x57D6D10", VA = "0x1857D8110")]
	public T APAEFEEPFOP()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x57D7F10", Offset = "0x57D6B10", VA = "0x1857D7F10")]
	protected void AIBBDJPODIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x57D8AF0", Offset = "0x57D76F0", VA = "0x1857D8AF0")]
	public DHKEGMBOJKA()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[HHMHLCBPJEC(LBBGAALIOCK.Self, false, false, false)]
		[SerializeField]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x68A59A0", Offset = "0x68A45A0", VA = "0x1868A59A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x68A5C70", Offset = "0x68A4870", VA = "0x1868A5C70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x68A5B80", Offset = "0x68A4780", VA = "0x1868A5B80")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x68A58F0", Offset = "0x68A44F0", VA = "0x1868A58F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x68A5BC0", Offset = "0x68A47C0", VA = "0x1868A5BC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x68A5AD0", Offset = "0x68A46D0", VA = "0x1868A5AD0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x68A5860", Offset = "0x68A4460", VA = "0x1868A5860")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x49260E0", Offset = "0x4924CE0", VA = "0x1849260E0", Slot = "4")]
		public virtual T LENJCBOBOIC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class EENIBKLNNLD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private Dictionary<byte, ADJHICNBHFB> FLNHPENOPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly GOJAECNACIA<ADJHICNBHFB> NGGHEDMLMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly bool NPHOOAJAAJM;

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public ADJHICNBHFB GNBODPMDPOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x8434A0", Offset = "0x8420A0", VA = "0x1808434A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public Vector2 ABPKAALLFOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xD17360", Offset = "0xD15F60", VA = "0x180D17360")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0xFFACA0", Offset = "0xFF98A0", VA = "0x180FFACA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	private Vector2 AEKIFNBMLJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x105B610", Offset = "0x105A210", VA = "0x18105B610")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Vector2 PKMHNEIJBPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x68A38C0", Offset = "0x68A24C0", VA = "0x1868A38C0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8433D0", Offset = "0x841FD0", VA = "0x1808433D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public int EMLIENMOLAM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x84B560", Offset = "0x84A160", VA = "0x18084B560")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x84B8D0", Offset = "0x84A4D0", VA = "0x18084B8D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x68A44B0", Offset = "0x68A30B0", VA = "0x1868A44B0")]
	public EENIBKLNNLD(Bounds PAMKMNPIOBC, Vector2[] ALMJCOOHGJN, int NPPFLOEBABL, byte PAGNMFPMINA, float IOGMAKIMBNE = 0f, [Optional] GOJAECNACIA<ADJHICNBHFB> NGGHEDMLMAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x68A39B0", Offset = "0x68A25B0", VA = "0x1868A39B0")]
	public void DBOHPEONNFN(Bounds PAMKMNPIOBC, Vector2[] ALMJCOOHGJN, int NPPFLOEBABL, byte PAGNMFPMINA, float IOGMAKIMBNE = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x68A4220", Offset = "0x68A2E20", VA = "0x1868A4220")]
	public ADJHICNBHFB KLLALAIPIFO(byte OPDMGNJCACB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x68A38E0", Offset = "0x68A24E0", VA = "0x1868A38E0")]
	public void DBKOLMMOHON(Vector3 DFPHDEDIHFK, float HHKAHEFFLCO, float NLNCOPOAFPF, List<byte> CLCBIPEEOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x68A38A0", Offset = "0x68A24A0", VA = "0x1868A38A0")]
	public void CICIDPMKCGA(ADJHICNBHFB.CPEGJDIDGIN GKMGDMCLADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x68A3E50", Offset = "0x68A2A50", VA = "0x1868A3E50")]
	public static int DGDACGMPNPN(Vector2[] ALMJCOOHGJN, int NPPFLOEBABL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x68A4280", Offset = "0x68A2E80", VA = "0x1868A4280")]
	private ADJHICNBHFB MEOLEOFNPBN(byte OPDMGNJCACB, ADJHICNBHFB.OFMJJMPHDDM NDFEHEMOCPK, ADJHICNBHFB GPMGJNAOOEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x68A34F0", Offset = "0x68A20F0", VA = "0x1868A34F0")]
	private void CECMHBDBLIM(ADJHICNBHFB GPMGJNAOOEP, Vector2[] ALMJCOOHGJN, int KPFEDGHIEBL, int MBBCEBOLALP, int EMABFLKHAJA, int ACFFJKKHCMG, float IOGMAKIMBNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x68A3FA0", Offset = "0x68A2BA0", VA = "0x1868A3FA0")]
	private void FNPGMOOAEAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x68A3F40", Offset = "0x68A2B40", VA = "0x1868A3F40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x68A41C0", Offset = "0x68A2DC0", VA = "0x1868A41C0", Slot = "1")]
	~EENIBKLNNLD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class ADJHICNBHFB
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public enum OFMJJMPHDDM
	{
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public enum CPEGJDIDGIN
	{
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public byte CCJJLJNMAIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public Vector3 JLBJEJBAMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public Vector3 LBOCLAHFPED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public Vector3 JPGOGEDHPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public Vector3 CEHOHDOEMLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public OFMJJMPHDDM ABKDHPHJKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public ADJHICNBHFB MHBJGCIDGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public List<ADJHICNBHFB> CKKMMNPEPNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public bool MGKDFGDJHPA;

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x68A2800", Offset = "0x68A1400", VA = "0x1868A2800")]
	public ADJHICNBHFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x68A26C0", Offset = "0x68A12C0", VA = "0x1868A26C0")]
	public void LEMHFMODGPL(ADJHICNBHFB EJMCPAEEGJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0")]
	public void CICIDPMKCGA(int GFLFJCLLOGO, CPEGJDIDGIN GKMGDMCLADB, int EMCEGDJKOFF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x68A23A0", Offset = "0x68A0FA0", VA = "0x1868A23A0")]
	public void DBKOLMMOHON(List<byte> CLCBIPEEOGF, Vector3 DFPHDEDIHFK, float HHKAHEFFLCO, float NLNCOPOAFPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x68A2690", Offset = "0x68A1290", VA = "0x1868A2690")]
	public bool KNKLLNGMLGO(Vector3 EJEEODBGEBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x68A2370", Offset = "0x68A0F70", VA = "0x1868A2370")]
	public bool BKFPJDKFJFG(Vector3 EJEEODBGEBC, float ILHODIHFNKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x68A2600", Offset = "0x68A1200", VA = "0x1868A2600")]
	public void EHHLDMLDHNI()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000068")]
		public struct JEHPEEJKIPO<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			private readonly List<Component> KNDOIJDCKAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			private readonly bool HODHKOPPPEG;

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x401EC50", Offset = "0x401D850", VA = "0x18401EC50")]
			public JEHPEEJKIPO(List<Component> KNDOIJDCKAF, bool HODHKOPPPEG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x401EB20", Offset = "0x401D720", VA = "0x18401EB20")]
			public MFLKADJCAJM<T> NDANHGBCNEI()
			{
				return default(MFLKADJCAJM<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x401EB80", Offset = "0x401D780", VA = "0x18401EB80", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x401EB80", Offset = "0x401D780", VA = "0x18401EB80", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		public struct MFLKADJCAJM<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			private readonly List<Component> KNDOIJDCKAF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			private readonly bool HODHKOPPPEG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			private int OPDMGNJCACB;

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			public T KDHPDJIABMO
			{
				[Cpp2IlInjected.Token(Token = "0x6000209")]
				[Cpp2IlInjected.Address(RVA = "0x43F2160", Offset = "0x43F0D60", VA = "0x1843F2160", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600020A")]
				[Cpp2IlInjected.Address(RVA = "0x43F20F0", Offset = "0x43F0CF0", VA = "0x1843F20F0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x43F2130", Offset = "0x43F0D30", VA = "0x1843F2130")]
			public MFLKADJCAJM(List<Component> KNDOIJDCKAF, bool HODHKOPPPEG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x43F2030", Offset = "0x43F0C30", VA = "0x1843F2030", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x43F2040", Offset = "0x43F0C40", VA = "0x1843F2040", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x38725F0", Offset = "0x38711F0", VA = "0x1838725F0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x68A76C0", Offset = "0x68A62C0", VA = "0x1868A76C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x68A6FF0", Offset = "0x68A5BF0", VA = "0x1868A6FF0")]
		private void EHHLDMLDHNI(GameObject GLPOGDKHFDA, bool NDHMLIPBMEM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x68A7160", Offset = "0x68A5D60", VA = "0x1868A7160")]
		public static void EHHLDMLDHNI(GameObject GLPOGDKHFDA, ToolHierarchyCache EMPAPNNPHEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x68A6FE0", Offset = "0x68A5BE0", VA = "0x1868A6FE0")]
		public void BMGHPIIJGLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x2E4B9D0", Offset = "0x2E4A5D0", VA = "0x182E4B9D0")]
		public void FNIAFBIHAKP<T>(Action<T> FIPNCHEIGMJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x2E4B930", Offset = "0x2E4A530", VA = "0x182E4B930")]
		public T EKDCGAKOIKG<T>(bool HODHKOPPPEG = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x2E4B870", Offset = "0x2E4A470", VA = "0x182E4B870")]
		public JEHPEEJKIPO<T> BGKBLMMNCEK<T>(bool HODHKOPPPEG = false) where T : class
		{
			return default(JEHPEEJKIPO<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x68A72E0", Offset = "0x68A5EE0", VA = "0x1868A72E0")]
		public List<Component> LGMNGDJADOI(Type NCNNODEFPOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x68A71F0", Offset = "0x68A5DF0", VA = "0x1868A71F0", Slot = "4")]
		public bool Equals(ToolHierarchyCache KNFDPFPHEON, ToolHierarchyCache EFBKAEHLBOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x68A7270", Offset = "0x68A5E70", VA = "0x1868A7270", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache HAHECKLGOJC)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class KGECGOHCCAB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private int ECCOECALPKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private int OKMLLMHDHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private List<T> KPAOLMPLIAP;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int FPIENNPNDKO
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3D45D20", Offset = "0x3D44920", VA = "0x183D45D20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public T FKLDIJDCIAH
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x414A6C0", Offset = "0x41492C0", VA = "0x18414A6C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public T ILIMELMDMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x414A3A0", Offset = "0x4148FA0", VA = "0x18414A3A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public T KPEHEFJJFBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x414A420", Offset = "0x4149020", VA = "0x18414A420")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x414AB10", Offset = "0x4149710", VA = "0x18414AB10")]
	public KGECGOHCCAB(int ECCOECALPKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x414A7F0", Offset = "0x41493F0", VA = "0x18414A7F0")]
	public void MPFJKDGCCNN(T JJEGGPLGMEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x414AAA0", Offset = "0x41496A0", VA = "0x18414AAA0")]
	public void ONDHHAABKMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x414A510", Offset = "0x4149110", VA = "0x18414A510")]
	public void CILFKDGKFIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x414A790", Offset = "0x4149390", VA = "0x18414A790")]
	public void LDGHNACDJDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x414AB00", Offset = "0x4149700", VA = "0x18414AB00")]
	public void PAGCKIALPPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class EJKNFFHHLLP<T>
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	private struct LMBKLOCJKNG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public int OINDKHLECKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public T EPAONLOANJK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly Dictionary<object, LMBKLOCJKNG> JBCLENIHHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly EqualityComparer<T> PMPADEFNOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private T JNDBFDHFPBE;

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public virtual T LIPDADFHDNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x8B92E0", Offset = "0x8B7EE0", VA = "0x1808B92E0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x3801DA0", Offset = "0x38009A0", VA = "0x183801DA0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool HOIODALFKJP
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x3801C80", Offset = "0x3800880", VA = "0x183801C80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public object DMCFPEEIKOE
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x847820", Offset = "0x846420", VA = "0x180847820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x38017E0", Offset = "0x38003E0", VA = "0x1838017E0")]
	public bool ALBFOOANFLI(T GLMEMJNJKAN, object FGIAGALCIAP, int BBABGOPLEMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x3801CE0", Offset = "0x38008E0", VA = "0x183801CE0")]
	public bool FGLGFDGEHMO(object FGIAGALCIAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x3801BE0", Offset = "0x38007E0", VA = "0x183801BE0")]
	public bool CMBHFEACNLN(object FGIAGALCIAP, [Out] T GLMEMJNJKAN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x3802960", Offset = "0x3801560", VA = "0x183802960")]
	public void ONDHHAABKMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x3802640", Offset = "0x3801240", VA = "0x183802640")]
	private bool IELGFFOMKBN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x38029B0", Offset = "0x38015B0", VA = "0x1838029B0")]
	public EJKNFFHHLLP()
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
