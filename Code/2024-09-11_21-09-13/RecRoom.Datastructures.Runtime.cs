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
		[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B407B0", Offset = "0x6B3EDB0", VA = "0x186B407B0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8B0AE0", Offset = "0x8AF0E0", VA = "0x1808B0AE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8B0B20", Offset = "0x8AF120", VA = "0x1808B0B20")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class PFEDOPIKGDD : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x16E4740", Offset = "0x16E2D40", VA = "0x1816E4740")]
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
		[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x887030", Offset = "0x885630", VA = "0x180887030", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x886FC0", Offset = "0x8855C0", VA = "0x180886FC0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x887040", Offset = "0x885640", VA = "0x180887040", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA36FE0", Offset = "0xA355E0", VA = "0x180A36FE0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash DOAOBIHCNJF);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x903180", Offset = "0x901780", VA = "0x180903180")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B41FD0", Offset = "0x6B405D0", VA = "0x186B41FD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6B41F90", Offset = "0x6B40590", VA = "0x186B41F90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6B42010", Offset = "0x6B40610", VA = "0x186B42010")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6B421C0", Offset = "0x6B407C0", VA = "0x186B421C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6B42130", Offset = "0x6B40730", VA = "0x186B42130")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x91DD80", Offset = "0x91C380", VA = "0x18091DD80")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xA374B0", Offset = "0xA35AB0", VA = "0x180A374B0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6B41F50", Offset = "0x6B40550", VA = "0x186B41F50")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6B420A0", Offset = "0x6B406A0", VA = "0x186B420A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6B41B80", Offset = "0x6B40180", VA = "0x186B41B80")]
	public void CopyBounds(SavedExtents PLNBHPCFEOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6B41EA0", Offset = "0x6B404A0", VA = "0x186B41EA0")]
	public void SetLocalSpaceBounds(Bounds OHEEJLEICDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xD2BED0", Offset = "0xD2A4D0", VA = "0x180D2BED0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6B41E90", Offset = "0x6B40490", VA = "0x186B41E90")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6B41380", Offset = "0x6B3F980", VA = "0x186B41380")]
	private void BODAAMGPBIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6B41C70", Offset = "0x6B40270", VA = "0x186B41C70")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6B41540", Offset = "0x6B3FB40", VA = "0x186B41540")]
	public static void CalculateLocalBoundsFor(GameObject MNKAGJEGJCF, [Out] Bounds OHEEJLEICDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6B41BB0", Offset = "0x6B401B0", VA = "0x186B41BB0")]
	private static void GIAOOGMLELI(Bounds MKGNFMMEFHC, Color DMIBFACOBBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6B41EC0", Offset = "0x6B404C0", VA = "0x186B41EC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8841A0", Offset = "0x8827A0", VA = "0x1808841A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x887070", Offset = "0x885670", VA = "0x180887070")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x11857E0", Offset = "0x1183DE0", VA = "0x1811857E0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4B41680", Offset = "0x4B3FC80", VA = "0x184B41680")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "4")]
	public virtual void OGGGFGGPBOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4B411B0", Offset = "0x4B3F7B0", VA = "0x184B411B0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4B3F890", Offset = "0x4B3DE90", VA = "0x184B3F890", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4B41570", Offset = "0x4B3FB70", VA = "0x184B41570")]
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
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public GICHKNMPGDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3DEA570", Offset = "0x3DE8B70", VA = "0x183DEA570")]
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
		[Cpp2IlInjected.Address(RVA = "0x3995F50", Offset = "0x3994550", VA = "0x183995F50", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3995FB0", Offset = "0x39945B0", VA = "0x183995FB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3995E20", Offset = "0x3994420", VA = "0x183995E20", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey LFOBGDLOPID]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3995EE0", Offset = "0x39944E0", VA = "0x183995EE0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3995CC0", Offset = "0x39942C0", VA = "0x183995CC0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3995960", Offset = "0x3993F60", VA = "0x183995960", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3994D20", Offset = "0x3993320", VA = "0x183994D20", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3994C90", Offset = "0x3993290", VA = "0x183994C90", Slot = "14")]
	protected virtual string JDMEPJHACPG(TKeyVal ODPLKBJGFEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3994B80", Offset = "0x3993180", VA = "0x183994B80", Slot = "4")]
	public bool ContainsKey(TKey LFOBGDLOPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3995B30", Offset = "0x3994130", VA = "0x183995B30", Slot = "5")]
	public bool TryGetValue(TKey LFOBGDLOPID, [Out] TVal KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3994BE0", Offset = "0x39931E0", VA = "0x183994BE0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3994BE0", Offset = "0x39931E0", VA = "0x183994BE0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3995B90", Offset = "0x3994190", VA = "0x183995B90")]
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
		[Cpp2IlInjected.Address(RVA = "0x8841B0", Offset = "0x8827B0", VA = "0x1808841B0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8841C0", Offset = "0x8827C0", VA = "0x1808841C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x887030", Offset = "0x885630", VA = "0x180887030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3D8A200", Offset = "0x3D88800", VA = "0x183D8A200")]
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
	[Cpp2IlInjected.Address(RVA = "0x4B428E0", Offset = "0x4B40EE0", VA = "0x184B428E0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4B41E60", Offset = "0x4B40460", VA = "0x184B41E60", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4B41570", Offset = "0x4B3FB70", VA = "0x184B41570")]
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
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public OIMKDLABEDP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4828810", Offset = "0x4826E10", VA = "0x184828810")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E58A10", Offset = "0x3E57010", VA = "0x183E58A10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3E59280", Offset = "0x3E57880", VA = "0x183E59280")]
	public HAIFFEDDPIN(float EADCNJLKLHJ, float LBEJGKANMDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3E585F0", Offset = "0x3E56BF0", VA = "0x183E585F0")]
	public bool GDJALHICHKP(float IMAGIDBPDMM, T KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3E58E20", Offset = "0x3E57420", VA = "0x183E58E20")]
	public IEnumerable<T> KNKJJKLELNO(float IMAGIDBPDMM, [Optional] float? NFCFCPBBNII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3E591C0", Offset = "0x3E577C0", VA = "0x183E591C0")]
	public void MPAAPCHGDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3E587E0", Offset = "0x3E56DE0", VA = "0x183E587E0")]
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
		[Cpp2IlInjected.Address(RVA = "0xB34CF0", Offset = "0xB332F0", VA = "0x180B34CF0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xB64DC0", Offset = "0xB633C0", VA = "0x180B64DC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x482A6E0", Offset = "0x4828CE0", VA = "0x18482A6E0")]
	public OKAIMGLEANI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x482A5A0", Offset = "0x4828BA0", VA = "0x18482A5A0")]
	public OKAIMGLEANI(int BHEAFIOEIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x48299D0", Offset = "0x4827FD0", VA = "0x1848299D0")]
	public void FABNFHGMHGJ(float IMAGIDBPDMM, T KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4829E10", Offset = "0x4828410", VA = "0x184829E10")]
	public void MPAAPCHGDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x482A2F0", Offset = "0x48288F0", VA = "0x18482A2F0")]
	public bool OJAPCLFLOLI(float APGBJJBOFJM, float JGMKAHHJFKO, [Out] T KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x48294C0", Offset = "0x4827AC0", VA = "0x1848294C0")]
	public bool DBBGJBBJJGG(float APGBJJBOFJM, float JGMKAHHJFKO, [Out] T KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4829C90", Offset = "0x4828290", VA = "0x184829C90")]
	public void GEHLEKPPDKD(float APGBJJBOFJM, float JGMKAHHJFKO, List<T> DJOHOLIEOKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4829FF0", Offset = "0x48285F0", VA = "0x184829FF0")]
	private int NEFGPBFAJBF(int LGMKIOHHJCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4829470", Offset = "0x4827A70", VA = "0x184829470")]
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
	[Cpp2IlInjected.Address(RVA = "0x895B10", Offset = "0x894110", VA = "0x180895B10", Slot = "4")]
	protected override Vector3 CIELCKPKCKB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6B3ECA0", Offset = "0x6B3D2A0", VA = "0x186B3ECA0", Slot = "5")]
	protected override Vector3 CCGIGJECGOE(Vector3 KLABJGGMBGH, float KGPMLIHPPAA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6B3EBD0", Offset = "0x6B3D1D0", VA = "0x186B3EBD0", Slot = "6")]
	protected override Vector3 BEMPEMEPJDB(Vector3 JDKMLCHPKLA, Vector3 AENKMLMFBAD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6B3EC20", Offset = "0x6B3D220", VA = "0x186B3EC20", Slot = "7")]
	protected override Vector3 BPBADMEJAOI(Vector3 JDKMLCHPKLA, Vector3 AENKMLMFBAD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6B3ECE0", Offset = "0x6B3D2E0", VA = "0x186B3ECE0")]
	public JMGKCBPFDEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class AJAPLMJNIEN
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x334A0A0", Offset = "0x33486A0", VA = "0x18334A0A0")]
	public static NLOJMGFBPKG<T1, T2> GMDNOGMNFLF<T1, T2>(T1 IJGAIHDGHFA, T2 CCGNFNGHILM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x334A140", Offset = "0x3348740", VA = "0x18334A140")]
	public static NGMIMHAAAFC<T1, T2, T3> GMDNOGMNFLF<T1, T2, T3>(T1 IJGAIHDGHFA, T2 CCGNFNGHILM, T3 MDDCNMEHIHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x46EA650", Offset = "0x46E8C50", VA = "0x1846EA650")]
	internal static int NHCFIELNEFP(int HMHOBPHFNBB, int FDFADNBBHNP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5EF16F0", Offset = "0x5EEFCF0", VA = "0x185EF16F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x472E240", Offset = "0x472C840", VA = "0x18472E240")]
	public NLOJMGFBPKG(T1 IJGAIHDGHFA, T2 CCGNFNGHILM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x472C410", Offset = "0x472AA10", VA = "0x18472C410", Slot = "4")]
	public int CompareTo(NLOJMGFBPKG<T1, T2> PLNBHPCFEOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x472CD20", Offset = "0x472B320", VA = "0x18472CD20", Slot = "0")]
	public override bool Equals(object PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x472D680", Offset = "0x472BC80", VA = "0x18472D680", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x472D9C0", Offset = "0x472BFC0", VA = "0x18472D9C0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x47195E0", Offset = "0x4717BE0", VA = "0x1847195E0")]
	public NGMIMHAAAFC(T1 IJGAIHDGHFA, T2 CCGNFNGHILM, T3 MDDCNMEHIHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4718DD0", Offset = "0x47173D0", VA = "0x184718DD0", Slot = "4")]
	public int CompareTo(NGMIMHAAAFC<T1, T2, T3> PLNBHPCFEOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4719030", Offset = "0x4717630", VA = "0x184719030", Slot = "0")]
	public override bool Equals(object PLNBHPCFEOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x47191E0", Offset = "0x47177E0", VA = "0x1847191E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4719420", Offset = "0x4717A20", VA = "0x184719420", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x23FC850", Offset = "0x23FAE50", VA = "0x1823FC850")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x23FC840", Offset = "0x23FAE40", VA = "0x1823FC840")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float JEEEJDKHNCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x925370", Offset = "0x923970", VA = "0x180925370")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4D8FFA0", Offset = "0x4D8E5A0", VA = "0x184D8FFA0")]
	public T GCLKEIENIBN(float KGPMLIHPPAA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4D90590", Offset = "0x4D8EB90", VA = "0x184D90590")]
	public T OJLDGOIKONN(float KGPMLIHPPAA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T EHHBHJFFOHF(T JDKMLCHPKLA, T AENKMLMFBAD, float KGPMLIHPPAA);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6B3EAE0", Offset = "0x6B3D0E0", VA = "0x186B3EAE0", Slot = "4")]
	protected override float EHHBHJFFOHF(float JDKMLCHPKLA, float AENKMLMFBAD, float KGPMLIHPPAA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6B3EB20", Offset = "0x6B3D120", VA = "0x186B3EB20")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x100B670", Offset = "0x1009C70", VA = "0x18100B670", Slot = "4")]
	protected override Vector3 EHHBHJFFOHF(Vector3 JDKMLCHPKLA, Vector3 AENKMLMFBAD, float KGPMLIHPPAA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6B42F90", Offset = "0x6B41590", VA = "0x186B42F90")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6B3E310", Offset = "0x6B3C910", VA = "0x186B3E310", Slot = "4")]
	protected override Color EHHBHJFFOHF(Color JDKMLCHPKLA, Color AENKMLMFBAD, float KGPMLIHPPAA)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6B3E3D0", Offset = "0x6B3C9D0", VA = "0x186B3E3D0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class FJLGHFMFEGD : KCEBOEMBPHC<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6B3EA90", Offset = "0x6B3D090", VA = "0x186B3EA90")]
	public FJLGHFMFEGD(int HCAOLDLEJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6B3EA20", Offset = "0x6B3D020", VA = "0x186B3EA20", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3940260", Offset = "0x393E860", VA = "0x183940260")]
	private KGMPEMBPBDF(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> AMMAMFCCPBP, int LNCKHBAPANI, int DKJFIAGOKPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4351B00", Offset = "0x4350100", VA = "0x184351B00")]
	public static KGMPEMBPBDF<T> GGBAHLJJLHO()
	{
		return default(KGMPEMBPBDF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x43513A0", Offset = "0x434F9A0", VA = "0x1843513A0")]
	public (int, int, Task<T>) FDNBJKIPHKJ(int GPABCNEPJFA, [Optional] CancellationToken IONNNJNKLMJ, double GMOGAEOJHDH = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4351DE0", Offset = "0x43503E0", VA = "0x184351DE0")]
	public void KPCJNDCJFAO(int GPABCNEPJFA, int DKJFIAGOKPG, [In] T POBDLJBBBCI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class CIGPBIFCBPB
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6B3E240", Offset = "0x6B3C840", VA = "0x186B3E240")]
	public static KGMPEMBPBDF<BLGMJKLPHOM> GGBAHLJJLHO()
	{
		return default(KGMPEMBPBDF<BLGMJKLPHOM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6B3E290", Offset = "0x6B3C890", VA = "0x186B3E290")]
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
		[Cpp2IlInjected.Address(RVA = "0x36B5100", Offset = "0x36B3700", VA = "0x1836B5100", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool PBLDLBGBGPD
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public ICollection<TKey> IAJFPBHMOEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3E72560", Offset = "0x3E70B60", VA = "0x183E72560", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public ICollection<TVal> EMLPAKLEEGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x396A430", Offset = "0x3968A30", VA = "0x18396A430", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public TVal BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3E724F0", Offset = "0x3E70AF0", VA = "0x183E724F0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x3E72600", Offset = "0x3E70C00", VA = "0x183E72600", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public TKey BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x3E717B0", Offset = "0x3E6FDB0", VA = "0x183E717B0")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3E71810", Offset = "0x3E6FE10", VA = "0x183E71810", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3E72260", Offset = "0x3E70860", VA = "0x183E72260", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3E716B0", Offset = "0x3E6FCB0", VA = "0x183E716B0", Slot = "9")]
	public void Add(TKey LFOBGDLOPID, TVal KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3E71660", Offset = "0x3E6FC60", VA = "0x183E71660", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> IFNDNLEGMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3E718C0", Offset = "0x3E6FEC0", VA = "0x183E718C0", Slot = "8")]
	public bool ContainsKey(TKey LFOBGDLOPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3E71960", Offset = "0x3E6FF60", VA = "0x183E71960", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> IFNDNLEGMFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3E721A0", Offset = "0x3E707A0", VA = "0x183E721A0", Slot = "10")]
	public bool Remove(TKey LFOBGDLOPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3E721E0", Offset = "0x3E707E0", VA = "0x183E721E0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> IFNDNLEGMFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3E72300", Offset = "0x3E70900", VA = "0x183E72300", Slot = "11")]
	public bool TryGetValue(TKey LFOBGDLOPID, [Out] TVal KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3E71E60", Offset = "0x3E70460", VA = "0x183E71E60", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3E719A0", Offset = "0x3E6FFA0", VA = "0x183E719A0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] DKEEEGEFALD, int FFJKEOACOPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3E72140", Offset = "0x3E70740", VA = "0x183E72140")]
	public bool LAFFHOKCOBI(TVal LFOBGDLOPID, [Out] TKey KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3E71B10", Offset = "0x3E70110", VA = "0x183E71B10")]
	private void ELFBFCLFDHN(TKey LFOBGDLOPID, TVal AAJFAHDADNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3E71FE0", Offset = "0x3E705E0", VA = "0x183E71FE0")]
	private void JADJMPILMGP(TKey LFOBGDLOPID, TVal AAJFAHDADNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3E71C10", Offset = "0x3E70210", VA = "0x183E71C10")]
	private bool FIAAFAPNPCL(TKey LFOBGDLOPID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3E72360", Offset = "0x3E70960", VA = "0x183E72360")]
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
			[Cpp2IlInjected.Address(RVA = "0x39DF040", Offset = "0x39DD640", VA = "0x1839DF040", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x39EDE90", Offset = "0x39EC490", VA = "0x1839EDE90", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x39EE2D0", Offset = "0x39EC8D0", VA = "0x1839EE2D0")]
		public Enumerator(AOIDBMPNMPK<T> DJOHOLIEOKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x39EC090", Offset = "0x39EA690", VA = "0x1839EC090", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x39ECBC0", Offset = "0x39EB1C0", VA = "0x1839ECBC0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x39EB020", Offset = "0x39E9620", VA = "0x1839EB020")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F22CD0", Offset = "0x3F212D0", VA = "0x183F22CD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public T BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3F22F60", Offset = "0x3F21560", VA = "0x183F22F60")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3F24940", Offset = "0x3F22F40", VA = "0x183F24940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3F24FE0", Offset = "0x3F235E0", VA = "0x183F24FE0")]
	public AOIDBMPNMPK(int HCAOLDLEJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3F23340", Offset = "0x3F21940", VA = "0x183F23340")]
	public void FABNFHGMHGJ(T KGPMLIHPPAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3F24CD0", Offset = "0x3F232D0", VA = "0x183F24CD0")]
	public void MPAAPCHGDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3F22D10", Offset = "0x3F21310", VA = "0x183F22D10")]
	public void BLECIAPFBDN(int FIGHABPEBPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3F24490", Offset = "0x3F22A90", VA = "0x183F24490")]
	public void IKLPEOJFMNH(T[] DKEEEGEFALD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3F23FD0", Offset = "0x3F225D0", VA = "0x183F23FD0")]
	public Enumerator HNHGFOAAHAF()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3F24D70", Offset = "0x3F23370", VA = "0x183F24D70", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3F24D70", Offset = "0x3F23370", VA = "0x183F24D70", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3F23C60", Offset = "0x3F22260", VA = "0x183F23C60")]
	private int GPBNJDFCDDK(int HGFDMIDEFHN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3F24910", Offset = "0x3F22F10", VA = "0x183F24910")]
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
			[Cpp2IlInjected.Address(RVA = "0x3E7D580", Offset = "0x3E7BB80", VA = "0x183E7D580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan JLKKPLPICDC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x8841B0", Offset = "0x8827B0", VA = "0x1808841B0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x3E7D740", Offset = "0x3E7BD40", VA = "0x183E7D740")]
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
		[Cpp2IlInjected.Address(RVA = "0x5A751A0", Offset = "0x5A737A0", VA = "0x185A751A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3E8D260", Offset = "0x3E8B860", VA = "0x183E8D260", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3E8DB40", Offset = "0x3E8C140", VA = "0x183E8DB40", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x3F4C9D0", Offset = "0x3F4AFD0", VA = "0x183F4C9D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3F4D030", Offset = "0x3F4B630", VA = "0x183F4D030", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x3DAEF30", Offset = "0x3DAD530", VA = "0x183DAEF30")]
	public AHBIPPDKNFN(HPDFEGEFJHD DGEBNMNGJNC, [Optional] HKCJMIABMLB CBBGEMNONGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3DAE5B0", Offset = "0x3DACBB0", VA = "0x183DAE5B0")]
	public Task<TResult> PHFBFNLCIAL(TRequest NEKCFCOLDAN, CancellationToken IONNNJNKLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3DADAD0", Offset = "0x3DAC0D0", VA = "0x183DADAD0")]
	private void BAEPNCDLGCC(DPJNGOGNCHK GMNIOKFBLPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3DAED90", Offset = "0x3DAD390", VA = "0x183DAED90")]
	[AsyncStateMachine(typeof(AHBIPPDKNFN<, >.HNPMPIJDHPH))]
	private Task POIOLJHCDOC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3DAE280", Offset = "0x3DAC880", VA = "0x183DAE280")]
	private DPJNGOGNCHK DKPEELNAANO()
	{
		return default(DPJNGOGNCHK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3DAD700", Offset = "0x3DABD00", VA = "0x183DAD700")]
	[AsyncStateMachine(typeof(AHBIPPDKNFN<, >.IBLBHACLOBE))]
	private Task ADLDJNAMPPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3DAD3D0", Offset = "0x3DAB9D0", VA = "0x183DAD3D0")]
	private void AADOCEEJEIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3DAE570", Offset = "0x3DACB70", VA = "0x183DAE570", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x36B5100", Offset = "0x36B3700", VA = "0x1836B5100", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool PBLDLBGBGPD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8CEE40", Offset = "0x8CD440", VA = "0x1808CEE40", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T BFDOCJKIDPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x293CD30", Offset = "0x293B330", VA = "0x18293CD30", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x4342AC0", Offset = "0x43410C0", VA = "0x184342AC0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3D591A0", Offset = "0x3D577A0", VA = "0x183D591A0", Slot = "11")]
	public void Add(T IFNDNLEGMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4342310", Offset = "0x4340910", VA = "0x184342310")]
	public bool KEADIHLHCFE(T IFNDNLEGMFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x43428C0", Offset = "0x4340EC0", VA = "0x1843428C0", Slot = "15")]
	public bool Remove(T IFNDNLEGMFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4341F80", Offset = "0x4340580", VA = "0x184341F80", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3CF8F80", Offset = "0x3CF7580", VA = "0x183CF8F80", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4341E10", Offset = "0x4340410", VA = "0x184341E10", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4341EC0", Offset = "0x43404C0", VA = "0x184341EC0", Slot = "13")]
	public bool Contains(T IFNDNLEGMFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4341F20", Offset = "0x4340520", VA = "0x184341F20", Slot = "14")]
	public void CopyTo(T[] DKEEEGEFALD, int FFJKEOACOPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x4342010", Offset = "0x4340610", VA = "0x184342010", Slot = "6")]
	public int IndexOf(T IFNDNLEGMFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4342070", Offset = "0x4340670", VA = "0x184342070", Slot = "7")]
	public void Insert(int HGFDMIDEFHN, T IFNDNLEGMFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4342690", Offset = "0x4340C90", VA = "0x184342690", Slot = "8")]
	public void RemoveAt(int HGFDMIDEFHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4342990", Offset = "0x4340F90", VA = "0x184342990")]
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
			[Cpp2IlInjected.Address(RVA = "0x22A7940", Offset = "0x22A5F40", VA = "0x1822A7940")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6B42560", Offset = "0x6B40B60", VA = "0x186B42560")]
		public SerializedGuid([In] Guid GDCMEHKEAMI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6B42430", Offset = "0x6B40A30", VA = "0x186B42430")]
		public static SerializedGuid NIHICLBFHCK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6B423C0", Offset = "0x6B409C0", VA = "0x186B423C0")]
		public static SerializedGuid HPJNHCHFGPO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6B42350", Offset = "0x6B40950", VA = "0x186B42350")]
		public bool FKPHAIMPOJM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6B42530", Offset = "0x6B40B30", VA = "0x186B42530", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6B424B0", Offset = "0x6B40AB0", VA = "0x186B424B0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6B42280", Offset = "0x6B40880", VA = "0x186B42280", Slot = "7")]
		public bool Equals(SerializedGuid PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6B422C0", Offset = "0x6B408C0", VA = "0x186B422C0", Slot = "0")]
		public override bool Equals(object GHMNBJIOGAM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6B423B0", Offset = "0x6B409B0", VA = "0x186B423B0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6B42250", Offset = "0x6B40850", VA = "0x186B42250", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x6B40740", Offset = "0x6B3ED40", VA = "0x186B40740")]
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
		[Cpp2IlInjected.Address(RVA = "0x4367C10", Offset = "0x4366210", VA = "0x184367C10")]
		public KKFNDFEJKGA(long IILEEIMAJLF, int JBCEGJEOPCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4367C80", Offset = "0x4366280", VA = "0x184367C80")]
		public KKFNDFEJKGA(long IILEEIMAJLF, long BDKEMEBAINC, int JBCEGJEOPCE, int KOFEANFMMDD, bool FNKAPHIKFPN, string FEOHFNPGOIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4367B20", Offset = "0x4366120", VA = "0x184367B20")]
		public int HHPNFBLIGGI()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x4367B00", Offset = "0x4366100", VA = "0x184367B00")]
		public int GGDKJCEJALN(int HLGIIIELNEG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x4367AA0", Offset = "0x43660A0", VA = "0x184367AA0")]
		public double CDBHAPCELFI()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4367B70", Offset = "0x4366170", VA = "0x184367B70")]
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
			[Cpp2IlInjected.Address(RVA = "0x4341210", Offset = "0x433F810", VA = "0x184341210", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x3FDFEA0", Offset = "0x3FDE4A0", VA = "0x183FDFEA0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x436F090", Offset = "0x436D690", VA = "0x18436F090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IEnumerable<LANPOEPHMID> FGHOHFEKFPJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x43E3960", Offset = "0x43E1F60", VA = "0x1843E3960")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public KKFNDFEJKGA EGPKDPLODJE
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x43E3C00", Offset = "0x43E2200", VA = "0x1843E3C00")]
			[CompilerGenerated]
			get
			{
				return default(KKFNDFEJKGA);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x43E3C20", Offset = "0x43E2220", VA = "0x1843E3C20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x43E3C50", Offset = "0x43E2250", VA = "0x1843E3C50")]
		internal LANPOEPHMID(APPPBJLIGLH<TKey> LOIGOPGNFFM, TKey LFOBGDLOPID, CMICIECANPG FPPDOFKLJHI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x43E37A0", Offset = "0x43E1DA0", VA = "0x1843E37A0")]
		public LANPOEPHMID CGCNNCLCEDB(TKey LFOBGDLOPID, [Optional] CMICIECANPG? FLFKFIHJAOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2C02F00", Offset = "0x2C01500", VA = "0x182C02F00")]
		[AsyncStateMachine(typeof(KDMEHFJKFKP<>))]
		public Task<T> DDPCJPMECIM<T>(TKey LFOBGDLOPID, Func<LANPOEPHMID, Task<T>> OADEFMMDNAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x43E39A0", Offset = "0x43E1FA0", VA = "0x1843E39A0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x22AB1F0", Offset = "0x22A97F0", VA = "0x1822AB1F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DA6F60", Offset = "0x3DA5560", VA = "0x183DA6F60", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x22AB2E0", Offset = "0x22A98E0", VA = "0x1822AB2E0")]
		[DebuggerHidden]
		public AFOAHFMLFNE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3B9B4A0", Offset = "0x3B99AA0", VA = "0x183B9B4A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3DA6A80", Offset = "0x3DA5080", VA = "0x183DA6A80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3DA6A30", Offset = "0x3DA5030", VA = "0x183DA6A30")]
		private void LFOMCLLDDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3DA6F10", Offset = "0x3DA5510", VA = "0x183DA6F10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3DA6E30", Offset = "0x3DA5430", VA = "0x183DA6E30", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, KKFNDFEJKGA)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3BA38A0", Offset = "0x3BA1EA0", VA = "0x183BA38A0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x22AB1F0", Offset = "0x22A97F0", VA = "0x1822AB1F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x4912F30", Offset = "0x4911530", VA = "0x184912F30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x22AB2E0", Offset = "0x22A98E0", VA = "0x1822AB2E0")]
		[DebuggerHidden]
		public PEKHLELNMCF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x4912F90", Offset = "0x4911590", VA = "0x184912F90", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x49125B0", Offset = "0x4910BB0", VA = "0x1849125B0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x4912550", Offset = "0x4910B50", VA = "0x184912550")]
		private void LFOMCLLDDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x49124F0", Offset = "0x4910AF0", VA = "0x1849124F0")]
		private void IOFDBJCEJOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x4912EE0", Offset = "0x49114E0", VA = "0x184912EE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x4912DA0", Offset = "0x49113A0", VA = "0x184912DA0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, KKFNDFEJKGA)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4912EA0", Offset = "0x49114A0", VA = "0x184912EA0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8879A0", Offset = "0x885FA0", VA = "0x1808879A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8868B0", Offset = "0x884EB0", VA = "0x1808868B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3F26C10", Offset = "0x3F25210", VA = "0x183F26C10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3F26E10", Offset = "0x3F25410", VA = "0x183F26E10")]
	public APPPBJLIGLH(TKey PEKHBFGPIMB, CMICIECANPG FPPDOFKLJHI, [Optional] int? JBCEGJEOPCE, [Optional][CanBeNull] Stopwatch GNMHDDIJNJL, [Optional] Action<TKey, KKFNDFEJKGA, CMICIECANPG> MMEAKLLGGBA, [Optional] Action<TKey, KKFNDFEJKGA, CMICIECANPG> LGNFPADIELM, [Optional] Action<APPPBJLIGLH<TKey>, CMICIECANPG> FHNGPEFKDCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3F26AB0", Offset = "0x3F250B0", VA = "0x183F26AB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3F26D60", Offset = "0x3F25360", VA = "0x183F26D60")]
	[IteratorStateMachine(typeof(APPPBJLIGLH<>.AFOAHFMLFNE))]
	public IEnumerable<(TKey, List<TKey>, KKFNDFEJKGA)> OKIIAADJKFG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3F26C70", Offset = "0x3F25270", VA = "0x183F26C70")]
	[IteratorStateMachine(typeof(APPPBJLIGLH<>.PEKHLELNMCF))]
	private IEnumerable<(TKey, List<TKey>, KKFNDFEJKGA)> OKIIAADJKFG(List<TKey> BICLBBDNKCN, LANPOEPHMID FLLPMEOKLAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3F26B90", Offset = "0x3F25190", VA = "0x183F26B90")]
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
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x440FA40", Offset = "0x440E040", VA = "0x18440FA40")]
	private static string BPCDFCLLONM(TKey LFOBGDLOPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x440FA80", Offset = "0x440E080", VA = "0x18440FA80", Slot = "4")]
	public override string FDHJHJEEKPL(APPPBJLIGLH<TKey> LOIGOPGNFFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x440FB70", Offset = "0x440E170", VA = "0x18440FB70")]
	public string FDHJHJEEKPL(APPPBJLIGLH<TKey> LOIGOPGNFFM, [NotNull] JFDIMHEGICI GBBOJDEPMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string LGAMHHKIGLE(APPPBJLIGLH<TKey> LOIGOPGNFFM, [NotNull] JFDIMHEGICI GBBOJDEPMEE);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x39870C0", Offset = "0x39856C0", VA = "0x1839870C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3E8C060", Offset = "0x3E8A660", VA = "0x183E8C060")]
	private static string BPCDFCLLONM(TKey LFOBGDLOPID)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3E8CCA0", Offset = "0x3E8B2A0", VA = "0x183E8CCA0")]
	public HNLCIMFLOIN(string DJKCIEHKENM = "F2", double PGDLOGJOJCF = double.MaxValue, bool JOKOEEGCMOL = false, int CDGDBILAFCH = int.MaxValue, [Optional] ISet<string> OHDPMLCOPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3E8C180", Offset = "0x3E8A780", VA = "0x183E8C180", Slot = "4")]
	public override Dictionary<string, string> FDHJHJEEKPL(APPPBJLIGLH<TKey> LOIGOPGNFFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3E8C0A0", Offset = "0x3E8A6A0", VA = "0x183E8C0A0")]
	private bool ELHFHLLOCJI(string GBDCKEINLDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3E8C270", Offset = "0x3E8A870", VA = "0x183E8C270")]
	public Dictionary<string, string> FDHJHJEEKPL(APPPBJLIGLH<TKey> LOIGOPGNFFM, OEBBOIDHGAD GBBOJDEPMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3E8C8C0", Offset = "0x3E8AEC0", VA = "0x183E8C8C0")]
	private string OHKMLHNKGBG(StringBuilder DOPMAKHHIHE, List<TKey> ENKCPDLGEFM, OEBBOIDHGAD GBBOJDEPMEE, bool NHHBBPCBFFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3E8CB40", Offset = "0x3E8B140", VA = "0x183E8CB40")]
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
	[Cpp2IlInjected.Address(RVA = "0x3D8F660", Offset = "0x3D8DC60", VA = "0x183D8F660")]
	private ADEDJGCBPJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x3D8E6D0", Offset = "0x3D8CCD0", VA = "0x183D8E6D0", Slot = "5")]
	protected override string LGAMHHKIGLE(APPPBJLIGLH<TKey> LOIGOPGNFFM, JFDIMHEGICI GBBOJDEPMEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x3D8E5C0", Offset = "0x3D8CBC0", VA = "0x183D8E5C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public NDBIEDMIIFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6B406B0", Offset = "0x6B3ECB0", VA = "0x186B406B0")]
		internal void FGPCFINPCOE(APPPBJLIGLH<string> timer, CMICIECANPG log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6B40D00", Offset = "0x6B3F300", VA = "0x186B40D00")]
	public PAGPABCOPIF(CMICIECANPG FPPDOFKLJHI, [Optional] string FOKBPMBLGEK, [Optional] int? JBCEGJEOPCE, [Optional] Stopwatch GNMHDDIJNJL, [Optional] Action<string, KKFNDFEJKGA, CMICIECANPG> MMEAKLLGGBA, [Optional] Action<string, KKFNDFEJKGA, CMICIECANPG> LGNFPADIELM, [Optional] Action<PAGPABCOPIF, CMICIECANPG> FHNGPEFKDCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6B40C40", Offset = "0x6B3F240", VA = "0x186B40C40")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B3CF50", Offset = "0x6B3B550", VA = "0x186B3CF50")]
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
			[Cpp2IlInjected.Address(RVA = "0xB3E730", Offset = "0xB3CD30", VA = "0x180B3E730", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6B3D040", Offset = "0x6B3B640", VA = "0x186B3D040")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B3E8C0", Offset = "0x6B3CEC0", VA = "0x186B3E8C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x2D6D960", Offset = "0x2D6BF60", VA = "0x182D6D960")]
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
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x886FC0", Offset = "0x8855C0", VA = "0x180886FC0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x4472900", Offset = "0x4470F00", VA = "0x184472900")]
		public LPEHNBLMJBH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x8879F0", Offset = "0x885FF0", VA = "0x1808879F0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x887AA0", Offset = "0x8860A0", VA = "0x180887AA0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x3DB28E0", Offset = "0x3DB0EE0", VA = "0x183DB28E0")]
		public AIMHNLBGKGA(T GOEOMDMENPE, Action<T>? OMALCONAAEJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x3DB2880", Offset = "0x3DB0E80", VA = "0x183DB2880", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x886FC0", Offset = "0x8855C0", VA = "0x180886FC0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x4708370", Offset = "0x4706970", VA = "0x184708370")]
		public NFAGLMPGONH(Exception FKDHFMCKMKA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x3F4ECA0", Offset = "0x3F4D2A0", VA = "0x183F4ECA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x3F4F700", Offset = "0x3F4DD00", VA = "0x183F4F700", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x5021330", Offset = "0x501F930", VA = "0x185021330", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x5021810", Offset = "0x501FE10", VA = "0x185021810", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x886FC0", Offset = "0x8855C0", VA = "0x180886FC0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8860F0", VA = "0x180887AF0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x468B9C0", Offset = "0x4689FC0", VA = "0x18468B9C0")]
		public MDABOPGCMOH(Task<POLPOFEBNLM<T>> KECDGIGMBNG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x468B5A0", Offset = "0x4689BA0", VA = "0x18468B5A0", Slot = "10")]
		protected override void DNDPHLKJOEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x468B6C0", Offset = "0x4689CC0", VA = "0x18468B6C0")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(MDABOPGCMOH<>.ICLPEPCIHAK))]
		internal static Task<T> IBBMBJAJIJJ(Task<POLPOFEBNLM<T>> KECDGIGMBNG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x468B3C0", Offset = "0x46899C0", VA = "0x18468B3C0")]
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
			[Cpp2IlInjected.Address(RVA = "0x3DF3C40", Offset = "0x3DF2240", VA = "0x183DF3C40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x3DF4300", Offset = "0x3DF2900", VA = "0x183DF4300", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x886FC0", Offset = "0x8855C0", VA = "0x180886FC0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8860F0", VA = "0x180887AF0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x48291B0", Offset = "0x48277B0", VA = "0x1848291B0")]
		public OJKCJCMEKEL(POLPOFEBNLM<TIn> KNACICKDHCD, Func<TIn, TOut> FECIBPEMOEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x4828DF0", Offset = "0x48273F0", VA = "0x184828DF0", Slot = "10")]
		protected override void DNDPHLKJOEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x4829020", Offset = "0x4827620", VA = "0x184829020")]
		[AsyncStateMachine(typeof(OJKCJCMEKEL<, >.GKKLMIBOIOH))]
		[CompilerGenerated]
		internal static Task<TOut> OEHHEHBHEMC(Task<TIn> DDFCFEFDKMO, Func<TIn, TOut> FECIBPEMOEG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2B1A6D0", Offset = "0x2B18CD0", VA = "0x182B1A6D0")]
	public static POLPOFEBNLM<T> PGEMABEMKPO<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x2B1A580", Offset = "0x2B18B80", VA = "0x182B1A580")]
	public static POLPOFEBNLM<T> EOJAFDGBAKJ<T>(T POBDLJBBBCI, [Optional] Action<T>? OMALCONAAEJ) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2A0BE40", Offset = "0x2A0A440", VA = "0x182A0BE40")]
	public static POLPOFEBNLM<T> JJGEEGFFNOO<T>(Exception FKDHFMCKMKA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x2A0BE40", Offset = "0x2A0A440", VA = "0x182A0BE40")]
	public static POLPOFEBNLM<T> GGEBIPHJJNE<T>(Task<POLPOFEBNLM<T>> KECDGIGMBNG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2B1A630", Offset = "0x2B18C30", VA = "0x182B1A630")]
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
		[Cpp2IlInjected.Address(RVA = "0xD0BF00", Offset = "0xD0A500", VA = "0x180D0BF00", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x3FB8B20", Offset = "0x3FB7120", VA = "0x183FB8B20")]
	public IGOJEPKBAMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x3FB86F0", Offset = "0x3FB6CF0", VA = "0x183FB86F0", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x36A2820", Offset = "0x36A0E20", VA = "0x1836A2820", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x36A2D90", Offset = "0x36A1390", VA = "0x1836A2D90", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public JBNOHKNIPGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x418FC20", Offset = "0x418E220", VA = "0x18418FC20")]
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
		[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public override JAGIEECCCMP<T> BFMCIAAECGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x886FC0", Offset = "0x8855C0", VA = "0x180886FC0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x3E937D0", Offset = "0x3E91DD0", VA = "0x183E937D0")]
	protected HPIKJDJNNFG(TTask KECDGIGMBNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3E93780", Offset = "0x3E91D80", VA = "0x183E93780", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x41C5770", Offset = "0x41C3D70", VA = "0x1841C5770", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public override JAGIEECCCMP<T> BFMCIAAECGF
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x886FC0", Offset = "0x8855C0", VA = "0x180886FC0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x41C57D0", Offset = "0x41C3DD0", VA = "0x1841C57D0")]
	public JIKOCDGFHBC(EMDFPNDLNED<Task<T>> MBNJBFDFLLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x41C5750", Offset = "0x41C3D50", VA = "0x1841C5750", Slot = "10")]
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
	[Cpp2IlInjected.Address(RVA = "0x6B40460", Offset = "0x6B3EA60", VA = "0x186B40460")]
	public static int MAJJILKDDFK(this AJJIDJJMECL NNNIELGKJFB, IncrementalHash DOAOBIHCNJF, byte[] NILJPNJFOGB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6B40400", Offset = "0x6B3EA00", VA = "0x186B40400")]
	public static bool LLJMKODPGIE([CanBeNull] this AJJIDJJMECL NNNIELGKJFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6B400F0", Offset = "0x6B3E6F0", VA = "0x186B400F0")]
	public static bool LLJMKODPGIE([CanBeNull] this AJJIDJJMECL NNNIELGKJFB, [Out] string ENDMINEHNJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6B3FDC0", Offset = "0x6B3E3C0", VA = "0x186B3FDC0")]
	public static bool LLJMKODPGIE([CanBeNull] this AJJIDJJMECL NNNIELGKJFB, IncrementalHash DOAOBIHCNJF, byte[] NILJPNJFOGB, [Out] string ENDMINEHNJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6B404E0", Offset = "0x6B3EAE0", VA = "0x186B404E0")]
	private static bool PIJNLACCFBB(byte[] NAHOMKMFEKM, Span<byte> MEPEBHEMJNG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class OPEOOEOEOMB
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6B40A90", Offset = "0x6B3F090", VA = "0x186B40A90")]
	public static int NHDPIFJHAND(HashAlgorithmName PJNHBFHPDMG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6B40830", Offset = "0x6B3EE30", VA = "0x186B40830")]
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
	[Cpp2IlInjected.Address(RVA = "0x2A10A80", Offset = "0x2A0F080", VA = "0x182A10A80")]
	public static void GHPOJPMNAMB<T>(this IncrementalHash NFHJCPDPIHO, [CanBeNull] T INEJDODHNGG) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2A109F0", Offset = "0x2A0EFF0", VA = "0x182A109F0")]
	public static void BIHAKOFHEBC<T>(this IncrementalHash NFHJCPDPIHO, [CanBeNull] T CCDFFEJNNAO) where T : HOLEDMBJCDB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x2A10B40", Offset = "0x2A0F140", VA = "0x182A10B40")]
	public static void LJMMMBAIIAM<T>(this IncrementalHash NFHJCPDPIHO, [CanBeNull] IList<T> FPJPKKJJECI) where T : HOLEDMBJCDB
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6B3D830", Offset = "0x6B3BE30", VA = "0x186B3D830")]
	private static bool DOBHLACPNFN([CanBeNull] HOLEDMBJCDB CCDFFEJNNAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6B3D8C0", Offset = "0x6B3BEC0", VA = "0x186B3D8C0")]
	public static void EOMIIDPELLG(this IncrementalHash DOAOBIHCNJF, string? CHADOCHAGBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6B3D0F0", Offset = "0x6B3B6F0", VA = "0x186B3D0F0")]
	public static void BCBMOJOHFGP(this IncrementalHash DOAOBIHCNJF, long MOOBPOCJAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6B3D600", Offset = "0x6B3BC00", VA = "0x186B3D600")]
	public static void DKJMCIFDPPP(this IncrementalHash DOAOBIHCNJF, int OGMNEECDOAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6B3D2C0", Offset = "0x6B3B8C0", VA = "0x186B3D2C0")]
	public static void BLENKHKECHL(this IncrementalHash DOAOBIHCNJF, short ONNDLMDOHBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6B3D4F0", Offset = "0x6B3BAF0", VA = "0x186B3D4F0")]
	public static void BOFGDBFOCMB(this IncrementalHash DOAOBIHCNJF, byte NKFCIOIPCIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6B3DCC0", Offset = "0x6B3C2C0", VA = "0x186B3DCC0")]
	public static void IDJKLMGMNKO(this IncrementalHash DOAOBIHCNJF, bool CKBBOFECJHM, bool BKIGNOBMMBC = false, bool KAPOAJNPDLH = false, bool LENPILFPBLD = false, bool CFMIFKGIMKC = false, bool PODCCKJLOPK = false, bool NNOFOCKDDGC = false, bool LKNODKAJBHP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x2A11060", Offset = "0x2A0F660", VA = "0x182A11060")]
	public static void OONDDMMMPMP<T>(this IncrementalHash DOAOBIHCNJF, T HBEFBGGFFKD) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6B3D090", Offset = "0x6B3B690", VA = "0x186B3D090")]
	public static void ANFMIDNKIND(this IncrementalHash DOAOBIHCNJF, float OGGAECCKLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6B3DE30", Offset = "0x6B3C430", VA = "0x186B3DE30")]
	public static void MAIGBICNDCG(this IncrementalHash DOAOBIHCNJF, ulong FEGHPJBPOKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6B3D7D0", Offset = "0x6B3BDD0", VA = "0x186B3D7D0")]
	public static void DMEAHLAEJIG(this IncrementalHash DOAOBIHCNJF, uint MANJNONNEGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6B3D490", Offset = "0x6B3BA90", VA = "0x186B3D490")]
	public static void BLJDHGGFDBA(this IncrementalHash DOAOBIHCNJF, ushort AOLNJALFCME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6B3DE90", Offset = "0x6B3C490", VA = "0x186B3DE90")]
	public static void NCHGNABOFLP(this IncrementalHash DOAOBIHCNJF, Vector3 DDGLAMCJPEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class PAEAPHMAMID : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6B40BE0", Offset = "0x6B3F1E0", VA = "0x186B40BE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xF42D50", Offset = "0xF41350", VA = "0x180F42D50")]
		public KNBLDIMCGPA(int OCBNPLFNECE, TClaimant AFKODHGKCIE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x436C0D0", Offset = "0x436A6D0", VA = "0x18436C0D0")]
		public bool MFOGLFCCAEH([In] KNBLDIMCGPA PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x436C0B0", Offset = "0x436A6B0", VA = "0x18436C0B0")]
		public bool BEMLNMPGNPF([In] KNBLDIMCGPA PLNBHPCFEOK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x436C0C0", Offset = "0x436A6C0", VA = "0x18436C0C0", Slot = "4")]
		public int CompareTo(KNBLDIMCGPA PLNBHPCFEOK)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x436C130", Offset = "0x436A730", VA = "0x18436C130", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x965BF0", Offset = "0x9641F0", VA = "0x180965BF0")]
		[DebuggerHidden]
		public DBEELMNFICP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x5A3EAC0", Offset = "0x5A3D0C0", VA = "0x185A3EAC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x5A3ECA0", Offset = "0x5A3D2A0", VA = "0x185A3ECA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x5A3EBA0", Offset = "0x5A3D1A0", VA = "0x185A3EBA0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3B9CAB0", Offset = "0x3B9B0B0", VA = "0x183B9CAB0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x41C38B0", Offset = "0x41C1EB0", VA = "0x1841C38B0")]
	public JHNCEONGBEP(NFHMJADPKEP COEMAIGHGPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x41C2FF0", Offset = "0x41C15F0", VA = "0x1841C2FF0")]
	public void IHPBHCHFJBO(TNode KOHLOCENPAH, TNode LEEMAEKICLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x41C32F0", Offset = "0x41C18F0", VA = "0x1841C32F0")]
	public void LOMCDHBPBJJ(TClaimant AFKODHGKCIE, TNode JANIPFKNJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x41C24C0", Offset = "0x41C0AC0", VA = "0x1841C24C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x41C3220", Offset = "0x41C1820", VA = "0x1841C3220")]
	private void LOBGEDBENPB(TClaimant AFKODHGKCIE, TNode KALPDEGIILK, TNode JANIPFKNJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x41C3660", Offset = "0x41C1C60", VA = "0x1841C3660")]
	private int NLNOHNMBKJB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x41C2C90", Offset = "0x41C1290", VA = "0x1841C2C90")]
	private void HMLGFEJMOEI(TClaimant AFKODHGKCIE, TNode LIIEMNCNAGO, TNode KJIBJMLOEOL, int LNHGADCHIPG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x41C1CC0", Offset = "0x41C02C0", VA = "0x1841C1CC0")]
	private void AMAOHBABINE(KNBLDIMCGPA DFDHIPOMCDE, EHOEPJIHAAF GANDHMGOAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x41C20A0", Offset = "0x41C06A0", VA = "0x1841C20A0")]
	private void CNJHPFHKOBE(TClaimant AFKODHGKCIE, TNode LIIEMNCNAGO, TNode KJIBJMLOEOL, int LNHGADCHIPG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x41C2B50", Offset = "0x41C1150", VA = "0x1841C2B50")]
	private void HIFHNHANMFA(KNBLDIMCGPA DFDHIPOMCDE, TNode KOHLOCENPAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x41C1DA0", Offset = "0x41C03A0", VA = "0x1841C1DA0")]
	private void BDOEBAGAMGL(KNBLDIMCGPA DFDHIPOMCDE, EHOEPJIHAAF GANDHMGOAJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x41C30C0", Offset = "0x41C16C0", VA = "0x1841C30C0")]
	private void LKOJBLEGLAH(EHOEPJIHAAF GANDHMGOAJC, bool MDKHHIMOIJF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x41C26E0", Offset = "0x41C0CE0", VA = "0x1841C26E0")]
	private void FEJNIBCIJFL(EHOEPJIHAAF GANDHMGOAJC, TNode LEEMAEKICLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x41C2A50", Offset = "0x41C1050", VA = "0x1841C2A50")]
	[IteratorStateMachine(typeof(JHNCEONGBEP<, >.DBEELMNFICP))]
	private IEnumerable<TNode> GBBNFEDKJEK(TNode LIIEMNCNAGO, TNode KJIBJMLOEOL, bool HBFOLNPIOBF = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x41C23A0", Offset = "0x41C09A0", VA = "0x1841C23A0")]
	private EHOEPJIHAAF DFNCPMNFPMK(TNode KOHLOCENPAH, TNode LDJCBIBELIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x41C1F10", Offset = "0x41C0510", VA = "0x1841C1F10")]
	private EHOEPJIHAAF CCGHNHLHJGA(TNode KOHLOCENPAH, TNode LDJCBIBELIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x41C3490", Offset = "0x41C1A90", VA = "0x1841C3490")]
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
			[Cpp2IlInjected.Address(RVA = "0x3996970", Offset = "0x3994F70", VA = "0x183996970", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public JALGICNCACK JINHOCMBIBA
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x46B6B50", Offset = "0x46B5150", VA = "0x1846B6B50", Slot = "4")]
			get
			{
				return default(JALGICNCACK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x46B6A60", Offset = "0x46B5060", VA = "0x1846B6A60")]
		public MNOADCFJMPJ(KCEBOEMBPHC<T> MECAOIIIDEC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x46B69E0", Offset = "0x46B4FE0", VA = "0x1846B69E0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x39EC520", Offset = "0x39EAB20", VA = "0x1839EC520", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xAD7B20", Offset = "0xAD6120", VA = "0x180AD7B20", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C59A0", Offset = "0x8C3FA0", VA = "0x1808C59A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8C50B0", Offset = "0x8C36B0", VA = "0x1808C50B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public int MNNLJFACLOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x36B5100", Offset = "0x36B3700", VA = "0x1836B5100")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x433B7C0", Offset = "0x4339DC0", VA = "0x18433B7C0")]
	public KCEBOEMBPHC(int HCAOLDLEJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x433B380", Offset = "0x4339980", VA = "0x18433B380")]
	public KCEBOEMBPHC(JALGICNCACK[] HOHGOGBAPKC, bool BLHNHDMGDFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x433A060", Offset = "0x4338660", VA = "0x18433A060")]
	public int CKPBJHKBAJE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x433A130", Offset = "0x4338730", VA = "0x18433A130")]
	private int ELPLKODBEIK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x433A030", Offset = "0x4338630", VA = "0x18433A030", Slot = "6")]
	protected virtual uint AHNPMMOMINN(uint DOAOBIHCNJF, T KLABJGGMBGH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x433A570", Offset = "0x4338B70", VA = "0x18433A570")]
	public bool GJKKBKFNGDO(T KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x433AD80", Offset = "0x4339380", VA = "0x18433AD80")]
	public int LOAMKNNONEE(T KLABJGGMBGH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x433A6D0", Offset = "0x4338CD0", VA = "0x18433A6D0")]
	public T JHMOEGIAFJJ(int HGFDMIDEFHN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x433A790", Offset = "0x4338D90", VA = "0x18433A790")]
	public bool KEADIHLHCFE(T KLABJGGMBGH, bool HIBAMFKGLNE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x433A800", Offset = "0x4338E00", VA = "0x18433A800")]
	public bool KEADIHLHCFE(T KLABJGGMBGH, int HGFDMIDEFHN, bool HIBAMFKGLNE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x433A630", Offset = "0x4338C30", VA = "0x18433A630")]
	private int ILEHHIKGAFI(int NBPJLJIBBHP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x433AE90", Offset = "0x4339490", VA = "0x18433AE90", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x433AE90", Offset = "0x4339490", VA = "0x18433AE90", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x46B78C0", Offset = "0x46B5EC0", VA = "0x1846B78C0")]
	public static MOGMOHJBDLD<T> DIGMCDIHONJ(int HCAOLDLEJCN = 0, int OJHJEIKFFKA = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x46B7E60", Offset = "0x46B6460", VA = "0x1846B7E60")]
	public static MOGMOHJBDLD<T> MDJBKCCMJEO(int HCAOLDLEJCN = 0, int OJHJEIKFFKA = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x46B8180", Offset = "0x46B6780", VA = "0x1846B8180")]
	public MOGMOHJBDLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x46B7F60", Offset = "0x46B6560", VA = "0x1846B7F60")]
	public MOGMOHJBDLD(int HCAOLDLEJCN, int OJHJEIKFFKA = int.MaxValue, bool MFFGHHEMOJM = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x46B7CA0", Offset = "0x46B62A0", VA = "0x1846B7CA0")]
	public T KINKNPKFCGM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x46B77E0", Offset = "0x46B5DE0", VA = "0x1846B77E0")]
	public void CJCAMEPPGCI(T KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x46B7BA0", Offset = "0x46B61A0", VA = "0x1846B7BA0")]
	private void FIDANHBJPBM(T KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x46B7B50", Offset = "0x46B6150", VA = "0x1846B7B50")]
	private void FDENEEOHLOK(T KLABJGGMBGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x46B79C0", Offset = "0x46B5FC0", VA = "0x1846B79C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x46B75E0", Offset = "0x46B5BE0", VA = "0x1846B75E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x887050", Offset = "0x885650", VA = "0x180887050", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x887030", Offset = "0x885630", VA = "0x180887030", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x3D206A0", Offset = "0x3D1ECA0", VA = "0x183D206A0")]
	public bool GMBIHPHNNPE(T KLABJGGMBGH, int OCBNPLFNECE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x3D205F0", Offset = "0x3D1EBF0", VA = "0x183D205F0")]
	public bool BDCMENKNKIJ(int OCBNPLFNECE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x3D20A00", Offset = "0x3D1F000", VA = "0x183D20A00")]
	public T OKMEMNNNNCN(int HLCFDIFFPHA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x3D208C0", Offset = "0x3D1EEC0", VA = "0x183D208C0")]
	private bool IMFFCFJEHBM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x3D209A0", Offset = "0x3D1EFA0", VA = "0x183D209A0")]
	public bool LAFFHOKCOBI(int OCBNPLFNECE, [Out] T KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x3D20E10", Offset = "0x3D1F410", VA = "0x183D20E10")]
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
		[Cpp2IlInjected.Address(RVA = "0x36B5100", Offset = "0x36B3700", VA = "0x1836B5100")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x54C4C90", Offset = "0x54C3290", VA = "0x1854C4C90")]
	public bool FEAHPDAAGAE(T KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x54C4A50", Offset = "0x54C3050", VA = "0x1854C4A50")]
	public void FABNFHGMHGJ(T KLABJGGMBGH, int OCBNPLFNECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x54C4EC0", Offset = "0x54C34C0", VA = "0x1854C4EC0")]
	public bool MBEEDABKNGP(T KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x54C5260", Offset = "0x54C3860", VA = "0x1854C5260")]
	public void MPAAPCHGDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x54C5310", Offset = "0x54C3910", VA = "0x1854C5310")]
	public T PFNAINPPKEI()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x54C47F0", Offset = "0x54C2DF0", VA = "0x1854C47F0")]
	protected void BJBEDCNPEPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x54C5450", Offset = "0x54C3A50", VA = "0x1854C5450")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B40F80", Offset = "0x6B3F580", VA = "0x186B40F80")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x6B41250", Offset = "0x6B3F850", VA = "0x186B41250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x6B41160", Offset = "0x6B3F760", VA = "0x186B41160")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x6B40ED0", Offset = "0x6B3F4D0", VA = "0x186B40ED0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x6B411A0", Offset = "0x6B3F7A0", VA = "0x186B411A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x6B410B0", Offset = "0x6B3F6B0", VA = "0x186B410B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x6B40E50", Offset = "0x6B3F450", VA = "0x186B40E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x4B04EB0", Offset = "0x4B034B0", VA = "0x184B04EB0", Slot = "4")]
		public virtual T HOCGGHEFDPB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8841B0", Offset = "0x8827B0", VA = "0x1808841B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8841C0", Offset = "0x8827C0", VA = "0x1808841C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Vector2 GGDNPJPPOBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xEBC6F0", Offset = "0xEBACF0", VA = "0x180EBC6F0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x11DE8B0", Offset = "0x11DCEB0", VA = "0x1811DE8B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	private Vector2 PILAFGHCIIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x1211180", Offset = "0x120F780", VA = "0x181211180")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Vector2 PKPBFOEMNNF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6B3ED40", Offset = "0x6B3D340", VA = "0x186B3ED40")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8879C0", Offset = "0x885FC0", VA = "0x1808879C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int CNJKHJEDDNP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8944C0", Offset = "0x892AC0", VA = "0x1808944C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x893F70", Offset = "0x892570", VA = "0x180893F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6B3FD00", Offset = "0x6B3E300", VA = "0x186B3FD00")]
	public KGCNOMJLKLJ(Bounds FDEEFKKBMPN, Vector2[] LAGMOMGHKBF, int MBIGONMGNOM, byte NBPJLJIBBHP, float BOLJBNJEECG = 0f, [Optional] MOGMOHJBDLD<DFKJJEKDPAN> OAPHKHOMFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6B3F220", Offset = "0x6B3D820", VA = "0x186B3F220")]
	public void KLPKPLEDCGC(Bounds FDEEFKKBMPN, Vector2[] LAGMOMGHKBF, int MBIGONMGNOM, byte NBPJLJIBBHP, float BOLJBNJEECG = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6B3F6C0", Offset = "0x6B3DCC0", VA = "0x186B3F6C0")]
	public DFKJJEKDPAN NHPDLKLOJNH(byte HGFDMIDEFHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6B3F150", Offset = "0x6B3D750", VA = "0x186B3F150")]
	public void JKOECOBIBKO(Vector3 LEELMECKGCG, float HOIEOMDDOBM, float PHGGFLDFJLC, List<byte> KOAIFCFGEPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6B3F130", Offset = "0x6B3D730", VA = "0x186B3F130")]
	public void INLLELBJEAI(DFKJJEKDPAN.NLOJICGBAGP KPGINFEFIJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6B3ED60", Offset = "0x6B3D360", VA = "0x186B3ED60")]
	public static int CMCCJCDGBKD(Vector2[] LAGMOMGHKBF, int MBIGONMGNOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6B3F720", Offset = "0x6B3DD20", VA = "0x186B3F720")]
	private DFKJJEKDPAN OBAKEMNMDNC(byte HGFDMIDEFHN, DFKJJEKDPAN.CIBPKACHPPI HMOEACGMNFA, DFKJJEKDPAN LDJCBIBELIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6B3F950", Offset = "0x6B3DF50", VA = "0x186B3F950")]
	private void OFLLPNOLCIO(DFKJJEKDPAN LDJCBIBELIM, Vector2[] LAGMOMGHKBF, int IBICPGCHFHL, int DBGFCEHDBML, int JGGICKNEINA, int ECMIPJACOKK, float BOLJBNJEECG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6B3EE50", Offset = "0x6B3D450", VA = "0x186B3EE50")]
	private void DPFCBDPIBEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6B3F070", Offset = "0x6B3D670", VA = "0x186B3F070", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6B3F0D0", Offset = "0x6B3D6D0", VA = "0x186B3F0D0", Slot = "1")]
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
	[Cpp2IlInjected.Address(RVA = "0x6B3E8A0", Offset = "0x6B3CEA0", VA = "0x186B3E8A0")]
	public DFKJJEKDPAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6B3E4A0", Offset = "0x6B3CAA0", VA = "0x186B3E4A0")]
	public void BHLBCINICIP(DFKJJEKDPAN JGEMMJEFOMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350")]
	public void INLLELBJEAI(int GIMJBOMHNKG, NLOJICGBAGP KPGINFEFIJB, int DKIIACHLPCD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x6B3E5E0", Offset = "0x6B3CBE0", VA = "0x186B3E5E0")]
	public void JKOECOBIBKO(List<byte> KOAIFCFGEPC, Vector3 LEELMECKGCG, float HOIEOMDDOBM, float PHGGFLDFJLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x6B3E870", Offset = "0x6B3CE70", VA = "0x186B3E870")]
	public bool MOGBNCIIENJ(Vector3 IFDMLAIJAHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x6B3E840", Offset = "0x6B3CE40", VA = "0x186B3E840")]
	public bool KLJDNJIKBFN(Vector3 IFDMLAIJAHF, float DNIMIBKBAMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6B3E410", Offset = "0x6B3CA10", VA = "0x186B3E410")]
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
			[Cpp2IlInjected.Address(RVA = "0x43DF710", Offset = "0x43DDD10", VA = "0x1843DF710")]
			public CLPMIGINGNH(List<Component> OLAPNOFMNPM, bool FGPBNNBIOHI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x56B4550", Offset = "0x56B2B50", VA = "0x1856B4550")]
			public OOODEIPHFMH<T> HNHGFOAAHAF()
			{
				return default(OOODEIPHFMH<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x56B45C0", Offset = "0x56B2BC0", VA = "0x1856B45C0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x56B45C0", Offset = "0x56B2BC0", VA = "0x1856B45C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x4839B70", Offset = "0x4838170", VA = "0x184839B70", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000061")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600021B")]
				[Cpp2IlInjected.Address(RVA = "0x4839B00", Offset = "0x4838100", VA = "0x184839B00", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x4839B40", Offset = "0x4838140", VA = "0x184839B40")]
			public OOODEIPHFMH(List<Component> OLAPNOFMNPM, bool FGPBNNBIOHI)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x4839A40", Offset = "0x4838040", VA = "0x184839A40", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x4839A50", Offset = "0x4838050", VA = "0x184839A50", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x393FBF0", Offset = "0x393E1F0", VA = "0x18393FBF0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B42C70", Offset = "0x6B41270", VA = "0x186B42C70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6B42620", Offset = "0x6B40C20", VA = "0x186B42620")]
		private void AIFHKOLJDOL(GameObject MDAHHDPNOMM, bool LENLJCDCMCG = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x6B42590", Offset = "0x6B40B90", VA = "0x186B42590")]
		public static void AIFHKOLJDOL(GameObject MDAHHDPNOMM, ToolHierarchyCache DNNINLMOCPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6B42810", Offset = "0x6B40E10", VA = "0x186B42810")]
		public void GBEDMPFBKNA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x2FC0860", Offset = "0x2FBEE60", VA = "0x182FC0860")]
		public void NBIFNCPJJJO<T>(Action<T> PMCMEAHOBEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x2FC07C0", Offset = "0x2FBEDC0", VA = "0x182FC07C0")]
		public T EAFLALGLEHA<T>(bool FGPBNNBIOHI = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x2FC0AA0", Offset = "0x2FBF0A0", VA = "0x182FC0AA0")]
		public CLPMIGINGNH<T> NKNEAKIGKMJ<T>(bool FGPBNNBIOHI = false) where T : class
		{
			return default(CLPMIGINGNH<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6B42820", Offset = "0x6B40E20", VA = "0x186B42820")]
		public List<Component> GFPOMHEHGKC(Type JLAAKHANEHC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x6B42790", Offset = "0x6B40D90", VA = "0x186B42790", Slot = "4")]
		public bool Equals(ToolHierarchyCache NCPIGLMANIM, ToolHierarchyCache DJBPOPBDKAJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x6B42B70", Offset = "0x6B41170", VA = "0x186B42B70", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x41C5770", Offset = "0x41C3D70", VA = "0x1841C5770")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public T FBNLOBKJFGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x4401AC0", Offset = "0x44000C0", VA = "0x184401AC0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public T OBJLAOIPCAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x44019D0", Offset = "0x43FFFD0", VA = "0x1844019D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public T MPEAGFGEPEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x4401CE0", Offset = "0x44002E0", VA = "0x184401CE0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x4401E30", Offset = "0x4400430", VA = "0x184401E30")]
	public LJOOMPALBJA(int HCAOLDLEJCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x44016F0", Offset = "0x43FFCF0", VA = "0x1844016F0")]
	public void FABNFHGMHGJ(T DHCIPDPNOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x4401D60", Offset = "0x4400360", VA = "0x184401D60")]
	public void MPAAPCHGDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x44015F0", Offset = "0x43FFBF0", VA = "0x1844015F0")]
	public void DLCJCGPMNAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x4401DC0", Offset = "0x44003C0", VA = "0x184401DC0")]
	public void NLDHJALJBBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x44015E0", Offset = "0x43FFBE0", VA = "0x1844015E0")]
	public void AOPLOKJADDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x4401540", Offset = "0x43FFB40", VA = "0x184401540")]
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
		[Cpp2IlInjected.Address(RVA = "0xA41670", Offset = "0xA3FC70", VA = "0x180A41670", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x3965DE0", Offset = "0x39643E0", VA = "0x183965DE0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public bool LLEHPMPCDLE
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x3965F40", Offset = "0x3964540", VA = "0x183965F40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public object NAGHLKNCOEB
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8879A0", Offset = "0x885FA0", VA = "0x1808879A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x88B6A0", Offset = "0x889CA0", VA = "0x18088B6A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x3966820", Offset = "0x3964E20", VA = "0x183966820")]
	public bool GMBIHPHNNPE(T KLABJGGMBGH, object FLLNLBHFENG, int OCBNPLFNECE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x3965E80", Offset = "0x3964480", VA = "0x183965E80")]
	public bool BDCMENKNKIJ(object FLLNLBHFENG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x3969E30", Offset = "0x3968430", VA = "0x183969E30")]
	public bool LAFFHOKCOBI(object FLLNLBHFENG, [Out] T KLABJGGMBGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x396A430", Offset = "0x3968A30", VA = "0x18396A430")]
	public void MPAAPCHGDCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x3968F10", Offset = "0x3967510", VA = "0x183968F10")]
	private bool IMFFCFJEHBM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x396A490", Offset = "0x3968A90", VA = "0x18396A490")]
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
