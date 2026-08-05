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
		[Cpp2IlInjected.Address(RVA = "0x9201C0", Offset = "0x91EFC0", VA = "0x1809201C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x724B270", Offset = "0x724A070", VA = "0x18724B270")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x920390", Offset = "0x91F190", VA = "0x180920390")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9203D0", Offset = "0x91F1D0", VA = "0x1809203D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NDLPFGAFJHI : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1DF5AB0", Offset = "0x1DF48B0", VA = "0x181DF5AB0")]
	public NDLPFGAFJHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, NNPNNEDPMJE, LBNHDCINGFG, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8F41E0", Offset = "0x8F2FE0", VA = "0x1808F41E0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8F7B20", Offset = "0x8F6920", VA = "0x1808F7B20", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8F7B10", Offset = "0x8F6910", VA = "0x1808F7B10", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xB5C510", Offset = "0xB5B310", VA = "0x180B5C510", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash EHFKLAFIBCC);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xA79E30", Offset = "0xA78C30", VA = "0x180A79E30")]
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
	[SerializeField]
	[HideInInspector]
	[ReadOnlyField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x724C6C0", Offset = "0x724B4C0", VA = "0x18724C6C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x724C680", Offset = "0x724B480", VA = "0x18724C680")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x724C700", Offset = "0x724B500", VA = "0x18724C700")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x724C8B0", Offset = "0x724B6B0", VA = "0x18724C8B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x724C820", Offset = "0x724B620", VA = "0x18724C820")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xD9F810", Offset = "0xD9E610", VA = "0x180D9F810")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xBF1C10", Offset = "0xBF0A10", VA = "0x180BF1C10")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x724C640", Offset = "0x724B440", VA = "0x18724C640")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x724C790", Offset = "0x724B590", VA = "0x18724C790")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x724C350", Offset = "0x724B150", VA = "0x18724C350")]
	public void CopyBounds(SavedExtents LHMPMCLNOPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x724C590", Offset = "0x724B390", VA = "0x18724C590")]
	public void SetLocalSpaceBounds(Bounds JLDNDJKLJNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x11EDBF0", Offset = "0x11EC9F0", VA = "0x1811EDBF0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x724C580", Offset = "0x724B380", VA = "0x18724C580")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x724BB30", Offset = "0x724A930", VA = "0x18724BB30")]
	private void CADBPMFNGBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x724C380", Offset = "0x724B180", VA = "0x18724C380")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x724BCE0", Offset = "0x724AAE0", VA = "0x18724BCE0")]
	public static void CalculateLocalBoundsFor(GameObject IHNPMPCJPIK, [Out] Bounds JLDNDJKLJNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x724BA70", Offset = "0x724A870", VA = "0x18724BA70")]
	private static void BDPKLLFCEBC(Bounds AGAPPIBJJBC, Color MKIHPGLMNDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x724C5B0", Offset = "0x724B3B0", VA = "0x18724C5B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8F41A0", Offset = "0x8F2FA0", VA = "0x1808F41A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8F8F80", Offset = "0x8F7D80", VA = "0x1808F8F80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x167B4B0", Offset = "0x167A2B0", VA = "0x18167B4B0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5129BB0", Offset = "0x51289B0", VA = "0x185129BB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "4")]
	public virtual void MHJELNGNNGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
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
	[NDLPFGAFJHI]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5129720", Offset = "0x5128520", VA = "0x185129720", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x51282F0", Offset = "0x51270F0", VA = "0x1851282F0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5129AD0", Offset = "0x51288D0", VA = "0x185129AD0")]
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
	private sealed class IOPOJEMKICD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public IOPOJEMKICD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x46F93F0", Offset = "0x46F81F0", VA = "0x1846F93F0")]
		internal int OGIBPJNEFMD(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[NDLPFGAFJHI]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x400DC20", Offset = "0x400CA20", VA = "0x18400DC20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x400DC80", Offset = "0x400CA80", VA = "0x18400DC80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x400DB00", Offset = "0x400C900", VA = "0x18400DB00", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey FFOHLCGHDKA]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x400DBC0", Offset = "0x400C9C0", VA = "0x18400DBC0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x400D9B0", Offset = "0x400C7B0", VA = "0x18400D9B0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x400D650", Offset = "0x400C450", VA = "0x18400D650", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x400CA10", Offset = "0x400B810", VA = "0x18400CA10", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x400C8E0", Offset = "0x400B6E0", VA = "0x18400C8E0", Slot = "14")]
	protected virtual string CGCLMIEBPIA(TKeyVal BCMHAMBOGLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x400C910", Offset = "0x400B710", VA = "0x18400C910", Slot = "4")]
	public bool ContainsKey(TKey FFOHLCGHDKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x400D830", Offset = "0x400C630", VA = "0x18400D830", Slot = "5")]
	public bool TryGetValue(TKey FFOHLCGHDKA, [Out] TVal IPHILEOFJLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x400C970", Offset = "0x400B770", VA = "0x18400C970", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x400C970", Offset = "0x400B770", VA = "0x18400C970", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x400D890", Offset = "0x400C690", VA = "0x18400D890")]
	protected EditableSerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class SerializedReferenceKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[SerializeField]
	[SerializeReference]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8F41C0", Offset = "0x8F2FC0", VA = "0x1808F41C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8F41E0", Offset = "0x8F2FE0", VA = "0x1808F41E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	protected SerializedReferenceKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class SerializedReferenceDictionary<TKey, TVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private class SerializedReferenceKeyValuePair : SerializedReferenceKeyVal<TKey, TVal>
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3F36020", Offset = "0x3F34E20", VA = "0x183F36020")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	[NDLPFGAFJHI]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x512B5A0", Offset = "0x512A3A0", VA = "0x18512B5A0")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x512ADE0", Offset = "0x5129BE0", VA = "0x18512ADE0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x512A390", Offset = "0x5129190", VA = "0x18512A390", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class DPCEHEPFEBO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private class IDNEGCPPLFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public float NAJEBBOFAOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T HKHKCHJEPKB;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public IDNEGCPPLFD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class EHEECBDOOBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public EHEECBDOOBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3FE0E20", Offset = "0x3FDFC20", VA = "0x183FE0E20")]
		internal bool OOEKKNJPPKI(IDNEGCPPLFD sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly float BBPKKPEFJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly float NAPMJPDDEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private List<IDNEGCPPLFD> JJGLPJOFOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private PJDOOEEFCKB<IDNEGCPPLFD> OBOFNOBNFIM;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int NNAHLDNNALF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x612D4B0", Offset = "0x612C2B0", VA = "0x18612D4B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x612DB80", Offset = "0x612C980", VA = "0x18612DB80")]
	public DPCEHEPFEBO(float LAGGMHCGGMI, float EEPIANMLIBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x612D900", Offset = "0x612C700", VA = "0x18612D900")]
	public bool MAJLKECCKGB(float LEAPIIAHEEF, T IPHILEOFJLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x612D140", Offset = "0x612BF40", VA = "0x18612D140")]
	public IEnumerable<T> AMMKIIIHGIC(float LEAPIIAHEEF, [Optional] float? DIFPPNJFDCL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x612DAD0", Offset = "0x612C8D0", VA = "0x18612DAD0")]
	public void NCEIDOKFHPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x612D590", Offset = "0x612C390", VA = "0x18612D590")]
	private void DCDDJFAJJFF(float LEAPIIAHEEF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class FGIFHNHEOAO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct DGJACPJKHBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public T HKHKCHJEPKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public float PFEBOINBCHG;
	}

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private static float OGCGDPBFDLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private List<T> COGDNMCACLC;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private const int AKLHNJLOFAG = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private DGJACPJKHBG[] EOOCBMPNEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private int BGDPPBBLJDC;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float LKNJDKLHCCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xACAC30", Offset = "0xAC9A30", VA = "0x180ACAC30")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xB30D70", Offset = "0xB2FB70", VA = "0x180B30D70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public T LMHGFELDAKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x8F41E0", Offset = "0x8F2FE0", VA = "0x1808F41E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x43975B0", Offset = "0x43963B0", VA = "0x1843975B0")]
	public FGIFHNHEOAO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4397480", Offset = "0x4396280", VA = "0x184397480")]
	public FGIFHNHEOAO(int IECADCKMGOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4396780", Offset = "0x4395580", VA = "0x184396780")]
	public void MDGAONDGEMG(float LEAPIIAHEEF, T IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4397230", Offset = "0x4396030", VA = "0x184397230")]
	public void NCEIDOKFHPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4396A00", Offset = "0x4395800", VA = "0x184396A00")]
	public bool MIEKIIOGGDC(float JHKFEMICOCN, float HOKBAAGNBLD, [Out] T IPHILEOFJLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4396530", Offset = "0x4395330", VA = "0x184396530")]
	public bool CGPBMGPPOOO(float JHKFEMICOCN, float HOKBAAGNBLD, [Out] T IPHILEOFJLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x43970B0", Offset = "0x4395EB0", VA = "0x1843970B0")]
	public void NCBFHPFELAK(float JHKFEMICOCN, float HOKBAAGNBLD, List<T> FBEHCHGAOLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4396750", Offset = "0x4395550", VA = "0x184396750")]
	private int FAOOFAKDIPO(int MBEEICPFGHJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4396700", Offset = "0x4395500", VA = "0x184396700")]
	private void DCBKNAAPIPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T OJCCIANNEJN();

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T LFPGJKNHFKG(T IPHILEOFJLB, float DHJLEBFEJME);

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T DGKNBEFGFGO(T NMOPBJNEFKL, T KCJDGOIFCIF);

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T JPDAFIIPPJC(T NMOPBJNEFKL, T KCJDGOIFCIF);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class MPNLLHGBPJL : FGIFHNHEOAO<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x9059E0", Offset = "0x9047E0", VA = "0x1809059E0", Slot = "4")]
	protected override Vector3 OJCCIANNEJN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x7249C40", Offset = "0x7248A40", VA = "0x187249C40", Slot = "5")]
	protected override Vector3 LFPGJKNHFKG(Vector3 IPHILEOFJLB, float DHJLEBFEJME)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x7249B70", Offset = "0x7248970", VA = "0x187249B70", Slot = "6")]
	protected override Vector3 DGKNBEFGFGO(Vector3 NMOPBJNEFKL, Vector3 KCJDGOIFCIF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x7249BC0", Offset = "0x72489C0", VA = "0x187249BC0", Slot = "7")]
	protected override Vector3 JPDAFIIPPJC(Vector3 NMOPBJNEFKL, Vector3 KCJDGOIFCIF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7249C80", Offset = "0x7248A80", VA = "0x187249C80")]
	public MPNLLHGBPJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class NBFMAIHPPNO
{
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3453FB0", Offset = "0x3452DB0", VA = "0x183453FB0")]
	public static OFKFKMAPIHD<T1, T2> DCMOGLEGFAE<T1, T2>(T1 HLNANAEJNIE, T2 HMBMDELKOBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3454050", Offset = "0x3452E50", VA = "0x183454050")]
	public static NPNJNOEKENI<T1, T2, T3> DCMOGLEGFAE<T1, T2, T3>(T1 HLNANAEJNIE, T2 HMBMDELKOBI, T3 FGJMDIAMPEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4D047E0", Offset = "0x4D035E0", VA = "0x184D047E0")]
	internal static int ODLDNPAAHOI(int EDDDNMKCCLD, int PAHMAJNJAOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x65606C0", Offset = "0x655F4C0", VA = "0x1865606C0")]
	internal static int ODLDNPAAHOI(int EDDDNMKCCLD, int PAHMAJNJAOF, int OFNCMLIEPEM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class OFKFKMAPIHD<T1, T2> : IComparable<OFKFKMAPIHD<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly T1 CPACODNGDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly T2 ACKCHLNPILC;

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4E38AC0", Offset = "0x4E378C0", VA = "0x184E38AC0")]
	public OFKFKMAPIHD(T1 HLNANAEJNIE, T2 HMBMDELKOBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4E37B70", Offset = "0x4E36970", VA = "0x184E37B70", Slot = "4")]
	public int CompareTo(OFKFKMAPIHD<T1, T2> LHMPMCLNOPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4E37E70", Offset = "0x4E36C70", VA = "0x184E37E70", Slot = "0")]
	public override bool Equals(object LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4E38400", Offset = "0x4E37200", VA = "0x184E38400", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4E38800", Offset = "0x4E37600", VA = "0x184E38800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class NPNJNOEKENI<T1, T2, T3> : IComparable<NPNJNOEKENI<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly T1 CPACODNGDHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly T2 ACKCHLNPILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public readonly T3 ODGOKECOAMM;

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4D49530", Offset = "0x4D48330", VA = "0x184D49530")]
	public NPNJNOEKENI(T1 HLNANAEJNIE, T2 HMBMDELKOBI, T3 FGJMDIAMPEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4D48D20", Offset = "0x4D47B20", VA = "0x184D48D20", Slot = "4")]
	public int CompareTo(NPNJNOEKENI<T1, T2, T3> LHMPMCLNOPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4D48E70", Offset = "0x4D47C70", VA = "0x184D48E70", Slot = "0")]
	public override bool Equals(object LHMPMCLNOPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x4D49140", Offset = "0x4D47F40", VA = "0x184D49140", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4D49380", Offset = "0x4D48180", VA = "0x184D49380", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public AnimationCurve PHNLFPEJIJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T PPEPDOAEBKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x10D98B0", Offset = "0x10D86B0", VA = "0x1810D98B0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T KDKEPAGBGCF
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0xACB760", Offset = "0xACA560", VA = "0x180ACB760")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public T HKHKCHJEPKB
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x28DDE00", Offset = "0x28DCC00", VA = "0x1828DDE00")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x28DE030", Offset = "0x28DCE30", VA = "0x1828DE030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public float FLFFMPPDPCL
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0xAC8300", Offset = "0xAC7100", VA = "0x180AC8300")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x537FF20", Offset = "0x537ED20", VA = "0x18537FF20")]
	public T PNIDELAKNFC(float DHJLEBFEJME)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x537FD00", Offset = "0x537EB00", VA = "0x18537FD00")]
	public T PIIIIDMHKJL(float DHJLEBFEJME)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T BLLAOFKBOAD(T NMOPBJNEFKL, T KCJDGOIFCIF, float DHJLEBFEJME);

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7247D70", Offset = "0x7246B70", VA = "0x187247D70", Slot = "4")]
	protected override float BLLAOFKBOAD(float NMOPBJNEFKL, float KCJDGOIFCIF, float DHJLEBFEJME)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7247DB0", Offset = "0x7246BB0", VA = "0x187247DB0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x14F3A60", Offset = "0x14F2860", VA = "0x1814F3A60", Slot = "4")]
	protected override Vector3 BLLAOFKBOAD(Vector3 NMOPBJNEFKL, Vector3 KCJDGOIFCIF, float DHJLEBFEJME)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x724D6C0", Offset = "0x724C4C0", VA = "0x18724D6C0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7247140", Offset = "0x7245F40", VA = "0x187247140", Slot = "4")]
	protected override Color BLLAOFKBOAD(Color NMOPBJNEFKL, Color KCJDGOIFCIF, float DHJLEBFEJME)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7247200", Offset = "0x7246000", VA = "0x187247200")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class DIMFJEOLLAE : PJFNLCNJIGJ<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x72472B0", Offset = "0x72460B0", VA = "0x1872472B0")]
	public DIMFJEOLLAE(int MLAKJOPIGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7247240", Offset = "0x7246040", VA = "0x187247240", Slot = "6")]
	protected override uint LHNLIEBFAPH(uint EHFKLAFIBCC, string IPHILEOFJLB)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class EHBHFPLJEOC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public static readonly IDisposable GGJCMHODIEM;

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	public EHBHFPLJEOC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct PHLKAIHPNKH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> OANGMDCKJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int OBPLIHKOFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private int LGIDEIMOCJC;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x4D069A0", Offset = "0x4D057A0", VA = "0x184D069A0")]
	private PHLKAIHPNKH(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> PJLLGOPMMGD, int EHJPABCBFHG, int JLPMMGLNOMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4F25600", Offset = "0x4F24400", VA = "0x184F25600")]
	public static PHLKAIHPNKH<T> MKHEJJEDOII()
	{
		return default(PHLKAIHPNKH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4F23980", Offset = "0x4F22780", VA = "0x184F23980")]
	public (int, int, Task<T>) MGEDEJGNKJA(int JOGIDIAAHEC, [Optional] CancellationToken FEHCANHDGHE, double CIOLBCCFHKE = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4F25700", Offset = "0x4F24500", VA = "0x184F25700")]
	public void MLGOMGNCEGH(int JOGIDIAAHEC, int JLPMMGLNOMC, [In] T LDEANEOLAOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class PHPKKCACEBD
{
	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x724B460", Offset = "0x724A260", VA = "0x18724B460")]
	public static PHLKAIHPNKH<ENLEGHEGALI> MKHEJJEDOII()
	{
		return default(PHLKAIHPNKH<ENLEGHEGALI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x724B4B0", Offset = "0x724A2B0", VA = "0x18724B4B0")]
	public static void MLGOMGNCEGH([In] this PHLKAIHPNKH<ENLEGHEGALI> DJAJDIFOIHP, int JOGIDIAAHEC, int JLPMMGLNOMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public class IAGPDCKIHOL<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<TKey, TVal> AANFJAFJBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly Dictionary<TVal, TKey> OBEPLLIOIFJ;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int IPKHGMJKDEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3C74770", Offset = "0x3C73570", VA = "0x183C74770", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool HPHENKFIHIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TKey> DCFFKNPGHKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x4584D10", Offset = "0x4583B10", VA = "0x184584D10", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public ICollection<TVal> EGMHGJAMKFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x46C59A0", Offset = "0x46C47A0", VA = "0x1846C59A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TVal FCGIOOCDKLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x46C58E0", Offset = "0x46C46E0", VA = "0x1846C58E0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x46C59F0", Offset = "0x46C47F0", VA = "0x1846C59F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public TKey FCGIOOCDKLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x46C5370", Offset = "0x46C4170", VA = "0x1846C5370")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x46C4E00", Offset = "0x46C3C00", VA = "0x1846C4E00", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x46C56C0", Offset = "0x46C44C0", VA = "0x1846C56C0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x46C4B10", Offset = "0x46C3910", VA = "0x1846C4B10", Slot = "9")]
	public void Add(TKey FFOHLCGHDKA, TVal IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x46C4B60", Offset = "0x46C3960", VA = "0x1846C4B60", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> MJONLBMPPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x46C4EA0", Offset = "0x46C3CA0", VA = "0x1846C4EA0", Slot = "8")]
	public bool ContainsKey(TKey FFOHLCGHDKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x46C4EF0", Offset = "0x46C3CF0", VA = "0x1846C4EF0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> MJONLBMPPCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x46C5600", Offset = "0x46C4400", VA = "0x1846C5600", Slot = "10")]
	public bool Remove(TKey FFOHLCGHDKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x46C5680", Offset = "0x46C4480", VA = "0x1846C5680", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> MJONLBMPPCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x46C5760", Offset = "0x46C4560", VA = "0x1846C5760", Slot = "11")]
	public bool TryGetValue(TKey FFOHLCGHDKA, [Out] TVal IPHILEOFJLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x46C4FF0", Offset = "0x46C3DF0", VA = "0x1846C4FF0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x46C4F70", Offset = "0x46C3D70", VA = "0x1846C4F70", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] EOOCBMPNEML, int FJBNAIEDHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x46C5250", Offset = "0x46C4050", VA = "0x1846C5250")]
	public bool MHAMFDPPPMK(TVal FFOHLCGHDKA, [Out] TKey IPHILEOFJLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x46C5160", Offset = "0x46C3F60", VA = "0x1846C5160")]
	private void JMAKHFCKPNJ(TKey FFOHLCGHDKA, TVal OAJCPHOOFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x46C4D10", Offset = "0x46C3B10", VA = "0x1846C4D10")]
	private void CDOOLFOFFNH(TKey FFOHLCGHDKA, TVal OAJCPHOOFGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x46C53D0", Offset = "0x46C41D0", VA = "0x1846C53D0")]
	private bool PJENCCPHFEL(TKey FFOHLCGHDKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x46C57C0", Offset = "0x46C45C0", VA = "0x1846C57C0")]
	public IAGPDCKIHOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class ICKBHKHHLLB<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private ICKBHKHHLLB<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x405DE60", Offset = "0x405CC60", VA = "0x18405DE60", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x4060CD0", Offset = "0x405FAD0", VA = "0x184060CD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4062810", Offset = "0x4061610", VA = "0x184062810")]
		public Enumerator(ICKBHKHHLLB<T> FBEHCHGAOLI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x405F3B0", Offset = "0x405E1B0", VA = "0x18405F3B0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x4060740", Offset = "0x405F540", VA = "0x184060740", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x405DFA0", Offset = "0x405CDA0", VA = "0x18405DFA0")]
		private void LJJKALPNPGL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private T[] OFEPONFGFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private int GJCOHOCILFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private int BGNNHGHIKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int BBDOELHAPOH;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int IPKHGMJKDEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x46CFB20", Offset = "0x46CE920", VA = "0x1846CFB20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public T FCGIOOCDKLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x46D0CB0", Offset = "0x46CFAB0", VA = "0x1846D0CB0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x46CF8B0", Offset = "0x46CE6B0", VA = "0x1846CF8B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x46D1140", Offset = "0x46CFF40", VA = "0x1846D1140")]
	public ICKBHKHHLLB(int MLAKJOPIGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x46D0610", Offset = "0x46CF410", VA = "0x1846D0610")]
	public void MDGAONDGEMG(T DHJLEBFEJME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x46D0B30", Offset = "0x46CF930", VA = "0x1846D0B30")]
	public void NCEIDOKFHPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x46CEFB0", Offset = "0x46CDDB0", VA = "0x1846CEFB0")]
	public void DEALEJKBALP(int BMGBDLLODJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x46CFB90", Offset = "0x46CE990", VA = "0x1846CFB90")]
	public void MCPPHIAOABD(T[] EOOCBMPNEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x46D0AF0", Offset = "0x46CF8F0", VA = "0x1846D0AF0")]
	public Enumerator NAPBKLICNNH()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x46D1080", Offset = "0x46CFE80", VA = "0x1846D1080", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x46D1080", Offset = "0x46CFE80", VA = "0x1846D1080", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x46CF410", Offset = "0x46CE210", VA = "0x1846CF410")]
	private int EHIBHPINPEK(int KNCPCNBMDNF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x46CFB60", Offset = "0x46CE960", VA = "0x1846CFB60")]
	private int ILGBBBLMOBE(int KNCPCNBMDNF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class FMGEGMGJJKP<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate Task<TResult> ELHCFMJNAKP(TRequest HJFGAIAKKLJ, CancellationToken FEHCANHDGHE);

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public enum DGPNPKMOIFP
	{
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class NHFIDFEFDHE
	{
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private const float PIBBLJJAANG = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TimeSpan DFOHNGKFAHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int JAPFAPLFDFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public DGPNPKMOIFP GGBENILNNJI;

		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public static readonly NHFIDFEFDHE KPNHHCMCHOD;

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public float JOEJKHHOAMD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x4D29C80", Offset = "0x4D28A80", VA = "0x184D29C80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public TimeSpan AEIOKINKJJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x4D29DD0", Offset = "0x4D28BD0", VA = "0x184D29DD0")]
		public NHFIDFEFDHE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private readonly struct MCFJMMEKKLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly TRequest HJFGAIAKKLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly CancellationToken FEHCANHDGHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public readonly TaskCompletionSource<TResult> LHILFOPNIIF;

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x4C875E0", Offset = "0x4C863E0", VA = "0x184C875E0")]
		public MCFJMMEKKLF(TRequest HJFGAIAKKLJ, TaskCompletionSource<TResult> LHILFOPNIIF, CancellationToken FEHCANHDGHE)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct GOBHCAPHGHI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public FMGEGMGJJKP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x45106F0", Offset = "0x450F4F0", VA = "0x1845106F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x4510B50", Offset = "0x450F950", VA = "0x184510B50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct PNBGBEPEMKO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public FMGEGMGJJKP<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private MCFJMMEKKLF <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x4F390D0", Offset = "0x4F37ED0", VA = "0x184F390D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x4F3A3C0", Offset = "0x4F391C0", VA = "0x184F3A3C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly CancellationTokenSource AADNIIBANIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly List<MCFJMMEKKLF> BAEDDBGDLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly NHFIDFEFDHE GFBPFOONIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ELHCFMJNAKP LLLMEHOJEFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private Task MBHEMNBLNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int PPEIFCKNLIN;

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x43D0220", Offset = "0x43CF020", VA = "0x1843D0220")]
	public FMGEGMGJJKP(ELHCFMJNAKP LLLMEHOJEFL, [Optional] NHFIDFEFDHE GFBPFOONIGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x43CF8D0", Offset = "0x43CE6D0", VA = "0x1843CF8D0")]
	public Task<TResult> JALKFNMDAOC(TRequest HJFGAIAKKLJ, CancellationToken FEHCANHDGHE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x43CFFA0", Offset = "0x43CEDA0", VA = "0x1843CFFA0")]
	private void OEOMKOPHHDM(MCFJMMEKKLF JJBOGONNGMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x43CF360", Offset = "0x43CE160", VA = "0x1843CF360")]
	[AsyncStateMachine(typeof(FMGEGMGJJKP<, >.GOBHCAPHGHI))]
	private Task EJIFPGGNDKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x43CE7A0", Offset = "0x43CD5A0", VA = "0x1843CE7A0")]
	private MCFJMMEKKLF AEKDNGHLOOA()
	{
		return default(MCFJMMEKKLF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x43CF230", Offset = "0x43CE030", VA = "0x1843CF230")]
	[AsyncStateMachine(typeof(FMGEGMGJJKP<, >.PNBGBEPEMKO))]
	private Task BEBCGJBGIPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x43CF7D0", Offset = "0x43CE5D0", VA = "0x1843CF7D0")]
	private void IMKHJPMDOKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x43CF320", Offset = "0x43CE120", VA = "0x1843CF320", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class PCAHHLLEMAA<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly List<T> BJCKKCNKPEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private HashSet<T> GMJFOIHCEFP;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int IPKHGMJKDEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x3C74770", Offset = "0x3C73570", VA = "0x183C74770", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool HPHENKFIHIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x93EA60", Offset = "0x93D860", VA = "0x18093EA60", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public T FCGIOOCDKLL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x32FC000", Offset = "0x32FAE00", VA = "0x1832FC000", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x4F04990", Offset = "0x4F03790", VA = "0x184F04990", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x441DEB0", Offset = "0x441CCB0", VA = "0x18441DEB0", Slot = "11")]
	public void Add(T MJONLBMPPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4F03F80", Offset = "0x4F02D80", VA = "0x184F03F80")]
	public bool GPJOLIGKBOI(T MJONLBMPPCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4F045B0", Offset = "0x4F033B0", VA = "0x184F045B0", Slot = "15")]
	public bool Remove(T MJONLBMPPCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4D2D080", Offset = "0x4D2BE80", VA = "0x184D2D080", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x444F550", Offset = "0x444E350", VA = "0x18444F550", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4F03D30", Offset = "0x4F02B30", VA = "0x184F03D30", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4F03DD0", Offset = "0x4F02BD0", VA = "0x184F03DD0", Slot = "13")]
	public bool Contains(T MJONLBMPPCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x4F03E20", Offset = "0x4F02C20", VA = "0x184F03E20", Slot = "14")]
	public void CopyTo(T[] EOOCBMPNEML, int FJBNAIEDHDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x4A14120", Offset = "0x4A12F20", VA = "0x184A14120", Slot = "6")]
	public int IndexOf(T MJONLBMPPCK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x4F041D0", Offset = "0x4F02FD0", VA = "0x184F041D0", Slot = "7")]
	public void Insert(int KNCPCNBMDNF, T MJONLBMPPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x4F04310", Offset = "0x4F03110", VA = "0x184F04310", Slot = "8")]
	public void RemoveAt(int KNCPCNBMDNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x4F04730", Offset = "0x4F03530", VA = "0x184F04730")]
	public PCAHHLLEMAA()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x2746160", Offset = "0x2744F60", VA = "0x182746160")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x724CC50", Offset = "0x724BA50", VA = "0x18724CC50")]
		public SerializedGuid([In] Guid OGOMDMBFOMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x724CAB0", Offset = "0x724B8B0", VA = "0x18724CAB0")]
		public static SerializedGuid LJODFKBDHCG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x724CB30", Offset = "0x724B930", VA = "0x18724CB30")]
		public static SerializedGuid MAONEEOMMII()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x724CA50", Offset = "0x724B850", VA = "0x18724CA50")]
		public bool HDHDIACPLJG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x724CC20", Offset = "0x724BA20", VA = "0x18724CC20", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x724CBA0", Offset = "0x724B9A0", VA = "0x18724CBA0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x724C970", Offset = "0x724B770", VA = "0x18724C970", Slot = "7")]
		public bool Equals(SerializedGuid LHMPMCLNOPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x724C9B0", Offset = "0x724B7B0", VA = "0x18724C9B0", Slot = "0")]
		public override bool Equals(object JOOHPPHJKMI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x724CA40", Offset = "0x724B840", VA = "0x18724CA40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x724C940", Offset = "0x724B740", VA = "0x18724C940", Slot = "6")]
		public int CompareTo(SerializedGuid LHMPMCLNOPG)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class MHNBGBPONOA : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly Type FDJOFOLBPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly string GBIPHDNBHOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly bool CGGCAEJGBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public readonly bool AGEHANDFCLP;

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x7249B00", Offset = "0x7248900", VA = "0x187249B00")]
	public MHNBGBPONOA(Type CKOPEDDDMNB, string GIDNDEMALOC, bool LLHJECOLOED = false, bool KIFINOAGICN = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class IGPFJOOPHMK<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public readonly struct JGONMLFMCPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly long PLOKNGGEFJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly long JJEMKGNGLEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly int NJGBHLAOCBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public readonly int CKPOBBOFGDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public readonly bool FMAIFBFCALM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly string EKEDDCCAJLF;

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x48BF710", Offset = "0x48BE510", VA = "0x1848BF710")]
		public JGONMLFMCPJ(long PLOKNGGEFJP, int NJGBHLAOCBG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x48BF780", Offset = "0x48BE580", VA = "0x1848BF780")]
		public JGONMLFMCPJ(long PLOKNGGEFJP, long JJEMKGNGLEE, int NJGBHLAOCBG, int CKPOBBOFGDJ, bool FMAIFBFCALM, string EKEDDCCAJLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x48BF5C0", Offset = "0x48BE3C0", VA = "0x1848BF5C0")]
		public int GEPOGCLOLNO()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x48BF5A0", Offset = "0x48BE3A0", VA = "0x1848BF5A0")]
		public int CMJMPAAHGPN(int BPAPGOPEHHN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x48BF6B0", Offset = "0x48BE4B0", VA = "0x1848BF6B0")]
		public double JFHCKNELFHP()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x48BF610", Offset = "0x48BE410", VA = "0x1848BF610")]
		public JGONMLFMCPJ JBFDBABOAGB(long JJEMKGNGLEE, int CKPOBBOFGDJ)
		{
			return default(JGONMLFMCPJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class PDLCJKJEJBF : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private struct HLKPNGPKHCH<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public PDLCJKJEJBF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			public Func<PDLCJKJEJBF, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private PDLCJKJEJBF <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x45881F0", Offset = "0x4586FF0", VA = "0x1845881F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x4524F80", Offset = "0x4523D80", VA = "0x184524F80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public readonly TKey HDKBAJIDJIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private readonly IGPFJOOPHMK<TKey> HPEGCCHCIAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public readonly IMOCAMGHNDM JBCGOBEIKAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		private List<PDLCJKJEJBF> DPIKNOBKOJI;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public string EGBOEHMEDOE
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x4F0CA40", Offset = "0x4F0B840", VA = "0x184F0CA40")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public IEnumerable<PDLCJKJEJBF> FDEJDHNLPJN
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x4F0C5E0", Offset = "0x4F0B3E0", VA = "0x184F0C5E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public JGONMLFMCPJ CODNCFLKDCM
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x4F0CA20", Offset = "0x4F0B820", VA = "0x184F0CA20")]
			[CompilerGenerated]
			get
			{
				return default(JGONMLFMCPJ);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x4F0C5B0", Offset = "0x4F0B3B0", VA = "0x184F0C5B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x4F0CA90", Offset = "0x4F0B890", VA = "0x184F0CA90")]
		internal PDLCJKJEJBF(IGPFJOOPHMK<TKey> HPEGCCHCIAG, TKey FFOHLCGHDKA, IMOCAMGHNDM JBCGOBEIKAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x4F0C870", Offset = "0x4F0B670", VA = "0x184F0C870")]
		public PDLCJKJEJBF FLECPIJHMFH(TKey FFOHLCGHDKA, [Optional] IMOCAMGHNDM? KJIMHOBKLIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3877A60", Offset = "0x3876860", VA = "0x183877A60")]
		[AsyncStateMachine(typeof(HLKPNGPKHCH<>))]
		public Task<T> NFFBFLLBDFI<T>(TKey FFOHLCGHDKA, Func<PDLCJKJEJBF, Task<T>> LLGCEMPPLIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4F0C620", Offset = "0x4F0B420", VA = "0x184F0C620", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class KEJAAAGOCDD : IEnumerable<(TKey, List<TKey>, JGONMLFMCPJ)>, IEnumerable, IEnumerator<(TKey, List<TKey>, JGONMLFMCPJ)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private (TKey key, List<TKey> path, JGONMLFMCPJ timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public IGPFJOOPHMK<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private IEnumerator<(TKey key, List<TKey> path, JGONMLFMCPJ timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		private (TKey, List<TKey>, JGONMLFMCPJ) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x2760DE0", Offset = "0x275FBE0", VA = "0x182760DE0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, JGONMLFMCPJ));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x49A79B0", Offset = "0x49A67B0", VA = "0x1849A79B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x2760ED0", Offset = "0x275FCD0", VA = "0x182760ED0")]
		[DebuggerHidden]
		public KEJAAAGOCDD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x43522B0", Offset = "0x43510B0", VA = "0x1843522B0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x49A74F0", Offset = "0x49A62F0", VA = "0x1849A74F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x49A74A0", Offset = "0x49A62A0", VA = "0x1849A74A0")]
		private void GEDOPIMJGAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x49A7960", Offset = "0x49A6760", VA = "0x1849A7960", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x49A7890", Offset = "0x49A6690", VA = "0x1849A7890", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, JGONMLFMCPJ)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4439A80", Offset = "0x4438880", VA = "0x184439A80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class CFLMLLHKGDB : IEnumerable<(TKey, List<TKey>, JGONMLFMCPJ)>, IEnumerable, IEnumerator<(TKey, List<TKey>, JGONMLFMCPJ)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private (TKey key, List<TKey> path, JGONMLFMCPJ timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private PDLCJKJEJBF timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public PDLCJKJEJBF <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public IGPFJOOPHMK<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private IEnumerator<PDLCJKJEJBF> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private IEnumerator<(TKey key, List<TKey> path, JGONMLFMCPJ timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		private (TKey, List<TKey>, JGONMLFMCPJ) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x2760DE0", Offset = "0x275FBE0", VA = "0x182760DE0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, JGONMLFMCPJ));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x586BE00", Offset = "0x586AC00", VA = "0x18586BE00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x2760ED0", Offset = "0x275FCD0", VA = "0x182760ED0")]
		[DebuggerHidden]
		public CFLMLLHKGDB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x586BE60", Offset = "0x586AC60", VA = "0x18586BE60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x586B4F0", Offset = "0x586A2F0", VA = "0x18586B4F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x586B430", Offset = "0x586A230", VA = "0x18586B430")]
		private void GEDOPIMJGAM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x586B490", Offset = "0x586A290", VA = "0x18586B490")]
		private void HHOEFEHKFHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x586BDB0", Offset = "0x586ABB0", VA = "0x18586BDB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x586BCB0", Offset = "0x586AAB0", VA = "0x18586BCB0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, JGONMLFMCPJ)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x513EAE0", Offset = "0x513D8E0", VA = "0x18513EAE0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Action<TKey, JGONMLFMCPJ, IMOCAMGHNDM> CHGGAHJLMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Action<TKey, JGONMLFMCPJ, IMOCAMGHNDM> HODDMIHGKFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Action<IGPFJOOPHMK<TKey>, IMOCAMGHNDM> FLCAPKAIFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly IMOCAMGHNDM JBCGOBEIKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly PDLCJKJEJBF LPMMMOMGFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private bool EICHBLDJPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private int JKADBKKCLFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly Stopwatch OAGIKDOAFNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public readonly int NHILGANEBDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private string DFCNINFKIPE;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public PDLCJKJEJBF NBJJLHMFEOJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x8F4270", Offset = "0x8F3070", VA = "0x1808F4270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	[NotNull]
	public string EGBOEHMEDOE
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x8F4230", Offset = "0x8F3030", VA = "0x1808F4230")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x46E3670", Offset = "0x46E2470", VA = "0x1846E3670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x46E3750", Offset = "0x46E2550", VA = "0x1846E3750")]
	public IGPFJOOPHMK(TKey FBLKCONPKBK, IMOCAMGHNDM JBCGOBEIKAJ, [Optional] int? NJGBHLAOCBG, [Optional][CanBeNull] Stopwatch OAGIKDOAFNB, [Optional] Action<TKey, JGONMLFMCPJ, IMOCAMGHNDM> CHGGAHJLMGN, [Optional] Action<TKey, JGONMLFMCPJ, IMOCAMGHNDM> HODDMIHGKFN, [Optional] Action<IGPFJOOPHMK<TKey>, IMOCAMGHNDM> FLCAPKAIFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x46E35A0", Offset = "0x46E23A0", VA = "0x1846E35A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x46E3500", Offset = "0x46E2300", VA = "0x1846E3500")]
	[IteratorStateMachine(typeof(IGPFJOOPHMK<>.KEJAAAGOCDD))]
	public IEnumerable<(TKey, List<TKey>, JGONMLFMCPJ)> BPPMJPALGOP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x46E3420", Offset = "0x46E2220", VA = "0x1846E3420")]
	[IteratorStateMachine(typeof(IGPFJOOPHMK<>.CFLMLLHKGDB))]
	private IEnumerable<(TKey, List<TKey>, JGONMLFMCPJ)> BPPMJPALGOP(List<TKey> FIJDAMLGBMN, PDLCJKJEJBF NNGOKEMGHAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x46E36D0", Offset = "0x46E24D0", VA = "0x1846E36D0")]
	private (long, int) PGKNEHFNHGD()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public abstract class CKPNILKLKEE<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut ADDLNMPANLP(IGPFJOOPHMK<TKey> HPEGCCHCIAG);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	protected CKPNILKLKEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public abstract class GEHFKKHHFOK<TKey> : CKPNILKLKEE<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate string PLMKIFCJLAG(TKey FFOHLCGHDKA);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x44AEC10", Offset = "0x44ADA10", VA = "0x1844AEC10")]
	private static string CHALABOOMMD(TKey FFOHLCGHDKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x44AEB30", Offset = "0x44AD930", VA = "0x1844AEB30", Slot = "4")]
	public override string ADDLNMPANLP(IGPFJOOPHMK<TKey> HPEGCCHCIAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x44AE9E0", Offset = "0x44AD7E0", VA = "0x1844AE9E0")]
	public string ADDLNMPANLP(IGPFJOOPHMK<TKey> HPEGCCHCIAG, [NotNull] PLMKIFCJLAG HEPEGAAIBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string MCONOBIAHJC(IGPFJOOPHMK<TKey> HPEGCCHCIAG, [NotNull] PLMKIFCJLAG HEPEGAAIBEC);

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x4383670", Offset = "0x4382470", VA = "0x184383670")]
	protected GEHFKKHHFOK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class FLOCBKKKKKA<TKey> : CKPNILKLKEE<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate string BELEDMOCHDI(TKey FFOHLCGHDKA);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly string LMOAJJIBDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly double AKMLNHHOIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly bool MNNDNPKCJHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly int IHGPLFDEGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private readonly ISet<string> PLBCAKEMMEL;

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x43CDFE0", Offset = "0x43CCDE0", VA = "0x1843CDFE0")]
	private static string CHALABOOMMD(TKey FFOHLCGHDKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x43CE4C0", Offset = "0x43CD2C0", VA = "0x1843CE4C0")]
	public FLOCBKKKKKA(string LMOAJJIBDFM = "F2", double AKMLNHHOIEC = double.MaxValue, bool MNNDNPKCJHP = false, int IHGPLFDEGBM = int.MaxValue, [Optional] ISet<string> PLBCAKEMMEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x43CD8C0", Offset = "0x43CC6C0", VA = "0x1843CD8C0", Slot = "4")]
	public override Dictionary<string, string> ADDLNMPANLP(IGPFJOOPHMK<TKey> HPEGCCHCIAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x43CE3F0", Offset = "0x43CD1F0", VA = "0x1843CE3F0")]
	private bool NHAGOFAAGBB(string LMBGNPJJCGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x43CD9A0", Offset = "0x43CC7A0", VA = "0x1843CD9A0")]
	public Dictionary<string, string> ADDLNMPANLP(IGPFJOOPHMK<TKey> HPEGCCHCIAG, BELEDMOCHDI HEPEGAAIBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x43CE180", Offset = "0x43CCF80", VA = "0x1843CE180")]
	private string GKPFIAIHNDB(StringBuilder JOFNDJPNENI, List<TKey> DKGGNEAFLHG, BELEDMOCHDI HEPEGAAIBEC, bool GJLBJMIINDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x43CE020", Offset = "0x43CCE20", VA = "0x1843CE020")]
	private static void GFBFGGHGIOI(StringBuilder DIEAPOCHPHC, string KOLLAFCBANP, bool CBIIPCHAHNL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class FFILAPJHDDF<TKey> : GEHFKKHHFOK<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct NHLGLEHIFBM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public PLMKIFCJLAG keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static FFILAPJHDDF<TKey> GGJCMHODIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private readonly string[] FOALADMCCMC;

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x4395880", Offset = "0x4394680", VA = "0x184395880")]
	private FFILAPJHDDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x4394910", Offset = "0x4393710", VA = "0x184394910", Slot = "5")]
	protected override string MCONOBIAHJC(IGPFJOOPHMK<TKey> HPEGCCHCIAG, PLMKIFCJLAG HEPEGAAIBEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x4394810", Offset = "0x4393610", VA = "0x184394810")]
	[CompilerGenerated]
	internal static string KNEHCFGMHGP(string IMILHNANCOF, TKey FFOHLCGHDKA, NHLGLEHIFBM P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class LPKIFNMIDJD : IGPFJOOPHMK<string>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class GGLIEDEKFLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		public Action<LPKIFNMIDJD, IMOCAMGHNDM> callback;

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public GGLIEDEKFLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x7247DF0", Offset = "0x7246BF0", VA = "0x187247DF0")]
		internal void PKAOKKKFPNP(IGPFJOOPHMK<string> timer, IMOCAMGHNDM log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x72499B0", Offset = "0x72487B0", VA = "0x1872499B0")]
	public LPKIFNMIDJD(IMOCAMGHNDM JBCGOBEIKAJ, [Optional] string LIIDAJEPFKF, [Optional] int? NJGBHLAOCBG, [Optional] Stopwatch OAGIKDOAFNB, [Optional] Action<string, JGONMLFMCPJ, IMOCAMGHNDM> CHGGAHJLMGN, [Optional] Action<string, JGONMLFMCPJ, IMOCAMGHNDM> HODDMIHGKFN, [Optional] Action<LPKIFNMIDJD, IMOCAMGHNDM> FLCAPKAIFNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x72498F0", Offset = "0x72486F0", VA = "0x1872498F0")]
	private static Action<IGPFJOOPHMK<string>, IMOCAMGHNDM> FNGPLHNEKFO(Action<LPKIFNMIDJD, IMOCAMGHNDM> JMGOMJNPFIN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public abstract class OOLLIDGACNB
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private class HCDAADOIILE : OOLLIDGACNB
	{
		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public static OOLLIDGACNB GGJCMHODIEM
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x7247E80", Offset = "0x7246C80", VA = "0x187247E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override float ABFHMOALCLJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x1006830", Offset = "0x1005630", VA = "0x181006830", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x7247F80", Offset = "0x7246D80", VA = "0x187247F80")]
		public HCDAADOIILE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private static OOLLIDGACNB DHLJMAOAJFE;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public static OOLLIDGACNB KPNHHCMCHOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x724B2F0", Offset = "0x724A0F0", VA = "0x18724B2F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public abstract float ABFHMOALCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	protected OOLLIDGACNB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface PGIHMBHBFKK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	bool OBOEGBKEDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface MEPEJIIMKOI<T> : PGIHMBHBFKK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	[NotNull]
	Task<T> DDHOPGNGKDH
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	[NotNull]
	MNHDJBCOCND<T> LPMMFMGBDPH
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class HBCEDKEFMJA
{
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x32BAC70", Offset = "0x32B9A70", VA = "0x1832BAC70")]
	public static MEPEJIIMKOI<TResource> FEDIHACKFAJ<TResource, TId>(this DJBHOJIJLJO<TId, TResource> IEEJJABBJCG, TId MIFPCBFGGLI, [Optional] Func<TId, CancellationToken, Task<TResource>>? IJCGOJFLGGH) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class FIDAENKOGPF
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private sealed class IFMLBLMCHMA<T> : GLJKIHHGNCC<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override Task<T?> DDHOPGNGKDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override MNHDJBCOCND<T?> LPMMFMGBDPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x8F7B20", Offset = "0x8F6920", VA = "0x1808F7B20", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x46DB800", Offset = "0x46DA600", VA = "0x1846DB800")]
		public IFMLBLMCHMA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "10")]
		protected override void AIOLEOBNKJJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private sealed class MHMPGBHEHED<T> : GLJKIHHGNCC<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly T JKJFCBNBALI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private readonly Action<T>? FHAHMEKJIOH;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override Task<T> DDHOPGNGKDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x8F4490", Offset = "0x8F3290", VA = "0x1808F4490", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override MNHDJBCOCND<T> LPMMFMGBDPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x8F4330", Offset = "0x8F3130", VA = "0x1808F4330", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x4C99000", Offset = "0x4C97E00", VA = "0x184C99000")]
		public MHMPGBHEHED(T BFICKAGANDC, Action<T>? PKAFAHJDEEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x4C98DC0", Offset = "0x4C97BC0", VA = "0x184C98DC0", Slot = "10")]
		protected override void AIOLEOBNKJJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private sealed class NGPBGGAGPHL<T> : GLJKIHHGNCC<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<T> DDHOPGNGKDH
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override MNHDJBCOCND<T> LPMMFMGBDPH
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x8F7B20", Offset = "0x8F6920", VA = "0x1808F7B20", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x4D29A80", Offset = "0x4D28880", VA = "0x184D29A80")]
		public NGPBGGAGPHL(Exception OMIBAPCKLFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "10")]
		protected override void AIOLEOBNKJJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private sealed class JIDLKOKKLDD<T> : GLJKIHHGNCC<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct AFNHEPCEAKO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public Task<MEPEJIIMKOI<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private TaskAwaiter<MEPEJIIMKOI<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x4480880", Offset = "0x447F680", VA = "0x184480880", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x4480D80", Offset = "0x447FB80", VA = "0x184480D80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private struct CLAOKAHLGEF : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			public Task<MEPEJIIMKOI<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			private TaskAwaiter<MEPEJIIMKOI<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x5968CB0", Offset = "0x5967AB0", VA = "0x185968CB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x5969110", Offset = "0x5967F10", VA = "0x185969110", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		private readonly Task<MEPEJIIMKOI<T>> OABAPEADMHI;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Task<T> DDHOPGNGKDH
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x8F7B20", Offset = "0x8F6920", VA = "0x1808F7B20", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override MNHDJBCOCND<T> LPMMFMGBDPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x8F41F0", Offset = "0x8F2FF0", VA = "0x1808F41F0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x48C6770", Offset = "0x48C5570", VA = "0x1848C6770")]
		public JIDLKOKKLDD(Task<MEPEJIIMKOI<T>> BDCCICFJHCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x48C61B0", Offset = "0x48C4FB0", VA = "0x1848C61B0", Slot = "10")]
		protected override void AIOLEOBNKJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x48C62D0", Offset = "0x48C50D0", VA = "0x1848C62D0")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(JIDLKOKKLDD<>.AFNHEPCEAKO))]
		internal static Task<T> AMMJDJCMPFA(Task<MEPEJIIMKOI<T>> BDCCICFJHCL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x48C6690", Offset = "0x48C5490", VA = "0x1848C6690")]
		[AsyncStateMachine(typeof(JIDLKOKKLDD<>.CLAOKAHLGEF))]
		[CompilerGenerated]
		internal static Task APABPJDNABM(Task<MEPEJIIMKOI<T>> BDCCICFJHCL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class AAGDLNPDOJA<TIn, TOut> : GLJKIHHGNCC<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct JDLOBAHANKO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public AsyncTaskMethodBuilder<TOut> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public Func<TIn, TOut> transformFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public Task<TIn> innerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private Func<TIn, TOut> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private TaskAwaiter<TIn> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x48B9AA0", Offset = "0x48B88A0", VA = "0x1848B9AA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x44D1DB0", Offset = "0x44D0BB0", VA = "0x1844D1DB0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly MEPEJIIMKOI<TIn> BMMOGFNIIKL;

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override Task<TOut> DDHOPGNGKDH
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x8F7B20", Offset = "0x8F6920", VA = "0x1808F7B20", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override MNHDJBCOCND<TOut> LPMMFMGBDPH
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x8F41F0", Offset = "0x8F2FF0", VA = "0x1808F41F0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0x447B710", Offset = "0x447A510", VA = "0x18447B710")]
		public AAGDLNPDOJA(MEPEJIIMKOI<TIn> JKLOFKMGNNF, Func<TIn, TOut> BIIAHIDONKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x447B3C0", Offset = "0x447A1C0", VA = "0x18447B3C0", Slot = "10")]
		protected override void AIOLEOBNKJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x447B410", Offset = "0x447A210", VA = "0x18447B410")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(AAGDLNPDOJA<, >.JDLOBAHANKO))]
		internal static Task<TOut> JLDKBNFEGOE(Task<TIn> BDIAPHFODKP, Func<TIn, TOut> BIIAHIDONKL)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x329B060", Offset = "0x3299E60", VA = "0x18329B060")]
	public static MEPEJIIMKOI<T> JBBIPKIKKBB<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x329B0E0", Offset = "0x3299EE0", VA = "0x18329B0E0")]
	public static MEPEJIIMKOI<T> MBFEINKDPPB<T>(T LDEANEOLAOA, [Optional] Action<T>? PKAFAHJDEEN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x3161CF0", Offset = "0x3160AF0", VA = "0x183161CF0")]
	public static MEPEJIIMKOI<T> ANLMHPBNPPL<T>(Exception OMIBAPCKLFH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x3161CF0", Offset = "0x3160AF0", VA = "0x183161CF0")]
	public static MEPEJIIMKOI<T> KPMNINMFDLA<T>(Task<MEPEJIIMKOI<T>> BDCCICFJHCL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x3100440", Offset = "0x30FF240", VA = "0x183100440")]
	public static MEPEJIIMKOI<TOut> HHEFOFLOCNG<TOut, TIn>(MEPEJIIMKOI<TIn> IPNJAOPIHCP, Func<TIn, TOut> BIIAHIDONKL) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public abstract class GLJKIHHGNCC<T> : MEPEJIIMKOI<T>, PGIHMBHBFKK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly string PJFMGLKNKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private readonly PJHHGAKMFFO ODIDJGGKHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private bool EICHBLDJPCE;

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public bool OBOEGBKEDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0xB4A970", Offset = "0xB49770", VA = "0x180B4A970", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public abstract Task<T> DDHOPGNGKDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public abstract MNHDJBCOCND<T> LPMMFMGBDPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x44D0B50", Offset = "0x44CF950", VA = "0x1844D0B50")]
	public GLJKIHHGNCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x44D0890", Offset = "0x44CF690", VA = "0x1844D0890", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void AIOLEOBNKJJ();
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public abstract class FCDFDNMHKDC<TTask, T> : GLJKIHHGNCC<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class MAMGHCHDALK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public MAMGHCHDALK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x3C63400", Offset = "0x3C62200", VA = "0x183C63400", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x3C636C0", Offset = "0x3C624C0", VA = "0x183C636C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public FCDFDNMHKDC<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public MAMGHCHDALK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0x4C794D0", Offset = "0x4C782D0", VA = "0x184C794D0")]
		[AsyncStateMachine(typeof(FCDFDNMHKDC<, >.MAMGHCHDALK.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> PKKMIOCMIAA(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private readonly Task<T> BDCCICFJHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	protected readonly CancellationTokenSource PCBNIHHNEIO;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public override Task<T> DDHOPGNGKDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public override MNHDJBCOCND<T> LPMMFMGBDPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8F7B20", Offset = "0x8F6920", VA = "0x1808F7B20", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x4389DD0", Offset = "0x4388BD0", VA = "0x184389DD0")]
	protected FCDFDNMHKDC(TTask BDCCICFJHCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x4389D80", Offset = "0x4388B80", VA = "0x184389D80", Slot = "10")]
	protected override void AIOLEOBNKJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T DLMJJCMNHEA(TTask KGALLFNGBDM);

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void NKDMBLAIKCO();
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class OGFOELEIDAC<T> : GLJKIHHGNCC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private readonly DHBMCMEBKMG<Task<T>> LPALJHHNAAE;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public override Task<T> DDHOPGNGKDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(RVA = "0x438D8E0", Offset = "0x438C6E0", VA = "0x18438D8E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public override MNHDJBCOCND<T> LPMMFMGBDPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x8F7B20", Offset = "0x8F6920", VA = "0x1808F7B20", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x4E39BC0", Offset = "0x4E389C0", VA = "0x184E39BC0")]
	public OGFOELEIDAC(DHBMCMEBKMG<Task<T>> FFHGJGCOBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x4E39BA0", Offset = "0x4E389A0", VA = "0x184E39BA0", Slot = "10")]
	protected override void AIOLEOBNKJJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class DNAOJKGDKGB
{
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public static readonly HashAlgorithmName GEFABGMKEMP;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly ThreadLocal<IncrementalHash> GLBFBHNBANF;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x72479A0", Offset = "0x72467A0", VA = "0x1872479A0")]
	public static int GMMIIOAIJKI(this NNPNNEDPMJE LIBEBLEHLMC, IncrementalHash EHFKLAFIBCC, byte[] AGKAMBCHAGK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x7247300", Offset = "0x7246100", VA = "0x187247300")]
	public static bool EIBKLCEMBCB([CanBeNull] this NNPNNEDPMJE LIBEBLEHLMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x7247360", Offset = "0x7246160", VA = "0x187247360")]
	public static bool EIBKLCEMBCB([CanBeNull] this NNPNNEDPMJE LIBEBLEHLMC, [Out] string LKNDCPLLKMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x7247670", Offset = "0x7246470", VA = "0x187247670")]
	public static bool EIBKLCEMBCB([CanBeNull] this NNPNNEDPMJE LIBEBLEHLMC, IncrementalHash EHFKLAFIBCC, byte[] AGKAMBCHAGK, [Out] string LKNDCPLLKMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7247A20", Offset = "0x7246820", VA = "0x187247A20")]
	private static bool HNELCDDGAEM(byte[] EOPJHDGLHNA, Span<byte> ANCGDFLMIOL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class NCEEJOLFCEP
{
	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x7249CE0", Offset = "0x7248AE0", VA = "0x187249CE0")]
	public static int AGKEPGLIOLF(HashAlgorithmName FKLOACFOBMG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x7249E30", Offset = "0x7248C30", VA = "0x187249E30")]
	public static int GMMIIOAIJKI(this LBNHDCINGFG JICEENPLCKI, byte[] HGEHMJLFNEK, IncrementalHash EHFKLAFIBCC, byte[] HADAHBLGCLI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface LBNHDCINGFG
{
	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash EHFKLAFIBCC);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface NNPNNEDPMJE : LBNHDCINGFG
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	[CanBeNull]
	byte[] EMMOBFAFFLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	[CanBeNull]
	byte[] CFNAOMKEPKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class NPONKCJBFIB
{
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static bool HBHJOHJKFGG;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly ArrayPool<byte> LNDEIDICLJL;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly ArrayPool<char> GKOFFGJDNDH;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly Encoding ALMEHFKOOMD;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly ThreadLocal<Encoder> OJEKDHCPBOE;

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x3465140", Offset = "0x3463F40", VA = "0x183465140")]
	public static void HKOBHGLGPNH<T>(this IncrementalHash PHADEEAINCF, [CanBeNull] T MMJIAOCMCPI) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x3465200", Offset = "0x3464000", VA = "0x183465200")]
	public static void MMMGIMAKGCG<T>(this IncrementalHash PHADEEAINCF, [CanBeNull] T JICEENPLCKI) where T : LBNHDCINGFG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x3464C20", Offset = "0x3463A20", VA = "0x183464C20")]
	public static void GJILFDBFOCE<T>(this IncrementalHash PHADEEAINCF, [CanBeNull] IList<T> EJDEDPCFBGJ) where T : LBNHDCINGFG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x724ACB0", Offset = "0x7249AB0", VA = "0x18724ACB0")]
	private static bool MGHGBCONHGP([CanBeNull] LBNHDCINGFG JICEENPLCKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x724A2C0", Offset = "0x72490C0", VA = "0x18724A2C0")]
	public static void DEFLKABHFKO(this IncrementalHash EHFKLAFIBCC, string? MDAEMIFLCDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x724A0F0", Offset = "0x7248EF0", VA = "0x18724A0F0")]
	public static void BPINMPPBGKG(this IncrementalHash EHFKLAFIBCC, long KCKGLGEOPNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x724AE00", Offset = "0x7249C00", VA = "0x18724AE00")]
	public static void PPDNNOOJMNE(this IncrementalHash EHFKLAFIBCC, int JEABMPNKEGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x724A6D0", Offset = "0x72494D0", VA = "0x18724A6D0")]
	public static void FKAINMOEDBJ(this IncrementalHash EHFKLAFIBCC, short HCBDKKDEPML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x724AB40", Offset = "0x7249940", VA = "0x18724AB40")]
	public static void IGKFKEGFMOH(this IncrementalHash EHFKLAFIBCC, byte HGNMDFICOGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x724A8A0", Offset = "0x72496A0", VA = "0x18724A8A0")]
	public static void FLLNMPKPAJD(this IncrementalHash EHFKLAFIBCC, bool FGFMLAEHNII, bool PONAMGFNKBO = false, bool MDELEJKKFFP = false, bool COEFHKMGDIB = false, bool DDFJLMBMJOL = false, bool FDPNDFPFECB = false, bool DAPFEAANMGM = false, bool CBCAEPMIIHD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x34645F0", Offset = "0x34633F0", VA = "0x1834645F0")]
	public static void FGFNBBOCPOG<T>(this IncrementalHash EHFKLAFIBCC, T LJGAMICHBPH) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x724AC50", Offset = "0x7249A50", VA = "0x18724AC50")]
	public static void JKILFNGKFJB(this IncrementalHash EHFKLAFIBCC, float KIBIDENOAFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x724A090", Offset = "0x7248E90", VA = "0x18724A090")]
	public static void AELMEJFCAGC(this IncrementalHash EHFKLAFIBCC, ulong PJJMFJBAENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x724AD40", Offset = "0x7249B40", VA = "0x18724AD40")]
	public static void NMOPCEDHIEK(this IncrementalHash EHFKLAFIBCC, uint NNFEKNKIOOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x724ADA0", Offset = "0x7249BA0", VA = "0x18724ADA0")]
	public static void ONPJHEINHCN(this IncrementalHash EHFKLAFIBCC, ushort GMOMAAAOFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x724AA10", Offset = "0x7249810", VA = "0x18724AA10")]
	public static void HDMGDLKPJBC(this IncrementalHash EHFKLAFIBCC, Vector3 AFDAGNNPAOL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class BOJJGKEHAJI : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x72470E0", Offset = "0x7245EE0", VA = "0x1872470E0")]
	public BOJJGKEHAJI(string KKBJAPCBOHH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public abstract class EOFIBDNMNHI
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public delegate void IDHCCHFKMNH(ushort HLIENFJBPKJ, ushort IPALNLIJKAI, ushort MKEABMHBDAA, ushort MBGAOPBLJLN);

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public delegate void EPLCMMIPPNN(ushort LHGFAJDAJIE, ushort MFPDNLNBELG);

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public delegate void OHLGIFBGJOC();

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public const ushort IIFDDIFLBPP = ushort.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
	protected EOFIBDNMNHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class IGAHFJLNGKC<T> : EOFIBDNMNHI where T : IGAHFJLNGKC<T>.LCKBJDEGPGB
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public interface LCKBJDEGPGB
	{
		[Cpp2IlInjected.Token(Token = "0x17000058")]
		EPLCMMIPPNN GFMAGCIHPGF
		{
			[Cpp2IlInjected.Token(Token = "0x60001BB")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		EPLCMMIPPNN AKJOBFLDHFB
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		OHLGIFBGJOC JEGFHNEAFOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private Dictionary<uint, T> HPMDGLOPNFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private OHLGIFBGJOC NOPKGCNHLCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private OHLGIFBGJOC FGHEAMJOKFM;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool LNEBMJDGANI
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xBE0400", Offset = "0xBDF200", VA = "0x180BE0400")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x8FE800", Offset = "0x8FD600", VA = "0x1808FE800")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public ushort JNMLLGDLBIM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x46DCA40", Offset = "0x46DB840", VA = "0x1846DCA40")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x46DC1F0", Offset = "0x46DAFF0", VA = "0x1846DC1F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public ushort EPNFHCEFKIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x46DBD20", Offset = "0x46DAB20", VA = "0x1846DBD20")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x46DC1E0", Offset = "0x46DAFE0", VA = "0x1846DC1E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public ushort CEIHANOABCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0xC8E960", Offset = "0xC8D760", VA = "0x180C8E960")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xC8EAA0", Offset = "0xC8D8A0", VA = "0x180C8EAA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public ushort KMEGENDMIKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x46DBD30", Offset = "0x46DAB30", VA = "0x1846DBD30")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x46DCA30", Offset = "0x46DB830", VA = "0x1846DCA30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	protected bool HNALOGCJPBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x1567E40", Offset = "0x1566C40", VA = "0x181567E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	protected bool HBKJPJJKGII
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x1D3E2C0", Offset = "0x1D3D0C0", VA = "0x181D3E2C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event IDHCCHFKMNH LGCKKLAGKHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x46DBD40", Offset = "0x46DAB40", VA = "0x1846DBD40")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x46DBB00", Offset = "0x46DA900", VA = "0x1846DBB00")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x46DBC10", Offset = "0x46DAA10", VA = "0x1846DBC10")]
	private T DCJGLCGCJJA(ushort LNBONOJCELA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x46DC120", Offset = "0x46DAF20", VA = "0x1846DC120")]
	private T KBLGFMMLCGE(ushort LNBONOJCELA, ushort CJJKPAEMIGH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x46DBCC0", Offset = "0x46DAAC0", VA = "0x1846DBCC0")]
	protected T EKDJGIPIGDI(uint DLEGIHAJJIC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x46DCA50", Offset = "0x46DB850", VA = "0x1846DCA50")]
	protected IGAHFJLNGKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x46DB950", Offset = "0x46DA750", VA = "0x1846DB950")]
	public void ACAJIADEAPL(ushort GPBFKMPJAFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x46DB990", Offset = "0x46DA790", VA = "0x1846DB990")]
	public void ACAJIADEAPL(ushort GPBFKMPJAFG, ushort EEBGPIHKLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x46DB9F0", Offset = "0x46DA7F0", VA = "0x1846DB9F0", Slot = "4")]
	protected virtual void ACAJIADEAPL(uint GGNDALPPILF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x46DC200", Offset = "0x46DB000", VA = "0x1846DC200")]
	protected void NKGEMILAKBE(uint GGNDALPPILF, uint ENIOCPKBOGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x46DBDE0", Offset = "0x46DABE0", VA = "0x1846DBDE0")]
	protected void HHGACAIECOA(ushort LNBONOJCELA, ushort CJJKPAEMIGH, T DKNLFDPIIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x46DBBA0", Offset = "0x46DA9A0", VA = "0x1846DBBA0")]
	private void BPDENLBFKFF(uint DLEGIHAJJIC, T DKNLFDPIIII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x46DBEB0", Offset = "0x46DACB0", VA = "0x1846DBEB0")]
	protected void JIOCMCBAJPL(float GLDLKCMKFON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x46DBC00", Offset = "0x46DAA00", VA = "0x1846DBC00")]
	protected uint CPLFDHLIGMG(ushort LNBONOJCELA, ushort CJJKPAEMIGH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x46DBE90", Offset = "0x46DAC90", VA = "0x1846DBE90")]
	protected ushort HIFPDJJBENN(uint GHEFBGANCIN)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x46DBEA0", Offset = "0x46DACA0", VA = "0x1846DBEA0")]
	protected ushort ICFMCJJMCMI(uint GHEFBGANCIN)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public abstract class JIBIKPMKEAF : IGAHFJLNGKC<JIBIKPMKEAF.BDMBOAFOBCI>
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class BDMBOAFOBCI : LCKBJDEGPGB
	{
		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public EPLCMMIPPNN GFMAGCIHPGF
		{
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0x8F41C0", Offset = "0x8F2FC0", VA = "0x1808F41C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public EPLCMMIPPNN AKJOBFLDHFB
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x8F41E0", Offset = "0x8F2FE0", VA = "0x1808F41E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public OHLGIFBGJOC JEGFHNEAFOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x8F7B20", Offset = "0x8F6920", VA = "0x1808F7B20", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x8F7B10", Offset = "0x8F6910", VA = "0x1808F7B10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public BDMBOAFOBCI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x7249630", Offset = "0x7248430", VA = "0x187249630")]
	public void KCPNMPNPPMD(ushort NMLHIKLEMFF, EPLCMMIPPNN LNJENFGEABO, EPLCMMIPPNN CPMGMMJHKLE, OHLGIFBGJOC FABMHDDCFMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x7249710", Offset = "0x7248510", VA = "0x187249710")]
	public void KCPNMPNPPMD(ushort LNBONOJCELA, ushort CJJKPAEMIGH, EPLCMMIPPNN LNJENFGEABO, EPLCMMIPPNN CPMGMMJHKLE, OHLGIFBGJOC FABMHDDCFMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x72495E0", Offset = "0x72483E0", VA = "0x1872495E0")]
	public void IGIPDIBMNHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x72497F0", Offset = "0x72485F0", VA = "0x1872497F0")]
	protected JIBIKPMKEAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class LJINGEFMHFC : JIBIKPMKEAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private bool BMMBPKGMHHK;

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool FIMGNNJILII
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xADD5B0", Offset = "0xADC3B0", VA = "0x180ADD5B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xB56580", Offset = "0xB55380", VA = "0x180B56580")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7249830", Offset = "0x7248630", VA = "0x187249830")]
	public void JEELJGCJJCO(ushort BFAKKBELKGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7249890", Offset = "0x7248690", VA = "0x187249890")]
	public void JEELJGCJJCO(ushort BFAKKBELKGC, ushort GLIMKDHNOMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x72497F0", Offset = "0x72485F0", VA = "0x1872497F0")]
	public LJINGEFMHFC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class IOGHJEMELGA<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	internal class JBOKMANLKEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public TNode DJAJDIFOIHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public TNode IFAMCPHMKIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public KMOEMJNCECO MPGLDFENCOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public List<KMOEMJNCECO> HEKHMAPJGPP;

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public JBOKMANLKEP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	internal struct KMOEMJNCECO : IComparable<KMOEMJNCECO>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public int JHPBGABBKOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		public TClaimant CAKDBFOHOCN;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x14426C0", Offset = "0x14414C0", VA = "0x1814426C0")]
		public KMOEMJNCECO(int JHPBGABBKOP, TClaimant CAKDBFOHOCN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x49D6F50", Offset = "0x49D5D50", VA = "0x1849D6F50")]
		public bool LOKJFOIDOMG([In] KMOEMJNCECO LHMPMCLNOPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x49D6F40", Offset = "0x49D5D40", VA = "0x1849D6F40")]
		public bool EFEKIDNPDJP([In] KMOEMJNCECO LHMPMCLNOPG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x49D6F30", Offset = "0x49D5D30", VA = "0x1849D6F30", Slot = "4")]
		public int CompareTo(KMOEMJNCECO LHMPMCLNOPG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x49D6FB0", Offset = "0x49D5DB0", VA = "0x1849D6FB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public enum BMCAKOMFNJM
	{
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class JGJLHFHBOME : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public IOGHJEMELGA<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0xC3B4C0", Offset = "0xC3A2C0", VA = "0x180C3B4C0")]
		[DebuggerHidden]
		public JGJLHFHBOME(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x48BF240", Offset = "0x48BE040", VA = "0x1848BF240", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x48BF420", Offset = "0x48BE220", VA = "0x1848BF420", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x48BF320", Offset = "0x48BE120", VA = "0x1848BF320", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x4353860", Offset = "0x4352660", VA = "0x184353860", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly PJDOOEEFCKB<JBOKMANLKEP> CLFGBBMPDJA;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly PJDOOEEFCKB<List<KMOEMJNCECO>> ECBNFODGLOG;

	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private static int IOPDPEKOFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	internal readonly Dictionary<TClaimant, TNode> JIIDODNHJMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	internal readonly Dictionary<TNode, JBOKMANLKEP> APNECHCCMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private BMCAKOMFNJM NAIDLLHPHIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool BBDDFKFCEGM;

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode PIDHLJFJIOA(TNode KFDHCNOCENN);

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void AAMMMKJDOKF(TNode KFDHCNOCENN, TClaimant PAAMJPACALD, TClaimant BIDPNNDPLAI);

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x46F8040", Offset = "0x46F6E40", VA = "0x1846F8040")]
	public IOGHJEMELGA(BMCAKOMFNJM NAIDLLHPHIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x46F7DB0", Offset = "0x46F6BB0", VA = "0x1846F7DB0")]
	public void OEDGEDNIJJG(TNode KFDHCNOCENN, TNode LBOOKOKCBHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x46F7450", Offset = "0x46F6250", VA = "0x1846F7450")]
	public void IIMHGBLIOAO(TClaimant CAKDBFOHOCN, TNode DPNEHFMIFLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x46F69D0", Offset = "0x46F57D0", VA = "0x1846F69D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x46F75D0", Offset = "0x46F63D0", VA = "0x1846F75D0")]
	private void IOGMIJEKMED(TClaimant CAKDBFOHOCN, TNode LOMGLDMPAGJ, TNode DPNEHFMIFLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x46F7800", Offset = "0x46F6600", VA = "0x1846F7800")]
	private int JLBKMPAABIA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x46F6690", Offset = "0x46F5490", VA = "0x1846F6690")]
	private void DFBHBHOHADA(TClaimant CAKDBFOHOCN, TNode IGEGCOAMDOI, TNode JBFBAHDHLKA, int DACLOKEFJCH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x46F7380", Offset = "0x46F6180", VA = "0x1846F7380")]
	private void GKPKINFDPLO(KMOEMJNCECO NCNLCACEAHF, JBOKMANLKEP JDNLPMLJDPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x46F79C0", Offset = "0x46F67C0", VA = "0x1846F79C0")]
	private void NCMDAALIDGB(TClaimant CAKDBFOHOCN, TNode IGEGCOAMDOI, TNode JBFBAHDHLKA, int DACLOKEFJCH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x46F6560", Offset = "0x46F5360", VA = "0x1846F6560")]
	private void CIIMMIPOHIE(KMOEMJNCECO NCNLCACEAHF, TNode KFDHCNOCENN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x46F76A0", Offset = "0x46F64A0", VA = "0x1846F76A0")]
	private void JHBJMEEKKOL(KMOEMJNCECO NCNLCACEAHF, JBOKMANLKEP JDNLPMLJDPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x46F7870", Offset = "0x46F6670", VA = "0x1846F7870")]
	private void LJAFBDPNFBM(JBOKMANLKEP JDNLPMLJDPE, bool IJAIKDDDAGK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x46F6BE0", Offset = "0x46F59E0", VA = "0x1846F6BE0")]
	private void ECHNMHCLAEO(JBOKMANLKEP JDNLPMLJDPE, TNode LBOOKOKCBHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x46F7290", Offset = "0x46F6090", VA = "0x1846F7290")]
	[IteratorStateMachine(typeof(IOGHJEMELGA<, >.JGJLHFHBOME))]
	private IEnumerable<TNode> GHIHJEJCJJA(TNode IGEGCOAMDOI, TNode JBFBAHDHLKA, bool MDHLLMAIBEH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x46F7CA0", Offset = "0x46F6AA0", VA = "0x1846F7CA0")]
	private JBOKMANLKEP NDIJFNBGAHF(TNode KFDHCNOCENN, TNode IFAMCPHMKIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x46F7110", Offset = "0x46F5F10", VA = "0x1846F7110")]
	private JBOKMANLKEP FNBIGANNDAE(TNode KFDHCNOCENN, TNode IFAMCPHMKIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x46F6F50", Offset = "0x46F5D50", VA = "0x1846F6F50")]
	private void FBJFKLLEJJL(JBOKMANLKEP JDNLPMLJDPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class PJFNLCNJIGJ<T> : IEnumerable<PJFNLCNJIGJ<T>.LPBLOPHGOAI>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct LPBLOPHGOAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public T IPHILEOFJLB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int KNCPCNBMDNF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class FNKOBHBDDOJ : IEnumerator<LPBLOPHGOAI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private PJFNLCNJIGJ<T> CMAKDFMJDKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private int KNCPCNBMDNF;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x4010180", Offset = "0x400EF80", VA = "0x184010180", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public LPBLOPHGOAI ABCAFDPDGPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x43D1F30", Offset = "0x43D0D30", VA = "0x1843D1F30", Slot = "4")]
			get
			{
				return default(LPBLOPHGOAI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x43D1EF0", Offset = "0x43D0CF0", VA = "0x1843D1EF0")]
		public FNKOBHBDDOJ(PJFNLCNJIGJ<T> CMAKDFMJDKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x43D1DF0", Offset = "0x43D0BF0", VA = "0x1843D1DF0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x40681E0", Offset = "0x4066FE0", VA = "0x1840681E0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0xF9FB80", Offset = "0xF9E980", VA = "0x180F9FB80", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private struct LBJONDNDFAL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public bool GECNPFJLDMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public T IPHILEOFJLB;
	}

	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private const int OBKFMFFMBMN = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private readonly Dictionary<T, int> JBONOABLHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private LBJONDNDFAL[] MMGMIPGFPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private int MHNMOHJFBHG;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public int DKHDPDEPMJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x935800", Offset = "0x934600", VA = "0x180935800")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x9353A0", Offset = "0x9341A0", VA = "0x1809353A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int IPKHGMJKDEO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x3C74770", Offset = "0x3C73570", VA = "0x183C74770")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x4F33560", Offset = "0x4F32360", VA = "0x184F33560")]
	public PJFNLCNJIGJ(int MLAKJOPIGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x4F33A80", Offset = "0x4F32880", VA = "0x184F33A80")]
	public PJFNLCNJIGJ(LPBLOPHGOAI[] EKADOMIOHHG, bool ADMAJFCOOBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x4F32770", Offset = "0x4F31570", VA = "0x184F32770")]
	public int AIGCJIIDHJA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x4F32A40", Offset = "0x4F31840", VA = "0x184F32A40")]
	private int DIJJCMPFLBL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x4F33470", Offset = "0x4F32270", VA = "0x184F33470", Slot = "6")]
	protected virtual uint LHNLIEBFAPH(uint EHFKLAFIBCC, T IPHILEOFJLB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x4F32CC0", Offset = "0x4F31AC0", VA = "0x184F32CC0")]
	public bool EDFMKGHIOIB(T IPHILEOFJLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x4F333F0", Offset = "0x4F321F0", VA = "0x184F333F0")]
	public int JJJCBKKHHGM(T IPHILEOFJLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x4F326B0", Offset = "0x4F314B0", VA = "0x184F326B0")]
	public T AIAPLHLPKLG(int KNCPCNBMDNF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x4F32D70", Offset = "0x4F31B70", VA = "0x184F32D70")]
	public bool GPJOLIGKBOI(T IPHILEOFJLB, bool ALBOFBJHMJO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x4F33070", Offset = "0x4F31E70", VA = "0x184F33070")]
	public bool GPJOLIGKBOI(T IPHILEOFJLB, int KNCPCNBMDNF, bool ALBOFBJHMJO = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x4F332D0", Offset = "0x4F320D0", VA = "0x184F332D0")]
	private int JBPNEEOJODC(int GJCOHOCILFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x4F334C0", Offset = "0x4F322C0", VA = "0x184F334C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x4F334C0", Offset = "0x4F322C0", VA = "0x184F334C0", Slot = "4")]
	private IEnumerator<LPBLOPHGOAI> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class PJDOOEEFCKB<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private readonly Stack<T> AEDLDLDGAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly List<T> CEBLEJEBFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly int LLDEDJAHPIG;

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x4F32090", Offset = "0x4F30E90", VA = "0x184F32090")]
	public static PJDOOEEFCKB<T> NJLDGLIEONA(int MLAKJOPIGGN = 0, int LLDEDJAHPIG = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x4F32280", Offset = "0x4F31080", VA = "0x184F32280")]
	public static PJDOOEEFCKB<T> OPLMLDLBNFC(int MLAKJOPIGGN = 0, int LLDEDJAHPIG = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x4F32450", Offset = "0x4F31250", VA = "0x184F32450")]
	public PJDOOEEFCKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x4F324A0", Offset = "0x4F312A0", VA = "0x184F324A0")]
	public PJDOOEEFCKB(int MLAKJOPIGGN, int LLDEDJAHPIG = int.MaxValue, bool ELPCEAPBCHP = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x4F31EC0", Offset = "0x4F30CC0", VA = "0x184F31EC0")]
	public T ECBHJOIKIMH()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x4F32370", Offset = "0x4F31170", VA = "0x184F32370")]
	public void PBAOHHFJIIL(T IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x4F32180", Offset = "0x4F30F80", VA = "0x184F32180")]
	private void NNKNOLNDPEL(T IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x4F31CF0", Offset = "0x4F30AF0", VA = "0x184F31CF0")]
	private void DHMAJKOEMKC(T IPHILEOFJLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x4F31D30", Offset = "0x4F30B30", VA = "0x184F31D30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x4F31B00", Offset = "0x4F30900", VA = "0x184F31B00")]
	private void CLHBPKPGBGJ(IEnumerable<T> DCFFMJLJGJB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class CDDADMIMGBH<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private Dictionary<int, T> BLCDMBCGKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private T IABNAINKGLL;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public virtual T EDDJIHNCKAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x8F4430", Offset = "0x8F3230", VA = "0x1808F4430", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x8F41E0", Offset = "0x8F2FE0", VA = "0x1808F41E0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x585E970", Offset = "0x585D770", VA = "0x18585E970")]
	public bool MILLFGFJJFB(T IPHILEOFJLB, int JHPBGABBKOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x46CD4E0", Offset = "0x46CC2E0", VA = "0x1846CD4E0")]
	public bool LBFCCEACMDE(int JHPBGABBKOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x585E2E0", Offset = "0x585D0E0", VA = "0x18585E2E0")]
	public T ADEHGCHIBAM(int KGFMJHGPKJJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x585E7D0", Offset = "0x585D5D0", VA = "0x18585E7D0")]
	private bool KLBOLHNIBGG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x585E910", Offset = "0x585D710", VA = "0x18585E910")]
	public bool MHAMFDPPPMK(int JHPBGABBKOP, [Out] T IPHILEOFJLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x46CE330", Offset = "0x46CD130", VA = "0x1846CE330")]
	public CDDADMIMGBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class GGBCPOHFKJA<T>
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	protected struct DEFGAJJMIBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public T HKHKCHJEPKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public int CKBPAMIEPPI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	protected readonly List<DEFGAJJMIBN> OFEPONFGFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private T AAIDCEDOBCK;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int IPKHGMJKDEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x3C74770", Offset = "0x3C73570", VA = "0x183C74770")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x44C0B10", Offset = "0x44BF910", VA = "0x1844C0B10")]
	public bool AMMEABLHNKI(T IPHILEOFJLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x44C1650", Offset = "0x44C0450", VA = "0x1844C1650")]
	public void MDGAONDGEMG(T IPHILEOFJLB, int JHPBGABBKOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x44C1380", Offset = "0x44C0180", VA = "0x1844C1380")]
	public bool IEINLEAGPOE(T IPHILEOFJLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x44C1700", Offset = "0x44C0500", VA = "0x1844C1700")]
	public void NCEIDOKFHPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x44C09E0", Offset = "0x44BF7E0", VA = "0x1844C09E0")]
	public T ACKJKMBBCKG()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x44C1080", Offset = "0x44BFE80", VA = "0x1844C1080")]
	protected void BLHBHDALJPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x44C17A0", Offset = "0x44C05A0", VA = "0x1844C17A0")]
	public GGBCPOHFKJA()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[SerializeField]
		[EECICDBJENE(ADIKDNKOEBP.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x724B670", Offset = "0x724A470", VA = "0x18724B670")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x724B940", Offset = "0x724A740", VA = "0x18724B940")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x724B850", Offset = "0x724A650", VA = "0x18724B850")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x724B5C0", Offset = "0x724A3C0", VA = "0x18724B5C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x724B890", Offset = "0x724A690", VA = "0x18724B890")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x724B7A0", Offset = "0x724A5A0", VA = "0x18724B7A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x724B530", Offset = "0x724A330", VA = "0x18724B530")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x50DFFE0", Offset = "0x50DEDE0", VA = "0x1850DFFE0", Slot = "4")]
		public virtual T COFPOHDIAFA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class HGDDJPDOLIG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private Dictionary<byte, IEBKMPKHOFG> KJKCHGPDEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly PJDOOEEFCKB<IEBKMPKHOFG> PJBFODGELCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private readonly bool PAMFOCADIPA;

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public IEBKMPKHOFG AEGPPEBHGOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x8F4460", Offset = "0x8F3260", VA = "0x1808F4460")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x8F41C0", Offset = "0x8F2FC0", VA = "0x1808F41C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public Vector2 CDLCLHJDJIA
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x13A9260", Offset = "0x13A8060", VA = "0x1813A9260")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0xB4CAC0", Offset = "0xB4B8C0", VA = "0x180B4CAC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private Vector2 JCFMMECDGJO
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0xB72600", Offset = "0xB71400", VA = "0x180B72600")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public Vector2 FGOFGMBHBKL
	{
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x7248D20", Offset = "0x7247B20", VA = "0x187248D20")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x8F4440", Offset = "0x8F3240", VA = "0x1808F4440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public int CGDCOEIMOBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x8F9AC0", Offset = "0x8F88C0", VA = "0x1808F9AC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x8F9750", Offset = "0x8F8550", VA = "0x1808F9750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x7248F80", Offset = "0x7247D80", VA = "0x187248F80")]
	public HGDDJPDOLIG(Bounds LFMGLMCEMDO, Vector2[] AJOGINFJFDE, int CKNAIBJDKEJ, byte GJCOHOCILFF, float IFJFHBMHIJG = 0f, [Optional] PJDOOEEFCKB<IEBKMPKHOFG> PJBFODGELCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x7247FD0", Offset = "0x7246DD0", VA = "0x187247FD0")]
	public void CHLLEPBAGFF(Bounds LFMGLMCEMDO, Vector2[] AJOGINFJFDE, int CKNAIBJDKEJ, byte GJCOHOCILFF, float IFJFHBMHIJG = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x7248CC0", Offset = "0x7247AC0", VA = "0x187248CC0")]
	public IEBKMPKHOFG OLCMPPGGOMF(byte KNCPCNBMDNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x7248520", Offset = "0x7247320", VA = "0x187248520")]
	public void JFFHHLFJCKD(Vector3 AKEODPFBHJE, float KDEOAIMLOKJ, float GDHCHIIGIBP, List<byte> OOHHADEAMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x7248D40", Offset = "0x7247B40", VA = "0x187248D40")]
	public void PAEDOPOHAHH(IEBKMPKHOFG.FINFJDLKHLI FLFLBKMDBDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x72485F0", Offset = "0x72473F0", VA = "0x1872485F0")]
	public static int LIKHGDHPIAK(Vector2[] AJOGINFJFDE, int CKNAIBJDKEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x7248A90", Offset = "0x7247890", VA = "0x187248A90")]
	private IEBKMPKHOFG OIIDEOODENA(byte KNCPCNBMDNF, IEBKMPKHOFG.NFKPIDINJBC JAHKGJHKMHC, IEBKMPKHOFG IFAMCPHMKIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x72486D0", Offset = "0x72474D0", VA = "0x1872486D0")]
	private void NOAGJJLMNLB(IEBKMPKHOFG IFAMCPHMKIP, Vector2[] AJOGINFJFDE, int NOFPGCOIBFA, int AHMHCPBPLNN, int JEJEGIPBLFM, int MMPEECJNFKH, float IFJFHBMHIJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x7248D60", Offset = "0x7247B60", VA = "0x187248D60")]
	private void PLDLFINGLML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x7248460", Offset = "0x7247260", VA = "0x187248460", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x72484C0", Offset = "0x72472C0", VA = "0x1872484C0", Slot = "1")]
	~HGDDJPDOLIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class IEBKMPKHOFG
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public enum NFKPIDINJBC
	{
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public enum FINFJDLKHLI
	{
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public byte OFAGBBGFDNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public Vector3 LLJDEKFEAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public Vector3 JCGPAOIEEDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public Vector3 KBHPNJLNKAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public Vector3 GGCFGNHEFBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public NFKPIDINJBC ONEFAFKLGDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public IEBKMPKHOFG LCIGPFKHHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public List<IEBKMPKHOFG> DAIOPDFCLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public bool PKFNJIMDCJI;

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x72495C0", Offset = "0x72483C0", VA = "0x1872495C0")]
	public IEBKMPKHOFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x7249130", Offset = "0x7247F30", VA = "0x187249130")]
	public void AOEKKHIFAME(IEBKMPKHOFG DOOFGBAMPBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x8F6D40", Offset = "0x8F5B40", VA = "0x1808F6D40")]
	public void PAEDOPOHAHH(int CHJJMKOKEMN, FINFJDLKHLI FLFLBKMDBDJ, int HODEHKGMDDA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x7249360", Offset = "0x7248160", VA = "0x187249360")]
	public void JFFHHLFJCKD(List<byte> OOHHADEAMDG, Vector3 AKEODPFBHJE, float KDEOAIMLOKJ, float GDHCHIIGIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x7249270", Offset = "0x7248070", VA = "0x187249270")]
	public bool EHFBDFMMJEL(Vector3 OHIOLMDNDJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x72492A0", Offset = "0x72480A0", VA = "0x1872492A0")]
	public bool ILCFOOHHJNI(Vector3 OHIOLMDNDJK, float OIINHNJALLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x72492D0", Offset = "0x72480D0", VA = "0x1872492D0")]
	public void JEELJGCJJCO()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000076")]
		public struct NLECDJCMMEP<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			private readonly List<Component> BJCKKCNKPEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			private readonly bool MPEOJDGIPDC;

			[Cpp2IlInjected.Token(Token = "0x6000250")]
			[Cpp2IlInjected.Address(RVA = "0x155A9B0", Offset = "0x15597B0", VA = "0x18155A9B0")]
			public NLECDJCMMEP(List<Component> BJCKKCNKPEK, bool MPEOJDGIPDC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x4D31820", Offset = "0x4D30620", VA = "0x184D31820")]
			public FBCLBCMBKAH<T> NAPBKLICNNH()
			{
				return default(FBCLBCMBKAH<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x4D31880", Offset = "0x4D30680", VA = "0x184D31880", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x4D31880", Offset = "0x4D30680", VA = "0x184D31880", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		public struct FBCLBCMBKAH<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			private readonly List<Component> BJCKKCNKPEK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			private readonly bool MPEOJDGIPDC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000131")]
			private int KNCPCNBMDNF;

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public T ABCAFDPDGPK
			{
				[Cpp2IlInjected.Token(Token = "0x6000255")]
				[Cpp2IlInjected.Address(RVA = "0x437EDC0", Offset = "0x437DBC0", VA = "0x18437EDC0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000256")]
				[Cpp2IlInjected.Address(RVA = "0x437ED50", Offset = "0x437DB50", VA = "0x18437ED50", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x437ED90", Offset = "0x437DB90", VA = "0x18437ED90")]
			public FBCLBCMBKAH(List<Component> BJCKKCNKPEK, bool MPEOJDGIPDC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000257")]
			[Cpp2IlInjected.Address(RVA = "0x437EC90", Offset = "0x437DA90", VA = "0x18437EC90", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000258")]
			[Cpp2IlInjected.Address(RVA = "0x437ECA0", Offset = "0x437DAA0", VA = "0x18437ECA0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000259")]
			[Cpp2IlInjected.Address(RVA = "0x4059790", Offset = "0x4058590", VA = "0x184059790", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x724D360", Offset = "0x724C160", VA = "0x18724D360")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x724CD80", Offset = "0x724BB80", VA = "0x18724CD80")]
		private void JEELJGCJJCO(GameObject IDGNIKPAEDA, bool MKKNPGPEIPF = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x724CEF0", Offset = "0x724BCF0", VA = "0x18724CEF0")]
		public static void JEELJGCJJCO(GameObject IDGNIKPAEDA, ToolHierarchyCache IEEJJABBJCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x724CD00", Offset = "0x724BB00", VA = "0x18724CD00")]
		public void FFLBJMNJKKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x362FA60", Offset = "0x362E860", VA = "0x18362FA60")]
		public void OODHFBJPHEI<T>(Action<T> OOCJAOHFGJK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x362F9C0", Offset = "0x362E7C0", VA = "0x18362F9C0")]
		public T HGLOCKLKOCG<T>(bool MPEOJDGIPDC = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0x362F900", Offset = "0x362E700", VA = "0x18362F900")]
		public NLECDJCMMEP<T> AIBLEGCENKM<T>(bool MPEOJDGIPDC = false) where T : class
		{
			return default(NLECDJCMMEP<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x724CF80", Offset = "0x724BD80", VA = "0x18724CF80")]
		public List<Component> KLBACIHOGGB(Type OBDHBADPJNM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x724CC80", Offset = "0x724BA80", VA = "0x18724CC80", Slot = "4")]
		public bool Equals(ToolHierarchyCache LBONEMFCDEA, ToolHierarchyCache IOKFBHNPJAN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x724CD10", Offset = "0x724BB10", VA = "0x18724CD10", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache JOOHPPHJKMI)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class KMLNGNIPMLI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private int MLAKJOPIGGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private int MCGIDCEHKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private List<T> OLAJDKDOKOD;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int IPKHGMJKDEO
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x438D8E0", Offset = "0x438C6E0", VA = "0x18438D8E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public T HGAKFPEEOJK
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x49D4810", Offset = "0x49D3610", VA = "0x1849D4810")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public T KOEOLBCAGBE
	{
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0x49D4B20", Offset = "0x49D3920", VA = "0x1849D4B20")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public T DAMIDPAOCBP
	{
		[Cpp2IlInjected.Token(Token = "0x600025D")]
		[Cpp2IlInjected.Address(RVA = "0x49D4950", Offset = "0x49D3750", VA = "0x1849D4950")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x49D4FB0", Offset = "0x49D3DB0", VA = "0x1849D4FB0")]
	public KMLNGNIPMLI(int MLAKJOPIGGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x49D4DF0", Offset = "0x49D3BF0", VA = "0x1849D4DF0")]
	public void MDGAONDGEMG(T PMCIBFLBCIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x49D4F50", Offset = "0x49D3D50", VA = "0x1849D4F50")]
	public void NCEIDOKFHPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x49D49D0", Offset = "0x49D37D0", VA = "0x1849D49D0")]
	public void EKINBEPEJLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x49D4AC0", Offset = "0x49D38C0", VA = "0x1849D4AC0")]
	public void FDINHGKLALI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(RVA = "0x49D4740", Offset = "0x49D3540", VA = "0x1849D4740")]
	public void BMGBNEIGAKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(RVA = "0x49D4C10", Offset = "0x49D3A10", VA = "0x1849D4C10")]
	public List<T> MBLGHPOFEFG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class DICKEMDLJAF<T>
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private struct CDNJALDBPMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public int CKBPAMIEPPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public T HKHKCHJEPKB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private readonly Dictionary<object, CDNJALDBPMM> BLCDMBCGKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private readonly EqualityComparer<T> NGOKGAGMIKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private T IABNAINKGLL;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public virtual T EDDJIHNCKAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000265")]
		[Cpp2IlInjected.Address(RVA = "0xBE3510", Offset = "0xBE2310", VA = "0x180BE3510", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000266")]
		[Cpp2IlInjected.Address(RVA = "0x6100620", Offset = "0x60FF420", VA = "0x186100620", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public bool OFOFOJHAONE
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x61034B0", Offset = "0x61022B0", VA = "0x1861034B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public object KAEBBHODEBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x8F4270", Offset = "0x8F3070", VA = "0x1808F4270")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x8F7B30", Offset = "0x8F6930", VA = "0x1808F7B30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x6104120", Offset = "0x6102F20", VA = "0x186104120")]
	public bool MILLFGFJJFB(T IPHILEOFJLB, object HACFGBHNOCC, int JHPBGABBKOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x61033F0", Offset = "0x61021F0", VA = "0x1861033F0")]
	public bool LBFCCEACMDE(object HACFGBHNOCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x6103CE0", Offset = "0x6102AE0", VA = "0x186103CE0")]
	public bool MHAMFDPPPMK(object HACFGBHNOCC, [Out] T IPHILEOFJLB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x46C59A0", Offset = "0x46C47A0", VA = "0x1846C59A0")]
	public void NCEIDOKFHPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x6101930", Offset = "0x6100730", VA = "0x186101930")]
	private bool KLBOLHNIBGG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x6104B60", Offset = "0x6103960", VA = "0x186104B60")]
	public DICKEMDLJAF()
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
