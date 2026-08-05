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
using RecRoom.Core.DataStructures;
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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x826C2E0", Offset = "0x826B6E0", VA = "0x18826C2E0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA99B00", Offset = "0xA98F00", VA = "0x180A99B00")]
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
		[Cpp2IlInjected.Address(RVA = "0xA99B40", Offset = "0xA98F40", VA = "0x180A99B40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class IJNGHHPMAMC : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x23556D0", Offset = "0x2354AD0", VA = "0x1823556D0")]
	public IJNGHHPMAMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, DLIEGFGDABH, LFLJJLGFANG, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xDC9780", Offset = "0xDC8B80", VA = "0x180DC9780", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash GONCBGJFGEK);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xCFA860", Offset = "0xCF9C60", VA = "0x180CFA860")]
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
	[ReadOnlyField]
	[HideInInspector]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x826D4F0", Offset = "0x826C8F0", VA = "0x18826D4F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x826D4B0", Offset = "0x826C8B0", VA = "0x18826D4B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x826D530", Offset = "0x826C930", VA = "0x18826D530")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x826D6E0", Offset = "0x826CAE0", VA = "0x18826D6E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x826D650", Offset = "0x826CA50", VA = "0x18826D650")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xABFF30", Offset = "0xABF330", VA = "0x180ABFF30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xABFF40", Offset = "0xABF340", VA = "0x180ABFF40")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x826D470", Offset = "0x826C870", VA = "0x18826D470")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x826D5C0", Offset = "0x826C9C0", VA = "0x18826D5C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x826D0C0", Offset = "0x826C4C0", VA = "0x18826D0C0")]
	public void CopyBounds(SavedExtents LHDOHAKINKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x826D3C0", Offset = "0x826C7C0", VA = "0x18826D3C0")]
	public void SetLocalSpaceBounds(Bounds FDFDKNGBJBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x16B2FB0", Offset = "0x16B23B0", VA = "0x1816B2FB0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x826D2F0", Offset = "0x826C6F0", VA = "0x18826D2F0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x826C8A0", Offset = "0x826BCA0", VA = "0x18826C8A0")]
	private void ACBBJIPNILH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x826D0F0", Offset = "0x826C4F0", VA = "0x18826D0F0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x826CA50", Offset = "0x826BE50", VA = "0x18826CA50")]
	public static void CalculateLocalBoundsFor(GameObject JBJNKCGNJKP, [Out] Bounds FDFDKNGBJBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x826D300", Offset = "0x826C700", VA = "0x18826D300")]
	private static void PDKKCHGAHCN(Bounds JOCIBENNGKI, Color CHNNNFLKBNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x826D3E0", Offset = "0x826C7E0", VA = "0x18826D3E0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA6D110", Offset = "0xA6C510", VA = "0x180A6D110")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xA6D190", Offset = "0xA6C590", VA = "0x180A6D190")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1B6E390", Offset = "0x1B6D790", VA = "0x181B6E390")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5D41D40", Offset = "0x5D41140", VA = "0x185D41D40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public virtual void GDBFEOJEBED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
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
	[IJNGHHPMAMC]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5D41970", Offset = "0x5D40D70", VA = "0x185D41970", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5D407C0", Offset = "0x5D3FBC0", VA = "0x185D407C0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5D41CA0", Offset = "0x5D410A0", VA = "0x185D41CA0")]
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
	private sealed class IAFLGBJBEGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public IAFLGBJBEGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5098C70", Offset = "0x5098070", VA = "0x185098C70")]
		internal int MCMBILLIBKF(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[IJNGHHPMAMC]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4A02890", Offset = "0x4A01C90", VA = "0x184A02890", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4A028D0", Offset = "0x4A01CD0", VA = "0x184A028D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4A027B0", Offset = "0x4A01BB0", VA = "0x184A027B0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey PEENICAIFOP]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4A02830", Offset = "0x4A01C30", VA = "0x184A02830", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4A026B0", Offset = "0x4A01AB0", VA = "0x184A026B0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4A023D0", Offset = "0x4A017D0", VA = "0x184A023D0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4A018C0", Offset = "0x4A00CC0", VA = "0x184A018C0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4A017B0", Offset = "0x4A00BB0", VA = "0x184A017B0", Slot = "14")]
	protected virtual string CPJGBKFOKOJ(TKeyVal AOJEPEFJCJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4A017E0", Offset = "0x4A00BE0", VA = "0x184A017E0", Slot = "4")]
	public bool ContainsKey(TKey PEENICAIFOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4A02580", Offset = "0x4A01980", VA = "0x184A02580", Slot = "5")]
	public bool TryGetValue(TKey PEENICAIFOP, [Out] TVal CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4A01820", Offset = "0x4A00C20", VA = "0x184A01820", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4A01820", Offset = "0x4A00C20", VA = "0x184A01820", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4A025C0", Offset = "0x4A019C0", VA = "0x184A025C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x44ECB20", Offset = "0x44EBF20", VA = "0x1844ECB20")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	[IJNGHHPMAMC]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5D433E0", Offset = "0x5D427E0", VA = "0x185D433E0")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5D42D30", Offset = "0x5D42130", VA = "0x185D42D30", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5D423B0", Offset = "0x5D417B0", VA = "0x185D423B0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class HAPGJAOCGCB<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct EOOJIDJFMEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public T JCMAOCOGHGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public float FMFDBMLDALO;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int MEGHMANMIEI = 16;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const float OHPGGOMFOKN = -1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected readonly EOOJIDJFMEJ[] LMLCJEFLFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	protected int BBPHAPHNNOI;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float BPJDDMNOFJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xD43CC0", Offset = "0xD430C0", VA = "0x180D43CC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xDB9C10", Offset = "0xDB9010", VA = "0x180DB9C10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public T EDDJHMLFBGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4FA6E10", Offset = "0x4FA6210", VA = "0x184FA6E10")]
	protected HAPGJAOCGCB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4FA6D90", Offset = "0x4FA6190", VA = "0x184FA6D90")]
	protected HAPGJAOCGCB(int MPDDFCCPIOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4FA6BD0", Offset = "0x4FA5FD0", VA = "0x184FA6BD0")]
	public void KOBMLIBBKBO(float GIKDKPMHFDA, T CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool IFMOHLCMFJC(float PJLONFPDOGE, float GMKLOKOGGIC, [Out] T CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool EFBFIGHPHJO(float PJLONFPDOGE, float GMKLOKOGGIC, [Out] T CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4FA6B70", Offset = "0x4FA5F70", VA = "0x184FA6B70")]
	public void HBLMHKLDBPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class JFHANCNKEEN : HAPGJAOCGCB<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x826B350", Offset = "0x826A750", VA = "0x18826B350", Slot = "4")]
	public override bool IFMOHLCMFJC(float PJLONFPDOGE, float GMKLOKOGGIC, [Out] Vector3 CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x826B210", Offset = "0x826A610", VA = "0x18826B210", Slot = "5")]
	public override bool EFBFIGHPHJO(float PJLONFPDOGE, float GMKLOKOGGIC, [Out] Vector3 CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x826B4B0", Offset = "0x826A8B0", VA = "0x18826B4B0")]
	public JFHANCNKEEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class GOCGFKNBDHM
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB540", Offset = "0x3CBA940", VA = "0x183CBB540")]
	public static PMEIOLAILNO<T1, T2> CEOONNIFPHP<T1, T2>(T1 EEOCIMLAANN, T2 JCDBBKFGLDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3CBB5C0", Offset = "0x3CBA9C0", VA = "0x183CBB5C0")]
	public static JMJDMNADNFF<T1, T2, T3> CEOONNIFPHP<T1, T2, T3>(T1 EEOCIMLAANN, T2 JCDBBKFGLDJ, T3 CCDAOGHIANE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x57D3F60", Offset = "0x57D3360", VA = "0x1857D3F60")]
	internal static int LDGOBLJFBLB(int FHOEAECGOHP, int PEDKJIPNGIO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x73D3EA0", Offset = "0x73D32A0", VA = "0x1873D3EA0")]
	internal static int LDGOBLJFBLB(int FHOEAECGOHP, int PEDKJIPNGIO, int HLAELMPFICF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class PMEIOLAILNO<T1, T2> : IComparable<PMEIOLAILNO<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T1 OEBFBOBOLHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T2 JILDLFMFNDK;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5B109E0", Offset = "0x5B0FDE0", VA = "0x185B109E0")]
	public PMEIOLAILNO(T1 EEOCIMLAANN, T2 JCDBBKFGLDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5B0EE90", Offset = "0x5B0E290", VA = "0x185B0EE90", Slot = "4")]
	public int CompareTo(PMEIOLAILNO<T1, T2> LHDOHAKINKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5B0F6F0", Offset = "0x5B0EAF0", VA = "0x185B0F6F0", Slot = "0")]
	public override bool Equals(object LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5B0FFF0", Offset = "0x5B0F3F0", VA = "0x185B0FFF0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5B10750", Offset = "0x5B0FB50", VA = "0x185B10750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class JMJDMNADNFF<T1, T2, T3> : IComparable<JMJDMNADNFF<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T1 OEBFBOBOLHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T2 JILDLFMFNDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T3 BOALLJFFEMG;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5379040", Offset = "0x5378440", VA = "0x185379040")]
	public JMJDMNADNFF(T1 EEOCIMLAANN, T2 JCDBBKFGLDJ, T3 CCDAOGHIANE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5378850", Offset = "0x5377C50", VA = "0x185378850", Slot = "4")]
	public int CompareTo(JMJDMNADNFF<T1, T2, T3> LHDOHAKINKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5378AA0", Offset = "0x5377EA0", VA = "0x185378AA0", Slot = "0")]
	public override bool Equals(object LHDOHAKINKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5378CE0", Offset = "0x53780E0", VA = "0x185378CE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5378E90", Offset = "0x5378290", VA = "0x185378E90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public AnimationCurve BEKMBGDILFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T KHMMBMKAIOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x13E0010", Offset = "0x13DF410", VA = "0x1813E0010")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T LCDEOIBGFNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xD45140", Offset = "0xD44540", VA = "0x180D45140")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T JCMAOCOGHGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2EC7E70", Offset = "0x2EC7270", VA = "0x182EC7E70")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2EC7E80", Offset = "0x2EC7280", VA = "0x182EC7E80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float PAMPGBNKOEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xAC27C0", Offset = "0xAC1BC0", VA = "0x180AC27C0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6015A60", Offset = "0x6014E60", VA = "0x186015A60")]
	public T IKFJBLKMPIE(float DBAMLJDDEJL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6015930", Offset = "0x6014D30", VA = "0x186015930")]
	public T AKHBHMGOBHJ(float DBAMLJDDEJL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T BBNLFGHHILN(T KEHFCBFJCMA, T KGECIONKOCO, float DBAMLJDDEJL);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x8269D30", Offset = "0x8269130", VA = "0x188269D30", Slot = "4")]
	protected override float BBNLFGHHILN(float KEHFCBFJCMA, float KGECIONKOCO, float DBAMLJDDEJL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x8269D70", Offset = "0x8269170", VA = "0x188269D70")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x19BAB70", Offset = "0x19B9F70", VA = "0x1819BAB70", Slot = "4")]
	protected override Vector3 BBNLFGHHILN(Vector3 KEHFCBFJCMA, Vector3 KGECIONKOCO, float DBAMLJDDEJL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x826E530", Offset = "0x826D930", VA = "0x18826E530")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x8269B40", Offset = "0x8268F40", VA = "0x188269B40", Slot = "4")]
	protected override Color BBNLFGHHILN(Color KEHFCBFJCMA, Color KGECIONKOCO, float DBAMLJDDEJL)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8269C00", Offset = "0x8269000", VA = "0x188269C00")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class BGAKFEEKMBI : KACAOJNCDBK<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x8269930", Offset = "0x8268D30", VA = "0x188269930")]
	public BGAKFEEKMBI(int HLNAOJHAMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x82698C0", Offset = "0x8268CC0", VA = "0x1882698C0", Slot = "6")]
	protected override uint GIEEEMEGMFB(uint GONCBGJFGEK, string CBMEHPPMEEA)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class NDPAKOGEGGL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly IDisposable NKAKNKMIPPI;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	public NDPAKOGEGGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct ACMIOJMEOCE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> CMEMOIMHFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int AHBEPPNCDOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int ENJAGFEKGHP;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x51044B0", Offset = "0x51038B0", VA = "0x1851044B0")]
	private ACMIOJMEOCE(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> BKBPKCPOHOP, int BGODOIMDLKF, int EFAHIMBLKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5102320", Offset = "0x5101720", VA = "0x185102320")]
	public static ACMIOJMEOCE<T> EJOLKNBPCJB()
	{
		return default(ACMIOJMEOCE<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5103790", Offset = "0x5102B90", VA = "0x185103790")]
	public (int, int, Task<T>) HIHEKGHKNML(int CJKINMFPLED, [Optional] CancellationToken GMKBGHHNCDJ, double OLCPEFOMCCM = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5103FA0", Offset = "0x51033A0", VA = "0x185103FA0")]
	public void PMNBCJLGIHK(int CJKINMFPLED, int EFAHIMBLKLN, [In] T HJBCDFKDKBA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class CEHFPPMHOEN
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x8269A70", Offset = "0x8268E70", VA = "0x188269A70")]
	public static ACMIOJMEOCE<EPILOLMBDMK> EJOLKNBPCJB()
	{
		return default(ACMIOJMEOCE<EPILOLMBDMK>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8269AC0", Offset = "0x8268EC0", VA = "0x188269AC0")]
	public static void PMNBCJLGIHK([In] this ACMIOJMEOCE<EPILOLMBDMK> DMFKPMONDPO, int CJKINMFPLED, int EFAHIMBLKLN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class DEEBLOMGOFL<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly Dictionary<TKey, TVal> IOFNAIMDMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TVal, TKey> OLCJLCAIMCK;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int JGJMKJIDNDK
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x44DC760", Offset = "0x44DBB60", VA = "0x1844DC760", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool NBPHDBEEFKK
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> EJHLAIBHCMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x453D860", Offset = "0x453CC60", VA = "0x18453D860", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> ALLICKBJCMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x453D8A0", Offset = "0x453CCA0", VA = "0x18453D8A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal FMHPKKMCCLF
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x453D7C0", Offset = "0x453CBC0", VA = "0x18453D7C0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x453D8E0", Offset = "0x453CCE0", VA = "0x18453D8E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey FMHPKKMCCLF
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x453D0B0", Offset = "0x453C4B0", VA = "0x18453D0B0")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x453CE70", Offset = "0x453C270", VA = "0x18453CE70", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x453D640", Offset = "0x453CA40", VA = "0x18453D640", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x453CE40", Offset = "0x453C240", VA = "0x18453CE40", Slot = "9")]
	public void Add(TKey PEENICAIFOP, TVal CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x453CE10", Offset = "0x453C210", VA = "0x18453CE10", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> GBDPBDHPLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x453CED0", Offset = "0x453C2D0", VA = "0x18453CED0", Slot = "8")]
	public bool ContainsKey(TKey PEENICAIFOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x453CF10", Offset = "0x453C310", VA = "0x18453CF10", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x453D570", Offset = "0x453C970", VA = "0x18453D570", Slot = "10")]
	public bool Remove(TKey PEENICAIFOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x453D5C0", Offset = "0x453C9C0", VA = "0x18453D5C0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x453D690", Offset = "0x453CA90", VA = "0x18453D690", Slot = "11")]
	public bool TryGetValue(TKey PEENICAIFOP, [Out] TVal CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x453D100", Offset = "0x453C500", VA = "0x18453D100", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x453CF70", Offset = "0x453C370", VA = "0x18453CF70", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] LMLCJEFLFMP, int KJLHONACGJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x453D020", Offset = "0x453C420", VA = "0x18453D020")]
	public bool EGMGAAFJGGH(TVal PEENICAIFOP, [Out] TKey CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x453D210", Offset = "0x453C610", VA = "0x18453D210")]
	private void IFNKHFDCEAH(TKey PEENICAIFOP, TVal DIMKOEFIKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x453D2B0", Offset = "0x453C6B0", VA = "0x18453D2B0")]
	private void JOAMDJNABLC(TKey PEENICAIFOP, TVal DIMKOEFIKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x453D3D0", Offset = "0x453C7D0", VA = "0x18453D3D0")]
	private bool LLNIMCDALCL(TKey PEENICAIFOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x453D6D0", Offset = "0x453CAD0", VA = "0x18453D6D0")]
	public DEEBLOMGOFL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class LOBGGEGMNPI<T> : IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private LOBGGEGMNPI<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x14EADF0", Offset = "0x14EA1F0", VA = "0x1814EADF0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x4A6CC70", Offset = "0x4A6C070", VA = "0x184A6CC70", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x4A6DFC0", Offset = "0x4A6D3C0", VA = "0x184A6DFC0")]
		public Enumerator(LOBGGEGMNPI<T> JCGBEKOGKKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x4A6BE10", Offset = "0x4A6B210", VA = "0x184A6BE10", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4A6C3F0", Offset = "0x4A6B7F0", VA = "0x184A6C3F0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x4A6B3D0", Offset = "0x4A6A7D0", VA = "0x184A6B3D0")]
		private void IMHBBMAPPMP()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private T[] NMFJIONMIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int FDIBAFEDFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int GKKJCJFPBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int CDBBOGJDAGP;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int JGJMKJIDNDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x55938B0", Offset = "0x5592CB0", VA = "0x1855938B0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T FMHPKKMCCLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5591440", Offset = "0x5590840", VA = "0x185591440")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5590F70", Offset = "0x5590370", VA = "0x185590F70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x5593830", Offset = "0x5592C30", VA = "0x185593830")]
	public LOBGGEGMNPI(int HLNAOJHAMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5591AF0", Offset = "0x5590EF0", VA = "0x185591AF0")]
	public void KOBMLIBBKBO(T DBAMLJDDEJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5591FF0", Offset = "0x55913F0", VA = "0x185591FF0")]
	public void NFFFKIMBGDJ(IEnumerable<T> CLIKJBPKKKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x55914D0", Offset = "0x55908D0", VA = "0x1855914D0")]
	public void HBLMHKLDBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x55934B0", Offset = "0x55928B0", VA = "0x1855934B0")]
	public void OKCPEGCKGNB(int PPNAGMANAKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x55906A0", Offset = "0x558FAA0", VA = "0x1855906A0")]
	public void AHINEHNEJJM(T[] LMLCJEFLFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x55933D0", Offset = "0x55927D0", VA = "0x1855933D0")]
	public Enumerator OJAPBOKMMBI()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x55935D0", Offset = "0x55929D0", VA = "0x1855935D0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x55935D0", Offset = "0x55929D0", VA = "0x1855935D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x55919F0", Offset = "0x5590DF0", VA = "0x1855919F0")]
	private int IONMFIJCBMA(int NOEININIMIL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5590F40", Offset = "0x5590340", VA = "0x185590F40")]
	private int CIFHKAENFIG(int NOEININIMIL)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class KOKOAANOAGE<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate Task<TResult> EKIPMIOFBGK(TRequest IDLJGJGIGEG, CancellationToken GMKBGHHNCDJ);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum ACLLEMNCHAI
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class GAAJLAJNMAB
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const float IPAOKHPNBLE = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TimeSpan ELCLGEPELOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int OCOAFGLFPCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public ACLLEMNCHAI LPBGHGAFLPI;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly GAAJLAJNMAB BCIBOEFGOGH;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float OGFHJICMJAB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x4F39420", Offset = "0x4F38820", VA = "0x184F39420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public TimeSpan HIIFKAFDHOC
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x4F39500", Offset = "0x4F38900", VA = "0x184F39500")]
		public GAAJLAJNMAB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private readonly struct MDHJPLMFOBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public readonly TRequest IDLJGJGIGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly CancellationToken GMKBGHHNCDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly TaskCompletionSource<TResult> JALJDNKJPMD;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x576C8E0", Offset = "0x576BCE0", VA = "0x18576C8E0")]
		public MDHJPLMFOBH(TRequest IDLJGJGIGEG, TaskCompletionSource<TResult> JALJDNKJPMD, CancellationToken GMKBGHHNCDJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct ELPNLJODBAH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public KOKOAANOAGE<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x49ECCD0", Offset = "0x49EC0D0", VA = "0x1849ECCD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x49ED450", Offset = "0x49EC850", VA = "0x1849ED450", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct KKCOHMNGJCC : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public KOKOAANOAGE<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private MDHJPLMFOBH <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x54596D0", Offset = "0x5458AD0", VA = "0x1854596D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x545A2A0", Offset = "0x54596A0", VA = "0x18545A2A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CancellationTokenSource JPDAFDCNPEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly List<MDHJPLMFOBH> AEHAEAJDKPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly GAAJLAJNMAB FOBDFIEMIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly EKIPMIOFBGK NJBGEDDNJIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Task OAPDABHJKIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int CPPLOOBCNKG;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x5471040", Offset = "0x5470440", VA = "0x185471040")]
	public KOKOAANOAGE(EKIPMIOFBGK NJBGEDDNJIE, [Optional] GAAJLAJNMAB FOBDFIEMIJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x5470240", Offset = "0x546F640", VA = "0x185470240")]
	public Task<TResult> NBAKOIHJFEG(TRequest IDLJGJGIGEG, CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x5470CD0", Offset = "0x54700D0", VA = "0x185470CD0")]
	private void OKEPKFNGFGM(MDHJPLMFOBH EDOLPDNGPGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x546FC90", Offset = "0x546F090", VA = "0x18546FC90")]
	[AsyncStateMachine(typeof(KOKOAANOAGE<, >.ELPNLJODBAH))]
	private Task IIPMEBOLHAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x5470420", Offset = "0x546F820", VA = "0x185470420")]
	private MDHJPLMFOBH NDHADBBPFIJ()
	{
		return default(MDHJPLMFOBH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x546F8E0", Offset = "0x546ECE0", VA = "0x18546F8E0")]
	[AsyncStateMachine(typeof(KOKOAANOAGE<, >.KKCOHMNGJCC))]
	private Task HAICKMFBGOF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x546F6C0", Offset = "0x546EAC0", VA = "0x18546F6C0")]
	private void AHJFMAMLJBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x546F8A0", Offset = "0x546ECA0", VA = "0x18546F8A0", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.AppUI
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public interface IRRUISpriteLookup
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryFindSpriteByName(string spriteName, [Out] Sprite sprite);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class MMJKNBGBOLC<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly List<T> KIGLENMLJCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private HashSet<T> PHCBKGHENBJ;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int JGJMKJIDNDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x44DC760", Offset = "0x44DBB60", VA = "0x1844DC760", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool NBPHDBEEFKK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xAB9810", Offset = "0xAB8C10", VA = "0x180AB9810", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T FMHPKKMCCLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5797400", Offset = "0x5796800", VA = "0x185797400", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5797510", Offset = "0x5796910", VA = "0x185797510", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4EC3180", Offset = "0x4EC2580", VA = "0x184EC3180", Slot = "11")]
	public void Add(T GBDPBDHPLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5796ED0", Offset = "0x57962D0", VA = "0x185796ED0")]
	public bool PGNMJFBANDH(T GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5797280", Offset = "0x5796680", VA = "0x185797280", Slot = "15")]
	public bool Remove(T GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4EA27B0", Offset = "0x4EA1BB0", VA = "0x184EA27B0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4F249E0", Offset = "0x4F23DE0", VA = "0x184F249E0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x5796C60", Offset = "0x5796060", VA = "0x185796C60", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x5796CC0", Offset = "0x57960C0", VA = "0x185796CC0", Slot = "13")]
	public bool Contains(T GBDPBDHPLOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5796D00", Offset = "0x5796100", VA = "0x185796D00", Slot = "14")]
	public void CopyTo(T[] LMLCJEFLFMP, int KJLHONACGJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x54B9440", Offset = "0x54B8840", VA = "0x1854B9440", Slot = "6")]
	public int IndexOf(T GBDPBDHPLOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5796E00", Offset = "0x5796200", VA = "0x185796E00", Slot = "7")]
	public void Insert(int NOEININIMIL, T GBDPBDHPLOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5797030", Offset = "0x5796430", VA = "0x185797030", Slot = "8")]
	public void RemoveAt(int NOEININIMIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x5797310", Offset = "0x5796710", VA = "0x185797310")]
	public MMJKNBGBOLC()
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
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2D236E0", Offset = "0x2D22AE0", VA = "0x182D236E0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x826DA80", Offset = "0x826CE80", VA = "0x18826DA80")]
		public SerializedGuid([In] Guid OOOANFDGEED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x826D8E0", Offset = "0x826CCE0", VA = "0x18826D8E0")]
		public static SerializedGuid OKGKJIFCJIG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x826DA10", Offset = "0x826CE10", VA = "0x18826DA10")]
		public static SerializedGuid PIDPINPLNMD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x826D870", Offset = "0x826CC70", VA = "0x18826D870")]
		public bool GAGDCLONJBF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x826D9E0", Offset = "0x826CDE0", VA = "0x18826D9E0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x826D960", Offset = "0x826CD60", VA = "0x18826D960", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x826D7A0", Offset = "0x826CBA0", VA = "0x18826D7A0", Slot = "7")]
		public bool Equals(SerializedGuid LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x826D7E0", Offset = "0x826CBE0", VA = "0x18826D7E0", Slot = "0")]
		public override bool Equals(object DEJGDIIDCDN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x826D8D0", Offset = "0x826CCD0", VA = "0x18826D8D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x826D770", Offset = "0x826CB70", VA = "0x18826D770", Slot = "6")]
		public int CompareTo(SerializedGuid LHDOHAKINKP)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class JFDFAGGNGMJ : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Type FMGIDAPFDHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly string ELFCHAOIIJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly bool AMMEHNJDJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly bool IJPHLBGMDML;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x826B1A0", Offset = "0x826A5A0", VA = "0x18826B1A0")]
	public JFDFAGGNGMJ(Type FJIJILMEAHD, string EFIOGDBAEJL, bool DNGOFIKBNIO = false, bool CJEKOEINAME = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface LOCLGBABCJG<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	int NFLHMECFMIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<T> IDMDHOFAIAO(float GIKDKPMHFDA, [Optional] float? MIPHCMNCHJA);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool POHJJGNOINA(float GIKDKPMHFDA, T CBMEHPPMEEA);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HBLMHKLDBPD();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[Obsolete("Use ITimeSeriesRollingWindow<T> instead")]
public class BNFGHKAMDJI<T> : LOCLGBABCJG<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class FCODDPOGOHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float LHIIPNAHAIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public T JCMAOCOGHGO;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public FCODDPOGOHN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class NGJNEPPIHGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public NGJNEPPIHGA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x57F6B40", Offset = "0x57F5F40", VA = "0x1857F6B40")]
		internal bool KGEDIMEHDOB(FCODDPOGOHN sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly float IFDEDCMGGFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly float GCOAOIABFCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<FCODDPOGOHN> IDHGNOPFHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private OADHGJHHIPF<FCODDPOGOHN> KMKFFFDPFFF;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int NFLHMECFMIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x68E8A40", Offset = "0x68E7E40", VA = "0x1868E8A40", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x68E93C0", Offset = "0x68E87C0", VA = "0x1868E93C0")]
	public BNFGHKAMDJI(float IEAKJAEHCBM, float GDJMHJLJBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x68E9250", Offset = "0x68E8650", VA = "0x1868E9250", Slot = "6")]
	public bool POHJJGNOINA(float GIKDKPMHFDA, T CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x68E8B10", Offset = "0x68E7F10", VA = "0x1868E8B10", Slot = "5")]
	public IEnumerable<T> IDMDHOFAIAO(float GIKDKPMHFDA, float? MIPHCMNCHJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x68E8AB0", Offset = "0x68E7EB0", VA = "0x1868E8AB0", Slot = "7")]
	public void HBLMHKLDBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x68E8890", Offset = "0x68E7C90", VA = "0x1868E8890")]
	private void AKBIDGHMAPF(float GIKDKPMHFDA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class HHGEDJELIFF<T> : LOCLGBABCJG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct CAAGNJBACEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly T JCMAOCOGHGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly float LHIIPNAHAIJ;

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x54E21D0", Offset = "0x54E15D0", VA = "0x1854E21D0")]
		public CAAGNJBACEN(T CBMEHPPMEEA, float GIKDKPMHFDA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class MJMDIIMBKDN : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public HHGEDJELIFF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float <>3__time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private float? minTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public float? <>3__minTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private int <count>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0xFC9810", Offset = "0xFC8C10", VA = "0x180FC9810")]
		[DebuggerHidden]
		public MJMDIIMBKDN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5785CA0", Offset = "0x57850A0", VA = "0x185785CA0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5786130", Offset = "0x5785530", VA = "0x185786130", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5786070", Offset = "0x5785470", VA = "0x185786070", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x510C3D0", Offset = "0x510B7D0", VA = "0x18510C3D0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly float IEAKJAEHCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly float GDJMHJLJBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly List<CAAGNJBACEN> IDHGNOPFHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int FDIBAFEDFOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int EMHABKNNHFM;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int NFLHMECFMIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0xA6D130", Offset = "0xA6C530", VA = "0x180A6D130", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4FDA8C0", Offset = "0x4FD9CC0", VA = "0x184FDA8C0")]
	public HHGEDJELIFF(float IEAKJAEHCBM, float GDJMHJLJBBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4FDA680", Offset = "0x4FD9A80", VA = "0x184FDA680", Slot = "6")]
	public bool POHJJGNOINA(float GIKDKPMHFDA, T CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4FDA420", Offset = "0x4FD9820", VA = "0x184FDA420", Slot = "8")]
	public int PHOAOKLJOAM(float GIKDKPMHFDA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4FDA170", Offset = "0x4FD9570", VA = "0x184FDA170", Slot = "5")]
	[IteratorStateMachine(typeof(HHGEDJELIFF<>.MJMDIIMBKDN))]
	public IEnumerable<T> IDMDHOFAIAO(float GIKDKPMHFDA, float? MIPHCMNCHJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4FDA130", Offset = "0x4FD9530", VA = "0x184FDA130", Slot = "7")]
	public void HBLMHKLDBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4FD9FA0", Offset = "0x4FD93A0", VA = "0x184FD9FA0")]
	private void AAFHPMLPEFL(float GIKDKPMHFDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x4FDA360", Offset = "0x4FD9760", VA = "0x184FDA360")]
	private CAAGNJBACEN KJHLEHLBMKN()
	{
		return default(CAAGNJBACEN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class CIIMOEPMPCG<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public readonly struct EOFIDJCGBGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly long BDFJEAGHKNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly long NMGIOGFFONP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly int CHAGGCKMEOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly int JMOPNMMENKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly bool DCMEPBFBLBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly string BLJKLJBOGEP;

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x49F1B90", Offset = "0x49F0F90", VA = "0x1849F1B90")]
		public EOFIDJCGBGN(long BDFJEAGHKNA, int CHAGGCKMEOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x49F1C00", Offset = "0x49F1000", VA = "0x1849F1C00")]
		public EOFIDJCGBGN(long BDFJEAGHKNA, long NMGIOGFFONP, int CHAGGCKMEOI, int JMOPNMMENKC, bool DCMEPBFBLBJ, string BLJKLJBOGEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x49F1B20", Offset = "0x49F0F20", VA = "0x1849F1B20")]
		public int MBEKLMNEFDH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x49F1B70", Offset = "0x49F0F70", VA = "0x1849F1B70")]
		public int PNMLGEIAPAA(int PNKGOKELJKG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x49F1AC0", Offset = "0x49F0EC0", VA = "0x1849F1AC0")]
		public double HNCPJCCCLOC()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x49F1A20", Offset = "0x49F0E20", VA = "0x1849F1A20")]
		public EOFIDJCGBGN GPCFBFNHLNN(long NMGIOGFFONP, int JMOPNMMENKC)
		{
			return default(EOFIDJCGBGN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class MOMGGNPHIKH : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private struct KIIKINDLOPM<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public MOMGGNPHIKH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Func<MOMGGNPHIKH, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private MOMGGNPHIKH <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x54514E0", Offset = "0x54508E0", VA = "0x1854514E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x49B8100", Offset = "0x49B7500", VA = "0x1849B8100", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly TKey BPKEMDDKCGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly CIIMOEPMPCG<TKey> LLOEFCNKADN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly AKNCNLDICPO CCLJCJDJCOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private List<MOMGGNPHIKH> MHJANNOFJLL;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string PBKFFEEDPFA
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x57A2020", Offset = "0x57A1420", VA = "0x1857A2020")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public IEnumerable<MOMGGNPHIKH> IBDCABEELNF
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x57A2050", Offset = "0x57A1450", VA = "0x1857A2050")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public EOFIDJCGBGN JGLOODJDGPA
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x57A1DF0", Offset = "0x57A11F0", VA = "0x1857A1DF0")]
			[CompilerGenerated]
			get
			{
				return default(EOFIDJCGBGN);
			}
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x57A1E10", Offset = "0x57A1210", VA = "0x1857A1E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x57A21D0", Offset = "0x57A15D0", VA = "0x1857A21D0")]
		internal MOMGGNPHIKH(CIIMOEPMPCG<TKey> LLOEFCNKADN, TKey PEENICAIFOP, AKNCNLDICPO CCLJCJDJCOE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x57A2080", Offset = "0x57A1480", VA = "0x1857A2080")]
		public MOMGGNPHIKH OGEDPBFFMNI(TKey PEENICAIFOP, [Optional] AKNCNLDICPO? LMKHHPDOKLD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x44628F0", Offset = "0x4461CF0", VA = "0x1844628F0")]
		[AsyncStateMachine(typeof(KIIKINDLOPM<>))]
		public Task<T> CIJOGNIHCGB<T>(TKey PEENICAIFOP, Func<MOMGGNPHIKH, Task<T>> PEHELHMLLIK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x57A1E40", Offset = "0x57A1240", VA = "0x1857A1E40", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class LJELAGHNLHA : IEnumerable<(TKey, List<TKey>, EOFIDJCGBGN)>, IEnumerable, IEnumerator<(TKey, List<TKey>, EOFIDJCGBGN)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private (TKey key, List<TKey> path, EOFIDJCGBGN timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public CIIMOEPMPCG<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private IEnumerator<(TKey key, List<TKey> path, EOFIDJCGBGN timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private (TKey, List<TKey>, EOFIDJCGBGN) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x2D0EC50", Offset = "0x2D0E050", VA = "0x182D0EC50", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, EOFIDJCGBGN));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x5517B70", Offset = "0x5516F70", VA = "0x185517B70", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x2D0ED40", Offset = "0x2D0E140", VA = "0x182D0ED40")]
		[DebuggerHidden]
		public LJELAGHNLHA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4539030", Offset = "0x4538430", VA = "0x184539030", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x55176E0", Offset = "0x5516AE0", VA = "0x1855176E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5517690", Offset = "0x5516A90", VA = "0x185517690")]
		private void DKMCMBPCGHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5517B20", Offset = "0x5516F20", VA = "0x185517B20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5517A60", Offset = "0x5516E60", VA = "0x185517A60", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, EOFIDJCGBGN)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x4578250", Offset = "0x4577650", VA = "0x184578250", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class IHIEOKGDMKC : IEnumerable<(TKey, List<TKey>, EOFIDJCGBGN)>, IEnumerable, IEnumerator<(TKey, List<TKey>, EOFIDJCGBGN)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private (TKey key, List<TKey> path, EOFIDJCGBGN timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private MOMGGNPHIKH timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public MOMGGNPHIKH <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public CIIMOEPMPCG<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IEnumerator<MOMGGNPHIKH> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private IEnumerator<(TKey key, List<TKey> path, EOFIDJCGBGN timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private (TKey, List<TKey>, EOFIDJCGBGN) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x2D0EC50", Offset = "0x2D0E050", VA = "0x182D0EC50", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, EOFIDJCGBGN));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0x50DEE40", Offset = "0x50DE240", VA = "0x1850DEE40", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x2D0ED40", Offset = "0x2D0E140", VA = "0x182D0ED40")]
		[DebuggerHidden]
		public IHIEOKGDMKC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x50DEEA0", Offset = "0x50DE2A0", VA = "0x1850DEEA0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x50DE580", Offset = "0x50DD980", VA = "0x1850DE580", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x50DE520", Offset = "0x50DD920", VA = "0x1850DE520")]
		private void DKMCMBPCGHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x50DE4C0", Offset = "0x50DD8C0", VA = "0x1850DE4C0")]
		private void AIFLPGLABJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x50DEDF0", Offset = "0x50DE1F0", VA = "0x1850DEDF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x50DECE0", Offset = "0x50DE0E0", VA = "0x1850DECE0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, EOFIDJCGBGN)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x50DEDC0", Offset = "0x50DE1C0", VA = "0x1850DEDC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Action<TKey, EOFIDJCGBGN, AKNCNLDICPO> GCPAMKKGHNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Action<TKey, EOFIDJCGBGN, AKNCNLDICPO> FDCBAFEDPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly Action<CIIMOEPMPCG<TKey>, AKNCNLDICPO> PJCHEBJIFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly AKNCNLDICPO CCLJCJDJCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly MOMGGNPHIKH CLKNJDJFEAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private bool EGNOAKFAPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int ACMKNENIIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Stopwatch POOLGKCMHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly int HCAAOFHMHFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private string MLLADFFHOAE;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public MOMGGNPHIKH AGMBCDCHGJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	[NotNull]
	public string PBKFFEEDPFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0xA70280", Offset = "0xA6F680", VA = "0x180A70280")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6D7B0E0", Offset = "0x6D7A4E0", VA = "0x186D7B0E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6D7B140", Offset = "0x6D7A540", VA = "0x186D7B140")]
	public CIIMOEPMPCG(TKey GCCEPLNFIKA, AKNCNLDICPO CCLJCJDJCOE, [Optional] int? CHAGGCKMEOI, [Optional][CanBeNull] Stopwatch POOLGKCMHBM, [Optional] Action<TKey, EOFIDJCGBGN, AKNCNLDICPO> GCPAMKKGHNC, [Optional] Action<TKey, EOFIDJCGBGN, AKNCNLDICPO> FDCBAFEDPJH, [Optional] Action<CIIMOEPMPCG<TKey>, AKNCNLDICPO> PJCHEBJIFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6D7AE70", Offset = "0x6D7A270", VA = "0x186D7AE70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6D7AF00", Offset = "0x6D7A300", VA = "0x186D7AF00")]
	[IteratorStateMachine(typeof(CIIMOEPMPCG<>.LJELAGHNLHA))]
	public IEnumerable<(TKey, List<TKey>, EOFIDJCGBGN)> EJMEIDBMEKG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6D7AF90", Offset = "0x6D7A390", VA = "0x186D7AF90")]
	[IteratorStateMachine(typeof(CIIMOEPMPCG<>.IHIEOKGDMKC))]
	private IEnumerable<(TKey, List<TKey>, EOFIDJCGBGN)> EJMEIDBMEKG(List<TKey> GADMOJMIIGI, MOMGGNPHIKH JLIFGOINOEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6D7B060", Offset = "0x6D7A460", VA = "0x186D7B060")]
	private (long, int) GCNEBINEPFO()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class NFPKGAIFMAF<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut IAKFMMOEHPA(CIIMOEPMPCG<TKey> LLOEFCNKADN);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	protected NFPKGAIFMAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class GJFLBNECOII<TKey> : NFPKGAIFMAF<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public delegate string NJPPMMPDOJI(TKey PEENICAIFOP);

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4F5B020", Offset = "0x4F5A420", VA = "0x184F5B020")]
	private static string KJCFNOBBCDG(TKey PEENICAIFOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4F5AF70", Offset = "0x4F5A370", VA = "0x184F5AF70", Slot = "4")]
	public override string IAKFMMOEHPA(CIIMOEPMPCG<TKey> LLOEFCNKADN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x4F5AE30", Offset = "0x4F5A230", VA = "0x184F5AE30")]
	public string IAKFMMOEHPA(CIIMOEPMPCG<TKey> LLOEFCNKADN, [NotNull] NJPPMMPDOJI HNCJEOCFFOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string AKIEHHDOLAF(CIIMOEPMPCG<TKey> LLOEFCNKADN, [NotNull] NJPPMMPDOJI HNCJEOCFFOL);

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x4F5B060", Offset = "0x4F5A460", VA = "0x184F5B060")]
	protected GJFLBNECOII()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class BHMDHAANGAL<TKey> : NFPKGAIFMAF<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public delegate string EELHBLLMGGI(TKey PEENICAIFOP);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly string LGEFJGMHIFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly double MLACHCNDLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly bool JFMNICLPHMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly int MEODKNBDCFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly ISet<string> MNGIJMFIJBP;

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6553470", Offset = "0x6552870", VA = "0x186553470")]
	private static string KJCFNOBBCDG(TKey PEENICAIFOP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x65536C0", Offset = "0x6552AC0", VA = "0x1865536C0")]
	public BHMDHAANGAL(string LGEFJGMHIFM = "F2", double MLACHCNDLIH = double.MaxValue, bool JFMNICLPHMH = false, int MEODKNBDCFE = int.MaxValue, [Optional] ISet<string> MNGIJMFIJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6552E10", Offset = "0x6552210", VA = "0x186552E10", Slot = "4")]
	public override Dictionary<string, string> IAKFMMOEHPA(CIIMOEPMPCG<TKey> LLOEFCNKADN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6552C40", Offset = "0x6552040", VA = "0x186552C40")]
	private bool ADOAGACGCPC(string GIBDLKMJHBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6552EC0", Offset = "0x65522C0", VA = "0x186552EC0")]
	public Dictionary<string, string> IAKFMMOEHPA(CIIMOEPMPCG<TKey> LLOEFCNKADN, EELHBLLMGGI HNCJEOCFFOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x65534B0", Offset = "0x65528B0", VA = "0x1865534B0")]
	private string NOHCAILNIDP(StringBuilder DHGKKJJBDCP, List<TKey> PLCBGJNOAAD, EELHBLLMGGI HNCJEOCFFOL, bool BLEIIMFABGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6552CB0", Offset = "0x65520B0", VA = "0x186552CB0")]
	private static void EDIKHPBFGPN(StringBuilder GMDNCODDKPC, string EPLBCDINBKM, bool OPFKKNBDOGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class MEOOABLHHEI<TKey> : GJFLBNECOII<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct BGAKLICJNJK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public NJPPMMPDOJI keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static MEOOABLHHEI<TKey> NKAKNKMIPPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly string[] OFFBHHBKGEP;

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x576FB10", Offset = "0x576EF10", VA = "0x18576FB10")]
	private MEOOABLHHEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x576EAD0", Offset = "0x576DED0", VA = "0x18576EAD0", Slot = "5")]
	protected override string AKIEHHDOLAF(CIIMOEPMPCG<TKey> LLOEFCNKADN, NJPPMMPDOJI HNCJEOCFFOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x576F8F0", Offset = "0x576ECF0", VA = "0x18576F8F0")]
	[CompilerGenerated]
	internal static string OFKOOKMAHFB(string MMEBNAIJEEN, TKey PEENICAIFOP, BGAKLICJNJK P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public sealed class JNLDDOOPIGL : CIIMOEPMPCG<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class MJBLHKHFJJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Action<JNLDDOOPIGL, AKNCNLDICPO> callback;

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public MJBLHKHFJJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x826C1D0", Offset = "0x826B5D0", VA = "0x18826C1D0")]
		internal void DLIHMNHPJIB(CIIMOEPMPCG<string> timer, AKNCNLDICPO log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x826B5B0", Offset = "0x826A9B0", VA = "0x18826B5B0")]
	public JNLDDOOPIGL(AKNCNLDICPO CCLJCJDJCOE, [Optional] string LJLHPFCBFFC, [Optional] int? CHAGGCKMEOI, [Optional] Stopwatch POOLGKCMHBM, [Optional] Action<string, EOFIDJCGBGN, AKNCNLDICPO> GCPAMKKGHNC, [Optional] Action<string, EOFIDJCGBGN, AKNCNLDICPO> FDCBAFEDPJH, [Optional] Action<JNLDDOOPIGL, AKNCNLDICPO> PJCHEBJIFGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x826B4F0", Offset = "0x826A8F0", VA = "0x18826B4F0")]
	private static Action<CIIMOEPMPCG<string>, AKNCNLDICPO> IBDACBBJJDC(Action<JNLDDOOPIGL, AKNCNLDICPO> BFDLNHAHOHH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public abstract class BACHBCBAOKG
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private class LECEFKLHHOC : BACHBCBAOKG
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static BACHBCBAOKG NKAKNKMIPPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x826C080", Offset = "0x826B480", VA = "0x18826C080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override float MMFDLCIIKEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0x1354A50", Offset = "0x1353E50", VA = "0x181354A50", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x826C180", Offset = "0x826B580", VA = "0x18826C180")]
		public LECEFKLHHOC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static BACHBCBAOKG FBKOEBGFBKO;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static BACHBCBAOKG BCIBOEFGOGH
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8269750", Offset = "0x8268B50", VA = "0x188269750")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public abstract float MMFDLCIIKEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	protected BACHBCBAOKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface BFNEHIJGJBB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	bool EGBEIIKGJLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface JAKNEJKGEIC<T> : BFNEHIJGJBB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	[NotNull]
	Task<T> NMFCLADFKMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[NotNull]
	FHMCAMOMJOP<T> LCACPCNKDPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class NIFONGKLGAO
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x3E5E8B0", Offset = "0x3E5DCB0", VA = "0x183E5E8B0")]
	public static JAKNEJKGEIC<TResource> DOAGFLGEOGB<TResource, TId>(this LMIGCBLKHKA<TId, TResource> INGGBOBKCIL, TId CLNGGGMIBPI, [Optional] Func<TId, CancellationToken, Task<TResource>>? KLDPJNKHOIA) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class CKJDEMPKKMP
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class JIGHKMKCPOE<T> : POHFLPAEANN<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<T?> NMFCLADFKMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override FHMCAMOMJOP<T?> LCACPCNKDPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x535D8E0", Offset = "0x535CCE0", VA = "0x18535D8E0")]
		public JIGHKMKCPOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "10")]
		protected override void DOACBKHCKFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class PDAGGKMGPGP<T> : POHFLPAEANN<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly T PENIDOGDIJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly Action<T>? FPMAMKFJABB;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Task<T> NMFCLADFKMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0xA70410", Offset = "0xA6F810", VA = "0x180A70410", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override FHMCAMOMJOP<T> LCACPCNKDPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0xA70260", Offset = "0xA6F660", VA = "0x180A70260", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x5AB1290", Offset = "0x5AB0690", VA = "0x185AB1290")]
		public PDAGGKMGPGP(T NJJNGJCGMCC, Action<T>? GHBJIOBBNNH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x5AB10C0", Offset = "0x5AB04C0", VA = "0x185AB10C0", Slot = "10")]
		protected override void DOACBKHCKFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private sealed class IHEGKAHEGCM<T> : POHFLPAEANN<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override Task<T> NMFCLADFKMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override FHMCAMOMJOP<T> LCACPCNKDPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x50DCAD0", Offset = "0x50DBED0", VA = "0x1850DCAD0")]
		public IHEGKAHEGCM(Exception CGMANOFIFCC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "10")]
		protected override void DOACBKHCKFI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private sealed class EFHAMCHFJJM<T> : POHFLPAEANN<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct CKKCMKAKEIM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public Task<JAKNEJKGEIC<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<JAKNEJKGEIC<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x6D80720", Offset = "0x6D7FB20", VA = "0x186D80720", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x6D80BF0", Offset = "0x6D7FFF0", VA = "0x186D80BF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct HOMNFMIIODE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public Task<JAKNEJKGEIC<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private TaskAwaiter<JAKNEJKGEIC<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x4FF57B0", Offset = "0x4FF4BB0", VA = "0x184FF57B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x4FF5A30", Offset = "0x4FF4E30", VA = "0x184FF5A30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly Task<JAKNEJKGEIC<T>> FPMFJCJPFDK;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override Task<T> NMFCLADFKMM
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override FHMCAMOMJOP<T> LCACPCNKDPF
		{
			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x49CFA90", Offset = "0x49CEE90", VA = "0x1849CFA90")]
		public EFHAMCHFJJM(Task<JAKNEJKGEIC<T>> KDHFABGBLNO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x49CF5B0", Offset = "0x49CE9B0", VA = "0x1849CF5B0", Slot = "10")]
		protected override void DOACBKHCKFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x49CF7F0", Offset = "0x49CEBF0", VA = "0x1849CF7F0")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(EFHAMCHFJJM<>.CKKCMKAKEIM))]
		internal static Task<T> NIBCBIJJDPN(Task<JAKNEJKGEIC<T>> KDHFABGBLNO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0x49CF710", Offset = "0x49CEB10", VA = "0x1849CF710")]
		[AsyncStateMachine(typeof(EFHAMCHFJJM<>.HOMNFMIIODE))]
		[CompilerGenerated]
		internal static Task IKDBLBEEFKI(Task<JAKNEJKGEIC<T>> KDHFABGBLNO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private sealed class PICAIBAHAIL<TIn, TOut> : POHFLPAEANN<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct CLANDGCCKFL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public AsyncTaskMethodBuilder<TOut> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public Func<TIn, TOut> transformFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public Task<TIn> innerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private Func<TIn, TOut> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private TaskAwaiter<TIn> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x6DAFC80", Offset = "0x6DAF080", VA = "0x186DAFC80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016C")]
			[Cpp2IlInjected.Address(RVA = "0x5773600", Offset = "0x5772A00", VA = "0x185773600", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly JAKNEJKGEIC<TIn> ANGJLFPAJOP;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override Task<TOut> NMFCLADFKMM
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override FHMCAMOMJOP<TOut> LCACPCNKDPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000167")]
			[Cpp2IlInjected.Address(RVA = "0xA703F0", Offset = "0xA6F7F0", VA = "0x180A703F0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x5AC8780", Offset = "0x5AC7B80", VA = "0x185AC8780")]
		public PICAIBAHAIL(JAKNEJKGEIC<TIn> BDFLNDDKBNI, Func<TIn, TOut> LOJAEGKDDLN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x5AC8730", Offset = "0x5AC7B30", VA = "0x185AC8730", Slot = "10")]
		protected override void DOACBKHCKFI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x5AC8570", Offset = "0x5AC7970", VA = "0x185AC8570")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(PICAIBAHAIL<, >.CLANDGCCKFL))]
		internal static Task<TOut> CJDHKEPBIAH(Task<TIn> HLJINIEACIA, Func<TIn, TOut> LOJAEGKDDLN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3AAC680", Offset = "0x3AABA80", VA = "0x183AAC680")]
	public static JAKNEJKGEIC<T> BOBPMJBGCMC<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3AAC5F0", Offset = "0x3AAB9F0", VA = "0x183AAC5F0")]
	public static JAKNEJKGEIC<T> BIIDFMPFJMH<T>(T HJBCDFKDKBA, [Optional] Action<T>? GHBJIOBBNNH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3AAC6E0", Offset = "0x3AABAE0", VA = "0x183AAC6E0")]
	public static JAKNEJKGEIC<T> NDOHFEMMMKA<T>(Exception CGMANOFIFCC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3AAC6E0", Offset = "0x3AABAE0", VA = "0x183AAC6E0")]
	public static JAKNEJKGEIC<T> IGHPPALNGLI<T>(Task<JAKNEJKGEIC<T>> KDHFABGBLNO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F370", Offset = "0x3A9E770", VA = "0x183A9F370")]
	public static JAKNEJKGEIC<TOut> MDOMHAEDEOM<TOut, TIn>(JAKNEJKGEIC<TIn> FELIADFOOJH, Func<TIn, TOut> LOJAEGKDDLN) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class POHFLPAEANN<T> : JAKNEJKGEIC<T>, BFNEHIJGJBB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly string OEKDNPMKPPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly NMFBOPDALLH MADLDBJIGFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private bool EGNOAKFAPLF;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool EGBEIIKGJLP
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0xB32050", Offset = "0xB31450", VA = "0x180B32050", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public abstract Task<T> NMFCLADFKMM
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public abstract FHMCAMOMJOP<T> LCACPCNKDPF
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x5B28060", Offset = "0x5B27460", VA = "0x185B28060")]
	public POHFLPAEANN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x5B27DA0", Offset = "0x5B271A0", VA = "0x185B27DA0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void DOACBKHCKFI();
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public abstract class NJGCDFBADKM<TTask, T> : POHFLPAEANN<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class BOCOPFCJMBP
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public BOCOPFCJMBP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x44C4D70", Offset = "0x44C4170", VA = "0x1844C4D70", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0x44C5030", Offset = "0x44C4430", VA = "0x1844C5030", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public NJGCDFBADKM<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public BOCOPFCJMBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x68EC400", Offset = "0x68EB800", VA = "0x1868EC400")]
		[AsyncStateMachine(typeof(NJGCDFBADKM<, >.BOCOPFCJMBP.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> DGINEODFLAA(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Task<T> KDHFABGBLNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	protected readonly CancellationTokenSource HAGAAAKNION;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public override Task<T> NMFCLADFKMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public override FHMCAMOMJOP<T> LCACPCNKDPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x5811000", Offset = "0x5810400", VA = "0x185811000")]
	protected NJGCDFBADKM(TTask KDHFABGBLNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x5810DF0", Offset = "0x58101F0", VA = "0x185810DF0", Slot = "10")]
	protected override void DOACBKHCKFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T LKDKDJPFHFE(TTask INOJAFNMNAO);

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void JNGHMJGIFNP();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class IEIDMKFCPOC<T> : POHFLPAEANN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly GDOFCMCMKJK<Task<T>> NKKHCNOFCJI;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override Task<T> NMFCLADFKMM
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x4EA2DE0", Offset = "0x4EA21E0", VA = "0x184EA2DE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override FHMCAMOMJOP<T> LCACPCNKDPF
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x50C8FB0", Offset = "0x50C83B0", VA = "0x1850C8FB0")]
	public IEIDMKFCPOC(GDOFCMCMKJK<Task<T>> JKGHFECAPDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x50C8F90", Offset = "0x50C8390", VA = "0x1850C8F90", Slot = "10")]
	protected override void DOACBKHCKFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class KNNKPCOLOGG
{
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly HashAlgorithmName OLMDDANNNLA;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly ThreadLocal<IncrementalHash> EBBILKHHALA;

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x826BDB0", Offset = "0x826B1B0", VA = "0x18826BDB0")]
	public static int IOGBJOGGCAF(this DLIEGFGDABH MHKABLIEFGN, IncrementalHash GONCBGJFGEK, byte[] GIAPNMOHCID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x826B700", Offset = "0x826AB00", VA = "0x18826B700")]
	public static bool FFMNPLBGDLK([CanBeNull] this DLIEGFGDABH MHKABLIEFGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x826B760", Offset = "0x826AB60", VA = "0x18826B760")]
	public static bool FFMNPLBGDLK([CanBeNull] this DLIEGFGDABH MHKABLIEFGN, [Out] string FKPCAPOIAIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x826BA70", Offset = "0x826AE70", VA = "0x18826BA70")]
	public static bool FFMNPLBGDLK([CanBeNull] this DLIEGFGDABH MHKABLIEFGN, IncrementalHash GONCBGJFGEK, byte[] GIAPNMOHCID, [Out] string FKPCAPOIAIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x826BE40", Offset = "0x826B240", VA = "0x18826BE40")]
	private static bool OKOGJCDCFND(byte[] LHKGDGCEMHL, Span<byte> KMMGIIELOIN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class GIJGBEEHJMI
{
	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x8269DB0", Offset = "0x82691B0", VA = "0x188269DB0")]
	public static int DJHNGBOPMOP(HashAlgorithmName CMFIDOKNHCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x3CB4C50", Offset = "0x3CB4050", VA = "0x183CB4C50")]
	public static int IOGBJOGGCAF<T>(this T EJLKFAEGIPA, byte[] OMPBEGGKKEB, IncrementalHash GONCBGJFGEK, byte[] JKBAJLJEGAL) where T : LFLJJLGFANG
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface LFLJJLGFANG
{
	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash GONCBGJFGEK);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface DLIEGFGDABH : LFLJJLGFANG
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	[CanBeNull]
	byte[] MIEDALIOCKI
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	[CanBeNull]
	byte[] MHAJCEBCNPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class HPAAMICGAML
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static bool FKLCPBHGCLC;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly ArrayPool<byte> BCPKALNODHM;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly ArrayPool<char> NFKEPGAIJMG;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly Encoding FIHHLBMKHOI;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly ThreadLocal<Encoder> BOGPJJKPKIJ;

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3CE77C0", Offset = "0x3CE6BC0", VA = "0x183CE77C0")]
	public static void NHMPKANIGCJ<T>(this IncrementalHash PGFJABBMLPM, [CanBeNull] T FCIHIIPNCLK) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3CE7730", Offset = "0x3CE6B30", VA = "0x183CE7730")]
	public static void LLAOPBJCOEL<T>(this IncrementalHash PGFJABBMLPM, [CanBeNull] T EJLKFAEGIPA) where T : LFLJJLGFANG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x3CE7210", Offset = "0x3CE6610", VA = "0x183CE7210")]
	public static void JFOCMHFDOPK<T>(this IncrementalHash PGFJABBMLPM, [CanBeNull] IList<T> IMAJEEICABH) where T : LFLJJLGFANG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x826A9B0", Offset = "0x8269DB0", VA = "0x18826A9B0")]
	private static bool JNMFLCIOBNJ([CanBeNull] LFLJJLGFANG EJLKFAEGIPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x826A0D0", Offset = "0x82694D0", VA = "0x18826A0D0")]
	public static void FNHJACGEBPC(this IncrementalHash GONCBGJFGEK, string? NECLNPCEKCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x826AC70", Offset = "0x826A070", VA = "0x18826AC70")]
	public static void POPMICPMION(this IncrementalHash GONCBGJFGEK, long LMEAMHFLGHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x826A4E0", Offset = "0x82698E0", VA = "0x18826A4E0")]
	public static void FODEPIPPEMD(this IncrementalHash GONCBGJFGEK, int FFJAMMGLBKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x826A6B0", Offset = "0x8269AB0", VA = "0x18826A6B0")]
	public static void GKKKGIDHJMI(this IncrementalHash GONCBGJFGEK, short JGMECGBLLOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x8269FC0", Offset = "0x82693C0", VA = "0x188269FC0")]
	public static void DEBFJJLFAAG(this IncrementalHash GONCBGJFGEK, byte PEDICPPOLJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x826AA40", Offset = "0x8269E40", VA = "0x18826AA40")]
	public static void KCLKIELAHAH(this IncrementalHash GONCBGJFGEK, bool DCJHDHIGIMJ, bool FAADFBFEDMP = false, bool LKBBALELCLG = false, bool OJKICCNGFMK = false, bool EOLJGPAEANO = false, bool KGHBKIHJEBK = false, bool IIOKJBPEIGM = false, bool OAOIOBMJGJK = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x3CE65B0", Offset = "0x3CE59B0", VA = "0x183CE65B0")]
	public static void GALBCHNFEEF<T>(this IncrementalHash GONCBGJFGEK, T JFDJMGGLGMC) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x8269F00", Offset = "0x8269300", VA = "0x188269F00")]
	public static void CFDNMKICPEA(this IncrementalHash GONCBGJFGEK, float LKJOHBOHPMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x8269F60", Offset = "0x8269360", VA = "0x188269F60")]
	public static void CNNIHPDMNLJ(this IncrementalHash GONCBGJFGEK, ulong DNEJCJEFBPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x826AC10", Offset = "0x826A010", VA = "0x18826AC10")]
	public static void NELCDAKBBHJ(this IncrementalHash GONCBGJFGEK, uint BOMHBOELOGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x826ABB0", Offset = "0x8269FB0", VA = "0x18826ABB0")]
	public static void MCOFICEDHGM(this IncrementalHash GONCBGJFGEK, ushort OPELDKGGIFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x826A880", Offset = "0x8269C80", VA = "0x18826A880")]
	public static void GPCEBKLHDFN(this IncrementalHash GONCBGJFGEK, Vector3 NIJLKCPPLEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class LCMMDILEKOC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x826C020", Offset = "0x826B420", VA = "0x18826C020")]
	public LCMMDILEKOC(string AFDNIPHJHMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class NOJBEAOCBDL
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate void EKFLOMBHMHA(ushort KFIOBABBHFO, ushort GGCMAMOIGCH, ushort PEHLPFJJGCI, ushort BJAMFGAHABE);

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate void BMDHPBMIEKF(ushort HCIAPKEFMGC, ushort PBILONGIEDL);

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public delegate void LIJIFGDDBBH();

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const ushort KHCJPLMNGMB = ushort.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
	protected NOJBEAOCBDL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class FNMPCJHJCCA<T> : NOJBEAOCBDL where T : FNMPCJHJCCA<T>.KEGBOIPGCAJ
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public interface KEGBOIPGCAJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		BMDHPBMIEKF OOHOKGBIPIN
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		BMDHPBMIEKF NIFNBDLOOLI
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		LIJIFGDDBBH AHOFLDNONOP
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Dictionary<uint, T> GOGBMGCHHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private LIJIFGDDBBH HJPJEDLDIKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private LIJIFGDDBBH LEHJGHJCAAD;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool IOIJHKHIAEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0xAC6D20", Offset = "0xAC6120", VA = "0x180AC6D20")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA7DA60", Offset = "0xA7CE60", VA = "0x180A7DA60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public ushort LNHFFALFPFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x1239E80", Offset = "0x1239280", VA = "0x181239E80")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x123A280", Offset = "0x1239680", VA = "0x18123A280")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public ushort HIDHJAADIPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x4EAF910", Offset = "0x4EAED10", VA = "0x184EAF910")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x4EAF7B0", Offset = "0x4EAEBB0", VA = "0x184EAF7B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public ushort GHPMMNBLMBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xF1B2B0", Offset = "0xF1A6B0", VA = "0x180F1B2B0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0xF1B370", Offset = "0xF1A770", VA = "0x180F1B370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public ushort PHOMCGMHHGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x4EAF900", Offset = "0x4EAED00", VA = "0x184EAF900")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x4EB0010", Offset = "0x4EAF410", VA = "0x184EB0010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	protected bool AJNEMKNPNDG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x123A270", Offset = "0x1239670", VA = "0x18123A270")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected bool KLAEPJPMMNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x22A8390", Offset = "0x22A7790", VA = "0x1822A8390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event EKFLOMBHMHA FEEBECAIKFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4EB0020", Offset = "0x4EAF420", VA = "0x184EB0020")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4EAF860", Offset = "0x4EAEC60", VA = "0x184EAF860")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x4EB00C0", Offset = "0x4EAF4C0", VA = "0x184EB00C0")]
	private T ICFPFABFJNH(ushort NEJOOJPPLDC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x4EAF7C0", Offset = "0x4EAEBC0", VA = "0x184EAF7C0")]
	private T DGPBCOJPBLG(ushort NEJOOJPPLDC, ushort LLJECGJGGLE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x4EB0280", Offset = "0x4EAF680", VA = "0x184EB0280")]
	protected T IFIKBPELIDL(uint LGBMNJABJEF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x4EB0560", Offset = "0x4EAF960", VA = "0x184EB0560")]
	protected FNMPCJHJCCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x4EB0260", Offset = "0x4EAF660", VA = "0x184EB0260")]
	public void IDIMJEELIGM(ushort JCOMPLEIOEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x4EB0150", Offset = "0x4EAF550", VA = "0x184EB0150")]
	public void IDIMJEELIGM(ushort JCOMPLEIOEG, ushort MICMMKJKKEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x4EB01A0", Offset = "0x4EAF5A0", VA = "0x184EB01A0", Slot = "4")]
	protected virtual void IDIMJEELIGM(uint OPLOPEHNAHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x4EAF930", Offset = "0x4EAED30", VA = "0x184EAF930")]
	protected void GAGDJNAIPNI(uint OPLOPEHNAHO, uint DDEHAMABEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x4EB04F0", Offset = "0x4EAF8F0", VA = "0x184EB04F0")]
	protected void PPCKMGEBHCD(ushort NEJOOJPPLDC, ushort LLJECGJGGLE, T JPDKKKJJNLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x4EAF770", Offset = "0x4EAEB70", VA = "0x184EAF770")]
	private void BFJDKHLAHJG(uint LGBMNJABJEF, T JPDKKKJJNLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x4EB02C0", Offset = "0x4EAF6C0", VA = "0x184EB02C0")]
	protected void NEEGIEHLJAF(float HBFJOJKDNMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x4EAF7A0", Offset = "0x4EAEBA0", VA = "0x184EAF7A0")]
	protected uint CAHEKBGNMOF(ushort NEJOOJPPLDC, ushort LLJECGJGGLE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x4EAF920", Offset = "0x4EAED20", VA = "0x184EAF920")]
	protected ushort FIFBBCJAEPH(uint PDGMGJCBAMC)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x4EAF850", Offset = "0x4EAEC50", VA = "0x184EAF850")]
	protected ushort DMEEELCBKCJ(uint PDGMGJCBAMC)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class APCMAEJKGHN : FNMPCJHJCCA<APCMAEJKGHN.IMEGOBHALBP>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class IMEGOBHALBP : KEGBOIPGCAJ
	{
		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public BMDHPBMIEKF OOHOKGBIPIN
		{
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0xA70250", Offset = "0xA6F650", VA = "0x180A70250", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0xA70290", Offset = "0xA6F690", VA = "0x180A70290")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public BMDHPBMIEKF NIFNBDLOOLI
		{
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public LIJIFGDDBBH AHOFLDNONOP
		{
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0xA6D140", Offset = "0xA6C540", VA = "0x180A6D140", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1C0", Offset = "0xA6C5C0", VA = "0x180A6D1C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public IMEGOBHALBP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x82695E0", Offset = "0x82689E0", VA = "0x1882695E0")]
	public void EFCENBDPDDL(ushort LBHDDGHCKEI, BMDHPBMIEKF NANEPGKAAJG, BMDHPBMIEKF NAOANLKEBPM, LIJIFGDDBBH DMLCMOABMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x8269500", Offset = "0x8268900", VA = "0x188269500")]
	public void EFCENBDPDDL(ushort NEJOOJPPLDC, ushort LLJECGJGGLE, BMDHPBMIEKF NANEPGKAAJG, BMDHPBMIEKF NAOANLKEBPM, LIJIFGDDBBH DMLCMOABMOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x82696C0", Offset = "0x8268AC0", VA = "0x1882696C0")]
	public void OGELNPLKAMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x8269710", Offset = "0x8268B10", VA = "0x188269710")]
	protected APCMAEJKGHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class IOINGJAJMHM : APCMAEJKGHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private bool FCEPOLLEEIA;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool OEKNIBMILKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xD31600", Offset = "0xD30A00", VA = "0x180D31600")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0xE3FF90", Offset = "0xE3F390", VA = "0x180E3FF90")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x826B140", Offset = "0x826A540", VA = "0x18826B140")]
	public void PJOFCLDPLJB(ushort FBGEOBGPJPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x826B0E0", Offset = "0x826A4E0", VA = "0x18826B0E0")]
	public void PJOFCLDPLJB(ushort FBGEOBGPJPP, ushort AHPBEDAAKNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x8269710", Offset = "0x8268B10", VA = "0x188269710")]
	public IOINGJAJMHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class JFGAKNCMECN<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal class EIDNOHCDBLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public TNode DMFKPMONDPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public TNode JIECBJMGMAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public ANPAGLDPPOE CCGANJILKHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public List<ANPAGLDPPOE> JFFMAGNKCEM;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public EIDNOHCDBLH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal struct ANPAGLDPPOE : IComparable<ANPAGLDPPOE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int ODFIJNEMHKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public TClaimant HAOEILGJLFN;

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x18FE520", Offset = "0x18FD920", VA = "0x1818FE520")]
		public ANPAGLDPPOE(int ODFIJNEMHKN, TClaimant HAOEILGJLFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x52C06D0", Offset = "0x52BFAD0", VA = "0x1852C06D0")]
		public bool HFGCGIAFCKF([In] ANPAGLDPPOE LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x52C0730", Offset = "0x52BFB30", VA = "0x1852C0730")]
		public bool LGFJPKAKOEC([In] ANPAGLDPPOE LHDOHAKINKP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x52C06C0", Offset = "0x52BFAC0", VA = "0x1852C06C0", Slot = "4")]
		public int CompareTo(ANPAGLDPPOE LHDOHAKINKP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x52C0740", Offset = "0x52BFB40", VA = "0x1852C0740", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public enum JOEMHELMLNJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class BJOMOGCMJFF : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public JFGAKNCMECN<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xFC9810", Offset = "0xFC8C10", VA = "0x180FC9810")]
		[DebuggerHidden]
		public BJOMOGCMJFF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0xA6ED70", Offset = "0xA6E170", VA = "0x180A6ED70", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x6559990", Offset = "0x6558D90", VA = "0x186559990", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x6559B50", Offset = "0x6558F50", VA = "0x186559B50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x6559A70", Offset = "0x6558E70", VA = "0x186559A70", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x4EF4800", Offset = "0x4EF3C00", VA = "0x184EF4800", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly OADHGJHHIPF<EIDNOHCDBLH> DJKDGBBEKAO;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly OADHGJHHIPF<List<ANPAGLDPPOE>> NFNCGCHDJHH;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static int EMPMJHBMDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	internal readonly Dictionary<TClaimant, TNode> KDNNNAJONPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	internal readonly Dictionary<TNode, EIDNOHCDBLH> MPHMGOBMHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private JOEMHELMLNJ KLNPGHMOELH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool GJNOCMLAONB;

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode IPKGCGIDGPI(TNode BLJBPFHLMML);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void KJPGABEPHEC(TNode BLJBPFHLMML, TClaimant NHEEOODEBCD, TClaimant ODEAKJECIDL);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x530CAA0", Offset = "0x530BEA0", VA = "0x18530CAA0")]
	public JFGAKNCMECN(JOEMHELMLNJ KLNPGHMOELH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x530C700", Offset = "0x530BB00", VA = "0x18530C700")]
	public void NPFDKGIMPDO(TNode BLJBPFHLMML, TNode LPICKFBBMGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x530B660", Offset = "0x530AA60", VA = "0x18530B660")]
	public void BNGLKPALEAJ(TClaimant HAOEILGJLFN, TNode DEIFGDBAMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x530BB70", Offset = "0x530AF70", VA = "0x18530BB70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x530B350", Offset = "0x530A750", VA = "0x18530B350")]
	private void ACEBPMOPFMM(TClaimant HAOEILGJLFN, TNode OAFLMAMHOFL, TNode DEIFGDBAMFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x530BE00", Offset = "0x530B200", VA = "0x18530BE00")]
	private int FIFEJJOLMLI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x530B850", Offset = "0x530AC50", VA = "0x18530B850")]
	private void DHMKEPDAJOM(TClaimant HAOEILGJLFN, TNode PPGLELNFLCA, TNode FBKFBKODJAE, int MGJPHACLIMD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x530B500", Offset = "0x530A900", VA = "0x18530B500")]
	private void BMKOKFOAGGJ(ANPAGLDPPOE ADIPGJHFGIG, EIDNOHCDBLH CMHOGPBPNOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x530C320", Offset = "0x530B720", VA = "0x18530C320")]
	private void MKAOBJMNNMF(TClaimant HAOEILGJLFN, TNode PPGLELNFLCA, TNode FBKFBKODJAE, int MGJPHACLIMD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x530B3F0", Offset = "0x530A7F0", VA = "0x18530B3F0")]
	private void ALABGGDHCAB(ANPAGLDPPOE ADIPGJHFGIG, TNode BLJBPFHLMML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x530B580", Offset = "0x530A980", VA = "0x18530B580")]
	private void BNFGIHHJDJP(ANPAGLDPPOE ADIPGJHFGIG, EIDNOHCDBLH CMHOGPBPNOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x530C5E0", Offset = "0x530B9E0", VA = "0x18530C5E0")]
	private void NMLNALOOPKC(EIDNOHCDBLH CMHOGPBPNOC, bool LKBFEPDNKIP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x530BE70", Offset = "0x530B270", VA = "0x18530BE70")]
	private void HJDBOJOBLIF(EIDNOHCDBLH CMHOGPBPNOC, TNode LPICKFBBMGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x530B780", Offset = "0x530AB80", VA = "0x18530B780")]
	[IteratorStateMachine(typeof(JFGAKNCMECN<, >.BJOMOGCMJFF))]
	private IEnumerable<TNode> CKFFDPJDJOE(TNode PPGLELNFLCA, TNode FBKFBKODJAE, bool NDBAHGKHODM = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x530BD20", Offset = "0x530B120", VA = "0x18530BD20")]
	private EIDNOHCDBLH FBCPPFLGGCH(TNode BLJBPFHLMML, TNode JIECBJMGMAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x530C790", Offset = "0x530BB90", VA = "0x18530C790")]
	private EIDNOHCDBLH OPMNPPLGHCF(TNode BLJBPFHLMML, TNode JIECBJMGMAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x530C1C0", Offset = "0x530B5C0", VA = "0x18530C1C0")]
	private void MGALOHPDHHK(EIDNOHCDBLH CMHOGPBPNOC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class KACAOJNCDBK<T> : IEnumerable<KACAOJNCDBK<T>.IEOPKBJECBL>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public struct IEOPKBJECBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public T CBMEHPPMEEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public int NOEININIMIL;
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class CKPHGAECHDG : IEnumerator<IEOPKBJECBL>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private KACAOJNCDBK<T> FKMIOCNPCCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int NOEININIMIL;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x4A03070", Offset = "0x4A02470", VA = "0x184A03070", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public IEOPKBJECBL FEIHGLOFMJE
		{
			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x6D817B0", Offset = "0x6D80BB0", VA = "0x186D817B0", Slot = "4")]
			get
			{
				return default(IEOPKBJECBL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x6D81770", Offset = "0x6D80B70", VA = "0x186D81770")]
		public CKPHGAECHDG(KACAOJNCDBK<T> FKMIOCNPCCJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x6D816F0", Offset = "0x6D80AF0", VA = "0x186D816F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x4A6C340", Offset = "0x4A6B740", VA = "0x184A6C340", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x12EF0D0", Offset = "0x12EE4D0", VA = "0x1812EF0D0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private struct BIOAMKPLGLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public bool KCNAIGNCMHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public T CBMEHPPMEEA;
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private const int BKMBPIMLCIM = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly Dictionary<T, int> PPPAGDBBHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private BIOAMKPLGLA[] OEOKLICKHLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int NEKHGNIHAPC;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int GHENNCEGOAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xC1A7F0", Offset = "0xC19BF0", VA = "0x180C1A7F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x104AEA0", Offset = "0x104A2A0", VA = "0x18104AEA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int JGJMKJIDNDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x44DC760", Offset = "0x44DBB60", VA = "0x1844DC760")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x542F850", Offset = "0x542EC50", VA = "0x18542F850")]
	public KACAOJNCDBK(int HLNAOJHAMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x542F4A0", Offset = "0x542E8A0", VA = "0x18542F4A0")]
	public KACAOJNCDBK(IEOPKBJECBL[] HPFOFIDKPIN, bool DIGABLFNABE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x542E990", Offset = "0x542DD90", VA = "0x18542E990")]
	public int KHPBLMNLDBN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x542F050", Offset = "0x542E450", VA = "0x18542F050")]
	private int PPGEFHLJBOO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x542E970", Offset = "0x542DD70", VA = "0x18542E970", Slot = "6")]
	protected virtual uint GIEEEMEGMFB(uint GONCBGJFGEK, T CBMEHPPMEEA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x542EA50", Offset = "0x542DE50", VA = "0x18542EA50")]
	public bool MLBGHPMLKCL(T CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x542EB00", Offset = "0x542DF00", VA = "0x18542EB00")]
	public int PCCPKEHPMJF(T CBMEHPPMEEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x542E880", Offset = "0x542DC80", VA = "0x18542E880")]
	public T FLBGDLPGKPP(int NOEININIMIL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x542ED70", Offset = "0x542E170", VA = "0x18542ED70")]
	public bool PGNMJFBANDH(T CBMEHPPMEEA, bool DCGIIHIJLML = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x542EB70", Offset = "0x542DF70", VA = "0x18542EB70")]
	public bool PGNMJFBANDH(T CBMEHPPMEEA, int NOEININIMIL, bool DCGIIHIJLML = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x542E7E0", Offset = "0x542DBE0", VA = "0x18542E7E0")]
	private int AECFKIDBHFP(int FDIBAFEDFOG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x542F420", Offset = "0x542E820", VA = "0x18542F420", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x542F420", Offset = "0x542E820", VA = "0x18542F420", Slot = "4")]
	private IEnumerator<IEOPKBJECBL> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class OADHGJHHIPF<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly Stack<T> ONFDFPDBLBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly List<T> NCBKCHBKIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly int HOEDAJHJFKP;

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x594B460", Offset = "0x594A860", VA = "0x18594B460")]
	public static OADHGJHHIPF<T> CLJHHADPHED(int HLNAOJHAMJG = 0, int HOEDAJHJFKP = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x594B8F0", Offset = "0x594ACF0", VA = "0x18594B8F0")]
	public static OADHGJHHIPF<T> KDEJILABKCN(int HLNAOJHAMJG = 0, int HOEDAJHJFKP = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x594BCF0", Offset = "0x594B0F0", VA = "0x18594BCF0")]
	public OADHGJHHIPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x594BD20", Offset = "0x594B120", VA = "0x18594BD20")]
	public OADHGJHHIPF(int HLNAOJHAMJG, int HOEDAJHJFKP = int.MaxValue, bool PCBLMELAENB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x594BAA0", Offset = "0x594AEA0", VA = "0x18594BAA0")]
	public T OGMDNDFHLGF()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x594B9D0", Offset = "0x594ADD0", VA = "0x18594B9D0")]
	public void LLLHPAIEGMF(T CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x594BC20", Offset = "0x594B020", VA = "0x18594BC20")]
	private void PLADCJKPJBL(T CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x594B8D0", Offset = "0x594ACD0", VA = "0x18594B8D0")]
	private void IFBKNDFJEGC(T CBMEHPPMEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x594B540", Offset = "0x594A940", VA = "0x18594B540", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x594B680", Offset = "0x594AA80", VA = "0x18594B680")]
	private void FLGEHCEKLBO(IEnumerable<T> EJCCOPPBIIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class DINMOGNNDCH<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private Dictionary<int, T> JAIKDDBMDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private T ECNENEKDBAH;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public virtual T KNMNKNGCKOG
	{
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0xA6D150", Offset = "0xA6C550", VA = "0x180A6D150", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x455A2A0", Offset = "0x45596A0", VA = "0x18455A2A0")]
	public bool JBMMNIEJAPK(T CBMEHPPMEEA, int ODFIJNEMHKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x455A380", Offset = "0x4559780", VA = "0x18455A380")]
	public bool LLNGNBGKNFB(int ODFIJNEMHKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x455A0C0", Offset = "0x45594C0", VA = "0x18455A0C0")]
	public T IAOPHNLLAGK(int PPJFEEKILFF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x455A490", Offset = "0x4559890", VA = "0x18455A490")]
	private bool OIOLMHFDDNE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x4559E80", Offset = "0x4559280", VA = "0x184559E80")]
	public bool EGMGAAFJGGH(int ODFIJNEMHKN, [Out] T CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x455A560", Offset = "0x4559960", VA = "0x18455A560")]
	public DINMOGNNDCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class IPAEKJPKFEI<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	protected struct EBFCHJMDEAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public T JCMAOCOGHGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int GGCGBFNNIDJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	protected readonly List<EBFCHJMDEAI> NMFJIONMIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private T EMOECBPAHBO;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public int JGJMKJIDNDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x44DC760", Offset = "0x44DBB60", VA = "0x1844DC760")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x51199F0", Offset = "0x5118DF0", VA = "0x1851199F0")]
	public bool BIEHLJBGGLM(T CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x511A2B0", Offset = "0x51196B0", VA = "0x18511A2B0")]
	public void KOBMLIBBKBO(T CBMEHPPMEEA, int ODFIJNEMHKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x5119DC0", Offset = "0x51191C0", VA = "0x185119DC0")]
	public bool CBDHBFLGDII(T CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x511A0A0", Offset = "0x51194A0", VA = "0x18511A0A0")]
	public void HBLMHKLDBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x511A180", Offset = "0x5119580", VA = "0x18511A180")]
	public T JBOFLOBICAH()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x5119870", Offset = "0x5118C70", VA = "0x185119870")]
	protected void APGKPCLAPPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x511A320", Offset = "0x5119720", VA = "0x18511A320")]
	public IPAEKJPKFEI()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[BNCHLJBJHLJ(FIPBCJPBODB.Self, false, false, false)]
		[SerializeField]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x826C4A0", Offset = "0x826B8A0", VA = "0x18826C4A0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x826C770", Offset = "0x826BB70", VA = "0x18826C770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x826C680", Offset = "0x826BA80", VA = "0x18826C680")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x826C3F0", Offset = "0x826B7F0", VA = "0x18826C3F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x826C6C0", Offset = "0x826BAC0", VA = "0x18826C6C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000232")]
			[Cpp2IlInjected.Address(RVA = "0x826C5D0", Offset = "0x826B9D0", VA = "0x18826C5D0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x826C360", Offset = "0x826B760", VA = "0x18826C360")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x5D09C70", Offset = "0x5D09070", VA = "0x185D09C70", Slot = "4")]
		public virtual T AHPHHFLKBGC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface HODADPMMDBI
{
	[Cpp2IlInjected.Token(Token = "0x17000070")]
	ToolHierarchyCache FJPOFPCKBMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		public struct PLBKAJEIOKB<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			private readonly List<Component> KIGLENMLJCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			private readonly bool HMDGKKJAACJ;

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x1A68C90", Offset = "0x1A68090", VA = "0x181A68C90")]
			public PLBKAJEIOKB(List<Component> KIGLENMLJCP, bool HMDGKKJAACJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x5B071D0", Offset = "0x5B065D0", VA = "0x185B071D0")]
			public KMKADBELMKP<T> OJAPBOKMMBI()
			{
				return default(KMKADBELMKP<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x5B07230", Offset = "0x5B06630", VA = "0x185B07230", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x5B07230", Offset = "0x5B06630", VA = "0x185B07230", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000079")]
		public struct KMKADBELMKP<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private readonly List<Component> KIGLENMLJCP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			private readonly bool HMDGKKJAACJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			private int NOEININIMIL;

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public T FEIHGLOFMJE
			{
				[Cpp2IlInjected.Token(Token = "0x6000248")]
				[Cpp2IlInjected.Address(RVA = "0x5460E00", Offset = "0x5460200", VA = "0x185460E00", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000249")]
				[Cpp2IlInjected.Address(RVA = "0x5460D90", Offset = "0x5460190", VA = "0x185460D90", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000247")]
			[Cpp2IlInjected.Address(RVA = "0x5460DD0", Offset = "0x54601D0", VA = "0x185460DD0")]
			public KMKADBELMKP(List<Component> KIGLENMLJCP, bool HMDGKKJAACJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x5460CD0", Offset = "0x54600D0", VA = "0x185460CD0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x5460CE0", Offset = "0x54600E0", VA = "0x185460CE0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x4A56FD0", Offset = "0x4A563D0", VA = "0x184A56FD0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x826E1D0", Offset = "0x826D5D0", VA = "0x18826E1D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x826DF40", Offset = "0x826D340", VA = "0x18826DF40")]
		private void PJOFCLDPLJB(GameObject MLLLHKPDMHN, bool KBIBIFOFAKG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x826E0B0", Offset = "0x826D4B0", VA = "0x18826E0B0")]
		public static void PJOFCLDPLJB(GameObject MLLLHKPDMHN, ToolHierarchyCache INGGBOBKCIL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x826DF30", Offset = "0x826D330", VA = "0x18826DF30")]
		public void HBIFLNIMJEH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x4083E10", Offset = "0x4083210", VA = "0x184083E10")]
		public void KKDOENAMEDD<T>(Action<T> ENDEKEOKCCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x4084030", Offset = "0x4083430", VA = "0x184084030")]
		public T LGLPILPJHFB<T>(bool HMDGKKJAACJ = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x4083D50", Offset = "0x4083150", VA = "0x184083D50")]
		public PLBKAJEIOKB<T> FGGOLLOMIBH<T>(bool HMDGKKJAACJ = false) where T : class
		{
			return default(PLBKAJEIOKB<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x826DB30", Offset = "0x826CF30", VA = "0x18826DB30")]
		public List<Component> FEGNDMPHKCB(Type IIHAKBEOLJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x826DAB0", Offset = "0x826CEB0", VA = "0x18826DAB0", Slot = "4")]
		public bool Equals(ToolHierarchyCache FNBJHADJBNG, ToolHierarchyCache MODFPFNICHM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x826DEC0", Offset = "0x826D2C0", VA = "0x18826DEC0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache DEJGDIIDCDN)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class FLCHBIJBJNC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private int HLNAOJHAMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private int BJDBHPBEOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private List<T> FDNGBEMKOGG;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int JGJMKJIDNDK
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x4EA2DE0", Offset = "0x4EA21E0", VA = "0x184EA2DE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public T BKPAKGNHJLP
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x4EA2BA0", Offset = "0x4EA1FA0", VA = "0x184EA2BA0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public T GDNMOOHMKNI
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x4EA3240", Offset = "0x4EA2640", VA = "0x184EA3240")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public T LEHDDIGKGLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x4EA2E70", Offset = "0x4EA2270", VA = "0x184EA2E70")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x4EA32D0", Offset = "0x4EA26D0", VA = "0x184EA32D0")]
	public FLCHBIJBJNC(int HLNAOJHAMJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x4EA2F50", Offset = "0x4EA2350", VA = "0x184EA2F50")]
	public void KOBMLIBBKBO(T FAEIIEOOJJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x4EA2F00", Offset = "0x4EA2300", VA = "0x184EA2F00")]
	public void HBLMHKLDBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x4EA3130", Offset = "0x4EA2530", VA = "0x184EA3130")]
	public void MGOFHNJJJBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x4EA2D10", Offset = "0x4EA2110", VA = "0x184EA2D10")]
	public void DGLLPMBCMIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x4EA2F40", Offset = "0x4EA2340", VA = "0x184EA2F40")]
	public void JEOEOOOEDEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(RVA = "0x4EA2D60", Offset = "0x4EA2160", VA = "0x184EA2D60")]
	public List<T> DKOAADIJEHL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class PPHOIHPAMHF<T>
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private struct HKJLBEIOPIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public int GGCGBFNNIDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public T JCMAOCOGHGO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly Dictionary<object, HKJLBEIOPIC> JAIKDDBMDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly EqualityComparer<T> AGPDIPPBJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private T ECNENEKDBAH;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public virtual T KNMNKNGCKOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0xE6C740", Offset = "0xE6BB40", VA = "0x180E6C740", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x5B32520", Offset = "0x5B31920", VA = "0x185B32520", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public bool NICHKAPJLPN
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x5B32D20", Offset = "0x5B32120", VA = "0x185B32D20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public object HCNPLEKGGNH
	{
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0xA70370", Offset = "0xA6F770", VA = "0x180A70370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025C")]
		[Cpp2IlInjected.Address(RVA = "0xA719E0", Offset = "0xA70DE0", VA = "0x180A719E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x5B32F50", Offset = "0x5B32350", VA = "0x185B32F50")]
	public bool JBMMNIEJAPK(T CBMEHPPMEEA, object MONGIMOHLAO, int ODFIJNEMHKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x5B33730", Offset = "0x5B32B30", VA = "0x185B33730")]
	public bool LLNGNBGKNFB(object MONGIMOHLAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x5B327E0", Offset = "0x5B31BE0", VA = "0x185B327E0")]
	public bool EGMGAAFJGGH(object MONGIMOHLAO, [Out] T CBMEHPPMEEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x5B32CF0", Offset = "0x5B320F0", VA = "0x185B32CF0")]
	public void HBLMHKLDBPD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x5B337B0", Offset = "0x5B32BB0", VA = "0x185B337B0")]
	private bool OIOLMHFDDNE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(RVA = "0x5B360E0", Offset = "0x5B354E0", VA = "0x185B360E0")]
	public PPHOIHPAMHF()
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
