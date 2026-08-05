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
using RecRoom.Async;
using RecRoom.Attributes;
using RecRoom.Core.DataStructures;
using RecRoom.DataStructures.Hashing;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;
using RecRoom.NoEngine.DataStructures.Caching;
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
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x9974870", Offset = "0x9973270", VA = "0x189974870")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD3A120", Offset = "0xD38B20", VA = "0x180D3A120")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3A160", Offset = "0xD38B60", VA = "0x180D3A160")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class CompactArrayDrawerAttribute : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x229D500", Offset = "0x229BF00", VA = "0x18229D500")]
	public CompactArrayDrawerAttribute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, DEGJOGATLXO, WEUCVMBDRNK, ISerializationCallbackReceiver
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
	public byte[] NEQGHXWDYQO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] GUCOTNJEQKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object OWMJOBRTNFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xE35270", Offset = "0xE33C70", VA = "0x180E35270", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash hash);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xDA5E70", Offset = "0xDA4870", VA = "0x180DA5E70")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private float NRLSMSEXFJO;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private float CJXEAOOFJAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[ReadOnlyField]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[ReadOnlyField]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9975F60", Offset = "0x9974960", VA = "0x189975F60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9975F20", Offset = "0x9974920", VA = "0x189975F20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9975FA0", Offset = "0x99749A0", VA = "0x189975FA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x99760C0", Offset = "0x9974AC0", VA = "0x1899760C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9976020", Offset = "0x9974A20", VA = "0x189976020")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xD777F0", Offset = "0xD761F0", VA = "0x180D777F0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xD67450", Offset = "0xD65E50", VA = "0x180D67450")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9975F00", Offset = "0x9974900", VA = "0x189975F00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xEE1A30", Offset = "0xEE0430", VA = "0x180EE1A30")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x99758E0", Offset = "0x99742E0", VA = "0x1899758E0")]
	public void CopyBounds(SavedExtents other)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x9975E60", Offset = "0x9974860", VA = "0x189975E60")]
	public void SetLocalSpaceBounds(Bounds totalBounds)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1753E80", Offset = "0x1752880", VA = "0x181753E80")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x9975D90", Offset = "0x9974790", VA = "0x189975D90")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x9975910", Offset = "0x9974310", VA = "0x189975910")]
	private void LQTTKXNRVDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x9975B10", Offset = "0x9974510", VA = "0x189975B10")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x9975290", Offset = "0x9973C90", VA = "0x189975290")]
	public static void CalculateLocalBoundsFor(GameObject gameObject, [Out] Bounds totalBounds)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x9975DA0", Offset = "0x99747A0", VA = "0x189975DA0")]
	private static void SYVTIMSZCYC(Bounds a, Color b)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x9975E80", Offset = "0x9974880", VA = "0x189975E80")]
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
		[Cpp2IlInjected.Address(RVA = "0xD0F110", Offset = "0xD0DB10", VA = "0x180D0F110")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xD12F30", Offset = "0xD11930", VA = "0x180D12F30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1C7CC20", Offset = "0x1C7B620", VA = "0x181C7CC20")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x7A23450", Offset = "0x7A21E50", VA = "0x187A23450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "4")]
	public virtual void ZMYCJYSZONZ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
	[CompactArrayDrawer]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x7A20E60", Offset = "0x7A1F860", VA = "0x187A20E60", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x7A1FC60", Offset = "0x7A1E660", VA = "0x187A1FC60", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x7A211E0", Offset = "0x7A1FBE0", VA = "0x187A211E0")]
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
	private sealed class ZRSWRQOBTIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> DLGYJUCLCRE;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public ZRSWRQOBTIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x517AB70", Offset = "0x5179570", VA = "0x18517AB70")]
		internal int FBDPLEKIWYP(TKeyVal a, TKeyVal b)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[CompactArrayDrawer]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> XDDWHOQIEJB;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x5C08E20", Offset = "0x5C07820", VA = "0x185C08E20", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5C08EA0", Offset = "0x5C078A0", VA = "0x185C08EA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5C08BA0", Offset = "0x5C075A0", VA = "0x185C08BA0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey key]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x5C08C50", Offset = "0x5C07650", VA = "0x185C08C50", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> RYUHOSTFIWE
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x5C08560", Offset = "0x5C06F60", VA = "0x185C08560", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5C082E0", Offset = "0x5C06CE0", VA = "0x185C082E0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5C07630", Offset = "0x5C06030", VA = "0x185C07630", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5C075D0", Offset = "0x5C05FD0", VA = "0x185C075D0", Slot = "14")]
	protected virtual string HQMNPCXPBIK(TKeyVal a)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5C07350", Offset = "0x5C05D50", VA = "0x185C07350", Slot = "4")]
	public bool ContainsKey(TKey key)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5C08760", Offset = "0x5C07160", VA = "0x185C08760", Slot = "5")]
	public bool TryGetValue(TKey key, [Out] TVal value)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5C07430", Offset = "0x5C05E30", VA = "0x185C07430", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5C07430", Offset = "0x5C05E30", VA = "0x185C07430", Slot = "11")]
	private IEnumerator UJBMGYABLAM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5C08AC0", Offset = "0x5C074C0", VA = "0x185C08AC0")]
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
		[Cpp2IlInjected.Address(RVA = "0xF357F0", Offset = "0xF341F0", VA = "0x180F357F0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xF35810", Offset = "0xF34210", VA = "0x180F35810")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	[CompactArrayDrawer]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x7A257C0", Offset = "0x7A241C0", VA = "0x187A257C0")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x7A25420", Offset = "0x7A23E20", VA = "0x187A25420", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x7A24A90", Offset = "0x7A23490", VA = "0x187A24A90", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class CNEKDFEDPPI<a>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct BufferEntry
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public a Value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public float Timestamp;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int YVPDLFDNDEL = 16;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const float QAWQKVUJYDK = -1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected readonly BufferEntry[] BHUHHXRMLWK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	protected int WTZUQGUYHOP;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float YAOKWLDCFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xDBC130", Offset = "0xDBAB30", VA = "0x180DBC130")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xDFEAF0", Offset = "0xDFD4F0", VA = "0x180DFEAF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public a QKZDXFUDSID
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x1A3D9B0", Offset = "0x1A3C3B0", VA = "0x181A3D9B0")]
		[CompilerGenerated]
		get
		{
			return (a)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x504A970", Offset = "0x5049370", VA = "0x18504A970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x504AB40", Offset = "0x5049540", VA = "0x18504AB40")]
	protected CNEKDFEDPPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x504AC00", Offset = "0x5049600", VA = "0x18504AC00")]
	protected CNEKDFEDPPI(int a)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x504A650", Offset = "0x5049050", VA = "0x18504A650")]
	public void Add(float time, a value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool LUEEGCYSEIB(float a, float b, [Out] a c);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool ZGZYIAKBGUK(float a, float b, [Out] a c);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x504A910", Offset = "0x5049310", VA = "0x18504A910")]
	public void Clear()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class RTXXNXNSDFN : CNEKDFEDPPI<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x9974A70", Offset = "0x9973470", VA = "0x189974A70", Slot = "4")]
	public override bool LUEEGCYSEIB(float a, float b, [Out] Vector3 c)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x9974BD0", Offset = "0x99735D0", VA = "0x189974BD0", Slot = "5")]
	public override bool ZGZYIAKBGUK(float a, float b, [Out] Vector3 c)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x9974D10", Offset = "0x9973710", VA = "0x189974D10")]
	public RTXXNXNSDFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class Tuple
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3FCD890", Offset = "0x3FCC290", VA = "0x183FCD890")]
	public static Tuple<T1, T2> Create<T1, T2>(T1 item1, T2 item2)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3FCD990", Offset = "0x3FCC390", VA = "0x183FCD990")]
	public static Tuple<T1, T2, T3> Create<T1, T2, T3>(T1 item1, T2 item2, T3 item3)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x705BFD0", Offset = "0x705A9D0", VA = "0x18705BFD0")]
	internal static int LBKMDVJRTSE(int a, int b)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x8B228B0", Offset = "0x8B212B0", VA = "0x188B228B0")]
	internal static int LBKMDVJRTSE(int a, int b, int c)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class Tuple<T1, T2> : IComparable<Tuple<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T1 VYBWZFLUTGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T2 VXMCHLECQYA;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3050", Offset = "0x7DB1A50", VA = "0x187DB3050")]
	public Tuple(T1 item1, T2 item2)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x7DAA160", Offset = "0x7DA8B60", VA = "0x187DAA160", Slot = "4")]
	public int CompareTo(Tuple<T1, T2> other)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7DAB720", Offset = "0x7DAA120", VA = "0x187DAB720", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x7DABD50", Offset = "0x7DAA750", VA = "0x187DABD50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7DB2840", Offset = "0x7DB1240", VA = "0x187DB2840", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class Tuple<T1, T2, T3> : IComparable<Tuple<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T1 VYBWZFLUTGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T2 VXMCHLECQYA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T3 VXRJERYAAJJ;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x7DB7310", Offset = "0x7DB5D10", VA = "0x187DB7310")]
	public Tuple(T1 item1, T2 item2, T3 item3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3090", Offset = "0x7DB1A90", VA = "0x187DB3090", Slot = "4")]
	public int CompareTo(Tuple<T1, T2, T3> other)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7DB3840", Offset = "0x7DB2240", VA = "0x187DB3840", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x7DB4160", Offset = "0x7DB2B60", VA = "0x187DB4160", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x7DB7190", Offset = "0x7DB5B90", VA = "0x187DB7190", Slot = "3")]
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
	public AnimationCurve BMMWYDCTIHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T LQOHVLUSGGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x104E620", Offset = "0x104D020", VA = "0x18104E620")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T FSCKFMZPOBW
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xDA5E80", Offset = "0xDA4880", VA = "0x180DA5E80")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T PGGBLURLEPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x300BB80", Offset = "0x300A580", VA = "0x18300BB80")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x300BA90", Offset = "0x300A490", VA = "0x18300BA90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float ZJCHXRUTINP
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xDA2840", Offset = "0xDA1240", VA = "0x180DA2840")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x80B29E0", Offset = "0x80B13E0", VA = "0x1880B29E0")]
	public T TELIHYYNUPA(float a)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x80B2850", Offset = "0x80B1250", VA = "0x1880B2850")]
	public T EOZGCXDJQJK(float a)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T GDPFALQFRVG(T a, T b, float c);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x9973CB0", Offset = "0x99726B0", VA = "0x189973CB0", Slot = "4")]
	protected override float GDPFALQFRVG(float a, float b, float c)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x9973CF0", Offset = "0x99726F0", VA = "0x189973CF0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1A9E7F0", Offset = "0x1A9D1F0", VA = "0x181A9E7F0", Slot = "4")]
	protected override Vector3 GDPFALQFRVG(Vector3 a, Vector3 b, float c)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x9978040", Offset = "0x9976A40", VA = "0x189978040")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x9973840", Offset = "0x9972240", VA = "0x189973840", Slot = "4")]
	protected override Color GDPFALQFRVG(Color a, Color b, float c)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x9973900", Offset = "0x9972300", VA = "0x189973900")]
	public ColorValueCurve()
	{
	}
}
namespace Structures.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class FCPZSFMLPUL : WEWSIDRDOGP<string>
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9973C60", Offset = "0x9972660", VA = "0x189973C60")]
		public FCPZSFMLPUL(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9973BF0", Offset = "0x99725F0", VA = "0x189973BF0", Slot = "6")]
		protected override uint ULPTYCYGGYL(uint a, string b)
		{
			return default(uint);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class NQCWVCIIQSD : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public static readonly IDisposable GFQGJWBHKJM;

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public NQCWVCIIQSD()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public struct AwaitableRpc<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> _roundTripRequests;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private int _lastActorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private int _requestId;

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x4EF7390", Offset = "0x4EF5D90", VA = "0x184EF7390")]
		private AwaitableRpc(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> roundTripRequests, int lastActorId, int requestId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x4EF71E0", Offset = "0x4EF5BE0", VA = "0x184EF71E0")]
		public static AwaitableRpc<T> New()
		{
			return default(AwaitableRpc<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x4EF5970", Offset = "0x4EF4370", VA = "0x184EF5970")]
		public (int, int, Task<T>) CDCKDBIRXJW(int a, [Optional] CancellationToken b, double c = 60.0)
		{
			return default((int, int, Task<T>));
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x4EF6B60", Offset = "0x4EF5560", VA = "0x184EF6B60")]
		public void DJVZEFRZINB(int a, int b, [In] T result)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public static class PVDIXERQIIA
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9974A20", Offset = "0x9973420", VA = "0x189974A20")]
		public static AwaitableRpc<None> New()
		{
			return default(AwaitableRpc<None>);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x99749A0", Offset = "0x99733A0", VA = "0x1899749A0")]
		public static void DJVZEFRZINB([In] this AwaitableRpc<None> self, int a, int b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class FCIQRPBUYVU<a, b> : IDictionary<a, b>, ICollection<KeyValuePair<a, b>>, IEnumerable<KeyValuePair<a, b>>, IEnumerable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly Dictionary<a, b> IMGFZGRPAVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private readonly Dictionary<b, a> DXOQAJJREUG;

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x6355090", Offset = "0x6353A90", VA = "0x186355090", Slot = "12")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xD5AE10", Offset = "0xD59810", VA = "0x180D5AE10", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public ICollection<a> Keys
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x63554D0", Offset = "0x6353ED0", VA = "0x1863554D0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public ICollection<b> Values
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x6355540", Offset = "0x6353F40", VA = "0x186355540", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public b this[a key]
		{
			[Cpp2IlInjected.Token(Token = "0x600008C")]
			[Cpp2IlInjected.Address(RVA = "0x6355460", Offset = "0x6353E60", VA = "0x186355460", Slot = "4")]
			get
			{
				return (b)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600008D")]
			[Cpp2IlInjected.Address(RVA = "0x6355660", Offset = "0x6354060", VA = "0x186355660", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public a this[b key]
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x63553F0", Offset = "0x6353DF0", VA = "0x1863553F0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6353400", Offset = "0x6351E00", VA = "0x186353400", Slot = "15")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x63547C0", Offset = "0x63531C0", VA = "0x1863547C0", Slot = "20")]
		private IEnumerator UJBMGYABLAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x6353270", Offset = "0x6351C70", VA = "0x186353270", Slot = "9")]
		public void Add(a key, b value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x63530E0", Offset = "0x6351AE0", VA = "0x1863530E0", Slot = "14")]
		public void Add(KeyValuePair<a, b> item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x63535F0", Offset = "0x6351FF0", VA = "0x1863535F0", Slot = "8")]
		public bool ContainsKey(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x6353770", Offset = "0x6352170", VA = "0x186353770", Slot = "16")]
		public bool Contains(KeyValuePair<a, b> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x6354370", Offset = "0x6352D70", VA = "0x186354370", Slot = "10")]
		public bool Remove(a key)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6354370", Offset = "0x6352D70", VA = "0x186354370", Slot = "18")]
		public bool Remove(KeyValuePair<a, b> item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x63546D0", Offset = "0x63530D0", VA = "0x1863546D0", Slot = "11")]
		public bool TryGetValue(a key, [Out] b value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x63542B0", Offset = "0x6352CB0", VA = "0x1863542B0", Slot = "19")]
		public IEnumerator<KeyValuePair<a, b>> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x63538B0", Offset = "0x63522B0", VA = "0x1863538B0", Slot = "17")]
		public void CopyTo(KeyValuePair<a, b>[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6354DB0", Offset = "0x63537B0", VA = "0x186354DB0")]
		public bool YOABBVTNACT(b a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6353910", Offset = "0x6352310", VA = "0x186353910")]
		private void EALJUHALKDT(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6353FF0", Offset = "0x63529F0", VA = "0x186353FF0")]
		private void FDXSUBESREK(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6354B60", Offset = "0x6353560", VA = "0x186354B60")]
		private bool YKNYBXGMIPG(a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x6354ED0", Offset = "0x63538D0", VA = "0x186354ED0")]
		public FCIQRPBUYVU()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class ESRIEFUDIWN<a> : IEnumerable<a>, IEnumerable, IReadOnlyCollection<a>
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public struct Enumerator : IEnumerator<a>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private ESRIEFUDIWN<a> buffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private int index;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private int version;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			private a current;

			[Cpp2IlInjected.Token(Token = "0x17000025")]
			public a Current
			{
				[Cpp2IlInjected.Token(Token = "0x60000A2")]
				[Cpp2IlInjected.Address(RVA = "0x15ADBE0", Offset = "0x15AC5E0", VA = "0x1815ADBE0", Slot = "4")]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000026")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x60000A6")]
				[Cpp2IlInjected.Address(RVA = "0x5C41E10", Offset = "0x5C40810", VA = "0x185C41E10", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x5C43FA0", Offset = "0x5C429A0", VA = "0x185C43FA0")]
			public Enumerator(ESRIEFUDIWN<a> buffer)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A4")]
			[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x5C42630", Offset = "0x5C41030", VA = "0x185C42630", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x5C42B10", Offset = "0x5C41510", VA = "0x185C42B10", Slot = "8")]
			private void QWPEWWNKZVD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x5C43D60", Offset = "0x5C42760", VA = "0x185C43D60")]
			private void TGZHSSDBSTX()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private a[] QXUGJWMLOIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private int VXYJQIHHLWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private int ONCCLOJNSZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private int version;

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0x5BE9320", Offset = "0x5BE7D20", VA = "0x185BE9320", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public a this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0x5BE9540", Offset = "0x5BE7F40", VA = "0x185BE9540")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0x5BE9710", Offset = "0x5BE8110", VA = "0x185BE9710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5BE9220", Offset = "0x5BE7C20", VA = "0x185BE9220")]
		public ESRIEFUDIWN(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5BE6630", Offset = "0x5BE5030", VA = "0x185BE6630")]
		public void Add(a t)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5BE8140", Offset = "0x5BE6B40", VA = "0x185BE8140")]
		public void QAAXATRKPYJ(IEnumerable<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5BE69E0", Offset = "0x5BE53E0", VA = "0x185BE69E0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5BE68B0", Offset = "0x5BE52B0", VA = "0x185BE68B0")]
		public void BRHLKGVGHAA(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5BE6A00", Offset = "0x5BE5400", VA = "0x185BE6A00")]
		public void CopyTo(a[] array)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5BE7180", Offset = "0x5BE5B80", VA = "0x185BE7180")]
		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5BE6D20", Offset = "0x5BE5720", VA = "0x185BE6D20", Slot = "4")]
		private IEnumerator<a> EJVKVOJRYRR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5BE6D20", Offset = "0x5BE5720", VA = "0x185BE6D20", Slot = "5")]
		private IEnumerator UJBMGYABLAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x5BE7210", Offset = "0x5BE5C10", VA = "0x185BE7210")]
		private int NQBBQZFLHWO(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x5BE73E0", Offset = "0x5BE5DE0", VA = "0x185BE73E0")]
		private int PEBZQSIGXBE(int a)
		{
			return default(int);
		}
	}
}
namespace RecRoom.Async
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public class ABNYGADKDYI<a, b> : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public delegate Task<b> RequestProcessor(a request, CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public enum ProcessMethod
		{
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			FirstInFirstOut,
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			LastInFirstOut
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public class AJQUKWNUXCJ
		{
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private const float CIKCKSJEWYV = 60f;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			private TimeSpan AXAYKJLFZKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public int KPRHPZFIJZZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			public ProcessMethod GXHXADMQTXJ;

			[Cpp2IlInjected.Token(Token = "0x4000043")]
			public static readonly AJQUKWNUXCJ DOFDCVCRMAS;

			[Cpp2IlInjected.Token(Token = "0x17000027")]
			public float YIORRFFQZEC
			{
				[Cpp2IlInjected.Token(Token = "0x60000B3")]
				[Cpp2IlInjected.Address(RVA = "0x72DCDE0", Offset = "0x72DB7E0", VA = "0x1872DCDE0")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000028")]
			public TimeSpan GUTIQBDFNIR
			{
				[Cpp2IlInjected.Token(Token = "0x60000B4")]
				[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
				get
				{
					return default(TimeSpan);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x72DD140", Offset = "0x72DBB40", VA = "0x1872DD140")]
			public AJQUKWNUXCJ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		private readonly struct QueueItem
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			public readonly a request;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			public readonly CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			public readonly TaskCompletionSource<b> taskCompletionSource;

			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x7739540", Offset = "0x7737F40", VA = "0x187739540")]
			public QueueItem(a request, TaskCompletionSource<b> taskCompletionSource, CancellationToken cancellationToken)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		[CompilerGenerated]
		private struct <DequeueItemAndRun>d__14 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			public ABNYGADKDYI<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			private QueueItem <req>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004B")]
			private TaskAwaiter<b> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x6682AF0", Offset = "0x66814F0", VA = "0x186682AF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x66842B0", Offset = "0x6682CB0", VA = "0x1866842B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private struct <StartQueueProcess>d__12 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			public ABNYGADKDYI<a, b> <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x6E10F20", Offset = "0x6E0F920", VA = "0x186E10F20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x6E11730", Offset = "0x6E10130", VA = "0x186E11730", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private readonly CancellationTokenSource UADMYMOCRTR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private readonly List<QueueItem> DHSJCGSGFRL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private readonly AJQUKWNUXCJ REUDBAKBKDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private readonly RequestProcessor AQMLDVKLUWO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private Task XKWOVNPMAXD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private int WDJZLYZSKNE;

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x72D8220", Offset = "0x72D6C20", VA = "0x1872D8220")]
		public ABNYGADKDYI(RequestProcessor a, [Optional] AJQUKWNUXCJ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x72D6820", Offset = "0x72D5220", VA = "0x1872D6820")]
		public Task<b> GEBMCEKISYJ(a a, CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x72D5F20", Offset = "0x72D4920", VA = "0x1872D5F20")]
		private void ARNVTZIQIOY(QueueItem a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x72D7370", Offset = "0x72D5D70", VA = "0x1872D7370")]
		[AsyncStateMachine(typeof(ABNYGADKDYI<, >.<StartQueueProcess>d__12))]
		private Task GTPQWJEAAKT()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x72D7860", Offset = "0x72D6260", VA = "0x1872D7860")]
		private QueueItem YXRJKJCELTH()
		{
			return default(QueueItem);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x72D7540", Offset = "0x72D5F40", VA = "0x1872D7540")]
		[AsyncStateMachine(typeof(ABNYGADKDYI<, >.<DequeueItemAndRun>d__14))]
		private Task LTFGMTFTULG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x72D6580", Offset = "0x72D4F80", VA = "0x1872D6580")]
		private void EYOWDWVMHYF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x72D63B0", Offset = "0x72D4DB0", VA = "0x1872D63B0", Slot = "4")]
		public void Dispose()
		{
		}
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
namespace RecRoom.DataStructures
{
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public class INTYYDBQVXM<a> : IList<a>, ICollection<a>, IEnumerable<a>, IEnumerable, IReadOnlyList<a>, IReadOnlyCollection<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private readonly List<a> FEFPYLNNFVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		private HashSet<a> JNTEGJUXWEL;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public int Count
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x286DE80", Offset = "0x286C880", VA = "0x18286DE80", Slot = "19")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool IsReadOnly
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0xD5AE10", Offset = "0xD59810", VA = "0x180D5AE10", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public a this[int index]
		{
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x664EF50", Offset = "0x664D950", VA = "0x18664EF50", Slot = "18")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x664F350", Offset = "0x664DD50", VA = "0x18664F350", Slot = "5")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x664DC80", Offset = "0x664C680", VA = "0x18664DC80", Slot = "11")]
		public void Add(a item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x664E1D0", Offset = "0x664CBD0", VA = "0x18664E1D0")]
		public bool EQRSINERSDL(a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x664EB00", Offset = "0x664D500", VA = "0x18664EB00", Slot = "15")]
		public bool Remove(a item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x664E2C0", Offset = "0x664CCC0", VA = "0x18664E2C0", Slot = "16")]
		public IEnumerator<a> GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x664ED10", Offset = "0x664D710", VA = "0x18664ED10", Slot = "17")]
		private IEnumerator UJBMGYABLAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x664DD60", Offset = "0x664C760", VA = "0x18664DD60", Slot = "12")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x664DF10", Offset = "0x664C910", VA = "0x18664DF10", Slot = "13")]
		public bool Contains(a item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x664DF70", Offset = "0x664C970", VA = "0x18664DF70", Slot = "14")]
		public void CopyTo(a[] array, int arrayIndex)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x664E3E0", Offset = "0x664CDE0", VA = "0x18664E3E0", Slot = "6")]
		public int IndexOf(a item)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x664E500", Offset = "0x664CF00", VA = "0x18664E500", Slot = "7")]
		public void Insert(int index, a item)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x664EA50", Offset = "0x664D450", VA = "0x18664EA50", Slot = "8")]
		public void RemoveAt(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x664ED90", Offset = "0x664D790", VA = "0x18664ED90")]
		public INTYYDBQVXM()
		{
		}
	}
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
		private Guid ZZTDTIVDSZB;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2E44090", Offset = "0x2E42A90", VA = "0x182E44090")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x74A1830", Offset = "0x74A0230", VA = "0x1874A1830")]
		public SerializedGuid([In] Guid guid)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x9976460", Offset = "0x9974E60", VA = "0x189976460")]
		public static SerializedGuid VVYWBNJEAJU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x99763F0", Offset = "0x9974DF0", VA = "0x1899763F0")]
		public static SerializedGuid SHMUHCEOFMQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x99762E0", Offset = "0x9974CE0", VA = "0x1899762E0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x99763C0", Offset = "0x9974DC0", VA = "0x1899763C0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x9976340", Offset = "0x9974D40", VA = "0x189976340", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x9976200", Offset = "0x9974C00", VA = "0x189976200", Slot = "7")]
		public bool Equals(SerializedGuid other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x9976240", Offset = "0x9974C40", VA = "0x189976240", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x99762D0", Offset = "0x9974CD0", VA = "0x1899762D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x99761D0", Offset = "0x9974BD0", VA = "0x1899761D0", Slot = "6")]
		public int CompareTo(SerializedGuid other)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	public class SerializedGuidSourceAttribute : PropertyAttribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public readonly Type ValueRetrieveMethodType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public readonly string ValueRetrieveMethod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public readonly bool InsertEmptyChoice;

		[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public readonly bool Disabled;

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x9976160", Offset = "0x9974B60", VA = "0x189976160")]
		public SerializedGuidSourceAttribute(Type valueRetrieveMethodType, string valueRetrieveMethod, bool insertEmptyChoice = false, bool disabled = false)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public interface VMYKDCRSXYK<a>
	{
		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		int IDIILRQQIVU
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IEnumerable<a> NDVZOWYWBAS(float a, [Optional] float? b);

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool CBMRGXQYGEI(float a, a b);

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		void Clear();
	}
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class WOVSRSLAJPP<a> : VMYKDCRSXYK<a>
	{
		[Cpp2IlInjected.Token(Token = "0x200002E")]
		private readonly struct Sample
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public readonly a Value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public readonly float Time;

			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x10741C0", Offset = "0x1072BC0", VA = "0x1810741C0")]
			public Sample(a value, float time)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private sealed class ZIZEEBDJFNI : IEnumerable<a>, IEnumerable, IEnumerator<a>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000060")]
			private int AKEYILDVZEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000061")]
			private a OCEUOVLOMMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private int AYLQLTGRUAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public WOVSRSLAJPP<a> XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private float XAGGSONZRZK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public float HZFREHMFBSP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000066")]
			private float? NTHHRIAYOKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public float? JGWCMPQPVXB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000068")]
			private int SSTAWKWRTBX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000069")]
			private int GQFJSYNJDIC;

			[Cpp2IlInjected.Token(Token = "0x1700002F")]
			private a HTALOBYUKAE
			{
				[Cpp2IlInjected.Token(Token = "0x60000E9")]
				[Cpp2IlInjected.Address(RVA = "0xED9DB0", Offset = "0xED87B0", VA = "0x180ED9DB0", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return (a)null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000030")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x60000EB")]
				[Cpp2IlInjected.Address(RVA = "0x515B5C0", Offset = "0x5159FC0", VA = "0x18515B5C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x15D99C0", Offset = "0x15D83C0", VA = "0x1815D99C0")]
			[DebuggerHidden]
			public ZIZEEBDJFNI(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "7")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x515B6A0", Offset = "0x515A0A0", VA = "0x18515B6A0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x4F23E00", Offset = "0x4F22800", VA = "0x184F23E00", Slot = "10")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x515B500", Offset = "0x5159F00", VA = "0x18515B500", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<a> EJVKVOJRYRR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x515BE20", Offset = "0x515A820", VA = "0x18515BE20", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UJBMGYABLAM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private readonly float MJGAWIQXDFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private readonly float TLKNEORLYYZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private readonly List<Sample> SGJGKVUDGCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private int VXYJQIHHLWB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private int BFXBCELWSJS;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public int IDIILRQQIVU
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0xD12BE0", Offset = "0xD115E0", VA = "0x180D12BE0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x872D350", Offset = "0x872BD50", VA = "0x18872D350")]
		public WOVSRSLAJPP(float a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x872C690", Offset = "0x872B090", VA = "0x18872C690", Slot = "6")]
		public bool CBMRGXQYGEI(float a, a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x872CCF0", Offset = "0x872B6F0", VA = "0x18872CCF0", Slot = "8")]
		public int MNIKZMVRDAG(float a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x872CED0", Offset = "0x872B8D0", VA = "0x18872CED0", Slot = "5")]
		[IteratorStateMachine(typeof(WOVSRSLAJPP<>.ZIZEEBDJFNI))]
		public IEnumerable<a> NDVZOWYWBAS(float a, float? b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x872CC80", Offset = "0x872B680", VA = "0x18872CC80", Slot = "7")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x872D0E0", Offset = "0x872BAE0", VA = "0x18872D0E0")]
		private void QYOWIQYKOOD(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x872C520", Offset = "0x872AF20", VA = "0x18872C520")]
		private Sample AWPGKSIOXDH()
		{
			return default(Sample);
		}
	}
}
namespace RecRoom.DataStructures.Times
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public class StackTimer<TKey> : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public readonly struct TimerEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public readonly long startTicks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public readonly long endTicks;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public readonly int startFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public readonly int endFrame;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public readonly bool isDone;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private readonly string stackTrace;

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x7CC9DA0", Offset = "0x7CC87A0", VA = "0x187CC9DA0")]
			public TimerEntry(long startTicks, int startFrame)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x7CC9D70", Offset = "0x7CC8770", VA = "0x187CC9D70")]
			public TimerEntry(long startTicks, long endTicks, int startFrame, int endFrame, bool isDone, string stackTrace)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x7CC9BF0", Offset = "0x7CC85F0", VA = "0x187CC9BF0")]
			public int ZDVGAPLMZHX()
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x7CC9B10", Offset = "0x7CC8510", VA = "0x187CC9B10")]
			public int NQJGKKFIDEX(int a)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x7CC9B90", Offset = "0x7CC8590", VA = "0x187CC9B90")]
			public double OETTUFZGRGL()
			{
				return default(double);
			}

			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x7CC9A70", Offset = "0x7CC8470", VA = "0x187CC9A70")]
			public TimerEntry LVSMVTZOBCO(long a, int b)
			{
				return default(TimerEntry);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public class IHETKLZLESW : IDisposable
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000033")]
			[CompilerGenerated]
			private struct <WrapAsync>d__17<T> : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x400007F")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000080")]
				public AsyncTaskMethodBuilder<T> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000081")]
				public IHETKLZLESW <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000082")]
				public TKey key;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000083")]
				public Func<IHETKLZLESW, Task<T>> function;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000084")]
				private IHETKLZLESW <internalTimer>5__2;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x4000085")]
				private TaskAwaiter<T> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000104")]
				[Cpp2IlInjected.Address(RVA = "0x719FE90", Offset = "0x719E890", VA = "0x18719FE90", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000105")]
				[Cpp2IlInjected.Address(RVA = "0x66955A0", Offset = "0x6693FA0", VA = "0x1866955A0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public readonly TKey XVKQGRWDPTO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private readonly StackTimer<TKey> VTJZGLHFILQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			public readonly Log KNJEMMUNATP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007D")]
			private List<IHETKLZLESW> XQTVZLUWRVW;

			[Cpp2IlInjected.Token(Token = "0x17000033")]
			public string LEPABJYTJUM
			{
				[Cpp2IlInjected.Token(Token = "0x60000FC")]
				[Cpp2IlInjected.Address(RVA = "0x6649C30", Offset = "0x6648630", VA = "0x186649C30")]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000034")]
			public IEnumerable<IHETKLZLESW> EHFJOPVXKEO
			{
				[Cpp2IlInjected.Token(Token = "0x60000FD")]
				[Cpp2IlInjected.Address(RVA = "0x6649470", Offset = "0x6647E70", VA = "0x186649470")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000035")]
			public TimerEntry UDXOEOYCBAK
			{
				[Cpp2IlInjected.Token(Token = "0x60000FE")]
				[Cpp2IlInjected.Address(RVA = "0x219BF50", Offset = "0x219A950", VA = "0x18219BF50")]
				[CompilerGenerated]
				get
				{
					return default(TimerEntry);
				}
				[Cpp2IlInjected.Token(Token = "0x60000FF")]
				[Cpp2IlInjected.Address(RVA = "0x6648FD0", Offset = "0x66479D0", VA = "0x186648FD0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x6649C60", Offset = "0x6648660", VA = "0x186649C60")]
			internal IHETKLZLESW(StackTimer<TKey> a, TKey b, Log c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0x66498E0", Offset = "0x66482E0", VA = "0x1866498E0")]
			public IHETKLZLESW OWDTBBZOMDY(TKey a, [Optional] Log? b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x38EF090", Offset = "0x38EDA90", VA = "0x1838EF090")]
			[AsyncStateMachine(typeof(<WrapAsync>d__17<>))]
			public Task<b> CNAMQSYASRZ<b>(TKey a, Func<IHETKLZLESW, Task<b>> b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0x6649000", Offset = "0x6647A00", VA = "0x186649000", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		[CompilerGenerated]
		private sealed class ELIFMCGUINU : IEnumerable<(TKey, List<TKey>, TimerEntry)>, IEnumerable, IEnumerator<(TKey, List<TKey>, TimerEntry)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			private int AKEYILDVZEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000087")]
			private (TKey key, List<TKey> path, TimerEntry timerEntry) OCEUOVLOMMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			private int AYLQLTGRUAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public StackTimer<TKey> XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			private IEnumerator<(TKey key, List<TKey> path, TimerEntry timerEntry)> ULWCKXMDKCB;

			[Cpp2IlInjected.Token(Token = "0x17000036")]
			private (TKey, List<TKey>, TimerEntry) DETCEBECAST
			{
				[Cpp2IlInjected.Token(Token = "0x600010A")]
				[Cpp2IlInjected.Address(RVA = "0x2E41010", Offset = "0x2E3FA10", VA = "0x182E41010", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((TKey, List<TKey>, TimerEntry));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000037")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x600010C")]
				[Cpp2IlInjected.Address(RVA = "0x5B8F130", Offset = "0x5B8DB30", VA = "0x185B8F130", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x2E41330", Offset = "0x2E3FD30", VA = "0x182E41330")]
			[DebuggerHidden]
			public ELIFMCGUINU(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x5B8FD20", Offset = "0x5B8E720", VA = "0x185B8FD20", Slot = "7")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x5B8F950", Offset = "0x5B8E350", VA = "0x185B8F950", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x5B8FEC0", Offset = "0x5B8E8C0", VA = "0x185B8FEC0")]
			private void RHNDEQIOOEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x4F23E00", Offset = "0x4F22800", VA = "0x184F23E00", Slot = "10")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x5B8F300", Offset = "0x5B8DD00", VA = "0x185B8F300", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(TKey, List<TKey>, TimerEntry)> MCVOELTNGTC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x5B8FF10", Offset = "0x5B8E910", VA = "0x185B8FF10", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UJBMGYABLAM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class ELNMJJARRZD : IEnumerable<(TKey, List<TKey>, TimerEntry)>, IEnumerable, IEnumerator<(TKey, List<TKey>, TimerEntry)>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			private int AKEYILDVZEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			private (TKey key, List<TKey> path, TimerEntry timerEntry) OCEUOVLOMMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private int AYLQLTGRUAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private List<TKey> OIFBGMTQUHM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008F")]
			public List<TKey> NVTGTGGVMLH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000090")]
			private IHETKLZLESW TMXNZAFFWZI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000091")]
			public IHETKLZLESW ZCYFNEULSDX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000092")]
			public StackTimer<TKey> XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000093")]
			private IEnumerator<IHETKLZLESW> ULWCKXMDKCB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000094")]
			private IEnumerator<(TKey key, List<TKey> path, TimerEntry timerEntry)> ULGHTDELHUA;

			[Cpp2IlInjected.Token(Token = "0x17000038")]
			private (TKey, List<TKey>, TimerEntry) DETCEBECAST
			{
				[Cpp2IlInjected.Token(Token = "0x6000114")]
				[Cpp2IlInjected.Address(RVA = "0x2E41010", Offset = "0x2E3FA10", VA = "0x182E41010", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return default((TKey, List<TKey>, TimerEntry));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000039")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x6000116")]
				[Cpp2IlInjected.Address(RVA = "0x5B949C0", Offset = "0x5B933C0", VA = "0x185B949C0", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x2E41330", Offset = "0x2E3FD30", VA = "0x182E41330")]
			[DebuggerHidden]
			public ELNMJJARRZD(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x5B96530", Offset = "0x5B94F30", VA = "0x185B96530", Slot = "7")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x5B95BD0", Offset = "0x5B945D0", VA = "0x185B95BD0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x5B96850", Offset = "0x5B95250", VA = "0x185B96850")]
			private void RHNDEQIOOEK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x5B96610", Offset = "0x5B95010", VA = "0x185B96610")]
			private void RHHWHJORETB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x4F23E00", Offset = "0x4F22800", VA = "0x184F23E00", Slot = "10")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x5B94A10", Offset = "0x5B93410", VA = "0x185B94A10", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<(TKey, List<TKey>, TimerEntry)> MCVOELTNGTC()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000118")]
			[Cpp2IlInjected.Address(RVA = "0x5B968B0", Offset = "0x5B952B0", VA = "0x185B968B0", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UJBMGYABLAM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private readonly Action<TKey, TimerEntry, Log> KHAOWJBAPTQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private readonly Action<TKey, TimerEntry, Log> SWAULBBAENN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		private readonly Action<StackTimer<TKey>, Log> NARDZGCSHRH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly Log KNJEMMUNATP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		private readonly IHETKLZLESW BKRNVCNWREO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private bool ICYNOWPKTPY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private int ASIVLRYLBKQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private readonly Stopwatch ZYIZCGUKWIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public readonly int VDJGWZTLLGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		private string FKUCKPTNZQH;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public IHETKLZLESW IHCLOQLLWJF
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		[NotNull]
		public string LEPABJYTJUM
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0xD11B20", Offset = "0xD10520", VA = "0x180D11B20")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x7B19E60", Offset = "0x7B18860", VA = "0x187B19E60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7B1A120", Offset = "0x7B18B20", VA = "0x187B1A120")]
		public StackTimer(TKey rootKey, Log log, [Optional] int? startFrame, [Optional][CanBeNull] Stopwatch stopwatch, [Optional] Action<TKey, TimerEntry, Log> pushCallback, [Optional] Action<TKey, TimerEntry, Log> popCallback, [Optional] Action<StackTimer<TKey>, Log> disposeCallback)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7B19810", Offset = "0x7B18210", VA = "0x187B19810", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7B19AE0", Offset = "0x7B184E0", VA = "0x187B19AE0")]
		[IteratorStateMachine(typeof(StackTimer<>.ELIFMCGUINU))]
		public IEnumerable<(TKey, List<TKey>, TimerEntry)> ESNMFBWCIWC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7B19C30", Offset = "0x7B18630", VA = "0x187B19C30")]
		[IteratorStateMachine(typeof(StackTimer<>.ELNMJJARRZD))]
		private IEnumerable<(TKey, List<TKey>, TimerEntry)> ESNMFBWCIWC(List<TKey> a, IHETKLZLESW b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7B19D00", Offset = "0x7B18700", VA = "0x187B19D00")]
		private (long, int) Now()
		{
			return default((long, int));
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public abstract class CKYUFBHGHME<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract b Format(StackTimer<a> timer);

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		protected CKYUFBHGHME()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public abstract class MVADRNRZQJF<a> : CKYUFBHGHME<a, string>
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public delegate string KeyToStringFunc(a key);

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6FFAE90", Offset = "0x6FF9890", VA = "0x186FFAE90")]
		private static string YEZKMCDBSFH(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6FFAC50", Offset = "0x6FF9650", VA = "0x186FFAC50", Slot = "4")]
		public override string Format(StackTimer<a> timer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x6FFAB60", Offset = "0x6FF9560", VA = "0x186FFAB60")]
		public string Format(StackTimer<a> timer, [NotNull] KeyToStringFunc keyToStringFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract string VXJRDDAMSXN(StackTimer<a> a, [NotNull] KeyToStringFunc keyToStringFunc);

		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x6FFAED0", Offset = "0x6FF98D0", VA = "0x186FFAED0")]
		protected MVADRNRZQJF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class BDNSHQIRHWX<a> : CKYUFBHGHME<a, Dictionary<string, string>>
	{
		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public delegate string KeyToStringFunc(a key);

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private readonly string HCHWOEVBWMU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private readonly double QUWHZPOAYIS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly bool ACLOWOYBVID;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly int GMSXPTUXMRF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly ISet<string> NTYKUNIHWQO;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x4EFE480", Offset = "0x4EFCE80", VA = "0x184EFE480")]
		private static string YEZKMCDBSFH(a a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x4EFE660", Offset = "0x4EFD060", VA = "0x184EFE660")]
		public BDNSHQIRHWX(string a = "F2", double b = 1.7976931348623157E+308, bool c = false, int d = 2147483647, [Optional] ISet<string> e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x4EFE060", Offset = "0x4EFCA60", VA = "0x184EFE060", Slot = "4")]
		public override Dictionary<string, string> Format(StackTimer<a> timer)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x4EFE100", Offset = "0x4EFCB00", VA = "0x184EFE100")]
		private bool GCEIRADFCOP(string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x4EFD8F0", Offset = "0x4EFC2F0", VA = "0x184EFD8F0")]
		public Dictionary<string, string> Format(StackTimer<a> timer, KeyToStringFunc keyToStringFunc)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x4EFCDA0", Offset = "0x4EFB7A0", VA = "0x184EFCDA0")]
		private string EXHSALNCZYO(StringBuilder a, List<a> b, KeyToStringFunc c, bool d)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x4EFE330", Offset = "0x4EFCD30", VA = "0x184EFE330")]
		private static void RGNVWNBZEJI(StringBuilder a, string b, bool c)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public class YKYXPEWMJBI<a> : MVADRNRZQJF<a>
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		[CompilerGenerated]
		private struct <>c__DisplayClass4_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public KeyToStringFunc keyToStringFunc;
		}

		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public static YKYXPEWMJBI<a> GFQGJWBHKJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly string[] DTUQEOJEEML;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x50F8420", Offset = "0x50F6E20", VA = "0x1850F8420")]
		private YKYXPEWMJBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x50F7630", Offset = "0x50F6030", VA = "0x1850F7630", Slot = "5")]
		protected override string VXJRDDAMSXN(StackTimer<a> a, KeyToStringFunc b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x50F7580", Offset = "0x50F5F80", VA = "0x1850F7580")]
		[CompilerGenerated]
		internal static string VSSQQDKGNXV(string a, a b, <>c__DisplayClass4_0 c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class GDVOHTFKLFP : StackTimer<string>
	{
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		[CompilerGenerated]
		private sealed class BAWJCOIJFZS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public Action<GDVOHTFKLFP, Log> PKLQWBZQGHM;

			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public BAWJCOIJFZS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x9973670", Offset = "0x9972070", VA = "0x189973670")]
			internal void KHRUFVEJLRN(StackTimer<string> a, Log b)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x9973DF0", Offset = "0x99727F0", VA = "0x189973DF0")]
		public GDVOHTFKLFP(Log a, [Optional] string b, [Optional] int? c, [Optional] Stopwatch d, [Optional] Action<string, TimerEntry, Log> e, [Optional] Action<string, TimerEntry, Log> f, [Optional] Action<GDVOHTFKLFP, Log> g)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x9973D30", Offset = "0x9972730", VA = "0x189973D30")]
		private static Action<StackTimer<string>, Log> HBKAYWFJNAV(Action<GDVOHTFKLFP, Log> a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public abstract class ATHNRPPKZGN
	{
		[Cpp2IlInjected.Token(Token = "0x2000040")]
		private class BNBXXITUWRY : ATHNRPPKZGN
		{
			[Cpp2IlInjected.Token(Token = "0x1700003C")]
			public static ATHNRPPKZGN GFQGJWBHKJM
			{
				[Cpp2IlInjected.Token(Token = "0x6000137")]
				[Cpp2IlInjected.Address(RVA = "0x9973700", Offset = "0x9972100", VA = "0x189973700")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public override float BOYAVAADXIT
			{
				[Cpp2IlInjected.Token(Token = "0x6000138")]
				[Cpp2IlInjected.Address(RVA = "0x1417470", Offset = "0x1415E70", VA = "0x181417470", Slot = "4")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x99737F0", Offset = "0x99721F0", VA = "0x1899737F0")]
			public BNBXXITUWRY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400009E")]
		private static ATHNRPPKZGN JOQCQRWCPDI;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public static ATHNRPPKZGN DOFDCVCRMAS
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x9973500", Offset = "0x9971F00", VA = "0x189973500")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public abstract float BOYAVAADXIT
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		protected ATHNRPPKZGN()
		{
		}
	}
}
namespace RecRoom.DataStructures.ResourceHandles
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public interface OEGCWZLZCPE : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		bool AJRBHITXSUS
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public interface OIRALRYLARL<a> : OEGCWZLZCPE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		[NotNull]
		Task<a> QYNQTUXLHYU
		{
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		[NotNull]
		CCAFLELIKTY<a> OCFJYKPMWGC
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public static class JKEKUHLUFVM
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x3B88BC0", Offset = "0x3B875C0", VA = "0x183B88BC0")]
		public static OIRALRYLARL<TResource> CRDBGFEPBCX<TResource, a>(this LIPKHNPTING<a, TResource> a, a b, [Optional] Func<a, CancellationToken, Task<TResource>>? resourceFactory) where TResource : notnull where a : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public static class KZDBMRIMJQD
	{
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		private sealed class LCIAQXZSAYX<a> : YPEBLPRGXEZ<a?> where a : class
		{
			[Cpp2IlInjected.Token(Token = "0x17000041")]
			public override Task<a?> QYNQTUXLHYU
			{
				[Cpp2IlInjected.Token(Token = "0x6000144")]
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000042")]
			public override CCAFLELIKTY<a?> OCFJYKPMWGC
			{
				[Cpp2IlInjected.Token(Token = "0x6000145")]
				[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x6984720", Offset = "0x6983120", VA = "0x186984720")]
			public LCIAQXZSAYX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "10")]
			protected override void GTQZIGGNINL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		private sealed class AROVPKOPACZ<a> : YPEBLPRGXEZ<a> where a : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private readonly a EJOVLYASCYS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private readonly Action<a>? BPNDWBLWBNW;

			[Cpp2IlInjected.Token(Token = "0x17000043")]
			public override Task<a> QYNQTUXLHYU
			{
				[Cpp2IlInjected.Token(Token = "0x6000148")]
				[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000044")]
			public override CCAFLELIKTY<a> OCFJYKPMWGC
			{
				[Cpp2IlInjected.Token(Token = "0x6000149")]
				[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x72DF9E0", Offset = "0x72DE3E0", VA = "0x1872DF9E0")]
			public AROVPKOPACZ(a a, Action<a>? onDispose)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x72DF520", Offset = "0x72DDF20", VA = "0x1872DF520", Slot = "10")]
			protected override void GTQZIGGNINL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		private sealed class PORBLGOORUT<a> : YPEBLPRGXEZ<a> where a : notnull
		{
			[Cpp2IlInjected.Token(Token = "0x17000045")]
			public override Task<a> QYNQTUXLHYU
			{
				[Cpp2IlInjected.Token(Token = "0x600014C")]
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000046")]
			public override CCAFLELIKTY<a> OCFJYKPMWGC
			{
				[Cpp2IlInjected.Token(Token = "0x600014D")]
				[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600014E")]
			[Cpp2IlInjected.Address(RVA = "0x74E0520", Offset = "0x74DEF20", VA = "0x1874E0520")]
			public PORBLGOORUT(Exception a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "10")]
			protected override void GTQZIGGNINL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private sealed class DKTTWVJPOHP<a> : YPEBLPRGXEZ<a> where a : notnull
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000049")]
			[CompilerGenerated]
			private struct <<-ctor>g__Unwrap|7_0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public AsyncTaskMethodBuilder<a> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				public Task<OIRALRYLARL<a>> task;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000AF")]
				private TaskAwaiter<OIRALRYLARL<a>> <>u__1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				private TaskAwaiter<a> <>u__2;

				[Cpp2IlInjected.Token(Token = "0x6000156")]
				[Cpp2IlInjected.Address(RVA = "0x42084E0", Offset = "0x4206EE0", VA = "0x1842084E0", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000157")]
				[Cpp2IlInjected.Address(RVA = "0x4209580", Offset = "0x4207F80", VA = "0x184209580", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200004A")]
			[CompilerGenerated]
			private struct <<OnDispose>g__AwaitThenDispose|8_0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B2")]
				public AsyncTaskMethodBuilder <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B3")]
				public Task<OIRALRYLARL<a>> task;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B4")]
				private TaskAwaiter<OIRALRYLARL<a>> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000158")]
				[Cpp2IlInjected.Address(RVA = "0x420DE70", Offset = "0x420C870", VA = "0x18420DE70", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000159")]
				[Cpp2IlInjected.Address(RVA = "0x420E600", Offset = "0x420D000", VA = "0x18420E600", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			private readonly Task<OIRALRYLARL<a>> GYMABWPVJFB;

			[Cpp2IlInjected.Token(Token = "0x17000047")]
			public override Task<a> QYNQTUXLHYU
			{
				[Cpp2IlInjected.Token(Token = "0x6000150")]
				[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000048")]
			public override CCAFLELIKTY<a> OCFJYKPMWGC
			{
				[Cpp2IlInjected.Token(Token = "0x6000151")]
				[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x5392FC0", Offset = "0x53919C0", VA = "0x185392FC0")]
			public DKTTWVJPOHP(Task<OIRALRYLARL<a>> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x5392620", Offset = "0x5391020", VA = "0x185392620", Slot = "10")]
			protected override void GTQZIGGNINL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x5392E80", Offset = "0x5391880", VA = "0x185392E80")]
			[AsyncStateMachine(typeof(DKTTWVJPOHP<>.<<-ctor>g__Unwrap|7_0>d))]
			[CompilerGenerated]
			internal static Task<a> XSWXNTZCGDH(Task<OIRALRYLARL<a>> a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x5392AA0", Offset = "0x53914A0", VA = "0x185392AA0")]
			[AsyncStateMachine(typeof(DKTTWVJPOHP<>.<<OnDispose>g__AwaitThenDispose|8_0>d))]
			[CompilerGenerated]
			internal static Task QESQQOLSQML(Task<OIRALRYLARL<a>> a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004B")]
		private sealed class QIXFDFRFCYP<a, b> : YPEBLPRGXEZ<b> where a : notnull where b : notnull
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x200004C")]
			[CompilerGenerated]
			private struct <<-ctor>g__Transform|7_0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B8")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000B9")]
				public AsyncTaskMethodBuilder<b> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000BA")]
				public Func<a, b> transformFunc;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000BB")]
				public Task<a> innerTask;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000BC")]
				private Func<a, b> <>7__wrap1;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000BD")]
				private TaskAwaiter<a> <>u__1;

				[Cpp2IlInjected.Token(Token = "0x600015F")]
				[Cpp2IlInjected.Address(RVA = "0x4207A50", Offset = "0x4206450", VA = "0x184207A50", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000160")]
				[Cpp2IlInjected.Address(RVA = "0x4208370", Offset = "0x4206D70", VA = "0x184208370", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			private readonly OIRALRYLARL<a> BLTDZSGJQWY;

			[Cpp2IlInjected.Token(Token = "0x17000049")]
			public override Task<b> QYNQTUXLHYU
			{
				[Cpp2IlInjected.Token(Token = "0x600015A")]
				[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0", Slot = "8")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700004A")]
			public override CCAFLELIKTY<b> OCFJYKPMWGC
			{
				[Cpp2IlInjected.Token(Token = "0x600015B")]
				[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00", Slot = "9")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x772BE10", Offset = "0x772A810", VA = "0x18772BE10")]
			public QIXFDFRFCYP(OIRALRYLARL<a> a, Func<a, b> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015D")]
			[Cpp2IlInjected.Address(RVA = "0x772BBC0", Offset = "0x772A5C0", VA = "0x18772BBC0", Slot = "10")]
			protected override void GTQZIGGNINL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015E")]
			[Cpp2IlInjected.Address(RVA = "0x772BA50", Offset = "0x772A450", VA = "0x18772BA50")]
			[AsyncStateMachine(typeof(QIXFDFRFCYP<, >.<<-ctor>g__Transform|7_0>d))]
			[CompilerGenerated]
			internal static Task<b> BBPDUGOZQRU(Task<a> a, Func<a, b> b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3C0F6A0", Offset = "0x3C0E0A0", VA = "0x183C0F6A0")]
		public static OIRALRYLARL<T> Empty<T>() where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x3C0F8E0", Offset = "0x3C0E2E0", VA = "0x183C0F8E0")]
		public static OIRALRYLARL<T> QBABTPHGZIM<T>(T a, [Optional] Action<T>? onDispose) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x3C0F770", Offset = "0x3C0E170", VA = "0x183C0F770")]
		public static OIRALRYLARL<T> IREWSFEBNKC<T>(Exception a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x3C0F5C0", Offset = "0x3C0DFC0", VA = "0x183C0F5C0")]
		public static OIRALRYLARL<T> AMZSEUWWXPO<T>(Task<OIRALRYLARL<T>> a) where T : notnull
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x3C0FA00", Offset = "0x3C0E400", VA = "0x183C0FA00")]
		public static OIRALRYLARL<TOut> Transform<TOut, TIn>(OIRALRYLARL<TIn> handle, Func<TIn, TOut> transformFunc) where TOut : notnull where TIn : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public abstract class YPEBLPRGXEZ<a> : OIRALRYLARL<a>, OEGCWZLZCPE, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private static readonly string DSKAPGKWVHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private readonly DisposeReminder JMPFDVETGXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private bool ICYNOWPKTPY;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public bool AJRBHITXSUS
		{
			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0xE38330", Offset = "0xE36D30", VA = "0x180E38330", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public abstract Task<a> QYNQTUXLHYU
		{
			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(Slot = "8")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public abstract CCAFLELIKTY<a> OCFJYKPMWGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(Slot = "9")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x50FACC0", Offset = "0x50F96C0", VA = "0x1850FACC0")]
		public YPEBLPRGXEZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0x50FA940", Offset = "0x50F9340", VA = "0x1850FA940", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(Slot = "10")]
		protected abstract void GTQZIGGNINL();
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public abstract class YOOGTVJOUWY<a, b> : YPEBLPRGXEZ<b> where a : Task
	{
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		[CompilerGenerated]
		private sealed class BEKRWCFQTJI
		{
			[StructLayout((LayoutKind)3)]
			[Cpp2IlInjected.Token(Token = "0x2000050")]
			private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
			{
				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C6")]
				public int <>1__state;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public AsyncTaskMethodBuilder<b> <>t__builder;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public a originalTask;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public BEKRWCFQTJI <>4__this;

				[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				private TaskAwaiter <>u__1;

				[Cpp2IlInjected.Token(Token = "0x6000170")]
				[Cpp2IlInjected.Address(RVA = "0x4207610", Offset = "0x4206010", VA = "0x184207610", Slot = "4")]
				private void MoveNext()
				{
				}

				[Cpp2IlInjected.Token(Token = "0x6000171")]
				[Cpp2IlInjected.Address(RVA = "0x42078E0", Offset = "0x42062E0", VA = "0x1842078E0", Slot = "5")]
				[DebuggerHidden]
				private void SetStateMachine(IAsyncStateMachine stateMachine)
				{
				}
			}

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public YOOGTVJOUWY<a, b> XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			public CancellationToken EYCXUCYSRNG;

			[Cpp2IlInjected.Token(Token = "0x600016E")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public BEKRWCFQTJI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016F")]
			[Cpp2IlInjected.Address(RVA = "0x4EFE7E0", Offset = "0x4EFD1E0", VA = "0x184EFE7E0")]
			[AsyncStateMachine(typeof(YOOGTVJOUWY<, >.BEKRWCFQTJI.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
			internal Task<b> JPUROXXFMLF(a a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private readonly Task<b> DVYATYCHJJS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		protected readonly CancellationTokenSource OOMRIGYHHNU;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public override Task<b> QYNQTUXLHYU
		{
			[Cpp2IlInjected.Token(Token = "0x6000168")]
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public override CCAFLELIKTY<b> OCFJYKPMWGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000169")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(RVA = "0x50FA190", Offset = "0x50F8B90", VA = "0x1850FA190")]
		protected YOOGTVJOUWY(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(RVA = "0x50FA140", Offset = "0x50F8B40", VA = "0x1850FA140", Slot = "10")]
		protected override void GTQZIGGNINL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		protected abstract b USEWYPEDCXJ(a a);

		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		protected abstract void ASDBTXBSROC();
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public class GWBMUCWKHNJ<a> : YPEBLPRGXEZ<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		private readonly ULKKXRJFDXF<Task<a>> UQUJULZCLMN;

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public override Task<a> QYNQTUXLHYU
		{
			[Cpp2IlInjected.Token(Token = "0x6000172")]
			[Cpp2IlInjected.Address(RVA = "0xFA46A0", Offset = "0xFA30A0", VA = "0x180FA46A0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public override CCAFLELIKTY<a> OCFJYKPMWGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000173")]
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x6451E50", Offset = "0x6450850", VA = "0x186451E50")]
		public GWBMUCWKHNJ(ULKKXRJFDXF<Task<a>> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6451DE0", Offset = "0x64507E0", VA = "0x186451DE0", Slot = "10")]
		protected override void GTQZIGGNINL()
		{
		}
	}
}
namespace RecRoom.DataStructures.Hashing
{
	[Cpp2IlInjected.Token(Token = "0x2000052")]
	public static class MEUVLBHAIEV
	{
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public static readonly HashAlgorithmName ZAVLOCCLZLL;

		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private static readonly ThreadLocal<IncrementalHash> NVUAETZIESM;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x9973FC0", Offset = "0x99729C0", VA = "0x189973FC0")]
		public static int LIBQIZZTEQS(this DEGJOGATLXO a, IncrementalHash b, byte[] c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x9974050", Offset = "0x9972A50", VA = "0x189974050")]
		public static bool UAANCUQBAWP([CanBeNull] this DEGJOGATLXO hashableAsset)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x99743C0", Offset = "0x9972DC0", VA = "0x1899743C0")]
		public static bool UAANCUQBAWP([CanBeNull] this DEGJOGATLXO hashableAsset, [Out] string a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x99740B0", Offset = "0x9972AB0", VA = "0x1899740B0")]
		public static bool UAANCUQBAWP([CanBeNull] this DEGJOGATLXO hashableAsset, IncrementalHash a, byte[] b, [Out] string c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x9973F30", Offset = "0x9972930", VA = "0x189973F30")]
		private static bool EPQRJBONSRZ(byte[] a, Span<byte> b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public static class WGGZJOIMMWP
	{
		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x9978080", Offset = "0x9976A80", VA = "0x189978080")]
		public static int UTBSMJGNHHK(HashAlgorithmName a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x4150700", Offset = "0x414F100", VA = "0x184150700")]
		public static int LIBQIZZTEQS<a>(this a a, byte[] b, IncrementalHash c, byte[] d) where a : WEUCVMBDRNK
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public interface WEUCVMBDRNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void AppendToHash([NotNull] IncrementalHash hash);
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public interface DEGJOGATLXO : WEUCVMBDRNK
	{
		[Cpp2IlInjected.Token(Token = "0x17000052")]
		[CanBeNull]
		byte[] NEQGHXWDYQO
		{
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		[CanBeNull]
		byte[] GUCOTNJEQKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public static class UYYFFVUIMPD
	{
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private static bool XVNEFECIUQV;

		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private static readonly ArrayPool<byte> QVNRWWKOQSM;

		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		private static readonly ArrayPool<char> KGXJBKGGFQE;

		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private static readonly Encoding KAOQESLNZGH;

		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private static readonly ThreadLocal<Encoder> MVXBANVACBI;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x40E1780", Offset = "0x40E0180", VA = "0x1840E1780")]
		public static void JOKGSPRNHTV<b>(this IncrementalHash a, [CanBeNull] b component) where b : Component
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x40E16F0", Offset = "0x40E00F0", VA = "0x1840E16F0")]
		public static void EMJKZVGVFAN<c>(this IncrementalHash a, [CanBeNull] c hashable) where c : WEUCVMBDRNK
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x40E2C00", Offset = "0x40E1600", VA = "0x1840E2C00")]
		public static void TLKWQQXZZLU<d>(this IncrementalHash a, [CanBeNull] IList<d> hashablesList) where d : WEUCVMBDRNK
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x9977250", Offset = "0x9975C50", VA = "0x189977250")]
		private static bool FLBFIVJJSFK([CanBeNull] WEUCVMBDRNK hashable)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x9977570", Offset = "0x9975F70", VA = "0x189977570")]
		public static void QKVUYSDFRHO(this IncrementalHash a, string? stringValue)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x99770E0", Offset = "0x9975AE0", VA = "0x1899770E0")]
		public static void CYYVNWWVORR(this IncrementalHash a, long b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x99773A0", Offset = "0x9975DA0", VA = "0x1899773A0")]
		public static void GCAHHUYSASS(this IncrementalHash a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x9977AD0", Offset = "0x99764D0", VA = "0x189977AD0")]
		public static void SAXOKWIJMIF(this IncrementalHash a, short b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x99779C0", Offset = "0x99763C0", VA = "0x1899779C0")]
		public static void RRLODABONJZ(this IncrementalHash a, byte b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x9977C40", Offset = "0x9976640", VA = "0x189977C40")]
		public static void SOQIAJTGBFM(this IncrementalHash a, bool b, bool c = false, bool d = false, bool e = false, bool f = false, bool g = false, bool h = false, bool i = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x40E1840", Offset = "0x40E0240", VA = "0x1840E1840")]
		public static void KYPXOADCISU<e>(this IncrementalHash a, e b) where e : struct, Enum, IConvertible
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x9977340", Offset = "0x9975D40", VA = "0x189977340")]
		public static void GBWJXHOGIQN(this IncrementalHash a, float b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x9977960", Offset = "0x9976360", VA = "0x189977960")]
		public static void RJHGKBFZCPQ(this IncrementalHash a, ulong b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x9977510", Offset = "0x9975F10", VA = "0x189977510")]
		public static void NHUPCTQJFXX(this IncrementalHash a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x99772E0", Offset = "0x9975CE0", VA = "0x1899772E0")]
		public static void FLTOVCLFFDQ(this IncrementalHash a, ushort b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x9976FB0", Offset = "0x99759B0", VA = "0x189976FB0")]
		public static void BLQDNRBVYZJ(this IncrementalHash a, Vector3 b)
		{
		}
	}
}
namespace RecRoom.DataStructures.Exceptions
{
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public class DataDesyncException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x9973B90", Offset = "0x9972590", VA = "0x189973B90")]
		public DataDesyncException(string message)
		{
		}
	}
}
namespace RecRoom.Core.Scripts.DataStructures
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public abstract class SUMYYHSKDBH
	{
		[Cpp2IlInjected.Token(Token = "0x200005B")]
		public delegate void OnStateChange(ushort currentStateId, ushort previousStateId, ushort currentSubStateId, ushort previousSubStateId);

		[Cpp2IlInjected.Token(Token = "0x200005C")]
		public delegate void StateTransition(ushort otherStateId, ushort otherSubStateId);

		[Cpp2IlInjected.Token(Token = "0x200005D")]
		public delegate void StateUpdate();

		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public const ushort TSIZWTQAINQ = 65535;

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		protected SUMYYHSKDBH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public abstract class YIDJIQVWXBM<a> : SUMYYHSKDBH where a : YIDJIQVWXBM<a>.REETLFKNBQZ
	{
		[Cpp2IlInjected.Token(Token = "0x200005F")]
		public interface REETLFKNBQZ
		{
			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			StateTransition QVQROEVKVAO
			{
				[Cpp2IlInjected.Token(Token = "0x60001BC")]
				[Cpp2IlInjected.Address(Slot = "0")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700005C")]
			StateTransition GTJVSMNZAWA
			{
				[Cpp2IlInjected.Token(Token = "0x60001BD")]
				[Cpp2IlInjected.Address(Slot = "1")]
				get;
			}

			[Cpp2IlInjected.Token(Token = "0x1700005D")]
			StateUpdate ITOORKOUXBP
			{
				[Cpp2IlInjected.Token(Token = "0x60001BE")]
				[Cpp2IlInjected.Address(Slot = "2")]
				get;
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private Dictionary<uint, a> PSNQABKWNKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private StateUpdate KXMOZJVOKSX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private StateUpdate DZCPYILSDGM;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public bool BJHOJFKGBXN
		{
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xEB2260", Offset = "0xEB0C60", VA = "0x180EB2260")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xD19FA0", Offset = "0xD189A0", VA = "0x180D19FA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public ushort ABIYMTFYIAW
		{
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0x12D7DC0", Offset = "0x12D67C0", VA = "0x1812D7DC0")]
			[CompilerGenerated]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0x12D8180", Offset = "0x12D6B80", VA = "0x1812D8180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public ushort TJJVLPOVDCE
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x50F2E50", Offset = "0x50F1850", VA = "0x1850F2E50")]
			[CompilerGenerated]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x50F5120", Offset = "0x50F3B20", VA = "0x1850F5120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public ushort RBOPCNHIRRG
		{
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0xF82270", Offset = "0xF80C70", VA = "0x180F82270")]
			[CompilerGenerated]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xF823C0", Offset = "0xF80DC0", VA = "0x180F823C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public ushort COMCVYINEXQ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0x50F5110", Offset = "0x50F3B10", VA = "0x1850F5110")]
			[CompilerGenerated]
			get
			{
				return default(ushort);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x50F2E40", Offset = "0x50F1840", VA = "0x1850F2E40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		protected bool VBTDYOUMEOZ
		{
			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x12D7B60", Offset = "0x12D6560", VA = "0x1812D7B60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		protected bool QSMPTOCMVSG
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x1B1D3C0", Offset = "0x1B1BDC0", VA = "0x181B1D3C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x14000001")]
		public event OnStateChange TMSMEXHMKTU
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x50F4CA0", Offset = "0x50F36A0", VA = "0x1850F4CA0")]
			[CompilerGenerated]
			add
			{
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x50F30D0", Offset = "0x50F1AD0", VA = "0x1850F30D0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x50F2E60", Offset = "0x50F1860", VA = "0x1850F2E60")]
		private a GSLKNPEEQKH(ushort a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x50F4BA0", Offset = "0x50F35A0", VA = "0x1850F4BA0")]
		private a UFFJHEJCUGU(ushort a, ushort b)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x50F3320", Offset = "0x50F1D20", VA = "0x1850F3320")]
		protected a MDGIQMWNVGK(uint a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x50F5230", Offset = "0x50F3C30", VA = "0x1850F5230")]
		protected YIDJIQVWXBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x50F3260", Offset = "0x50F1C60", VA = "0x1850F3260")]
		public void KLHGLIFYFCC(ushort a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x50F3170", Offset = "0x50F1B70", VA = "0x1850F3170")]
		public void KLHGLIFYFCC(ushort a, ushort b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x50F32A0", Offset = "0x50F1CA0", VA = "0x1850F32A0", Slot = "4")]
		protected virtual void KLHGLIFYFCC(uint a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x50F3480", Offset = "0x50F1E80", VA = "0x1850F3480")]
		protected void QHQQUZWUGOQ(uint a, uint b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x50F4870", Offset = "0x50F3270", VA = "0x1850F4870")]
		protected void RELLFJNXHAM(ushort a, ushort b, a c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x50F4730", Offset = "0x50F3130", VA = "0x1850F4730")]
		private void QNSUWMNLGQO(uint a, a b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x50F4F90", Offset = "0x50F3990", VA = "0x1850F4F90")]
		protected void XIMHXAQMFMK(float a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x50F4A10", Offset = "0x50F3410", VA = "0x1850F4A10")]
		protected uint RQFFOKTQPGH(ushort a, ushort b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x50F3020", Offset = "0x50F1A20", VA = "0x1850F3020")]
		protected ushort HIDFIADPYMR(uint a)
		{
			return default(ushort);
		}

		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x50F4A20", Offset = "0x50F3420", VA = "0x1850F4A20")]
		protected ushort TEAMEGPHIXY(uint a)
		{
			return default(ushort);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public abstract class DXEAUKSYLSK : YIDJIQVWXBM<DXEAUKSYLSK.State>
	{
		[Cpp2IlInjected.Token(Token = "0x2000061")]
		public class State : REETLFKNBQZ
		{
			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			public StateTransition QVQROEVKVAO
			{
				[Cpp2IlInjected.Token(Token = "0x60001C3")]
				[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001C4")]
				[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			public StateTransition GTJVSMNZAWA
			{
				[Cpp2IlInjected.Token(Token = "0x60001C5")]
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001C6")]
				[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public StateUpdate ITOORKOUXBP
			{
				[Cpp2IlInjected.Token(Token = "0x60001C7")]
				[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0", Slot = "6")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x60001C8")]
				[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
				[CompilerGenerated]
				set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public State()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x9973940", Offset = "0x9972340", VA = "0x189973940")]
		public void RECPLXMNICZ(ushort a, StateTransition b, StateTransition c, StateUpdate d)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x9973A20", Offset = "0x9972420", VA = "0x189973A20")]
		public void RECPLXMNICZ(ushort a, ushort b, StateTransition c, StateTransition d, StateUpdate e)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x9973B00", Offset = "0x9972500", VA = "0x189973B00")]
		public void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x9973B50", Offset = "0x9972550", VA = "0x189973B50")]
		protected DXEAUKSYLSK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public class ZDFLQXATVXG : DXEAUKSYLSK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private bool YBKPTVRZSKE;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public bool YJTUVSGDJFT
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0xF85FC0", Offset = "0xF849C0", VA = "0x180F85FC0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0xF85920", Offset = "0xF84320", VA = "0x180F85920")]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x99781D0", Offset = "0x9976BD0", VA = "0x1899781D0")]
		public void Initialize(ushort initialStateId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x9978230", Offset = "0x9976C30", VA = "0x189978230")]
		public void Initialize(ushort initialStateId, ushort initialSubStateId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x9973B50", Offset = "0x9972550", VA = "0x189973B50")]
		public ZDFLQXATVXG()
		{
		}
	}
}
namespace RecRoom.Core.DataStructures
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public abstract class SXLVAPLPVIX<a, b> : IDisposable where a : class where b : class
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		internal class JPVTQQXPYYZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public b FAZYPCYHAJB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public b WKYFTFFHETD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public PriorityClaim QDUDBVDWRMU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public List<PriorityClaim> TNMBPSFBHAV;

			[Cpp2IlInjected.Token(Token = "0x60001E3")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public JPVTQQXPYYZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		internal struct PriorityClaim : IComparable<PriorityClaim>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public int priority;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public a claim;

			[Cpp2IlInjected.Token(Token = "0x60001E4")]
			[Cpp2IlInjected.Address(RVA = "0x19BF880", Offset = "0x19BE280", VA = "0x1819BF880")]
			public PriorityClaim(int priority, a claim)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x76A44D0", Offset = "0x76A2ED0", VA = "0x1876A44D0")]
			public bool CKPLFEBQDVU([In] PriorityClaim other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x76A45A0", Offset = "0x76A2FA0", VA = "0x1876A45A0")]
			public bool XLCBHQJAMKJ([In] PriorityClaim other)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x76A4530", Offset = "0x76A2F30", VA = "0x1876A4530", Slot = "4")]
			public int CompareTo(PriorityClaim other)
			{
				return default(int);
			}

			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x76A4540", Offset = "0x76A2F40", VA = "0x1876A4540", Slot = "3")]
			public override string ToString()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000066")]
		public enum Mode
		{
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			FirstOwner,
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			ClosestAncestor
		}

		[Cpp2IlInjected.Token(Token = "0x2000067")]
		[CompilerGenerated]
		private sealed class BNTHFFDPNXT : IEnumerable<b>, IEnumerable, IEnumerator<b>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			private int AKEYILDVZEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			private b OCEUOVLOMMW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			private int AYLQLTGRUAA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private b GQSOVWUQDWG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public b EMJXNAGJYDT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public SXLVAPLPVIX<a, b> XRWOWCJVPDZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			private b HJUEOTAZEVK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public b ODWAKSGWPYH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			private bool PWMCGWWRNXA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public bool WFUFQIQRCRZ;

			[Cpp2IlInjected.Token(Token = "0x17000062")]
			private b JYAFIJBBATW
			{
				[Cpp2IlInjected.Token(Token = "0x60001EC")]
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000063")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x60001EE")]
				[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x1031740", Offset = "0x1030140", VA = "0x181031740")]
			[DebuggerHidden]
			public BNTHFFDPNXT(int a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150", Slot = "7")]
			[DebuggerHidden]
			private void QRJGYHJVBJO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EB")]
			[Cpp2IlInjected.Address(RVA = "0x4F23D20", Offset = "0x4F22720", VA = "0x184F23D20", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001ED")]
			[Cpp2IlInjected.Address(RVA = "0x4F23E00", Offset = "0x4F22800", VA = "0x184F23E00", Slot = "10")]
			[DebuggerHidden]
			private void QWPEWWNKZVD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001EF")]
			[Cpp2IlInjected.Address(RVA = "0x4F23C40", Offset = "0x4F22640", VA = "0x184F23C40", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<b> CWPNTOEZKZJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F0")]
			[Cpp2IlInjected.Address(RVA = "0x4F23E40", Offset = "0x4F22840", VA = "0x184F23E40", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator UJBMGYABLAM()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private static readonly PMZJHKNHCHI<JPVTQQXPYYZ> HJJCTPDPQDB;

		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private static readonly PMZJHKNHCHI<List<PriorityClaim>> WUMBVCHZEQH;

		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private static int BRRELZDWOND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		internal readonly Dictionary<a, b> XMYHDWEDIGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		internal readonly Dictionary<b, JPVTQQXPYYZ> BDJNDFOQXAT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		private Mode UHDXYKHTRPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		private bool DZPJVTCESGG;

		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(Slot = "5")]
		protected abstract b QIRLZLLLSZZ(b a);

		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(Slot = "6")]
		protected abstract void CXUHAAPBZZB(b a, a b, a c);

		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x7A09540", Offset = "0x7A07F40", VA = "0x187A09540")]
		public SXLVAPLPVIX(Mode a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0x7A07F20", Offset = "0x7A06920", VA = "0x187A07F20")]
		public void ETIBIYMFKWA(b a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x7A07DC0", Offset = "0x7A067C0", VA = "0x187A07DC0")]
		public void EEWPTHZKGIO(a a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x7A07BF0", Offset = "0x7A065F0", VA = "0x187A07BF0", Slot = "7")]
		public virtual void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7A085B0", Offset = "0x7A06FB0", VA = "0x187A085B0")]
		private void KTXOLRCUUTJ(a a, b b, b c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7A08070", Offset = "0x7A06A70", VA = "0x187A08070")]
		private int GUBHOUFMIRX()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7A081C0", Offset = "0x7A06BC0", VA = "0x187A081C0")]
		private void JDAMUHTXMRG(a a, b b, b c, int d = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D8")]
		[Cpp2IlInjected.Address(RVA = "0x7A080D0", Offset = "0x7A06AD0", VA = "0x187A080D0")]
		private void HNEFEACWAHX(PriorityClaim a, JPVTQQXPYYZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001D9")]
		[Cpp2IlInjected.Address(RVA = "0x7A08790", Offset = "0x7A07190", VA = "0x187A08790")]
		private void RKORANBKUKG(a a, b b, b c, int d = 0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x7A08D10", Offset = "0x7A07710", VA = "0x187A08D10")]
		private void YSTDXOVYBYT(PriorityClaim a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x7A07FA0", Offset = "0x7A069A0", VA = "0x187A07FA0")]
		private void FPPGEUMPDZN(PriorityClaim a, JPVTQQXPYYZ b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x7A08C00", Offset = "0x7A07600", VA = "0x187A08C00")]
		private void VMXQWSYJTVI(JPVTQQXPYYZ a, bool b = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x7A090A0", Offset = "0x7A07AA0", VA = "0x187A090A0")]
		private void YZBGRMJWEUQ(JPVTQQXPYYZ a, b b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x7A07B10", Offset = "0x7A06510", VA = "0x187A07B10")]
		[IteratorStateMachine(typeof(SXLVAPLPVIX<, >.BNTHFFDPNXT))]
		private IEnumerable<b> BBYVXZSINCS(b a, b b, bool c = false)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0x7A07940", Offset = "0x7A06340", VA = "0x187A07940")]
		private JPVTQQXPYYZ AVTIKFEHOHU(b a, b b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x7A08650", Offset = "0x7A07050", VA = "0x187A08650")]
		private JPVTQQXPYYZ OXLPESGRLEF(b a, b b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x7A08A90", Offset = "0x7A07490", VA = "0x187A08A90")]
		private void VKUARTFSEDL(JPVTQQXPYYZ a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public class WEWSIDRDOGP<a> : IEnumerable<WEWSIDRDOGP<a>.Pair>, IEnumerable
	{
		[Cpp2IlInjected.Token(Token = "0x2000069")]
		public struct Pair
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public a value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public int index;
		}

		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public class NGEQUJIPQFB : IEnumerator<Pair>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000105")]
			private WEWSIDRDOGP<a> EEVVFEZVAXH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000106")]
			private int ALPNKJZOFUT;

			[Cpp2IlInjected.Token(Token = "0x17000066")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x6000201")]
				[Cpp2IlInjected.Address(RVA = "0x7226240", Offset = "0x7224C40", VA = "0x187226240", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000067")]
			public Pair Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000202")]
				[Cpp2IlInjected.Address(RVA = "0x7226580", Offset = "0x7224F80", VA = "0x187226580", Slot = "4")]
				get
				{
					return default(Pair);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000203")]
			[Cpp2IlInjected.Address(RVA = "0x72264A0", Offset = "0x7224EA0", VA = "0x1872264A0")]
			public NGEQUJIPQFB(WEWSIDRDOGP<a> a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x72263A0", Offset = "0x7224DA0", VA = "0x1872263A0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x5C46A20", Offset = "0x5C45420", VA = "0x185C46A20", Slot = "8")]
			public void Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0xF854D0", Offset = "0xF83ED0", VA = "0x180F854D0", Slot = "5")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006B")]
		private struct ListEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public bool hasValue;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public a value;
		}

		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private const int SMHTQYYEIPV = 32;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private readonly Dictionary<a, int> DFSLYPVKIMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private ListEntry[] EUYVVTCXDWT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		private int KYBPYYWEDGC;

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public int LXRMZMCXUER
		{
			[Cpp2IlInjected.Token(Token = "0x60001F1")]
			[Cpp2IlInjected.Address(RVA = "0xD38090", Offset = "0xD36A90", VA = "0x180D38090")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Cpp2IlInjected.Token(Token = "0x60001F2")]
			[Cpp2IlInjected.Address(RVA = "0xF21A50", Offset = "0xF20450", VA = "0x180F21A50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public int PUCTPTIOQGU
		{
			[Cpp2IlInjected.Token(Token = "0x60001F3")]
			[Cpp2IlInjected.Address(RVA = "0x6355090", Offset = "0x6353A90", VA = "0x186355090")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x871F070", Offset = "0x871DA70", VA = "0x18871F070")]
		public WEWSIDRDOGP(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x871ECD0", Offset = "0x871D6D0", VA = "0x18871ECD0")]
		public WEWSIDRDOGP(Pair[] a, bool b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x871DEC0", Offset = "0x871C8C0", VA = "0x18871DEC0")]
		public int XNHMPNYTZOY()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x871DAD0", Offset = "0x871C4D0", VA = "0x18871DAD0")]
		private int XIRZSIYYRZV()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x871D5A0", Offset = "0x871BFA0", VA = "0x18871D5A0", Slot = "6")]
		protected virtual uint ULPTYCYGGYL(uint a, a b)
		{
			return default(uint);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x871CF10", Offset = "0x871B910", VA = "0x18871CF10")]
		public bool FIVIJQPLKOJ(a a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x871D0D0", Offset = "0x871BAD0", VA = "0x18871D0D0")]
		public int FQRMSDGDMRP(a a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x871D230", Offset = "0x871BC30", VA = "0x18871D230")]
		public a OMHWMJXNOYY(int a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x871C300", Offset = "0x871AD00", VA = "0x18871C300")]
		public bool EQRSINERSDL(a a, bool b = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x871CBA0", Offset = "0x871B5A0", VA = "0x18871CBA0")]
		public bool EQRSINERSDL(a a, int b, bool c = false)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x871D5D0", Offset = "0x871BFD0", VA = "0x18871D5D0")]
		private int XHUIOUJSTBO(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x871D130", Offset = "0x871BB30", VA = "0x18871D130", Slot = "5")]
		private IEnumerator UJBMGYABLAM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x871D130", Offset = "0x871BB30", VA = "0x18871D130", Slot = "4")]
		private IEnumerator<Pair> JVWNSPHVRVM()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class PMZJHKNHCHI<a> : IDisposable where a : new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private readonly Stack<a> TUEBNVZWFYL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		private readonly List<a> TKRPZMUHDHX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private readonly int AAZWSQIMRDI;

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x74DB870", Offset = "0x74DA270", VA = "0x1874DB870")]
		public static PMZJHKNHCHI<a> NGBFNYBETSE(int a = 0, int b = 100)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x74DC3F0", Offset = "0x74DADF0", VA = "0x1874DC3F0")]
		public PMZJHKNHCHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x74DC040", Offset = "0x74DAA40", VA = "0x1874DC040")]
		public PMZJHKNHCHI(int a, int b = 2147483647, bool c = true)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x74DB060", Offset = "0x74D9A60", VA = "0x1874DB060")]
		public a Acquire()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x74DB920", Offset = "0x74DA320", VA = "0x1874DB920")]
		public void Release(a value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x74DB5D0", Offset = "0x74D9FD0", VA = "0x1874DB5D0")]
		private void EHUENPJUFPD(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x74DB770", Offset = "0x74DA170", VA = "0x1874DB770")]
		private void JXQUNFSSTRY(a a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x74DB1C0", Offset = "0x74D9BC0", VA = "0x1874DB1C0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x74DBE50", Offset = "0x74DA850", VA = "0x1874DBE50")]
		private void STSRMAAKGUD(IEnumerable<a> a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public class GBKMLTBWJZA<a> where a : IEquatable<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		private Dictionary<int, a> NEVDAWWBIMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		private a RQXSDYAAMXJ;

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public virtual a UWOBBLEYMKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0xD77800", Offset = "0xD76200", VA = "0x180D77800", Slot = "4")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000211")]
			[Cpp2IlInjected.Address(RVA = "0x14214C0", Offset = "0x141FEC0", VA = "0x1814214C0", Slot = "5")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x643E440", Offset = "0x643CE40", VA = "0x18643E440")]
		public bool HATUIBUWRBD(a a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x643E830", Offset = "0x643D230", VA = "0x18643E830")]
		public bool OYXSKSWDQEW(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000214")]
		[Cpp2IlInjected.Address(RVA = "0x643DD70", Offset = "0x643C770", VA = "0x18643DD70")]
		public a DYYIIZTZRFC(int a)
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000215")]
		[Cpp2IlInjected.Address(RVA = "0x643E790", Offset = "0x643D190", VA = "0x18643E790")]
		private bool MIYWELCZTBC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x643E9F0", Offset = "0x643D3F0", VA = "0x18643E9F0")]
		public bool YOABBVTNACT(int a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x643EA20", Offset = "0x643D420", VA = "0x18643EA20")]
		public GBKMLTBWJZA()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class MSWDLAGKDAH<a>
	{
		[Cpp2IlInjected.Token(Token = "0x200006F")]
		protected struct Entry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public a Value;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public int Priority;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		protected readonly List<Entry> QXUGJWMLOIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private a WGFUUCICSNO;

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public int PUCTPTIOQGU
		{
			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x286DE80", Offset = "0x286C880", VA = "0x18286DE80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x6FF8C50", Offset = "0x6FF7650", VA = "0x186FF8C50")]
		public bool Contains(a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x6FF8930", Offset = "0x6FF7330", VA = "0x186FF8930")]
		public void Add(a value, int priority)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x6FF9E40", Offset = "0x6FF8840", VA = "0x186FF9E40")]
		public bool Remove(a value)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x6FF8BE0", Offset = "0x6FF75E0", VA = "0x186FF8BE0")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x6FF9670", Offset = "0x6FF8070", VA = "0x186FF9670")]
		public a LLZQVYTHGLE()
		{
			return (a)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x6FF96D0", Offset = "0x6FF80D0", VA = "0x186FF96D0")]
		protected void RJYSZBCFDNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x6FFA410", Offset = "0x6FF8E10", VA = "0x186FFA410")]
		public MSWDLAGKDAH()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[SerializeField]
		[Autofill(AutofillType.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x9974E90", Offset = "0x9973890", VA = "0x189974E90")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x9975160", Offset = "0x9973B60", VA = "0x189975160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x9975070", Offset = "0x9973A70", VA = "0x189975070")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x9974DE0", Offset = "0x99737E0", VA = "0x189974DE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x99750B0", Offset = "0x9973AB0", VA = "0x1899750B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x9974FC0", Offset = "0x99739C0", VA = "0x189974FC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x9974D50", Offset = "0x9973750", VA = "0x189974D50")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x79A9870", Offset = "0x79A8270", VA = "0x1879A9870", Slot = "4")]
		public virtual T VQJUTIPKGSH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		protected ResourcePrefabReference()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000072")]
	public interface ANLENNRALHL
	{
		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		ToolHierarchyCache YHWTKKAFJIQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000229")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public struct Enumerable<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			private readonly List<Component> list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			private readonly bool includeInactive;

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x1B2ED70", Offset = "0x1B2D770", VA = "0x181B2ED70")]
			public Enumerable(List<Component> list, bool includeInactive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x5C244C0", Offset = "0x5C22EC0", VA = "0x185C244C0")]
			public Enumerator<T> GetEnumerator()
			{
				return default(Enumerator<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x5C24350", Offset = "0x5C22D50", VA = "0x185C24350", Slot = "5")]
			private IEnumerator UJBMGYABLAM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x5C24350", Offset = "0x5C22D50", VA = "0x185C24350", Slot = "4")]
			private IEnumerator<T> EJVKVOJRYRR()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public struct Enumerator<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			private readonly List<Component> list;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private readonly bool includeInactive;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private int index;

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public T Current
			{
				[Cpp2IlInjected.Token(Token = "0x600023B")]
				[Cpp2IlInjected.Address(RVA = "0x5D0B7F0", Offset = "0x5D0A1F0", VA = "0x185D0B7F0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			private object ELQJLQJBXAL
			{
				[Cpp2IlInjected.Token(Token = "0x600023C")]
				[Cpp2IlInjected.Address(RVA = "0x5D09FE0", Offset = "0x5D089E0", VA = "0x185D09FE0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x5D0B470", Offset = "0x5D09E70", VA = "0x185D0B470")]
			public Enumerator(List<Component> list, bool includeInactive)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x5D09FD0", Offset = "0x5D089D0", VA = "0x185D09FD0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x5D0AC20", Offset = "0x5D09620", VA = "0x185D0AC20", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x5C0A2F0", Offset = "0x5C08CF0", VA = "0x185C0A2F0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static List<Component> MAAXLNRVOSG;

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
		private Dictionary<Type, List<Component>> IGIKAPVFWZU;

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x9976C80", Offset = "0x9975680", VA = "0x189976C80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x9976A80", Offset = "0x9975480", VA = "0x189976A80")]
		private void Initialize(GameObject go, bool force = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x99769F0", Offset = "0x99753F0", VA = "0x1899769F0")]
		public static void Initialize(GameObject go, ToolHierarchyCache cache)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x9976BE0", Offset = "0x99755E0", VA = "0x189976BE0")]
		public void Refresh()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x3FBEFC0", Offset = "0x3FBD9C0", VA = "0x183FBEFC0")]
		public void MFZKSPSXRIB<a>(Action<a> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x3FBEC00", Offset = "0x3FBD600", VA = "0x183FBEC00")]
		public b KAUCJJVAWGC<b>(bool a = false) where b : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x3FBEB50", Offset = "0x3FBD550", VA = "0x183FBEB50")]
		public Enumerable<c> ISYGKTXDOQD<c>(bool a = false) where c : class
		{
			return default(Enumerable<c>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x9976580", Offset = "0x9974F80", VA = "0x189976580")]
		public List<Component> BYQXWXWQVMW(Type a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x9976900", Offset = "0x9975300", VA = "0x189976900", Slot = "4")]
		public bool Equals(ToolHierarchyCache x, ToolHierarchyCache y)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x9976980", Offset = "0x9975380", VA = "0x189976980", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache obj)
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000076")]
	public class MZPAVGUYHAL<a>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private int XBMHEWCBHBX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		private int DOFYYIELMCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private List<a> PERNOGOIGCM;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public int PUCTPTIOQGU
		{
			[Cpp2IlInjected.Token(Token = "0x6000240")]
			[Cpp2IlInjected.Address(RVA = "0x27F36A0", Offset = "0x27F20A0", VA = "0x1827F36A0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public a AZIENLMDEDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000241")]
			[Cpp2IlInjected.Address(RVA = "0x7007B90", Offset = "0x7006590", VA = "0x187007B90")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public a GMKHKGDDQOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x70078E0", Offset = "0x70062E0", VA = "0x1870078E0")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public a UQQUBBBYJBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x7007D90", Offset = "0x7006790", VA = "0x187007D90")]
			get
			{
				return (a)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000244")]
		[Cpp2IlInjected.Address(RVA = "0x7008110", Offset = "0x7006B10", VA = "0x187008110")]
		public MZPAVGUYHAL(int a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000245")]
		[Cpp2IlInjected.Address(RVA = "0x7007240", Offset = "0x7005C40", VA = "0x187007240")]
		public void Add(a command)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000246")]
		[Cpp2IlInjected.Address(RVA = "0x7007660", Offset = "0x7006060", VA = "0x187007660")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000247")]
		[Cpp2IlInjected.Address(RVA = "0x7007FE0", Offset = "0x70069E0", VA = "0x187007FE0")]
		public void WCEIXMFCNSO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000248")]
		[Cpp2IlInjected.Address(RVA = "0x7007960", Offset = "0x7006360", VA = "0x187007960")]
		public void IJOZFFQCMEB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000249")]
		[Cpp2IlInjected.Address(RVA = "0x7008100", Offset = "0x7006B00", VA = "0x187008100")]
		public void XGWHMKEHVML()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600024A")]
		[Cpp2IlInjected.Address(RVA = "0x7007AD0", Offset = "0x70064D0", VA = "0x187007AD0")]
		public List<a> IWQXBOMVHAM()
		{
			return null;
		}
	}
}
namespace RecRoom.Core.DataStructures.Tokens
{
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class CKAEZMOWUEX<a>
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		private struct PrioritizedData
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public int Priority;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			public a Value;
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private readonly Dictionary<object, PrioritizedData> NEVDAWWBIMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		private readonly EqualityComparer<a> JWSIYDURTLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		private a RQXSDYAAMXJ;

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public virtual a UWOBBLEYMKE
		{
			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0xEF2E20", Offset = "0xEF1820", VA = "0x180EF2E20", Slot = "4")]
			get
			{
				return (a)null;
			}
			[Cpp2IlInjected.Token(Token = "0x600024C")]
			[Cpp2IlInjected.Address(RVA = "0x5046870", Offset = "0x5045270", VA = "0x185046870", Slot = "5")]
			protected set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public bool ZQOECVTTKUK
		{
			[Cpp2IlInjected.Token(Token = "0x600024D")]
			[Cpp2IlInjected.Address(RVA = "0x5042910", Offset = "0x5041310", VA = "0x185042910")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public object UDJKDUBZCZO
		{
			[Cpp2IlInjected.Token(Token = "0x600024E")]
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600024F")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(RVA = "0x5041F60", Offset = "0x5040960", VA = "0x185041F60")]
		public bool HATUIBUWRBD(a a, object b, int c)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000251")]
		[Cpp2IlInjected.Address(RVA = "0x5045940", Offset = "0x5044340", VA = "0x185045940")]
		public bool OYXSKSWDQEW(object a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x5045FC0", Offset = "0x50449C0", VA = "0x185045FC0")]
		public bool YOABBVTNACT(object a, [Out] a b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x5041700", Offset = "0x5040100", VA = "0x185041700")]
		public void Clear()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x50437F0", Offset = "0x50421F0", VA = "0x1850437F0")]
		private bool MIYWELCZTBC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x5047610", Offset = "0x5046010", VA = "0x185047610")]
		public CKAEZMOWUEX()
		{
		}
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
