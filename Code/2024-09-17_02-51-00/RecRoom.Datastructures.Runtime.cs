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
		[Cpp2IlInjected.Address(RVA = "0x8C1980", Offset = "0x8C0380", VA = "0x1808C1980")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C279A0", Offset = "0x6C263A0", VA = "0x186C279A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C2AE0", Offset = "0x8C14E0", VA = "0x1808C2AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C2B20", Offset = "0x8C1520", VA = "0x1808C2B20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class PFEDOPIKGDD : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1852420", Offset = "0x1850E20", VA = "0x181852420")]
	public PFEDOPIKGDD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, AJJIDJJMECL, HOLEDMBJCDB, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x899030", Offset = "0x897A30", VA = "0x180899030", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x898FC0", Offset = "0x8979C0", VA = "0x180898FC0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x899040", Offset = "0x897A40", VA = "0x180899040", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9461F0", Offset = "0x944BF0", VA = "0x1809461F0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash DOAOBIHCNJF);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x9A74A0", Offset = "0x9A5EA0", VA = "0x1809A74A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C291C0", Offset = "0x6C27BC0", VA = "0x186C291C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6C29180", Offset = "0x6C27B80", VA = "0x186C29180")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6C29200", Offset = "0x6C27C00", VA = "0x186C29200")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6C293B0", Offset = "0x6C27DB0", VA = "0x186C293B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6C29320", Offset = "0x6C27D20", VA = "0x186C29320")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9C14D0", Offset = "0x9BFED0", VA = "0x1809C14D0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xB063A0", Offset = "0xB04DA0", VA = "0x180B063A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6C29140", Offset = "0x6C27B40", VA = "0x186C29140")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6C29290", Offset = "0x6C27C90", VA = "0x186C29290")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6C28D70", Offset = "0x6C27770", VA = "0x186C28D70")]
	public void CopyBounds(SavedExtents PLNBHPCFEOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6C29090", Offset = "0x6C27A90", VA = "0x186C29090")]
	public void SetLocalSpaceBounds(Bounds OHEEJLEICDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xDFE060", Offset = "0xDFCA60", VA = "0x180DFE060")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6C29080", Offset = "0x6C27A80", VA = "0x186C29080")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6C28570", Offset = "0x6C26F70", VA = "0x186C28570")]
	private void BODAAMGPBIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6C28E60", Offset = "0x6C27860", VA = "0x186C28E60")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6C28730", Offset = "0x6C27130", VA = "0x186C28730")]
	public static void CalculateLocalBoundsFor(GameObject MNKAGJEGJCF, [Out] Bounds OHEEJLEICDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6C28DA0", Offset = "0x6C277A0", VA = "0x186C28DA0")]
	private static void GIAOOGMLELI(Bounds MKGNFMMEFHC, Color DMIBFACOBBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6C290B0", Offset = "0x6C27AB0", VA = "0x186C290B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8961A0", Offset = "0x894BA0", VA = "0x1808961A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x899070", Offset = "0x897A70", VA = "0x180899070")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1237110", Offset = "0x1235B10", VA = "0x181237110")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4C197F0", Offset = "0x4C181F0", VA = "0x184C197F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "4")]
	public virtual void OGGGFGGPBOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
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
	[PFEDOPIKGDD]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4C19320", Offset = "0x4C17D20", VA = "0x184C19320", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4C17A00", Offset = "0x4C16400", VA = "0x184C17A00", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4C196E0", Offset = "0x4C180E0", VA = "0x184C196E0")]
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
	private sealed class GICHKNMPGDD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public GICHKNMPGDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3ED8810", Offset = "0x3ED7210", VA = "0x183ED8810")]
		internal int ONMPBEFDBMJ(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[PFEDOPIKGDD]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3A6A840", Offset = "0x3A69240", VA = "0x183A6A840", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3A6A8A0", Offset = "0x3A692A0", VA = "0x183A6A8A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3A6A710", Offset = "0x3A69110", VA = "0x183A6A710", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey LFOBGDLOPID]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3A6A7D0", Offset = "0x3A691D0", VA = "0x183A6A7D0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3A6A5B0", Offset = "0x3A68FB0", VA = "0x183A6A5B0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3A6A250", Offset = "0x3A68C50", VA = "0x183A6A250", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3A69610", Offset = "0x3A68010", VA = "0x183A69610", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3A69580", Offset = "0x3A67F80", VA = "0x183A69580", Slot = "14")]
	protected virtual string JDMEPJHACPG(TKeyVal ODPLKBJGFEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3A69470", Offset = "0x3A67E70", VA = "0x183A69470", Slot = "4")]
	public bool ContainsKey(TKey LFOBGDLOPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3A6A420", Offset = "0x3A68E20", VA = "0x183A6A420", Slot = "5")]
	public bool TryGetValue(TKey LFOBGDLOPID, [Out] TVal KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3A694D0", Offset = "0x3A67ED0", VA = "0x183A694D0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3A694D0", Offset = "0x3A67ED0", VA = "0x183A694D0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3A6A480", Offset = "0x3A68E80", VA = "0x183A6A480")]
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
		[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8961C0", Offset = "0x894BC0", VA = "0x1808961C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x899030", Offset = "0x897A30", VA = "0x180899030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E5C460", Offset = "0x3E5AE60", VA = "0x183E5C460")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	[PFEDOPIKGDD]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4C1AA50", Offset = "0x4C19450", VA = "0x184C1AA50", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4C19FD0", Offset = "0x4C189D0", VA = "0x184C19FD0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4C196E0", Offset = "0x4C180E0", VA = "0x184C196E0")]
	protected SerializedReferenceDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class HAIFFEDDPIN<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private class MLHDPHGDHGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public float LADJOJMEALC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T PGPGCBGPPOH;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public MLHDPHGDHGK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class OIMKDLABEDP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public OIMKDLABEDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x48FBAD0", Offset = "0x48FA4D0", VA = "0x1848FBAD0")]
		internal bool FLFJAKBHNJE(MLHDPHGDHGK sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly float HCLBNCNDONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly float PKEHBMNDFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private List<MLHDPHGDHGK> PLHLEOABGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private MOGMOHJBDLD<MLHDPHGDHGK> OFJOHBNJJLM;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int BCIDMJENBJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3F20BD0", Offset = "0x3F1F5D0", VA = "0x183F20BD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3F21440", Offset = "0x3F1FE40", VA = "0x183F21440")]
	public HAIFFEDDPIN(float EADCNJLKLHJ, float LBEJGKANMDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3F207B0", Offset = "0x3F1F1B0", VA = "0x183F207B0")]
	public bool GDJALHICHKP(float IMAGIDBPDMM, T KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3F20FE0", Offset = "0x3F1F9E0", VA = "0x183F20FE0")]
	public IEnumerable<T> KNKJJKLELNO(float IMAGIDBPDMM, [Optional] float? NFCFCPBBNII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3F21380", Offset = "0x3F1FD80", VA = "0x183F21380")]
	public void MPAAPCHGDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3F209A0", Offset = "0x3F1F3A0", VA = "0x183F209A0")]
	private void KDEOMMGOFFA(float IMAGIDBPDMM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class OKAIMGLEANI<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct JAMKBCGNFMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public T PGPGCBGPPOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public float HOLMEBECIKK;
	}

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static float LFOCOMICEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private List<T> DPPCCMDEONH;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private const int FFJBNNDCCDE = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private JAMKBCGNFMM[] DKEEEGEFALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int MHOIJKJCFFP;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float KILNADGPFDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xBE8A50", Offset = "0xBE7450", VA = "0x180BE8A50")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xC33B90", Offset = "0xC32590", VA = "0x180C33B90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x48FE2C0", Offset = "0x48FCCC0", VA = "0x1848FE2C0")]
	public OKAIMGLEANI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x48FE180", Offset = "0x48FCB80", VA = "0x1848FE180")]
	public OKAIMGLEANI(int BHEAFIOEIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x48FD5B0", Offset = "0x48FBFB0", VA = "0x1848FD5B0")]
	public void FABNFHGMHGJ(float IMAGIDBPDMM, T KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x48FD9F0", Offset = "0x48FC3F0", VA = "0x1848FD9F0")]
	public void MPAAPCHGDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x48FDED0", Offset = "0x48FC8D0", VA = "0x1848FDED0")]
	public bool OJAPCLFLOLI(float APGBJJBOFJM, float JGMKAHHJFKO, [Out] T KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x48FD0A0", Offset = "0x48FBAA0", VA = "0x1848FD0A0")]
	public bool DBBGJBBJJGG(float APGBJJBOFJM, float JGMKAHHJFKO, [Out] T KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x48FD870", Offset = "0x48FC270", VA = "0x1848FD870")]
	public void GEHLEKPPDKD(float APGBJJBOFJM, float JGMKAHHJFKO, List<T> DJOHOLIEOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x48FDBD0", Offset = "0x48FC5D0", VA = "0x1848FDBD0")]
	private int NEFGPBFAJBF(int LGMKIOHHJCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x48FD050", Offset = "0x48FBA50", VA = "0x1848FD050")]
	private void BFCCEFKIKOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T CIELCKPKCKB();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T CCGIGJECGOE(T KLABJGGMBGH, float KGPMLIHPPAA);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T BEMPEMEPJDB(T JDKMLCHPKLA, T AENKMLMFBAD);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T BPBADMEJAOI(T JDKMLCHPKLA, T AENKMLMFBAD);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class JMGKCBPFDEE : OKAIMGLEANI<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8A7B10", Offset = "0x8A6510", VA = "0x1808A7B10", Slot = "4")]
	protected override Vector3 CIELCKPKCKB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6C25E90", Offset = "0x6C24890", VA = "0x186C25E90", Slot = "5")]
	protected override Vector3 CCGIGJECGOE(Vector3 KLABJGGMBGH, float KGPMLIHPPAA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6C25DC0", Offset = "0x6C247C0", VA = "0x186C25DC0", Slot = "6")]
	protected override Vector3 BEMPEMEPJDB(Vector3 JDKMLCHPKLA, Vector3 AENKMLMFBAD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6C25E10", Offset = "0x6C24810", VA = "0x186C25E10", Slot = "7")]
	protected override Vector3 BPBADMEJAOI(Vector3 JDKMLCHPKLA, Vector3 AENKMLMFBAD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6C25ED0", Offset = "0x6C248D0", VA = "0x186C25ED0")]
	public JMGKCBPFDEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class AJAPLMJNIEN
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x34412B0", Offset = "0x343FCB0", VA = "0x1834412B0")]
	public static NLOJMGFBPKG<T1, T2> GMDNOGMNFLF<T1, T2>(T1 IJGAIHDGHFA, T2 CCGNFNGHILM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3441350", Offset = "0x343FD50", VA = "0x183441350")]
	public static NGMIMHAAAFC<T1, T2, T3> GMDNOGMNFLF<T1, T2, T3>(T1 IJGAIHDGHFA, T2 CCGNFNGHILM, T3 MDDCNMEHIHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x47C0C90", Offset = "0x47BF690", VA = "0x1847C0C90")]
	internal static int NHCFIELNEFP(int HMHOBPHFNBB, int FDFADNBBHNP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5FD4E40", Offset = "0x5FD3840", VA = "0x185FD4E40")]
	internal static int NHCFIELNEFP(int HMHOBPHFNBB, int FDFADNBBHNP, int NDOBJDHHLDI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class NLOJMGFBPKG<T1, T2> : IComparable<NLOJMGFBPKG<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly T1 NPODMCOOLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly T2 FGIFCBLJGIP;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x48048D0", Offset = "0x48032D0", VA = "0x1848048D0")]
	public NLOJMGFBPKG(T1 IJGAIHDGHFA, T2 CCGNFNGHILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4802AA0", Offset = "0x48014A0", VA = "0x184802AA0", Slot = "4")]
	public int CompareTo(NLOJMGFBPKG<T1, T2> PLNBHPCFEOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x48033B0", Offset = "0x4801DB0", VA = "0x1848033B0", Slot = "0")]
	public override bool Equals(object PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4803D10", Offset = "0x4802710", VA = "0x184803D10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4804050", Offset = "0x4802A50", VA = "0x184804050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class NGMIMHAAAFC<T1, T2, T3> : IComparable<NGMIMHAAAFC<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly T1 NPODMCOOLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly T2 FGIFCBLJGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly T3 GAAMDCKKONP;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x47EFDD0", Offset = "0x47EE7D0", VA = "0x1847EFDD0")]
	public NGMIMHAAAFC(T1 IJGAIHDGHFA, T2 CCGNFNGHILM, T3 MDDCNMEHIHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x47EF5C0", Offset = "0x47EDFC0", VA = "0x1847EF5C0", Slot = "4")]
	public int CompareTo(NGMIMHAAAFC<T1, T2, T3> PLNBHPCFEOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x47EF820", Offset = "0x47EE220", VA = "0x1847EF820", Slot = "0")]
	public override bool Equals(object PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x47EF9D0", Offset = "0x47EE3D0", VA = "0x1847EF9D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x47EFC10", Offset = "0x47EE610", VA = "0x1847EFC10", Slot = "3")]
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
	public T PGPGCBGPPOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x249F570", Offset = "0x249DF70", VA = "0x18249F570")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x249F560", Offset = "0x249DF60", VA = "0x18249F560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float JEEEJDKHNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9CB040", Offset = "0x9C9A40", VA = "0x1809CB040")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4E7C5A0", Offset = "0x4E7AFA0", VA = "0x184E7C5A0")]
	public T GCLKEIENIBN(float KGPMLIHPPAA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4E7CB90", Offset = "0x4E7B590", VA = "0x184E7CB90")]
	public T OJLDGOIKONN(float KGPMLIHPPAA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T EHHBHJFFOHF(T JDKMLCHPKLA, T AENKMLMFBAD, float KGPMLIHPPAA);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6C25CD0", Offset = "0x6C246D0", VA = "0x186C25CD0", Slot = "4")]
	protected override float EHHBHJFFOHF(float JDKMLCHPKLA, float AENKMLMFBAD, float KGPMLIHPPAA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6C25D10", Offset = "0x6C24710", VA = "0x186C25D10")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x10BF470", Offset = "0x10BDE70", VA = "0x1810BF470", Slot = "4")]
	protected override Vector3 EHHBHJFFOHF(Vector3 JDKMLCHPKLA, Vector3 AENKMLMFBAD, float KGPMLIHPPAA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6C2A180", Offset = "0x6C28B80", VA = "0x186C2A180")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6C25500", Offset = "0x6C23F00", VA = "0x186C25500", Slot = "4")]
	protected override Color EHHBHJFFOHF(Color JDKMLCHPKLA, Color AENKMLMFBAD, float KGPMLIHPPAA)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6C255C0", Offset = "0x6C23FC0", VA = "0x186C255C0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class FJLGHFMFEGD : KCEBOEMBPHC<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6C25C80", Offset = "0x6C24680", VA = "0x186C25C80")]
	public FJLGHFMFEGD(int HCAOLDLEJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6C25C10", Offset = "0x6C24610", VA = "0x186C25C10", Slot = "6")]
	protected override uint AHNPMMOMINN(uint DOAOBIHCNJF, string KLABJGGMBGH)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class HMFJOEDIKPH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly IDisposable DFEEMNKDOMA;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public HMFJOEDIKPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct KGMPEMBPBDF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> EPCCIEPHAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int BLICKPNHKPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int PODJOOJBFCN;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3A15430", Offset = "0x3A13E30", VA = "0x183A15430")]
	private KGMPEMBPBDF(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> AMMAMFCCPBP, int LNCKHBAPANI, int DKJFIAGOKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4426E20", Offset = "0x4425820", VA = "0x184426E20")]
	public static KGMPEMBPBDF<T> GGBAHLJJLHO()
	{
		return default(KGMPEMBPBDF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x44266C0", Offset = "0x44250C0", VA = "0x1844266C0")]
	public (int, int, Task<T>) FDNBJKIPHKJ(int GPABCNEPJFA, [Optional] CancellationToken IONNNJNKLMJ, double GMOGAEOJHDH = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4427100", Offset = "0x4425B00", VA = "0x184427100")]
	public void KPCJNDCJFAO(int GPABCNEPJFA, int DKJFIAGOKPG, [In] T POBDLJBBBCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class CIGPBIFCBPB
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6C25430", Offset = "0x6C23E30", VA = "0x186C25430")]
	public static KGMPEMBPBDF<BLGMJKLPHOM> GGBAHLJJLHO()
	{
		return default(KGMPEMBPBDF<BLGMJKLPHOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6C25480", Offset = "0x6C23E80", VA = "0x186C25480")]
	public static void KPCJNDCJFAO([In] this KGMPEMBPBDF<BLGMJKLPHOM> BJNJBGHPMEH, int GPABCNEPJFA, int DKJFIAGOKPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public class HHBOELANGID<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly Dictionary<TKey, TVal> IJLPFJGEGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<TVal, TKey> OGDHHOEEGLF;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int MNNLJFACLOK
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x377A360", Offset = "0x3778D60", VA = "0x18377A360", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool PBLDLBGBGPD
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public ICollection<TKey> IAJFPBHMOEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3F3B260", Offset = "0x3F39C60", VA = "0x183F3B260", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public ICollection<TVal> EMLPAKLEEGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3A3ED40", Offset = "0x3A3D740", VA = "0x183A3ED40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public TVal BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3F3B1F0", Offset = "0x3F39BF0", VA = "0x183F3B1F0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x3F3B300", Offset = "0x3F39D00", VA = "0x183F3B300", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public TKey BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x3F3A4B0", Offset = "0x3F38EB0", VA = "0x183F3A4B0")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3F3A510", Offset = "0x3F38F10", VA = "0x183F3A510", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3F3AF60", Offset = "0x3F39960", VA = "0x183F3AF60", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3F3A3B0", Offset = "0x3F38DB0", VA = "0x183F3A3B0", Slot = "9")]
	public void Add(TKey LFOBGDLOPID, TVal KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3F3A360", Offset = "0x3F38D60", VA = "0x183F3A360", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> IFNDNLEGMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3F3A5C0", Offset = "0x3F38FC0", VA = "0x183F3A5C0", Slot = "8")]
	public bool ContainsKey(TKey LFOBGDLOPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3F3A660", Offset = "0x3F39060", VA = "0x183F3A660", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> IFNDNLEGMFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3F3AEA0", Offset = "0x3F398A0", VA = "0x183F3AEA0", Slot = "10")]
	public bool Remove(TKey LFOBGDLOPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3F3AEE0", Offset = "0x3F398E0", VA = "0x183F3AEE0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> IFNDNLEGMFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3F3B000", Offset = "0x3F39A00", VA = "0x183F3B000", Slot = "11")]
	public bool TryGetValue(TKey LFOBGDLOPID, [Out] TVal KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3F3AB60", Offset = "0x3F39560", VA = "0x183F3AB60", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3F3A6A0", Offset = "0x3F390A0", VA = "0x183F3A6A0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] DKEEEGEFALD, int FFJKEOACOPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3F3AE40", Offset = "0x3F39840", VA = "0x183F3AE40")]
	public bool LAFFHOKCOBI(TVal LFOBGDLOPID, [Out] TKey KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3F3A810", Offset = "0x3F39210", VA = "0x183F3A810")]
	private void ELFBFCLFDHN(TKey LFOBGDLOPID, TVal AAJFAHDADNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3F3ACE0", Offset = "0x3F396E0", VA = "0x183F3ACE0")]
	private void JADJMPILMGP(TKey LFOBGDLOPID, TVal AAJFAHDADNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3F3A910", Offset = "0x3F39310", VA = "0x183F3A910")]
	private bool FIAAFAPNPCL(TKey LFOBGDLOPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3F3B060", Offset = "0x3F39A60", VA = "0x183F3B060")]
	public HHBOELANGID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class AOIDBMPNMPK<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private AOIDBMPNMPK<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x3AB3B90", Offset = "0x3AB2590", VA = "0x183AB3B90", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x3AC2AB0", Offset = "0x3AC14B0", VA = "0x183AC2AB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3AC2EF0", Offset = "0x3AC18F0", VA = "0x183AC2EF0")]
		public Enumerator(AOIDBMPNMPK<T> DJOHOLIEOKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3AC0BE0", Offset = "0x3ABF5E0", VA = "0x183AC0BE0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3AC1710", Offset = "0x3AC0110", VA = "0x183AC1710", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3ABFB70", Offset = "0x3ABE570", VA = "0x183ABFB70")]
		private void CIOHBBIMEJE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private T[] EBKMDGFIIBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int NBPJLJIBBHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private int GNOIGGGFMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private int CJEHFDAEGCE;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int MNNLJFACLOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3FD7D30", Offset = "0x3FD6730", VA = "0x183FD7D30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public T BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3FD7EF0", Offset = "0x3FD68F0", VA = "0x183FD7EF0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3FD8C90", Offset = "0x3FD7690", VA = "0x183FD8C90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3FD90A0", Offset = "0x3FD7AA0", VA = "0x183FD90A0")]
	public AOIDBMPNMPK(int HCAOLDLEJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3FD8130", Offset = "0x3FD6B30", VA = "0x183FD8130")]
	public void FABNFHGMHGJ(T KGPMLIHPPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3FD8E90", Offset = "0x3FD7890", VA = "0x183FD8E90")]
	public void MPAAPCHGDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3FD7D70", Offset = "0x3FD6770", VA = "0x183FD7D70")]
	public void BLECIAPFBDN(int FIGHABPEBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3FD8960", Offset = "0x3FD7360", VA = "0x183FD8960")]
	public void IKLPEOJFMNH(T[] DKEEEGEFALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3FD87A0", Offset = "0x3FD71A0", VA = "0x183FD87A0")]
	public Enumerator HNHGFOAAHAF()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3FD8EB0", Offset = "0x3FD78B0", VA = "0x183FD8EB0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3FD8EB0", Offset = "0x3FD78B0", VA = "0x183FD8EB0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3FD85E0", Offset = "0x3FD6FE0", VA = "0x183FD85E0")]
	private int GPBNJDFCDDK(int HGFDMIDEFHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3FD8C60", Offset = "0x3FD7660", VA = "0x183FD8C60")]
	private int JAKNADEKLNM(int HGFDMIDEFHN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class AHBIPPDKNFN<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate Task<TResult> HPDFEGEFJHD(TRequest NEKCFCOLDAN, CancellationToken IONNNJNKLMJ);

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public enum CEICJEBCCMM
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class HKCJMIABMLB
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private const float MGNKEBMMEJM = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TimeSpan IKECENCACFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int OFOFDKJFMHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public CEICJEBCCMM MJBHOLDCCHH;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public static readonly HKCJMIABMLB CLODJPHKAPB;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float LCLLCONIJJP
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x3F462B0", Offset = "0x3F44CB0", VA = "0x183F462B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan JLKKPLPICDC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3F46470", Offset = "0x3F44E70", VA = "0x183F46470")]
		public HKCJMIABMLB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private readonly struct DPJNGOGNCHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly TRequest NEKCFCOLDAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly CancellationToken IONNNJNKLMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly TaskCompletionSource<TResult> CFGILIGCGBD;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x5B5D9F0", Offset = "0x5B5C3F0", VA = "0x185B5D9F0")]
		public DPJNGOGNCHK(TRequest NEKCFCOLDAN, TaskCompletionSource<TResult> CFGILIGCGBD, CancellationToken IONNNJNKLMJ)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct HNPMPIJDHPH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AHBIPPDKNFN<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3F56070", Offset = "0x3F54A70", VA = "0x183F56070", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3F56950", Offset = "0x3F55350", VA = "0x183F56950", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct IBLBHACLOBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public AHBIPPDKNFN<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private DPJNGOGNCHK <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x401CD70", Offset = "0x401B770", VA = "0x18401CD70", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x401D3D0", Offset = "0x401BDD0", VA = "0x18401D3D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly CancellationTokenSource NKIDDDCGPCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<DPJNGOGNCHK> CNIFLIHNBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly HKCJMIABMLB CBBGEMNONGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly HPDFEGEFJHD DGEBNMNGJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Task JFKBJALHJLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private int DJOAKBGINEF;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3E848A0", Offset = "0x3E832A0", VA = "0x183E848A0")]
	public AHBIPPDKNFN(HPDFEGEFJHD DGEBNMNGJNC, [Optional] HKCJMIABMLB CBBGEMNONGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3E83F20", Offset = "0x3E82920", VA = "0x183E83F20")]
	public Task<TResult> PHFBFNLCIAL(TRequest NEKCFCOLDAN, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3E83440", Offset = "0x3E81E40", VA = "0x183E83440")]
	private void BAEPNCDLGCC(DPJNGOGNCHK GMNIOKFBLPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3E84700", Offset = "0x3E83100", VA = "0x183E84700")]
	[AsyncStateMachine(typeof(AHBIPPDKNFN<, >.HNPMPIJDHPH))]
	private Task POIOLJHCDOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3E83BF0", Offset = "0x3E825F0", VA = "0x183E83BF0")]
	private DPJNGOGNCHK DKPEELNAANO()
	{
		return default(DPJNGOGNCHK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3E83070", Offset = "0x3E81A70", VA = "0x183E83070")]
	[AsyncStateMachine(typeof(AHBIPPDKNFN<, >.IBLBHACLOBE))]
	private Task ADLDJNAMPPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3E82D40", Offset = "0x3E81740", VA = "0x183E82D40")]
	private void AADOCEEJEIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3E83EE0", Offset = "0x3E828E0", VA = "0x183E83EE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class KECDKEKFEIA<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly List<T> OLAPNOFMNPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private HashSet<T> LECDLAFDCPH;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int MNNLJFACLOK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x377A360", Offset = "0x3778D60", VA = "0x18377A360", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool PBLDLBGBGPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8E0E40", Offset = "0x8DF840", VA = "0x1808E0E40", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2B02350", Offset = "0x2B00D50", VA = "0x182B02350", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x44175C0", Offset = "0x4415FC0", VA = "0x1844175C0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3E2A010", Offset = "0x3E28A10", VA = "0x183E2A010", Slot = "11")]
	public void Add(T IFNDNLEGMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4416E10", Offset = "0x4415810", VA = "0x184416E10")]
	public bool KEADIHLHCFE(T IFNDNLEGMFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x44173C0", Offset = "0x4415DC0", VA = "0x1844173C0", Slot = "15")]
	public bool Remove(T IFNDNLEGMFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4416A80", Offset = "0x4415480", VA = "0x184416A80", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3E407C0", Offset = "0x3E3F1C0", VA = "0x183E407C0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4416910", Offset = "0x4415310", VA = "0x184416910", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x44169C0", Offset = "0x44153C0", VA = "0x1844169C0", Slot = "13")]
	public bool Contains(T IFNDNLEGMFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4416A20", Offset = "0x4415420", VA = "0x184416A20", Slot = "14")]
	public void CopyTo(T[] DKEEEGEFALD, int FFJKEOACOPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4416B10", Offset = "0x4415510", VA = "0x184416B10", Slot = "6")]
	public int IndexOf(T IFNDNLEGMFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4416B70", Offset = "0x4415570", VA = "0x184416B70", Slot = "7")]
	public void Insert(int HGFDMIDEFHN, T IFNDNLEGMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4417190", Offset = "0x4415B90", VA = "0x184417190", Slot = "8")]
	public void RemoveAt(int HGFDMIDEFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4417490", Offset = "0x4415E90", VA = "0x184417490")]
	public KECDKEKFEIA()
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
			[Cpp2IlInjected.Address(RVA = "0x234A1C0", Offset = "0x2348BC0", VA = "0x18234A1C0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6C29750", Offset = "0x6C28150", VA = "0x186C29750")]
		public SerializedGuid([In] Guid GDCMEHKEAMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6C29620", Offset = "0x6C28020", VA = "0x186C29620")]
		public static SerializedGuid NIHICLBFHCK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6C295B0", Offset = "0x6C27FB0", VA = "0x186C295B0")]
		public static SerializedGuid HPJNHCHFGPO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6C29540", Offset = "0x6C27F40", VA = "0x186C29540")]
		public bool FKPHAIMPOJM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6C29720", Offset = "0x6C28120", VA = "0x186C29720", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6C296A0", Offset = "0x6C280A0", VA = "0x186C296A0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6C29470", Offset = "0x6C27E70", VA = "0x186C29470", Slot = "7")]
		public bool Equals(SerializedGuid PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6C294B0", Offset = "0x6C27EB0", VA = "0x186C294B0", Slot = "0")]
		public override bool Equals(object GHMNBJIOGAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6C295A0", Offset = "0x6C27FA0", VA = "0x186C295A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6C29440", Offset = "0x6C27E40", VA = "0x186C29440", Slot = "6")]
		public int CompareTo(SerializedGuid PLNBHPCFEOK)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class NOAACMFHJIJ : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly Type PDGKENBLFML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly string CCAPCABANDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly bool KBBFJHBKLAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly bool PEABGAONDIC;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6C27930", Offset = "0x6C26330", VA = "0x186C27930")]
	public NOAACMFHJIJ(Type APKMKPFKIED, string KHABMDPCFLJ, bool BNEPEFANJCF = false, bool MOJJKMMJFFE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class APPPBJLIGLH<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public readonly struct KKFNDFEJKGA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly long IILEEIMAJLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly long BDKEMEBAINC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly int JBCEGJEOPCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly int KOFEANFMMDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public readonly bool FNKAPHIKFPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly string FEOHFNPGOIM;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x443CA20", Offset = "0x443B420", VA = "0x18443CA20")]
		public KKFNDFEJKGA(long IILEEIMAJLF, int JBCEGJEOPCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x443CA90", Offset = "0x443B490", VA = "0x18443CA90")]
		public KKFNDFEJKGA(long IILEEIMAJLF, long BDKEMEBAINC, int JBCEGJEOPCE, int KOFEANFMMDD, bool FNKAPHIKFPN, string FEOHFNPGOIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x443C930", Offset = "0x443B330", VA = "0x18443C930")]
		public int HHPNFBLIGGI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x443C910", Offset = "0x443B310", VA = "0x18443C910")]
		public int GGDKJCEJALN(int HLGIIIELNEG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x443C8B0", Offset = "0x443B2B0", VA = "0x18443C8B0")]
		public double CDBHAPCELFI()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x443C980", Offset = "0x443B380", VA = "0x18443C980")]
		public KKFNDFEJKGA PICHBOPLIFN(long BDKEMEBAINC, int KOFEANFMMDD)
		{
			return default(KKFNDFEJKGA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class LANPOEPHMID : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private struct KDMEHFJKFKP<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public LANPOEPHMID <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public Func<LANPOEPHMID, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private LANPOEPHMID <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x4415D10", Offset = "0x4414710", VA = "0x184415D10", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x40B0860", Offset = "0x40AF260", VA = "0x1840B0860", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public readonly TKey PJJDBLNOLBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly APPPBJLIGLH<TKey> LOIGOPGNFFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public readonly CMICIECANPG FPPDOFKLJHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private List<LANPOEPHMID> PLBBJIAHOOO;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string DIJLLMJOIEJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x4444100", Offset = "0x4442B00", VA = "0x184444100")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IEnumerable<LANPOEPHMID> FGHOHFEKFPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x44BA6E0", Offset = "0x44B90E0", VA = "0x1844BA6E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public KKFNDFEJKGA EGPKDPLODJE
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x44BA980", Offset = "0x44B9380", VA = "0x1844BA980")]
			[CompilerGenerated]
			get
			{
				return default(KKFNDFEJKGA);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x44BA9A0", Offset = "0x44B93A0", VA = "0x1844BA9A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x44BA9D0", Offset = "0x44B93D0", VA = "0x1844BA9D0")]
		internal LANPOEPHMID(APPPBJLIGLH<TKey> LOIGOPGNFFM, TKey LFOBGDLOPID, CMICIECANPG FPPDOFKLJHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x44BA520", Offset = "0x44B8F20", VA = "0x1844BA520")]
		public LANPOEPHMID CGCNNCLCEDB(TKey LFOBGDLOPID, [Optional] CMICIECANPG? FLFKFIHJAOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2D70910", Offset = "0x2D6F310", VA = "0x182D70910")]
		[AsyncStateMachine(typeof(KDMEHFJKFKP<>))]
		public Task<T> DDPCJPMECIM<T>(TKey LFOBGDLOPID, Func<LANPOEPHMID, Task<T>> OADEFMMDNAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x44BA720", Offset = "0x44B9120", VA = "0x1844BA720", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class AFOAHFMLFNE : IEnumerable<(TKey, List<TKey>, KKFNDFEJKGA)>, IEnumerable, IEnumerator<(TKey, List<TKey>, KKFNDFEJKGA)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private (TKey key, List<TKey> path, KKFNDFEJKGA timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public APPPBJLIGLH<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private IEnumerator<(TKey key, List<TKey> path, KKFNDFEJKGA timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, KKFNDFEJKGA) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x234CC60", Offset = "0x234B660", VA = "0x18234CC60", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, KKFNDFEJKGA));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x3E7C8D0", Offset = "0x3E7B2D0", VA = "0x183E7C8D0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x234CD50", Offset = "0x234B750", VA = "0x18234CD50")]
		[DebuggerHidden]
		public AFOAHFMLFNE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3C49710", Offset = "0x3C48110", VA = "0x183C49710", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3E7C440", Offset = "0x3E7AE40", VA = "0x183E7C440", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3E7C3F0", Offset = "0x3E7ADF0", VA = "0x183E7C3F0")]
		private void LFOMCLLDDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3E7C880", Offset = "0x3E7B280", VA = "0x183E7C880", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3E7C7A0", Offset = "0x3E7B1A0", VA = "0x183E7C7A0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, KKFNDFEJKGA)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3C50EC0", Offset = "0x3C4F8C0", VA = "0x183C50EC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class PEKHLELNMCF : IEnumerable<(TKey, List<TKey>, KKFNDFEJKGA)>, IEnumerable, IEnumerator<(TKey, List<TKey>, KKFNDFEJKGA)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private (TKey key, List<TKey> path, KKFNDFEJKGA timerEntry) <>2__current;

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
		private LANPOEPHMID timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public LANPOEPHMID <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public APPPBJLIGLH<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private IEnumerator<LANPOEPHMID> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private IEnumerator<(TKey key, List<TKey> path, KKFNDFEJKGA timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private (TKey, List<TKey>, KKFNDFEJKGA) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x234CC60", Offset = "0x234B660", VA = "0x18234CC60", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, KKFNDFEJKGA));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x49EA2C0", Offset = "0x49E8CC0", VA = "0x1849EA2C0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x234CD50", Offset = "0x234B750", VA = "0x18234CD50")]
		[DebuggerHidden]
		public PEKHLELNMCF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x49EA320", Offset = "0x49E8D20", VA = "0x1849EA320", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x49E9940", Offset = "0x49E8340", VA = "0x1849E9940", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x49E98E0", Offset = "0x49E82E0", VA = "0x1849E98E0")]
		private void LFOMCLLDDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x49E9880", Offset = "0x49E8280", VA = "0x1849E9880")]
		private void IOFDBJCEJOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x49EA270", Offset = "0x49E8C70", VA = "0x1849EA270", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x49EA130", Offset = "0x49E8B30", VA = "0x1849EA130", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, KKFNDFEJKGA)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x49EA230", Offset = "0x49E8C30", VA = "0x1849EA230", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly Action<TKey, KKFNDFEJKGA, CMICIECANPG> MMEAKLLGGBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Action<TKey, KKFNDFEJKGA, CMICIECANPG> LGNFPADIELM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Action<APPPBJLIGLH<TKey>, CMICIECANPG> FHNGPEFKDCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly CMICIECANPG FPPDOFKLJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly LANPOEPHMID KMINNFCENMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private bool HHCLANPDDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int NIPKJJHAJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Stopwatch GNMHDDIJNJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly int IAOCNOBCGEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private string OJKGHCPPCHN;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public LANPOEPHMID FHCAMDGKCDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8999A0", Offset = "0x8983A0", VA = "0x1808999A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[NotNull]
	public string DIJLLMJOIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8988B0", Offset = "0x8972B0", VA = "0x1808988B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x410BCD0", Offset = "0x410A6D0", VA = "0x18410BCD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x410BED0", Offset = "0x410A8D0", VA = "0x18410BED0")]
	public APPPBJLIGLH(TKey PEKHBFGPIMB, CMICIECANPG FPPDOFKLJHI, [Optional] int? JBCEGJEOPCE, [Optional][CanBeNull] Stopwatch GNMHDDIJNJL, [Optional] Action<TKey, KKFNDFEJKGA, CMICIECANPG> MMEAKLLGGBA, [Optional] Action<TKey, KKFNDFEJKGA, CMICIECANPG> LGNFPADIELM, [Optional] Action<APPPBJLIGLH<TKey>, CMICIECANPG> FHNGPEFKDCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x410BB70", Offset = "0x410A570", VA = "0x18410BB70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x410BE20", Offset = "0x410A820", VA = "0x18410BE20")]
	[IteratorStateMachine(typeof(APPPBJLIGLH<>.AFOAHFMLFNE))]
	public IEnumerable<(TKey, List<TKey>, KKFNDFEJKGA)> OKIIAADJKFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x410BD30", Offset = "0x410A730", VA = "0x18410BD30")]
	[IteratorStateMachine(typeof(APPPBJLIGLH<>.PEKHLELNMCF))]
	private IEnumerable<(TKey, List<TKey>, KKFNDFEJKGA)> OKIIAADJKFG(List<TKey> BICLBBDNKCN, LANPOEPHMID FLLPMEOKLAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x410BC50", Offset = "0x410A650", VA = "0x18410BC50")]
	private (long, int) LAIHDJJDNCL()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public abstract class JAAOIKLPKFN<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut FDHJHJEEKPL(APPPBJLIGLH<TKey> LOIGOPGNFFM);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	protected JAAOIKLPKFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public abstract class LNEIOJJLGJB<TKey> : JAAOIKLPKFN<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate string JFDIMHEGICI(TKey LFOBGDLOPID);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x44E6900", Offset = "0x44E5300", VA = "0x1844E6900")]
	private static string BPCDFCLLONM(TKey LFOBGDLOPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x44E6940", Offset = "0x44E5340", VA = "0x1844E6940", Slot = "4")]
	public override string FDHJHJEEKPL(APPPBJLIGLH<TKey> LOIGOPGNFFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x44E6A30", Offset = "0x44E5430", VA = "0x1844E6A30")]
	public string FDHJHJEEKPL(APPPBJLIGLH<TKey> LOIGOPGNFFM, [NotNull] JFDIMHEGICI GBBOJDEPMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string LGAMHHKIGLE(APPPBJLIGLH<TKey> LOIGOPGNFFM, [NotNull] JFDIMHEGICI GBBOJDEPMEE);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3A5B9B0", Offset = "0x3A5A3B0", VA = "0x183A5B9B0")]
	protected LNEIOJJLGJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class HNLCIMFLOIN<TKey> : JAAOIKLPKFN<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate string OEBBOIDHGAD(TKey LFOBGDLOPID);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly string DJKCIEHKENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly double PGDLOGJOJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly bool JOKOEEGCMOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly int CDGDBILAFCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly ISet<string> OHDPMLCOPOF;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3F54E70", Offset = "0x3F53870", VA = "0x183F54E70")]
	private static string BPCDFCLLONM(TKey LFOBGDLOPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3F55AB0", Offset = "0x3F544B0", VA = "0x183F55AB0")]
	public HNLCIMFLOIN(string DJKCIEHKENM = "F2", double PGDLOGJOJCF = double.MaxValue, bool JOKOEEGCMOL = false, int CDGDBILAFCH = int.MaxValue, [Optional] ISet<string> OHDPMLCOPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3F54F90", Offset = "0x3F53990", VA = "0x183F54F90", Slot = "4")]
	public override Dictionary<string, string> FDHJHJEEKPL(APPPBJLIGLH<TKey> LOIGOPGNFFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3F54EB0", Offset = "0x3F538B0", VA = "0x183F54EB0")]
	private bool ELHFHLLOCJI(string GBDCKEINLDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3F55080", Offset = "0x3F53A80", VA = "0x183F55080")]
	public Dictionary<string, string> FDHJHJEEKPL(APPPBJLIGLH<TKey> LOIGOPGNFFM, OEBBOIDHGAD GBBOJDEPMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3F556D0", Offset = "0x3F540D0", VA = "0x183F556D0")]
	private string OHKMLHNKGBG(StringBuilder DOPMAKHHIHE, List<TKey> ENKCPDLGEFM, OEBBOIDHGAD GBBOJDEPMEE, bool NHHBBPCBFFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3F55950", Offset = "0x3F54350", VA = "0x183F55950")]
	private static void PEGEGIKJJCP(StringBuilder AIOALODPPIH, string CCGEOMAGPED, bool MLAEHNFIJAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class ADEDJGCBPJD<TKey> : LNEIOJJLGJB<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct KJIEOHOCIFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public JFDIMHEGICI keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static ADEDJGCBPJD<TKey> DFEEMNKDOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly string[] MICBGONIPLO;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x3E77E00", Offset = "0x3E76800", VA = "0x183E77E00")]
	private ADEDJGCBPJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3E76E70", Offset = "0x3E75870", VA = "0x183E76E70", Slot = "5")]
	protected override string LGAMHHKIGLE(APPPBJLIGLH<TKey> LOIGOPGNFFM, JFDIMHEGICI GBBOJDEPMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3E76D60", Offset = "0x3E75760", VA = "0x183E76D60")]
	[CompilerGenerated]
	internal static string EIOKMPCOBGJ(string LNAEBAJOFPM, TKey LFOBGDLOPID, KJIEOHOCIFE P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class PAGPABCOPIF : APPPBJLIGLH<string>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class NDBIEDMIIFK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Action<PAGPABCOPIF, CMICIECANPG> callback;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public NDBIEDMIIFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6C278A0", Offset = "0x6C262A0", VA = "0x186C278A0")]
		internal void FGPCFINPCOE(APPPBJLIGLH<string> timer, CMICIECANPG log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6C27EF0", Offset = "0x6C268F0", VA = "0x186C27EF0")]
	public PAGPABCOPIF(CMICIECANPG FPPDOFKLJHI, [Optional] string FOKBPMBLGEK, [Optional] int? JBCEGJEOPCE, [Optional] Stopwatch GNMHDDIJNJL, [Optional] Action<string, KKFNDFEJKGA, CMICIECANPG> MMEAKLLGGBA, [Optional] Action<string, KKFNDFEJKGA, CMICIECANPG> LGNFPADIELM, [Optional] Action<PAGPABCOPIF, CMICIECANPG> FHNGPEFKDCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6C27E30", Offset = "0x6C26830", VA = "0x186C27E30")]
	private static Action<APPPBJLIGLH<string>, CMICIECANPG> FJLGNDIHKBG(Action<PAGPABCOPIF, CMICIECANPG> JMKAJHCEDCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public abstract class ELPELOHONJN
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private class AEJMNMHHGEB : ELPELOHONJN
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static ELPELOHONJN DFEEMNKDOMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x6C24140", Offset = "0x6C22B40", VA = "0x186C24140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override float KPFLMKGJHIL
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0xBF2490", Offset = "0xBF0E90", VA = "0x180BF2490", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6C24230", Offset = "0x6C22C30", VA = "0x186C24230")]
		public AEJMNMHHGEB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static ELPELOHONJN LIDFJLHMJAG;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static ELPELOHONJN CLODJPHKAPB
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6C25AB0", Offset = "0x6C244B0", VA = "0x186C25AB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public abstract float KPFLMKGJHIL
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	protected ELPELOHONJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface FCFAMILBOPJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool LEALCMGAHLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface POLPOFEBNLM<T> : FCFAMILBOPJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	[NotNull]
	Task<T> DLODDOEOAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	[NotNull]
	JAGIEECCCMP<T> BFMCIAAECGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class LBPIBCDKKCA
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2E4D110", Offset = "0x2E4BB10", VA = "0x182E4D110")]
	public static POLPOFEBNLM<TResource> KMPOIPKJJCD<TResource, TId>(this BDGMGOKIHEA<TId, TResource> DNNINLMOCPD, TId MCAKFNPAKIL, [Optional] Func<TId, CancellationToken, Task<TResource>>? ACCCKCBDAHL) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class DNLEPHKHIOL
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private sealed class LPEHNBLMJBH<T> : IGOJEPKBAMD<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override Task<T?> DLODDOEOAOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override JAGIEECCCMP<T?> BFMCIAAECGF
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x898FC0", Offset = "0x8979C0", VA = "0x180898FC0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x454A7B0", Offset = "0x45491B0", VA = "0x18454A7B0")]
		public LPEHNBLMJBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "10")]
		protected override void DNDPHLKJOEI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private sealed class AIMHNLBGKGA<T> : IGOJEPKBAMD<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly T GBANAKCBABJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly Action<T>? EHAOOGOPJFK;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override Task<T> DLODDOEOAOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x8999F0", Offset = "0x8983F0", VA = "0x1808999F0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override JAGIEECCCMP<T> BFMCIAAECGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x899AA0", Offset = "0x8984A0", VA = "0x180899AA0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x3E88250", Offset = "0x3E86C50", VA = "0x183E88250")]
		public AIMHNLBGKGA(T GOEOMDMENPE, Action<T>? OMALCONAAEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x3E881F0", Offset = "0x3E86BF0", VA = "0x183E881F0", Slot = "10")]
		protected override void DNDPHLKJOEI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private sealed class NFAGLMPGONH<T> : IGOJEPKBAMD<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override Task<T> DLODDOEOAOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override JAGIEECCCMP<T> BFMCIAAECGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x898FC0", Offset = "0x8979C0", VA = "0x180898FC0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x47DEB00", Offset = "0x47DD500", VA = "0x1847DEB00")]
		public NFAGLMPGONH(Exception FKDHFMCKMKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "10")]
		protected override void DNDPHLKJOEI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private sealed class MDABOPGCMOH<T> : IGOJEPKBAMD<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct ICLPEPCIHAK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public Task<POLPOFEBNLM<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private TaskAwaiter<POLPOFEBNLM<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x401F040", Offset = "0x401DA40", VA = "0x18401F040", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x401FAA0", Offset = "0x401E4A0", VA = "0x18401FAA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private struct BCBOCIMFKPM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public Task<POLPOFEBNLM<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private TaskAwaiter<POLPOFEBNLM<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x5102280", Offset = "0x5100C80", VA = "0x185102280", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x5102760", Offset = "0x5101160", VA = "0x185102760", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly Task<POLPOFEBNLM<T>> NLCCIDHLBEO;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override Task<T> DLODDOEOAOJ
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x898FC0", Offset = "0x8979C0", VA = "0x180898FC0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override JAGIEECCCMP<T> BFMCIAAECGF
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x899AF0", Offset = "0x8984F0", VA = "0x180899AF0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x4762380", Offset = "0x4760D80", VA = "0x184762380")]
		public MDABOPGCMOH(Task<POLPOFEBNLM<T>> KECDGIGMBNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x4761F60", Offset = "0x4760960", VA = "0x184761F60", Slot = "10")]
		protected override void DNDPHLKJOEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x4762080", Offset = "0x4760A80", VA = "0x184762080")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(MDABOPGCMOH<>.ICLPEPCIHAK))]
		internal static Task<T> IBBMBJAJIJJ(Task<POLPOFEBNLM<T>> KECDGIGMBNG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x4761D80", Offset = "0x4760780", VA = "0x184761D80")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(MDABOPGCMOH<>.BCBOCIMFKPM))]
		internal static Task CKFMLPJFLCC(Task<POLPOFEBNLM<T>> KECDGIGMBNG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class OJKCJCMEKEL<TIn, TOut> : IGOJEPKBAMD<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct GKKLMIBOIOH : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x3EE1E40", Offset = "0x3EE0840", VA = "0x183EE1E40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x3EE2500", Offset = "0x3EE0F00", VA = "0x183EE2500", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly POLPOFEBNLM<TIn> JIEPAKFPNMN;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<TOut> DLODDOEOAOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x898FC0", Offset = "0x8979C0", VA = "0x180898FC0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override JAGIEECCCMP<TOut> BFMCIAAECGF
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x899AF0", Offset = "0x8984F0", VA = "0x180899AF0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x48FCC40", Offset = "0x48FB640", VA = "0x1848FCC40")]
		public OJKCJCMEKEL(POLPOFEBNLM<TIn> KNACICKDHCD, Func<TIn, TOut> FECIBPEMOEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x48FC880", Offset = "0x48FB280", VA = "0x1848FC880", Slot = "10")]
		protected override void DNDPHLKJOEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x48FCAB0", Offset = "0x48FB4B0", VA = "0x1848FCAB0")]
		[AsyncStateMachine(typeof(OJKCJCMEKEL<, >.GKKLMIBOIOH))]
		[CompilerGenerated]
		internal static Task<TOut> OEHHEHBHEMC(Task<TIn> DDFCFEFDKMO, Func<TIn, TOut> FECIBPEMOEG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2BD4E10", Offset = "0x2BD3810", VA = "0x182BD4E10")]
	public static POLPOFEBNLM<T> PGEMABEMKPO<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x2BD4CC0", Offset = "0x2BD36C0", VA = "0x182BD4CC0")]
	public static POLPOFEBNLM<T> EOJAFDGBAKJ<T>(T POBDLJBBBCI, [Optional] Action<T>? OMALCONAAEJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2ACDA20", Offset = "0x2ACC420", VA = "0x182ACDA20")]
	public static POLPOFEBNLM<T> JJGEEGFFNOO<T>(Exception FKDHFMCKMKA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x2ACDA20", Offset = "0x2ACC420", VA = "0x182ACDA20")]
	public static POLPOFEBNLM<T> GGEBIPHJJNE<T>(Task<POLPOFEBNLM<T>> KECDGIGMBNG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2BD4D70", Offset = "0x2BD3770", VA = "0x182BD4D70")]
	public static POLPOFEBNLM<TOut> MJIIFCFMCAF<TOut, TIn>(POLPOFEBNLM<TIn> GPPOCIDKPII, Func<TIn, TOut> FECIBPEMOEG) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public abstract class IGOJEPKBAMD<T> : POLPOFEBNLM<T>, FCFAMILBOPJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly string ELFGMDPFECJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly OGMGECKBGAC KIFHCDLBOIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private bool HHCLANPDDNK;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool LEALCMGAHLN
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xDDDD60", Offset = "0xDDC760", VA = "0x180DDDD60", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public abstract Task<T> DLODDOEOAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public abstract JAGIEECCCMP<T> BFMCIAAECGF
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x4089250", Offset = "0x4087C50", VA = "0x184089250")]
	public IGOJEPKBAMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x4088E20", Offset = "0x4087820", VA = "0x184088E20", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void DNDPHLKJOEI();
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public abstract class HPIKJDJNNFG<TTask, T> : IGOJEPKBAMD<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class JBNOHKNIPGE
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
			public JBNOHKNIPGE <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x3767A80", Offset = "0x3766480", VA = "0x183767A80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x3767FF0", Offset = "0x37669F0", VA = "0x183767FF0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public HPIKJDJNNFG<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public JBNOHKNIPGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x4267700", Offset = "0x4266100", VA = "0x184267700")]
		[AsyncStateMachine(typeof(HPIKJDJNNFG<, >.JBNOHKNIPGE.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> ECGLPLEJPPN(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly Task<T> KECDGIGMBNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	protected readonly CancellationTokenSource ADHBHFEGLBD;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public override Task<T> DLODDOEOAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public override JAGIEECCCMP<T> BFMCIAAECGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x898FC0", Offset = "0x8979C0", VA = "0x180898FC0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x3F5B7F0", Offset = "0x3F5A1F0", VA = "0x183F5B7F0")]
	protected HPIKJDJNNFG(TTask KECDGIGMBNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3F5B7A0", Offset = "0x3F5A1A0", VA = "0x183F5B7A0", Slot = "10")]
	protected override void DNDPHLKJOEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T MNEGIKDGNGL(TTask NMDMLCAOIKH);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void OCFKJOBKHJN();
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class JIKOCDGFHBC<T> : IGOJEPKBAMD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly EMDFPNDLNED<Task<T>> ONEIHGGBHND;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public override Task<T> DLODDOEOAOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x429E4F0", Offset = "0x429CEF0", VA = "0x18429E4F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public override JAGIEECCCMP<T> BFMCIAAECGF
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x898FC0", Offset = "0x8979C0", VA = "0x180898FC0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x429E550", Offset = "0x429CF50", VA = "0x18429E550")]
	public JIKOCDGFHBC(EMDFPNDLNED<Task<T>> MBNJBFDFLLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x429E4D0", Offset = "0x429CED0", VA = "0x18429E4D0", Slot = "10")]
	protected override void DNDPHLKJOEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class LHDAKLKJHMA
{
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static readonly HashAlgorithmName MMFOPLJGJND;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly ThreadLocal<IncrementalHash> AAIEHGFIOHM;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6C27650", Offset = "0x6C26050", VA = "0x186C27650")]
	public static int MAJJILKDDFK(this AJJIDJJMECL NNNIELGKJFB, IncrementalHash DOAOBIHCNJF, byte[] NILJPNJFOGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6C275F0", Offset = "0x6C25FF0", VA = "0x186C275F0")]
	public static bool LLJMKODPGIE([CanBeNull] this AJJIDJJMECL NNNIELGKJFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6C272E0", Offset = "0x6C25CE0", VA = "0x186C272E0")]
	public static bool LLJMKODPGIE([CanBeNull] this AJJIDJJMECL NNNIELGKJFB, [Out] string ENDMINEHNJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6C26FB0", Offset = "0x6C259B0", VA = "0x186C26FB0")]
	public static bool LLJMKODPGIE([CanBeNull] this AJJIDJJMECL NNNIELGKJFB, IncrementalHash DOAOBIHCNJF, byte[] NILJPNJFOGB, [Out] string ENDMINEHNJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6C276D0", Offset = "0x6C260D0", VA = "0x186C276D0")]
	private static bool PIJNLACCFBB(byte[] NAHOMKMFEKM, Span<byte> MEPEBHEMJNG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class OPEOOEOEOMB
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6C27C80", Offset = "0x6C26680", VA = "0x186C27C80")]
	public static int NHDPIFJHAND(HashAlgorithmName PJNHBFHPDMG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6C27A20", Offset = "0x6C26420", VA = "0x186C27A20")]
	public static int MAJJILKDDFK(this HOLEDMBJCDB CCDFFEJNNAO, byte[] HCOLPMDGMDH, IncrementalHash DOAOBIHCNJF, byte[] BMKKLHINMOH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface HOLEDMBJCDB
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash DOAOBIHCNJF);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface AJJIDJJMECL : HOLEDMBJCDB
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	[CanBeNull]
	byte[] GCCABACIPDE
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	[CanBeNull]
	byte[] DGCHILINOIC
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class BINPCABEJEP
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static bool HEIJEFCNEND;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly ArrayPool<byte> PLGHBIJADKD;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly ArrayPool<char> DAJPJHBPLGH;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly Encoding EAANDAAMGOG;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly ThreadLocal<Encoder> AAPCEMJDLPL;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x2AD2660", Offset = "0x2AD1060", VA = "0x182AD2660")]
	public static void GHPOJPMNAMB<T>(this IncrementalHash NFHJCPDPIHO, [CanBeNull] T INEJDODHNGG) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2AD25D0", Offset = "0x2AD0FD0", VA = "0x182AD25D0")]
	public static void BIHAKOFHEBC<T>(this IncrementalHash NFHJCPDPIHO, [CanBeNull] T CCDFFEJNNAO) where T : HOLEDMBJCDB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x2AD2720", Offset = "0x2AD1120", VA = "0x182AD2720")]
	public static void LJMMMBAIIAM<T>(this IncrementalHash NFHJCPDPIHO, [CanBeNull] IList<T> FPJPKKJJECI) where T : HOLEDMBJCDB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6C24A20", Offset = "0x6C23420", VA = "0x186C24A20")]
	private static bool DOBHLACPNFN([CanBeNull] HOLEDMBJCDB CCDFFEJNNAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6C24AB0", Offset = "0x6C234B0", VA = "0x186C24AB0")]
	public static void EOMIIDPELLG(this IncrementalHash DOAOBIHCNJF, string? CHADOCHAGBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6C242E0", Offset = "0x6C22CE0", VA = "0x186C242E0")]
	public static void BCBMOJOHFGP(this IncrementalHash DOAOBIHCNJF, long MOOBPOCJAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6C247F0", Offset = "0x6C231F0", VA = "0x186C247F0")]
	public static void DKJMCIFDPPP(this IncrementalHash DOAOBIHCNJF, int OGMNEECDOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6C244B0", Offset = "0x6C22EB0", VA = "0x186C244B0")]
	public static void BLENKHKECHL(this IncrementalHash DOAOBIHCNJF, short ONNDLMDOHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6C246E0", Offset = "0x6C230E0", VA = "0x186C246E0")]
	public static void BOFGDBFOCMB(this IncrementalHash DOAOBIHCNJF, byte NKFCIOIPCIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6C24EB0", Offset = "0x6C238B0", VA = "0x186C24EB0")]
	public static void IDJKLMGMNKO(this IncrementalHash DOAOBIHCNJF, bool CKBBOFECJHM, bool BKIGNOBMMBC = false, bool KAPOAJNPDLH = false, bool LENPILFPBLD = false, bool CFMIFKGIMKC = false, bool PODCCKJLOPK = false, bool NNOFOCKDDGC = false, bool LKNODKAJBHP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x2AD2C40", Offset = "0x2AD1640", VA = "0x182AD2C40")]
	public static void OONDDMMMPMP<T>(this IncrementalHash DOAOBIHCNJF, T HBEFBGGFFKD) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6C24280", Offset = "0x6C22C80", VA = "0x186C24280")]
	public static void ANFMIDNKIND(this IncrementalHash DOAOBIHCNJF, float OGGAECCKLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6C25020", Offset = "0x6C23A20", VA = "0x186C25020")]
	public static void MAIGBICNDCG(this IncrementalHash DOAOBIHCNJF, ulong FEGHPJBPOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6C249C0", Offset = "0x6C233C0", VA = "0x186C249C0")]
	public static void DMEAHLAEJIG(this IncrementalHash DOAOBIHCNJF, uint MANJNONNEGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6C24680", Offset = "0x6C23080", VA = "0x186C24680")]
	public static void BLJDHGGFDBA(this IncrementalHash DOAOBIHCNJF, ushort AOLNJALFCME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6C25080", Offset = "0x6C23A80", VA = "0x186C25080")]
	public static void NCHGNABOFLP(this IncrementalHash DOAOBIHCNJF, Vector3 DDGLAMCJPEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class PAEAPHMAMID : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6C27DD0", Offset = "0x6C267D0", VA = "0x186C27DD0")]
	public PAEAPHMAMID(string KFAOBDLOMDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public abstract class JHNCEONGBEP<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	internal class EHOEPJIHAAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public TNode BJNJBGHPMEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public TNode LDJCBIBELIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public KNBLDIMCGPA KOIICEKKKHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public List<KNBLDIMCGPA> NLPHELGAJGH;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public EHOEPJIHAAF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal struct KNBLDIMCGPA : IComparable<KNBLDIMCGPA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public int OCBNPLFNECE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public TClaimant AFKODHGKCIE;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x1012BB0", Offset = "0x10115B0", VA = "0x181012BB0")]
		public KNBLDIMCGPA(int OCBNPLFNECE, TClaimant AFKODHGKCIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x4441140", Offset = "0x443FB40", VA = "0x184441140")]
		public bool MFOGLFCCAEH([In] KNBLDIMCGPA PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x4441120", Offset = "0x443FB20", VA = "0x184441120")]
		public bool BEMLNMPGNPF([In] KNBLDIMCGPA PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x4441130", Offset = "0x443FB30", VA = "0x184441130", Slot = "4")]
		public int CompareTo(KNBLDIMCGPA PLNBHPCFEOK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x44411A0", Offset = "0x443FBA0", VA = "0x1844411A0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public enum NFHMJADPKEP
	{
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class DBEELMNFICP : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public JHNCEONGBEP<TClaimant, TNode> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x993D30", Offset = "0x992730", VA = "0x180993D30")]
		[DebuggerHidden]
		public DBEELMNFICP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x5B27BE0", Offset = "0x5B265E0", VA = "0x185B27BE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x5B27DC0", Offset = "0x5B267C0", VA = "0x185B27DC0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x5B27CC0", Offset = "0x5B266C0", VA = "0x185B27CC0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3C4ACF0", Offset = "0x3C496F0", VA = "0x183C4ACF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly MOGMOHJBDLD<EHOEPJIHAAF> OAHDFMOBMBJ;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly MOGMOHJBDLD<List<KNBLDIMCGPA>> KGDDLFBCHJD;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static int GHKLMABMCNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	internal readonly Dictionary<TClaimant, TNode> AKFCJBJAMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	internal readonly Dictionary<TNode, EHOEPJIHAAF> GNIJCKCIPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private NFHMJADPKEP COEMAIGHGPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool HFIMBOHAJFI;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode HKBIHEEOPIF(TNode KOHLOCENPAH);

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void ALMJOIHJABC(TNode KOHLOCENPAH, TClaimant OCKPEDIOEGE, TClaimant MJKNDPCFBGI);

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x429C630", Offset = "0x429B030", VA = "0x18429C630")]
	public JHNCEONGBEP(NFHMJADPKEP COEMAIGHGPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x429BD70", Offset = "0x429A770", VA = "0x18429BD70")]
	public void IHPBHCHFJBO(TNode KOHLOCENPAH, TNode LEEMAEKICLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x429C070", Offset = "0x429AA70", VA = "0x18429C070")]
	public void LOMCDHBPBJJ(TClaimant AFKODHGKCIE, TNode JANIPFKNJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x429B240", Offset = "0x4299C40", VA = "0x18429B240", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x429BFA0", Offset = "0x429A9A0", VA = "0x18429BFA0")]
	private void LOBGEDBENPB(TClaimant AFKODHGKCIE, TNode KALPDEGIILK, TNode JANIPFKNJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x429C3E0", Offset = "0x429ADE0", VA = "0x18429C3E0")]
	private int NLNOHNMBKJB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x429BA10", Offset = "0x429A410", VA = "0x18429BA10")]
	private void HMLGFEJMOEI(TClaimant AFKODHGKCIE, TNode LIIEMNCNAGO, TNode KJIBJMLOEOL, int LNHGADCHIPG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x429AA40", Offset = "0x4299440", VA = "0x18429AA40")]
	private void AMAOHBABINE(KNBLDIMCGPA DFDHIPOMCDE, EHOEPJIHAAF GANDHMGOAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x429AE20", Offset = "0x4299820", VA = "0x18429AE20")]
	private void CNJHPFHKOBE(TClaimant AFKODHGKCIE, TNode LIIEMNCNAGO, TNode KJIBJMLOEOL, int LNHGADCHIPG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x429B8D0", Offset = "0x429A2D0", VA = "0x18429B8D0")]
	private void HIFHNHANMFA(KNBLDIMCGPA DFDHIPOMCDE, TNode KOHLOCENPAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x429AB20", Offset = "0x4299520", VA = "0x18429AB20")]
	private void BDOEBAGAMGL(KNBLDIMCGPA DFDHIPOMCDE, EHOEPJIHAAF GANDHMGOAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x429BE40", Offset = "0x429A840", VA = "0x18429BE40")]
	private void LKOJBLEGLAH(EHOEPJIHAAF GANDHMGOAJC, bool MDKHHIMOIJF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x429B460", Offset = "0x4299E60", VA = "0x18429B460")]
	private void FEJNIBCIJFL(EHOEPJIHAAF GANDHMGOAJC, TNode LEEMAEKICLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x429B7D0", Offset = "0x429A1D0", VA = "0x18429B7D0")]
	[IteratorStateMachine(typeof(JHNCEONGBEP<, >.DBEELMNFICP))]
	private IEnumerable<TNode> GBBNFEDKJEK(TNode LIIEMNCNAGO, TNode KJIBJMLOEOL, bool HBFOLNPIOBF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x429B120", Offset = "0x4299B20", VA = "0x18429B120")]
	private EHOEPJIHAAF DFNCPMNFPMK(TNode KOHLOCENPAH, TNode LDJCBIBELIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x429AC90", Offset = "0x4299690", VA = "0x18429AC90")]
	private EHOEPJIHAAF CCGHNHLHJGA(TNode KOHLOCENPAH, TNode LDJCBIBELIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x429C210", Offset = "0x429AC10", VA = "0x18429C210")]
	private void MFGCBMKPOEG(EHOEPJIHAAF GANDHMGOAJC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class KCEBOEMBPHC<T> : IEnumerable<KCEBOEMBPHC<T>.JALGICNCACK>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public struct JALGICNCACK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public T KLABJGGMBGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public int HGFDMIDEFHN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class MNOADCFJMPJ : IEnumerator<JALGICNCACK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private KCEBOEMBPHC<T> MECAOIIIDEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private int HGFDMIDEFHN;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x3A6B330", Offset = "0x3A69D30", VA = "0x183A6B330", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public JALGICNCACK JINHOCMBIBA
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x478D500", Offset = "0x478BF00", VA = "0x18478D500", Slot = "4")]
			get
			{
				return default(JALGICNCACK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x478D410", Offset = "0x478BE10", VA = "0x18478D410")]
		public MNOADCFJMPJ(KCEBOEMBPHC<T> MECAOIIIDEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x478D390", Offset = "0x478BD90", VA = "0x18478D390", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3AC1070", Offset = "0x3ABFA70", VA = "0x183AC1070", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xB8B690", Offset = "0xB8A090", VA = "0x180B8B690", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private struct EDAGNLEFEDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public bool GFHAPKAOHIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public T KLABJGGMBGH;
	}

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private const int EPOPNFLGMHO = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly Dictionary<T, int> GBHMBJNGHLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private EDAGNLEFEDB[] GGBFBEJFLNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private int MEODNPEJEJG;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public int DDOCDMMBJKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8D79A0", Offset = "0x8D63A0", VA = "0x1808D79A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8D70B0", Offset = "0x8D5AB0", VA = "0x1808D70B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public int MNNLJFACLOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x377A360", Offset = "0x3778D60", VA = "0x18377A360")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x4410270", Offset = "0x440EC70", VA = "0x184410270")]
	public KCEBOEMBPHC(int HCAOLDLEJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x440FE30", Offset = "0x440E830", VA = "0x18440FE30")]
	public KCEBOEMBPHC(JALGICNCACK[] HOHGOGBAPKC, bool BLHNHDMGDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x440EB10", Offset = "0x440D510", VA = "0x18440EB10")]
	public int CKPBJHKBAJE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x440EBE0", Offset = "0x440D5E0", VA = "0x18440EBE0")]
	private int ELPLKODBEIK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x440EAE0", Offset = "0x440D4E0", VA = "0x18440EAE0", Slot = "6")]
	protected virtual uint AHNPMMOMINN(uint DOAOBIHCNJF, T KLABJGGMBGH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x440F020", Offset = "0x440DA20", VA = "0x18440F020")]
	public bool GJKKBKFNGDO(T KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x440F830", Offset = "0x440E230", VA = "0x18440F830")]
	public int LOAMKNNONEE(T KLABJGGMBGH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x440F180", Offset = "0x440DB80", VA = "0x18440F180")]
	public T JHMOEGIAFJJ(int HGFDMIDEFHN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x440F240", Offset = "0x440DC40", VA = "0x18440F240")]
	public bool KEADIHLHCFE(T KLABJGGMBGH, bool HIBAMFKGLNE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x440F2B0", Offset = "0x440DCB0", VA = "0x18440F2B0")]
	public bool KEADIHLHCFE(T KLABJGGMBGH, int HGFDMIDEFHN, bool HIBAMFKGLNE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x440F0E0", Offset = "0x440DAE0", VA = "0x18440F0E0")]
	private int ILEHHIKGAFI(int NBPJLJIBBHP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x440F940", Offset = "0x440E340", VA = "0x18440F940", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x440F940", Offset = "0x440E340", VA = "0x18440F940", Slot = "4")]
	private IEnumerator<JALGICNCACK> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class MOGMOHJBDLD<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly Stack<T> PNBHHBNOEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly List<T> DDDECJCELPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly int OJHJEIKFFKA;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x478E270", Offset = "0x478CC70", VA = "0x18478E270")]
	public static MOGMOHJBDLD<T> DIGMCDIHONJ(int HCAOLDLEJCN = 0, int OJHJEIKFFKA = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x478E810", Offset = "0x478D210", VA = "0x18478E810")]
	public static MOGMOHJBDLD<T> MDJBKCCMJEO(int HCAOLDLEJCN = 0, int OJHJEIKFFKA = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x478EB30", Offset = "0x478D530", VA = "0x18478EB30")]
	public MOGMOHJBDLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x478E910", Offset = "0x478D310", VA = "0x18478E910")]
	public MOGMOHJBDLD(int HCAOLDLEJCN, int OJHJEIKFFKA = int.MaxValue, bool MFFGHHEMOJM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x478E650", Offset = "0x478D050", VA = "0x18478E650")]
	public T KINKNPKFCGM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x478E190", Offset = "0x478CB90", VA = "0x18478E190")]
	public void CJCAMEPPGCI(T KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x478E550", Offset = "0x478CF50", VA = "0x18478E550")]
	private void FIDANHBJPBM(T KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x478E500", Offset = "0x478CF00", VA = "0x18478E500")]
	private void FDENEEOHLOK(T KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x478E370", Offset = "0x478CD70", VA = "0x18478E370", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x478DF90", Offset = "0x478C990", VA = "0x18478DF90")]
	private void BMFMGBCELKE(IEnumerable<T> ICLOFOKMOJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class FGJHJMJKBBK<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private Dictionary<int, T> HGEMHLLLPMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private T MPKMDJKKGLB;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public virtual T MAMEDPJPNGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x899050", Offset = "0x897A50", VA = "0x180899050", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x899030", Offset = "0x897A30", VA = "0x180899030", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x3DF2C50", Offset = "0x3DF1650", VA = "0x183DF2C50")]
	public bool GMBIHPHNNPE(T KLABJGGMBGH, int OCBNPLFNECE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x3A0E750", Offset = "0x3A0D150", VA = "0x183A0E750")]
	public bool BDCMENKNKIJ(int OCBNPLFNECE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x3DF2FB0", Offset = "0x3DF19B0", VA = "0x183DF2FB0")]
	public T OKMEMNNNNCN(int HLCFDIFFPHA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x3DF2E70", Offset = "0x3DF1870", VA = "0x183DF2E70")]
	private bool IMFFCFJEHBM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x3DF2F50", Offset = "0x3DF1950", VA = "0x183DF2F50")]
	public bool LAFFHOKCOBI(int OCBNPLFNECE, [Out] T KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x3A10EC0", Offset = "0x3A0F8C0", VA = "0x183A10EC0")]
	public FGJHJMJKBBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class CGEKAGAGHLJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	protected struct FECFLNIMLMH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public T PGPGCBGPPOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public int AMAJJPNLHJB;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	protected readonly List<FECFLNIMLMH> EBKMDGFIIBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private T MNJJGFPGCCE;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public int MNNLJFACLOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x377A360", Offset = "0x3778D60", VA = "0x18377A360")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x5669040", Offset = "0x5667A40", VA = "0x185669040")]
	public bool FEAHPDAAGAE(T KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x5668E00", Offset = "0x5667800", VA = "0x185668E00")]
	public void FABNFHGMHGJ(T KLABJGGMBGH, int OCBNPLFNECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x5669270", Offset = "0x5667C70", VA = "0x185669270")]
	public bool MBEEDABKNGP(T KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x5669610", Offset = "0x5668010", VA = "0x185669610")]
	public void MPAAPCHGDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x56696C0", Offset = "0x56680C0", VA = "0x1856696C0")]
	public T PFNAINPPKEI()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x5668BA0", Offset = "0x56675A0", VA = "0x185668BA0")]
	protected void BJBEDCNPEPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x5669800", Offset = "0x5668200", VA = "0x185669800")]
	public CGEKAGAGHLJ()
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
		[JLEDHNACBFM(LPFNGFMJOGK.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x6C28170", Offset = "0x6C26B70", VA = "0x186C28170")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x6C28440", Offset = "0x6C26E40", VA = "0x186C28440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x6C28350", Offset = "0x6C26D50", VA = "0x186C28350")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x6C280C0", Offset = "0x6C26AC0", VA = "0x186C280C0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x6C28390", Offset = "0x6C26D90", VA = "0x186C28390")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x6C282A0", Offset = "0x6C26CA0", VA = "0x186C282A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x6C28040", Offset = "0x6C26A40", VA = "0x186C28040")]
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
		[Cpp2IlInjected.Address(RVA = "0x4BDD010", Offset = "0x4BDBA10", VA = "0x184BDD010", Slot = "4")]
		public virtual T HOCGGHEFDPB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class KGCNOMJLKLJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private Dictionary<byte, DFKJJEKDPAN> NCPBGGHLFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private readonly MOGMOHJBDLD<DFKJJEKDPAN> OAPHKHOMFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly bool CEPPPDHKKFN;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public DFKJJEKDPAN AMEHPOBNHMM
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8961C0", Offset = "0x894BC0", VA = "0x1808961C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Vector2 GGDNPJPPOBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xF71460", Offset = "0xF6FE60", VA = "0x180F71460")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x1290270", Offset = "0x128EC70", VA = "0x181290270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	private Vector2 PILAFGHCIIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x94AA20", Offset = "0x949420", VA = "0x18094AA20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Vector2 PKPBFOEMNNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6C25F30", Offset = "0x6C24930", VA = "0x186C25F30")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8999C0", Offset = "0x8983C0", VA = "0x1808999C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int CNJKHJEDDNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8A64C0", Offset = "0x8A4EC0", VA = "0x1808A64C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8A5F70", Offset = "0x8A4970", VA = "0x1808A5F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6C26EF0", Offset = "0x6C258F0", VA = "0x186C26EF0")]
	public KGCNOMJLKLJ(Bounds FDEEFKKBMPN, Vector2[] LAGMOMGHKBF, int MBIGONMGNOM, byte NBPJLJIBBHP, float BOLJBNJEECG = 0f, [Optional] MOGMOHJBDLD<DFKJJEKDPAN> OAPHKHOMFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6C26410", Offset = "0x6C24E10", VA = "0x186C26410")]
	public void KLPKPLEDCGC(Bounds FDEEFKKBMPN, Vector2[] LAGMOMGHKBF, int MBIGONMGNOM, byte NBPJLJIBBHP, float BOLJBNJEECG = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6C268B0", Offset = "0x6C252B0", VA = "0x186C268B0")]
	public DFKJJEKDPAN NHPDLKLOJNH(byte HGFDMIDEFHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6C26340", Offset = "0x6C24D40", VA = "0x186C26340")]
	public void JKOECOBIBKO(Vector3 LEELMECKGCG, float HOIEOMDDOBM, float PHGGFLDFJLC, List<byte> KOAIFCFGEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6C26320", Offset = "0x6C24D20", VA = "0x186C26320")]
	public void INLLELBJEAI(DFKJJEKDPAN.NLOJICGBAGP KPGINFEFIJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6C25F50", Offset = "0x6C24950", VA = "0x186C25F50")]
	public static int CMCCJCDGBKD(Vector2[] LAGMOMGHKBF, int MBIGONMGNOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6C26910", Offset = "0x6C25310", VA = "0x186C26910")]
	private DFKJJEKDPAN OBAKEMNMDNC(byte HGFDMIDEFHN, DFKJJEKDPAN.CIBPKACHPPI HMOEACGMNFA, DFKJJEKDPAN LDJCBIBELIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6C26B40", Offset = "0x6C25540", VA = "0x186C26B40")]
	private void OFLLPNOLCIO(DFKJJEKDPAN LDJCBIBELIM, Vector2[] LAGMOMGHKBF, int IBICPGCHFHL, int DBGFCEHDBML, int JGGICKNEINA, int ECMIPJACOKK, float BOLJBNJEECG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6C26040", Offset = "0x6C24A40", VA = "0x186C26040")]
	private void DPFCBDPIBEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6C26260", Offset = "0x6C24C60", VA = "0x186C26260", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6C262C0", Offset = "0x6C24CC0", VA = "0x186C262C0", Slot = "1")]
	~KGCNOMJLKLJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class DFKJJEKDPAN
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public enum CIBPKACHPPI
	{
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public enum NLOJICGBAGP
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
	public byte OMPMKCIPJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public Vector3 MPMIDEELHJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public Vector3 KHAEIGABOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public Vector3 ODODCCCNOEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public Vector3 KIPHCFNIGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public CIBPKACHPPI BKBPAMDNDLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public DFKJJEKDPAN NPDGLEPLKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public List<DFKJJEKDPAN> EMAENDOGIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public bool MLLCKGIJCKA;

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x6C25A90", Offset = "0x6C24490", VA = "0x186C25A90")]
	public DFKJJEKDPAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6C25690", Offset = "0x6C24090", VA = "0x186C25690")]
	public void BHLBCINICIP(DFKJJEKDPAN JGEMMJEFOMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
	public void INLLELBJEAI(int GIMJBOMHNKG, NLOJICGBAGP KPGINFEFIJB, int DKIIACHLPCD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x6C257D0", Offset = "0x6C241D0", VA = "0x186C257D0")]
	public void JKOECOBIBKO(List<byte> KOAIFCFGEPC, Vector3 LEELMECKGCG, float HOIEOMDDOBM, float PHGGFLDFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x6C25A60", Offset = "0x6C24460", VA = "0x186C25A60")]
	public bool MOGBNCIIENJ(Vector3 IFDMLAIJAHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x6C25A30", Offset = "0x6C24430", VA = "0x186C25A30")]
	public bool KLJDNJIKBFN(Vector3 IFDMLAIJAHF, float DNIMIBKBAMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6C25600", Offset = "0x6C24000", VA = "0x186C25600")]
	public void AIFHKOLJDOL()
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
		public struct CLPMIGINGNH<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private readonly List<Component> OLAPNOFMNPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private readonly bool FGPBNNBIOHI;

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x44B6DF0", Offset = "0x44B57F0", VA = "0x1844B6DF0")]
			public CLPMIGINGNH(List<Component> OLAPNOFMNPM, bool FGPBNNBIOHI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x5859BC0", Offset = "0x58585C0", VA = "0x185859BC0")]
			public OOODEIPHFMH<T> HNHGFOAAHAF()
			{
				return default(OOODEIPHFMH<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x5859C30", Offset = "0x5858630", VA = "0x185859C30", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x5859C30", Offset = "0x5858630", VA = "0x185859C30", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006E")]
		public struct OOODEIPHFMH<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			private readonly List<Component> OLAPNOFMNPM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			private readonly bool FGPBNNBIOHI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			private int HGFDMIDEFHN;

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public T JINHOCMBIBA
			{
				[Cpp2IlInjected.Token(Token = "0x600021A")]
				[Cpp2IlInjected.Address(RVA = "0x490D8D0", Offset = "0x490C2D0", VA = "0x18490D8D0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000061")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600021B")]
				[Cpp2IlInjected.Address(RVA = "0x490D860", Offset = "0x490C260", VA = "0x18490D860", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x490D8A0", Offset = "0x490C2A0", VA = "0x18490D8A0")]
			public OOODEIPHFMH(List<Component> OLAPNOFMNPM, bool FGPBNNBIOHI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x490D7A0", Offset = "0x490C1A0", VA = "0x18490D7A0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x490D7B0", Offset = "0x490C1B0", VA = "0x18490D7B0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x3A14DC0", Offset = "0x3A137C0", VA = "0x183A14DC0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C29E60", Offset = "0x6C28860", VA = "0x186C29E60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6C29810", Offset = "0x6C28210", VA = "0x186C29810")]
		private void AIFHKOLJDOL(GameObject MDAHHDPNOMM, bool LENLJCDCMCG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x6C29780", Offset = "0x6C28180", VA = "0x186C29780")]
		public static void AIFHKOLJDOL(GameObject MDAHHDPNOMM, ToolHierarchyCache DNNINLMOCPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6C29A00", Offset = "0x6C28400", VA = "0x186C29A00")]
		public void GBEDMPFBKNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3095000", Offset = "0x3093A00", VA = "0x183095000")]
		public void NBIFNCPJJJO<T>(Action<T> PMCMEAHOBEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x3094F60", Offset = "0x3093960", VA = "0x183094F60")]
		public T EAFLALGLEHA<T>(bool FGPBNNBIOHI = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x3095240", Offset = "0x3093C40", VA = "0x183095240")]
		public CLPMIGINGNH<T> NKNEAKIGKMJ<T>(bool FGPBNNBIOHI = false) where T : class
		{
			return default(CLPMIGINGNH<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6C29A10", Offset = "0x6C28410", VA = "0x186C29A10")]
		public List<Component> GFPOMHEHGKC(Type JLAAKHANEHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x6C29980", Offset = "0x6C28380", VA = "0x186C29980", Slot = "4")]
		public bool Equals(ToolHierarchyCache NCPIGLMANIM, ToolHierarchyCache DJBPOPBDKAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x6C29D60", Offset = "0x6C28760", VA = "0x186C29D60", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache GHMNBJIOGAM)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class LJOOMPALBJA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int HCAOLDLEJCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int OMMPMAMGCAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private List<T> GMHOCNFEHGD;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int MNNLJFACLOK
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x429E4F0", Offset = "0x429CEF0", VA = "0x18429E4F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public T FBNLOBKJFGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x44D8980", Offset = "0x44D7380", VA = "0x1844D8980")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public T OBJLAOIPCAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x44D8890", Offset = "0x44D7290", VA = "0x1844D8890")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public T MPEAGFGEPEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x44D8BA0", Offset = "0x44D75A0", VA = "0x1844D8BA0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x44D8CF0", Offset = "0x44D76F0", VA = "0x1844D8CF0")]
	public LJOOMPALBJA(int HCAOLDLEJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x44D85B0", Offset = "0x44D6FB0", VA = "0x1844D85B0")]
	public void FABNFHGMHGJ(T DHCIPDPNOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x44D8C20", Offset = "0x44D7620", VA = "0x1844D8C20")]
	public void MPAAPCHGDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x44D84B0", Offset = "0x44D6EB0", VA = "0x1844D84B0")]
	public void DLCJCGPMNAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x44D8C80", Offset = "0x44D7680", VA = "0x1844D8C80")]
	public void NLDHJALJBBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x44D84A0", Offset = "0x44D6EA0", VA = "0x1844D84A0")]
	public void AOPLOKJADDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x44D8400", Offset = "0x44D6E00", VA = "0x1844D8400")]
	public List<T> AOJADBJEDFH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class EKKHBMHPFLJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private struct DAPAPNJDAHN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public int AMAJJPNLHJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public T PGPGCBGPPOH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly Dictionary<object, DAPAPNJDAHN> HGEMHLLLPMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly EqualityComparer<T> PFHCFCNJFFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private T MPKMDJKKGLB;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public virtual T MAMEDPJPNGB
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x962310", Offset = "0x960D10", VA = "0x180962310", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x3A3A6F0", Offset = "0x3A390F0", VA = "0x183A3A6F0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public bool LLEHPMPCDLE
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x3A3A850", Offset = "0x3A39250", VA = "0x183A3A850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public object NAGHLKNCOEB
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8999A0", Offset = "0x8983A0", VA = "0x1808999A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x89D6A0", Offset = "0x89C0A0", VA = "0x18089D6A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x3A3B130", Offset = "0x3A39B30", VA = "0x183A3B130")]
	public bool GMBIHPHNNPE(T KLABJGGMBGH, object FLLNLBHFENG, int OCBNPLFNECE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x3A3A790", Offset = "0x3A39190", VA = "0x183A3A790")]
	public bool BDCMENKNKIJ(object FLLNLBHFENG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x3A3E740", Offset = "0x3A3D140", VA = "0x183A3E740")]
	public bool LAFFHOKCOBI(object FLLNLBHFENG, [Out] T KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x3A3ED40", Offset = "0x3A3D740", VA = "0x183A3ED40")]
	public void MPAAPCHGDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x3A3D820", Offset = "0x3A3C220", VA = "0x183A3D820")]
	private bool IMFFCFJEHBM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x3A3EDA0", Offset = "0x3A3D7A0", VA = "0x183A3EDA0")]
	public EKKHBMHPFLJ()
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
