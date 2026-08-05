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
		[Cpp2IlInjected.Address(RVA = "0x87C5D0", Offset = "0x87B7D0", VA = "0x18087C5D0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x68C5A60", Offset = "0x68C4C60", VA = "0x1868C5A60")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x87D8D0", Offset = "0x87CAD0", VA = "0x18087D8D0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x87D910", Offset = "0x87CB10", VA = "0x18087D910")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class OGEGJKMLCNM : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x14D3B10", Offset = "0x14D2D10", VA = "0x1814D3B10")]
	public OGEGJKMLCNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, CEAGNJHJOCG, FOEMIFIPDHC, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x852890", Offset = "0x851A90", VA = "0x180852890", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x851AA0", VA = "0x1808528A0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x852870", Offset = "0x851A70", VA = "0x180852870", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x920210", Offset = "0x91F410", VA = "0x180920210", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash BGMAOMLOOIC);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8BE920", Offset = "0x8BDB20", VA = "0x1808BE920")]
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
	[SerializeField]
	[ReadOnlyField]
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
		[Cpp2IlInjected.Address(RVA = "0x68C6E60", Offset = "0x68C6060", VA = "0x1868C6E60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x68C6E20", Offset = "0x68C6020", VA = "0x1868C6E20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x68C6EA0", Offset = "0x68C60A0", VA = "0x1868C6EA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x68C7050", Offset = "0x68C6250", VA = "0x1868C7050")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x68C6FC0", Offset = "0x68C61C0", VA = "0x1868C6FC0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8BE910", Offset = "0x8BDB10", VA = "0x1808BE910")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8BE8D0", Offset = "0x8BDAD0", VA = "0x1808BE8D0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x68C6DE0", Offset = "0x68C5FE0", VA = "0x1868C6DE0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x68C6F30", Offset = "0x68C6130", VA = "0x1868C6F30")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x68C6850", Offset = "0x68C5A50", VA = "0x1868C6850")]
	public void CopyBounds(SavedExtents OKGBBGMIACH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x68C6D30", Offset = "0x68C5F30", VA = "0x1868C6D30")]
	public void SetLocalSpaceBounds(Bounds IFKDOLFNMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xBB21B0", Offset = "0xBB13B0", VA = "0x180BB21B0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x68C6D20", Offset = "0x68C5F20", VA = "0x1868C6D20")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x68C6880", Offset = "0x68C5A80", VA = "0x1868C6880")]
	private void ECNBNJLLBEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x68C6B00", Offset = "0x68C5D00", VA = "0x1868C6B00")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x68C61E0", Offset = "0x68C53E0", VA = "0x1868C61E0")]
	public static void CalculateLocalBoundsFor(GameObject NBDLDMDNCAL, [Out] Bounds IFKDOLFNMJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x68C6A40", Offset = "0x68C5C40", VA = "0x1868C6A40")]
	private static void IEHMKCEKBOJ(Bounds GANEOONFJPD, Color DDJHOHBDMLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x68C6D50", Offset = "0x68C5F50", VA = "0x1868C6D50")]
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
		[Cpp2IlInjected.Address(RVA = "0x8521A0", Offset = "0x8513A0", VA = "0x1808521A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x852910", Offset = "0x851B10", VA = "0x180852910")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xFD3780", Offset = "0xFD2980", VA = "0x180FD3780")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x496D8B0", Offset = "0x496CAB0", VA = "0x18496D8B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "4")]
	public virtual void IBAMJKALAJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
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
	[OGEGJKMLCNM]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x496D430", Offset = "0x496C630", VA = "0x18496D430", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x496BC40", Offset = "0x496AE40", VA = "0x18496BC40", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x496D7B0", Offset = "0x496C9B0", VA = "0x18496D7B0")]
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
	private sealed class PLJLHLCOBLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public PLJLHLCOBLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x47876F0", Offset = "0x47868F0", VA = "0x1847876F0")]
		internal int GBKFKGKKNGO(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[OGEGJKMLCNM]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x38224E0", Offset = "0x38216E0", VA = "0x1838224E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3822540", Offset = "0x3821740", VA = "0x183822540", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x38223C0", Offset = "0x38215C0", VA = "0x1838223C0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey NDDCLPHCEEO]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3822480", Offset = "0x3821680", VA = "0x183822480", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3822270", Offset = "0x3821470", VA = "0x183822270", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3821F30", Offset = "0x3821130", VA = "0x183821F30", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3821350", Offset = "0x3820550", VA = "0x183821350", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3821320", Offset = "0x3820520", VA = "0x183821320", Slot = "14")]
	protected virtual string IMEGMNFCIOH(TKeyVal HDDCDBLOLDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x38211C0", Offset = "0x38203C0", VA = "0x1838211C0", Slot = "4")]
	public bool ContainsKey(TKey NDDCLPHCEEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x38220F0", Offset = "0x38212F0", VA = "0x1838220F0", Slot = "5")]
	public bool TryGetValue(TKey NDDCLPHCEEO, [Out] TVal JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3821220", Offset = "0x3820420", VA = "0x183821220", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3821220", Offset = "0x3820420", VA = "0x183821220", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3822150", Offset = "0x3821350", VA = "0x183822150")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class NHJHDBAJGNN<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class GMBLGKIIJEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public float IOIJNMIIHIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public T JNHPIMBJPMJ;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public GMBLGKIIJEI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class IBHPFKJNGPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public IBHPFKJNGPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3E2F250", Offset = "0x3E2E450", VA = "0x183E2F250")]
		internal bool NPHOCHGOIIC(GMBLGKIIJEI sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly float HCKDDPKCGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly float KJMCBPIHFFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<GMBLGKIIJEI> LFOOMPFBGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private CAJPHPCFPPJ<GMBLGKIIJEI> JIIKGPMGFHC;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int GJGOIKGCHNA
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4521B90", Offset = "0x4520D90", VA = "0x184521B90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4521C00", Offset = "0x4520E00", VA = "0x184521C00")]
	public NHJHDBAJGNN(float KJHHCJADBDH, float DHJINKLHOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4520E60", Offset = "0x4520060", VA = "0x184520E60")]
	public bool HMBECCONFBC(float HDCBOMJHFCH, T JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4521610", Offset = "0x4520810", VA = "0x184521610")]
	public IEnumerable<T> IOMCBEOMABD(float HDCBOMJHFCH, [Optional] float? IALGELGJOKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x45211F0", Offset = "0x45203F0", VA = "0x1845211F0")]
	public void IMJJLGNDCEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4521980", Offset = "0x4520B80", VA = "0x184521980")]
	private void JPNMHHBOHFG(float HDCBOMJHFCH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class OKINFAONJHL<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct PPDEGLHINBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public T JNHPIMBJPMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public float MOEHEJACJEH;
	}

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static float MPGMGLKLEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private List<T> MHBAABDANFO;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private const int PJPGAPLLDJA = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private PPDEGLHINBJ[] PFKJAOOHGBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int FGHIONIHMHA;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float LCLMKPJCKGN
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9A4990", Offset = "0x9A3B90", VA = "0x1809A4990")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9AD3E0", Offset = "0x9AC5E0", VA = "0x1809AD3E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4677330", Offset = "0x4676530", VA = "0x184677330")]
	public OKINFAONJHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4677370", Offset = "0x4676570", VA = "0x184677370")]
	public OKINFAONJHL(int ECGAAJFODGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x46770D0", Offset = "0x46762D0", VA = "0x1846770D0")]
	public void PBLNBBGFGAP(float HDCBOMJHFCH, T JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4676F90", Offset = "0x4676190", VA = "0x184676F90")]
	public void IMJJLGNDCEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4676910", Offset = "0x4675B10", VA = "0x184676910")]
	public bool BCABLAINCKG(float NCEEMEKPLHO, float GEHGKBEMJPC, [Out] T JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4676270", Offset = "0x4675470", VA = "0x184676270")]
	public bool ADNNIEHGPNG(float NCEEMEKPLHO, float GEHGKBEMJPC, [Out] T JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4676B60", Offset = "0x4675D60", VA = "0x184676B60")]
	public void DMHNGCDMEIP(float NCEEMEKPLHO, float GEHGKBEMJPC, List<T> PHMDIHEJOGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4676E70", Offset = "0x4676070", VA = "0x184676E70")]
	private int ECAMDGGGKKL(int FJGMLNHLPBF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x4677080", Offset = "0x4676280", VA = "0x184677080")]
	private void OKIBDCKHELL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T LIADPNCJBOP();

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T KCBPOPNLEFI(T JMDCGOKJIDA, float DOGPFNGIKMO);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T GCKOMEIBJIG(T DIAAOCPNHKC, T LLLBDLGIMPP);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T JEGNKKKIMIH(T DIAAOCPNHKC, T LLLBDLGIMPP);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class AILGIAAEDNM : OKINFAONJHL<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x862EA0", Offset = "0x8620A0", VA = "0x180862EA0", Slot = "4")]
	protected override Vector3 LIADPNCJBOP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x68C1E10", Offset = "0x68C1010", VA = "0x1868C1E10", Slot = "5")]
	protected override Vector3 KCBPOPNLEFI(Vector3 JMDCGOKJIDA, float DOGPFNGIKMO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x68C1D40", Offset = "0x68C0F40", VA = "0x1868C1D40", Slot = "6")]
	protected override Vector3 GCKOMEIBJIG(Vector3 DIAAOCPNHKC, Vector3 LLLBDLGIMPP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x68C1D90", Offset = "0x68C0F90", VA = "0x1868C1D90", Slot = "7")]
	protected override Vector3 JEGNKKKIMIH(Vector3 DIAAOCPNHKC, Vector3 LLLBDLGIMPP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x68C1E50", Offset = "0x68C1050", VA = "0x1868C1E50")]
	public AILGIAAEDNM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class FLHLDIOPFJL
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2B25700", Offset = "0x2B24900", VA = "0x182B25700")]
	public static KKNLDOICDLK<T1, T2> JGIIBNEOBDO<T1, T2>(T1 BCCJLCECHOM, T2 HEMMFIBMKDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2B25790", Offset = "0x2B24990", VA = "0x182B25790")]
	public static PLNCJGBCMBC<T1, T2, T3> JGIIBNEOBDO<T1, T2, T3>(T1 BCCJLCECHOM, T2 HEMMFIBMKDK, T3 EFGMBOCFEML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x44F7140", Offset = "0x44F6340", VA = "0x1844F7140")]
	internal static int EPAFINGNDJL(int HEOPLAHHFAB, int GJOFFMCMAIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5C70A10", Offset = "0x5C6FC10", VA = "0x185C70A10")]
	internal static int EPAFINGNDJL(int HEOPLAHHFAB, int GJOFFMCMAIA, int OAKJCPFALKN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KKNLDOICDLK<T1, T2> : IComparable<KKNLDOICDLK<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly T1 MMILKMINAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly T2 NDNGJEJEBEB;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x419B630", Offset = "0x419A830", VA = "0x18419B630")]
	public KKNLDOICDLK(T1 BCCJLCECHOM, T2 HEMMFIBMKDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x419B1E0", Offset = "0x419A3E0", VA = "0x18419B1E0", Slot = "4")]
	public int CompareTo(KKNLDOICDLK<T1, T2> OKGBBGMIACH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x419B2E0", Offset = "0x419A4E0", VA = "0x18419B2E0", Slot = "0")]
	public override bool Equals(object OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x419B480", Offset = "0x419A680", VA = "0x18419B480", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x419B4D0", Offset = "0x419A6D0", VA = "0x18419B4D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class PLNCJGBCMBC<T1, T2, T3> : IComparable<PLNCJGBCMBC<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly T1 MMILKMINAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly T2 NDNGJEJEBEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly T3 GBLLJADMCBN;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x47881D0", Offset = "0x47873D0", VA = "0x1847881D0")]
	public PLNCJGBCMBC(T1 BCCJLCECHOM, T2 HEMMFIBMKDK, T3 EFGMBOCFEML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4787A00", Offset = "0x4786C00", VA = "0x184787A00", Slot = "4")]
	public int CompareTo(PLNCJGBCMBC<T1, T2, T3> OKGBBGMIACH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4787B50", Offset = "0x4786D50", VA = "0x184787B50", Slot = "0")]
	public override bool Equals(object OKGBBGMIACH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4787E70", Offset = "0x4787070", VA = "0x184787E70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4787F10", Offset = "0x4787110", VA = "0x184787F10", Slot = "3")]
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
	public T JNHPIMBJPMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x2307C30", Offset = "0x2306E30", VA = "0x182307C30")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x2307CF0", Offset = "0x2306EF0", VA = "0x182307CF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float MLAFKOALCDL
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8BE870", Offset = "0x8BDA70", VA = "0x1808BE870")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4BCD5F0", Offset = "0x4BCC7F0", VA = "0x184BCD5F0")]
	public T FNEDDDIBHBA(float DOGPFNGIKMO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4BCD720", Offset = "0x4BCC920", VA = "0x184BCD720")]
	public T LIEECAELOJE(float DOGPFNGIKMO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T DADNJNHMGGO(T DIAAOCPNHKC, T LLLBDLGIMPP, float DOGPFNGIKMO);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x68C33F0", Offset = "0x68C25F0", VA = "0x1868C33F0", Slot = "4")]
	protected override float DADNJNHMGGO(float DIAAOCPNHKC, float LLLBDLGIMPP, float DOGPFNGIKMO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x68C3430", Offset = "0x68C2630", VA = "0x1868C3430")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xE70870", Offset = "0xE6FA70", VA = "0x180E70870", Slot = "4")]
	protected override Vector3 DADNJNHMGGO(Vector3 DIAAOCPNHKC, Vector3 LLLBDLGIMPP, float DOGPFNGIKMO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x68C7E60", Offset = "0x68C7060", VA = "0x1868C7E60")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x68C2210", Offset = "0x68C1410", VA = "0x1868C2210", Slot = "4")]
	protected override Color DADNJNHMGGO(Color DIAAOCPNHKC, Color LLLBDLGIMPP, float DOGPFNGIKMO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x68C22D0", Offset = "0x68C14D0", VA = "0x1868C22D0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class JNMGJLGBACE : DLCLPGKFPDM<string>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x68C4830", Offset = "0x68C3A30", VA = "0x1868C4830")]
	public JNMGJLGBACE(int HHGNDILCLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x68C47C0", Offset = "0x68C39C0", VA = "0x1868C47C0", Slot = "6")]
	protected override uint MNAKOEMGGBL(uint BGMAOMLOOIC, string JMDCGOKJIDA)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class BMKFGIADLGO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly IDisposable MJFJCBEEADM;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
	public BMKFGIADLGO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct CAAPJJNLHNO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> IMABLLPDOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int PEIHIHFNBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int LNJGPIPEBPK;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3C1A580", Offset = "0x3C19780", VA = "0x183C1A580")]
	private CAAPJJNLHNO(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> AICLDAIHHEE, int DLDADAOHCHO, int BPFNHEMHBMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x500C450", Offset = "0x500B650", VA = "0x18500C450")]
	public static CAAPJJNLHNO<T> FJAAFKPDAIA()
	{
		return default(CAAPJJNLHNO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x500D370", Offset = "0x500C570", VA = "0x18500D370")]
	public (int, int, Task<T>) JPFOMCJKBNN(int IEJKLFLAGBB, [Optional] CancellationToken MPLGBOFHPLM, double IOCCJIJEELD = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x500E510", Offset = "0x500D710", VA = "0x18500E510")]
	public void KIJDNFKPHIA(int IEJKLFLAGBB, int BPFNHEMHBMJ, [In] T ADPMAHMCGNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class CIFEGFPFPGG
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x68C1F30", Offset = "0x68C1130", VA = "0x1868C1F30")]
	public static CAAPJJNLHNO<MOOMEEOMEEK> FJAAFKPDAIA()
	{
		return default(CAAPJJNLHNO<MOOMEEOMEEK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x68C1F80", Offset = "0x68C1180", VA = "0x1868C1F80")]
	public static void KIJDNFKPHIA([In] this CAAPJJNLHNO<MOOMEEOMEEK> HIKEOGPAJAF, int IEJKLFLAGBB, int BPFNHEMHBMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class NOGDILHKBGL<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<TKey, TVal> MDEEENOGJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly Dictionary<TVal, TKey> AMBOIAGLBDA;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3592420", Offset = "0x3591620", VA = "0x183592420", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool HNPAFAKBDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x89B030", Offset = "0x89A230", VA = "0x18089B030", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ICollection<TKey> FBJILCMLFAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3D1AE80", Offset = "0x3D1A080", VA = "0x183D1AE80", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> PGIKKFOHHOG
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x4548EB0", Offset = "0x45480B0", VA = "0x184548EB0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x454F440", Offset = "0x454E640", VA = "0x18454F440", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x454F4A0", Offset = "0x454E6A0", VA = "0x18454F4A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x454F0F0", Offset = "0x454E2F0", VA = "0x18454F0F0")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x454EA60", Offset = "0x454DC60", VA = "0x18454EA60", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x454F270", Offset = "0x454E470", VA = "0x18454F270", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x454E850", Offset = "0x454DA50", VA = "0x18454E850", Slot = "9")]
	public void Add(TKey NDDCLPHCEEO, TVal JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x454E800", Offset = "0x454DA00", VA = "0x18454E800", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> JNHGHHKKNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x37F00C0", Offset = "0x37EF2C0", VA = "0x1837F00C0", Slot = "8")]
	public bool ContainsKey(TKey NDDCLPHCEEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x454EB40", Offset = "0x454DD40", VA = "0x18454EB40", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> JNHGHHKKNBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x454F160", Offset = "0x454E360", VA = "0x18454F160", Slot = "10")]
	public bool Remove(TKey NDDCLPHCEEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x454F1E0", Offset = "0x454E3E0", VA = "0x18454F1E0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> JNHGHHKKNBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x454F2C0", Offset = "0x454E4C0", VA = "0x18454F2C0", Slot = "11")]
	public bool TryGetValue(TKey NDDCLPHCEEO, [Out] TVal JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x454EFF0", Offset = "0x454E1F0", VA = "0x18454EFF0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x454EB80", Offset = "0x454DD80", VA = "0x18454EB80", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] PFKJAOOHGBN, int OMHDEOJLLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x454E6C0", Offset = "0x454D8C0", VA = "0x18454E6C0")]
	public bool AKPHPFIGELN(TVal NDDCLPHCEEO, [Out] TKey JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x454E8A0", Offset = "0x454DAA0", VA = "0x18454E8A0")]
	private void CJHLJHDOGME(TKey NDDCLPHCEEO, TVal GPBAFILNEOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x454ECD0", Offset = "0x454DED0", VA = "0x18454ECD0")]
	private void DMBPGBGBDFN(TKey NDDCLPHCEEO, TVal GPBAFILNEOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x454EDC0", Offset = "0x454DFC0", VA = "0x18454EDC0")]
	private bool FIHONAPKJEP(TKey NDDCLPHCEEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x454F320", Offset = "0x454E520", VA = "0x18454F320")]
	public NOGDILHKBGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[DefaultMember("Item")]
public class HIGMIECILNG<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private HIGMIECILNG<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x386DEF0", Offset = "0x386D0F0", VA = "0x18386DEF0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x387CC70", Offset = "0x387BE70", VA = "0x18387CC70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x387E240", Offset = "0x387D440", VA = "0x18387E240")]
		public Enumerator(HIGMIECILNG<T> PHMDIHEJOGG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x387B450", Offset = "0x387A650", VA = "0x18387B450", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x387C060", Offset = "0x387B260", VA = "0x18387C060", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x387A730", Offset = "0x3879930", VA = "0x18387A730")]
		private void LKFPEHKNIBA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private T[] GOKDLEPEPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private int JHEGPJBDKAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int MLNHFJAKLHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int DMDAEILPBHA;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3D2FA50", Offset = "0x3D2EC50", VA = "0x183D2FA50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3D309A0", Offset = "0x3D2FBA0", VA = "0x183D309A0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x3D2EFD0", Offset = "0x3D2E1D0", VA = "0x183D2EFD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3D30EF0", Offset = "0x3D300F0", VA = "0x183D30EF0")]
	public HIGMIECILNG(int HHGNDILCLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3D2FE70", Offset = "0x3D2F070", VA = "0x183D2FE70")]
	public void PBLNBBGFGAP(T DOGPFNGIKMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3D2FA00", Offset = "0x3D2EC00", VA = "0x183D2FA00")]
	public void IMJJLGNDCEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3D2EDF0", Offset = "0x3D2DFF0", VA = "0x183D2EDF0")]
	public void CFDMGAKBOCA(int IHGHLPOONHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3D307A0", Offset = "0x3D2F9A0", VA = "0x183D307A0")]
	public void PGKLAMLJNDJ(T[] PFKJAOOHGBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3D2EEC0", Offset = "0x3D2E0C0", VA = "0x183D2EEC0")]
	public Enumerator DCPEOMEKOMK()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3D30C10", Offset = "0x3D2FE10", VA = "0x183D30C10", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3D30C10", Offset = "0x3D2FE10", VA = "0x183D30C10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3D2F460", Offset = "0x3D2E660", VA = "0x183D2F460")]
	private int GCBALGANIKP(int DHNLEFJCEAH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3D2FA20", Offset = "0x3D2EC20", VA = "0x183D2FA20")]
	private int MFMMGBJNFFA(int DHNLEFJCEAH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class LLNBPHOHMNO<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate Task<TResult> AKDEOCDHLMJ(TRequest GPCNCGBOPJG, CancellationToken MPLGBOFHPLM);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public enum OEDKJEMJDGI
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class EBKBHGJMDMP
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private const float IKEDAOAHOHD = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TimeSpan IAIKPKJLIMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int DIJGBCNBBGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public OEDKJEMJDGI EOMEDHLEFLE;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static readonly EBKBHGJMDMP ELIKMDBCIKF;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float BPMKKGOMHCN
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x37E6610", Offset = "0x37E5810", VA = "0x1837E6610")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public TimeSpan GPPHPNDKNGE
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x852300", VA = "0x180853100")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x37E67D0", Offset = "0x37E59D0", VA = "0x1837E67D0")]
		public EBKBHGJMDMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private readonly struct PFKJFMEHMOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly TRequest GPCNCGBOPJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly CancellationToken MPLGBOFHPLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly TaskCompletionSource<TResult> KLCFJBFNJKE;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4777620", Offset = "0x4776820", VA = "0x184777620")]
		public PFKJFMEHMOJ(TRequest GPCNCGBOPJG, TaskCompletionSource<TResult> KLCFJBFNJKE, CancellationToken MPLGBOFHPLM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct AANEIBFALJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public LLNBPHOHMNO<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3C645B0", Offset = "0x3C637B0", VA = "0x183C645B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x3C64A10", Offset = "0x3C63C10", VA = "0x183C64A10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct MLNAIEAFIFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public LLNBPHOHMNO<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private PFKJFMEHMOJ <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x44BDCA0", Offset = "0x44BCEA0", VA = "0x1844BDCA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x44BE920", Offset = "0x44BDB20", VA = "0x1844BE920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly CancellationTokenSource CIHCAICIHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly List<PFKJFMEHMOJ> LKJHDMOCNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly EBKBHGJMDMP EPIPNOBBMOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly AKDEOCDHLMJ GCFLFLFKPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Task IOBENEJNNKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private int FDMFJIHCLBE;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x42A2FF0", Offset = "0x42A21F0", VA = "0x1842A2FF0")]
	public LLNBPHOHMNO(AKDEOCDHLMJ GCFLFLFKPOA, [Optional] EBKBHGJMDMP EPIPNOBBMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x42A1680", Offset = "0x42A0880", VA = "0x1842A1680")]
	public Task<TResult> DKHIGLLOPPE(TRequest GPCNCGBOPJG, CancellationToken MPLGBOFHPLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x42A1420", Offset = "0x42A0620", VA = "0x1842A1420")]
	private void BLEEADHCKKC(PFKJFMEHMOJ FOIKNMKKKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x42A1E60", Offset = "0x42A1060", VA = "0x1842A1E60")]
	[AsyncStateMachine(typeof(LLNBPHOHMNO<, >.AANEIBFALJN))]
	private Task LICNHNOGJKF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x42A2890", Offset = "0x42A1A90", VA = "0x1842A2890")]
	private PFKJFMEHMOJ NIHOKLMGKOO()
	{
		return default(PFKJFMEHMOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x42A2100", Offset = "0x42A1300", VA = "0x1842A2100")]
	[AsyncStateMachine(typeof(LLNBPHOHMNO<, >.MLNAIEAFIFE))]
	private Task NBGALBJACNO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x42A2C60", Offset = "0x42A1E60", VA = "0x1842A2C60")]
	private void OLPBGAGFGEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x42A1D50", Offset = "0x42A0F50", VA = "0x1842A1D50", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class PEGNAEEHKKL<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly List<T> CGIFJALMJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private HashSet<T> KEAGOEBAADJ;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3592420", Offset = "0x3591620", VA = "0x183592420", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool HNPAFAKBDHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x89B030", Offset = "0x89A230", VA = "0x18089B030", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public T NBEMKGGOBKM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2757B80", Offset = "0x2756D80", VA = "0x182757B80", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x47757F0", Offset = "0x47749F0", VA = "0x1847757F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3C28DA0", Offset = "0x3C27FA0", VA = "0x183C28DA0", Slot = "11")]
	public void Add(T JNHGHHKKNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4774E20", Offset = "0x4774020", VA = "0x184774E20")]
	public bool AGNJLLJNDOJ(T JNHGHHKKNBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4775610", Offset = "0x4774810", VA = "0x184775610", Slot = "15")]
	public bool Remove(T JNHGHHKKNBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3BEC350", Offset = "0x3BEB550", VA = "0x183BEC350", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3BFCBC0", Offset = "0x3BFBDC0", VA = "0x183BFCBC0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4774F10", Offset = "0x4774110", VA = "0x184774F10", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4774FB0", Offset = "0x47741B0", VA = "0x184774FB0", Slot = "13")]
	public bool Contains(T JNHGHHKKNBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4775000", Offset = "0x4774200", VA = "0x184775000", Slot = "14")]
	public void CopyTo(T[] PFKJAOOHGBN, int OMHDEOJLLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x4214B40", Offset = "0x4213D40", VA = "0x184214B40", Slot = "6")]
	public int IndexOf(T JNHGHHKKNBB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x4775190", Offset = "0x4774390", VA = "0x184775190", Slot = "7")]
	public void Insert(int DHNLEFJCEAH, T JNHGHHKKNBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4775410", Offset = "0x4774610", VA = "0x184775410", Slot = "8")]
	public void RemoveAt(int DHNLEFJCEAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x47756D0", Offset = "0x47748D0", VA = "0x1847756D0")]
	public PEGNAEEHKKL()
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
			[Cpp2IlInjected.Address(RVA = "0x21B3170", Offset = "0x21B2370", VA = "0x1821B3170")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x68C73F0", Offset = "0x68C65F0", VA = "0x1868C73F0")]
		public SerializedGuid([In] Guid BMIGIGGJPJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x68C72C0", Offset = "0x68C64C0", VA = "0x1868C72C0")]
		public static SerializedGuid LGEFIKAIAMK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x68C7250", Offset = "0x68C6450", VA = "0x1868C7250")]
		public static SerializedGuid IDICMGFIBGL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x68C70E0", Offset = "0x68C62E0", VA = "0x1868C70E0")]
		public bool CFHDDGLKNCC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x68C73C0", Offset = "0x68C65C0", VA = "0x1868C73C0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x68C7340", Offset = "0x68C6540", VA = "0x1868C7340", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x68C7170", Offset = "0x68C6370", VA = "0x1868C7170", Slot = "7")]
		public bool Equals(SerializedGuid OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x68C71B0", Offset = "0x68C63B0", VA = "0x1868C71B0", Slot = "0")]
		public override bool Equals(object MEAFIMADMKA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x68C7240", Offset = "0x68C6440", VA = "0x1868C7240", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x68C7140", Offset = "0x68C6340", VA = "0x1868C7140", Slot = "6")]
		public int CompareTo(SerializedGuid OKGBBGMIACH)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class ONFMOOOPGFJ : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly Type PNKOJBNOJNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly string PEDAFBNCNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool HFDNAEDKMCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool GDBLJJMDBNI;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x68C5AE0", Offset = "0x68C4CE0", VA = "0x1868C5AE0")]
	public ONFMOOOPGFJ(Type CGDDLPBGNNM, string FBDJFLEOFMI, bool PPHGECCENLH = false, bool GHAEIGGIDIG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class OADONCMLPJG<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public readonly struct CENCABLHMDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly long KLAGOPJFMBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly long HHKEGHFGPEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly int JHAPJJJNDPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly int BPNEAIMIODL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly bool DPKGDAPDGHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly string AHDKPNBDPPD;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5108B40", Offset = "0x5107D40", VA = "0x185108B40")]
		public CENCABLHMDP(long KLAGOPJFMBH, int JHAPJJJNDPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5108B10", Offset = "0x5107D10", VA = "0x185108B10")]
		public CENCABLHMDP(long KLAGOPJFMBH, long HHKEGHFGPEN, int JHAPJJJNDPF, int BPNEAIMIODL, bool DPKGDAPDGHN, string AHDKPNBDPPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x51089A0", Offset = "0x5107BA0", VA = "0x1851089A0")]
		public int KDMIGDIIPBB()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x5108A90", Offset = "0x5107C90", VA = "0x185108A90")]
		public int MBLLJLINFID(int FFLLANCAOFF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5108AB0", Offset = "0x5107CB0", VA = "0x185108AB0")]
		public double PNBHBLKJGEA()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x51089F0", Offset = "0x5107BF0", VA = "0x1851089F0")]
		public CENCABLHMDP LCENFNDIJHE(long HHKEGHFGPEN, int BPNEAIMIODL)
		{
			return default(CENCABLHMDP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class HILOONJJDHL : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private struct PNBCGELHKKN<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public HILOONJJDHL <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Func<HILOONJJDHL, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private HILOONJJDHL <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x478A4F0", Offset = "0x47896F0", VA = "0x18478A4F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x381B610", Offset = "0x381A810", VA = "0x18381B610", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly TKey HJDGBLHMFIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly OADONCMLPJG<TKey> GFNLGFOFJFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public readonly CDLNJDLNIPA KBNCOADBJAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private List<HILOONJJDHL> FCJJODHBCHH;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public string AOHCGGKNAML
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x3B81AF0", Offset = "0x3B80CF0", VA = "0x183B81AF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public IEnumerable<HILOONJJDHL> PEPBBOEMMMB
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x3D311F0", Offset = "0x3D303F0", VA = "0x183D311F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public CENCABLHMDP MEJDIPHAJMD
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x3D313E0", Offset = "0x3D305E0", VA = "0x183D313E0")]
			[CompilerGenerated]
			get
			{
				return default(CENCABLHMDP);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x3D30F80", Offset = "0x3D30180", VA = "0x183D30F80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x3D31400", Offset = "0x3D30600", VA = "0x183D31400")]
		internal HILOONJJDHL(OADONCMLPJG<TKey> GFNLGFOFJFM, TKey NDDCLPHCEEO, CDLNJDLNIPA KBNCOADBJAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3D31230", Offset = "0x3D30430", VA = "0x183D31230")]
		public HILOONJJDHL FINICLOHGIA(TKey NDDCLPHCEEO, [Optional] CDLNJDLNIPA? BALLFEMFJJO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x29E0CF0", Offset = "0x29DFEF0", VA = "0x1829E0CF0")]
		[AsyncStateMachine(typeof(PNBCGELHKKN<>))]
		public Task<T> DOCLEABBBAL<T>(TKey NDDCLPHCEEO, Func<HILOONJJDHL, Task<T>> GPJOKKOGGOF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3D30FB0", Offset = "0x3D301B0", VA = "0x183D30FB0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class HPMAGKANJKC : IEnumerable<(TKey, List<TKey>, CENCABLHMDP)>, IEnumerable, IEnumerator<(TKey, List<TKey>, CENCABLHMDP)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private (TKey key, List<TKey> path, CENCABLHMDP timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public OADONCMLPJG<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IEnumerator<(TKey key, List<TKey> path, CENCABLHMDP timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private (TKey, List<TKey>, CENCABLHMDP) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x21B3BC0", Offset = "0x21B2DC0", VA = "0x1821B3BC0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, CENCABLHMDP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x3D69280", Offset = "0x3D68480", VA = "0x183D69280", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x21B3CB0", Offset = "0x21B2EB0", VA = "0x1821B3CB0")]
		[DebuggerHidden]
		public HPMAGKANJKC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x398CD50", Offset = "0x398BF50", VA = "0x18398CD50", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3D68DC0", Offset = "0x3D67FC0", VA = "0x183D68DC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3D68D70", Offset = "0x3D67F70", VA = "0x183D68D70")]
		private void CEOBCCLIKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x3D69230", Offset = "0x3D68430", VA = "0x183D69230", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3D69160", Offset = "0x3D68360", VA = "0x183D69160", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, CENCABLHMDP)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3AE70C0", Offset = "0x3AE62C0", VA = "0x183AE70C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class NNLEBBADFID : IEnumerable<(TKey, List<TKey>, CENCABLHMDP)>, IEnumerable, IEnumerator<(TKey, List<TKey>, CENCABLHMDP)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private (TKey key, List<TKey> path, CENCABLHMDP timerEntry) <>2__current;

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
		private HILOONJJDHL timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public HILOONJJDHL <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public OADONCMLPJG<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private IEnumerator<HILOONJJDHL> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private IEnumerator<(TKey key, List<TKey> path, CENCABLHMDP timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, CENCABLHMDP) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x21B3BC0", Offset = "0x21B2DC0", VA = "0x1821B3BC0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, CENCABLHMDP));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x45485F0", Offset = "0x45477F0", VA = "0x1845485F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x21B3CB0", Offset = "0x21B2EB0", VA = "0x1821B3CB0")]
		[DebuggerHidden]
		public NNLEBBADFID(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4548650", Offset = "0x4547850", VA = "0x184548650", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4547C90", Offset = "0x4546E90", VA = "0x184547C90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4547BD0", Offset = "0x4546DD0", VA = "0x184547BD0")]
		private void CEOBCCLIKJA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4547C30", Offset = "0x4546E30", VA = "0x184547C30")]
		private void KNPOGHPBEEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x45485A0", Offset = "0x45477A0", VA = "0x1845485A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x4548460", Offset = "0x4547660", VA = "0x184548460", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, CENCABLHMDP)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x4548560", Offset = "0x4547760", VA = "0x184548560", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly Action<TKey, CENCABLHMDP, CDLNJDLNIPA> CDDNBOKDIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Action<TKey, CENCABLHMDP, CDLNJDLNIPA> DDIKNNBKHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly Action<OADONCMLPJG<TKey>, CDLNJDLNIPA> EBNPBMEGAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly CDLNJDLNIPA KBNCOADBJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly HILOONJJDHL AMFJIPJPHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private bool MAFFMBBADNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int EHLLNMHLGGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly Stopwatch FPCPJEPFGDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly int MAJPDHANBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string HAFKKLEAJLM;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public HILOONJJDHL FDKCIFMCANG
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x855DC0", VA = "0x180856BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	[NotNull]
	public string AOHCGGKNAML
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x856300", Offset = "0x855500", VA = "0x180856300")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x46180D0", Offset = "0x46172D0", VA = "0x1846180D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4618130", Offset = "0x4617330", VA = "0x184618130")]
	public OADONCMLPJG(TKey PGNFCILIBKB, CDLNJDLNIPA KBNCOADBJAI, [Optional] int? JHAPJJJNDPF, [Optional][CanBeNull] Stopwatch FPCPJEPFGDL, [Optional] Action<TKey, CENCABLHMDP, CDLNJDLNIPA> CDDNBOKDIMA, [Optional] Action<TKey, CENCABLHMDP, CDLNJDLNIPA> DDIKNNBKHHD, [Optional] Action<OADONCMLPJG<TKey>, CDLNJDLNIPA> EBNPBMEGAIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4618000", Offset = "0x4617200", VA = "0x184618000", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4617F60", Offset = "0x4617160", VA = "0x184617F60")]
	[IteratorStateMachine(typeof(OADONCMLPJG<>.HPMAGKANJKC))]
	public IEnumerable<(TKey, List<TKey>, CENCABLHMDP)> DJMKPDMAODN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4617E80", Offset = "0x4617080", VA = "0x184617E80")]
	[IteratorStateMachine(typeof(OADONCMLPJG<>.NNLEBBADFID))]
	private IEnumerable<(TKey, List<TKey>, CENCABLHMDP)> DJMKPDMAODN(List<TKey> BECGFNBELMK, HILOONJJDHL DOAFLGODEDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4617E00", Offset = "0x4617000", VA = "0x184617E00")]
	private (long, int) CDBPGJJNNAF()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public abstract class CPKOJAAICCF<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut BMENGJPMPIB(OADONCMLPJG<TKey> GFNLGFOFJFM);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
	protected CPKOJAAICCF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public abstract class PJPNOLNCOGB<TKey> : CPKOJAAICCF<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate string AEMENILFDFE(TKey NDDCLPHCEEO);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x4783060", Offset = "0x4782260", VA = "0x184783060")]
	private static string DJJIKBBNAGO(TKey NDDCLPHCEEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x4782F80", Offset = "0x4782180", VA = "0x184782F80", Slot = "4")]
	public override string BMENGJPMPIB(OADONCMLPJG<TKey> GFNLGFOFJFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x4782E30", Offset = "0x4782030", VA = "0x184782E30")]
	public string BMENGJPMPIB(OADONCMLPJG<TKey> GFNLGFOFJFM, [NotNull] AEMENILFDFE NBKHPILOMOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string BLLHFJPBMOE(OADONCMLPJG<TKey> GFNLGFOFJFM, [NotNull] AEMENILFDFE NBKHPILOMOL);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3CD4910", Offset = "0x3CD3B10", VA = "0x183CD4910")]
	protected PJPNOLNCOGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class LDBDKGIKPEF<TKey> : CPKOJAAICCF<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public delegate string KGBLOFDDKLH(TKey NDDCLPHCEEO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly string BOONLBHLOGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly double GMGPNLBKAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly bool PFAENIKAPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly int BMMMIGBMDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly ISet<string> GOBFALADJGM;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x4241190", Offset = "0x4240390", VA = "0x184241190")]
	private static string DJJIKBBNAGO(TKey NDDCLPHCEEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x4241440", Offset = "0x4240640", VA = "0x184241440")]
	public LDBDKGIKPEF(string BOONLBHLOGE = "F2", double GMGPNLBKAOC = double.MaxValue, bool PFAENIKAPLP = false, int BMMMIGBMDLJ = int.MaxValue, [Optional] ISet<string> GOBFALADJGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x4240FD0", Offset = "0x42401D0", VA = "0x184240FD0", Slot = "4")]
	public override Dictionary<string, string> BMENGJPMPIB(OADONCMLPJG<TKey> GFNLGFOFJFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x42410B0", Offset = "0x42402B0", VA = "0x1842410B0")]
	private bool CMAKGCDIHIB(string FELMDNOFLBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x42409A0", Offset = "0x423FBA0", VA = "0x1842409A0")]
	public Dictionary<string, string> BMENGJPMPIB(OADONCMLPJG<TKey> GFNLGFOFJFM, KGBLOFDDKLH NBKHPILOMOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x42411D0", Offset = "0x42403D0", VA = "0x1842411D0")]
	private string FBLDDIGEKAC(StringBuilder OOBMNIJGKAM, List<TKey> GFLLMHHAMIJ, KGBLOFDDKLH NBKHPILOMOL, bool DCKCCBMBKML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x4240840", Offset = "0x423FA40", VA = "0x184240840")]
	private static void BGBBFIIIAGM(StringBuilder KEOPMHJOBBH, string MECMFGBHOOA, bool JPDDEBGGPGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class FKKEPGGADDP<TKey> : PJPNOLNCOGB<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct DEAPGGLMCPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public AEMENILFDFE keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static FKKEPGGADDP<TKey> MJFJCBEEADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly string[] ABPHODNPGAH;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3C0EA00", Offset = "0x3C0DC00", VA = "0x183C0EA00")]
	private FKKEPGGADDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3C0D970", Offset = "0x3C0CB70", VA = "0x183C0D970", Slot = "5")]
	protected override string BLLHFJPBMOE(OADONCMLPJG<TKey> GFNLGFOFJFM, AEMENILFDFE NBKHPILOMOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3C0E7C0", Offset = "0x3C0D9C0", VA = "0x183C0E7C0")]
	[CompilerGenerated]
	internal static string CFJJJHFDALF(string FKLCPMENCPL, TKey NDDCLPHCEEO, DEAPGGLMCPA P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class COIHLFMDECC : OADONCMLPJG<string>
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class LJLCLGHGGEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Action<COIHLFMDECC, CDLNJDLNIPA> callback;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public LJLCLGHGGEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x68C5530", Offset = "0x68C4730", VA = "0x1868C5530")]
		internal void AOBJLOGCGCC(OADONCMLPJG<string> timer, CDLNJDLNIPA log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x68C20C0", Offset = "0x68C12C0", VA = "0x1868C20C0")]
	public COIHLFMDECC(CDLNJDLNIPA KBNCOADBJAI, [Optional] string NELDGGFCGBO, [Optional] int? JHAPJJJNDPF, [Optional] Stopwatch FPCPJEPFGDL, [Optional] Action<string, CENCABLHMDP, CDLNJDLNIPA> CDDNBOKDIMA, [Optional] Action<string, CENCABLHMDP, CDLNJDLNIPA> DDIKNNBKHHD, [Optional] Action<COIHLFMDECC, CDLNJDLNIPA> EBNPBMEGAIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x68C2000", Offset = "0x68C1200", VA = "0x1868C2000")]
	private static Action<OADONCMLPJG<string>, CDLNJDLNIPA> HACHDNNNLLE(Action<COIHLFMDECC, CDLNJDLNIPA> HBBMMHKOEKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class GEKKFPEPFEA
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private class PNLPKPOJFJL : GEKKFPEPFEA
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public static GEKKFPEPFEA MJFJCBEEADM
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x68C5B50", Offset = "0x68C4D50", VA = "0x1868C5B50")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override float AMJPOMIJLKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x98DC30", Offset = "0x98CE30", VA = "0x18098DC30", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x68C5C50", Offset = "0x68C4E50", VA = "0x1868C5C50")]
		public PNLPKPOJFJL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static GEKKFPEPFEA FIAHPHAFHGL;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static GEKKFPEPFEA ELIKMDBCIKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x68C3470", Offset = "0x68C2670", VA = "0x1868C3470")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public abstract float AMJPOMIJLKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
	protected GEKKFPEPFEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface IABENFAMAOM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool OJBMAONCMFP
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface GBMNPHMLGKB<T> : IABENFAMAOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	[NotNull]
	Task<T> GJLNBAMLKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	[NotNull]
	MAKKFMNHCEA<T> AOBKCEMGLKF
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class CIBINEPEOEH
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x29499D0", Offset = "0x2948BD0", VA = "0x1829499D0")]
	public static GBMNPHMLGKB<TResource> KCLJIOCOKEB<TResource, TId>(this FILEOJEALJN<TId, TResource> MGPCCJLLDAM, TId DKFNFHGODON, [Optional] Func<TId, CancellationToken, Task<TResource>>? FLPMJCBHCGB) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class PDMMMODAIBL
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private sealed class IJINABGMDPL<T> : MDDCCCKDBFD<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override Task<T?> GJLNBAMLKBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override MAKKFMNHCEA<T?> AOBKCEMGLKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x851AA0", VA = "0x1808528A0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x3ED7130", Offset = "0x3ED6330", VA = "0x183ED7130")]
		public IJINABGMDPL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "10")]
		protected override void MDIOCFABDCD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private sealed class OEDAMCGCDGP<T> : MDDCCCKDBFD<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly T OBAIELFNFBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly Action<T>? JNKKLOOAFLE;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override Task<T> GJLNBAMLKBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x856960", Offset = "0x855B60", VA = "0x180856960", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override MAKKFMNHCEA<T> AOBKCEMGLKF
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x856AB0", Offset = "0x855CB0", VA = "0x180856AB0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x4638B00", Offset = "0x4637D00", VA = "0x184638B00")]
		public OEDAMCGCDGP(T GDBEHNBLALJ, Action<T>? BDILBDIGJFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x4638A50", Offset = "0x4637C50", VA = "0x184638A50", Slot = "10")]
		protected override void MDIOCFABDCD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private sealed class HPCMBIPFBDO<T> : MDDCCCKDBFD<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override Task<T> GJLNBAMLKBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override MAKKFMNHCEA<T> AOBKCEMGLKF
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x851AA0", VA = "0x1808528A0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3D673B0", Offset = "0x3D665B0", VA = "0x183D673B0")]
		public HPCMBIPFBDO(Exception HBEPHPNHPNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "10")]
		protected override void MDIOCFABDCD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private sealed class JENNPKJBJKI<T> : MDDCCCKDBFD<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct FIGADIKGLEI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public Task<GBMNPHMLGKB<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private TaskAwaiter<GBMNPHMLGKB<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x3BEFD30", Offset = "0x3BEEF30", VA = "0x183BEFD30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x3BF0230", Offset = "0x3BEF430", VA = "0x183BF0230", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct BKGHLKIEEDI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public Task<GBMNPHMLGKB<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private TaskAwaiter<GBMNPHMLGKB<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x4E44D20", Offset = "0x4E43F20", VA = "0x184E44D20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x4E45180", Offset = "0x4E44380", VA = "0x184E45180", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly Task<GBMNPHMLGKB<T>> ABMDBAFOLDA;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override Task<T> GJLNBAMLKBJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x851AA0", VA = "0x1808528A0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override MAKKFMNHCEA<T> AOBKCEMGLKF
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x856940", Offset = "0x855B40", VA = "0x180856940", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x40A8D40", Offset = "0x40A7F40", VA = "0x1840A8D40")]
		public JENNPKJBJKI(Task<GBMNPHMLGKB<T>> LEDCCMOCHJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x40A8C20", Offset = "0x40A7E20", VA = "0x1840A8C20", Slot = "10")]
		protected override void MDIOCFABDCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x40A8900", Offset = "0x40A7B00", VA = "0x1840A8900")]
		[AsyncStateMachine(typeof(JENNPKJBJKI<>.FIGADIKGLEI))]
		[CompilerGenerated]
		internal static Task<T> CPEBEHODMBN(Task<GBMNPHMLGKB<T>> LEDCCMOCHJB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x40A8A60", Offset = "0x40A7C60", VA = "0x1840A8A60")]
		[AsyncStateMachine(typeof(JENNPKJBJKI<>.BKGHLKIEEDI))]
		[CompilerGenerated]
		internal static Task MCKOPPOLCGM(Task<GBMNPHMLGKB<T>> LEDCCMOCHJB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private sealed class DNPBNLOHHHF<TIn, TOut> : MDDCCCKDBFD<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct LOAPPFFINDE : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x42AA380", Offset = "0x42A9580", VA = "0x1842AA380", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x3C68420", Offset = "0x3C67620", VA = "0x183C68420", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly GBMNPHMLGKB<TIn> GPFBODKIOAJ;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override Task<TOut> GJLNBAMLKBJ
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x851AA0", VA = "0x1808528A0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override MAKKFMNHCEA<TOut> AOBKCEMGLKF
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x856940", Offset = "0x855B40", VA = "0x180856940", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x57953A0", Offset = "0x57945A0", VA = "0x1857953A0")]
		public DNPBNLOHHHF(GBMNPHMLGKB<TIn> BIPHMNOOLAG, Func<TIn, TOut> AMBLFAKGKHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x5795350", Offset = "0x5794550", VA = "0x185795350", Slot = "10")]
		protected override void MDIOCFABDCD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x5795000", Offset = "0x5794200", VA = "0x185795000")]
		[AsyncStateMachine(typeof(DNPBNLOHHHF<, >.LOAPPFFINDE))]
		[CompilerGenerated]
		internal static Task<TOut> HOHFKGAHFIN(Task<TIn> DJMMIEKABGF, Func<TIn, TOut> AMBLFAKGKHE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2CD45B0", Offset = "0x2CD37B0", VA = "0x182CD45B0")]
	public static GBMNPHMLGKB<T> ENKECPBOOIC<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2CD4500", Offset = "0x2CD3700", VA = "0x182CD4500")]
	public static GBMNPHMLGKB<T> CPNDOIMICJM<T>(T ADPMAHMCGNH, [Optional] Action<T>? BDILBDIGJFD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x2B6E440", Offset = "0x2B6D640", VA = "0x182B6E440")]
	public static GBMNPHMLGKB<T> HJMCIEPGHOP<T>(Exception HBEPHPNHPNB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x2B6E440", Offset = "0x2B6D640", VA = "0x182B6E440")]
	public static GBMNPHMLGKB<T> LPMMIMKFOPJ<T>(Task<GBMNPHMLGKB<T>> LEDCCMOCHJB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x28D5900", Offset = "0x28D4B00", VA = "0x1828D5900")]
	public static GBMNPHMLGKB<TOut> IKKMMCBJHKI<TOut, TIn>(GBMNPHMLGKB<TIn> IIMJMBJHGDI, Func<TIn, TOut> AMBLFAKGKHE) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public abstract class MDDCCCKDBFD<T> : GBMNPHMLGKB<T>, IABENFAMAOM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static readonly string LBMPEFBEIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly AHNPDBJIDJD OGOPNLCHEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private bool MAFFMBBADNE;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool OJBMAONCMFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xB80600", Offset = "0xB7F800", VA = "0x180B80600", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public abstract Task<T> GJLNBAMLKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public abstract MAKKFMNHCEA<T> AOBKCEMGLKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x4493100", Offset = "0x4492300", VA = "0x184493100")]
	public MDDCCCKDBFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x4492D00", Offset = "0x4491F00", VA = "0x184492D00", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void MDIOCFABDCD();
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public abstract class OBLJHNCCPPP<TTask, T> : MDDCCCKDBFD<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class NEBGBHFDEIJ
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
			public NEBGBHFDEIJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x35800B0", Offset = "0x357F2B0", VA = "0x1835800B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x3580600", Offset = "0x357F800", VA = "0x183580600", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public OBLJHNCCPPP<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public NEBGBHFDEIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x4514860", Offset = "0x4513A60", VA = "0x184514860")]
		[AsyncStateMachine(typeof(OBLJHNCCPPP<, >.NEBGBHFDEIJ.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> ECDKOFADJJG(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly Task<T> LEDCCMOCHJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	protected readonly CancellationTokenSource NPCICLIMLAO;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public override Task<T> GJLNBAMLKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public override MAKKFMNHCEA<T> AOBKCEMGLKF
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x851AA0", VA = "0x1808528A0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x4621030", Offset = "0x4620230", VA = "0x184621030")]
	protected OBLJHNCCPPP(TTask LEDCCMOCHJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x4620DF0", Offset = "0x461FFF0", VA = "0x184620DF0", Slot = "10")]
	protected override void MDIOCFABDCD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T DOCHOJKICPF(TTask OMBNLOMPPEF);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void GLGFOCIIMBB();
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class GNFMNOLIFHP<T> : MDDCCCKDBFD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly PIKIJNPLMPM<Task<T>> KNGNJJGKNLA;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public override Task<T> GJLNBAMLKBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3CE57D0", Offset = "0x3CE49D0", VA = "0x183CE57D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public override MAKKFMNHCEA<T> AOBKCEMGLKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8528A0", Offset = "0x851AA0", VA = "0x1808528A0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5840", Offset = "0x3CE4A40", VA = "0x183CE5840")]
	public GNFMNOLIFHP(PIKIJNPLMPM<Task<T>> FOFGABHMNDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x3CE5820", Offset = "0x3CE4A20", VA = "0x183CE5820", Slot = "10")]
	protected override void MDIOCFABDCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class LHFAHALCBEB
{
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public static readonly HashAlgorithmName OGCCNNILNND;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly ThreadLocal<IncrementalHash> CMMFHCKDAGP;

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x68C4C30", Offset = "0x68C3E30", VA = "0x1868C4C30")]
	public static int EOPENGOEFIE(this CEAGNJHJOCG PFNNOMPNEPO, IncrementalHash BGMAOMLOOIC, byte[] DDKJPDFNFFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x68C5070", Offset = "0x68C4270", VA = "0x1868C5070")]
	public static bool OCCAPKCOBAG([CanBeNull] this CEAGNJHJOCG PFNNOMPNEPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x68C50D0", Offset = "0x68C42D0", VA = "0x1868C50D0")]
	public static bool OCCAPKCOBAG([CanBeNull] this CEAGNJHJOCG PFNNOMPNEPO, [Out] string GGEHLADLJHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x68C4D40", Offset = "0x68C3F40", VA = "0x1868C4D40")]
	public static bool OCCAPKCOBAG([CanBeNull] this CEAGNJHJOCG PFNNOMPNEPO, IncrementalHash BGMAOMLOOIC, byte[] DDKJPDFNFFD, [Out] string GGEHLADLJHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x68C4CB0", Offset = "0x68C3EB0", VA = "0x1868C4CB0")]
	private static bool MPGJNMPBAJG(byte[] OMFLMICADGH, Span<byte> EBICLIKEKJG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class LHDMLOIIAOF
{
	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x68C4AE0", Offset = "0x68C3CE0", VA = "0x1868C4AE0")]
	public static int IPKIPJBEPHJ(HashAlgorithmName MNIMKJCKKKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x68C4880", Offset = "0x68C3A80", VA = "0x1868C4880")]
	public static int EOPENGOEFIE(this FOEMIFIPDHC DHFJKIPBMFJ, byte[] NMFEPCIMIAN, IncrementalHash BGMAOMLOOIC, byte[] EKFMIPDOAPN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface FOEMIFIPDHC
{
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash BGMAOMLOOIC);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface CEAGNJHJOCG : FOEMIFIPDHC
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	[CanBeNull]
	byte[] FAKBFMBEEFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	[CanBeNull]
	byte[] AAHKDJIIEFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class IOJCOBHAGFG
{
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static bool MMALCHFILNB;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly ArrayPool<byte> LFJOBHFHLIP;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly ArrayPool<char> KPHKJMHODKM;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly Encoding BAKLFFLKPIP;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly ThreadLocal<Encoder> EEOPNEOPEBO;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2BBC830", Offset = "0x2BBBA30", VA = "0x182BBC830")]
	public static void CNPAGKBBIPD<T>(this IncrementalHash EJJPKIEAEOJ, [CanBeNull] T INPAFGCEBHH) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2BBCF20", Offset = "0x2BBC120", VA = "0x182BBCF20")]
	public static void EMLEKPEKODA<T>(this IncrementalHash EJJPKIEAEOJ, [CanBeNull] T DHFJKIPBMFJ) where T : FOEMIFIPDHC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2BBCFB0", Offset = "0x2BBC1B0", VA = "0x182BBCFB0")]
	public static void KDEPAHFAJNG<T>(this IncrementalHash EJJPKIEAEOJ, [CanBeNull] IList<T> AMPDPODCKNI) where T : FOEMIFIPDHC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x68C3DF0", Offset = "0x68C2FF0", VA = "0x1868C3DF0")]
	private static bool HOEIECHNKHJ([CanBeNull] FOEMIFIPDHC DHFJKIPBMFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x68C40B0", Offset = "0x68C32B0", VA = "0x1868C40B0")]
	public static void LCFNAEKCBPL(this IncrementalHash BGMAOMLOOIC, string? OCIBELDMAAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x68C3A50", Offset = "0x68C2C50", VA = "0x1868C3A50")]
	public static void FKEGCHJGIOJ(this IncrementalHash BGMAOMLOOIC, long GFMBFOEFLFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x68C3C20", Offset = "0x68C2E20", VA = "0x1868C3C20")]
	public static void GBNCLGONELP(this IncrementalHash BGMAOMLOOIC, int EOHIGKOGJIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x68C35E0", Offset = "0x68C27E0", VA = "0x1868C35E0")]
	public static void DJAPLPKGNGB(this IncrementalHash BGMAOMLOOIC, short EKIDBNIHGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x68C3940", Offset = "0x68C2B40", VA = "0x1868C3940")]
	public static void FGLNHDMIGKO(this IncrementalHash BGMAOMLOOIC, byte LGAPMFOONIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x68C3E80", Offset = "0x68C3080", VA = "0x1868C3E80")]
	public static void KNKOIFFHJAH(this IncrementalHash BGMAOMLOOIC, bool JGCDIGHDPJC, bool NFCMLGILAOO = false, bool ADPDFKGHKGK = false, bool LEPLIIGEKNE = false, bool INAJHEFHAGB = false, bool MGFEEBHGLDK = false, bool GNEMENOMHLN = false, bool DNHAFAKMNCK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2BBC8F0", Offset = "0x2BBBAF0", VA = "0x182BBC8F0")]
	public static void DLLAPPKCHBA<T>(this IncrementalHash BGMAOMLOOIC, T NKEPPGPEFAC) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x68C37B0", Offset = "0x68C29B0", VA = "0x1868C37B0")]
	public static void EEPLLLFEHPA(this IncrementalHash BGMAOMLOOIC, float CGKCMNEGKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x68C4050", Offset = "0x68C3250", VA = "0x1868C4050")]
	public static void LCEEFBMDLNC(this IncrementalHash BGMAOMLOOIC, ulong HIDLCCHGKBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x68C3FF0", Offset = "0x68C31F0", VA = "0x1868C3FF0")]
	public static void KOIGCEAPDPH(this IncrementalHash BGMAOMLOOIC, uint JGPNPJAIALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x68C44C0", Offset = "0x68C36C0", VA = "0x1868C44C0")]
	public static void LGDCCFKHDAM(this IncrementalHash BGMAOMLOOIC, ushort NFMGAKDNKLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x68C3810", Offset = "0x68C2A10", VA = "0x1868C3810")]
	public static void FCIPJKPKEKP(this IncrementalHash BGMAOMLOOIC, Vector3 NLCKJNGAHOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class EOCGBMKNDDN : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x68C3390", Offset = "0x68C2590", VA = "0x1868C3390")]
	public EOCGBMKNDDN(string JNNDBFGKHHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public abstract class OLMGKNKHOEA<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	internal class JGFNDJBHLGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public TNode HIKEOGPAJAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public TNode BMBBFJPOJEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public MKNIGIHFOCE IDOOJPJNKLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public List<MKNIGIHFOCE> MEBIICEPBCE;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public JGFNDJBHLGK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	internal struct MKNIGIHFOCE : IComparable<MKNIGIHFOCE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public int CBHPEKJLLAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public TClaimant JOOMFCKIBIA;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xD891C0", Offset = "0xD883C0", VA = "0x180D891C0")]
		public MKNIGIHFOCE(int CBHPEKJLLAF, TClaimant JOOMFCKIBIA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x44AEB50", Offset = "0x44ADD50", VA = "0x1844AEB50")]
		public bool GLMODKNLDMJ([In] MKNIGIHFOCE OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x44AEBB0", Offset = "0x44ADDB0", VA = "0x1844AEBB0")]
		public bool JFCICOEJFHD([In] MKNIGIHFOCE OKGBBGMIACH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x44AEB40", Offset = "0x44ADD40", VA = "0x1844AEB40", Slot = "4")]
		public int CompareTo(MKNIGIHFOCE OKGBBGMIACH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x44AEBC0", Offset = "0x44ADDC0", VA = "0x1844AEBC0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public enum CEBFEKJKDCN
	{
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class PMNNDINKMBK : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public OLMGKNKHOEA<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x89FB40", Offset = "0x89ED40", VA = "0x18089FB40")]
		[DebuggerHidden]
		public PMNNDINKMBK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x478A0D0", Offset = "0x47892D0", VA = "0x18478A0D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x478A2A0", Offset = "0x47894A0", VA = "0x18478A2A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x478A1B0", Offset = "0x47893B0", VA = "0x18478A1B0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x398E320", Offset = "0x398D520", VA = "0x18398E320", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly CAJPHPCFPPJ<JGFNDJBHLGK> GOHLDHFINAI;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly CAJPHPCFPPJ<List<MKNIGIHFOCE>> AKBNLJNBMGA;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static int ELDDLGIECEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	internal readonly Dictionary<TClaimant, TNode> EOPOIOIBAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	internal readonly Dictionary<TNode, JGFNDJBHLGK> DMGOLBKMDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private CEBFEKJKDCN DNCAOAEPAKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool LOOMHHLOKGF;

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode EJGCADKFNOA(TNode LLENHGPBNOK);

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void JPPKKMPMPEF(TNode LLENHGPBNOK, TClaimant FFJFCDDDHHD, TClaimant POAGJKNBNPJ);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x467EA20", Offset = "0x467DC20", VA = "0x18467EA20")]
	public OLMGKNKHOEA(CEBFEKJKDCN DNCAOAEPAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x467E790", Offset = "0x467D990", VA = "0x18467E790")]
	public void NJJNMEDKCPE(TNode LLENHGPBNOK, TNode KGHLFFBGAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x467D7E0", Offset = "0x467C9E0", VA = "0x18467D7E0")]
	public void FPDLNKKCFJK(TClaimant JOOMFCKIBIA, TNode LHEKFIAPFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x467D4D0", Offset = "0x467C6D0", VA = "0x18467D4D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x467DE00", Offset = "0x467D000", VA = "0x18467DE00")]
	private void LHDCOHMHHHG(TClaimant JOOMFCKIBIA, TNode OOOGHEGGLNM, TNode LHEKFIAPFHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x467D950", Offset = "0x467CB50", VA = "0x18467D950")]
	private int GMKIELAOLGB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x467E2F0", Offset = "0x467D4F0", VA = "0x18467E2F0")]
	private void MOBFJOJEODO(TClaimant JOOMFCKIBIA, TNode BIAKJJCLLID, TNode MODLHPADBNH, int JJCEFAGICFP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x467E220", Offset = "0x467D420", VA = "0x18467E220")]
	private void MLAPOHICBNJ(MKNIGIHFOCE PPMAMEOGFHI, JGFNDJBHLGK EGLLCDAKFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x467CF60", Offset = "0x467C160", VA = "0x18467CF60")]
	private void BJMICDOBFJM(TClaimant JOOMFCKIBIA, TNode BIAKJJCLLID, TNode MODLHPADBNH, int JJCEFAGICFP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x467D3A0", Offset = "0x467C5A0", VA = "0x18467D3A0")]
	private void DBOPOABIABA(MKNIGIHFOCE PPMAMEOGFHI, TNode LLENHGPBNOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x467E630", Offset = "0x467D830", VA = "0x18467E630")]
	private void NAKPKGILFEG(MKNIGIHFOCE PPMAMEOGFHI, JGFNDJBHLGK EGLLCDAKFDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x467D250", Offset = "0x467C450", VA = "0x18467D250")]
	private void CNDGLHIGANH(JGFNDJBHLGK EGLLCDAKFDC, bool PKNHKGDKIOM = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x467DED0", Offset = "0x467D0D0", VA = "0x18467DED0")]
	private void MGKIDAKOLDC(JGFNDJBHLGK EGLLCDAKFDC, TNode KGHLFFBGAIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x467D9C0", Offset = "0x467CBC0", VA = "0x18467D9C0")]
	[IteratorStateMachine(typeof(OLMGKNKHOEA<, >.PMNNDINKMBK))]
	private IEnumerable<TNode> IHCDNCHFMJE(TNode BIAKJJCLLID, TNode MODLHPADBNH, bool NNLPMCHFPHJ = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x467D6D0", Offset = "0x467C8D0", VA = "0x18467D6D0")]
	private JGFNDJBHLGK EHEAPGIABLG(TNode LLENHGPBNOK, TNode BMBBFJPOJEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x467DAB0", Offset = "0x467CCB0", VA = "0x18467DAB0")]
	private JGFNDJBHLGK IMNJPKNAEMO(TNode LLENHGPBNOK, TNode BMBBFJPOJEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x467DC40", Offset = "0x467CE40", VA = "0x18467DC40")]
	private void KNIMKAMBEDB(JGFNDJBHLGK EGLLCDAKFDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class DLCLPGKFPDM<T> : IEnumerable<DLCLPGKFPDM<T>.OBDEHHJCNBO>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct OBDEHHJCNBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public T JMDCGOKJIDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public int DHNLEFJCEAH;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class NBGIDHOAPIM : IEnumerator<OBDEHHJCNBO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private DLCLPGKFPDM<T> NAOKJFLCLAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int DHNLEFJCEAH;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x38230B0", Offset = "0x38222B0", VA = "0x1838230B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public OBDEHHJCNBO EBFPDFJFKPC
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x450EAE0", Offset = "0x450DCE0", VA = "0x18450EAE0", Slot = "4")]
			get
			{
				return default(OBDEHHJCNBO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x450E9F0", Offset = "0x450DBF0", VA = "0x18450E9F0")]
		public NBGIDHOAPIM(DLCLPGKFPDM<T> NAOKJFLCLAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x450E970", Offset = "0x450DB70", VA = "0x18450E970", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x3878390", Offset = "0x3877590", VA = "0x183878390", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x93ABB0", Offset = "0x939DB0", VA = "0x18093ABB0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private struct NOFLDIHKDIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool DLHNOLAFDOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public T JMDCGOKJIDA;
	}

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private const int PNEGAMBKAPP = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly Dictionary<T, int> IBAMAMICCBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private NOFLDIHKDIC[] IHCMEBBLIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private int GNMDMHIJCOI;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public int IOIECPABLEP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x891DC0", Offset = "0x890FC0", VA = "0x180891DC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8913C0", Offset = "0x8905C0", VA = "0x1808913C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3592420", Offset = "0x3591620", VA = "0x183592420")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x578D2E0", Offset = "0x578C4E0", VA = "0x18578D2E0")]
	public DLCLPGKFPDM(int HHGNDILCLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x578D3D0", Offset = "0x578C5D0", VA = "0x18578D3D0")]
	public DLCLPGKFPDM(OBDEHHJCNBO[] LMPEAEHMIBH, bool HLDKFPLAGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x578CE10", Offset = "0x578C010", VA = "0x18578CE10")]
	public int EGHBGNMNINA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x578CA10", Offset = "0x578BC10", VA = "0x18578CA10")]
	private int BCNIOLPGFFI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x578D090", Offset = "0x578C290", VA = "0x18578D090", Slot = "6")]
	protected virtual uint MNAKOEMGGBL(uint BGMAOMLOOIC, T JMDCGOKJIDA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x578D0B0", Offset = "0x578C2B0", VA = "0x18578D0B0")]
	public bool ODHBLCILLBD(T JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x578CF60", Offset = "0x578C160", VA = "0x18578CF60")]
	public int ICKPOHFJOGL(T JMDCGOKJIDA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x578D180", Offset = "0x578C380", VA = "0x18578D180")]
	public T POIMHEEJLCG(int DHNLEFJCEAH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x578C750", Offset = "0x578B950", VA = "0x18578C750")]
	public bool AGNJLLJNDOJ(T JMDCGOKJIDA, bool JJAIHJFGNCD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x578C7B0", Offset = "0x578B9B0", VA = "0x18578C7B0")]
	public bool AGNJLLJNDOJ(T JMDCGOKJIDA, int DHNLEFJCEAH, bool JJAIHJFGNCD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x578CEC0", Offset = "0x578C0C0", VA = "0x18578CEC0")]
	private int HLIPIGFOOOI(int JHEGPJBDKAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x578D240", Offset = "0x578C440", VA = "0x18578D240", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x578D240", Offset = "0x578C440", VA = "0x18578D240", Slot = "4")]
	private IEnumerator<OBDEHHJCNBO> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class CAJPHPCFPPJ<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly Stack<T> JOPKJIBCCEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly List<T> BNAFAHMPPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly int KJLEDNHKEND;

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x50172B0", Offset = "0x50164B0", VA = "0x1850172B0")]
	public static CAJPHPCFPPJ<T> HBPMPABLDNC(int HHGNDILCLEE = 0, int KJLEDNHKEND = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x5017000", Offset = "0x5016200", VA = "0x185017000")]
	public static CAJPHPCFPPJ<T> BJHJLAFEIHL(int HHGNDILCLEE = 0, int KJLEDNHKEND = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x5017B00", Offset = "0x5016D00", VA = "0x185017B00")]
	public CAJPHPCFPPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x5017900", Offset = "0x5016B00", VA = "0x185017900")]
	public CAJPHPCFPPJ(int HHGNDILCLEE, int KJLEDNHKEND = int.MaxValue, bool BBFPOCCEHDH = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x5017690", Offset = "0x5016890", VA = "0x185017690")]
	public T MCBLJONGBGM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x5017830", Offset = "0x5016A30", VA = "0x185017830")]
	public void NLCHOINDCPP(T JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x5017590", Offset = "0x5016790", VA = "0x185017590")]
	private void KDIBJKFCPKI(T JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x50170F0", Offset = "0x50162F0", VA = "0x1850170F0")]
	private void CAPMIAOOFKN(T JMDCGOKJIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x5017130", Offset = "0x5016330", VA = "0x185017130", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x50173A0", Offset = "0x50165A0", VA = "0x1850173A0")]
	private void IJHCHEHDLAP(IEnumerable<T> MNHECFLLMJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class MEOFAFIIODC<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private Dictionary<int, T> ENCKOMKBEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private T BGCICGMELIJ;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public virtual T MDNMGILJJDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851B00", VA = "0x180852900", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x852890", Offset = "0x851A90", VA = "0x180852890", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x44A30B0", Offset = "0x44A22B0", VA = "0x1844A30B0")]
	public bool MBCOGGKHPPK(T JMDCGOKJIDA, int CBHPEKJLLAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x44A31F0", Offset = "0x44A23F0", VA = "0x1844A31F0")]
	public bool NOOCMPIIMHF(int CBHPEKJLLAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x44A2CB0", Offset = "0x44A1EB0", VA = "0x1844A2CB0")]
	public T HDKIBNHBHBG(int EFAIDKFIHBO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x44A2AC0", Offset = "0x44A1CC0", VA = "0x1844A2AC0")]
	private bool BCHEJMABEAA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x44A2A60", Offset = "0x44A1C60", VA = "0x1844A2A60")]
	public bool AKPHPFIGELN(int CBHPEKJLLAF, [Out] T JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x44A3290", Offset = "0x44A2490", VA = "0x1844A3290")]
	public MEOFAFIIODC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class FJGCBIBHNKC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	protected struct CICOHLCPCCM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public T JNHPIMBJPMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public int CLMJDMFGEEH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	protected readonly List<CICOHLCPCCM> GOKDLEPEPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private T FLCFFHCGPAE;

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3592420", Offset = "0x3591620", VA = "0x183592420")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x3BF2900", Offset = "0x3BF1B00", VA = "0x183BF2900")]
	public bool DJONJHALGBO(T JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x3BF3280", Offset = "0x3BF2480", VA = "0x183BF3280")]
	public void PBLNBBGFGAP(T JMDCGOKJIDA, int CBHPEKJLLAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x3BF2D20", Offset = "0x3BF1F20", VA = "0x183BF2D20")]
	public bool MFKDEBIIBOM(T JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x3BF2C90", Offset = "0x3BF1E90", VA = "0x183BF2C90")]
	public void IMJJLGNDCEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x3BF3110", Offset = "0x3BF2310", VA = "0x183BF3110")]
	public T NIPDGGIOLFB()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x3BF2790", Offset = "0x3BF1990", VA = "0x183BF2790")]
	protected void ADIMLGACIJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x3BF3330", Offset = "0x3BF2530", VA = "0x183BF3330")]
	public FJGCBIBHNKC()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		[SerializeField]
		[CIHMDBDDPOM(LEHCEJJDOON.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x68C5DE0", Offset = "0x68C4FE0", VA = "0x1868C5DE0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x68C60B0", Offset = "0x68C52B0", VA = "0x1868C60B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x68C5FC0", Offset = "0x68C51C0", VA = "0x1868C5FC0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x68C5D30", Offset = "0x68C4F30", VA = "0x1868C5D30")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x68C6000", Offset = "0x68C5200", VA = "0x1868C6000")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x68C5F10", Offset = "0x68C5110", VA = "0x1868C5F10")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x68C5CA0", Offset = "0x68C4EA0", VA = "0x1868C5CA0")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x4932A80", Offset = "0x4931C80", VA = "0x184932A80", Slot = "4")]
		public virtual T IAEKFCIDOJB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class EBAAHAJOGPG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private Dictionary<byte, MGEHJFADNFP> LGFHDKPHDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly CAJPHPCFPPJ<MGEHJFADNFP> KMBEOJJMKHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly bool FHFADMIJKPL;

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public MGEHJFADNFP KMOCFMJFNDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x853100", Offset = "0x852300", VA = "0x180853100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x8530F0", Offset = "0x8522F0", VA = "0x1808530F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public Vector2 PFIPJEJHIMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xD33670", Offset = "0xD32870", VA = "0x180D33670")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x1011380", Offset = "0x1010580", VA = "0x181011380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	private Vector2 OIJAPFHDMJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x1076B60", Offset = "0x1075D60", VA = "0x181076B60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Vector2 KNABPCAPIKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x68C2B80", Offset = "0x68C1D80", VA = "0x1868C2B80")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x856970", Offset = "0x855B70", VA = "0x180856970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public int BBDCOONMEKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x858FA0", Offset = "0x8581A0", VA = "0x180858FA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x858FB0", Offset = "0x8581B0", VA = "0x180858FB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x68C32D0", Offset = "0x68C24D0", VA = "0x1868C32D0")]
	public EBAAHAJOGPG(Bounds KDCDOPFLHCB, Vector2[] DPJEDCJKKHP, int OJLNBIJKHHG, byte JHEGPJBDKAJ, float GGJDPDBKJBO = 0f, [Optional] CAJPHPCFPPJ<MGEHJFADNFP> KMBEOJJMKHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x68C2530", Offset = "0x68C1730", VA = "0x1868C2530")]
	public void BOBCJIHEMLL(Bounds KDCDOPFLHCB, Vector2[] DPJEDCJKKHP, int OJLNBIJKHHG, byte JHEGPJBDKAJ, float GGJDPDBKJBO = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x68C2BA0", Offset = "0x68C1DA0", VA = "0x1868C2BA0")]
	public MGEHJFADNFP MMNLJMABFJA(byte DHNLEFJCEAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x68C2AB0", Offset = "0x68C1CB0", VA = "0x1868C2AB0")]
	public void JGKPHFDIMOO(Vector3 HGDCPNGLIKJ, float NANONHKFLNA, float AAJMFKMAPJC, List<byte> KCPGCDNJEHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x68C2A30", Offset = "0x68C1C30", VA = "0x1868C2A30")]
	public void FFGCPAEENBJ(MGEHJFADNFP.LHPOGDFGOMM MPLMFILGECK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x68C31E0", Offset = "0x68C23E0", VA = "0x1868C31E0")]
	public static int PJBEALCPOAM(Vector2[] DPJEDCJKKHP, int OJLNBIJKHHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x68C2FB0", Offset = "0x68C21B0", VA = "0x1868C2FB0")]
	private MGEHJFADNFP PGDKNGDEEDJ(byte DHNLEFJCEAH, MGEHJFADNFP.BKCIFIMDGNF CNKALIILKAB, MGEHJFADNFP BMBBFJPOJEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x68C2C00", Offset = "0x68C1E00", VA = "0x1868C2C00")]
	private void MPDBJPKFCLE(MGEHJFADNFP BMBBFJPOJEB, Vector2[] DPJEDCJKKHP, int POFJHEANJLB, int HBFHNOFLBKI, int OEDKEGLIMMN, int BCOADEPLLJB, float GGJDPDBKJBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x68C2310", Offset = "0x68C1510", VA = "0x1868C2310")]
	private void AKODCACBFNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x68C29D0", Offset = "0x68C1BD0", VA = "0x1868C29D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x68C2A50", Offset = "0x68C1C50", VA = "0x1868C2A50", Slot = "1")]
	~EBAAHAJOGPG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class MGEHJFADNFP
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public enum BKCIFIMDGNF
	{
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public enum LHPOGDFGOMM
	{
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public byte CODEDOIEGGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public Vector3 KNFHACNBEOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public Vector3 LIFKLMGEOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public Vector3 KNPEIHDJEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public Vector3 ECFANLHEHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public BKCIFIMDGNF KAMHFFBHMOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public MGEHJFADNFP EJAGAMOLJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public List<MGEHJFADNFP> KHBCKHOINMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public bool JOLMKCABECH;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x68C5A40", Offset = "0x68C4C40", VA = "0x1868C5A40")]
	public MGEHJFADNFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x68C58E0", Offset = "0x68C4AE0", VA = "0x1868C58E0")]
	public void LGJHIGDGICA(MGEHJFADNFP JPEFLCPGHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x854290", Offset = "0x853490", VA = "0x180854290")]
	public void FFGCPAEENBJ(int DBBMHIGAALB, LHPOGDFGOMM MPLMFILGECK, int GHDPCBMOFPP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x68C5680", Offset = "0x68C4880", VA = "0x1868C5680")]
	public void JGKPHFDIMOO(List<byte> KCPGCDNJEHA, Vector3 HGDCPNGLIKJ, float NANONHKFLNA, float AAJMFKMAPJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x68C55C0", Offset = "0x68C47C0", VA = "0x1868C55C0")]
	public bool ENOABKCMGKL(Vector3 FNIJIKICPBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x68C5A10", Offset = "0x68C4C10", VA = "0x1868C5A10")]
	public bool MMLCMIOAFMM(Vector3 FNIJIKICPBL, float LIOGGACPGOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x68C55F0", Offset = "0x68C47F0", VA = "0x1868C55F0")]
	public void HMCGAKKBHMB()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public struct NNPHAGBPNDM<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			private readonly List<Component> CGIFJALMJMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			private readonly bool AEJPJHFLJPH;

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x4238720", Offset = "0x4237920", VA = "0x184238720")]
			public NNPHAGBPNDM(List<Component> CGIFJALMJMI, bool AEJPJHFLJPH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x454E430", Offset = "0x454D630", VA = "0x18454E430")]
			public JJBLGBDCGNE<T> DCPEOMEKOMK()
			{
				return default(JJBLGBDCGNE<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x454E490", Offset = "0x454D690", VA = "0x18454E490", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x454E490", Offset = "0x454D690", VA = "0x18454E490", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006B")]
		public struct JJBLGBDCGNE<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			private readonly List<Component> CGIFJALMJMI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private readonly bool AEJPJHFLJPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private int DHNLEFJCEAH;

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			public T EBFPDFJFKPC
			{
				[Cpp2IlInjected.Token(Token = "0x6000211")]
				[Cpp2IlInjected.Address(RVA = "0x40B5EE0", Offset = "0x40B50E0", VA = "0x1840B5EE0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000212")]
				[Cpp2IlInjected.Address(RVA = "0x40B5E70", Offset = "0x40B5070", VA = "0x1840B5E70", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x40B5EB0", Offset = "0x40B50B0", VA = "0x1840B5EB0")]
			public JJBLGBDCGNE(List<Component> CGIFJALMJMI, bool AEJPJHFLJPH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x40B5DB0", Offset = "0x40B4FB0", VA = "0x1840B5DB0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x40B5DC0", Offset = "0x40B4FC0", VA = "0x1840B5DC0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x3869700", Offset = "0x3868900", VA = "0x183869700", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x68C7B00", Offset = "0x68C6D00", VA = "0x1868C7B00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x85AD80", Offset = "0x859F80", VA = "0x18085AD80")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x68C75B0", Offset = "0x68C67B0", VA = "0x1868C75B0")]
		private void HMCGAKKBHMB(GameObject JDNAMEBBFMB, bool AMNFMCIBNPO = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x68C7520", Offset = "0x68C6720", VA = "0x1868C7520")]
		public static void HMCGAKKBHMB(GameObject JDNAMEBBFMB, ToolHierarchyCache MGPCCJLLDAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x68C7420", Offset = "0x68C6620", VA = "0x1868C7420")]
		public void EKBFOMDGHMK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x2E48420", Offset = "0x2E47620", VA = "0x182E48420")]
		public void LEBBJHKNBKL<T>(Action<T> ENGMCBPHJGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x2E48380", Offset = "0x2E47580", VA = "0x182E48380")]
		public T IMHGJJDCNHN<T>(bool AEJPJHFLJPH = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x2E48650", Offset = "0x2E47850", VA = "0x182E48650")]
		public NNPHAGBPNDM<T> NHGLAGFMEFC<T>(bool AEJPJHFLJPH = false) where T : class
		{
			return default(NNPHAGBPNDM<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x68C7720", Offset = "0x68C6920", VA = "0x1868C7720")]
		public List<Component> JLPJGPOMMPK(Type NCMHJNKFAGH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x68C7430", Offset = "0x68C6630", VA = "0x1868C7430", Slot = "4")]
		public bool Equals(ToolHierarchyCache IPBJLCONKPC, ToolHierarchyCache FACAKAOOAJP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x68C74B0", Offset = "0x68C66B0", VA = "0x1868C74B0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache MEAFIMADMKA)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class DKAOIPEKHDK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int HHGNDILCLEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int GPLPBBELLMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private List<T> DBMHCDPGPKD;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int MELIDLJEANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x3CE57D0", Offset = "0x3CE49D0", VA = "0x183CE57D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public T NCDLNIPPHPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x5788120", Offset = "0x5787320", VA = "0x185788120")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public T OAIJJFKKBFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x5787EF0", Offset = "0x57870F0", VA = "0x185787EF0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public T AOELINJOHCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x5788320", Offset = "0x5787520", VA = "0x185788320")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x5788650", Offset = "0x5787850", VA = "0x185788650")]
	public DKAOIPEKHDK(int HHGNDILCLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x57884F0", Offset = "0x57876F0", VA = "0x1857884F0")]
	public void PBLNBBGFGAP(T NJICNCJNFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x5788060", Offset = "0x5787260", VA = "0x185788060")]
	public void IMJJLGNDCEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x5787F70", Offset = "0x5787170", VA = "0x185787F70")]
	public void EELNHPMEPEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x57880C0", Offset = "0x57872C0", VA = "0x1857880C0")]
	public void JPGLPONFFLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x5787E70", Offset = "0x5787070", VA = "0x185787E70")]
	public void ALCHLDCDNCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class PAOCFNIHNOE<T>
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private struct FPAKJFKIPKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public int CLMJDMFGEEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public T JNHPIMBJPMJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly Dictionary<object, FPAKJFKIPKF> ENCKOMKBEOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly EqualityComparer<T> PLDPEIBNFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private T BGCICGMELIJ;

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public virtual T MDNMGILJJDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x8C9C00", Offset = "0x8C8E00", VA = "0x1808C9C00", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x4756FE0", Offset = "0x47561E0", VA = "0x184756FE0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool BFKHAPKIPIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x4756F70", Offset = "0x4756170", VA = "0x184756F70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public object ELFAFEKBGJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x856BC0", Offset = "0x855DC0", VA = "0x180856BC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x85B4C0", Offset = "0x85A6C0", VA = "0x18085B4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x47579F0", Offset = "0x4756BF0", VA = "0x1847579F0")]
	public bool MBCOGGKHPPK(T JMDCGOKJIDA, object EOCJCEFCOOA, int CBHPEKJLLAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x4757D90", Offset = "0x4756F90", VA = "0x184757D90")]
	public bool NOOCMPIIMHF(object EOCJCEFCOOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x4754150", Offset = "0x4753350", VA = "0x184754150")]
	public bool AKPHPFIGELN(object EOCJCEFCOOA, [Out] T JMDCGOKJIDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x4548EB0", Offset = "0x45480B0", VA = "0x184548EB0")]
	public void IMJJLGNDCEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x4754660", Offset = "0x4753860", VA = "0x184754660")]
	private bool BCHEJMABEAA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x4757E50", Offset = "0x4757050", VA = "0x184757E50")]
	public PAOCFNIHNOE()
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
