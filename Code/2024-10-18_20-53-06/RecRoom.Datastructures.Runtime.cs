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
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6DA1580", Offset = "0x6DA0980", VA = "0x186DA1580")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D4610", Offset = "0x8D3A10", VA = "0x1808D4610")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8D4650", Offset = "0x8D3A50", VA = "0x1808D4650")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class KAIKHAPGEFM : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x198B2B0", Offset = "0x198A6B0", VA = "0x18198B2B0")]
	public KAIKHAPGEFM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, NNDLMACIFIG, ELDAOEFJOLH, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8A8970", Offset = "0x8A7D70", VA = "0x1808A8970", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8A89D0", Offset = "0x8A7DD0", VA = "0x1808A89D0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8A8A00", Offset = "0x8A7E00", VA = "0x1808A8A00", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9AD460", Offset = "0x9AC860", VA = "0x1809AD460", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash ACNHEEAHLIA);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xA255A0", Offset = "0xA249A0", VA = "0x180A255A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6DA2750", Offset = "0x6DA1B50", VA = "0x186DA2750")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6DA2710", Offset = "0x6DA1B10", VA = "0x186DA2710")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6DA2790", Offset = "0x6DA1B90", VA = "0x186DA2790")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6DA2940", Offset = "0x6DA1D40", VA = "0x186DA2940")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6DA28B0", Offset = "0x6DA1CB0", VA = "0x186DA28B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA2AE70", Offset = "0xA2A270", VA = "0x180A2AE70")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xB846E0", Offset = "0xB83AE0", VA = "0x180B846E0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6DA26D0", Offset = "0x6DA1AD0", VA = "0x186DA26D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6DA2820", Offset = "0x6DA1C20", VA = "0x186DA2820")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6DA2170", Offset = "0x6DA1570", VA = "0x186DA2170")]
	public void CopyBounds(SavedExtents KNLMODPGFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6DA2620", Offset = "0x6DA1A20", VA = "0x186DA2620")]
	public void SetLocalSpaceBounds(Bounds OJFDCNGCDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xE6DC90", Offset = "0xE6D090", VA = "0x180E6DC90")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6DA2610", Offset = "0x6DA1A10", VA = "0x186DA2610")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6DA2260", Offset = "0x6DA1660", VA = "0x186DA2260")]
	private void FOPDHLKMKPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6DA2410", Offset = "0x6DA1810", VA = "0x186DA2410")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6DA1B30", Offset = "0x6DA0F30", VA = "0x186DA1B30")]
	public static void CalculateLocalBoundsFor(GameObject BCDDMHHPJBD, [Out] Bounds OJFDCNGCDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6DA21A0", Offset = "0x6DA15A0", VA = "0x186DA21A0")]
	private static void DJJEFJCNMPJ(Bounds BCMPBHCEGGA, Color JEGEADOBKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6DA2640", Offset = "0x6DA1A40", VA = "0x186DA2640")]
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
		[Cpp2IlInjected.Address(RVA = "0x8A81A0", Offset = "0x8A75A0", VA = "0x1808A81A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8A89F0", Offset = "0x8A7DF0", VA = "0x1808A89F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x12C3650", Offset = "0x12C2A50", VA = "0x1812C3650")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4D3BFA0", Offset = "0x4D3B3A0", VA = "0x184D3BFA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "4")]
	public virtual void HMAJBBMEDNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
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
	[KAIKHAPGEFM]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4D3BAB0", Offset = "0x4D3AEB0", VA = "0x184D3BAB0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4D3A0D0", Offset = "0x4D394D0", VA = "0x184D3A0D0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4D3BE90", Offset = "0x4D3B290", VA = "0x184D3BE90")]
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
	private sealed class AIDGNFGNOHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public AIDGNFGNOHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3FDDFF0", Offset = "0x3FDD3F0", VA = "0x183FDDFF0")]
		internal int DEDCMNPKNLK(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[KAIKHAPGEFM]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3BC7670", Offset = "0x3BC6A70", VA = "0x183BC7670", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3BC76D0", Offset = "0x3BC6AD0", VA = "0x183BC76D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3BC7540", Offset = "0x3BC6940", VA = "0x183BC7540", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey OEOMDKHBDFI]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3BC7600", Offset = "0x3BC6A00", VA = "0x183BC7600", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3BC73E0", Offset = "0x3BC67E0", VA = "0x183BC73E0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3BC7060", Offset = "0x3BC6460", VA = "0x183BC7060", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3BC63D0", Offset = "0x3BC57D0", VA = "0x183BC63D0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3BC6230", Offset = "0x3BC5630", VA = "0x183BC6230", Slot = "14")]
	protected virtual string BNKHLCONPEJ(TKeyVal IHDPJLNMCJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3BC62C0", Offset = "0x3BC56C0", VA = "0x183BC62C0", Slot = "4")]
	public bool ContainsKey(TKey OEOMDKHBDFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3BC7250", Offset = "0x3BC6650", VA = "0x183BC7250", Slot = "5")]
	public bool TryGetValue(TKey OEOMDKHBDFI, [Out] TVal EEPLCHCGAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3BC6320", Offset = "0x3BC5720", VA = "0x183BC6320", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3BC6320", Offset = "0x3BC5720", VA = "0x183BC6320", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3BC72B0", Offset = "0x3BC66B0", VA = "0x183BC72B0")]
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
	[SerializeReference]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8AAD20", Offset = "0x8AA120", VA = "0x1808AAD20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8A8970", Offset = "0x8A7D70", VA = "0x1808A8970")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3B9D470", Offset = "0x3B9C870", VA = "0x183B9D470")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	[KAIKHAPGEFM]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4D3DA50", Offset = "0x4D3CE50", VA = "0x184D3DA50")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4D3D240", Offset = "0x4D3C640", VA = "0x184D3D240", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4D3C780", Offset = "0x4D3BB80", VA = "0x184D3C780", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class ODJOINNEMKG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private class IPOIAJGLIHM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public float KGPIHNMLGIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T EEMLDMGPOLA;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public IPOIAJGLIHM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class MLGCCJDIPKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public MLGCCJDIPKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4815F50", Offset = "0x4815350", VA = "0x184815F50")]
		internal bool OMPEKLDIEJA(IPOIAJGLIHM sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly float MCFKJEMKKFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly float NEMBBEIGHMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private List<IPOIAJGLIHM> HPIBAJCJPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private JAJEACLLCPM<IPOIAJGLIHM> HAEILHGIOGL;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int NLPNCFBPKMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4A0BAD0", Offset = "0x4A0AED0", VA = "0x184A0BAD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4A0BD70", Offset = "0x4A0B170", VA = "0x184A0BD70")]
	public ODJOINNEMKG(float PDKALFPNOPJ, float ABGMBKBFJLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4A0B820", Offset = "0x4A0AC20", VA = "0x184A0B820")]
	public bool HKEHCJMLECP(float EBOOIPGOPKP, T EEPLCHCGAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x4A0B2A0", Offset = "0x4A0A6A0", VA = "0x184A0B2A0")]
	public IEnumerable<T> DFHIGGJGLPO(float EBOOIPGOPKP, [Optional] float? FCMHFOALJPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4A0BA10", Offset = "0x4A0AE10", VA = "0x184A0BA10")]
	public void KMNEPMPOIBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4A0BBB0", Offset = "0x4A0AFB0", VA = "0x184A0BBB0")]
	private void LKAELAOLNAD(float EBOOIPGOPKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class GJLFCOIDLJD<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct AMGKLDNGPHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public T EEMLDMGPOLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public float LFAIHDPAPLL;
	}

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static float ODLEJKHBHHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private List<T> KJCOAHCBPNJ;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private const int NNAANMHGEGH = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private AMGKLDNGPHJ[] IGGIDMIPNHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int CBBGOGFDKLE;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float PLMEOEPGIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xC734A0", Offset = "0xC728A0", VA = "0x180C734A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xC9AAC0", Offset = "0xC99EC0", VA = "0x180C9AAC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x40B44C0", Offset = "0x40B38C0", VA = "0x1840B44C0")]
	public GJLFCOIDLJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x40B4380", Offset = "0x40B3780", VA = "0x1840B4380")]
	public GJLFCOIDLJD(int IKJKAFPPDBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x40B4220", Offset = "0x40B3620", VA = "0x1840B4220")]
	public void LEFBGNCKNFL(float EBOOIPGOPKP, T EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x40B4020", Offset = "0x40B3420", VA = "0x1840B4020")]
	public void KMNEPMPOIBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x40B3CD0", Offset = "0x40B30D0", VA = "0x1840B3CD0")]
	public bool IOHAOFBGKIF(float LOJLJHAFBHM, float MDOEFPBKMDL, [Out] T EEPLCHCGAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x40B3280", Offset = "0x40B2680", VA = "0x1840B3280")]
	public bool EKHHGNGOBFL(float LOJLJHAFBHM, float MDOEFPBKMDL, [Out] T EEPLCHCGAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x40B3680", Offset = "0x40B2A80", VA = "0x1840B3680")]
	public void FLDNKMKHLJC(float LOJLJHAFBHM, float MDOEFPBKMDL, List<T> PCJDGFHBJBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x40B3250", Offset = "0x40B2650", VA = "0x1840B3250")]
	private int AHFJBPHPNBO(int CIKHMONKMEE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x40B39B0", Offset = "0x40B2DB0", VA = "0x1840B39B0")]
	private void GCNCHJNNPED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T DENMCGNAHOB();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T IFLMNPAOEND(T EEPLCHCGAIN, float KBFPLGGGODF);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T IJMBCDHBDNG(T JKMLNPBBJIG, T JDJGFJGMEAK);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T ILDPLHKNFFD(T JKMLNPBBJIG, T JDJGFJGMEAK);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class APAPMJDIMJB : GJLFCOIDLJD<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8B99E0", Offset = "0x8B8DE0", VA = "0x1808B99E0", Slot = "4")]
	protected override Vector3 DENMCGNAHOB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6D9DB20", Offset = "0x6D9CF20", VA = "0x186D9DB20", Slot = "5")]
	protected override Vector3 IFLMNPAOEND(Vector3 EEPLCHCGAIN, float KBFPLGGGODF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6D9DB60", Offset = "0x6D9CF60", VA = "0x186D9DB60", Slot = "6")]
	protected override Vector3 IJMBCDHBDNG(Vector3 JKMLNPBBJIG, Vector3 JDJGFJGMEAK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6D9DBB0", Offset = "0x6D9CFB0", VA = "0x186D9DBB0", Slot = "7")]
	protected override Vector3 ILDPLHKNFFD(Vector3 JKMLNPBBJIG, Vector3 JDJGFJGMEAK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6D9DC30", Offset = "0x6D9D030", VA = "0x186D9DC30")]
	public APAPMJDIMJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class DBHJDNOINNO
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2C9D1D0", Offset = "0x2C9C5D0", VA = "0x182C9D1D0")]
	public static IPECDPPJEHA<T1, T2> JMOKCOIDHBC<T1, T2>(T1 EBNGFDFMIGO, T2 KKHEKHOKIKJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2C9D270", Offset = "0x2C9C670", VA = "0x182C9D270")]
	public static GAANIFLIIEP<T1, T2, T3> JMOKCOIDHBC<T1, T2, T3>(T1 EBNGFDFMIGO, T2 KKHEKHOKIKJ, T3 GHDLHHHABPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4885440", Offset = "0x4884840", VA = "0x184885440")]
	internal static int LJBOCCPHEOK(int HPBACOAFHKC, int JOOBHLDBFMB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6133A40", Offset = "0x6132E40", VA = "0x186133A40")]
	internal static int LJBOCCPHEOK(int HPBACOAFHKC, int JOOBHLDBFMB, int NMBBGAGEMID)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class IPECDPPJEHA<T1, T2> : IComparable<IPECDPPJEHA<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly T1 CBENDMINGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly T2 KFGJEJHLGFI;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4265930", Offset = "0x4264D30", VA = "0x184265930")]
	public IPECDPPJEHA(T1 EBNGFDFMIGO, T2 KKHEKHOKIKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4263AA0", Offset = "0x4262EA0", VA = "0x184263AA0", Slot = "4")]
	public int CompareTo(IPECDPPJEHA<T1, T2> KNLMODPGFOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4264650", Offset = "0x4263A50", VA = "0x184264650", Slot = "0")]
	public override bool Equals(object KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4264CA0", Offset = "0x42640A0", VA = "0x184264CA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x42652D0", Offset = "0x42646D0", VA = "0x1842652D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class GAANIFLIIEP<T1, T2, T3> : IComparable<GAANIFLIIEP<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly T1 CBENDMINGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly T2 KFGJEJHLGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly T3 GLODKKBJCBG;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x40167F0", Offset = "0x4015BF0", VA = "0x1840167F0")]
	public GAANIFLIIEP(T1 EBNGFDFMIGO, T2 KKHEKHOKIKJ, T3 GHDLHHHABPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4015FB0", Offset = "0x40153B0", VA = "0x184015FB0", Slot = "4")]
	public int CompareTo(GAANIFLIIEP<T1, T2, T3> KNLMODPGFOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4016230", Offset = "0x4015630", VA = "0x184016230", Slot = "0")]
	public override bool Equals(object KNLMODPGFOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x40163F0", Offset = "0x40157F0", VA = "0x1840163F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4016520", Offset = "0x4015920", VA = "0x184016520", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public T EEMLDMGPOLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x257EBC0", Offset = "0x257DFC0", VA = "0x18257EBC0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x257E9C0", Offset = "0x257DDC0", VA = "0x18257E9C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float MMNJHLCKFDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA33090", Offset = "0xA32490", VA = "0x180A33090")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4F9D0D0", Offset = "0x4F9C4D0", VA = "0x184F9D0D0")]
	public T GMDFNFNPHMC(float KBFPLGGGODF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4F9D470", Offset = "0x4F9C870", VA = "0x184F9D470")]
	public T NAHOAFKEEMI(float KBFPLGGGODF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T ELLFKCPFDJL(T JKMLNPBBJIG, T JDJGFJGMEAK, float KBFPLGGGODF);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6D9DF60", Offset = "0x6D9D360", VA = "0x186D9DF60", Slot = "4")]
	protected override float ELLFKCPFDJL(float JKMLNPBBJIG, float JDJGFJGMEAK, float KBFPLGGGODF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6D9DFA0", Offset = "0x6D9D3A0", VA = "0x186D9DFA0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1146ED0", Offset = "0x11462D0", VA = "0x181146ED0", Slot = "4")]
	protected override Vector3 ELLFKCPFDJL(Vector3 JKMLNPBBJIG, Vector3 JDJGFJGMEAK, float KBFPLGGGODF)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6DA3710", Offset = "0x6DA2B10", VA = "0x186DA3710")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6D9DDD0", Offset = "0x6D9D1D0", VA = "0x186D9DDD0", Slot = "4")]
	protected override Color ELLFKCPFDJL(Color JKMLNPBBJIG, Color JDJGFJGMEAK, float KBFPLGGGODF)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6D9DE90", Offset = "0x6D9D290", VA = "0x186D9DE90")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class MDNICEPFOAP : JOOHFHAKFAD<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6DA1530", Offset = "0x6DA0930", VA = "0x186DA1530")]
	public MDNICEPFOAP(int BIMLHBENMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6DA14C0", Offset = "0x6DA08C0", VA = "0x186DA14C0", Slot = "6")]
	protected override uint LEJBEDIHJOG(uint ACNHEEAHLIA, string EEPLCHCGAIN)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class LHDEEJCKGCB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly IDisposable GJPJBBHLIHD;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public LHDEEJCKGCB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct HPHIGMNNOLH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> GCMHABMLHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int NEOCAOHNEJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int NHBLPFNNPGH;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4188DD0", Offset = "0x41881D0", VA = "0x184188DD0")]
	private HPHIGMNNOLH(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> KDECCIGCENM, int IEIODHODMHB, int HGKHECLJGIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4186760", Offset = "0x4185B60", VA = "0x184186760")]
	public static HPHIGMNNOLH<T> AHLALEPNKFA()
	{
		return default(HPHIGMNNOLH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4188670", Offset = "0x4187A70", VA = "0x184188670")]
	public (int, int, Task<T>) DLDBMKEMELG(int KIGKEDGNJCM, [Optional] CancellationToken NBBCMDKGJKI, double FBMABEBEKJJ = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4186C60", Offset = "0x4186060", VA = "0x184186C60")]
	public void CCIBKPMJCNA(int KIGKEDGNJCM, int HGKHECLJGIA, [In] T IPNDOKDOGDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class CDJEGJGBOLB
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6D9DD00", Offset = "0x6D9D100", VA = "0x186D9DD00")]
	public static HPHIGMNNOLH<IOADHBFKJOJ> AHLALEPNKFA()
	{
		return default(HPHIGMNNOLH<IOADHBFKJOJ>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6D9DD50", Offset = "0x6D9D150", VA = "0x186D9DD50")]
	public static void CCIBKPMJCNA([In] this HPHIGMNNOLH<IOADHBFKJOJ> MCPMOAEEEOJ, int KIGKEDGNJCM, int HGKHECLJGIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public class EOAIAFKLFCI<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly Dictionary<TKey, TVal> JJFBHBFJAMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<TVal, TKey> ADNPGDKGJBN;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int ICBOPDBFFOG
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x388A9A0", Offset = "0x3889DA0", VA = "0x18388A9A0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool IHEEMPBAFPK
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public ICollection<TKey> HDCGPPCFMPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3BAF1E0", Offset = "0x3BAE5E0", VA = "0x183BAF1E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public ICollection<TVal> ENHONGHAPHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3B7C5E0", Offset = "0x3B7B9E0", VA = "0x183B7C5E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public TVal MGACFGHHFEH
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3BAF170", Offset = "0x3BAE570", VA = "0x183BAF170", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x3BAF240", Offset = "0x3BAE640", VA = "0x183BAF240", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public TKey MGACFGHHFEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x3BAEEB0", Offset = "0x3BAE2B0", VA = "0x183BAEEB0")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3BAE9D0", Offset = "0x3BADDD0", VA = "0x183BAE9D0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3BAEF90", Offset = "0x3BAE390", VA = "0x183BAEF90", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3BAE850", Offset = "0x3BADC50", VA = "0x183BAE850", Slot = "9")]
	public void Add(TKey OEOMDKHBDFI, TVal EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3BAE800", Offset = "0x3BADC00", VA = "0x183BAE800", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> HHDONFMCNBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3BAEA80", Offset = "0x3BADE80", VA = "0x183BAEA80", Slot = "8")]
	public bool ContainsKey(TKey OEOMDKHBDFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3BAEAE0", Offset = "0x3BADEE0", VA = "0x183BAEAE0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> HHDONFMCNBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3BAEF50", Offset = "0x3BAE350", VA = "0x183BAEF50", Slot = "10")]
	public bool Remove(TKey OEOMDKHBDFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3BAEF10", Offset = "0x3BAE310", VA = "0x183BAEF10", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> HHDONFMCNBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3BAEFE0", Offset = "0x3BAE3E0", VA = "0x183BAEFE0", Slot = "11")]
	public bool TryGetValue(TKey OEOMDKHBDFI, [Out] TVal EEPLCHCGAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3BAEBB0", Offset = "0x3BADFB0", VA = "0x183BAEBB0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3BAEB20", Offset = "0x3BADF20", VA = "0x183BAEB20", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] IGGIDMIPNHL, int GJALKOIBMBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3BAEC50", Offset = "0x3BAE050", VA = "0x183BAEC50")]
	public bool LCKMIEGKAOE(TVal OEOMDKHBDFI, [Out] TKey EEPLCHCGAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3BAECB0", Offset = "0x3BAE0B0", VA = "0x183BAECB0")]
	private void LIEICAGICNP(TKey OEOMDKHBDFI, TVal OAKJBMEGCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3BAEDB0", Offset = "0x3BAE1B0", VA = "0x183BAEDB0")]
	private void MBFFDLCJKBF(TKey OEOMDKHBDFI, TVal OAKJBMEGCLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3BAE8A0", Offset = "0x3BADCA0", VA = "0x183BAE8A0")]
	private bool CPHLKMEGGFA(TKey OEOMDKHBDFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3BAF040", Offset = "0x3BAE440", VA = "0x183BAF040")]
	public EOAIAFKLFCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class LDCPMFHNLPL<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private LDCPMFHNLPL<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x3C14130", Offset = "0x3C13530", VA = "0x183C14130", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x3C1CDC0", Offset = "0x3C1C1C0", VA = "0x183C1CDC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3C1DC30", Offset = "0x3C1D030", VA = "0x183C1DC30")]
		public Enumerator(LDCPMFHNLPL<T> PCJDGFHBJBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3C1B1B0", Offset = "0x3C1A5B0", VA = "0x183C1B1B0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3C1C080", Offset = "0x3C1B480", VA = "0x183C1C080", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3C1ABA0", Offset = "0x3C19FA0", VA = "0x183C1ABA0")]
		private void GIKMPLAHPCC()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private T[] MCOPGCLGFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int PGAHHGFJKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private int HILPPJEFBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private int ABNEAOFINHP;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int ICBOPDBFFOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x4593490", Offset = "0x4592890", VA = "0x184593490")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public T MGACFGHHFEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x4593BA0", Offset = "0x4592FA0", VA = "0x184593BA0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4592FD0", Offset = "0x45923D0", VA = "0x184592FD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4594150", Offset = "0x4593550", VA = "0x184594150")]
	public LDCPMFHNLPL(int BIMLHBENMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4593810", Offset = "0x4592C10", VA = "0x184593810")]
	public void LEFBGNCKNFL(T KBFPLGGGODF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x45934D0", Offset = "0x45928D0", VA = "0x1845934D0")]
	public void KMNEPMPOIBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4593280", Offset = "0x4592680", VA = "0x184593280")]
	public void JABLBKILDDF(int HMELIAGANNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x45925C0", Offset = "0x45919C0", VA = "0x1845925C0")]
	public void BOHHJANEDAD(T[] IGGIDMIPNHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4593450", Offset = "0x4592850", VA = "0x184593450")]
	public Enumerator JLDAKMOMDIF()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4593EE0", Offset = "0x45932E0", VA = "0x184593EE0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4593EE0", Offset = "0x45932E0", VA = "0x184593EE0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x45929C0", Offset = "0x4591DC0", VA = "0x1845929C0")]
	private int CDNBLKOPNKC(int HAJICDLBEKC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4593250", Offset = "0x4592650", VA = "0x184593250")]
	private int HIAEJGNNGND(int HAJICDLBEKC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class PEKJCFNHGBA<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate Task<TResult> LIGNPNJPMPD(TRequest BCGNIJHEBIO, CancellationToken NBBCMDKGJKI);

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public enum LLDFDMKDLMP
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class KJPNEIKEJIP
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private const float JOCIJBJMDBP = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TimeSpan AJBKHHCHHJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int CFGKBMFLDGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public LLDFDMKDLMP CNGOENJGCLP;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public static readonly KJPNEIKEJIP BONGJJLJANI;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float DHKCMNMKAGK
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x4509F50", Offset = "0x4509350", VA = "0x184509F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan FNFNNHHJOGN
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x450A030", Offset = "0x4509430", VA = "0x18450A030")]
		public KJPNEIKEJIP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private readonly struct IOPHNGHCCFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly TRequest BCGNIJHEBIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly CancellationToken NBBCMDKGJKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly TaskCompletionSource<TResult> JCMIOIBGHIO;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x4263210", Offset = "0x4262610", VA = "0x184263210")]
		public IOPHNGHCCFD(TRequest BCGNIJHEBIO, TaskCompletionSource<TResult> JCMIOIBGHIO, CancellationToken NBBCMDKGJKI)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct BJLPBOLJHHD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public PEKJCFNHGBA<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x52738F0", Offset = "0x5272CF0", VA = "0x1852738F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x5274110", Offset = "0x5273510", VA = "0x185274110", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct ALNPAIDCKCE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public PEKJCFNHGBA<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private IOPHNGHCCFD <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x40CFD40", Offset = "0x40CF140", VA = "0x1840CFD40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x40D10C0", Offset = "0x40D04C0", VA = "0x1840D10C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly CancellationTokenSource HFADKKCGMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<IOPHNGHCCFD> BOCKJOKKPKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly KJPNEIKEJIP OLKOAIOOJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly LIGNPNJPMPD APMEMJJKJJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Task EPLCDKKOFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private int FBPHPKNMCAM;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x4AE37A0", Offset = "0x4AE2BA0", VA = "0x184AE37A0")]
	public PEKJCFNHGBA(LIGNPNJPMPD APMEMJJKJJN, [Optional] KJPNEIKEJIP OLKOAIOOJPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x4AE2B30", Offset = "0x4AE1F30", VA = "0x184AE2B30")]
	public Task<TResult> JMJAFGGKJMO(TRequest BCGNIJHEBIO, CancellationToken NBBCMDKGJKI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x4AE2480", Offset = "0x4AE1880", VA = "0x184AE2480")]
	private void BMNDCLCJPPL(IOPHNGHCCFD KMBDPHFLKNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x4AE2820", Offset = "0x4AE1C20", VA = "0x184AE2820")]
	[AsyncStateMachine(typeof(PEKJCFNHGBA<, >.BJLPBOLJHHD))]
	private Task HONHFJHAFGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x4AE1DA0", Offset = "0x4AE11A0", VA = "0x184AE1DA0")]
	private IOPHNGHCCFD BHNKBCJEMLI()
	{
		return default(IOPHNGHCCFD);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x4AE3000", Offset = "0x4AE2400", VA = "0x184AE3000")]
	[AsyncStateMachine(typeof(PEKJCFNHGBA<, >.ALNPAIDCKCE))]
	private Task OMGGLDHPFKL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x4AE3500", Offset = "0x4AE2900", VA = "0x184AE3500")]
	private void PIMNNEFDCCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x4AE2640", Offset = "0x4AE1A40", VA = "0x184AE2640", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class DDGNAGHDCDG<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly List<T> KDBAFFDDPME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private HashSet<T> IIIGMBMKEKN;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int ICBOPDBFFOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x388A9A0", Offset = "0x3889DA0", VA = "0x18388A9A0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool IHEEMPBAFPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8F2CF0", Offset = "0x8F20F0", VA = "0x1808F2CF0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T MGACFGHHFEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2CFDFF0", Offset = "0x2CFD3F0", VA = "0x182CFDFF0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5C96530", Offset = "0x5C95930", VA = "0x185C96530", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3F35360", Offset = "0x3F34760", VA = "0x183F35360", Slot = "11")]
	public void Add(T HHDONFMCNBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5C95D80", Offset = "0x5C95180", VA = "0x185C95D80")]
	public bool JOOFMAMJLCK(T HHDONFMCNBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5C96260", Offset = "0x5C95660", VA = "0x185C96260", Slot = "15")]
	public bool Remove(T HHDONFMCNBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4413F50", Offset = "0x4413350", VA = "0x184413F50", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3F9A350", Offset = "0x3F99750", VA = "0x183F9A350", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5C95970", Offset = "0x5C94D70", VA = "0x185C95970", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5C95A20", Offset = "0x5C94E20", VA = "0x185C95A20", Slot = "13")]
	public bool Contains(T HHDONFMCNBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5C95A80", Offset = "0x5C94E80", VA = "0x185C95A80", Slot = "14")]
	public void CopyTo(T[] IGGIDMIPNHL, int GJALKOIBMBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4548F50", Offset = "0x4548350", VA = "0x184548F50", Slot = "6")]
	public int IndexOf(T HHDONFMCNBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5C95C30", Offset = "0x5C95030", VA = "0x185C95C30", Slot = "7")]
	public void Insert(int HAJICDLBEKC, T HHDONFMCNBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5C96100", Offset = "0x5C95500", VA = "0x185C96100", Slot = "8")]
	public void RemoveAt(int HAJICDLBEKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5C96400", Offset = "0x5C95800", VA = "0x185C96400")]
	public DDGNAGHDCDG()
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
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x240DA10", Offset = "0x240CE10", VA = "0x18240DA10")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6DA2CE0", Offset = "0x6DA20E0", VA = "0x186DA2CE0")]
		public SerializedGuid([In] Guid GPJCGLBMIBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6DA2C60", Offset = "0x6DA2060", VA = "0x186DA2C60")]
		public static SerializedGuid PGHLNKEKNEO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6DA2AD0", Offset = "0x6DA1ED0", VA = "0x186DA2AD0")]
		public static SerializedGuid FHCNNBFFAEF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6DA2B50", Offset = "0x6DA1F50", VA = "0x186DA2B50")]
		public bool HNBCNJGJEII()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6DA2C30", Offset = "0x6DA2030", VA = "0x186DA2C30", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6DA2BB0", Offset = "0x6DA1FB0", VA = "0x186DA2BB0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6DA2A00", Offset = "0x6DA1E00", VA = "0x186DA2A00", Slot = "7")]
		public bool Equals(SerializedGuid KNLMODPGFOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6DA2A40", Offset = "0x6DA1E40", VA = "0x186DA2A40", Slot = "0")]
		public override bool Equals(object FMAFBHGACNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6DA2B40", Offset = "0x6DA1F40", VA = "0x186DA2B40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6DA29D0", Offset = "0x6DA1DD0", VA = "0x186DA29D0", Slot = "6")]
		public int CompareTo(SerializedGuid KNLMODPGFOA)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class BADBEOCNFGD : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly Type MMIDDJJNKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly string CMMBCEAAMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly bool OGPCIPLHJJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly bool ILGMKJGOKFC;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6D9DC90", Offset = "0x6D9D090", VA = "0x186D9DC90")]
	public BADBEOCNFGD(Type DKLDOEBEEIP, string NNAEAIOONLO, bool MLJCMOPJOBL = false, bool NKBMOFHFGCG = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class OGAFCBAEIIJ<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public readonly struct IMHEBAELAHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly long KLNEMNNOFOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly long ALCOMJADAMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly int HJPFAOMOAHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly int FDAIIHMMAFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public readonly bool CHCBFLFBOHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly string JFAEIIKGFCK;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x425D7E0", Offset = "0x425CBE0", VA = "0x18425D7E0")]
		public IMHEBAELAHI(long KLNEMNNOFOO, int HJPFAOMOAHB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x425D7B0", Offset = "0x425CBB0", VA = "0x18425D7B0")]
		public IMHEBAELAHI(long KLNEMNNOFOO, long ALCOMJADAMG, int HJPFAOMOAHB, int FDAIIHMMAFM, bool CHCBFLFBOHC, string JFAEIIKGFCK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x425D760", Offset = "0x425CB60", VA = "0x18425D760")]
		public int PGDNLGDGOPC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x425D6A0", Offset = "0x425CAA0", VA = "0x18425D6A0")]
		public int NDNPBPHJJMP(int IHIBGCAKGFB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x425D640", Offset = "0x425CA40", VA = "0x18425D640")]
		public double EMELFMMCFLJ()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x425D6C0", Offset = "0x425CAC0", VA = "0x18425D6C0")]
		public IMHEBAELAHI NLIIACCPEAL(long ALCOMJADAMG, int FDAIIHMMAFM)
		{
			return default(IMHEBAELAHI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class DDIOHHJLGKB : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private struct CMKKEFMAKPM<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public DDIOHHJLGKB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public Func<DDIOHHJLGKB, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private DDIOHHJLGKB <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x5A74FB0", Offset = "0x5A743B0", VA = "0x185A74FB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x4A10A10", Offset = "0x4A0FE10", VA = "0x184A10A10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public readonly TKey KJHFJLCNKKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly OGAFCBAEIIJ<TKey> BKBOMPKPCMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public readonly FLILHMOBPPM APPINHJJCPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private List<DDIOHHJLGKB> OHLGPCJPDKK;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string HCFHNJINFGI
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x3F5E680", Offset = "0x3F5DA80", VA = "0x183F5E680")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IEnumerable<DDIOHHJLGKB> BGJNHCEFIII
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x5C97050", Offset = "0x5C96450", VA = "0x185C97050")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public IMHEBAELAHI KGEAJPHBIPA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x5C97030", Offset = "0x5C96430", VA = "0x185C97030")]
			[CompilerGenerated]
			get
			{
				return default(IMHEBAELAHI);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x5C96BE0", Offset = "0x5C95FE0", VA = "0x185C96BE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5C97090", Offset = "0x5C96490", VA = "0x185C97090")]
		internal DDIOHHJLGKB(OGAFCBAEIIJ<TKey> BKBOMPKPCMH, TKey OEOMDKHBDFI, FLILHMOBPPM APPINHJJCPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5C96C10", Offset = "0x5C96010", VA = "0x185C96C10")]
		public DDIOHHJLGKB DODFJHOLPNI(TKey OEOMDKHBDFI, [Optional] FLILHMOBPPM? LOLENOEDNHN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2D7E320", Offset = "0x2D7D720", VA = "0x182D7E320")]
		[AsyncStateMachine(typeof(CMKKEFMAKPM<>))]
		public Task<T> KJNCFIMPKGD<T>(TKey OEOMDKHBDFI, Func<DDIOHHJLGKB, Task<T>> KNNCNNMDAMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5C96DD0", Offset = "0x5C961D0", VA = "0x185C96DD0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class FDEIEFFLJNI : IEnumerable<(TKey, List<TKey>, IMHEBAELAHI)>, IEnumerable, IEnumerator<(TKey, List<TKey>, IMHEBAELAHI)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private (TKey key, List<TKey> path, IMHEBAELAHI timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public OGAFCBAEIIJ<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private IEnumerator<(TKey key, List<TKey> path, IMHEBAELAHI timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, IMHEBAELAHI) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x24173F0", Offset = "0x24167F0", VA = "0x1824173F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, IMHEBAELAHI));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x3F34040", Offset = "0x3F33440", VA = "0x183F34040", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x24174E0", Offset = "0x24168E0", VA = "0x1824174E0")]
		[DebuggerHidden]
		public FDEIEFFLJNI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3B6DAA0", Offset = "0x3B6CEA0", VA = "0x183B6DAA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3F33B60", Offset = "0x3F32F60", VA = "0x183F33B60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3F33B10", Offset = "0x3F32F10", VA = "0x183F33B10")]
		private void CPDIPGODGJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3F33FF0", Offset = "0x3F333F0", VA = "0x183F33FF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3F33F10", Offset = "0x3F33310", VA = "0x183F33F10", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, IMHEBAELAHI)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3EA5A60", Offset = "0x3EA4E60", VA = "0x183EA5A60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class GEPPJOBHCLA : IEnumerable<(TKey, List<TKey>, IMHEBAELAHI)>, IEnumerable, IEnumerator<(TKey, List<TKey>, IMHEBAELAHI)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private (TKey key, List<TKey> path, IMHEBAELAHI timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private DDIOHHJLGKB timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public DDIOHHJLGKB <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public OGAFCBAEIIJ<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private IEnumerator<DDIOHHJLGKB> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private IEnumerator<(TKey key, List<TKey> path, IMHEBAELAHI timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private (TKey, List<TKey>, IMHEBAELAHI) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x24173F0", Offset = "0x24167F0", VA = "0x1824173F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, IMHEBAELAHI));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x40916F0", Offset = "0x4090AF0", VA = "0x1840916F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x24174E0", Offset = "0x24168E0", VA = "0x1824174E0")]
		[DebuggerHidden]
		public GEPPJOBHCLA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4091750", Offset = "0x4090B50", VA = "0x184091750", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x4090D80", Offset = "0x4090180", VA = "0x184090D80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4090CC0", Offset = "0x40900C0", VA = "0x184090CC0")]
		private void CPDIPGODGJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x4090D20", Offset = "0x4090120", VA = "0x184090D20")]
		private void FKMGMNDEOBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x40916A0", Offset = "0x4090AA0", VA = "0x1840916A0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x4091560", Offset = "0x4090960", VA = "0x184091560", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, IMHEBAELAHI)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4091660", Offset = "0x4090A60", VA = "0x184091660", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly Action<TKey, IMHEBAELAHI, FLILHMOBPPM> AKKMKAMHLCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Action<TKey, IMHEBAELAHI, FLILHMOBPPM> HGDKPDNNGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Action<OGAFCBAEIIJ<TKey>, FLILHMOBPPM> HHBHGDNJPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly FLILHMOBPPM APPINHJJCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly DDIOHHJLGKB EJFJAEAPCLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private bool NLOIKEFMMEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int MLDOAGGNEHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Stopwatch OOBCNKBCDNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly int NJNGCBJOOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private string CBNPALAJBPI;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public DDIOHHJLGKB IJPDCOAJHBA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8AAD10", Offset = "0x8AA110", VA = "0x1808AAD10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[NotNull]
	public string HCFHNJINFGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8ACAF0", Offset = "0x8ABEF0", VA = "0x1808ACAF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x4A13310", Offset = "0x4A12710", VA = "0x184A13310")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4A133F0", Offset = "0x4A127F0", VA = "0x184A133F0")]
	public OGAFCBAEIIJ(TKey OHCODLJJBPG, FLILHMOBPPM APPINHJJCPL, [Optional] int? HJPFAOMOAHB, [Optional][CanBeNull] Stopwatch OOBCNKBCDNB, [Optional] Action<TKey, IMHEBAELAHI, FLILHMOBPPM> AKKMKAMHLCB, [Optional] Action<TKey, IMHEBAELAHI, FLILHMOBPPM> HGDKPDNNGGJ, [Optional] Action<OGAFCBAEIIJ<TKey>, FLILHMOBPPM> HHBHGDNJPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4A13230", Offset = "0x4A12630", VA = "0x184A13230", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4A13090", Offset = "0x4A12490", VA = "0x184A13090")]
	[IteratorStateMachine(typeof(OGAFCBAEIIJ<>.FDEIEFFLJNI))]
	public IEnumerable<(TKey, List<TKey>, IMHEBAELAHI)> DJDMBCCFBBB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4A13140", Offset = "0x4A12540", VA = "0x184A13140")]
	[IteratorStateMachine(typeof(OGAFCBAEIIJ<>.GEPPJOBHCLA))]
	private IEnumerable<(TKey, List<TKey>, IMHEBAELAHI)> DJDMBCCFBBB(List<TKey> NDECLOFKCPB, DDIOHHJLGKB EMFPIJAEOEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4A13370", Offset = "0x4A12770", VA = "0x184A13370")]
	private (long, int) MGDCEMGFAMA()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public abstract class BCNFILCOKNN<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut JDCJPDKDNFL(OGAFCBAEIIJ<TKey> BKBOMPKPCMH);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	protected BCNFILCOKNN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public abstract class CFBOPGBDKIB<TKey> : BCNFILCOKNN<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate string JDHMPDHFHKF(TKey OEOMDKHBDFI);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x587C810", Offset = "0x587BC10", VA = "0x18587C810")]
	private static string JCEEKFIFJLJ(TKey OEOMDKHBDFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x587C9B0", Offset = "0x587BDB0", VA = "0x18587C9B0", Slot = "4")]
	public override string JDCJPDKDNFL(OGAFCBAEIIJ<TKey> BKBOMPKPCMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x587C850", Offset = "0x587BC50", VA = "0x18587C850")]
	public string JDCJPDKDNFL(OGAFCBAEIIJ<TKey> BKBOMPKPCMH, [NotNull] JDHMPDHFHKF EHBHGGAKPBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string DALHDBFJDOI(OGAFCBAEIIJ<TKey> BKBOMPKPCMH, [NotNull] JDHMPDHFHKF EHBHGGAKPBN);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x426C960", Offset = "0x426BD60", VA = "0x18426C960")]
	protected CFBOPGBDKIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class EGMJGLNFDCC<TKey> : BCNFILCOKNN<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate string GEJJFBCOHKB(TKey OEOMDKHBDFI);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly string FJLBGAADACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly double CPOKDFCMALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly bool BKAGCICOINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly int OJFOPODJLDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly ISet<string> CELPNPFNDDE;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3B68F30", Offset = "0x3B68330", VA = "0x183B68F30")]
	private static string JCEEKFIFJLJ(TKey OEOMDKHBDFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3B69810", Offset = "0x3B68C10", VA = "0x183B69810")]
	public EGMJGLNFDCC(string FJLBGAADACF = "F2", double CPOKDFCMALA = double.MaxValue, bool BKAGCICOINC = false, int OJFOPODJLDH = int.MaxValue, [Optional] ISet<string> CELPNPFNDDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3B68F70", Offset = "0x3B68370", VA = "0x183B68F70", Slot = "4")]
	public override Dictionary<string, string> JDCJPDKDNFL(OGAFCBAEIIJ<TKey> BKBOMPKPCMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3B68E60", Offset = "0x3B68260", VA = "0x183B68E60")]
	private bool GKOCCGNFMHI(string ENKJPIPMDKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3B69060", Offset = "0x3B68460", VA = "0x183B69060")]
	public Dictionary<string, string> JDCJPDKDNFL(OGAFCBAEIIJ<TKey> BKBOMPKPCMH, GEJJFBCOHKB EHBHGGAKPBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3B68BE0", Offset = "0x3B67FE0", VA = "0x183B68BE0")]
	private string ENOCDHDEDPM(StringBuilder KDHOAHMOLJA, List<TKey> AONAIPJHNKM, GEJJFBCOHKB EHBHGGAKPBN, bool JMJLDAIJLIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3B696B0", Offset = "0x3B68AB0", VA = "0x183B696B0")]
	private static void KBJOLGJGCJK(StringBuilder FJDHPKDGLGE, string IGFIALMPAFL, bool LCNMCNOLDGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class FOCMLHIIAPH<TKey> : CFBOPGBDKIB<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct FICLACIIJID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public JDHMPDHFHKF keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static FOCMLHIIAPH<TKey> GJPJBBHLIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly string[] COOOLKEOJJM;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3F64E00", Offset = "0x3F64200", VA = "0x183F64E00")]
	private FOCMLHIIAPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3F63D40", Offset = "0x3F63140", VA = "0x183F63D40", Slot = "5")]
	protected override string DALHDBFJDOI(OGAFCBAEIIJ<TKey> BKBOMPKPCMH, JDHMPDHFHKF EHBHGGAKPBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3F64BA0", Offset = "0x3F63FA0", VA = "0x183F64BA0")]
	[CompilerGenerated]
	internal static string LNAIEGCCAAE(string AFADJPFBPKB, TKey OEOMDKHBDFI, FICLACIIJID P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class JFIBMNDGCJD : OGAFCBAEIIJ<string>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class EBPJDGAKGMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Action<JFIBMNDGCJD, FLILHMOBPPM> callback;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public EBPJDGAKGMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6D9DED0", Offset = "0x6D9D2D0", VA = "0x186D9DED0")]
		internal void PLEPNCPEFBB(OGAFCBAEIIJ<string> timer, FLILHMOBPPM log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6D9EFA0", Offset = "0x6D9E3A0", VA = "0x186D9EFA0")]
	public JFIBMNDGCJD(FLILHMOBPPM APPINHJJCPL, [Optional] string OHNLDFKLCDA, [Optional] int? HJPFAOMOAHB, [Optional] Stopwatch OOBCNKBCDNB, [Optional] Action<string, IMHEBAELAHI, FLILHMOBPPM> AKKMKAMHLCB, [Optional] Action<string, IMHEBAELAHI, FLILHMOBPPM> HGDKPDNNGGJ, [Optional] Action<JFIBMNDGCJD, FLILHMOBPPM> HHBHGDNJPON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6D9EEE0", Offset = "0x6D9E2E0", VA = "0x186D9EEE0")]
	private static Action<OGAFCBAEIIJ<string>, FLILHMOBPPM> OKJACGBPAPD(Action<JFIBMNDGCJD, FLILHMOBPPM> JMKLCPOKHHP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public abstract class IACLJDFJBKN
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private class KILIAMEEBDO : IACLJDFJBKN
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static IACLJDFJBKN GJPJBBHLIHD
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x6D9F0F0", Offset = "0x6D9E4F0", VA = "0x186D9F0F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override float HGICEBNEEIO
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0xC73530", Offset = "0xC72930", VA = "0x180C73530", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6D9F1E0", Offset = "0x6D9E5E0", VA = "0x186D9F1E0")]
		public KILIAMEEBDO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static IACLJDFJBKN MEGIDGGMLNG;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static IACLJDFJBKN BONGJJLJANI
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6D9E490", Offset = "0x6D9D890", VA = "0x186D9E490")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public abstract float HGICEBNEEIO
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	protected IACLJDFJBKN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface NDCHECJCLID : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool ANJBFCDOFPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface GHMLKDLFDEG<T> : NDCHECJCLID, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	[NotNull]
	Task<T> DNFJJDIKMGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	[NotNull]
	MJGAHFINLMO<T> GAFMPDKNOKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class OFNKIAEMFMO
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2FFF640", Offset = "0x2FFEA40", VA = "0x182FFF640")]
	public static GHMLKDLFDEG<TResource> JFKKLOFDBBK<TResource, TId>(this IPJNHCBKGPM<TId, TResource> OJLLLCEEJNF, TId NKPCGMJMEIE, [Optional] Func<TId, CancellationToken, Task<TResource>>? HAMCBAGBBLB) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class LIHELPNENNI
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private sealed class GDBFBPODHOK<T> : MDPHLEPHNGE<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override Task<T?> DNFJJDIKMGI
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override MJGAHFINLMO<T?> GAFMPDKNOKH
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x8A89D0", Offset = "0x8A7DD0", VA = "0x1808A89D0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x40877A0", Offset = "0x4086BA0", VA = "0x1840877A0")]
		public GDBFBPODHOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "10")]
		protected override void JHLJDCFNHGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private sealed class CCCELDJDHOM<T> : MDPHLEPHNGE<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly T JJJEFNDPACF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly Action<T>? DALHKNMLENC;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override Task<T> DNFJJDIKMGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x8AD870", Offset = "0x8ACC70", VA = "0x1808AD870", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override MJGAHFINLMO<T> GAFMPDKNOKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x8AD4C0", Offset = "0x8AC8C0", VA = "0x1808AD4C0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x548C650", Offset = "0x548BA50", VA = "0x18548C650")]
		public CCCELDJDHOM(T INOPIMDINAD, Action<T>? LCFBAKMEMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x548C5A0", Offset = "0x548B9A0", VA = "0x18548C5A0", Slot = "10")]
		protected override void JHLJDCFNHGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private sealed class MPGFKBIHKNE<T> : MDPHLEPHNGE<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override Task<T> DNFJJDIKMGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override MJGAHFINLMO<T> GAFMPDKNOKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x8A89D0", Offset = "0x8A7DD0", VA = "0x1808A89D0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x48557C0", Offset = "0x4854BC0", VA = "0x1848557C0")]
		public MPGFKBIHKNE(Exception CDCDIGHMBPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "10")]
		protected override void JHLJDCFNHGN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private sealed class ENMKLJHENJA<T> : MDPHLEPHNGE<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct AAMEADANDPB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public Task<GHMLKDLFDEG<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private TaskAwaiter<GHMLKDLFDEG<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x3FC8D00", Offset = "0x3FC8100", VA = "0x183FC8D00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x3FC9240", Offset = "0x3FC8640", VA = "0x183FC9240", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private struct NDGNDLBFJLI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public Task<GHMLKDLFDEG<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private TaskAwaiter<GHMLKDLFDEG<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x48C06F0", Offset = "0x48BFAF0", VA = "0x1848C06F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x48C0BD0", Offset = "0x48BFFD0", VA = "0x1848C0BD0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly Task<GHMLKDLFDEG<T>> CDPANNPEKGH;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override Task<T> DNFJJDIKMGI
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x8A89D0", Offset = "0x8A7DD0", VA = "0x1808A89D0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override MJGAHFINLMO<T> GAFMPDKNOKH
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x8AD890", Offset = "0x8ACC90", VA = "0x1808AD890", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3BAE6C0", Offset = "0x3BADAC0", VA = "0x183BAE6C0")]
		public ENMKLJHENJA(Task<GHMLKDLFDEG<T>> IALOMLEGCDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3BAE2A0", Offset = "0x3BAD6A0", VA = "0x183BAE2A0", Slot = "10")]
		protected override void JHLJDCFNHGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3BAE540", Offset = "0x3BAD940", VA = "0x183BAE540")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(ENMKLJHENJA<>.AAMEADANDPB))]
		internal static Task<T> OHENIHIGABD(Task<GHMLKDLFDEG<T>> IALOMLEGCDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3BAE1B0", Offset = "0x3BAD5B0", VA = "0x183BAE1B0")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(ENMKLJHENJA<>.NDGNDLBFJLI))]
		internal static Task EJJBMJCJIAO(Task<GHMLKDLFDEG<T>> IALOMLEGCDH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class LNLLHPLHCNM<TIn, TOut> : MDPHLEPHNGE<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct JDGLBHGPBOO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public AsyncTaskMethodBuilder<TOut> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public Func<TIn, TOut> transformFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public Task<TIn> innerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private Func<TIn, TOut> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private TaskAwaiter<TIn> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x44144F0", Offset = "0x44138F0", VA = "0x1844144F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x4414870", Offset = "0x4413C70", VA = "0x184414870", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly GHMLKDLFDEG<TIn> NMABMAOIPAO;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<TOut> DNFJJDIKMGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x8A89D0", Offset = "0x8A7DD0", VA = "0x1808A89D0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override MJGAHFINLMO<TOut> GAFMPDKNOKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x8AD890", Offset = "0x8ACC90", VA = "0x1808AD890", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x45ED6C0", Offset = "0x45ECAC0", VA = "0x1845ED6C0")]
		public LNLLHPLHCNM(GHMLKDLFDEG<TIn> LHAGFDMKOOG, Func<TIn, TOut> DOJHEDEGJPP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x45ED670", Offset = "0x45ECA70", VA = "0x1845ED670", Slot = "10")]
		protected override void JHLJDCFNHGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x45ED490", Offset = "0x45EC890", VA = "0x1845ED490")]
		[AsyncStateMachine(typeof(LNLLHPLHCNM<, >.JDGLBHGPBOO))]
		[CompilerGenerated]
		internal static Task<TOut> HKPNCJKJHMJ(Task<TIn> CAGPKDGNEEB, Func<TIn, TOut> DOJHEDEGJPP)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2F06760", Offset = "0x2F05B60", VA = "0x182F06760")]
	public static GHMLKDLFDEG<T> JFFGEEEAJID<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x2F066B0", Offset = "0x2F05AB0", VA = "0x182F066B0")]
	public static GHMLKDLFDEG<T> AOIMBFJCIMB<T>(T IPNDOKDOGDG, [Optional] Action<T>? LCFBAKMEMIB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2C61870", Offset = "0x2C60C70", VA = "0x182C61870")]
	public static GHMLKDLFDEG<T> AJIMBKJAJPJ<T>(Exception CDCDIGHMBPL) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x2C61870", Offset = "0x2C60C70", VA = "0x182C61870")]
	public static GHMLKDLFDEG<T> DBKPBHCALGM<T>(Task<GHMLKDLFDEG<T>> IALOMLEGCDH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2C63150", Offset = "0x2C62550", VA = "0x182C63150")]
	public static GHMLKDLFDEG<TOut> BDJMNGJGEPI<TOut, TIn>(GHMLKDLFDEG<TIn> KNOJBNNAGCL, Func<TIn, TOut> DOJHEDEGJPP) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public abstract class MDPHLEPHNGE<T> : GHMLKDLFDEG<T>, NDCHECJCLID, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly string BNNGOJPIFEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly BMHLGBBDJOD HPHIAFKHBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private bool NLOIKEFMMEI;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool ANJBFCDOFPB
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xE51E90", Offset = "0xE51290", VA = "0x180E51E90", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public abstract Task<T> DNFJJDIKMGI
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public abstract MJGAHFINLMO<T> GAFMPDKNOKH
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x47BF220", Offset = "0x47BE620", VA = "0x1847BF220")]
	public MDPHLEPHNGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x47BEE70", Offset = "0x47BE270", VA = "0x1847BEE70", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void JHLJDCFNHGN();
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public abstract class PIJMIAHNECG<TTask, T> : MDPHLEPHNGE<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class OCEOEBPOOKA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public OCEOEBPOOKA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x38781F0", Offset = "0x38775F0", VA = "0x1838781F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x38784C0", Offset = "0x38778C0", VA = "0x1838784C0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public PIJMIAHNECG<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public OCEOEBPOOKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x4A09C30", Offset = "0x4A09030", VA = "0x184A09C30")]
		[AsyncStateMachine(typeof(PIJMIAHNECG<, >.OCEOEBPOOKA.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> IPMMEJNJCAG(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly Task<T> IALOMLEGCDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	protected readonly CancellationTokenSource INALIICJMHK;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public override Task<T> DNFJJDIKMGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public override MJGAHFINLMO<T> GAFMPDKNOKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8A89D0", Offset = "0x8A7DD0", VA = "0x1808A89D0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x4B1D1E0", Offset = "0x4B1C5E0", VA = "0x184B1D1E0")]
	protected PIJMIAHNECG(TTask IALOMLEGCDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x4B1CF80", Offset = "0x4B1C380", VA = "0x184B1CF80", Slot = "10")]
	protected override void JHLJDCFNHGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T IILEIHFANKH(TTask KKJNDDBELMF);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void PKGFFKOHEMB();
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class HBNDNPPJMCF<T> : MDPHLEPHNGE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly KEACOJOOGKI<Task<T>> HMEJPAGMLNC;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public override Task<T> DNFJJDIKMGI
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3FC3D40", Offset = "0x3FC3140", VA = "0x183FC3D40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public override MJGAHFINLMO<T> GAFMPDKNOKH
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8A89D0", Offset = "0x8A7DD0", VA = "0x1808A89D0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x41177E0", Offset = "0x4116BE0", VA = "0x1841177E0")]
	public HBNDNPPJMCF(KEACOJOOGKI<Task<T>> KGHDLGAKPAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x41177C0", Offset = "0x4116BC0", VA = "0x1841177C0", Slot = "10")]
	protected override void JHLJDCFNHGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class ILMLJKPAEFA
{
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static readonly HashAlgorithmName OHCPLMGBEHE;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly ThreadLocal<IncrementalHash> GBHOKONJJFK;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6D9E5F0", Offset = "0x6D9D9F0", VA = "0x186D9E5F0")]
	public static int GIAGJNKAAGJ(this NNDLMACIFIG LGDBIGHFLAJ, IncrementalHash ACNHEEAHLIA, byte[] FHBNJHNDAPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6D9EA10", Offset = "0x6D9DE10", VA = "0x186D9EA10")]
	public static bool LCCCNLAILKN([CanBeNull] this NNDLMACIFIG LGDBIGHFLAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6D9E700", Offset = "0x6D9DB00", VA = "0x186D9E700")]
	public static bool LCCCNLAILKN([CanBeNull] this NNDLMACIFIG LGDBIGHFLAJ, [Out] string MEDJAOOGFHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6D9EA70", Offset = "0x6D9DE70", VA = "0x186D9EA70")]
	public static bool LCCCNLAILKN([CanBeNull] this NNDLMACIFIG LGDBIGHFLAJ, IncrementalHash ACNHEEAHLIA, byte[] FHBNJHNDAPN, [Out] string MEDJAOOGFHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6D9E670", Offset = "0x6D9DA70", VA = "0x186D9E670")]
	private static bool IMFAPBIHMBM(byte[] OBKDNKMLHLP, Span<byte> GGBEKEJNPKE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class AFHDEHIADMP
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6D9D970", Offset = "0x6D9CD70", VA = "0x186D9D970")]
	public static int KBFHAHEEPHH(HashAlgorithmName EFOIFAEFCHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6D9D710", Offset = "0x6D9CB10", VA = "0x186D9D710")]
	public static int GIAGJNKAAGJ(this ELDAOEFJOLH JJAFEIHOFLN, byte[] GCEFOABCPEK, IncrementalHash ACNHEEAHLIA, byte[] PCCLIKNHNBB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface ELDAOEFJOLH
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash ACNHEEAHLIA);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface NNDLMACIFIG : ELDAOEFJOLH
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	[CanBeNull]
	byte[] IFKDOGIPDPE
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	[CanBeNull]
	byte[] PNLPOEFEOIE
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class LEOHGKOGGIO
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static bool KIDKELCPMKB;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly ArrayPool<byte> AGHDIFGBIBF;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly ArrayPool<char> DHDKACCINLM;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly Encoding KBPPOBEIKBF;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly ThreadLocal<Encoder> MGLAPGHMHFO;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x2F04930", Offset = "0x2F03D30", VA = "0x182F04930")]
	public static void HOMPBPKOKKN<T>(this IncrementalHash IJCAKIMPPBF, [CanBeNull] T GKPPNECBJFF) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2F04380", Offset = "0x2F03780", VA = "0x182F04380")]
	public static void ALKCOOGGLIF<T>(this IncrementalHash IJCAKIMPPBF, [CanBeNull] T JJAFEIHOFLN) where T : ELDAOEFJOLH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x2F04410", Offset = "0x2F03810", VA = "0x182F04410")]
	public static void BAGBIACCBEP<T>(this IncrementalHash IJCAKIMPPBF, [CanBeNull] IList<T> OFFBIAIBPCD) where T : ELDAOEFJOLH
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6D9F590", Offset = "0x6D9E990", VA = "0x186D9F590")]
	private static bool CAJJPFFNMIP([CanBeNull] ELDAOEFJOLH JJAFEIHOFLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6D9F620", Offset = "0x6D9EA20", VA = "0x186D9F620")]
	public static void FOIDJBFICJD(this IncrementalHash ACNHEEAHLIA, string? IPHHFAIJKJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6D9FF90", Offset = "0x6D9F390", VA = "0x186D9FF90")]
	public static void MMDKNFMMFPK(this IncrementalHash ACNHEEAHLIA, long CAKOFGKDGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6D9FCB0", Offset = "0x6D9F0B0", VA = "0x186D9FCB0")]
	public static void MGBMDAPJMGO(this IncrementalHash ACNHEEAHLIA, int JMKAJEFKMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6D9FA20", Offset = "0x6D9EE20", VA = "0x186D9FA20")]
	public static void GCIADELMPBO(this IncrementalHash ACNHEEAHLIA, short JLDOOFPNDJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6D9FE80", Offset = "0x6D9F280", VA = "0x186D9FE80")]
	public static void MLAAKDGCMPE(this IncrementalHash ACNHEEAHLIA, byte DDBFOBEJCNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6D9F230", Offset = "0x6D9E630", VA = "0x186D9F230")]
	public static void ADOGPDJNMPP(this IncrementalHash ACNHEEAHLIA, bool CPNFGDJAMLB, bool MENOHCNADFJ = false, bool AAPGEEMICGC = false, bool OGKPPDAAPPL = false, bool JOACJFCPDHH = false, bool MAOPOOFGKEG = false, bool KNFCPLOKFFD = false, bool FGAMMMGGJGD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x2F049F0", Offset = "0x2F03DF0", VA = "0x182F049F0")]
	public static void PKENACBIKGM<T>(this IncrementalHash ACNHEEAHLIA, T GLEGKLPKAOM) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6D9FC50", Offset = "0x6D9F050", VA = "0x186D9FC50")]
	public static void JAEDLPOMFAH(this IncrementalHash ACNHEEAHLIA, float CGJHPHCGBFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6D9FBF0", Offset = "0x6D9EFF0", VA = "0x186D9FBF0")]
	public static void GPNJJFIJDDD(this IncrementalHash ACNHEEAHLIA, ulong LJALMKFPNBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6D9F530", Offset = "0x6D9E930", VA = "0x186D9F530")]
	public static void BKMKFEPGLNA(this IncrementalHash ACNHEEAHLIA, uint BHIJHKLHAJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6D9F4D0", Offset = "0x6D9E8D0", VA = "0x186D9F4D0")]
	public static void APIBJAFMBHP(this IncrementalHash ACNHEEAHLIA, ushort BFGLCGANLAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6D9F3A0", Offset = "0x6D9E7A0", VA = "0x186D9F3A0")]
	public static void APDIJFABLAM(this IncrementalHash ACNHEEAHLIA, Vector3 MLOKILLMJAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class AGCIKNKKEEC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6D9DAC0", Offset = "0x6D9CEC0", VA = "0x186D9DAC0")]
	public AGCIKNKKEEC(string MOKGCFCFCPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public abstract class IJFCDMMMFID<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	internal class JHFNMPDJPEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public TNode MCPMOAEEEOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public TNode DEDHJMDEEIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public HEAFDBKIJPB OACLGAKONPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public List<HEAFDBKIJPB> LGIPOGINGLO;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public JHFNMPDJPEI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal struct HEAFDBKIJPB : IComparable<HEAFDBKIJPB>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public int ALEEOPFLOLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public TClaimant BACADJPMNOJ;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x10957B0", Offset = "0x1094BB0", VA = "0x1810957B0")]
		public HEAFDBKIJPB(int ALEEOPFLOLJ, TClaimant BACADJPMNOJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x4120470", Offset = "0x411F870", VA = "0x184120470")]
		public bool KHJHCGBJKJM([In] HEAFDBKIJPB KNLMODPGFOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x4120460", Offset = "0x411F860", VA = "0x184120460")]
		public bool GFHDDFIOPPF([In] HEAFDBKIJPB KNLMODPGFOA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x4120450", Offset = "0x411F850", VA = "0x184120450", Slot = "4")]
		public int CompareTo(HEAFDBKIJPB KNLMODPGFOA)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x41204D0", Offset = "0x411F8D0", VA = "0x1841204D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public enum CLADAGJANLJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class GKCIKHBLPCB : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public IJFCDMMMFID<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x9EB7D0", Offset = "0x9EABD0", VA = "0x1809EB7D0")]
		[DebuggerHidden]
		public GKCIKHBLPCB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x40B7E50", Offset = "0x40B7250", VA = "0x1840B7E50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x40B8030", Offset = "0x40B7430", VA = "0x1840B8030", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x40B7F30", Offset = "0x40B7330", VA = "0x1840B7F30", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3E9EA40", Offset = "0x3E9DE40", VA = "0x183E9EA40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly JAJEACLLCPM<JHFNMPDJPEI> HPHGABIJDFD;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly JAJEACLLCPM<List<HEAFDBKIJPB>> DNHKAFCOBIN;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static int IDPJLCHBMKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	internal readonly Dictionary<TClaimant, TNode> IEDGFIKKNDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	internal readonly Dictionary<TNode, JHFNMPDJPEI> MMOBLIPKHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private CLADAGJANLJ GJELEMMNCEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool INBIMOFIBDA;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode IPAKFDELFFC(TNode EKHCANKHNFM);

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void DOJBMPAOCKH(TNode EKHCANKHNFM, TClaimant HHAINKNIKPL, TClaimant JKFGIHNCKBN);

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x425BDD0", Offset = "0x425B1D0", VA = "0x18425BDD0")]
	public IJFCDMMMFID(CLADAGJANLJ GJELEMMNCEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x425BB20", Offset = "0x425AF20", VA = "0x18425BB20")]
	public void OFLAGOECHIP(TNode EKHCANKHNFM, TNode LNNICEPGDAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x425B0F0", Offset = "0x425A4F0", VA = "0x18425B0F0")]
	public void IGDFOPIEDOF(TClaimant BACADJPMNOJ, TNode KBLBHNNHCFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x425AA90", Offset = "0x4259E90", VA = "0x18425AA90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x425A630", Offset = "0x4259A30", VA = "0x18425A630")]
	private void DEDENIEFOMM(TClaimant BACADJPMNOJ, TNode LALKLGGFAID, TNode KBLBHNNHCFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x425ADB0", Offset = "0x425A1B0", VA = "0x18425ADB0")]
	private int FKDGCIKABEF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x425B7C0", Offset = "0x425ABC0", VA = "0x18425B7C0")]
	private void MEMJAFJCCEM(TClaimant BACADJPMNOJ, TNode LHOLHEPHJBI, TNode NLHLJAMHHNB, int KKHDHEIDEKE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x425B3B0", Offset = "0x425A7B0", VA = "0x18425B3B0")]
	private void KHCBMDNLHIO(HEAFDBKIJPB DIFEAAJGPKF, JHFNMPDJPEI BDAAIBDOCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x425A1C0", Offset = "0x42595C0", VA = "0x18425A1C0")]
	private void APDGBGBOKDB(TClaimant BACADJPMNOJ, TNode LHOLHEPHJBI, TNode NLHLJAMHHNB, int KKHDHEIDEKE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x425AFB0", Offset = "0x425A3B0", VA = "0x18425AFB0")]
	private void HJAJKOOBPPP(HEAFDBKIJPB DIFEAAJGPKF, TNode EKHCANKHNFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x425A4C0", Offset = "0x42598C0", VA = "0x18425A4C0")]
	private void COIDKGPENGD(HEAFDBKIJPB DIFEAAJGPKF, JHFNMPDJPEI BDAAIBDOCNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x425B660", Offset = "0x425AA60", VA = "0x18425B660")]
	private void LCMLKENMGBH(JHFNMPDJPEI BDAAIBDOCNE, bool PNNNMONMAAF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x425A700", Offset = "0x4259B00", VA = "0x18425A700")]
	private void DKGBOCMCDGB(JHFNMPDJPEI BDAAIBDOCNE, TNode LNNICEPGDAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x425ACB0", Offset = "0x425A0B0", VA = "0x18425ACB0")]
	[IteratorStateMachine(typeof(IJFCDMMMFID<, >.GKCIKHBLPCB))]
	private IEnumerable<TNode> ENKJPEHCFBC(TNode LHOLHEPHJBI, TNode NLHLJAMHHNB, bool EJDOEABDMDA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x425B290", Offset = "0x425A690", VA = "0x18425B290")]
	private JHFNMPDJPEI JJOGLMLAPEE(TNode EKHCANKHNFM, TNode DEDHJMDEEIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x425AE20", Offset = "0x425A220", VA = "0x18425AE20")]
	private JHFNMPDJPEI HHFBHOCEMNM(TNode EKHCANKHNFM, TNode DEDHJMDEEIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x425B490", Offset = "0x425A890", VA = "0x18425B490")]
	private void LBLOIDPAGJD(JHFNMPDJPEI BDAAIBDOCNE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class JOOHFHAKFAD<T> : IEnumerable<JOOHFHAKFAD<T>.PJDHPLPMGCI>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public struct PJDHPLPMGCI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public T EEPLCHCGAIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public int HAJICDLBEKC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class LODLKEPFLPP : IEnumerator<PJDHPLPMGCI>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private JOOHFHAKFAD<T> JBDFBNJNGAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private int HAJICDLBEKC;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x3BC7850", Offset = "0x3BC6C50", VA = "0x183BC7850", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public PJDHPLPMGCI GKCMOMIKDKD
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x45EE2B0", Offset = "0x45ED6B0", VA = "0x1845EE2B0", Slot = "4")]
			get
			{
				return default(PJDHPLPMGCI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x45EE1C0", Offset = "0x45ED5C0", VA = "0x1845EE1C0")]
		public LODLKEPFLPP(JOOHFHAKFAD<T> JBDFBNJNGAL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x45EE140", Offset = "0x45ED540", VA = "0x1845EE140", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3C1F8B0", Offset = "0x3C1ECB0", VA = "0x183C1F8B0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xBFA6A0", Offset = "0xBF9AA0", VA = "0x180BFA6A0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private struct CKGLAKOLJEF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public bool MFILHJGDJHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public T EEPLCHCGAIN;
	}

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private const int AJIHONFBHLG = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly Dictionary<T, int> DHGMLFDFMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private CKGLAKOLJEF[] PGHLCAELJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private int PICDAAGMGBL;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public int BEFAGPFGGPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8E9CC0", Offset = "0x8E90C0", VA = "0x1808E9CC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8E93A0", Offset = "0x8E87A0", VA = "0x1808E93A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public int ICBOPDBFFOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x388A9A0", Offset = "0x3889DA0", VA = "0x18388A9A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x4431350", Offset = "0x4430750", VA = "0x184431350")]
	public JOOHFHAKFAD(int BIMLHBENMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x4430F10", Offset = "0x4430310", VA = "0x184430F10")]
	public JOOHFHAKFAD(PJDHPLPMGCI[] FMMDJMFDGIL, bool FFOCJGHBMAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x4430CE0", Offset = "0x44300E0", VA = "0x184430CE0")]
	public int LHLJHLFCNNK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x442FFB0", Offset = "0x442F3B0", VA = "0x18442FFB0")]
	private int FLHLCIPLDFN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x4430C80", Offset = "0x4430080", VA = "0x184430C80", Slot = "6")]
	protected virtual uint LEJBEDIHJOG(uint ACNHEEAHLIA, T EEPLCHCGAIN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x4430DB0", Offset = "0x44301B0", VA = "0x184430DB0")]
	public bool MMGNJIFNHBF(T EEPLCHCGAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x44304A0", Offset = "0x442F8A0", VA = "0x1844304A0")]
	public int GIJCNGIJALM(T EEPLCHCGAIN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x4430BC0", Offset = "0x442FFC0", VA = "0x184430BC0")]
	public T KNHFAJNBGBJ(int HAJICDLBEKC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x4430880", Offset = "0x442FC80", VA = "0x184430880")]
	public bool JOOFMAMJLCK(T EEPLCHCGAIN, bool MEOJDBNDAAH = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x4430950", Offset = "0x442FD50", VA = "0x184430950")]
	public bool JOOFMAMJLCK(T EEPLCHCGAIN, int HAJICDLBEKC, bool MEOJDBNDAAH = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x4430580", Offset = "0x442F980", VA = "0x184430580")]
	private int IJOJLPNNIDK(int PGAHHGFJKBL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x4430E70", Offset = "0x4430270", VA = "0x184430E70", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x4430E70", Offset = "0x4430270", VA = "0x184430E70", Slot = "4")]
	private IEnumerator<PJDHPLPMGCI> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class JAJEACLLCPM<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly Stack<T> OKEFGGEHACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly List<T> GMKDFAODOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly int IBGFBKBFMOD;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x440B270", Offset = "0x440A670", VA = "0x18440B270")]
	public static JAJEACLLCPM<T> BLNADDGBAFM(int BIMLHBENMHO = 0, int IBGFBKBFMOD = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x440B840", Offset = "0x440AC40", VA = "0x18440B840")]
	public static JAJEACLLCPM<T> IAPENEOEAGA(int BIMLHBENMHO = 0, int IBGFBKBFMOD = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x440BC60", Offset = "0x440B060", VA = "0x18440BC60")]
	public JAJEACLLCPM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x440BA40", Offset = "0x440AE40", VA = "0x18440BA40")]
	public JAJEACLLCPM(int BIMLHBENMHO, int IBGFBKBFMOD = int.MaxValue, bool CEENJEMLDAK = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x440B090", Offset = "0x440A490", VA = "0x18440B090")]
	public T BJKLPNDFDNG()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x440B750", Offset = "0x440AB50", VA = "0x18440B750")]
	public void HNEMOMPNNFO(T EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x440B940", Offset = "0x440AD40", VA = "0x18440B940")]
	private void KFAEGIPJIJK(T EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x440B500", Offset = "0x440A900", VA = "0x18440B500")]
	private void EIAOHNGDGHD(T EEPLCHCGAIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x440B370", Offset = "0x440A770", VA = "0x18440B370", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x440B550", Offset = "0x440A950", VA = "0x18440B550")]
	private void GBHAHCPPBCK(IEnumerable<T> BFAMJIIMLEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class GODBDNNGBKF<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private Dictionary<int, T> BNDGLAGJGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private T BMPOKGHJLME;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public virtual T CGCDELDKFHP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8A8970", Offset = "0x8A7D70", VA = "0x1808A8970", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x40C29E0", Offset = "0x40C1DE0", VA = "0x1840C29E0")]
	public bool GJNKIFOCKMF(T EEPLCHCGAIN, int ALEEOPFLOLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x40C22D0", Offset = "0x40C16D0", VA = "0x1840C22D0")]
	public bool BGGIECNKLKA(int ALEEOPFLOLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x40C2380", Offset = "0x40C1780", VA = "0x1840C2380")]
	public T DDDLONMJJJO(int MLPPFNGKECD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x40C28A0", Offset = "0x40C1CA0", VA = "0x1840C28A0")]
	private bool ECFHIGPMJOD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x40C2B40", Offset = "0x40C1F40", VA = "0x1840C2B40")]
	public bool LCKMIEGKAOE(int ALEEOPFLOLJ, [Out] T EEPLCHCGAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x40C2BA0", Offset = "0x40C1FA0", VA = "0x1840C2BA0")]
	public GODBDNNGBKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class POPKHCKJKEJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	protected struct POAFJDLDLDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public T EEMLDMGPOLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public int BOMPAKPLOGP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	protected readonly List<POAFJDLDLDJ> MCOPGCLGFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private T ONIELPAKJBO;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public int ICBOPDBFFOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x388A9A0", Offset = "0x3889DA0", VA = "0x18388A9A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x4B31340", Offset = "0x4B30740", VA = "0x184B31340")]
	public bool FLEJEGPKCKH(T EEPLCHCGAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x4B31A10", Offset = "0x4B30E10", VA = "0x184B31A10")]
	public void LEFBGNCKNFL(T EEPLCHCGAIN, int ALEEOPFLOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x4B30C80", Offset = "0x4B30080", VA = "0x184B30C80")]
	public bool BJFEGIDGDBE(T EEPLCHCGAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x4B31880", Offset = "0x4B30C80", VA = "0x184B31880")]
	public void KMNEPMPOIBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x4B31740", Offset = "0x4B30B40", VA = "0x184B31740")]
	public T KGJOMNFCKKM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x4B311B0", Offset = "0x4B305B0", VA = "0x184B311B0")]
	protected void FEKENHKCOIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x4B31AD0", Offset = "0x4B30ED0", VA = "0x184B31AD0")]
	public POPKHCKJKEJ()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		[SerializeField]
		[AIBPGBFCHJI(OPJKPNFINLK.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x6DA1730", Offset = "0x6DA0B30", VA = "0x186DA1730")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x6DA1A00", Offset = "0x6DA0E00", VA = "0x186DA1A00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x6DA1910", Offset = "0x6DA0D10", VA = "0x186DA1910")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x6DA1680", Offset = "0x6DA0A80", VA = "0x186DA1680")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x6DA1950", Offset = "0x6DA0D50", VA = "0x186DA1950")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x6DA1860", Offset = "0x6DA0C60", VA = "0x186DA1860")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x6DA1600", Offset = "0x6DA0A00", VA = "0x186DA1600")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x4CFF450", Offset = "0x4CFE850", VA = "0x184CFF450", Slot = "4")]
		public virtual T LJGEACHONKD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class LKAMNCPDFHM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private Dictionary<byte, GNNHAGACLCH> FPNAIFPGBGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private readonly JAJEACLLCPM<GNNHAGACLCH> LPKLHNJFPBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly bool OKPGEEFOBNM;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public GNNHAGACLCH BMGHFFBMPND
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8AAD20", Offset = "0x8AA120", VA = "0x1808AAD20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Vector2 GMANKOJKBGF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xFEBD90", Offset = "0xFEB190", VA = "0x180FEBD90")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x13315A0", Offset = "0x13309A0", VA = "0x1813315A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	private Vector2 OGPKMOEAMAI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x9A2B50", Offset = "0x9A1F50", VA = "0x1809A2B50")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Vector2 FHCHMFECKEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6DA0450", Offset = "0x6D9F850", VA = "0x186DA0450")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8B2C70", Offset = "0x8B2070", VA = "0x1808B2C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int OPEICHMLPKC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8AD880", Offset = "0x8ACC80", VA = "0x1808AD880")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8AD8A0", Offset = "0x8ACCA0", VA = "0x1808AD8A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6DA1400", Offset = "0x6DA0800", VA = "0x186DA1400")]
	public LKAMNCPDFHM(Bounds GACOMEPNEBH, Vector2[] FFFGAIKGLJP, int CNNJFJEHFOF, byte PGAHHGFJKBL, float JEIPIHIELBD = 0f, [Optional] JAJEACLLCPM<GNNHAGACLCH> LPKLHNJFPBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6DA0C00", Offset = "0x6DA0000", VA = "0x186DA0C00")]
	public void JEIPHLGCNII(Bounds GACOMEPNEBH, Vector2[] FFFGAIKGLJP, int CNNJFJEHFOF, byte PGAHHGFJKBL, float JEIPIHIELBD = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6DA13A0", Offset = "0x6DA07A0", VA = "0x186DA13A0")]
	public GNNHAGACLCH OCHMGJEPCDL(byte HAJICDLBEKC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6DA12D0", Offset = "0x6DA06D0", VA = "0x186DA12D0")]
	public void MGLEFBANFDE(Vector3 CLHMEGFDOKF, float DPHLDIMPPEF, float ACIPFCHKMFF, List<byte> JNCNCLMHNIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6DA1090", Offset = "0x6DA0490", VA = "0x186DA1090")]
	public void LOMMKEMNHPA(GNNHAGACLCH.NMBFLJNFHKL GINPNFOAGMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6DA0B20", Offset = "0x6D9FF20", VA = "0x186DA0B20")]
	public static int HJPBHAABGDA(Vector2[] FFFGAIKGLJP, int CNNJFJEHFOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6DA08F0", Offset = "0x6D9FCF0", VA = "0x186DA08F0")]
	private GNNHAGACLCH HHGFFENOMPH(byte HAJICDLBEKC, GNNHAGACLCH.GIMDNAFEELO PIMPPMBCEPE, GNNHAGACLCH DEDHJMDEEIE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6DA0530", Offset = "0x6D9F930", VA = "0x186DA0530")]
	private void GLGCJGBDFMJ(GNNHAGACLCH DEDHJMDEEIE, Vector2[] FFFGAIKGLJP, int OAIMEFOANGJ, int KELEAHPDOEI, int OLMIJNKHDFE, int EDMPJMPHGMI, float JEIPIHIELBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6DA10B0", Offset = "0x6DA04B0", VA = "0x186DA10B0")]
	private void MCIDIPACPLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6DA0470", Offset = "0x6D9F870", VA = "0x186DA0470", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6DA04D0", Offset = "0x6D9F8D0", VA = "0x186DA04D0", Slot = "1")]
	~LKAMNCPDFHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class GNNHAGACLCH
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public enum GIMDNAFEELO
	{
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public enum NMBFLJNFHKL
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public byte DMJALGAFDNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public Vector3 MCBKCBKCLHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public Vector3 GDNEEEAIONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public Vector3 NPOABNJGPMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public Vector3 NOOEJNBKAFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public GIMDNAFEELO HKAPBMPMGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public GNNHAGACLCH CNLABKPDMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public List<GNNHAGACLCH> GACFAGFHELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public bool ICNJJPMGKIP;

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x6D9E470", Offset = "0x6D9D870", VA = "0x186D9E470")]
	public GNNHAGACLCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6D9DFE0", Offset = "0x6D9D3E0", VA = "0x186D9DFE0")]
	public void BHKAAHKPFIE(GNNHAGACLCH KADEDLJJJFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270")]
	public void LOMMKEMNHPA(int LIMHLENILGM, NMBFLJNFHKL GINPNFOAGMN, int NPGFALIGDDG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x6D9E1E0", Offset = "0x6D9D5E0", VA = "0x186D9E1E0")]
	public void MGLEFBANFDE(List<byte> JNCNCLMHNIC, Vector3 CLHMEGFDOKF, float DPHLDIMPPEF, float ACIPFCHKMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x6D9E440", Offset = "0x6D9D840", VA = "0x186D9E440")]
	public bool PBEELGEGDIO(Vector3 DFIPADAPDJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x6D9E1B0", Offset = "0x6D9D5B0", VA = "0x186D9E1B0")]
	public bool DMFDOOGMHGE(Vector3 DFIPADAPDJG, float BJNHKGCLFHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6D9E120", Offset = "0x6D9D520", VA = "0x186D9E120")]
	public void CGCFJDLGJFP()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		public struct EPIHEPJLIEH<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private readonly List<Component> KDBAFFDDPME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private readonly bool GMIJINHPOCK;

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x3BC0420", Offset = "0x3BBF820", VA = "0x183BC0420")]
			public EPIHEPJLIEH(List<Component> KDBAFFDDPME, bool GMIJINHPOCK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x3BC02E0", Offset = "0x3BBF6E0", VA = "0x183BC02E0")]
			public FADEGIDFAGJ<T> JLDAKMOMDIF()
			{
				return default(FADEGIDFAGJ<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x3BC0350", Offset = "0x3BBF750", VA = "0x183BC0350", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x3BC0350", Offset = "0x3BBF750", VA = "0x183BC0350", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006E")]
		public struct FADEGIDFAGJ<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			private readonly List<Component> KDBAFFDDPME;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			private readonly bool GMIJINHPOCK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			private int HAJICDLBEKC;

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public T GKCMOMIKDKD
			{
				[Cpp2IlInjected.Token(Token = "0x600021A")]
				[Cpp2IlInjected.Address(RVA = "0x3F29D70", Offset = "0x3F29170", VA = "0x183F29D70", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000061")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600021B")]
				[Cpp2IlInjected.Address(RVA = "0x3F29D00", Offset = "0x3F29100", VA = "0x183F29D00", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x3F29D40", Offset = "0x3F29140", VA = "0x183F29D40")]
			public FADEGIDFAGJ(List<Component> KDBAFFDDPME, bool GMIJINHPOCK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x3F29C40", Offset = "0x3F29040", VA = "0x183F29C40", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x3F29C50", Offset = "0x3F29050", VA = "0x183F29C50", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x3C0F260", Offset = "0x3C0E660", VA = "0x183C0F260", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x6DA33F0", Offset = "0x6DA27F0", VA = "0x186DA33F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6DA3060", Offset = "0x6DA2460", VA = "0x186DA3060")]
		private void CGCFJDLGJFP(GameObject OJGOEPKIAGN, bool MALABKOONDB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x6DA31D0", Offset = "0x6DA25D0", VA = "0x186DA31D0")]
		public static void CGCFJDLGJFP(GameObject OJGOEPKIAGN, ToolHierarchyCache OJLLLCEEJNF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6DA3350", Offset = "0x6DA2750", VA = "0x186DA3350")]
		public void KBBCMICLLCJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x31BE820", Offset = "0x31BDC20", VA = "0x1831BE820")]
		public void JJJPAKHAOBM<T>(Action<T> HJOAJFDFEDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x31BEA60", Offset = "0x31BDE60", VA = "0x1831BEA60")]
		public T MFPIDIFIHKO<T>(bool GMIJINHPOCK = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x31BE760", Offset = "0x31BDB60", VA = "0x1831BE760")]
		public EPIHEPJLIEH<T> EHHGJLIDDFA<T>(bool GMIJINHPOCK = false) where T : class
		{
			return default(EPIHEPJLIEH<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6DA2D10", Offset = "0x6DA2110", VA = "0x186DA2D10")]
		public List<Component> BJNJPKFHAOO(Type DPOLEDLIAMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x6DA3260", Offset = "0x6DA2660", VA = "0x186DA3260", Slot = "4")]
		public bool Equals(ToolHierarchyCache LBEGFJJGJFP, ToolHierarchyCache GAMIAAAKNPF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x6DA32E0", Offset = "0x6DA26E0", VA = "0x186DA32E0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache FMAFBHGACNM)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class AAFPOKKOMJK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int BIMLHBENMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int CBMHMMEMKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private List<T> KODDIJIFMHA;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int ICBOPDBFFOG
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x3FC3D40", Offset = "0x3FC3140", VA = "0x183FC3D40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public T NMKLPFBIAMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x3FC3B90", Offset = "0x3FC2F90", VA = "0x183FC3B90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public T FKKACNCKCJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x3FC4180", Offset = "0x3FC3580", VA = "0x183FC4180")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public T JEIELIAKOAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x3FC3990", Offset = "0x3FC2D90", VA = "0x183FC3990")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x3FC4270", Offset = "0x3FC3670", VA = "0x183FC4270")]
	public AAFPOKKOMJK(int BIMLHBENMHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x3FC3E00", Offset = "0x3FC3200", VA = "0x183FC3E00")]
	public void LEFBGNCKNFL(T JBGMPEBEEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x3FC3DA0", Offset = "0x3FC31A0", VA = "0x183FC3DA0")]
	public void KMNEPMPOIBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x3FC3A90", Offset = "0x3FC2E90", VA = "0x183FC3A90")]
	public void HKENLLDAGAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x3FC3A10", Offset = "0x3FC2E10", VA = "0x183FC3A10")]
	public void DHKMHMEDKEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x3FC3A80", Offset = "0x3FC2E80", VA = "0x183FC3A80")]
	public void FHNGAPHGLIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x3FC40E0", Offset = "0x3FC34E0", VA = "0x183FC40E0")]
	public List<T> MICLDNNFHGN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class EIHKPIPKPBD<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private struct IMLAMLGKMJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public int BOMPAKPLOGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public T EEMLDMGPOLA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly Dictionary<object, IMLAMLGKMJA> BNDGLAGJGHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly EqualityComparer<T> CEOELKOGAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private T BMPOKGHJLME;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public virtual T CGCDELDKFHP
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x96A490", Offset = "0x969890", VA = "0x18096A490", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x3B7B710", Offset = "0x3B7AB10", VA = "0x183B7B710", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public bool JHLGCKKMJOF
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x3B7C580", Offset = "0x3B7B980", VA = "0x183B7C580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public object NEKFFAJBHMH
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8AAD10", Offset = "0x8AA110", VA = "0x1808AAD10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8AAD00", Offset = "0x8AA100", VA = "0x1808AAD00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x3B7C480", Offset = "0x3B7B880", VA = "0x183B7C480")]
	public bool GJNKIFOCKMF(T EEPLCHCGAIN, object ABHFNNFMPHA, int ALEEOPFLOLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x3B787A0", Offset = "0x3B77BA0", VA = "0x183B787A0")]
	public bool BGGIECNKLKA(object ABHFNNFMPHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x3B7C7F0", Offset = "0x3B7BBF0", VA = "0x183B7C7F0")]
	public bool LCKMIEGKAOE(object ABHFNNFMPHA, [Out] T EEPLCHCGAIN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x3B7C5E0", Offset = "0x3B7B9E0", VA = "0x183B7C5E0")]
	public void KMNEPMPOIBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x3B7A3A0", Offset = "0x3B797A0", VA = "0x183B7A3A0")]
	private bool ECFHIGPMJOD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x3B7CFA0", Offset = "0x3B7C3A0", VA = "0x183B7CFA0")]
	public EIHKPIPKPBD()
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
