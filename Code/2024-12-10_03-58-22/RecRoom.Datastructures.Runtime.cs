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
		[Cpp2IlInjected.Address(RVA = "0x8B2480", Offset = "0x8B1080", VA = "0x1808B2480")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C13A90", Offset = "0x6C12690", VA = "0x186C13A90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8B3410", Offset = "0x8B2010", VA = "0x1808B3410")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B3450", Offset = "0x8B2050", VA = "0x1808B3450")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class OALJHBGLNGF : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1738690", Offset = "0x1737290", VA = "0x181738690")]
	public OALJHBGLNGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, OPGKDDHHMDK, DKKKGNJODMD, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x88ABB0", Offset = "0x8897B0", VA = "0x18088ABB0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8866F0", VA = "0x180887AF0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x888260", Offset = "0x886E60", VA = "0x180888260", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA495A0", Offset = "0xA481A0", VA = "0x180A495A0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash IGABCIKOEOA);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8F3410", Offset = "0x8F2010", VA = "0x1808F3410")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C15010", Offset = "0x6C13C10", VA = "0x186C15010")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6C14FD0", Offset = "0x6C13BD0", VA = "0x186C14FD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6C15050", Offset = "0x6C13C50", VA = "0x186C15050")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6C15200", Offset = "0x6C13E00", VA = "0x186C15200")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6C15170", Offset = "0x6C13D70", VA = "0x186C15170")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x918F20", Offset = "0x917B20", VA = "0x180918F20")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA622D0", Offset = "0xA60ED0", VA = "0x180A622D0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6C14F90", Offset = "0x6C13B90", VA = "0x186C14F90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6C150E0", Offset = "0x6C13CE0", VA = "0x186C150E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6C14AF0", Offset = "0x6C136F0", VA = "0x186C14AF0")]
	public void CopyBounds(SavedExtents FDOEIPBMJJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6C14EE0", Offset = "0x6C13AE0", VA = "0x186C14EE0")]
	public void SetLocalSpaceBounds(Bounds LGFHACOFLNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xD6E320", Offset = "0xD6CF20", VA = "0x180D6E320")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6C14ED0", Offset = "0x6C13AD0", VA = "0x186C14ED0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6C14B20", Offset = "0x6C13720", VA = "0x186C14B20")]
	private void LBNNPAODJNF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6C14CD0", Offset = "0x6C138D0", VA = "0x186C14CD0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6C144B0", Offset = "0x6C130B0", VA = "0x186C144B0")]
	public static void CalculateLocalBoundsFor(GameObject DKOODDCANLH, [Out] Bounds LGFHACOFLNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6C143F0", Offset = "0x6C12FF0", VA = "0x186C143F0")]
	private static void BKMMMLFOKDO(Bounds AFHCIMLJCHF, Color NPAFKDGAFPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6C14F00", Offset = "0x6C13B00", VA = "0x186C14F00")]
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
		[Cpp2IlInjected.Address(RVA = "0x8871A0", Offset = "0x885DA0", VA = "0x1808871A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x88FB90", Offset = "0x88E790", VA = "0x18088FB90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x11CD580", Offset = "0x11CC180", VA = "0x1811CD580")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4B6CCF0", Offset = "0x4B6B8F0", VA = "0x184B6CCF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "4")]
	public virtual void HPPKCCEILLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
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
	[OALJHBGLNGF]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4B6C840", Offset = "0x4B6B440", VA = "0x184B6C840", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4B6AF80", Offset = "0x4B69B80", VA = "0x184B6AF80", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4B6CBF0", Offset = "0x4B6B7F0", VA = "0x184B6CBF0")]
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
	private sealed class CIIGMHPNPLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public CIIGMHPNPLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x55DB740", Offset = "0x55DA340", VA = "0x1855DB740")]
		internal int GHJEJJOFEKA(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[OALJHBGLNGF]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3A9DF10", Offset = "0x3A9CB10", VA = "0x183A9DF10", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3A9DF70", Offset = "0x3A9CB70", VA = "0x183A9DF70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3A9DDF0", Offset = "0x3A9C9F0", VA = "0x183A9DDF0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey NONKDEOLPHL]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3A9DEB0", Offset = "0x3A9CAB0", VA = "0x183A9DEB0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3A9DCA0", Offset = "0x3A9C8A0", VA = "0x183A9DCA0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3A9D940", Offset = "0x3A9C540", VA = "0x183A9D940", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3A9CD00", Offset = "0x3A9B900", VA = "0x183A9CD00", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3A9CBD0", Offset = "0x3A9B7D0", VA = "0x183A9CBD0", Slot = "14")]
	protected virtual string DICICCBHNEG(TKeyVal IMNOJHDIPPM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3A9CB70", Offset = "0x3A9B770", VA = "0x183A9CB70", Slot = "4")]
	public bool ContainsKey(TKey NONKDEOLPHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3A9DB20", Offset = "0x3A9C720", VA = "0x183A9DB20", Slot = "5")]
	public bool TryGetValue(TKey NONKDEOLPHL, [Out] TVal CABLCDOIFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3A9CC60", Offset = "0x3A9B860", VA = "0x183A9CC60", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3A9CC60", Offset = "0x3A9B860", VA = "0x183A9CC60", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3A9DB80", Offset = "0x3A9C780", VA = "0x183A9DB80")]
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
		[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x888270", Offset = "0x886E70", VA = "0x180888270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x88ABB0", Offset = "0x8897B0", VA = "0x18088ABB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3A5A620", Offset = "0x3A59220", VA = "0x183A5A620")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	[OALJHBGLNGF]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4B6E6B0", Offset = "0x4B6D2B0", VA = "0x184B6E6B0")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4B6DEF0", Offset = "0x4B6CAF0", VA = "0x184B6DEF0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4B6D4A0", Offset = "0x4B6C0A0", VA = "0x184B6D4A0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class HLLNGBKCEAP<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private class CLGJEAIDNLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public float KBPDPAJFOLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T PPPKGAOABBC;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public CLGJEAIDNLA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class GJNJJHNMBEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public GJNJJHNMBEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x3EEB8C0", Offset = "0x3EEA4C0", VA = "0x183EEB8C0")]
		internal bool KEIPHDJELCM(CLGJEAIDNLA sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly float OAMNPMOCCOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly float AHODEMOBMMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private List<CLGJEAIDNLA> KONEPPOFKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private GPDDNEDAGLO<CLGJEAIDNLA> JLPJDAKPFID;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int PJHEEJJDDFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3F52AE0", Offset = "0x3F516E0", VA = "0x183F52AE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3F53770", Offset = "0x3F52370", VA = "0x183F53770")]
	public HLLNGBKCEAP(float FKEPJCCHLDD, float NCFKNDBEBLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3F52EC0", Offset = "0x3F51AC0", VA = "0x183F52EC0")]
	public bool JFMNGKPLOJA(float GBMJCPKKICC, T CABLCDOIFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3F53090", Offset = "0x3F51C90", VA = "0x183F53090")]
	public IEnumerable<T> PBEJFNLCDHG(float GBMJCPKKICC, [Optional] float? PFGLOAOCKFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3F529C0", Offset = "0x3F515C0", VA = "0x183F529C0")]
	public void ANKOMBFBDGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3F52B50", Offset = "0x3F51750", VA = "0x183F52B50")]
	private void DMMNNFLDDOK(float GBMJCPKKICC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class HKBLGHCIAHE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct CMAEOOIMBFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public T PPPKGAOABBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public float INIDHEPNPGM;
	}

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static float AOADOIMEAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private List<T> LGANCKOIPEI;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private const int BHHNJNMJAEM = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private CMAEOOIMBFC[] BFDOCKABCPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int GPMCDIDDJLF;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float FPPMAICBEED
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xB52F30", Offset = "0xB51B30", VA = "0x180B52F30")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xB72D10", Offset = "0xB71910", VA = "0x180B72D10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3F46520", Offset = "0x3F45120", VA = "0x183F46520")]
	public HKBLGHCIAHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x3F46560", Offset = "0x3F45160", VA = "0x183F46560")]
	public HKBLGHCIAHE(int OLKJNOHMJPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x3F45B30", Offset = "0x3F44730", VA = "0x183F45B30")]
	public void CMCAIIEBGOH(float GBMJCPKKICC, T CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x3F45530", Offset = "0x3F44130", VA = "0x183F45530")]
	public void ANKOMBFBDGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x3F45620", Offset = "0x3F44220", VA = "0x183F45620")]
	public bool BIMIMNIPBPD(float OPAEOLIADNO, float LJEFIFPGOMC, [Out] T CABLCDOIFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x3F45F60", Offset = "0x3F44B60", VA = "0x183F45F60")]
	public bool FLFPMGFBCHA(float OPAEOLIADNO, float LJEFIFPGOMC, [Out] T CABLCDOIFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x3F461B0", Offset = "0x3F44DB0", VA = "0x183F461B0")]
	public void NHECHJNICKE(float OPAEOLIADNO, float LJEFIFPGOMC, List<T> OFBCPBHPLBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x3F46180", Offset = "0x3F44D80", VA = "0x183F46180")]
	private int MIOJLEABCIF(int IGGEBCONMDA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x3F46130", Offset = "0x3F44D30", VA = "0x183F46130")]
	private void GDDKJOCELDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T BBGCEGGCKGK();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T IPCBBKCLHHJ(T CABLCDOIFFL, float APOGBJPOAAH);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T HGLELNEBGIO(T CKONCFGMELN, T GAAMPOEMOPE);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T IOPFAFHMJFB(T CKONCFGMELN, T GAAMPOEMOPE);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class ELGGMEIDEPM : HKBLGHCIAHE<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x898880", Offset = "0x897480", VA = "0x180898880", Slot = "4")]
	protected override Vector3 BBGCEGGCKGK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6C11450", Offset = "0x6C10050", VA = "0x186C11450", Slot = "5")]
	protected override Vector3 IPCBBKCLHHJ(Vector3 CABLCDOIFFL, float APOGBJPOAAH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6C11380", Offset = "0x6C0FF80", VA = "0x186C11380", Slot = "6")]
	protected override Vector3 HGLELNEBGIO(Vector3 CKONCFGMELN, Vector3 GAAMPOEMOPE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6C113D0", Offset = "0x6C0FFD0", VA = "0x186C113D0", Slot = "7")]
	protected override Vector3 IOPFAFHMJFB(Vector3 CKONCFGMELN, Vector3 GAAMPOEMOPE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6C11490", Offset = "0x6C10090", VA = "0x186C11490")]
	public ELGGMEIDEPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class GJAHKDJFMJL
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2E06000", Offset = "0x2E04C00", VA = "0x182E06000")]
	public static BJJFMCLLNEG<T1, T2> ELGDCMPCLII<T1, T2>(T1 DKDKLMJDGJO, T2 LNDFGAAIADB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2E060A0", Offset = "0x2E04CA0", VA = "0x182E060A0")]
	public static IKHCLAAJAGP<T1, T2, T3> ELGDCMPCLII<T1, T2, T3>(T1 DKDKLMJDGJO, T2 LNDFGAAIADB, T3 OCDJPBPDICI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4613CE0", Offset = "0x46128E0", VA = "0x184613CE0")]
	internal static int IHGJCALCKPB(int DCGPJCIIEDJ, int HHPMIIOGCJF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5F65BB0", Offset = "0x5F647B0", VA = "0x185F65BB0")]
	internal static int IHGJCALCKPB(int DCGPJCIIEDJ, int HHPMIIOGCJF, int FOPELCLPDKF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class BJJFMCLLNEG<T1, T2> : IComparable<BJJFMCLLNEG<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly T1 DCPPBNILNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly T2 JKPCCABMJKI;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x50B1CC0", Offset = "0x50B08C0", VA = "0x1850B1CC0")]
	public BJJFMCLLNEG(T1 DKDKLMJDGJO, T2 LNDFGAAIADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x50B02C0", Offset = "0x50AEEC0", VA = "0x1850B02C0", Slot = "4")]
	public int CompareTo(BJJFMCLLNEG<T1, T2> FDOEIPBMJJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x50B0600", Offset = "0x50AF200", VA = "0x1850B0600", Slot = "0")]
	public override bool Equals(object FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x50B0FA0", Offset = "0x50AFBA0", VA = "0x1850B0FA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x50B13D0", Offset = "0x50AFFD0", VA = "0x1850B13D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class IKHCLAAJAGP<T1, T2, T3> : IComparable<IKHCLAAJAGP<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly T1 DCPPBNILNNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly T2 JKPCCABMJKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly T3 GDIGBPPDKJE;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4031400", Offset = "0x4030000", VA = "0x184031400")]
	public IKHCLAAJAGP(T1 DKDKLMJDGJO, T2 LNDFGAAIADB, T3 OCDJPBPDICI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4030A90", Offset = "0x402F690", VA = "0x184030A90", Slot = "4")]
	public int CompareTo(IKHCLAAJAGP<T1, T2, T3> FDOEIPBMJJM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4030D40", Offset = "0x402F940", VA = "0x184030D40", Slot = "0")]
	public override bool Equals(object FDOEIPBMJJM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x40310A0", Offset = "0x402FCA0", VA = "0x1840310A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4031250", Offset = "0x402FE50", VA = "0x184031250", Slot = "3")]
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
	public T PPPKGAOABBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x24D58A0", Offset = "0x24D44A0", VA = "0x1824D58A0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x24D5720", Offset = "0x24D4320", VA = "0x1824D5720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float GKGPIKBDEJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x91A510", Offset = "0x919110", VA = "0x18091A510")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4DC2500", Offset = "0x4DC1100", VA = "0x184DC2500")]
	public T KHAIMMLOFFC(float APOGBJPOAAH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4DC2440", Offset = "0x4DC1040", VA = "0x184DC2440")]
	public T GHEDPAHNFMJ(float APOGBJPOAAH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T FHBMDHGNBBF(T CKONCFGMELN, T GAAMPOEMOPE, float APOGBJPOAAH);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6C114F0", Offset = "0x6C100F0", VA = "0x186C114F0", Slot = "4")]
	protected override float FHBMDHGNBBF(float CKONCFGMELN, float GAAMPOEMOPE, float APOGBJPOAAH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6C11530", Offset = "0x6C10130", VA = "0x186C11530")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x104E9E0", Offset = "0x104D5E0", VA = "0x18104E9E0", Slot = "4")]
	protected override Vector3 FHBMDHGNBBF(Vector3 CKONCFGMELN, Vector3 GAAMPOEMOPE, float APOGBJPOAAH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6C15FD0", Offset = "0x6C14BD0", VA = "0x186C15FD0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6C10050", Offset = "0x6C0EC50", VA = "0x186C10050", Slot = "4")]
	protected override Color FHBMDHGNBBF(Color CKONCFGMELN, Color GAAMPOEMOPE, float APOGBJPOAAH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6C10110", Offset = "0x6C0ED10", VA = "0x186C10110")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class BFJANIOJKMP : JDKFBEENOAB<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6C10000", Offset = "0x6C0EC00", VA = "0x186C10000")]
	public BFJANIOJKMP(int KPFLHEHNDFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6C0FF90", Offset = "0x6C0EB90", VA = "0x186C0FF90", Slot = "6")]
	protected override uint FLFHHCHPADJ(uint IGABCIKOEOA, string CABLCDOIFFL)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class NBICPJKGHBM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly IDisposable AAGIFLNDKEI;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	public NBICPJKGHBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct LOKJHGFJNMI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> HODIFEJLFIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int KEEBFBNNOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int APBEHMLBNMD;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x43C7130", Offset = "0x43C5D30", VA = "0x1843C7130")]
	private LOKJHGFJNMI(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> GGFBOPJAEJB, int IJGEIFNGEFI, int CFOEIOJEJHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x43C53B0", Offset = "0x43C3FB0", VA = "0x1843C53B0")]
	public static LOKJHGFJNMI<T> LMDPPDEOAIA()
	{
		return default(LOKJHGFJNMI<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x43C6A10", Offset = "0x43C5610", VA = "0x1843C6A10")]
	public (int, int, Task<T>) NJNDKGCJDIO(int EKDFELJLMMH, [Optional] CancellationToken CKKFHABGBNL, double KEFCDGNOKGL = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x43C4C10", Offset = "0x43C3810", VA = "0x1843C4C10")]
	public void LBHNAIKELFJ(int EKDFELJLMMH, int CFOEIOJEJHE, [In] T CMNKPAFMHMO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class NPBCHEONBFL
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6C13A40", Offset = "0x6C12640", VA = "0x186C13A40")]
	public static LOKJHGFJNMI<FKMCALNFICP> LMDPPDEOAIA()
	{
		return default(LOKJHGFJNMI<FKMCALNFICP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6C139C0", Offset = "0x6C125C0", VA = "0x186C139C0")]
	public static void LBHNAIKELFJ([In] this LOKJHGFJNMI<FKMCALNFICP> GMNCELIMKIF, int EKDFELJLMMH, int CFOEIOJEJHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public class BOCODBGPDEE<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly Dictionary<TKey, TVal> MKPHLIIPNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<TVal, TKey> EEJDNGNPMPM;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int DNBGNCFCKIN
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x379C8E0", Offset = "0x379B4E0", VA = "0x18379C8E0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool POMDFADBODP
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public ICollection<TKey> DGBOKIIJPPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x4671870", Offset = "0x4670470", VA = "0x184671870", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public ICollection<TVal> NAIAACHGNHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x47D8740", Offset = "0x47D7340", VA = "0x1847D8740", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public TVal CECFGNBJFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x50CEFD0", Offset = "0x50CDBD0", VA = "0x1850CEFD0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x50CF070", Offset = "0x50CDC70", VA = "0x1850CF070", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public TKey CECFGNBJFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x50CE380", Offset = "0x50CCF80", VA = "0x1850CE380")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x50CE440", Offset = "0x50CD040", VA = "0x1850CE440", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x50CEE00", Offset = "0x50CDA00", VA = "0x1850CEE00", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x50CE2E0", Offset = "0x50CCEE0", VA = "0x1850CE2E0", Slot = "9")]
	public void Add(TKey NONKDEOLPHL, TVal CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x50CE330", Offset = "0x50CCF30", VA = "0x1850CE330", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> ANPIFEPGOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x48AEF30", Offset = "0x48ADB30", VA = "0x1848AEF30", Slot = "8")]
	public bool ContainsKey(TKey NONKDEOLPHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x50CE520", Offset = "0x50CD120", VA = "0x1850CE520", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> ANPIFEPGOLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x50CED30", Offset = "0x50CD930", VA = "0x1850CED30", Slot = "10")]
	public bool Remove(TKey NONKDEOLPHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x50CED70", Offset = "0x50CD970", VA = "0x1850CED70", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> ANPIFEPGOLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x50CEE50", Offset = "0x50CDA50", VA = "0x1850CEE50", Slot = "11")]
	public bool TryGetValue(TKey NONKDEOLPHL, [Out] TVal CABLCDOIFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x50CE7A0", Offset = "0x50CD3A0", VA = "0x1850CE7A0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x50CE560", Offset = "0x50CD160", VA = "0x1850CE560", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] BFDOCKABCPN, int GAPDNNJAGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x50CEC30", Offset = "0x50CD830", VA = "0x1850CEC30")]
	public bool NNAAPMJPMIH(TVal NONKDEOLPHL, [Out] TKey CABLCDOIFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x50CE5E0", Offset = "0x50CD1E0", VA = "0x1850CE5E0")]
	private void DMCKECLMIID(TKey NONKDEOLPHL, TVal JEODFFDGHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x50CEB40", Offset = "0x50CD740", VA = "0x1850CEB40")]
	private void JKEDMMEGPFA(TKey NONKDEOLPHL, TVal JEODFFDGHHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x50CE840", Offset = "0x50CD440", VA = "0x1850CE840")]
	private bool IGMKNHBMJOL(TKey NONKDEOLPHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x50CEEB0", Offset = "0x50CDAB0", VA = "0x1850CEEB0")]
	public BOCODBGPDEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class ECOIMJAAGGC<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private ECOIMJAAGGC<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x3AE88A0", Offset = "0x3AE74A0", VA = "0x183AE88A0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x3AF01D0", Offset = "0x3AEEDD0", VA = "0x183AF01D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3AF1890", Offset = "0x3AF0490", VA = "0x183AF1890")]
		public Enumerator(ECOIMJAAGGC<T> OFBCPBHPLBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3AEE6B0", Offset = "0x3AED2B0", VA = "0x183AEE6B0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3AEF640", Offset = "0x3AEE240", VA = "0x183AEF640", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3AED100", Offset = "0x3AEBD00", VA = "0x183AED100")]
		private void DEDLBJOHNCL()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private T[] IAHIBFAGKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int HAOCJMNINJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private int MNLLLHOHODG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private int OGMJKGKJANG;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int DNBGNCFCKIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3A607C0", Offset = "0x3A5F3C0", VA = "0x183A607C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public T CECFGNBJFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3A60EF0", Offset = "0x3A5FAF0", VA = "0x183A60EF0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3A61AF0", Offset = "0x3A606F0", VA = "0x183A61AF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3A62930", Offset = "0x3A61530", VA = "0x183A62930")]
	public ECOIMJAAGGC(int KPFLHEHNDFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3A60BE0", Offset = "0x3A5F7E0", VA = "0x183A60BE0")]
	public void CMCAIIEBGOH(T APOGBJPOAAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3A607A0", Offset = "0x3A5F3A0", VA = "0x183A607A0")]
	public void ANKOMBFBDGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3A619A0", Offset = "0x3A605A0", VA = "0x183A619A0")]
	public void IIDNPBAENDG(int KNHHBEFLJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3A61550", Offset = "0x3A60150", VA = "0x183A61550")]
	public void EKOFGCIACJL(T[] BFDOCKABCPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3A61E50", Offset = "0x3A60A50", VA = "0x183A61E50")]
	public Enumerator NEGBLLIJCNA()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3A62650", Offset = "0x3A61250", VA = "0x183A62650", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3A62650", Offset = "0x3A61250", VA = "0x183A62650", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3A62060", Offset = "0x3A60C60", VA = "0x183A62060")]
	private int NKANEIDLABF(int MFJLAMOCOBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3A61DF0", Offset = "0x3A609F0", VA = "0x183A61DF0")]
	private int KPALLNHOEDE(int MFJLAMOCOBC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class GNKAKBBCPIL<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate Task<TResult> OCMFKLKLBKF(TRequest IBNNNHFPFBF, CancellationToken CKKFHABGBNL);

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public enum JPGLPHFBOFC
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class GAHCIPGBMCA
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private const float CPHBOEIOMEE = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TimeSpan NBADNBFIKMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int PJNNADOCNJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public JPGLPHFBOFC COJPEOILBBL;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public static readonly GAHCIPGBMCA GHFEJGGLAKB;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float KMIEKFGINLL
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x3ED0550", Offset = "0x3ECF150", VA = "0x183ED0550")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan LFPMHKLNNLF
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3ED0630", Offset = "0x3ECF230", VA = "0x183ED0630")]
		public GAHCIPGBMCA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private readonly struct JMCMKINGMIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly TRequest IBNNNHFPFBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly CancellationToken CKKFHABGBNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly TaskCompletionSource<TResult> HMHJMNCNKOH;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x41F4270", Offset = "0x41F2E70", VA = "0x1841F4270")]
		public JMCMKINGMIM(TRequest IBNNNHFPFBF, TaskCompletionSource<TResult> HMHJMNCNKOH, CancellationToken CKKFHABGBNL)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct GOCDLKHIPKM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public GNKAKBBCPIL<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8270", Offset = "0x3EF6E70", VA = "0x183EF8270", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3EF8E70", Offset = "0x3EF7A70", VA = "0x183EF8E70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct BFFIMAHADOB : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public GNKAKBBCPIL<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private JMCMKINGMIM <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x5070CE0", Offset = "0x506F8E0", VA = "0x185070CE0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5071980", Offset = "0x5070580", VA = "0x185071980", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly CancellationTokenSource FDLJIKLFHEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<JMCMKINGMIM> OFOOLABAOLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly GAHCIPGBMCA DOJEIPADELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly OCMFKLKLBKF EDCKGNFMFLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Task JILMNGBOBEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private int JNHKCILFONP;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3EF57B0", Offset = "0x3EF43B0", VA = "0x183EF57B0")]
	public GNKAKBBCPIL(OCMFKLKLBKF EDCKGNFMFLP, [Optional] GAHCIPGBMCA DOJEIPADELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3EF46C0", Offset = "0x3EF32C0", VA = "0x183EF46C0")]
	public Task<TResult> DAEDOCFLKAK(TRequest IBNNNHFPFBF, CancellationToken CKKFHABGBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3EF4FE0", Offset = "0x3EF3BE0", VA = "0x183EF4FE0")]
	private void FOIIAINMNLP(JMCMKINGMIM FOCPBIHKLOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3EF50B0", Offset = "0x3EF3CB0", VA = "0x183EF50B0")]
	[AsyncStateMachine(typeof(GNKAKBBCPIL<, >.GOCDLKHIPKM))]
	private Task MIPJLPNLFCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3EF3E70", Offset = "0x3EF2A70", VA = "0x183EF3E70")]
	private JMCMKINGMIM APLCPHGAIKI()
	{
		return default(JMCMKINGMIM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3EF4C50", Offset = "0x3EF3850", VA = "0x183EF4C50")]
	[AsyncStateMachine(typeof(GNKAKBBCPIL<, >.BFFIMAHADOB))]
	private Task FOGMLLGALHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3EF5420", Offset = "0x3EF4020", VA = "0x183EF5420")]
	private void OKFFCDONNBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3EF4B10", Offset = "0x3EF3710", VA = "0x183EF4B10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class DAKCAHEFDOF<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly List<T> APGPCFDNGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private HashSet<T> EFJCOLDCGBC;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int DNBGNCFCKIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x379C8E0", Offset = "0x379B4E0", VA = "0x18379C8E0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool POMDFADBODP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8D1ED0", Offset = "0x8D0AD0", VA = "0x1808D1ED0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T CECFGNBJFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B3E480", Offset = "0x2B3D080", VA = "0x182B3E480", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5AB7120", Offset = "0x5AB5D20", VA = "0x185AB7120", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3DFC950", Offset = "0x3DFB550", VA = "0x183DFC950", Slot = "11")]
	public void Add(T ANPIFEPGOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5AB6710", Offset = "0x5AB5310", VA = "0x185AB6710")]
	public bool DPACCLIBHJD(T ANPIFEPGOLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5AB6D40", Offset = "0x5AB5940", VA = "0x185AB6D40", Slot = "15")]
	public bool Remove(T ANPIFEPGOLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3F30D60", Offset = "0x3F2F960", VA = "0x183F30D60", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3E6F7E0", Offset = "0x3E6E3E0", VA = "0x183E6F7E0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5AB64C0", Offset = "0x5AB50C0", VA = "0x185AB64C0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5AB6560", Offset = "0x5AB5160", VA = "0x185AB6560", Slot = "13")]
	public bool Contains(T ANPIFEPGOLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5AB65B0", Offset = "0x5AB51B0", VA = "0x185AB65B0", Slot = "14")]
	public void CopyTo(T[] BFDOCKABCPN, int GAPDNNJAGGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x433D6E0", Offset = "0x433C2E0", VA = "0x18433D6E0", Slot = "6")]
	public int IndexOf(T ANPIFEPGOLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5AB6960", Offset = "0x5AB5560", VA = "0x185AB6960", Slot = "7")]
	public void Insert(int MFJLAMOCOBC, T ANPIFEPGOLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5AB6AA0", Offset = "0x5AB56A0", VA = "0x185AB6AA0", Slot = "8")]
	public void RemoveAt(int MFJLAMOCOBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5AB6EC0", Offset = "0x5AB5AC0", VA = "0x185AB6EC0")]
	public DAKCAHEFDOF()
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
			[Cpp2IlInjected.Address(RVA = "0x2360840", Offset = "0x235F440", VA = "0x182360840")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6C155A0", Offset = "0x6C141A0", VA = "0x186C155A0")]
		public SerializedGuid([In] Guid OCIHAODAEFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6C15390", Offset = "0x6C13F90", VA = "0x186C15390")]
		public static SerializedGuid GEFOJFDIMON()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6C15530", Offset = "0x6C14130", VA = "0x186C15530")]
		public static SerializedGuid PNIFLBKGFLE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6C154D0", Offset = "0x6C140D0", VA = "0x186C154D0")]
		public bool PEBIHPCGOKK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6C154A0", Offset = "0x6C140A0", VA = "0x186C154A0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6C15420", Offset = "0x6C14020", VA = "0x186C15420", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6C152C0", Offset = "0x6C13EC0", VA = "0x186C152C0", Slot = "7")]
		public bool Equals(SerializedGuid FDOEIPBMJJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6C15300", Offset = "0x6C13F00", VA = "0x186C15300", Slot = "0")]
		public override bool Equals(object PLAMADMDGIO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6C15410", Offset = "0x6C14010", VA = "0x186C15410", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6C15290", Offset = "0x6C13E90", VA = "0x186C15290", Slot = "6")]
		public int CompareTo(SerializedGuid FDOEIPBMJJM)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class EDHIENMAIDF : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly Type IMBLFABOEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly string GLAJCPLBLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly bool EKNLAJCAOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly bool BHDHEBINKEA;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6C11310", Offset = "0x6C0FF10", VA = "0x186C11310")]
	public EDHIENMAIDF(Type OIOFHAIAGKK, string JKPMPFEMMPK, bool LHGJGFFIAGH = false, bool PNPHDKOGFMF = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class ELHAGIINIBP<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public readonly struct JIBMAAGLALH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly long BEHIBKAANDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly long DKKKFFAMNLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly int IEAIJFCDKHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly int JECKMJPMHNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public readonly bool CKNLNHPOMPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly string PNODKGPHNMF;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x41EF480", Offset = "0x41EE080", VA = "0x1841EF480")]
		public JIBMAAGLALH(long BEHIBKAANDI, int IEAIJFCDKHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x41EF4F0", Offset = "0x41EE0F0", VA = "0x1841EF4F0")]
		public JIBMAAGLALH(long BEHIBKAANDI, long DKKKFFAMNLF, int IEAIJFCDKHI, int JECKMJPMHNJ, bool CKNLNHPOMPA, string PNODKGPHNMF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x41EF410", Offset = "0x41EE010", VA = "0x1841EF410")]
		public int ICDNOKEOGCG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x41EF460", Offset = "0x41EE060", VA = "0x1841EF460")]
		public int PEPFHAKLNJB(int OGNNBAHAIKJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x41EF3B0", Offset = "0x41EDFB0", VA = "0x1841EF3B0")]
		public double HHEBAPKAHIJ()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x41EF310", Offset = "0x41EDF10", VA = "0x1841EF310")]
		public JIBMAAGLALH EKHJDKLAEHG(long DKKKFFAMNLF, int JECKMJPMHNJ)
		{
			return default(JIBMAAGLALH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class ILKJCNDFBCP : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private struct OBEEMPIKGAH<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public ILKJCNDFBCP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public Func<ILKJCNDFBCP, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private ILKJCNDFBCP <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x4793380", Offset = "0x4791F80", VA = "0x184793380", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x3E121A0", Offset = "0x3E10DA0", VA = "0x183E121A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public readonly TKey EIDDFPPJNCP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly ELHAGIINIBP<TKey> MDMPBKGCCHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public readonly BNHLDIHMNLF HOKLECPLLKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private List<ILKJCNDFBCP> IBPGHGHCILH;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string HJCEBADFNHH
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x4033570", Offset = "0x4032170", VA = "0x184033570")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IEnumerable<ILKJCNDFBCP> HJJBBJPJLEK
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x4033A10", Offset = "0x4032610", VA = "0x184033A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public JIBMAAGLALH ECHACHHOKON
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x40339F0", Offset = "0x40325F0", VA = "0x1840339F0")]
			[CompilerGenerated]
			get
			{
				return default(JIBMAAGLALH);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x40339C0", Offset = "0x40325C0", VA = "0x1840339C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4033A50", Offset = "0x4032650", VA = "0x184033A50")]
		internal ILKJCNDFBCP(ELHAGIINIBP<TKey> MDMPBKGCCHN, TKey NONKDEOLPHL, BNHLDIHMNLF HOKLECPLLKF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x40335C0", Offset = "0x40321C0", VA = "0x1840335C0")]
		public ILKJCNDFBCP BKOEEGEFHOJ(TKey NONKDEOLPHL, [Optional] BNHLDIHMNLF? HHFOEMENHPP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2C8C890", Offset = "0x2C8B490", VA = "0x182C8C890")]
		[AsyncStateMachine(typeof(OBEEMPIKGAH<>))]
		public Task<T> JADAGCHAEPM<T>(TKey NONKDEOLPHL, Func<ILKJCNDFBCP, Task<T>> AKLCLFEHBGE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x4033770", Offset = "0x4032370", VA = "0x184033770", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class GIPGHFLBPGH : IEnumerable<(TKey, List<TKey>, JIBMAAGLALH)>, IEnumerable, IEnumerator<(TKey, List<TKey>, JIBMAAGLALH)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private (TKey key, List<TKey> path, JIBMAAGLALH timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public ELHAGIINIBP<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private IEnumerator<(TKey key, List<TKey> path, JIBMAAGLALH timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, JIBMAAGLALH) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x234F9D0", Offset = "0x234E5D0", VA = "0x18234F9D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, JIBMAAGLALH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x3EEA940", Offset = "0x3EE9540", VA = "0x183EEA940", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x234FAC0", Offset = "0x234E6C0", VA = "0x18234FAC0")]
		[DebuggerHidden]
		public GIPGHFLBPGH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3D5B830", Offset = "0x3D5A430", VA = "0x183D5B830", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3EEA480", Offset = "0x3EE9080", VA = "0x183EEA480", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3EEA430", Offset = "0x3EE9030", VA = "0x183EEA430")]
		private void GOOHPDHLOBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3EEA8F0", Offset = "0x3EE94F0", VA = "0x183EEA8F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3EEA820", Offset = "0x3EE9420", VA = "0x183EEA820", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, JIBMAAGLALH)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3A63E40", Offset = "0x3A62A40", VA = "0x183A63E40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class ACMDLGLMKAF : IEnumerable<(TKey, List<TKey>, JIBMAAGLALH)>, IEnumerable, IEnumerator<(TKey, List<TKey>, JIBMAAGLALH)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private (TKey key, List<TKey> path, JIBMAAGLALH timerEntry) <>2__current;

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
		private ILKJCNDFBCP timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public ILKJCNDFBCP <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public ELHAGIINIBP<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private IEnumerator<ILKJCNDFBCP> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private IEnumerator<(TKey key, List<TKey> path, JIBMAAGLALH timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private (TKey, List<TKey>, JIBMAAGLALH) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x234F9D0", Offset = "0x234E5D0", VA = "0x18234F9D0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, JIBMAAGLALH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x3EA2820", Offset = "0x3EA1420", VA = "0x183EA2820", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x234FAC0", Offset = "0x234E6C0", VA = "0x18234FAC0")]
		[DebuggerHidden]
		public ACMDLGLMKAF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3EA2880", Offset = "0x3EA1480", VA = "0x183EA2880", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3EA1EC0", Offset = "0x3EA0AC0", VA = "0x183EA1EC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3EA1E60", Offset = "0x3EA0A60", VA = "0x183EA1E60")]
		private void GOOHPDHLOBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3EA1E00", Offset = "0x3EA0A00", VA = "0x183EA1E00")]
		private void BLMKNMDJMNK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x3EA27D0", Offset = "0x3EA13D0", VA = "0x183EA27D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3EA2690", Offset = "0x3EA1290", VA = "0x183EA2690", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, JIBMAAGLALH)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3EA2790", Offset = "0x3EA1390", VA = "0x183EA2790", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly Action<TKey, JIBMAAGLALH, BNHLDIHMNLF> KNFJHCNGAAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Action<TKey, JIBMAAGLALH, BNHLDIHMNLF> EKBPBNMEEMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Action<ELHAGIINIBP<TKey>, BNHLDIHMNLF> IHKAOFMLKEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly BNHLDIHMNLF HOKLECPLLKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly ILKJCNDFBCP IIAMKMPJCAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private bool IMLFLKFFANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int MMONGECIFFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Stopwatch LEJGEMGBDLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly int LOCPIPNCALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private string MPEEGLIKELL;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public ILKJCNDFBCP EJJDJNJFPMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x887B10", Offset = "0x886710", VA = "0x180887B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[NotNull]
	public string HJCEBADFNHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x88C740", Offset = "0x88B340", VA = "0x18088C740")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3A89BB0", Offset = "0x3A887B0", VA = "0x183A89BB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3A89EE0", Offset = "0x3A88AE0", VA = "0x183A89EE0")]
	public ELHAGIINIBP(TKey NEHOIPGEJIG, BNHLDIHMNLF HOKLECPLLKF, [Optional] int? IEAIJFCDKHI, [Optional][CanBeNull] Stopwatch LEJGEMGBDLA, [Optional] Action<TKey, JIBMAAGLALH, BNHLDIHMNLF> KNFJHCNGAAH, [Optional] Action<TKey, JIBMAAGLALH, BNHLDIHMNLF> EKBPBNMEEMP, [Optional] Action<ELHAGIINIBP<TKey>, BNHLDIHMNLF> IHKAOFMLKEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3A89D90", Offset = "0x3A88990", VA = "0x183A89D90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3A89C10", Offset = "0x3A88810", VA = "0x183A89C10")]
	[IteratorStateMachine(typeof(ELHAGIINIBP<>.GIPGHFLBPGH))]
	public IEnumerable<(TKey, List<TKey>, JIBMAAGLALH)> BOECKBLGOLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3A89CB0", Offset = "0x3A888B0", VA = "0x183A89CB0")]
	[IteratorStateMachine(typeof(ELHAGIINIBP<>.ACMDLGLMKAF))]
	private IEnumerable<(TKey, List<TKey>, JIBMAAGLALH)> BOECKBLGOLO(List<TKey> BJNACHPNEEP, ILKJCNDFBCP OHFBIOJFKPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3A89E60", Offset = "0x3A88A60", VA = "0x183A89E60")]
	private (long, int) OOAIGOJECIG()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public abstract class LJEBABAFFFJ<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut NOHEDCPAGPP(ELHAGIINIBP<TKey> MDMPBKGCCHN);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	protected LJEBABAFFFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public abstract class BHHPIDPPDKD<TKey> : LJEBABAFFFJ<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate string JGMKPNLOEOH(TKey NONKDEOLPHL);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x50AC8B0", Offset = "0x50AB4B0", VA = "0x1850AC8B0")]
	private static string AKFOCEPEDEA(TKey NONKDEOLPHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x50ACA40", Offset = "0x50AB640", VA = "0x1850ACA40", Slot = "4")]
	public override string NOHEDCPAGPP(ELHAGIINIBP<TKey> MDMPBKGCCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x50AC8F0", Offset = "0x50AB4F0", VA = "0x1850AC8F0")]
	public string NOHEDCPAGPP(ELHAGIINIBP<TKey> MDMPBKGCCHN, [NotNull] JGMKPNLOEOH ENAOECPEGFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string PJHALPMBKLA(ELHAGIINIBP<TKey> MDMPBKGCCHN, [NotNull] JGMKPNLOEOH ENAOECPEGFO);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3E20760", Offset = "0x3E1F360", VA = "0x183E20760")]
	protected BHHPIDPPDKD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class JECCGEACPOJ<TKey> : LJEBABAFFFJ<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate string GMJADNEHABN(TKey NONKDEOLPHL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly string LIGEJAKAAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly double JPAELJODAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly bool LMELOPOAHDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly int JCLHLGPPDNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly ISet<string> EKHGBFIOKGK;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x41E44D0", Offset = "0x41E30D0", VA = "0x1841E44D0")]
	private static string AKFOCEPEDEA(TKey NONKDEOLPHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x41E50D0", Offset = "0x41E3CD0", VA = "0x1841E50D0")]
	public JECCGEACPOJ(string LIGEJAKAAGE = "F2", double JPAELJODAJC = double.MaxValue, bool LMELOPOAHDD = false, int JCLHLGPPDNB = int.MaxValue, [Optional] ISet<string> EKHGBFIOKGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x41E4950", Offset = "0x41E3550", VA = "0x1841E4950", Slot = "4")]
	public override Dictionary<string, string> NOHEDCPAGPP(ELHAGIINIBP<TKey> MDMPBKGCCHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x41E4780", Offset = "0x41E3380", VA = "0x1841E4780")]
	private bool GKEHGAAFJFO(string PBJDJGLLEON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x41E4A30", Offset = "0x41E3630", VA = "0x1841E4A30")]
	public Dictionary<string, string> NOHEDCPAGPP(ELHAGIINIBP<TKey> MDMPBKGCCHN, GMJADNEHABN ENAOECPEGFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x41E4510", Offset = "0x41E3110", VA = "0x1841E4510")]
	private string GFCKDABAIAH(StringBuilder KGEOJJDJNCJ, List<TKey> AFHENONDALL, GMJADNEHABN ENAOECPEGFO, bool JLFGHJKIPCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x41E47F0", Offset = "0x41E33F0", VA = "0x1841E47F0")]
	private static void HJGONPJDBJM(StringBuilder PGOAPIDKOHF, string JNJADIHFAAJ, bool BFOFJIPOPNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class DCDLHIMBPGP<TKey> : BHHPIDPPDKD<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct JHIELCLDDIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public JGMKPNLOEOH keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static DCDLHIMBPGP<TKey> AAGIFLNDKEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly string[] ACHIOINAFKI;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5ABE7C0", Offset = "0x5ABD3C0", VA = "0x185ABE7C0")]
	private DCDLHIMBPGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5ABD860", Offset = "0x5ABC460", VA = "0x185ABD860", Slot = "5")]
	protected override string PJHALPMBKLA(ELHAGIINIBP<TKey> MDMPBKGCCHN, JGMKPNLOEOH ENAOECPEGFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5ABD760", Offset = "0x5ABC360", VA = "0x185ABD760")]
	[CompilerGenerated]
	internal static string DEJAOHAHMCN(string KCNGFIGKDAH, TKey NONKDEOLPHL, JHIELCLDDIN P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class LJBJPIKBFBK : ELHAGIINIBP<string>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class LNLFHNHKIMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Action<LJBJPIKBFBK, BNHLDIHMNLF> callback;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public LNLFHNHKIMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6C138C0", Offset = "0x6C124C0", VA = "0x186C138C0")]
		internal void LJPCKEBNEPH(ELHAGIINIBP<string> timer, BNHLDIHMNLF log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6C13770", Offset = "0x6C12370", VA = "0x186C13770")]
	public LJBJPIKBFBK(BNHLDIHMNLF HOKLECPLLKF, [Optional] string FDDOJKEDHBB, [Optional] int? IEAIJFCDKHI, [Optional] Stopwatch LEJGEMGBDLA, [Optional] Action<string, JIBMAAGLALH, BNHLDIHMNLF> KNFJHCNGAAH, [Optional] Action<string, JIBMAAGLALH, BNHLDIHMNLF> EKBPBNMEEMP, [Optional] Action<LJBJPIKBFBK, BNHLDIHMNLF> IHKAOFMLKEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6C136B0", Offset = "0x6C122B0", VA = "0x186C136B0")]
	private static Action<ELHAGIINIBP<string>, BNHLDIHMNLF> CAJFBFHHEGJ(Action<LJBJPIKBFBK, BNHLDIHMNLF> NNGDIBHFMBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public abstract class AEGKBJKHKHE
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private class KFOKBAHLMLL : AEGKBJKHKHE
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static AEGKBJKHKHE AAGIFLNDKEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x6C13570", Offset = "0x6C12170", VA = "0x186C13570")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override float CDEDODLIGMN
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0xB514D0", Offset = "0xB500D0", VA = "0x180B514D0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6C13660", Offset = "0x6C12260", VA = "0x186C13660")]
		public KFOKBAHLMLL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static AEGKBJKHKHE EMPNAMIKNJF;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static AEGKBJKHKHE GHFEJGGLAKB
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6C0FBE0", Offset = "0x6C0E7E0", VA = "0x186C0FBE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public abstract float CDEDODLIGMN
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	protected AEGKBJKHKHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface ICGCFKNNIIE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool KIIJDPHLFKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface MGEGMLPKNPK<T> : ICGCFKNNIIE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	[NotNull]
	Task<T> JKLKDMDCGCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	[NotNull]
	HHDNLBNGHMC<T> FHMLDBCLJHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class LJCPFBHPKNI
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2EDC1B0", Offset = "0x2EDADB0", VA = "0x182EDC1B0")]
	public static MGEGMLPKNPK<TResource> NDFBODFDKNJ<TResource, TId>(this AKKGBCJBMHJ<TId, TResource> FAJPBGGJLEJ, TId MJDOIIBKEKN, [Optional] Func<TId, CancellationToken, Task<TResource>>? FHEFKDOFPBL) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class CBBDFCNLLGO
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private sealed class ADFMMEFOKIM<T> : IHONDELONOF<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override Task<T?> JKLKDMDCGCM
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override HHDNLBNGHMC<T?> FHMLDBCLJHN
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8866F0", VA = "0x180887AF0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x3EA49E0", Offset = "0x3EA35E0", VA = "0x183EA49E0")]
		public ADFMMEFOKIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "10")]
		protected override void EMCDAACENKG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private sealed class HHNOELGKFGI<T> : IHONDELONOF<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly T BBHJOFPOBFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly Action<T>? DGEMPIMCEBJ;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override Task<T> JKLKDMDCGCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x88C720", Offset = "0x88B320", VA = "0x18088C720", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override HHDNLBNGHMC<T> FHMLDBCLJHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x88C520", Offset = "0x88B120", VA = "0x18088C520", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x3F3E5C0", Offset = "0x3F3D1C0", VA = "0x183F3E5C0")]
		public HHNOELGKFGI(T NDBPGFIPMNE, Action<T>? DFCOBDBBLMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x3F3E3D0", Offset = "0x3F3CFD0", VA = "0x183F3E3D0", Slot = "10")]
		protected override void EMCDAACENKG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private sealed class IFKKIDPIMHJ<T> : IHONDELONOF<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override Task<T> JKLKDMDCGCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override HHDNLBNGHMC<T> FHMLDBCLJHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8866F0", VA = "0x180887AF0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x4026B00", Offset = "0x4025700", VA = "0x184026B00")]
		public IFKKIDPIMHJ(Exception EFPHLGHGCEN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "10")]
		protected override void EMCDAACENKG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private sealed class MGKKPAAKHGB<T> : IHONDELONOF<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct CHCACIHLFBG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public Task<MGEGMLPKNPK<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private TaskAwaiter<MGEGMLPKNPK<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x55D1C00", Offset = "0x55D0800", VA = "0x1855D1C00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x55D25E0", Offset = "0x55D11E0", VA = "0x1855D25E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private struct DLAEJOPABKN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public Task<MGEGMLPKNPK<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private TaskAwaiter<MGEGMLPKNPK<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x5B01720", Offset = "0x5B00320", VA = "0x185B01720", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x5B01950", Offset = "0x5B00550", VA = "0x185B01950", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly Task<MGEGMLPKNPK<T>> CMDNEALCJLO;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override Task<T> JKLKDMDCGCM
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8866F0", VA = "0x180887AF0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override HHDNLBNGHMC<T> FHMLDBCLJHN
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x88ABD0", Offset = "0x8897D0", VA = "0x18088ABD0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x45B2FB0", Offset = "0x45B1BB0", VA = "0x1845B2FB0")]
		public MGKKPAAKHGB(Task<MGEGMLPKNPK<T>> NEEKHCPCAAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x45B29F0", Offset = "0x45B15F0", VA = "0x1845B29F0", Slot = "10")]
		protected override void EMCDAACENKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x45B2CD0", Offset = "0x45B18D0", VA = "0x1845B2CD0")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(MGKKPAAKHGB<>.CHCACIHLFBG))]
		internal static Task<T> LPFGFIDOLIP(Task<MGEGMLPKNPK<T>> NEEKHCPCAAC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x45B2BF0", Offset = "0x45B17F0", VA = "0x1845B2BF0")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(MGKKPAAKHGB<>.DLAEJOPABKN))]
		internal static Task KMJOGKNBONJ(Task<MGEGMLPKNPK<T>> NEEKHCPCAAC)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class GGDEAKINHJG<TIn, TOut> : IHONDELONOF<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct BOACLOHIFDD : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x50CD780", Offset = "0x50CC380", VA = "0x1850CD780", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x45BDFC0", Offset = "0x45BCBC0", VA = "0x1845BDFC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly MGEGMLPKNPK<TIn> DCJMKFDKMHA;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<TOut> JKLKDMDCGCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8866F0", VA = "0x180887AF0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override HHDNLBNGHMC<TOut> FHMLDBCLJHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x88ABD0", Offset = "0x8897D0", VA = "0x18088ABD0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3EE5760", Offset = "0x3EE4360", VA = "0x183EE5760")]
		public GGDEAKINHJG(MGEGMLPKNPK<TIn> DDLAHAHGMPH, Func<TIn, TOut> EONPGCBLCEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x3EE53C0", Offset = "0x3EE3FC0", VA = "0x183EE53C0", Slot = "10")]
		protected override void EMCDAACENKG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x3EE55E0", Offset = "0x3EE41E0", VA = "0x183EE55E0")]
		[AsyncStateMachine(typeof(GGDEAKINHJG<, >.BOACLOHIFDD))]
		[CompilerGenerated]
		internal static Task<TOut> MJBCILMOHPB(Task<TIn> JCOMCFEDHKG, Func<TIn, TOut> EONPGCBLCEA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2BF5C50", Offset = "0x2BF4850", VA = "0x182BF5C50")]
	public static MGEGMLPKNPK<T> EHFCNKAFHAH<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x2BF5BA0", Offset = "0x2BF47A0", VA = "0x182BF5BA0")]
	public static MGEGMLPKNPK<T> ANJEDINPONB<T>(T CMNKPAFMHMO, [Optional] Action<T>? DFCOBDBBLMK) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2BF5CD0", Offset = "0x2BF48D0", VA = "0x182BF5CD0")]
	public static MGEGMLPKNPK<T> HPCBCBNPAGD<T>(Exception EFPHLGHGCEN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x2BF5CD0", Offset = "0x2BF48D0", VA = "0x182BF5CD0")]
	public static MGEGMLPKNPK<T> NKLCJKJKGLK<T>(Task<MGEGMLPKNPK<T>> NEEKHCPCAAC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2B8B240", Offset = "0x2B89E40", VA = "0x182B8B240")]
	public static MGEGMLPKNPK<TOut> DJCNFDBJOLJ<TOut, TIn>(MGEGMLPKNPK<TIn> JBFBMCPGKHE, Func<TIn, TOut> EONPGCBLCEA) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public abstract class IHONDELONOF<T> : MGEGMLPKNPK<T>, ICGCFKNNIIE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly string KLEECFOMMBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly KBDLCKKEKFO BNOFJIIMJGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private bool IMLFLKFFANH;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool KIIJDPHLFKB
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xD4B480", Offset = "0xD4A080", VA = "0x180D4B480", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public abstract Task<T> JKLKDMDCGCM
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public abstract HHDNLBNGHMC<T> FHMLDBCLJHN
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x402DCF0", Offset = "0x402C8F0", VA = "0x18402DCF0")]
	public IHONDELONOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x402DA60", Offset = "0x402C660", VA = "0x18402DA60", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void EMCDAACENKG();
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public abstract class HMNPGEFNICB<TTask, T> : IHONDELONOF<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class AACECDHFJPK
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
			public AACECDHFJPK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x378B610", Offset = "0x378A210", VA = "0x18378B610", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x378B8D0", Offset = "0x378A4D0", VA = "0x18378B8D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public HMNPGEFNICB<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public AACECDHFJPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x3E9A530", Offset = "0x3E99130", VA = "0x183E9A530")]
		[AsyncStateMachine(typeof(HMNPGEFNICB<, >.AACECDHFJPK.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> KHKMPGLBECE(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly Task<T> NEEKHCPCAAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	protected readonly CancellationTokenSource IMJPMIKGHND;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public override Task<T> JKLKDMDCGCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public override HHDNLBNGHMC<T> FHMLDBCLJHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8866F0", VA = "0x180887AF0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x3F5A720", Offset = "0x3F59320", VA = "0x183F5A720")]
	protected HMNPGEFNICB(TTask NEEKHCPCAAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3F5A6D0", Offset = "0x3F592D0", VA = "0x183F5A6D0", Slot = "10")]
	protected override void EMCDAACENKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T EOPCAPHLOIN(TTask BMOOBLAOMLB);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void EBFIFEDLDIP();
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class IDGNLFAEAFO<T> : IHONDELONOF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly LFNFGMGFLKN<Task<T>> PNPMBGBEPJI;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public override Task<T> JKLKDMDCGCM
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x4018030", Offset = "0x4016C30", VA = "0x184018030", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public override HHDNLBNGHMC<T> FHMLDBCLJHN
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8866F0", VA = "0x180887AF0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x40180A0", Offset = "0x4016CA0", VA = "0x1840180A0")]
	public IDGNLFAEAFO(LFNFGMGFLKN<Task<T>> GKIKKMMMBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x4018080", Offset = "0x4016C80", VA = "0x184018080", Slot = "10")]
	protected override void EMCDAACENKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class GFDOLLCOFOM
{
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static readonly HashAlgorithmName NMHNGMLNKLF;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly ThreadLocal<IncrementalHash> IOEBLAKGNAP;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6C11CA0", Offset = "0x6C108A0", VA = "0x186C11CA0")]
	public static int DDHMACPNOKM(this OPGKDDHHMDK AEAOHGKEOEI, IncrementalHash IGABCIKOEOA, byte[] CKDGAAGNCLK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6C11C40", Offset = "0x6C10840", VA = "0x186C11C40")]
	public static bool CCEPGLAEPBN([CanBeNull] this OPGKDDHHMDK AEAOHGKEOEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6C11600", Offset = "0x6C10200", VA = "0x186C11600")]
	public static bool CCEPGLAEPBN([CanBeNull] this OPGKDDHHMDK AEAOHGKEOEI, [Out] string IHNODDPNJFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6C11910", Offset = "0x6C10510", VA = "0x186C11910")]
	public static bool CCEPGLAEPBN([CanBeNull] this OPGKDDHHMDK AEAOHGKEOEI, IncrementalHash IGABCIKOEOA, byte[] CKDGAAGNCLK, [Out] string IHNODDPNJFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6C11570", Offset = "0x6C10170", VA = "0x186C11570")]
	private static bool AGCKIFDBHIG(byte[] HJPHLFGGCOO, Span<byte> KAOJAGMNMMC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class PHONOFDCNMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6C13D70", Offset = "0x6C12970", VA = "0x186C13D70")]
	public static int OOKIBNNMMOA(HashAlgorithmName BKGMPEMAEIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6C13B10", Offset = "0x6C12710", VA = "0x186C13B10")]
	public static int DDHMACPNOKM(this DKKKGNJODMD GMMHGFBIJBG, byte[] KDPHBPMHAFD, IncrementalHash IGABCIKOEOA, byte[] PPGABPCANGP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface DKKKGNJODMD
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash IGABCIKOEOA);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface OPGKDDHHMDK : DKKKGNJODMD
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	[CanBeNull]
	byte[] DBKEJIKMHGN
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	[CanBeNull]
	byte[] PCNBKIJCKFM
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class HPIHKFGEKFD
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static bool GJPOBLEIDHB;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly ArrayPool<byte> DFIBLAKLPLF;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly ArrayPool<char> NILJGCGFOJA;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly Encoding HLJOHMJIBMP;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly ThreadLocal<Encoder> LPLIPJFFNIL;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x2E3E3B0", Offset = "0x2E3CFB0", VA = "0x182E3E3B0")]
	public static void OHBMEGCNAAK<T>(this IncrementalHash KOAKGHFHINM, [CanBeNull] T BHEFEMNBEDJ) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2E3E320", Offset = "0x2E3CF20", VA = "0x182E3E320")]
	public static void KJIPFNKLAHA<T>(this IncrementalHash KOAKGHFHINM, [CanBeNull] T GMMHGFBIJBG) where T : DKKKGNJODMD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x2E3D7D0", Offset = "0x2E3C3D0", VA = "0x182E3D7D0")]
	public static void AJIAFEKGAMF<T>(this IncrementalHash KOAKGHFHINM, [CanBeNull] IList<T> INKABDCMHMC) where T : DKKKGNJODMD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6C12CA0", Offset = "0x6C118A0", VA = "0x186C12CA0")]
	private static bool MPLDACJNGND([CanBeNull] DKKKGNJODMD GMMHGFBIJBG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6C123D0", Offset = "0x6C10FD0", VA = "0x186C123D0")]
	public static void HAHMEOACPIO(this IncrementalHash IGABCIKOEOA, string? BPEGOMOILGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6C12EA0", Offset = "0x6C11AA0", VA = "0x186C12EA0")]
	public static void NMFBKCLJHLD(this IncrementalHash IGABCIKOEOA, long JLIEJMDKKDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6C13070", Offset = "0x6C11C70", VA = "0x186C13070")]
	public static void NOBGKPFDJFJ(this IncrementalHash IGABCIKOEOA, int KHNNECJDPLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6C127D0", Offset = "0x6C113D0", VA = "0x186C127D0")]
	public static void JFIEHIMKFPB(this IncrementalHash IGABCIKOEOA, short FPAJHENAKMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6C129A0", Offset = "0x6C115A0", VA = "0x186C129A0")]
	public static void KEDKMBBPKDO(this IncrementalHash IGABCIKOEOA, byte PADADEGKEBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6C12D30", Offset = "0x6C11930", VA = "0x186C12D30")]
	public static void NHGMBNCHAAD(this IncrementalHash IGABCIKOEOA, bool IGGMNMHNECF, bool BFHDALPKFHN = false, bool DAGDILGIIFI = false, bool NMKLLFCHGJL = false, bool MOFBMDGLCKK = false, bool NKJGFHNFINB = false, bool AICNLACBMIN = false, bool AEIOFAAFLAF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x2E3DCF0", Offset = "0x2E3C8F0", VA = "0x182E3DCF0")]
	public static void GNKELBEDELC<T>(this IncrementalHash IGABCIKOEOA, T DIBAENLMLKH) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6C12310", Offset = "0x6C10F10", VA = "0x186C12310")]
	public static void CHIIAODMKPG(this IncrementalHash IGABCIKOEOA, float HIIOEJMHCKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6C12370", Offset = "0x6C10F70", VA = "0x186C12370")]
	public static void GCHNMFBDFAN(this IncrementalHash IGABCIKOEOA, ulong KHCNGIDEFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6C12B10", Offset = "0x6C11710", VA = "0x186C12B10")]
	public static void KKIDMJOMLND(this IncrementalHash IGABCIKOEOA, uint AIJPNIMEGLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6C12AB0", Offset = "0x6C116B0", VA = "0x186C12AB0")]
	public static void KIMIOLLPMIH(this IncrementalHash IGABCIKOEOA, ushort IKPNJKLDJMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6C12B70", Offset = "0x6C11770", VA = "0x186C12B70")]
	public static void LGIPLJPCEOK(this IncrementalHash IGABCIKOEOA, Vector3 MOKBCHEKNKL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class DINKOPIMKDD : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6C10150", Offset = "0x6C0ED50", VA = "0x186C10150")]
	public DINKOPIMKDD(string LFKIGNHCOID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public abstract class HEEHHOEDBHP
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public delegate void ABAGFOCPCHM(ushort DFJNNNDDGHD, ushort NBDKNNACONG, ushort EHGMAOFCABG, ushort NJMJCIKMEPH);

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public delegate void DIOJIOEJGPF(ushort PMMCGLLJIJD, ushort FIEGIBFFGCI);

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public delegate void CGFDEMAJNCK();

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public const ushort BJHDBNCIDCE = ushort.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
	protected HEEHHOEDBHP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public abstract class LBHKLOLFPLA<T> : HEEHHOEDBHP where T : LBHKLOLFPLA<T>.BNIAFNMCAIG
{
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public interface BNIAFNMCAIG
	{
		[Cpp2IlInjected.Token(Token = "0x17000054")]
		DIOJIOEJGPF HGMGMJNMKIP
		{
			[Cpp2IlInjected.Token(Token = "0x60001B6")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		DIOJIOEJGPF GMCOOIJBIOI
		{
			[Cpp2IlInjected.Token(Token = "0x60001B7")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		CGFDEMAJNCK FBKBGOHBOBL
		{
			[Cpp2IlInjected.Token(Token = "0x60001B8")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private Dictionary<uint, T> GHKNPGPENLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private CGFDEMAJNCK GJCEIHLNOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private CGFDEMAJNCK ABMGCAHANNB;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool MDIBLCPBKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0xA22440", Offset = "0xA21040", VA = "0x180A22440")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x892E30", Offset = "0x891A30", VA = "0x180892E30")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public ushort OBAELLOGFKH
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x4365C80", Offset = "0x4364880", VA = "0x184365C80")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x4364C50", Offset = "0x4363850", VA = "0x184364C50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public ushort OAKLGJOAPBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x4365170", Offset = "0x4363D70", VA = "0x184365170")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x4364ED0", Offset = "0x4363AD0", VA = "0x184364ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public ushort NDKOOJIKGFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x1F45280", Offset = "0x1F43E80", VA = "0x181F45280")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x1F45330", Offset = "0x1F43F30", VA = "0x181F45330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public ushort PLAAHJGBPEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x4364FB0", Offset = "0x4363BB0", VA = "0x184364FB0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x4364FA0", Offset = "0x4363BA0", VA = "0x184364FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	protected bool COAOCDKKLEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x10C2310", Offset = "0x10C0F10", VA = "0x1810C2310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	protected bool BJBJGMLNMDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0xBE74B0", Offset = "0xBE60B0", VA = "0x180BE74B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event ABAGFOCPCHM PCMIHCFBDIO
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x4365250", Offset = "0x4363E50", VA = "0x184365250")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x43652F0", Offset = "0x4363EF0", VA = "0x1843652F0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x4365BD0", Offset = "0x43647D0", VA = "0x184365BD0")]
	private T OMCBGJADGCN(ushort HECCHHAPAEK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x4365C90", Offset = "0x4364890", VA = "0x184365C90")]
	private T PCBNIHAKDFA(ushort HECCHHAPAEK, ushort JEOPAIJDFNK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x4365190", Offset = "0x4363D90", VA = "0x184365190")]
	protected T JMPIKFLFIGN(uint KCGEMIEDPMB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x4365D50", Offset = "0x4364950", VA = "0x184365D50")]
	protected LBHKLOLFPLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x4365130", Offset = "0x4363D30", VA = "0x184365130")]
	public void IBBNGPLBBOF(ushort FNCJBLEJJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x43650D0", Offset = "0x4363CD0", VA = "0x1843650D0")]
	public void IBBNGPLBBOF(ushort FNCJBLEJJFK, ushort GDAAFHMHLPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x4364FC0", Offset = "0x4363BC0", VA = "0x184364FC0", Slot = "4")]
	protected virtual void IBBNGPLBBOF(uint LBDOOGOEGHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x4365390", Offset = "0x4363F90", VA = "0x184365390")]
	protected void MKDGHMLEHIA(uint LBDOOGOEGHG, uint AOMLMFPPCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x4364EE0", Offset = "0x4363AE0", VA = "0x184364EE0")]
	protected void EKJKGPFNAAD(ushort HECCHHAPAEK, ushort JEOPAIJDFNK, T GFCPLDIMNPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x43651F0", Offset = "0x4363DF0", VA = "0x1843651F0")]
	private void JOFFGFNEBBE(uint KCGEMIEDPMB, T GFCPLDIMNPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x4364C60", Offset = "0x4363860", VA = "0x184364C60")]
	protected void CFPPECIKPAA(float EOJDMAMGKKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x4365180", Offset = "0x4363D80", VA = "0x184365180")]
	protected uint JJNHEMNGJHF(ushort HECCHHAPAEK, ushort JEOPAIJDFNK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x4364F90", Offset = "0x4363B90", VA = "0x184364F90")]
	protected ushort FLIBCMFPHGM(uint FHICMPGLPDG)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x4365BC0", Offset = "0x43647C0", VA = "0x184365BC0")]
	protected ushort NEJNECMPKDJ(uint FHICMPGLPDG)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public abstract class AMHMCKLIPFH : LBHKLOLFPLA<AMHMCKLIPFH.EGDBDIGMDMD>
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class EGDBDIGMDMD : BNIAFNMCAIG
	{
		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public DIOJIOEJGPF HGMGMJNMKIP
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x888270", Offset = "0x886E70", VA = "0x180888270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public DIOJIOEJGPF GMCOOIJBIOI
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x88ABB0", Offset = "0x8897B0", VA = "0x18088ABB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public CGFDEMAJNCK FBKBGOHBOBL
		{
			[Cpp2IlInjected.Token(Token = "0x60001C1")]
			[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8866F0", VA = "0x180887AF0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C2")]
			[Cpp2IlInjected.Address(RVA = "0x888260", Offset = "0x886E60", VA = "0x180888260")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public EGDBDIGMDMD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6C0FE20", Offset = "0x6C0EA20", VA = "0x186C0FE20")]
	public void GJHOOILLLAM(ushort JDCBHGJHGKL, DIOJIOEJGPF MLKOMELBNMA, DIOJIOEJGPF FEIEIMBMIAO, CGFDEMAJNCK LAODGIKIOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6C0FD40", Offset = "0x6C0E940", VA = "0x186C0FD40")]
	public void GJHOOILLLAM(ushort HECCHHAPAEK, ushort JEOPAIJDFNK, DIOJIOEJGPF MLKOMELBNMA, DIOJIOEJGPF FEIEIMBMIAO, CGFDEMAJNCK LAODGIKIOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x6C0FF00", Offset = "0x6C0EB00", VA = "0x186C0FF00")]
	public void HMDNBLCBPCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x6C0FF50", Offset = "0x6C0EB50", VA = "0x186C0FF50")]
	protected AMHMCKLIPFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class JIGCNLFGOML : AMHMCKLIPFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private bool PNICHAHNEGC;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool LNEBBFIJLFI
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x908600", Offset = "0x907200", VA = "0x180908600")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x908610", Offset = "0x907210", VA = "0x180908610")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x6C13510", Offset = "0x6C12110", VA = "0x186C13510")]
	public void KMAKNPIEEHP(ushort MEGACLJHGAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x6C134B0", Offset = "0x6C120B0", VA = "0x186C134B0")]
	public void KMAKNPIEEHP(ushort MEGACLJHGAA, ushort DAEANBKNCFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x6C0FF50", Offset = "0x6C0EB50", VA = "0x186C0FF50")]
	public JIGCNLFGOML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class NJPEEOPAHCD<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	internal class EIKBHJEKLJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public TNode GMNCELIMKIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public TNode CDBGCEIGNJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public HBBCGEPIAJJ LCMKGCMMEHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public List<HBBCGEPIAJJ> OIAFMPOOFBL;

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public EIKBHJEKLJP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000064")]
	internal struct HBBCGEPIAJJ : IComparable<HBBCGEPIAJJ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public int LLJMNDBPFJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public TClaimant NKHNJGBNMLH;

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0xF963E0", Offset = "0xF94FE0", VA = "0x180F963E0")]
		public HBBCGEPIAJJ(int LLJMNDBPFJI, TClaimant NKHNJGBNMLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x3F30570", Offset = "0x3F2F170", VA = "0x183F30570")]
		public bool FDPMILNLIGP([In] HBBCGEPIAJJ FDOEIPBMJJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x3F305D0", Offset = "0x3F2F1D0", VA = "0x183F305D0")]
		public bool LDAMJNJECKF([In] HBBCGEPIAJJ FDOEIPBMJJM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x3F30560", Offset = "0x3F2F160", VA = "0x183F30560", Slot = "4")]
		public int CompareTo(HBBCGEPIAJJ FDOEIPBMJJM)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x3F305E0", Offset = "0x3F2F1E0", VA = "0x183F305E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public enum FLDIAAIMNFF
	{
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	[CompilerGenerated]
	private sealed class EFIMAPKPLFK : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public NJPEEOPAHCD<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x8E1390", Offset = "0x8DFF90", VA = "0x1808E1390")]
		[DebuggerHidden]
		public EFIMAPKPLFK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x3A6A7A0", Offset = "0x3A693A0", VA = "0x183A6A7A0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x3A6A9C0", Offset = "0x3A695C0", VA = "0x183A6A9C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x3A6A880", Offset = "0x3A69480", VA = "0x183A6A880", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x3A6A980", Offset = "0x3A69580", VA = "0x183A6A980", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly GPDDNEDAGLO<EIKBHJEKLJP> GGPNDPGKEHE;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly GPDDNEDAGLO<List<HBBCGEPIAJJ>> ICLKLFIIEIC;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static int JPNOCCDGDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	internal readonly Dictionary<TClaimant, TNode> OIEHKJGHPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	internal readonly Dictionary<TNode, EIKBHJEKLJP> OEKHBDLFPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private FLDIAAIMNFF DCNHCLKJAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private bool HINLMPLCGEB;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode ABELJLHOKHJ(TNode HNCCPGMBLOD);

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void EAJFKLLOJKH(TNode HNCCPGMBLOD, TClaimant NPJCACGGAGG, TClaimant AIPIJLPPDIG);

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x46770D0", Offset = "0x4675CD0", VA = "0x1846770D0")]
	public NJPEEOPAHCD(FLDIAAIMNFF DCNHCLKJAMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x4676980", Offset = "0x4675580", VA = "0x184676980")]
	public void PNAKCJLJEJG(TNode HNCCPGMBLOD, TNode NDJJLBGHFGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x4676730", Offset = "0x4675330", VA = "0x184676730")]
	public void MIMDKOMMHLD(TClaimant NKHNJGBNMLH, TNode EBABMHPODAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x4675E90", Offset = "0x4674A90", VA = "0x184675E90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x4675A70", Offset = "0x4674670", VA = "0x184675A70")]
	private void CMPEGLNOLEG(TClaimant NKHNJGBNMLH, TNode CELJCLPPFBE, TNode EBABMHPODAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x4676D30", Offset = "0x4675930", VA = "0x184676D30")]
	private int POMKIDANCBH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x4675B40", Offset = "0x4674740", VA = "0x184675B40")]
	private void DPGBCGEGGGF(TClaimant NKHNJGBNMLH, TNode HGMOPCCBKDN, TNode OMPOBHCLMBI, int KDBANPECJKF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x46768B0", Offset = "0x46754B0", VA = "0x1846768B0")]
	private void PDBBNPBHFOD(HBBCGEPIAJJ AIIKLEFEMDG, EIKBHJEKLJP NEMFFPFIOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x4676A40", Offset = "0x4675640", VA = "0x184676A40")]
	private void PNJLBPKKMFM(TClaimant NKHNJGBNMLH, TNode HGMOPCCBKDN, TNode OMPOBHCLMBI, int KDBANPECJKF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x4676400", Offset = "0x4675000", VA = "0x184676400")]
	private void JBLBCMJOPPO(HBBCGEPIAJJ AIIKLEFEMDG, TNode HNCCPGMBLOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x4676DA0", Offset = "0x46759A0", VA = "0x184676DA0")]
	private void PPOIANHKDBE(HBBCGEPIAJJ AIIKLEFEMDG, EIKBHJEKLJP NEMFFPFIOFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x46755E0", Offset = "0x46741E0", VA = "0x1846755E0")]
	private void BELEIPEPCDA(EIKBHJEKLJP NEMFFPFIOFE, bool LMNIIGECENA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x4676090", Offset = "0x4674C90", VA = "0x184676090")]
	private void IPCLEJNDHPJ(EIKBHJEKLJP NEMFFPFIOFE, TNode NDJJLBGHFGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x4676530", Offset = "0x4675130", VA = "0x184676530")]
	[IteratorStateMachine(typeof(NJPEEOPAHCD<, >.EFIMAPKPLFK))]
	private IEnumerable<TNode> JLJKIOMMNJA(TNode HGMOPCCBKDN, TNode OMPOBHCLMBI, bool OEPCIDKDBCD = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x4676620", Offset = "0x4675220", VA = "0x184676620")]
	private EIKBHJEKLJP LCDBCDIOIID(TNode HNCCPGMBLOD, TNode CDBGCEIGNJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x46758F0", Offset = "0x46744F0", VA = "0x1846758F0")]
	private EIKBHJEKLJP CGCBMNJMIJE(TNode HNCCPGMBLOD, TNode CDBGCEIGNJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x4675730", Offset = "0x4674330", VA = "0x184675730")]
	private void CEBCAOABIGN(EIKBHJEKLJP NEMFFPFIOFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class JDKFBEENOAB<T> : IEnumerable<JDKFBEENOAB<T>.ADJFCAPJNNM>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public struct ADJFCAPJNNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public T CABLCDOIFFL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public int MFJLAMOCOBC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class PFDFBBPLDCO : IEnumerator<ADJFCAPJNNM>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private JDKFBEENOAB<T> CANDNHJPNMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int MFJLAMOCOBC;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x3A9E860", Offset = "0x3A9D460", VA = "0x183A9E860", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public ADJFCAPJNNM FFEGLPIJFMI
		{
			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x4882FD0", Offset = "0x4881BD0", VA = "0x184882FD0", Slot = "4")]
			get
			{
				return default(ADJFCAPJNNM);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x4882F90", Offset = "0x4881B90", VA = "0x184882F90")]
		public PFDFBBPLDCO(JDKFBEENOAB<T> CANDNHJPNMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x4882E90", Offset = "0x4881A90", VA = "0x184882E90", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x3AF6880", Offset = "0x3AF5480", VA = "0x183AF6880", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0xAE9C20", Offset = "0xAE8820", VA = "0x180AE9C20", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	private struct MJFOGBBFGGB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public bool EKBHLJDHOJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public T CABLCDOIFFL;
	}

	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private const int ELDLCLBDKLE = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private readonly Dictionary<T, int> BMDNGCCIBDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private MJFOGBBFGGB[] HIHMAINIJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private int OHFHBKBBNAH;

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public int PKHGMEILNLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8C8DC0", Offset = "0x8C79C0", VA = "0x1808C8DC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8C8970", Offset = "0x8C7570", VA = "0x1808C8970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int DNBGNCFCKIN
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x379C8E0", Offset = "0x379B4E0", VA = "0x18379C8E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x41E3B90", Offset = "0x41E2790", VA = "0x1841E3B90")]
	public JDKFBEENOAB(int KPFLHEHNDFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x41E40B0", Offset = "0x41E2CB0", VA = "0x1841E40B0")]
	public JDKFBEENOAB(ADJFCAPJNNM[] KIGIHBOEDKM, bool JEMCOJMNMOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x41E2CE0", Offset = "0x41E18E0", VA = "0x1841E2CE0")]
	public int BGKOKNHJNCH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x41E3500", Offset = "0x41E2100", VA = "0x1841E3500")]
	private int GMPABNMHIEG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x41E34B0", Offset = "0x41E20B0", VA = "0x1841E34B0", Slot = "6")]
	protected virtual uint FLFHHCHPADJ(uint IGABCIKOEOA, T CABLCDOIFFL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x41E3990", Offset = "0x41E2590", VA = "0x1841E3990")]
	public bool HLEENLPHDBG(T CABLCDOIFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x41E3A70", Offset = "0x41E2670", VA = "0x1841E3A70")]
	public int KDPGOGJKFPF(T CABLCDOIFFL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x41E33A0", Offset = "0x41E1FA0", VA = "0x1841E33A0")]
	public T EENAOOMALPK(int MFJLAMOCOBC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x41E3000", Offset = "0x41E1C00", VA = "0x1841E3000")]
	public bool DPACCLIBHJD(T CABLCDOIFFL, bool ADMBNIKBFLA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x41E2DA0", Offset = "0x41E19A0", VA = "0x1841E2DA0")]
	public bool DPACCLIBHJD(T CABLCDOIFFL, int MFJLAMOCOBC, bool ADMBNIKBFLA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x41E3460", Offset = "0x41E2060", VA = "0x1841E3460")]
	private int FDMLFMNBFGI(int HAOCJMNINJC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x41E3AF0", Offset = "0x41E26F0", VA = "0x1841E3AF0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x41E3AF0", Offset = "0x41E26F0", VA = "0x1841E3AF0", Slot = "4")]
	private IEnumerator<ADJFCAPJNNM> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class GPDDNEDAGLO<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private readonly Stack<T> AKNBIKOODEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private readonly List<T> GHILPEAAPJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly int FEHKEAAAOCA;

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x3EF98B0", Offset = "0x3EF84B0", VA = "0x183EF98B0")]
	public static GPDDNEDAGLO<T> GGPLDLHLGNJ(int KPFLHEHNDFJ = 0, int FEHKEAAAOCA = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x3EF99A0", Offset = "0x3EF85A0", VA = "0x183EF99A0")]
	public static GPDDNEDAGLO<T> KLDBOBAMCBB(int KPFLHEHNDFJ = 0, int FEHKEAAAOCA = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x3EF9D80", Offset = "0x3EF8980", VA = "0x183EF9D80")]
	public GPDDNEDAGLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x3EF9DD0", Offset = "0x3EF89D0", VA = "0x183EF9DD0")]
	public GPDDNEDAGLO(int KPFLHEHNDFJ, int FEHKEAAAOCA = int.MaxValue, bool OBIBPMKGMHB = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x3EF9550", Offset = "0x3EF8150", VA = "0x183EF9550")]
	public T DGNCLAFGAIG()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x3EF9430", Offset = "0x3EF8030", VA = "0x183EF9430")]
	public void BIODNPDBBKO(T CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x3EF9C80", Offset = "0x3EF8880", VA = "0x183EF9C80")]
	private void NOCEANLMJOK(T CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x3EF9510", Offset = "0x3EF8110", VA = "0x183EF9510")]
	private void BKJONOFHJGD(T CABLCDOIFFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x3EF9720", Offset = "0x3EF8320", VA = "0x183EF9720", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x3EF9A90", Offset = "0x3EF8690", VA = "0x183EF9A90")]
	private void NEBFDOHOENJ(IEnumerable<T> ILAABJMNJPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class CHACNBIGNNF<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private Dictionary<int, T> MPMLAHPFKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private T DHMOCEKHKLI;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public virtual T FOOBNPMHOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x88ABA0", Offset = "0x8897A0", VA = "0x18088ABA0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x88ABB0", Offset = "0x8897B0", VA = "0x18088ABB0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x55D1910", Offset = "0x55D0510", VA = "0x1855D1910")]
	public bool FHJKMILGDEP(T CABLCDOIFFL, int LLJMNDBPFJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x3E1BE70", Offset = "0x3E1AA70", VA = "0x183E1BE70")]
	public bool FFMOGGPFHLA(int LLJMNDBPFJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x55D1430", Offset = "0x55D0030", VA = "0x1855D1430")]
	public T ELGLNCDFCLO(int IPFMPGHAPLM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x55D1A10", Offset = "0x55D0610", VA = "0x1855D1A10")]
	private bool OEJMNNPDFDJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x55D19B0", Offset = "0x55D05B0", VA = "0x1855D19B0")]
	public bool NNAAPMJPMIH(int LLJMNDBPFJI, [Out] T CABLCDOIFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x3E1E4E0", Offset = "0x3E1D0E0", VA = "0x183E1E4E0")]
	public CHACNBIGNNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class PLMNEFPAGLE<T>
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	protected struct DFGEDIOCCNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public T PPPKGAOABBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public int FEGEFLLGLNN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	protected readonly List<DFGEDIOCCNC> IAHIBFAGKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private T EBEGJDLADNK;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int DNBGNCFCKIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x379C8E0", Offset = "0x379B4E0", VA = "0x18379C8E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x48B6450", Offset = "0x48B5050", VA = "0x1848B6450")]
	public bool IFELPNGNEIG(T CABLCDOIFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x48B63A0", Offset = "0x48B4FA0", VA = "0x1848B63A0")]
	public void CMCAIIEBGOH(T CABLCDOIFFL, int LLJMNDBPFJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x48B5F50", Offset = "0x48B4B50", VA = "0x1848B5F50")]
	public bool CEFMELNJEMA(T CABLCDOIFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x48B5D80", Offset = "0x48B4980", VA = "0x1848B5D80")]
	public void ANKOMBFBDGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x48B5EB0", Offset = "0x48B4AB0", VA = "0x1848B5EB0")]
	public T BIKBLMLHGIB()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x48B69C0", Offset = "0x48B55C0", VA = "0x1848B69C0")]
	protected void MMCGPJDAFJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x48B6B40", Offset = "0x48B5740", VA = "0x1848B6B40")]
	public PLMNEFPAGLE()
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
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[GBPOFPPCAAP(KOFDDAAAPEO.Self, false, false, false)]
		[SerializeField]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x600021B")]
			[Cpp2IlInjected.Address(RVA = "0x6C13FF0", Offset = "0x6C12BF0", VA = "0x186C13FF0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x6C142C0", Offset = "0x6C12EC0", VA = "0x186C142C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x6C141D0", Offset = "0x6C12DD0", VA = "0x186C141D0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x6C13F40", Offset = "0x6C12B40", VA = "0x186C13F40")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x600021F")]
			[Cpp2IlInjected.Address(RVA = "0x6C14210", Offset = "0x6C12E10", VA = "0x186C14210")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x6C14120", Offset = "0x6C12D20", VA = "0x186C14120")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x6C13EC0", Offset = "0x6C12AC0", VA = "0x186C13EC0")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x4B322A0", Offset = "0x4B30EA0", VA = "0x184B322A0", Slot = "4")]
		public virtual T HCIENKLECKL()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class DNFCBDHLBBJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private Dictionary<byte, GOJPFFGHDMG> DDFHLJLMPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly GPDDNEDAGLO<GOJPFFGHDMG> MMMAPOCILNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private readonly bool MHJALAEPIIL;

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public GOJPFFGHDMG FOHMHJOIONP
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x888250", Offset = "0x886E50", VA = "0x180888250")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000225")]
		[Cpp2IlInjected.Address(RVA = "0x888270", Offset = "0x886E70", VA = "0x180888270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public Vector2 KEIGBMBGNOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0xEE8510", Offset = "0xEE7110", VA = "0x180EE8510")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x121C1D0", Offset = "0x121ADD0", VA = "0x18121C1D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	private Vector2 ADNPLFHAFCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0x1256DD0", Offset = "0x12559D0", VA = "0x181256DD0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public Vector2 LNIOMJPFHND
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(RVA = "0x6C10BD0", Offset = "0x6C0F7D0", VA = "0x186C10BD0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x88C4D0", Offset = "0x88B0D0", VA = "0x18088C4D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public int BPEFPKCLKDG
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x893E00", Offset = "0x892A00", VA = "0x180893E00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x893E10", Offset = "0x892A10", VA = "0x180893E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x6C11250", Offset = "0x6C0FE50", VA = "0x186C11250")]
	public DNFCBDHLBBJ(Bounds APLKGACKJBB, Vector2[] LCHFCDAKMFC, int DLFCGKOLHBC, byte HAOCJMNINJC, float FAOFOBMEKBE = 0f, [Optional] GPDDNEDAGLO<GOJPFFGHDMG> MMMAPOCILNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x6C10BF0", Offset = "0x6C0F7F0", VA = "0x186C10BF0")]
	public void IJIOADABIKD(Bounds APLKGACKJBB, Vector2[] LCHFCDAKMFC, int DLFCGKOLHBC, byte HAOCJMNINJC, float FAOFOBMEKBE = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x6C102A0", Offset = "0x6C0EEA0", VA = "0x186C102A0")]
	public GOJPFFGHDMG CDHLCMNIHHG(byte MFJLAMOCOBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x6C110A0", Offset = "0x6C0FCA0", VA = "0x186C110A0")]
	public void LBPHMKIDIIK(Vector3 GKJAMFFKDLE, float APADDJJLEBH, float BFLOHOAJBGF, List<byte> BEOLMLBJJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x6C11080", Offset = "0x6C0FC80", VA = "0x186C11080")]
	public void KJMGIPBBPJC(GOJPFFGHDMG.CJNDIGMOLKA MHJCAOEAMMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x6C11170", Offset = "0x6C0FD70", VA = "0x186C11170")]
	public static int LCIECHHJENL(Vector2[] LCHFCDAKMFC, int DLFCGKOLHBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x6C105E0", Offset = "0x6C0F1E0", VA = "0x186C105E0")]
	private GOJPFFGHDMG HFGBNPMLNHN(byte MFJLAMOCOBC, GOJPFFGHDMG.JBECLDJNOOA NNFGLICMLFM, GOJPFFGHDMG CDBGCEIGNJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x6C10810", Offset = "0x6C0F410", VA = "0x186C10810")]
	private void HGGAIKGGBAH(GOJPFFGHDMG CDBGCEIGNJC, Vector2[] LCHFCDAKMFC, int FAJEKFNLDIP, int COCKPOAJNOD, int APKMODOLAIH, int PGOPPKKFCGO, float FAOFOBMEKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(RVA = "0x6C10300", Offset = "0x6C0EF00", VA = "0x186C10300")]
	private void CIBNDNPBCLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(RVA = "0x6C10520", Offset = "0x6C0F120", VA = "0x186C10520", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(RVA = "0x6C10580", Offset = "0x6C0F180", VA = "0x186C10580", Slot = "1")]
	~DNFCBDHLBBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class GOJPFFGHDMG
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public enum JBECLDJNOOA
	{
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public enum CJNDIGMOLKA
	{
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public byte HJABBJLNKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public Vector3 EIGECMFNGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public Vector3 DMCOCMMDKIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public Vector3 EEFEJOBNHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public Vector3 DKCBCBKHMOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public JBECLDJNOOA APKLLFFBLPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public GOJPFFGHDMG GGAFGBKJIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public List<GOJPFFGHDMG> DAMLEBMIKND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public bool ENECOLDCKPA;

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(RVA = "0x6C122F0", Offset = "0x6C10EF0", VA = "0x186C122F0")]
	public GOJPFFGHDMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(RVA = "0x6C11EC0", Offset = "0x6C10AC0", VA = "0x186C11EC0")]
	public void KICAOPFBPDO(GOJPFFGHDMG MADODMHNENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(RVA = "0x88A140", Offset = "0x888D40", VA = "0x18088A140")]
	public void KJMGIPBBPJC(int JPGFNKHEHLD, CJNDIGMOLKA MHJCAOEAMMM, int POFGODPFIFA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(RVA = "0x6C12090", Offset = "0x6C10C90", VA = "0x186C12090")]
	public void LBPHMKIDIIK(List<byte> BEOLMLBJJBP, Vector3 GKJAMFFKDLE, float APADDJJLEBH, float BFLOHOAJBGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(RVA = "0x6C11E90", Offset = "0x6C10A90", VA = "0x186C11E90")]
	public bool GGHLFGEIAJO(Vector3 EJNKPMJJHKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(RVA = "0x6C11E60", Offset = "0x6C10A60", VA = "0x186C11E60")]
	public bool EJEEPOEOAJL(Vector3 EJNKPMJJHKH, float MIKEAGGBPAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x6C12000", Offset = "0x6C10C00", VA = "0x186C12000")]
	public void KMAKNPIEEHP()
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
		public struct DDAHFAAFNLI<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012C")]
			private readonly List<Component> APGPCFDNGCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012D")]
			private readonly bool CHOMIMMIIJK;

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x10BF1C0", Offset = "0x10BDDC0", VA = "0x1810BF1C0")]
			public DDAHFAAFNLI(List<Component> APGPCFDNGCA, bool CHOMIMMIIJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x5AC11D0", Offset = "0x5ABFDD0", VA = "0x185AC11D0")]
			public MFMCGHJACMA<T> NEGBLLIJCNA()
			{
				return default(MFMCGHJACMA<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x5AC1230", Offset = "0x5ABFE30", VA = "0x185AC1230", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0x5AC1230", Offset = "0x5ABFE30", VA = "0x185AC1230", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000077")]
		public struct MFMCGHJACMA<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012E")]
			private readonly List<Component> APGPCFDNGCA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400012F")]
			private readonly bool CHOMIMMIIJK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000130")]
			private int MFJLAMOCOBC;

			[Cpp2IlInjected.Token(Token = "0x1700006E")]
			public T FFEGLPIJFMI
			{
				[Cpp2IlInjected.Token(Token = "0x6000250")]
				[Cpp2IlInjected.Address(RVA = "0x4594B20", Offset = "0x4593720", VA = "0x184594B20", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700006F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000251")]
				[Cpp2IlInjected.Address(RVA = "0x4594AB0", Offset = "0x45936B0", VA = "0x184594AB0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0x4594AF0", Offset = "0x45936F0", VA = "0x184594AF0")]
			public MFMCGHJACMA(List<Component> APGPCFDNGCA, bool CHOMIMMIIJK)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000252")]
			[Cpp2IlInjected.Address(RVA = "0x45949F0", Offset = "0x45935F0", VA = "0x1845949F0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000253")]
			[Cpp2IlInjected.Address(RVA = "0x4594A00", Offset = "0x4593600", VA = "0x184594A00", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000254")]
			[Cpp2IlInjected.Address(RVA = "0x3AE6D20", Offset = "0x3AE5920", VA = "0x183AE6D20", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x6C15CB0", Offset = "0x6C148B0", VA = "0x186C15CB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x8957D0", Offset = "0x8943D0", VA = "0x1808957D0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x6C15760", Offset = "0x6C14360", VA = "0x186C15760")]
		private void KMAKNPIEEHP(GameObject INBNPDODNMN, bool KHODILEOPHB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x6C156D0", Offset = "0x6C142D0", VA = "0x186C156D0")]
		public static void KMAKNPIEEHP(GameObject INBNPDODNMN, ToolHierarchyCache FAJPBGGJLEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x6C155D0", Offset = "0x6C141D0", VA = "0x186C155D0")]
		public void CEFHOFLCENN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x3135BB0", Offset = "0x31347B0", VA = "0x183135BB0")]
		public void PHCJMPFNIHK<T>(Action<T> FNGNLBJEBKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x3135A50", Offset = "0x3134650", VA = "0x183135A50")]
		public T CDIMDGHJPMB<T>(bool CHOMIMMIIJK = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x3135AF0", Offset = "0x31346F0", VA = "0x183135AF0")]
		public DDAHFAAFNLI<T> MNAKBFHAFJD<T>(bool CHOMIMMIIJK = false) where T : class
		{
			return default(DDAHFAAFNLI<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x6C158D0", Offset = "0x6C144D0", VA = "0x186C158D0")]
		public List<Component> MIHEAAJILHP(Type FIFJJNIIAPF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x6C155E0", Offset = "0x6C141E0", VA = "0x186C155E0", Slot = "4")]
		public bool Equals(ToolHierarchyCache MBJABMPNEHF, ToolHierarchyCache MNMGCDILGBO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x6C15660", Offset = "0x6C14260", VA = "0x186C15660", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache PLAMADMDGIO)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public class LPDMJOKAPED<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private int KPFLHEHNDFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private int LOCOCJMPJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private List<T> LNIHEAGKKGE;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public int DNBGNCFCKIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x4018030", Offset = "0x4016C30", VA = "0x184018030")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public T JIBIMLHAGAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x43C7910", Offset = "0x43C6510", VA = "0x1843C7910")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public T POPDECHOOEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x43C7760", Offset = "0x43C6360", VA = "0x1843C7760")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public T GBLGGLHHHOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x43C7240", Offset = "0x43C5E40", VA = "0x1843C7240")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(RVA = "0x43C79E0", Offset = "0x43C65E0", VA = "0x1843C79E0")]
	public LPDMJOKAPED(int KPFLHEHNDFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(RVA = "0x43C7320", Offset = "0x43C5F20", VA = "0x1843C7320")]
	public void CMCAIIEBGOH(T BHLHNKOABBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(RVA = "0x43C7170", Offset = "0x43C5D70", VA = "0x1843C7170")]
	public void ANKOMBFBDGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x43C75E0", Offset = "0x43C61E0", VA = "0x1843C75E0")]
	public void IOBFMJKLIMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x43C72C0", Offset = "0x43C5EC0", VA = "0x1843C72C0")]
	public void BJCFCKMMCJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x43C75D0", Offset = "0x43C61D0", VA = "0x1843C75D0")]
	public void INCMDALBHFN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x43C76D0", Offset = "0x43C62D0", VA = "0x1843C76D0")]
	public List<T> JIADCFACHFM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public class OPNFBDLFKNK<T>
{
	[Cpp2IlInjected.Token(Token = "0x200007A")]
	private struct EIDACENBGDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public int FEGEFLLGLNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public T PPPKGAOABBC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private readonly Dictionary<object, EIDACENBGDM> MPMLAHPFKKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private readonly EqualityComparer<T> HFCIIJLJJLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private T DHMOCEKHKLI;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public virtual T FOOBNPMHOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000260")]
		[Cpp2IlInjected.Address(RVA = "0xA6A0D0", Offset = "0xA68CD0", VA = "0x180A6A0D0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000261")]
		[Cpp2IlInjected.Address(RVA = "0x47D86C0", Offset = "0x47D72C0", VA = "0x1847D86C0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public bool OBGEOLNFJJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000262")]
		[Cpp2IlInjected.Address(RVA = "0x47DCBF0", Offset = "0x47DB7F0", VA = "0x1847DCBF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public object OGLFOLJMAFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000263")]
		[Cpp2IlInjected.Address(RVA = "0x887B10", Offset = "0x886710", VA = "0x180887B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000264")]
		[Cpp2IlInjected.Address(RVA = "0x887AE0", Offset = "0x8866E0", VA = "0x180887AE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(RVA = "0x47D8960", Offset = "0x47D7560", VA = "0x1847D8960")]
	public bool FHJKMILGDEP(T CABLCDOIFFL, object DGGGDIFONNG, int LLJMNDBPFJI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(RVA = "0x47D87A0", Offset = "0x47D73A0", VA = "0x1847D87A0")]
	public bool FFMOGGPFHLA(object DGGGDIFONNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(RVA = "0x47D9760", Offset = "0x47D8360", VA = "0x1847D9760")]
	public bool NNAAPMJPMIH(object DGGGDIFONNG, [Out] T CABLCDOIFFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(RVA = "0x47D8740", Offset = "0x47D7340", VA = "0x1847D8740")]
	public void ANKOMBFBDGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(RVA = "0x47DBF60", Offset = "0x47DAB60", VA = "0x1847DBF60")]
	private bool OEJMNNPDFDJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(RVA = "0x47DCC50", Offset = "0x47DB850", VA = "0x1847DCC50")]
	public OPNFBDLFKNK()
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
