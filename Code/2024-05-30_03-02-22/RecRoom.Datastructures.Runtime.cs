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
		[Cpp2IlInjected.Address(RVA = "0x7F2B00", Offset = "0x7F1D00", VA = "0x1807F2B00")]
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
		[Cpp2IlInjected.Address(RVA = "0x63D0B60", Offset = "0x63CFD60", VA = "0x1863D0B60")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7F3A00", Offset = "0x7F2C00", VA = "0x1807F3A00")]
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
		[Cpp2IlInjected.Address(RVA = "0x7F3A40", Offset = "0x7F2C40", VA = "0x1807F3A40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class EAGCJGICMGK : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1409650", Offset = "0x1408850", VA = "0x181409650")]
	public EAGCJGICMGK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, BKLFMNKEDBP, NMOOGDEEBPF, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF80", Offset = "0x7CA180", VA = "0x1807CAF80", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4C0", Offset = "0x7CA6C0", VA = "0x1807CB4C0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF90", Offset = "0x7CA190", VA = "0x1807CAF90", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x865250", Offset = "0x864450", VA = "0x180865250", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash ICJNJPHEBHD);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x834750", Offset = "0x833950", VA = "0x180834750")]
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
		[Cpp2IlInjected.Address(RVA = "0x63D20B0", Offset = "0x63D12B0", VA = "0x1863D20B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x63D2070", Offset = "0x63D1270", VA = "0x1863D2070")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x63D20F0", Offset = "0x63D12F0", VA = "0x1863D20F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x63D22A0", Offset = "0x63D14A0", VA = "0x1863D22A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x63D2210", Offset = "0x63D1410", VA = "0x1863D2210")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x834740", Offset = "0x833940", VA = "0x180834740")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x834700", Offset = "0x833900", VA = "0x180834700")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x63D2030", Offset = "0x63D1230", VA = "0x1863D2030")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x63D2180", Offset = "0x63D1380", VA = "0x1863D2180")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x63D1D20", Offset = "0x63D0F20", VA = "0x1863D1D20")]
	public void CopyBounds(SavedExtents JPLJHFMPDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x63D1F80", Offset = "0x63D1180", VA = "0x1863D1F80")]
	public void SetLocalSpaceBounds(Bounds IFABHCLMCGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xAC5EA0", Offset = "0xAC50A0", VA = "0x180AC5EA0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x63D1F70", Offset = "0x63D1170", VA = "0x1863D1F70")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x63D14F0", Offset = "0x63D06F0", VA = "0x1863D14F0")]
	private void APOHMFNDLKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x63D1D50", Offset = "0x63D0F50", VA = "0x1863D1D50")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x63D16B0", Offset = "0x63D08B0", VA = "0x1863D16B0")]
	public static void CalculateLocalBoundsFor(GameObject IIDBEBHLIGH, [Out] Bounds IFABHCLMCGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x63D1430", Offset = "0x63D0630", VA = "0x1863D1430")]
	private static void ANFLGPDOCNA(Bounds NOIIDJMAOFK, Color HHHFIGOCAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x63D1FA0", Offset = "0x63D11A0", VA = "0x1863D1FA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C8110", Offset = "0x7C7310", VA = "0x1807C8110")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7CE040", Offset = "0x7CD240", VA = "0x1807CE040")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xF153E0", Offset = "0xF145E0", VA = "0x180F153E0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x45AD320", Offset = "0x45AC520", VA = "0x1845AD320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "4")]
	public virtual void AMIKGHDNHGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
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
	[EAGCJGICMGK]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x45ACF50", Offset = "0x45AC150", VA = "0x1845ACF50", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x45ABA00", Offset = "0x45AAC00", VA = "0x1845ABA00", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x45AD260", Offset = "0x45AC460", VA = "0x1845AD260")]
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
	private sealed class EHNDEELEIJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public EHNDEELEIJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3574190", Offset = "0x3573390", VA = "0x183574190")]
		internal int MCIBOJPGJFD(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[EAGCJGICMGK]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x35AAFC0", Offset = "0x35AA1C0", VA = "0x1835AAFC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x35AB000", Offset = "0x35AA200", VA = "0x1835AB000", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x35AAEE0", Offset = "0x35AA0E0", VA = "0x1835AAEE0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey MNOIAMGNLNL]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x35AAF60", Offset = "0x35AA160", VA = "0x1835AAF60", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x35AADE0", Offset = "0x35A9FE0", VA = "0x1835AADE0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x35AAB30", Offset = "0x35A9D30", VA = "0x1835AAB30", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x35AA070", Offset = "0x35A9270", VA = "0x1835AA070", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x35A9F70", Offset = "0x35A9170", VA = "0x1835A9F70", Slot = "14")]
	protected virtual string FIKLBEHNHOI(TKeyVal NBBKDMLOFNB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x35A9F00", Offset = "0x35A9100", VA = "0x1835A9F00", Slot = "4")]
	public bool ContainsKey(TKey MNOIAMGNLNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x35AACB0", Offset = "0x35A9EB0", VA = "0x1835AACB0", Slot = "5")]
	public bool TryGetValue(TKey MNOIAMGNLNL, [Out] TVal HLCKBKFCMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x35A9FD0", Offset = "0x35A91D0", VA = "0x1835A9FD0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x35A9FD0", Offset = "0x35A91D0", VA = "0x1835A9FD0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x35AACF0", Offset = "0x35A9EF0", VA = "0x1835AACF0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class BGKKJEOANJA<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class GLLLGOGNPHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public float DAFGCOCANMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public T OGADOHBOMGE;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public GLLLGOGNPHD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class HPKKNHNFCBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public HPKKNHNFCBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3A5DE80", Offset = "0x3A5D080", VA = "0x183A5DE80")]
		internal bool GPOMPODDFFK(GLLLGOGNPHD sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly float DNNEBJPJMFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly float FILHIMEHNLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<GLLLGOGNPHD> MIHHFEOCAKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private PBINHHMDMKA<GLLLGOGNPHD> DBECPLCGBLB;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int PPGABHHGIHG
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4A58660", Offset = "0x4A57860", VA = "0x184A58660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4A59120", Offset = "0x4A58320", VA = "0x184A59120")]
	public BGKKJEOANJA(float CCDJEKJOMGD, float CIJJLGAKNEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4A58890", Offset = "0x4A57A90", VA = "0x184A58890")]
	public bool ICABLGADONI(float BAPODJDPLNJ, T HLCKBKFCMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4A58CF0", Offset = "0x4A57EF0", VA = "0x184A58CF0")]
	public IEnumerable<T> IJIBDGAJKMG(float BAPODJDPLNJ, [Optional] float? ECICPDDNCDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4A586D0", Offset = "0x4A578D0", VA = "0x184A586D0")]
	public void BFDHFEEMFPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4A58FE0", Offset = "0x4A581E0", VA = "0x184A58FE0")]
	private void PCMMECFBDDL(float BAPODJDPLNJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class JAKFBLIGPCA<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct MBPEJMINICD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public T OGADOHBOMGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public float KFMPOMBJHEK;
	}

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static float IGDNOLIACGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private List<T> KBDPNIBPADM;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private const int MFDLDEPOOIK = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private MBPEJMINICD[] HPGKNFECNHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int FGLABHABDGP;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float PFEGECCFJJL
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8E14D0", Offset = "0x8E06D0", VA = "0x1808E14D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x90A0C0", Offset = "0x9092C0", VA = "0x18090A0C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3CE2790", Offset = "0x3CE1990", VA = "0x183CE2790")]
	public JAKFBLIGPCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3CE26A0", Offset = "0x3CE18A0", VA = "0x183CE26A0")]
	public JAKFBLIGPCA(int AGHIAPEPFJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3CE2310", Offset = "0x3CE1510", VA = "0x183CE2310")]
	public void LGLNKEHGBKE(float BAPODJDPLNJ, T HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3CE1960", Offset = "0x3CE0B60", VA = "0x183CE1960")]
	public void BFDHFEEMFPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3CE2040", Offset = "0x3CE1240", VA = "0x183CE2040")]
	public bool KHGBJHONFBI(float IDADMJINJBK, float FHNPHIOAFLB, [Out] T HLCKBKFCMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3CE1A50", Offset = "0x3CE0C50", VA = "0x183CE1A50")]
	public bool GBKMCLLJCBK(float IDADMJINJBK, float FHNPHIOAFLB, [Out] T HLCKBKFCMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3CE23D0", Offset = "0x3CE15D0", VA = "0x183CE23D0")]
	public void ONEGPINGCFJ(float IDADMJINJBK, float FHNPHIOAFLB, List<T> OPMKPGEDLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3CE2230", Offset = "0x3CE1430", VA = "0x183CE2230")]
	private int KKKIOCEPBNK(int MKFKICOLLKJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3CE1DB0", Offset = "0x3CE0FB0", VA = "0x183CE1DB0")]
	private void HPBEIEKEJDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T JCLCMMOGGNA();

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T JKDBLJBGINO(T HLCKBKFCMPI, float GIHFGGLMPDC);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T BIAAIBJILJC(T GFINPEICFEL, T ENBAOKALGHB);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T JEIMPDEKLIF(T GFINPEICFEL, T ENBAOKALGHB);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class DMNPABPJMAB : JAKFBLIGPCA<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7D8EA0", Offset = "0x7D80A0", VA = "0x1807D8EA0", Slot = "4")]
	protected override Vector3 JCLCMMOGGNA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x63CED00", Offset = "0x63CDF00", VA = "0x1863CED00", Slot = "5")]
	protected override Vector3 JKDBLJBGINO(Vector3 HLCKBKFCMPI, float GIHFGGLMPDC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x63CEC30", Offset = "0x63CDE30", VA = "0x1863CEC30", Slot = "6")]
	protected override Vector3 BIAAIBJILJC(Vector3 GFINPEICFEL, Vector3 ENBAOKALGHB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x63CEC80", Offset = "0x63CDE80", VA = "0x1863CEC80", Slot = "7")]
	protected override Vector3 JEIMPDEKLIF(Vector3 GFINPEICFEL, Vector3 ENBAOKALGHB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x63CED40", Offset = "0x63CDF40", VA = "0x1863CED40")]
	public DMNPABPJMAB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class EMFIHGMEIED
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x282B2A0", Offset = "0x282A4A0", VA = "0x18282B2A0")]
	public static JPAGMGAIGPN<T1, T2> ADOMMGOMPJC<T1, T2>(T1 KJKDLNMIHEF, T2 NLAGNJKEBCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x282B320", Offset = "0x282A520", VA = "0x18282B320")]
	public static CLMBBOMIMEG<T1, T2, T3> ADOMMGOMPJC<T1, T2, T3>(T1 KJKDLNMIHEF, T2 NLAGNJKEBCJ, T3 FOJPJCOKMKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4180170", Offset = "0x417F370", VA = "0x184180170")]
	internal static int LKIOBOGBAJE(int MPAKOLPLAJE, int KBMGGCLIENF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x57C8330", Offset = "0x57C7530", VA = "0x1857C8330")]
	internal static int LKIOBOGBAJE(int MPAKOLPLAJE, int KBMGGCLIENF, int EBLFAMJECGI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class JPAGMGAIGPN<T1, T2> : IComparable<JPAGMGAIGPN<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly T1 EFIOGEELNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly T2 FHANIJOMNGB;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3D9FC20", Offset = "0x3D9EE20", VA = "0x183D9FC20")]
	public JPAGMGAIGPN(T1 KJKDLNMIHEF, T2 NLAGNJKEBCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3D9E1C0", Offset = "0x3D9D3C0", VA = "0x183D9E1C0", Slot = "4")]
	public int CompareTo(JPAGMGAIGPN<T1, T2> JPLJHFMPDFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3D9E7E0", Offset = "0x3D9D9E0", VA = "0x183D9E7E0", Slot = "0")]
	public override bool Equals(object JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3D9F1F0", Offset = "0x3D9E3F0", VA = "0x183D9F1F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3D9F370", Offset = "0x3D9E570", VA = "0x183D9F370", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class CLMBBOMIMEG<T1, T2, T3> : IComparable<CLMBBOMIMEG<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly T1 EFIOGEELNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly T2 FHANIJOMNGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly T3 HNHIEGLGOGH;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x50629B0", Offset = "0x5061BB0", VA = "0x1850629B0")]
	public CLMBBOMIMEG(T1 KJKDLNMIHEF, T2 NLAGNJKEBCJ, T3 FOJPJCOKMKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5062200", Offset = "0x5061400", VA = "0x185062200", Slot = "4")]
	public int CompareTo(CLMBBOMIMEG<T1, T2, T3> JPLJHFMPDFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5062330", Offset = "0x5061530", VA = "0x185062330", Slot = "0")]
	public override bool Equals(object JPLJHFMPDFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x50625C0", Offset = "0x50617C0", VA = "0x1850625C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5062800", Offset = "0x5061A00", VA = "0x185062800", Slot = "3")]
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
	public T OGADOHBOMGE
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x22043D0", Offset = "0x22035D0", VA = "0x1822043D0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x22043E0", Offset = "0x22035E0", VA = "0x1822043E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float FPBKFIBINHM
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8346A0", Offset = "0x8338A0", VA = "0x1808346A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x47AB1D0", Offset = "0x47AA3D0", VA = "0x1847AB1D0")]
	public T KGJFNEEBPEG(float GIHFGGLMPDC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x47AB0A0", Offset = "0x47AA2A0", VA = "0x1847AB0A0")]
	public T GEKFEFBGBAB(float GIHFGGLMPDC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T EDACNPEOKKD(T GFINPEICFEL, T ENBAOKALGHB, float GIHFGGLMPDC);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x63CF230", Offset = "0x63CE430", VA = "0x1863CF230", Slot = "4")]
	protected override float EDACNPEOKKD(float GFINPEICFEL, float ENBAOKALGHB, float GIHFGGLMPDC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x63CF270", Offset = "0x63CE470", VA = "0x1863CF270")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xDBA730", Offset = "0xDB9930", VA = "0x180DBA730", Slot = "4")]
	protected override Vector3 EDACNPEOKKD(Vector3 GFINPEICFEL, Vector3 ENBAOKALGHB, float GIHFGGLMPDC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x63D2FB0", Offset = "0x63D21B0", VA = "0x1863D2FB0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x63CDAE0", Offset = "0x63CCCE0", VA = "0x1863CDAE0", Slot = "4")]
	protected override Color EDACNPEOKKD(Color GFINPEICFEL, Color ENBAOKALGHB, float GIHFGGLMPDC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x63CDBA0", Offset = "0x63CCDA0", VA = "0x1863CDBA0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class LINHNFHHMBK : OKKNIKNPDNP<string>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x63D07B0", Offset = "0x63CF9B0", VA = "0x1863D07B0")]
	public LINHNFHHMBK(int EFDILNFHNJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x63D0740", Offset = "0x63CF940", VA = "0x1863D0740", Slot = "6")]
	protected override uint MMCNHIEMPMK(uint ICJNJPHEBHD, string HLCKBKFCMPI)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class HNOJMNGHCGF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly IDisposable LNFBMICMFIL;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public HNOJMNGHCGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct FCPHJKEKAPF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> KGBNODPGJMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int BCMHPKBFMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int GEPAKMIFGGJ;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x38F97A0", Offset = "0x38F89A0", VA = "0x1838F97A0")]
	private FCPHJKEKAPF(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> LDJJOGNIGPH, int OECLGCBKFOD, int IGLBCBEFGEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x38F7CB0", Offset = "0x38F6EB0", VA = "0x1838F7CB0")]
	public static FCPHJKEKAPF<T> EPPBEPCPNMI()
	{
		return default(FCPHJKEKAPF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x38F8420", Offset = "0x38F7620", VA = "0x1838F8420")]
	public (int, int, Task<T>) OKLDHFLHCDF(int MDCNPPDPLHN, [Optional] CancellationToken GILHKFNDIJP, double CNDFBLFAGOA = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x38F75F0", Offset = "0x38F67F0", VA = "0x1838F75F0")]
	public void BLIACNJLBHM(int MDCNPPDPLHN, int IGLBCBEFGEC, [In] T JBENFHJBMMN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class PEIBJBPJKGA
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x63D0EA0", Offset = "0x63D00A0", VA = "0x1863D0EA0")]
	public static FCPHJKEKAPF<PJGNGDCIDLA> EPPBEPCPNMI()
	{
		return default(FCPHJKEKAPF<PJGNGDCIDLA>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x63D0E20", Offset = "0x63D0020", VA = "0x1863D0E20")]
	public static void BLIACNJLBHM([In] this FCPHJKEKAPF<PJGNGDCIDLA> CJKIBFNGPNM, int MDCNPPDPLHN, int IGLBCBEFGEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class HMFDFIFAPCE<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<TKey, TVal> DNLGIBHNNLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly Dictionary<TVal, TKey> NHAABKPBPAH;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int HJGLMCCDDEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x335AF10", Offset = "0x335A110", VA = "0x18335AF10", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool PMLPHGCHDJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ICollection<TKey> IJNLGJPBLGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3576C20", Offset = "0x3575E20", VA = "0x183576C20", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> CAEOEHJHBMA
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3A51FC0", Offset = "0x3A511C0", VA = "0x183A51FC0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal FOFBNHMHKAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x3A51F60", Offset = "0x3A51160", VA = "0x183A51F60", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3A52020", Offset = "0x3A51220", VA = "0x183A52020", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey FOFBNHMHKAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3A518B0", Offset = "0x3A50AB0", VA = "0x183A518B0")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3A51320", Offset = "0x3A50520", VA = "0x183A51320", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3A51DA0", Offset = "0x3A50FA0", VA = "0x183A51DA0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3A512F0", Offset = "0x3A504F0", VA = "0x183A512F0", Slot = "9")]
	public void Add(TKey MNOIAMGNLNL, TVal HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3A512C0", Offset = "0x3A504C0", VA = "0x183A512C0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> OIJOJELHKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3A51380", Offset = "0x3A50580", VA = "0x183A51380", Slot = "8")]
	public bool ContainsKey(TKey MNOIAMGNLNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3A513C0", Offset = "0x3A505C0", VA = "0x183A513C0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> OIJOJELHKIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3A51CB0", Offset = "0x3A50EB0", VA = "0x183A51CB0", Slot = "10")]
	public bool Remove(TKey MNOIAMGNLNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3A51C80", Offset = "0x3A50E80", VA = "0x183A51C80", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> OIJOJELHKIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3A51DF0", Offset = "0x3A50FF0", VA = "0x183A51DF0", Slot = "11")]
	public bool TryGetValue(TKey MNOIAMGNLNL, [Out] TVal HLCKBKFCMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3A519D0", Offset = "0x3A50BD0", VA = "0x183A519D0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3A51440", Offset = "0x3A50640", VA = "0x183A51440", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] HPGKNFECNHG, int HFIJABHHPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3A51980", Offset = "0x3A50B80", VA = "0x183A51980")]
	public bool GMADCLHMMHE(TVal MNOIAMGNLNL, [Out] TKey HLCKBKFCMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3A51B60", Offset = "0x3A50D60", VA = "0x183A51B60")]
	private void IDMCIMEJMKM(TKey MNOIAMGNLNL, TVal LGIDDHPGAND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3A51790", Offset = "0x3A50990", VA = "0x183A51790")]
	private void EEKCLILFHCJ(TKey MNOIAMGNLNL, TVal LGIDDHPGAND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3A51640", Offset = "0x3A50840", VA = "0x183A51640")]
	private bool EAIPGCNLGCJ(TKey MNOIAMGNLNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3A51E30", Offset = "0x3A51030", VA = "0x183A51E30")]
	public HMFDFIFAPCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[DefaultMember("Item")]
public class JOJPHAMDFLJ<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private JOJPHAMDFLJ<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x35F1050", Offset = "0x35F0250", VA = "0x1835F1050", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x35FB7F0", Offset = "0x35FA9F0", VA = "0x1835FB7F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x35FC3A0", Offset = "0x35FB5A0", VA = "0x1835FC3A0")]
		public Enumerator(JOJPHAMDFLJ<T> OPMKPGEDLGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x35F92B0", Offset = "0x35F84B0", VA = "0x1835F92B0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x35FA940", Offset = "0x35F9B40", VA = "0x1835FA940", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x35F8B40", Offset = "0x35F7D40", VA = "0x1835F8B40")]
		private void FNGMCOFGFPD()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private T[] OKMFPJLHBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private int CJICFAPMKCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int HDKNPMMADMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int DHGBHLPPCDP;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int HJGLMCCDDEF
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3D9D4A0", Offset = "0x3D9C6A0", VA = "0x183D9D4A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T FOFBNHMHKAA
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3D9C470", Offset = "0x3D9B670", VA = "0x183D9C470")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x3D9D510", Offset = "0x3D9C710", VA = "0x183D9D510")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3D9DAD0", Offset = "0x3D9CCD0", VA = "0x183D9DAD0")]
	public JOJPHAMDFLJ(int EFDILNFHNJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3D9C980", Offset = "0x3D9BB80", VA = "0x183D9C980")]
	public void LGLNKEHGBKE(T GIHFGGLMPDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3D9BCB0", Offset = "0x3D9AEB0", VA = "0x183D9BCB0")]
	public void BFDHFEEMFPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3D9C550", Offset = "0x3D9B750", VA = "0x183D9C550")]
	public void GOMPHJGKFAJ(int BIFLOKBJAPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3D9D1C0", Offset = "0x3D9C3C0", VA = "0x183D9D1C0")]
	public void MANIPLIBLAI(T[] HPGKNFECNHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3D9C620", Offset = "0x3D9B820", VA = "0x183D9C620")]
	public Enumerator KBKKLBPIAFK()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3D9D990", Offset = "0x3D9CB90", VA = "0x183D9D990", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3D9D990", Offset = "0x3D9CB90", VA = "0x183D9D990", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3D9BDD0", Offset = "0x3D9AFD0", VA = "0x183D9BDD0")]
	private int BKDKDHCJNAK(int PMNHOLIPOMJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3D9D4E0", Offset = "0x3D9C6E0", VA = "0x183D9D4E0")]
	private int PJFIGEMGGCG(int PMNHOLIPOMJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class AENNINMKNDN<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate Task<TResult> MLDDCANCHJO(TRequest DAFMLJPHFGN, CancellationToken GILHKFNDIJP);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public enum NJPGCJKNGGL
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class PHALHMDEOPI
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private const float DPKCJFLEAIK = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TimeSpan GAHLJLMKFJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int LPMOBBAOEMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public NJPGCJKNGGL NFPNDFNEMIK;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static readonly PHALHMDEOPI DNJMIDOFPAJ;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float MKDFAKFJMAL
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x43B0E00", Offset = "0x43B0000", VA = "0x1843B0E00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public TimeSpan LMEFIAAOCEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x43B0EE0", Offset = "0x43B00E0", VA = "0x1843B0EE0")]
		public PHALHMDEOPI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private readonly struct JJLIPAGBOMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly TRequest DAFMLJPHFGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly CancellationToken GILHKFNDIJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly TaskCompletionSource<TResult> ANAAMEIIOFB;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x3D5BC60", Offset = "0x3D5AE60", VA = "0x183D5BC60")]
		public JJLIPAGBOMH(TRequest DAFMLJPHFGN, TaskCompletionSource<TResult> ANAAMEIIOFB, CancellationToken GILHKFNDIJP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct HPILINAAJIF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AENNINMKNDN<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3A5D220", Offset = "0x3A5C420", VA = "0x183A5D220", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x3A5DDC0", Offset = "0x3A5CFC0", VA = "0x183A5DDC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct GHPNNPMELGP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public AENNINMKNDN<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private JJLIPAGBOMH <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x39D43D0", Offset = "0x39D35D0", VA = "0x1839D43D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x39D4EC0", Offset = "0x39D40C0", VA = "0x1839D4EC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly CancellationTokenSource IIKLKNKDFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly List<JJLIPAGBOMH> KICNNBLFCJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly PHALHMDEOPI BCMBKOPNJOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly MLDDCANCHJO MDDFIMBPOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Task DMCHDMIOLGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private int FKPCKAKGNKG;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3BA93B0", Offset = "0x3BA85B0", VA = "0x183BA93B0")]
	public AENNINMKNDN(MLDDCANCHJO MDDFIMBPOOB, [Optional] PHALHMDEOPI BCMBKOPNJOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3BA88F0", Offset = "0x3BA7AF0", VA = "0x183BA88F0")]
	public Task<TResult> MGPLEGDNIEB(TRequest DAFMLJPHFGN, CancellationToken GILHKFNDIJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3BA8440", Offset = "0x3BA7640", VA = "0x183BA8440")]
	private void KPJFPINLGED(JJLIPAGBOMH NFMECJJMMFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3BA7E80", Offset = "0x3BA7080", VA = "0x183BA7E80")]
	[AsyncStateMachine(typeof(AENNINMKNDN<, >.HPILINAAJIF))]
	private Task HEKBIKJINNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3BA8AD0", Offset = "0x3BA7CD0", VA = "0x183BA8AD0")]
	private JJLIPAGBOMH OKAAHGJIGMM()
	{
		return default(JJLIPAGBOMH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3BA8120", Offset = "0x3BA7320", VA = "0x183BA8120")]
	[AsyncStateMachine(typeof(AENNINMKNDN<, >.GHPNNPMELGP))]
	private Task JILOAAOKGKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3BA7AE0", Offset = "0x3BA6CE0", VA = "0x183BA7AE0")]
	private void GJOKBJDHGKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3BA7AA0", Offset = "0x3BA6CA0", VA = "0x183BA7AA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class EAEKJPBBDCO<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly List<T> AIMBMINBCPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private HashSet<T> KJKOPAIODDH;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int HJGLMCCDDEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x335AF10", Offset = "0x335A110", VA = "0x18335AF10", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool PMLPHGCHDJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x811360", Offset = "0x810560", VA = "0x180811360", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public T FOFBNHMHKAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x355E430", Offset = "0x355D630", VA = "0x18355E430", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x355E540", Offset = "0x355D740", VA = "0x18355E540", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x355DB90", Offset = "0x355CD90", VA = "0x18355DB90", Slot = "11")]
	public void Add(T OIJOJELHKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x355DF90", Offset = "0x355D190", VA = "0x18355DF90")]
	public bool KINNJEDKJAM(T OIJOJELHKIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x355E290", Offset = "0x355D490", VA = "0x18355E290", Slot = "15")]
	public bool Remove(T OIJOJELHKIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x355DC80", Offset = "0x355CE80", VA = "0x18355DC80", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x355E320", Offset = "0x355D520", VA = "0x18355E320", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x355DBB0", Offset = "0x355CDB0", VA = "0x18355DBB0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x355DC10", Offset = "0x355CE10", VA = "0x18355DC10", Slot = "13")]
	public bool Contains(T OIJOJELHKIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x355DC50", Offset = "0x355CE50", VA = "0x18355DC50", Slot = "14")]
	public void CopyTo(T[] HPGKNFECNHG, int HFIJABHHPNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x355DD00", Offset = "0x355CF00", VA = "0x18355DD00", Slot = "6")]
	public int IndexOf(T OIJOJELHKIF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x355DE10", Offset = "0x355D010", VA = "0x18355DE10", Slot = "7")]
	public void Insert(int PMNHOLIPOMJ, T OIJOJELHKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x355E040", Offset = "0x355D240", VA = "0x18355E040", Slot = "8")]
	public void RemoveAt(int PMNHOLIPOMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x355E340", Offset = "0x355D540", VA = "0x18355E340")]
	public EAEKJPBBDCO()
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
			[Cpp2IlInjected.Address(RVA = "0x20A47C0", Offset = "0x20A39C0", VA = "0x1820A47C0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x63D2640", Offset = "0x63D1840", VA = "0x1863D2640")]
		public SerializedGuid([In] Guid LDJEJDDHHLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x63D25C0", Offset = "0x63D17C0", VA = "0x1863D25C0")]
		public static SerializedGuid PLKHIDPNAJL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x63D24A0", Offset = "0x63D16A0", VA = "0x1863D24A0")]
		public static SerializedGuid OLJCMMAPPOG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x63D2440", Offset = "0x63D1640", VA = "0x1863D2440")]
		public bool KPPCPAJJDMP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x63D2590", Offset = "0x63D1790", VA = "0x1863D2590", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x63D2510", Offset = "0x63D1710", VA = "0x1863D2510", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x63D2360", Offset = "0x63D1560", VA = "0x1863D2360", Slot = "7")]
		public bool Equals(SerializedGuid JPLJHFMPDFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x63D23A0", Offset = "0x63D15A0", VA = "0x1863D23A0", Slot = "0")]
		public override bool Equals(object CDJAKLIPEBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x63D2430", Offset = "0x63D1630", VA = "0x1863D2430", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x63D2330", Offset = "0x63D1530", VA = "0x1863D2330", Slot = "6")]
		public int CompareTo(SerializedGuid JPLJHFMPDFD)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class JFMIHEJAOBF : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly Type LMDAJPFHGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly string AKJNENABOMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool ONGHCFCPACP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool FCJEAGEAEAP;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x63D0560", Offset = "0x63CF760", VA = "0x1863D0560")]
	public JFMIHEJAOBF(Type BDCLGEPBCIO, string BPFPKFDNKFC, bool MMJEEHLBKGD = false, bool MGNFJMFNIOB = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class CEIEAABKFOO<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public readonly struct ENNOCDKMMGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly long GLBNBBAOIFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly long LJNEEFIFFFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly int MAOMCKGDJBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly int ELGJKHKMFEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly bool NDJCIEPAEDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly string GEDMOLODLHD;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x35A0710", Offset = "0x359F910", VA = "0x1835A0710")]
		public ENNOCDKMMGN(long GLBNBBAOIFI, int MAOMCKGDJBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x35A0780", Offset = "0x359F980", VA = "0x1835A0780")]
		public ENNOCDKMMGN(long GLBNBBAOIFI, long LJNEEFIFFFA, int MAOMCKGDJBJ, int ELGJKHKMFEK, bool NDJCIEPAEDO, string GEDMOLODLHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x35A06C0", Offset = "0x359F8C0", VA = "0x1835A06C0")]
		public int KHIEANLJBAK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x35A06A0", Offset = "0x359F8A0", VA = "0x1835A06A0")]
		public int IJBDMMIGMIE(int IJPACDKEACC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x35A05A0", Offset = "0x359F7A0", VA = "0x1835A05A0")]
		public double EDGMEIGHGPJ()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x35A0600", Offset = "0x359F800", VA = "0x1835A0600")]
		public ENNOCDKMMGN FKAHPEGFLPD(long LJNEEFIFFFA, int ELGJKHKMFEK)
		{
			return default(ENNOCDKMMGN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class DDLAMDHALOK : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private struct CFNEBMOGMFN<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public DDLAMDHALOK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Func<DDLAMDHALOK, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private DDLAMDHALOK <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x4F7F8F0", Offset = "0x4F7EAF0", VA = "0x184F7F8F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x3C8D0F0", Offset = "0x3C8C2F0", VA = "0x183C8D0F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly TKey HCJOAPEDCHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly CEIEAABKFOO<TKey> MPHIGPEIAAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly LBOEGNBEJHN AMPJEKFBOKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private List<DDLAMDHALOK> IAOJCILDMPN;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public string KEHHPJGMCEO
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x5322040", Offset = "0x5321240", VA = "0x185322040")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public IEnumerable<DDLAMDHALOK> NKCCOGCCNBA
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x5322090", Offset = "0x5321290", VA = "0x185322090")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public ENNOCDKMMGN FPKGDHNJFGM
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x5322070", Offset = "0x5321270", VA = "0x185322070")]
			[CompilerGenerated]
			get
			{
				return default(ENNOCDKMMGN);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x53220C0", Offset = "0x53212C0", VA = "0x1853220C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5322420", Offset = "0x5321620", VA = "0x185322420")]
		internal DDLAMDHALOK(CEIEAABKFOO<TKey> MPHIGPEIAAC, TKey MNOIAMGNLNL, LBOEGNBEJHN AMPJEKFBOKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x53222D0", Offset = "0x53214D0", VA = "0x1853222D0")]
		public DDLAMDHALOK HJAHIEMHCII(TKey MNOIAMGNLNL, [Optional] LBOEGNBEJHN? MIKOOEGBEDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x274BE60", Offset = "0x274B060", VA = "0x18274BE60")]
		[AsyncStateMachine(typeof(CFNEBMOGMFN<>))]
		public Task<T> JMKKBEAJFBA<T>(TKey MNOIAMGNLNL, Func<DDLAMDHALOK, Task<T>> IKBJCBBBOIM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x53220F0", Offset = "0x53212F0", VA = "0x1853220F0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class CDGBNNIGDHJ : IEnumerable<(TKey, List<TKey>, ENNOCDKMMGN)>, IEnumerable, IEnumerator<(TKey, List<TKey>, ENNOCDKMMGN)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private (TKey key, List<TKey> path, ENNOCDKMMGN timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public CEIEAABKFOO<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IEnumerator<(TKey key, List<TKey> path, ENNOCDKMMGN timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private (TKey, List<TKey>, ENNOCDKMMGN) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x2099CA0", Offset = "0x2098EA0", VA = "0x182099CA0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, ENNOCDKMMGN));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x4EACE90", Offset = "0x4EAC090", VA = "0x184EACE90", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x2099D90", Offset = "0x2098F90", VA = "0x182099D90")]
		[DebuggerHidden]
		public CDGBNNIGDHJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x3597090", Offset = "0x3596290", VA = "0x183597090", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x4EACA00", Offset = "0x4EABC00", VA = "0x184EACA00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4EAC9B0", Offset = "0x4EABBB0", VA = "0x184EAC9B0")]
		private void BADJBHNLCNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4EACE40", Offset = "0x4EAC040", VA = "0x184EACE40", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x4EACD80", Offset = "0x4EABF80", VA = "0x184EACD80", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, ENNOCDKMMGN)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x388D8E0", Offset = "0x388CAE0", VA = "0x18388D8E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class AIMKKGGOIIB : IEnumerable<(TKey, List<TKey>, ENNOCDKMMGN)>, IEnumerable, IEnumerator<(TKey, List<TKey>, ENNOCDKMMGN)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private (TKey key, List<TKey> path, ENNOCDKMMGN timerEntry) <>2__current;

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
		private DDLAMDHALOK timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public DDLAMDHALOK <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public CEIEAABKFOO<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private IEnumerator<DDLAMDHALOK> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private IEnumerator<(TKey key, List<TKey> path, ENNOCDKMMGN timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, ENNOCDKMMGN) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x2099CA0", Offset = "0x2098EA0", VA = "0x182099CA0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, ENNOCDKMMGN));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x3C8DB00", Offset = "0x3C8CD00", VA = "0x183C8DB00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2099D90", Offset = "0x2098F90", VA = "0x182099D90")]
		[DebuggerHidden]
		public AIMKKGGOIIB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3C8DB60", Offset = "0x3C8CD60", VA = "0x183C8DB60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3C8D1E0", Offset = "0x3C8C3E0", VA = "0x183C8D1E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3C8D180", Offset = "0x3C8C380", VA = "0x183C8D180")]
		private void BADJBHNLCNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3C8D940", Offset = "0x3C8CB40", VA = "0x183C8D940")]
		private void NFKGCPGOKKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3C8DAB0", Offset = "0x3C8CCB0", VA = "0x183C8DAB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3C8D9A0", Offset = "0x3C8CBA0", VA = "0x183C8D9A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, ENNOCDKMMGN)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x3C8DA80", Offset = "0x3C8CC80", VA = "0x183C8DA80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly Action<TKey, ENNOCDKMMGN, LBOEGNBEJHN> MIJKCFHFONF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Action<TKey, ENNOCDKMMGN, LBOEGNBEJHN> KCPHNDFCCLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly Action<CEIEAABKFOO<TKey>, LBOEGNBEJHN> DFJOBBKBHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly LBOEGNBEJHN AMPJEKFBOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly DDLAMDHALOK MBHNLMIKDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private bool NHFBHKGIGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int KLKLMKCEPJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly Stopwatch KPFNMOFLBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly int BHBAHOJJENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string FEBNPKAPHAK;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public DDLAMDHALOK JACLOCPIFBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4E0", Offset = "0x7CA6E0", VA = "0x1807CB4E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	[NotNull]
	public string KEHHPJGMCEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7CBF80", Offset = "0x7CB180", VA = "0x1807CBF80")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x4F7CC80", Offset = "0x4F7BE80", VA = "0x184F7CC80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4F7CF50", Offset = "0x4F7C150", VA = "0x184F7CF50")]
	public CEIEAABKFOO(TKey HDLLJBLFLHJ, LBOEGNBEJHN AMPJEKFBOKH, [Optional] int? MAOMCKGDJBJ, [Optional][CanBeNull] Stopwatch KPFNMOFLBGG, [Optional] Action<TKey, ENNOCDKMMGN, LBOEGNBEJHN> MIJKCFHFONF, [Optional] Action<TKey, ENNOCDKMMGN, LBOEGNBEJHN> KCPHNDFCCLM, [Optional] Action<CEIEAABKFOO<TKey>, LBOEGNBEJHN> DFJOBBKBHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4F7CCE0", Offset = "0x4F7BEE0", VA = "0x184F7CCE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4F7CD70", Offset = "0x4F7BF70", VA = "0x184F7CD70")]
	[IteratorStateMachine(typeof(CEIEAABKFOO<>.CDGBNNIGDHJ))]
	public IEnumerable<(TKey, List<TKey>, ENNOCDKMMGN)> EINIAHPBECB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4F7CE00", Offset = "0x4F7C000", VA = "0x184F7CE00")]
	[IteratorStateMachine(typeof(CEIEAABKFOO<>.AIMKKGGOIIB))]
	private IEnumerable<(TKey, List<TKey>, ENNOCDKMMGN)> EINIAHPBECB(List<TKey> JGJLFCNOJON, DDLAMDHALOK IBPBMNDCFLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4F7CED0", Offset = "0x4F7C0D0", VA = "0x184F7CED0")]
	private (long, int) GFPFEBAOCGF()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public abstract class GPFCPLBFGLH<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut PHCFKHGDDHH(CEIEAABKFOO<TKey> MPHIGPEIAAC);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	protected GPFCPLBFGLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public abstract class IPDLKFAHCMO<TKey> : GPFCPLBFGLH<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate string FDPCMKJIMHD(TKey MNOIAMGNLNL);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3B3A6A0", Offset = "0x3B398A0", VA = "0x183B3A6A0")]
	private static string FHJPACLNBII(TKey MNOIAMGNLNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3B3A6E0", Offset = "0x3B398E0", VA = "0x183B3A6E0", Slot = "4")]
	public override string PHCFKHGDDHH(CEIEAABKFOO<TKey> MPHIGPEIAAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3B3A790", Offset = "0x3B39990", VA = "0x183B3A790")]
	public string PHCFKHGDDHH(CEIEAABKFOO<TKey> MPHIGPEIAAC, [NotNull] FDPCMKJIMHD OCHDFJIFOOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string LIDACODPFDL(CEIEAABKFOO<TKey> MPHIGPEIAAC, [NotNull] FDPCMKJIMHD OCHDFJIFOOE);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x39E8A80", Offset = "0x39E7C80", VA = "0x1839E8A80")]
	protected IPDLKFAHCMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class ILMKFHBMHEH<TKey> : GPFCPLBFGLH<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public delegate string GLMGIMCNKFM(TKey MNOIAMGNLNL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly string PDKOAFMGNEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly double MIBJBEAEMGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly bool CGDPKDCIDGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly int FEOGDPDLBBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly ISet<string> BPINCFHEKPC;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3B20830", Offset = "0x3B1FA30", VA = "0x183B20830")]
	private static string FHJPACLNBII(TKey MNOIAMGNLNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3B20ED0", Offset = "0x3B200D0", VA = "0x183B20ED0")]
	public ILMKFHBMHEH(string PDKOAFMGNEM = "F2", double MIBJBEAEMGL = double.MaxValue, bool CGDPKDCIDGB = false, int FEOGDPDLBBB = int.MaxValue, [Optional] ISet<string> BPINCFHEKPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3B20870", Offset = "0x3B1FA70", VA = "0x183B20870", Slot = "4")]
	public override Dictionary<string, string> PHCFKHGDDHH(CEIEAABKFOO<TKey> MPHIGPEIAAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3B20760", Offset = "0x3B1F960", VA = "0x183B20760")]
	private bool EHLPDLFGGCF(string OCMOGBEBEDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3B20920", Offset = "0x3B1FB20", VA = "0x183B20920")]
	public Dictionary<string, string> PHCFKHGDDHH(CEIEAABKFOO<TKey> MPHIGPEIAAC, GLMGIMCNKFM OCHDFJIFOOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3B20550", Offset = "0x3B1F750", VA = "0x183B20550")]
	private string BBGOEJEAPJC(StringBuilder EJFJIMDIGCN, List<TKey> LOFBKJBKAFO, GLMGIMCNKFM OCHDFJIFOOE, bool FIOCGBCONJP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3B203F0", Offset = "0x3B1F5F0", VA = "0x183B203F0")]
	private static void AJJKEFNEIBL(StringBuilder LPJFNMBGKKE, string JKNIDNCGLKA, bool ODNOKHAJOEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class NNECMOAJEPD<TKey> : IPDLKFAHCMO<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct APNHEDJFNHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public FDPCMKJIMHD keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static NNECMOAJEPD<TKey> LNFBMICMFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly string[] DNEJLODPPFP;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x41CFCE0", Offset = "0x41CEEE0", VA = "0x1841CFCE0")]
	private NNECMOAJEPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x41CECF0", Offset = "0x41CDEF0", VA = "0x1841CECF0", Slot = "5")]
	protected override string LIDACODPFDL(CEIEAABKFOO<TKey> MPHIGPEIAAC, FDPCMKJIMHD OCHDFJIFOOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x41CEC00", Offset = "0x41CDE00", VA = "0x1841CEC00")]
	[CompilerGenerated]
	internal static string LFLIGAKPJNF(string BBKMFHGMLLJ, TKey MNOIAMGNLNL, APNHEDJFNHK P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class NMFDKCNOFEH : CEIEAABKFOO<string>
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class AJOJLEMJNIE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Action<NMFDKCNOFEH, LBOEGNBEJHN> callback;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public AJOJLEMJNIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x63CDA50", Offset = "0x63CCC50", VA = "0x1863CDA50")]
		internal void DCHLLGNBKMP(CEIEAABKFOO<string> timer, LBOEGNBEJHN log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x63D0A10", Offset = "0x63CFC10", VA = "0x1863D0A10")]
	public NMFDKCNOFEH(LBOEGNBEJHN AMPJEKFBOKH, [Optional] string NLDCLHIBPIE, [Optional] int? MAOMCKGDJBJ, [Optional] Stopwatch KPFNMOFLBGG, [Optional] Action<string, ENNOCDKMMGN, LBOEGNBEJHN> MIJKCFHFONF, [Optional] Action<string, ENNOCDKMMGN, LBOEGNBEJHN> KCPHNDFCCLM, [Optional] Action<NMFDKCNOFEH, LBOEGNBEJHN> DFJOBBKBHCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x63D0950", Offset = "0x63CFB50", VA = "0x1863D0950")]
	private static Action<CEIEAABKFOO<string>, LBOEGNBEJHN> HIJPNBIEJMK(Action<NMFDKCNOFEH, LBOEGNBEJHN> GPGHCLCHGND)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class JOIEGDIANEA
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private class NDDHOCNBEPH : JOIEGDIANEA
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public static JOIEGDIANEA LNFBMICMFIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x63D0800", Offset = "0x63CFA00", VA = "0x1863D0800")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override float AHDOEICMPHI
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x8E5D40", Offset = "0x8E4F40", VA = "0x1808E5D40", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x63D0900", Offset = "0x63CFB00", VA = "0x1863D0900")]
		public NDDHOCNBEPH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static JOIEGDIANEA CHOFKKLJEFB;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static JOIEGDIANEA DNJMIDOFPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x63D05D0", Offset = "0x63CF7D0", VA = "0x1863D05D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public abstract float AHDOEICMPHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	protected JOIEGDIANEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface PADMHIBMAFN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool ICKIPDGCPNL
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface AECHCDNEFCI<T> : PADMHIBMAFN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	[NotNull]
	Task<T> OEGABEHMNNB
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	[NotNull]
	PMIHBBCEMHD<T> LFOOOOGFCCG
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class NIMHCEKLNIB
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private sealed class EENCJJDLIGM<T> : ECNPIIPAIGI<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override Task<T?> OEGABEHMNNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override PMIHBBCEMHD<T?> LFOOOOGFCCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x7CB4C0", Offset = "0x7CA6C0", VA = "0x1807CB4C0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x3571900", Offset = "0x3570B00", VA = "0x183571900")]
		public EENCJJDLIGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "10")]
		protected override void HDCKBKCBCAL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private sealed class DPEPPOBPBME<T> : ECNPIIPAIGI<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override Task<T> OEGABEHMNNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override PMIHBBCEMHD<T> LFOOOOGFCCG
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x7CB4C0", Offset = "0x7CA6C0", VA = "0x1807CB4C0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x534C540", Offset = "0x534B740", VA = "0x18534C540")]
		public DPEPPOBPBME(Exception NJNKMHCCCIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "10")]
		protected override void HDCKBKCBCAL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private sealed class BMFNINJIJNI<T> : ECNPIIPAIGI<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private struct NMHMOFKEIFN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public Task<AECHCDNEFCI<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			private TaskAwaiter<AECHCDNEFCI<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x41CC230", Offset = "0x41CB430", VA = "0x1841CC230", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x41CC6E0", Offset = "0x41CB8E0", VA = "0x1841CC6E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private struct KMEDFCPGCKD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public Task<AECHCDNEFCI<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private TaskAwaiter<AECHCDNEFCI<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x3EA57C0", Offset = "0x3EA49C0", VA = "0x183EA57C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x3EA59E0", Offset = "0x3EA4BE0", VA = "0x183EA59E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly Task<AECHCDNEFCI<T>> OHMKOHDOGHJ;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override Task<T> OEGABEHMNNB
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x7CB4C0", Offset = "0x7CA6C0", VA = "0x1807CB4C0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override PMIHBBCEMHD<T> LFOOOOGFCCG
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x7CB520", Offset = "0x7CA720", VA = "0x1807CB520", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x4B02AD0", Offset = "0x4B01CD0", VA = "0x184B02AD0")]
		public BMFNINJIJNI(Task<AECHCDNEFCI<T>> IKEBALIIPCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x4B02820", Offset = "0x4B01A20", VA = "0x184B02820", Slot = "10")]
		protected override void HDCKBKCBCAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x4B028A0", Offset = "0x4B01AA0", VA = "0x184B028A0")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(BMFNINJIJNI<>.NMHMOFKEIFN))]
		internal static Task<T> HJLHEBDIJLC(Task<AECHCDNEFCI<T>> IKEBALIIPCC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x4B029F0", Offset = "0x4B01BF0", VA = "0x184B029F0")]
		[AsyncStateMachine(typeof(BMFNINJIJNI<>.KMEDFCPGCKD))]
		[CompilerGenerated]
		internal static Task KJIBLNIHDFC(Task<AECHCDNEFCI<T>> IKEBALIIPCC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2AC6B10", Offset = "0x2AC5D10", VA = "0x182AC6B10")]
	public static AECHCDNEFCI<T> NECMJGIIDLF<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2803900", Offset = "0x2802B00", VA = "0x182803900")]
	public static AECHCDNEFCI<T> JHEDLLEKBIK<T>(Exception NJNKMHCCCIB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2803900", Offset = "0x2802B00", VA = "0x182803900")]
	public static AECHCDNEFCI<T> CEMINHGEHOK<T>(Task<AECHCDNEFCI<T>> IKEBALIIPCC) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public abstract class ECNPIIPAIGI<T> : AECHCDNEFCI<T>, PADMHIBMAFN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly string DPODHJABPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly BPDAEKAOABP PDPBCADDGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private bool NHFBHKGIGAE;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool ICKIPDGCPNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xABF9C0", Offset = "0xABEBC0", VA = "0x180ABF9C0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public abstract Task<T> OEGABEHMNNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public abstract PMIHBBCEMHD<T> LFOOOOGFCCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x356F6C0", Offset = "0x356E8C0", VA = "0x18356F6C0")]
	public ECNPIIPAIGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x356F3E0", Offset = "0x356E5E0", VA = "0x18356F3E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void HDCKBKCBCAL();
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public abstract class BKKJNNHIJLF<TTask, T> : ECNPIIPAIGI<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class CIFGIFKIIFG
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
			public CIFGIFKIIFG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x334A810", Offset = "0x3349A10", VA = "0x18334A810", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x334AAD0", Offset = "0x3349CD0", VA = "0x18334AAD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public BKKJNNHIJLF<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public CIFGIFKIIFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x4F8FD30", Offset = "0x4F8EF30", VA = "0x184F8FD30")]
		[AsyncStateMachine(typeof(BKKJNNHIJLF<, >.CIFGIFKIIFG.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> FIGJANFCAKI(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly Task<T> IKEBALIIPCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	protected readonly CancellationTokenSource IDLLPIFDGKP;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public override Task<T> OEGABEHMNNB
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public override PMIHBBCEMHD<T> LFOOOOGFCCG
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4C0", Offset = "0x7CA6C0", VA = "0x1807CB4C0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x4AFA4E0", Offset = "0x4AF96E0", VA = "0x184AFA4E0")]
	protected BKKJNNHIJLF(TTask IKEBALIIPCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x4AFA2D0", Offset = "0x4AF94D0", VA = "0x184AFA2D0", Slot = "10")]
	protected override void HDCKBKCBCAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T PGALNOAKNOM(TTask PEBEKNPNJIF);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void DKANOOPFGPL();
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class DFAPLDIKLNK<T> : ECNPIIPAIGI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly PHKGJMALLOJ<Task<T>> JGBADNLPAOE;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public override Task<T> OEGABEHMNNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x3E694E0", Offset = "0x3E686E0", VA = "0x183E694E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public override PMIHBBCEMHD<T> LFOOOOGFCCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4C0", Offset = "0x7CA6C0", VA = "0x1807CB4C0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x5328A50", Offset = "0x5327C50", VA = "0x185328A50")]
	public DFAPLDIKLNK(PHKGJMALLOJ<Task<T>> LCNLBNAMNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x5328A30", Offset = "0x5327C30", VA = "0x185328A30", Slot = "10")]
	protected override void HDCKBKCBCAL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class IBFGALEBFKK
{
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x63CF4B0", Offset = "0x63CE6B0", VA = "0x1863CF4B0")]
	[NotNull]
	public static byte[] MPLHKNFPKBJ(this BKLFMNKEDBP GMGJPGNBIMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x63CF520", Offset = "0x63CE720", VA = "0x1863CF520")]
	[NotNull]
	public static byte[] MPLHKNFPKBJ(this BKLFMNKEDBP GMGJPGNBIMP, HashAlgorithmName PBCCEOCBAGC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x63CF590", Offset = "0x63CE790", VA = "0x1863CF590")]
	public static bool OPBFGCHAOBG([CanBeNull] this BKLFMNKEDBP GMGJPGNBIMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x63CF720", Offset = "0x63CE920", VA = "0x1863CF720")]
	public static bool OPBFGCHAOBG([CanBeNull] this BKLFMNKEDBP GMGJPGNBIMP, [Out] string KFNIFKKFLAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x63CF390", Offset = "0x63CE590", VA = "0x1863CF390")]
	private static bool DDNHCDBGCHJ([NotNull] BKLFMNKEDBP GMGJPGNBIMP, [Out][CanBeNull] byte[] AILEBEIBDAM, [Out][CanBeNull] byte[] NIILFOADEAM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class OECLHBPDKHG
{
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x63D0BE0", Offset = "0x63CFDE0", VA = "0x1863D0BE0")]
	[NotNull]
	public static byte[] MPLHKNFPKBJ(this NMOOGDEEBPF AOMGBBMAADF, HashAlgorithmName PBCCEOCBAGC, byte[] LBMAMKFALJM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface NMOOGDEEBPF
{
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash ICJNJPHEBHD);
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface BKLFMNKEDBP : NMOOGDEEBPF
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	[CanBeNull]
	byte[] NNLANHFPLNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	[CanBeNull]
	byte[] GHCNGMGLPGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class IKCBBNFGHPG
{
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static readonly ArrayPool<byte> LBJBBKHHFPO;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static bool MJFCCCMEMEJ;

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x29DD2A0", Offset = "0x29DC4A0", VA = "0x1829DD2A0")]
	public static void LCIAJGKFELE<T>(this IncrementalHash NCGLKBDAKFO, [CanBeNull] T NPBKACHANBH) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x29DCCF0", Offset = "0x29DBEF0", VA = "0x1829DCCF0")]
	public static void GPGPAJNALFM<T>(this IncrementalHash NCGLKBDAKFO, [CanBeNull] T AOMGBBMAADF) where T : NMOOGDEEBPF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x29DCD80", Offset = "0x29DBF80", VA = "0x1829DCD80")]
	public static void KGKMNAAKJOC<T>(this IncrementalHash NCGLKBDAKFO, [CanBeNull] IList<T> GHMHFDALGAE) where T : NMOOGDEEBPF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x63D0000", Offset = "0x63CF200", VA = "0x1863D0000")]
	private static bool MKDJLFIDJDE([CanBeNull] NMOOGDEEBPF AOMGBBMAADF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x63D0090", Offset = "0x63CF290", VA = "0x1863D0090")]
	public static void MMEKOGHEEJA(this IncrementalHash ICJNJPHEBHD, [CanBeNull] string OBKELHHDLGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x63D0220", Offset = "0x63CF420", VA = "0x1863D0220")]
	public static void OBGBEEMPCCK(this IncrementalHash ICJNJPHEBHD, long MPKEJLAJCIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x63CFC60", Offset = "0x63CEE60", VA = "0x1863CFC60")]
	public static void FGDOINLEDCG(this IncrementalHash ICJNJPHEBHD, int ONFJHEJKFFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x63CF8C0", Offset = "0x63CEAC0", VA = "0x1863CF8C0")]
	public static void AJJGCFMFMHG(this IncrementalHash ICJNJPHEBHD, short NMFGOOACKMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x63CFE90", Offset = "0x63CF090", VA = "0x1863CFE90")]
	public static void HEOJILBPDGO(this IncrementalHash ICJNJPHEBHD, byte MIDDFHFOFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x63CFAF0", Offset = "0x63CECF0", VA = "0x1863CFAF0")]
	public static void CFAKNHGDBLF(this IncrementalHash ICJNJPHEBHD, bool FLKNEAHMNDB, bool OHENHNFKPKM = false, bool JPJOOCLKFME = false, bool BOJNDPEGOPE = false, bool GDFNKBOIPBG = false, bool HHLOPKLIADO = false, bool JAGENFIBJHM = false, bool PGKEELNPIKL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x29DC6C0", Offset = "0x29DB8C0", VA = "0x1829DC6C0")]
	public static void FEBJFFDAPIF<T>(this IncrementalHash ICJNJPHEBHD, T GAPFLOIFLPD) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x63CFFA0", Offset = "0x63CF1A0", VA = "0x1863CFFA0")]
	public static void LLOCIKEHCCM(this IncrementalHash ICJNJPHEBHD, float HAONDFJFPAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x63CFA90", Offset = "0x63CEC90", VA = "0x1863CFA90")]
	public static void CBMODCODFAD(this IncrementalHash ICJNJPHEBHD, ulong GGDLLKCNJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x63CFE30", Offset = "0x63CF030", VA = "0x1863CFE30")]
	public static void FMAFGJHNFCI(this IncrementalHash ICJNJPHEBHD, uint BPOGFLNCGNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x63D03F0", Offset = "0x63CF5F0", VA = "0x1863D03F0")]
	public static void PGPDOEGAMAC(this IncrementalHash ICJNJPHEBHD, ushort HHEGINJMMNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x63D00F0", Offset = "0x63CF2F0", VA = "0x1863D00F0")]
	public static void NKBPCNHHPIF(this IncrementalHash ICJNJPHEBHD, Vector3 FEIGGLALIHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class GHALAIAOPHJ : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x63CF2B0", Offset = "0x63CE4B0", VA = "0x1863CF2B0")]
	public GHALAIAOPHJ(string PPGBBBOBJLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class PCACPNCKIPH<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	internal class PEMKMHLEPBF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public TNode CJKIBFNGPNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public TNode BGILIGANMHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public GJCAOKHLLGM OFDCFOKBLAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public List<GJCAOKHLLGM> FGPKPEMHKLC;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public PEMKMHLEPBF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal struct GJCAOKHLLGM : IComparable<GJCAOKHLLGM>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int GMDNJIBGHKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public TClaimant INPDNANLNIH;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xCE5780", Offset = "0xCE4980", VA = "0x180CE5780")]
		public GJCAOKHLLGM(int GMDNJIBGHKH, TClaimant INPDNANLNIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x39D5840", Offset = "0x39D4A40", VA = "0x1839D5840")]
		public bool JFMIBDHDGOP([In] GJCAOKHLLGM JPLJHFMPDFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x39D58A0", Offset = "0x39D4AA0", VA = "0x1839D58A0")]
		public bool POBPLDMLDJK([In] GJCAOKHLLGM JPLJHFMPDFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x39D5830", Offset = "0x39D4A30", VA = "0x1839D5830", Slot = "4")]
		public int CompareTo(GJCAOKHLLGM JPLJHFMPDFD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x39D58B0", Offset = "0x39D4AB0", VA = "0x1839D58B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public enum AHPNFLKAPCF
	{
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class ALAIFNNDHBD : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public PCACPNCKIPH<TClaimant, TNode> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x828B00", Offset = "0x827D00", VA = "0x180828B00")]
		[DebuggerHidden]
		public ALAIFNNDHBD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3D63B10", Offset = "0x3D62D10", VA = "0x183D63B10", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3D63CD0", Offset = "0x3D62ED0", VA = "0x183D63CD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3D63BF0", Offset = "0x3D62DF0", VA = "0x183D63BF0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x3886C80", Offset = "0x3885E80", VA = "0x183886C80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly PBINHHMDMKA<PEMKMHLEPBF> CMMFNGGBLEK;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly PBINHHMDMKA<List<GJCAOKHLLGM>> GOILOOEJBHD;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static int OHGAPKJPOKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	internal readonly Dictionary<TClaimant, TNode> JOPLIIEIKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	internal readonly Dictionary<TNode, PEMKMHLEPBF> FCMCFNDKIDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private AHPNFLKAPCF CKIGLEMFOLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private bool JOHIIOJDHKN;

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode OKIAIBIAEDD(TNode BKOKOKIHONK);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void EJHHOIDFGII(TNode BKOKOKIHONK, TClaimant DOPNEOEINOA, TClaimant JGHLINGLHME);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x43A6DA0", Offset = "0x43A5FA0", VA = "0x1843A6DA0")]
	public PCACPNCKIPH(AHPNFLKAPCF CKIGLEMFOLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x43A6B60", Offset = "0x43A5D60", VA = "0x1843A6B60")]
	public void OKNDGCCOKKF(TNode BKOKOKIHONK, TNode KFDAFHAJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x43A6A40", Offset = "0x43A5C40", VA = "0x1843A6A40")]
	public void OKJFIKPMEGA(TClaimant INPDNANLNIH, TNode NEFLJMCLPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x43A5BD0", Offset = "0x43A4DD0", VA = "0x1843A5BD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x43A5B30", Offset = "0x43A4D30", VA = "0x1843A5B30")]
	private void BMOIDGDDIHM(TClaimant INPDNANLNIH, TNode KFCOJAMPDIF, TNode NEFLJMCLPJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x43A5D80", Offset = "0x43A4F80", VA = "0x1843A5D80")]
	private int EBLEEBDMKLL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x43A64B0", Offset = "0x43A56B0", VA = "0x1843A64B0")]
	private void NFGMJCLLLLP(TClaimant INPDNANLNIH, TNode DLIHLPEIGHK, TNode JIHELKOFMCM, int PBFCBHDODCE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x43A68B0", Offset = "0x43A5AB0", VA = "0x1843A68B0")]
	private void NLPOPAPCDBA(GJCAOKHLLGM KCLMPAFNKLL, PEMKMHLEPBF FDAEAIELBEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x43A5DF0", Offset = "0x43A4FF0", VA = "0x1843A5DF0")]
	private void HPDNNDGMOAN(TClaimant INPDNANLNIH, TNode DLIHLPEIGHK, TNode JIHELKOFMCM, int PBFCBHDODCE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x43A6930", Offset = "0x43A5B30", VA = "0x1843A6930")]
	private void NPFEAOIEPMG(GJCAOKHLLGM KCLMPAFNKLL, TNode BKOKOKIHONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x43A60B0", Offset = "0x43A52B0", VA = "0x1843A60B0")]
	private void JMMIADOEIDG(GJCAOKHLLGM KCLMPAFNKLL, PEMKMHLEPBF FDAEAIELBEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x43A5A10", Offset = "0x43A4C10", VA = "0x1843A5A10")]
	private void BEGKOMGFBOP(PEMKMHLEPBF FDAEAIELBEG, bool KOCAPFCFDHF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x43A6190", Offset = "0x43A5390", VA = "0x1843A6190")]
	private void KBICMGHFJFJ(PEMKMHLEPBF FDAEAIELBEG, TNode KFDAFHAJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x43A57E0", Offset = "0x43A49E0", VA = "0x1843A57E0")]
	[IteratorStateMachine(typeof(PCACPNCKIPH<, >.ALAIFNNDHBD))]
	private IEnumerable<TNode> APOGIIJNBCA(TNode DLIHLPEIGHK, TNode JIHELKOFMCM, bool AGOGPIKEAJB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x43A67D0", Offset = "0x43A59D0", VA = "0x1843A67D0")]
	private PEMKMHLEPBF NHLOKFPIFDI(TNode BKOKOKIHONK, TNode BGILIGANMHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x43A58B0", Offset = "0x43A4AB0", VA = "0x1843A58B0")]
	private PEMKMHLEPBF BDMJMOLOKGD(TNode BKOKOKIHONK, TNode BGILIGANMHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x43A5680", Offset = "0x43A4880", VA = "0x1843A5680")]
	private void ALAEPMMMDEA(PEMKMHLEPBF FDAEAIELBEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class OKKNIKNPDNP<T> : IEnumerable<OKKNIKNPDNP<T>.LNBICDHBNNB>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct LNBICDHBNNB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public T HLCKBKFCMPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int PMNHOLIPOMJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public class DHKFEICNIFA : IEnumerator<LNBICDHBNNB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private OKKNIKNPDNP<T> DAEGLAIOHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private int PMNHOLIPOMJ;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x35AB710", Offset = "0x35AA910", VA = "0x1835AB710", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public LNBICDHBNNB NPODDCIDCOP
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x53380B0", Offset = "0x53372B0", VA = "0x1853380B0", Slot = "4")]
			get
			{
				return default(LNBICDHBNNB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x5337FC0", Offset = "0x53371C0", VA = "0x185337FC0")]
		public DHKFEICNIFA(OKKNIKNPDNP<T> DAEGLAIOHBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x5337EC0", Offset = "0x53370C0", VA = "0x185337EC0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x35FDAC0", Offset = "0x35FCCC0", VA = "0x1835FDAC0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x883260", Offset = "0x882460", VA = "0x180883260", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private struct IBJANBIFPEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public bool FKKDMNDDNPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public T HLCKBKFCMPI;
	}

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private const int PALPKOHLAKE = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly Dictionary<T, int> OOBJBDOJBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private IBJANBIFPEK[] KHFFCNDAMKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int MNDILAIEMLI;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int AEDMPKICCMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x807FC0", Offset = "0x8071C0", VA = "0x180807FC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x807560", Offset = "0x806760", VA = "0x180807560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int HJGLMCCDDEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x335AF10", Offset = "0x335A110", VA = "0x18335AF10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x429E110", Offset = "0x429D310", VA = "0x18429E110")]
	public OKKNIKNPDNP(int EFDILNFHNJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x429DD60", Offset = "0x429CF60", VA = "0x18429DD60")]
	public OKKNIKNPDNP(LNBICDHBNNB[] MNMNJMECEND, bool LKGAMIPMJGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x429CF50", Offset = "0x429C150", VA = "0x18429CF50")]
	public int JLCPJBDNLKC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x429D680", Offset = "0x429C880", VA = "0x18429D680")]
	private int LJJIMFJGNNI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x429D850", Offset = "0x429CA50", VA = "0x18429D850", Slot = "6")]
	protected virtual uint MMCNHIEMPMK(uint ICJNJPHEBHD, T HLCKBKFCMPI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x429D8E0", Offset = "0x429CAE0", VA = "0x18429D8E0")]
	public bool MOEHHAADCEC(T HLCKBKFCMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x429CDE0", Offset = "0x429BFE0", VA = "0x18429CDE0")]
	public int HLHMOABNCIK(T HLCKBKFCMPI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x429CD70", Offset = "0x429BF70", VA = "0x18429CD70")]
	public T DJMFFBCEIIA(int PMNHOLIPOMJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x429D010", Offset = "0x429C210", VA = "0x18429D010")]
	public bool KINNJEDKJAM(T HLCKBKFCMPI, bool BFMOKDDJKKD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x429D2B0", Offset = "0x429C4B0", VA = "0x18429D2B0")]
	public bool KINNJEDKJAM(T HLCKBKFCMPI, int PMNHOLIPOMJ, bool BFMOKDDJKKD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x429CEB0", Offset = "0x429C0B0", VA = "0x18429CEB0")]
	private int HPPJBEGNPLI(int CJICFAPMKCE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x429D930", Offset = "0x429CB30", VA = "0x18429D930", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x429D930", Offset = "0x429CB30", VA = "0x18429D930", Slot = "4")]
	private IEnumerator<LNBICDHBNNB> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class PBINHHMDMKA<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly Stack<T> EIJNFEGGOBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly List<T> PKOCOMINHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly int GMDCONKJECK;

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x43A0860", Offset = "0x439FA60", VA = "0x1843A0860")]
	public static PBINHHMDMKA<T> PFIEPOIBIOG(int EFDILNFHNJD = 0, int GMDCONKJECK = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x43A0350", Offset = "0x439F550", VA = "0x1843A0350")]
	public static PBINHHMDMKA<T> AGJCLAJLBIN(int EFDILNFHNJD = 0, int GMDCONKJECK = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x43A0B50", Offset = "0x439FD50", VA = "0x1843A0B50")]
	public PBINHHMDMKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x43A0B80", Offset = "0x439FD80", VA = "0x1843A0B80")]
	public PBINHHMDMKA(int EFDILNFHNJD, int GMDCONKJECK = int.MaxValue, bool ICFNCNPDEEE = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x43A0700", Offset = "0x439F900", VA = "0x1843A0700")]
	public T ENFMDAGMBIP()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x43A0430", Offset = "0x439F630", VA = "0x1843A0430")]
	public void BNPNHCAJEDK(T HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x43A0500", Offset = "0x439F700", VA = "0x1843A0500")]
	private void DEMCHPEPEOK(T HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x43A0B30", Offset = "0x439FD30", VA = "0x1843A0B30")]
	private void PPCCGONFHJD(T HLCKBKFCMPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x43A05D0", Offset = "0x439F7D0", VA = "0x1843A05D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x43A0940", Offset = "0x439FB40", VA = "0x1843A0940")]
	private void PKCIFEOFOOF(IEnumerable<T> IJMHBFBFIEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class GCCGNEKGONF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private Dictionary<int, T> FAEHLNLHLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private T HLPDBGNLLEB;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual T NFLGCDKNBEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF80", Offset = "0x7CA180", VA = "0x1807CAF80", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x39A5EA0", Offset = "0x39A50A0", VA = "0x1839A5EA0")]
	public bool BACMHJHBCMI(T HLCKBKFCMPI, int GMDNJIBGHKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x39A4F70", Offset = "0x39A4170", VA = "0x1839A4F70")]
	public bool ADCGPDBINPA(int GMDNJIBGHKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x39A6120", Offset = "0x39A5320", VA = "0x1839A6120")]
	public T OCCFGLMLPOK(int BJEOCEHNKKD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x39A5DA0", Offset = "0x39A4FA0", VA = "0x1839A5DA0")]
	private bool ACCAPBCDEAH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x39A5F10", Offset = "0x39A5110", VA = "0x1839A5F10")]
	public bool GMADCLHMMHE(int GMDNJIBGHKH, [Out] T HLCKBKFCMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x39A62F0", Offset = "0x39A54F0", VA = "0x1839A62F0")]
	public GCCGNEKGONF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class IAFPHJBKLDL<T>
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	protected struct AIMBOEINNAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public T OGADOHBOMGE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public int BBINAIMCLEP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	protected readonly List<AIMBOEINNAD> OKMFPJLHBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private T IFKNFBNBHHP;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int HJGLMCCDDEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x335AF10", Offset = "0x335A110", VA = "0x18335AF10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x3AFE550", Offset = "0x3AFD750", VA = "0x183AFE550")]
	public bool EJPMGDOHJOE(T HLCKBKFCMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x3AFE9E0", Offset = "0x3AFDBE0", VA = "0x183AFE9E0")]
	public void LGLNKEHGBKE(T HLCKBKFCMPI, int GMDNJIBGHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x3AFE0E0", Offset = "0x3AFD2E0", VA = "0x183AFE0E0")]
	public bool BIFLKBKPGJE(T HLCKBKFCMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x3AFDF50", Offset = "0x3AFD150", VA = "0x183AFDF50")]
	public void BFDHFEEMFPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x3AFE8D0", Offset = "0x3AFDAD0", VA = "0x183AFE8D0")]
	public T LCFHGHJIAEE()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x3AFE3F0", Offset = "0x3AFD5F0", VA = "0x183AFE3F0")]
	protected void DFOEEEIBPKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x3AFEAF0", Offset = "0x3AFDCF0", VA = "0x183AFEAF0")]
	public IAFPHJBKLDL()
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
		[EOOIALGHMHP(LIEGAMPPNDC.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x63D1030", Offset = "0x63D0230", VA = "0x1863D1030")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x63D1300", Offset = "0x63D0500", VA = "0x1863D1300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x63D1210", Offset = "0x63D0410", VA = "0x1863D1210")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x63D0F80", Offset = "0x63D0180", VA = "0x1863D0F80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x63D1250", Offset = "0x63D0450", VA = "0x1863D1250")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x63D1160", Offset = "0x63D0360", VA = "0x1863D1160")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x63D0EF0", Offset = "0x63D00F0", VA = "0x1863D0EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4578D30", Offset = "0x4577F30", VA = "0x184578D30", Slot = "4")]
		public virtual T COOKIBMKDCK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class DGOMHMEIIEK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private Dictionary<byte, FLIDKOAKGNK> FAPJDJAKHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly PBINHHMDMKA<FLIDKOAKGNK> AOGAMIEADHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly bool AIGHCGJNBIC;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public FLIDKOAKGNK BIEMGLHOPNC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4D0", Offset = "0x7CA6D0", VA = "0x1807CB4D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public Vector2 MBHNBFAPDIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xC74330", Offset = "0xC73530", VA = "0x180C74330")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xF4D170", Offset = "0xF4C370", VA = "0x180F4D170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private Vector2 BDGGOMABOAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xFAC1D0", Offset = "0xFAB3D0", VA = "0x180FAC1D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public Vector2 EMOGMAFCKLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x63CE6D0", Offset = "0x63CD8D0", VA = "0x1863CE6D0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7CEA90", Offset = "0x7CDC90", VA = "0x1807CEA90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public int MJLPDHCDDHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7D45E0", Offset = "0x7D37E0", VA = "0x1807D45E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7D47D0", Offset = "0x7D39D0", VA = "0x1807D47D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x63CEB70", Offset = "0x63CDD70", VA = "0x1863CEB70")]
	public DGOMHMEIIEK(Bounds PMDEHPLNJGH, Vector2[] FNLKCCLMDMH, int JJOONLANBJJ, byte CJICFAPMKCE, float ELJNADBEGIK = 0f, [Optional] PBINHHMDMKA<FLIDKOAKGNK> AOGAMIEADHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x63CE010", Offset = "0x63CD210", VA = "0x1863CE010")]
	public void IGIFHDDLJHI(Bounds PMDEHPLNJGH, Vector2[] FNLKCCLMDMH, int JJOONLANBJJ, byte CJICFAPMKCE, float ELJNADBEGIK = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x63CDCC0", Offset = "0x63CCEC0", VA = "0x1863CDCC0")]
	public FLIDKOAKGNK HAHGGDFABCE(byte PMNHOLIPOMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x63CE6F0", Offset = "0x63CD8F0", VA = "0x1863CE6F0")]
	public void NACDNGDCJGJ(Vector3 CAOOPLKANIG, float LJMAOHMOGDN, float JKEINGGJLNF, List<byte> HLJCCEDOLBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x63CDBE0", Offset = "0x63CCDE0", VA = "0x1863CDBE0")]
	public void CCGDJMHFKGN(FLIDKOAKGNK.GIFFMEOCBFB MDMKMILIAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x63CDF20", Offset = "0x63CD120", VA = "0x1863CDF20")]
	public static int HMBENMJBKHG(Vector2[] FNLKCCLMDMH, int JJOONLANBJJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x63CDD20", Offset = "0x63CCF20", VA = "0x1863CDD20")]
	private FLIDKOAKGNK HGMANPCMNMM(byte PMNHOLIPOMJ, FLIDKOAKGNK.FMMGLCNMBJC CCJLKFFNOMG, FLIDKOAKGNK BGILIGANMHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x63CE7C0", Offset = "0x63CD9C0", VA = "0x1863CE7C0")]
	private void OGIPELBFEMH(FLIDKOAKGNK BGILIGANMHA, Vector2[] FNLKCCLMDMH, int JLFDDAFBHAE, int LDNEOIOLHEB, int NBHGMKNAPIP, int EHGEHKNEJLE, float ELJNADBEGIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x63CE4B0", Offset = "0x63CD6B0", VA = "0x1863CE4B0")]
	private void JDKMOGMIAIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x63CDC00", Offset = "0x63CCE00", VA = "0x1863CDC00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x63CDC60", Offset = "0x63CCE60", VA = "0x1863CDC60", Slot = "1")]
	~DGOMHMEIIEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class FLIDKOAKGNK
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public enum FMMGLCNMBJC
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public enum GIFFMEOCBFB
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
	public byte ALHOENKOJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public Vector3 EPIBGOODDAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public Vector3 BGCPNAGJMOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public Vector3 CGJDKHDLCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public Vector3 HFCCOBNDKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public FMMGLCNMBJC ENPEABPKALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public FLIDKOAKGNK DPGEGBIPNMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public List<FLIDKOAKGNK> BCFMKEIPKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public bool FIEMFELPJDN;

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x63CF210", Offset = "0x63CE410", VA = "0x1863CF210")]
	public FLIDKOAKGNK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x63CEE30", Offset = "0x63CE030", VA = "0x1863CEE30")]
	public void HDOMKOPCCKF(FLIDKOAKGNK POGNIHKEPMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0")]
	public void CCGDJMHFKGN(int KCHDFINIMGA, GIFFMEOCBFB MDMKMILIAKN, int JMMNCBCPEMF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x63CEFB0", Offset = "0x63CE1B0", VA = "0x1863CEFB0")]
	public void NACDNGDCJGJ(List<byte> HLJCCEDOLBL, Vector3 CAOOPLKANIG, float LJMAOHMOGDN, float JKEINGGJLNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x63CEF50", Offset = "0x63CE150", VA = "0x1863CEF50")]
	public bool ICFNDEGOHDF(Vector3 OGPMBFEEKPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x63CEF80", Offset = "0x63CE180", VA = "0x1863CEF80")]
	public bool IEIDOPMIGIM(Vector3 OGPMBFEEKPH, float EJJMALEOELB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x63CEDA0", Offset = "0x63CDFA0", VA = "0x1863CEDA0")]
	public void CNOOLEDIEBH()
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
		public struct GFBAGLNANPE<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			private readonly List<Component> AIMBMINBCPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			private readonly bool AAFOLPMPCIH;

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x3906230", Offset = "0x3905430", VA = "0x183906230")]
			public GFBAGLNANPE(List<Component> AIMBMINBCPM, bool AAFOLPMPCIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x39C80D0", Offset = "0x39C72D0", VA = "0x1839C80D0")]
			public OBJFHFHBFMK<T> KBKKLBPIAFK()
			{
				return default(OBJFHFHBFMK<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x39C8130", Offset = "0x39C7330", VA = "0x1839C8130", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x39C8130", Offset = "0x39C7330", VA = "0x1839C8130", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		public struct OBJFHFHBFMK<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			private readonly List<Component> AIMBMINBCPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			private readonly bool AAFOLPMPCIH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			private int PMNHOLIPOMJ;

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public T NPODDCIDCOP
			{
				[Cpp2IlInjected.Token(Token = "0x60001F9")]
				[Cpp2IlInjected.Address(RVA = "0x42824C0", Offset = "0x42816C0", VA = "0x1842824C0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001FA")]
				[Cpp2IlInjected.Address(RVA = "0x4282450", Offset = "0x4281650", VA = "0x184282450", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x4282490", Offset = "0x4281690", VA = "0x184282490")]
			public OBJFHFHBFMK(List<Component> AIMBMINBCPM, bool AAFOLPMPCIH)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x4282390", Offset = "0x4281590", VA = "0x184282390", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x42823A0", Offset = "0x42815A0", VA = "0x1842823A0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x35F1150", Offset = "0x35F0350", VA = "0x1835F1150", Slot = "8")]
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
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x63D2B80", Offset = "0x63D1D80", VA = "0x1863D2B80")]
		private void CNOOLEDIEBH(GameObject KGIANBEAMHM, bool LBPGAAMAJKE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x63D29C0", Offset = "0x63D1BC0", VA = "0x1863D29C0")]
		public static void CNOOLEDIEBH(GameObject KGIANBEAMHM, ToolHierarchyCache JFCCHECKCHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x2C64E80", Offset = "0x2C64080", VA = "0x182C64E80")]
		public void GHDNIIKDGFH<T>(Action<T> BGMBJALDBDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x2C650A0", Offset = "0x2C642A0", VA = "0x182C650A0")]
		public T OFCJDLJLOHD<T>(bool AAFOLPMPCIH = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x2C64DC0", Offset = "0x2C63FC0", VA = "0x182C64DC0")]
		public GFBAGLNANPE<T> FAIJOFFANBM<T>(bool AAFOLPMPCIH = false) where T : class
		{
			return default(GFBAGLNANPE<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x63D2670", Offset = "0x63D1870", VA = "0x1863D2670")]
		public List<Component> CLONCDNIKOP(Type HHJOOHJDNNM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x63D2CF0", Offset = "0x63D1EF0", VA = "0x1863D2CF0", Slot = "4")]
		public bool Equals(ToolHierarchyCache DCHJALFCEJF, ToolHierarchyCache JFJIMNMJLJE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x63D2D70", Offset = "0x63D1F70", VA = "0x1863D2D70", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache CDJAKLIPEBF)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class MGMMGMGGKII<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private int EFDILNFHNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private int IAPEFBNMKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private List<T> JMAHFBFPIEP;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int HJGLMCCDDEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3E694E0", Offset = "0x3E686E0", VA = "0x183E694E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public T DNHMKPKJANF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x4134160", Offset = "0x4133360", VA = "0x184134160")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public T CFLGKKMEMHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x4133E80", Offset = "0x4133080", VA = "0x184133E80")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public T NOPILBPAPOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x4133D50", Offset = "0x4132F50", VA = "0x184133D50")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x41342C0", Offset = "0x41334C0", VA = "0x1841342C0")]
	public MGMMGMGGKII(int EFDILNFHNJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x4134020", Offset = "0x4133220", VA = "0x184134020")]
	public void LGLNKEHGBKE(T HLMBEKDALBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x4133CC0", Offset = "0x4132EC0", VA = "0x184133CC0")]
	public void BFDHFEEMFPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x4133DC0", Offset = "0x4132FC0", VA = "0x184133DC0")]
	public void JDOHHCHFPCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x4134110", Offset = "0x4133310", VA = "0x184134110")]
	public void MCCMHMMIPDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x41342B0", Offset = "0x41334B0", VA = "0x1841342B0")]
	public void PAPBIBGBBOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class ABNDGKEIMID<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private struct IMGAOJMALIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public int BBINAIMCLEP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public T OGADOHBOMGE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly Dictionary<object, IMGAOJMALIM> FAEHLNLHLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly EqualityComparer<T> KALEPKNOJFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private T HLPDBGNLLEB;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public virtual T NFLGCDKNBEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x83B460", Offset = "0x83A660", VA = "0x18083B460", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x39AB0E0", Offset = "0x39AA2E0", VA = "0x1839AB0E0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool PMJAJJKGNGB
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x39AA830", Offset = "0x39A9A30", VA = "0x1839AA830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public object HLKEBKOJDPC
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4E0", Offset = "0x7CA6E0", VA = "0x1807CB4E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7CB500", Offset = "0x7CA700", VA = "0x1807CB500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x39A9EC0", Offset = "0x39A90C0", VA = "0x1839A9EC0")]
	public bool BACMHJHBCMI(T HLCKBKFCMPI, object CEFPPEHCFCF, int GMDNJIBGHKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x39A9DB0", Offset = "0x39A8FB0", VA = "0x1839A9DB0")]
	public bool ADCGPDBINPA(object CEFPPEHCFCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x39AAE50", Offset = "0x39AA050", VA = "0x1839AAE50")]
	public bool GMADCLHMMHE(object CEFPPEHCFCF, [Out] T HLCKBKFCMPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x39AA800", Offset = "0x39A9A00", VA = "0x1839AA800")]
	public void BFDHFEEMFPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x39A8A50", Offset = "0x39A7C50", VA = "0x1839A8A50")]
	private bool ACCAPBCDEAH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x39AB100", Offset = "0x39AA300", VA = "0x1839AB100")]
	public ABNDGKEIMID()
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
