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
		[Cpp2IlInjected.Address(RVA = "0x8C5550", Offset = "0x8C4950", VA = "0x1808C5550")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D1B210", Offset = "0x6D1A610", VA = "0x186D1B210")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8C5B80", Offset = "0x8C4F80", VA = "0x1808C5B80")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C5BC0", Offset = "0x8C4FC0", VA = "0x1808C5BC0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NCNFFFDAHBG : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1970D50", Offset = "0x1970150", VA = "0x181970D50")]
	public NCNFFFDAHBG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, OBEHHICAKLG, MCFPOFLGEIF, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x89CEC0", Offset = "0x89C2C0", VA = "0x18089CEC0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x89EF40", Offset = "0x89E340", VA = "0x18089EF40", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x89CED0", Offset = "0x89C2D0", VA = "0x18089CED0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9F9470", Offset = "0x9F8870", VA = "0x1809F9470", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash KOJHIJJELLP);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xA887D0", Offset = "0xA87BD0", VA = "0x180A887D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6D1C630", Offset = "0x6D1BA30", VA = "0x186D1C630")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6D1C5F0", Offset = "0x6D1B9F0", VA = "0x186D1C5F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6D1C670", Offset = "0x6D1BA70", VA = "0x186D1C670")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6D1C820", Offset = "0x6D1BC20", VA = "0x186D1C820")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6D1C790", Offset = "0x6D1BB90", VA = "0x186D1C790")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA89110", Offset = "0xA88510", VA = "0x180A89110")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xBD2900", Offset = "0xBD1D00", VA = "0x180BD2900")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6D1C5B0", Offset = "0x6D1B9B0", VA = "0x186D1C5B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6D1C700", Offset = "0x6D1BB00", VA = "0x186D1C700")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6D1C200", Offset = "0x6D1B600", VA = "0x186D1C200")]
	public void CopyBounds(SavedExtents OGKFFDCECEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6D1C500", Offset = "0x6D1B900", VA = "0x186D1C500")]
	public void SetLocalSpaceBounds(Bounds HFFIGINFPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xEC4020", Offset = "0xEC3420", VA = "0x180EC4020")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6D1C4F0", Offset = "0x6D1B8F0", VA = "0x186D1C4F0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6D1B9E0", Offset = "0x6D1ADE0", VA = "0x186D1B9E0")]
	private void CJBGEOHBKHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6D1C2F0", Offset = "0x6D1B6F0", VA = "0x186D1C2F0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6D1BB90", Offset = "0x6D1AF90", VA = "0x186D1BB90")]
	public static void CalculateLocalBoundsFor(GameObject NEMCGAENDDH, [Out] Bounds HFFIGINFPCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6D1C230", Offset = "0x6D1B630", VA = "0x186D1C230")]
	private static void LGGCALJBECL(Bounds LLNOONNFEHK, Color JPCJICGNBND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6D1C520", Offset = "0x6D1B920", VA = "0x186D1C520")]
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
		[Cpp2IlInjected.Address(RVA = "0x89A1A0", Offset = "0x8995A0", VA = "0x18089A1A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8A6060", Offset = "0x8A5460", VA = "0x1808A6060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x13351C0", Offset = "0x13345C0", VA = "0x1813351C0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4D36190", Offset = "0x4D35590", VA = "0x184D36190")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "4")]
	public virtual void FINPCMDIPDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
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
	[NCNFFFDAHBG]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4D35CE0", Offset = "0x4D350E0", VA = "0x184D35CE0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4D34420", Offset = "0x4D33820", VA = "0x184D34420", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4D36090", Offset = "0x4D35490", VA = "0x184D36090")]
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
	private sealed class GDPAFKKOMBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public GDPAFKKOMBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4007EE0", Offset = "0x40072E0", VA = "0x184007EE0")]
		internal int AJBBGBHJCKJ(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[NCNFFFDAHBG]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3BBBD70", Offset = "0x3BBB170", VA = "0x183BBBD70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3BBBDD0", Offset = "0x3BBB1D0", VA = "0x183BBBDD0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3BBBC50", Offset = "0x3BBB050", VA = "0x183BBBC50", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey PBFBBOFLBNL]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3BBBCB0", Offset = "0x3BBB0B0", VA = "0x183BBBCB0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3BBBB00", Offset = "0x3BBAF00", VA = "0x183BBBB00", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3BBB7A0", Offset = "0x3BBABA0", VA = "0x183BBB7A0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3BBAF40", Offset = "0x3BBA340", VA = "0x183BBAF40", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3BBAE10", Offset = "0x3BBA210", VA = "0x183BBAE10", Slot = "14")]
	protected virtual string BAECLNPNBIF(TKeyVal AIFHIMEOACL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3BBAE40", Offset = "0x3BBA240", VA = "0x183BBAE40", Slot = "4")]
	public bool ContainsKey(TKey PBFBBOFLBNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3BBB980", Offset = "0x3BBAD80", VA = "0x183BBB980", Slot = "5")]
	public bool TryGetValue(TKey PBFBBOFLBNL, [Out] TVal PFKKDHPJFEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3BBAEA0", Offset = "0x3BBA2A0", VA = "0x183BBAEA0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3BBAEA0", Offset = "0x3BBA2A0", VA = "0x183BBAEA0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3BBB9E0", Offset = "0x3BBADE0", VA = "0x183BBB9E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x89A1B0", Offset = "0x8995B0", VA = "0x18089A1B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x89CEC0", Offset = "0x89C2C0", VA = "0x18089CEC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
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
		[Cpp2IlInjected.Address(RVA = "0x416DA00", Offset = "0x416CE00", VA = "0x18416DA00")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	[NCNFFFDAHBG]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4D37B90", Offset = "0x4D36F90", VA = "0x184D37B90")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4D373D0", Offset = "0x4D367D0", VA = "0x184D373D0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4D36980", Offset = "0x4D35D80", VA = "0x184D36980", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class NEOPLCKPBOO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private class BJAEGMPHDFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public float LPNMJEDJOEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T FDJCHKNOIDG;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public BJAEGMPHDFN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class OAHHKNMEGOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public OAHHKNMEGOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x4A42C20", Offset = "0x4A42020", VA = "0x184A42C20")]
		internal bool FNAIJLOGPDB(BJAEGMPHDFN sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly float FLLHGMFJIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly float LOKCKDHFAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private List<BJAEGMPHDFN> MPEKAJLKCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private PAPCKMNGDME<BJAEGMPHDFN> OFMDCOLBEPB;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int INKGKNFFKAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x4935600", Offset = "0x4934A00", VA = "0x184935600")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x4936300", Offset = "0x4935700", VA = "0x184936300")]
	public NEOPLCKPBOO(float CLPLGILCJCJ, float JAILMJPFAAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x4936130", Offset = "0x4935530", VA = "0x184936130")]
	public bool OCJIADMFINN(float HEJHCAGJGFP, T PFKKDHPJFEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x49356E0", Offset = "0x4934AE0", VA = "0x1849356E0")]
	public IEnumerable<T> KGEFHKFJFOL(float HEJHCAGJGFP, [Optional] float? FANDDHDIDPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4935550", Offset = "0x4934950", VA = "0x184935550")]
	public void FEPOBOIDOBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4935DC0", Offset = "0x49351C0", VA = "0x184935DC0")]
	private void MNNHLJADFLN(float HEJHCAGJGFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class JJCCGAPGBAL<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct CFBFHAOOPDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public T FDJCHKNOIDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public float LCDJCJPGOEL;
	}

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static float ENMCFOMEBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private List<T> JGELAAMDOHJ;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private const int BMKJMHLCIOJ = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private CFBFHAOOPDF[] EFKOIGFMOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int COPNNLEGGAJ;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float NAAJKDFCIFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xCC5590", Offset = "0xCC4990", VA = "0x180CC5590")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xCEC7C0", Offset = "0xCEBBC0", VA = "0x180CEC7C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x442F830", Offset = "0x442EC30", VA = "0x18442F830")]
	public JJCCGAPGBAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x442F700", Offset = "0x442EB00", VA = "0x18442F700")]
	public JJCCGAPGBAL(int JKIIGJDNBMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x442E970", Offset = "0x442DD70", VA = "0x18442E970")]
	public void FNBCENOGBNB(float HEJHCAGJGFP, T PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x442E780", Offset = "0x442DB80", VA = "0x18442E780")]
	public void FEPOBOIDOBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x442ED40", Offset = "0x442E140", VA = "0x18442ED40")]
	public bool GKDJFGFKOLI(float AOKHMGLMKIB, float NNCNFNLOCFK, [Out] T PFKKDHPJFEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x442F2B0", Offset = "0x442E6B0", VA = "0x18442F2B0")]
	public bool MNNAMHDKBBM(float AOKHMGLMKIB, float NNCNFNLOCFK, [Out] T PFKKDHPJFEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x442EF90", Offset = "0x442E390", VA = "0x18442EF90")]
	public void MAKCAPJKHFM(float AOKHMGLMKIB, float NNCNFNLOCFK, List<T> GMKBBDEHIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x442E610", Offset = "0x442DA10", VA = "0x18442E610")]
	private int EJBLIEAGCDF(int FJPOAMCDAGJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x442E640", Offset = "0x442DA40", VA = "0x18442E640")]
	private void EKBJOKKOOEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T NIKDIEHGLIK();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T OBNLFLIHJCM(T PFKKDHPJFEH, float BNBMPMKBBFO);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T CHKKIABDFEG(T MMHCOKHACHF, T DEOGINMLLDP);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T LMDIGHBKKHF(T MMHCOKHACHF, T DEOGINMLLDP);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class GMPFGIDMENM : JJCCGAPGBAL<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8AB870", Offset = "0x8AAC70", VA = "0x1808AB870", Slot = "4")]
	protected override Vector3 NIKDIEHGLIK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6D19C00", Offset = "0x6D19000", VA = "0x186D19C00", Slot = "5")]
	protected override Vector3 OBNLFLIHJCM(Vector3 PFKKDHPJFEH, float BNBMPMKBBFO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6D19B30", Offset = "0x6D18F30", VA = "0x186D19B30", Slot = "6")]
	protected override Vector3 CHKKIABDFEG(Vector3 MMHCOKHACHF, Vector3 DEOGINMLLDP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6D19B80", Offset = "0x6D18F80", VA = "0x186D19B80", Slot = "7")]
	protected override Vector3 LMDIGHBKKHF(Vector3 MMHCOKHACHF, Vector3 DEOGINMLLDP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6D19C40", Offset = "0x6D19040", VA = "0x186D19C40")]
	public GMPFGIDMENM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class ICKCNCBNHND
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2EDF520", Offset = "0x2EDE920", VA = "0x182EDF520")]
	public static BBOCCICBKPL<T1, T2> ANJEPJLHJHG<T1, T2>(T1 BANCHAHNLHP, T2 EEJEDLBOHIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2EDF5C0", Offset = "0x2EDE9C0", VA = "0x182EDF5C0")]
	public static OMPPOKOFBGJ<T1, T2, T3> ANJEPJLHJHG<T1, T2, T3>(T1 BANCHAHNLHP, T2 EEJEDLBOHIK, T3 JGLIGFGMBBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x491EA80", Offset = "0x491DE80", VA = "0x18491EA80")]
	internal static int LAMJLFBKEKO(int CGCPCPFHGED, int EJEFMDBFGOO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6098000", Offset = "0x6097400", VA = "0x186098000")]
	internal static int LAMJLFBKEKO(int CGCPCPFHGED, int EJEFMDBFGOO, int JAPJNGDCOEP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class BBOCCICBKPL<T1, T2> : IComparable<BBOCCICBKPL<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly T1 DAFOCMIBPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly T2 BICKJLEEDJG;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x521D700", Offset = "0x521CB00", VA = "0x18521D700")]
	public BBOCCICBKPL(T1 BANCHAHNLHP, T2 EEJEDLBOHIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x521CEC0", Offset = "0x521C2C0", VA = "0x18521CEC0", Slot = "4")]
	public int CompareTo(BBOCCICBKPL<T1, T2> OGKFFDCECEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x521D210", Offset = "0x521C610", VA = "0x18521D210", Slot = "0")]
	public override bool Equals(object OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x521D3C0", Offset = "0x521C7C0", VA = "0x18521D3C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x521D470", Offset = "0x521C870", VA = "0x18521D470", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class OMPPOKOFBGJ<T1, T2, T3> : IComparable<OMPPOKOFBGJ<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly T1 DAFOCMIBPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly T2 BICKJLEEDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly T3 GMDPPIHDFIO;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4A7CBC0", Offset = "0x4A7BFC0", VA = "0x184A7CBC0")]
	public OMPPOKOFBGJ(T1 BANCHAHNLHP, T2 EEJEDLBOHIK, T3 JGLIGFGMBBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4A7C3B0", Offset = "0x4A7B7B0", VA = "0x184A7C3B0", Slot = "4")]
	public int CompareTo(OMPPOKOFBGJ<T1, T2, T3> OGKFFDCECEL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4A7C620", Offset = "0x4A7BA20", VA = "0x184A7C620", Slot = "0")]
	public override bool Equals(object OGKFFDCECEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x4A7C860", Offset = "0x4A7BC60", VA = "0x184A7C860", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4A7CA10", Offset = "0x4A7BE10", VA = "0x184A7CA10", Slot = "3")]
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
	public T FDJCHKNOIDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x25B8D20", Offset = "0x25B8120", VA = "0x1825B8D20")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x25B8FF0", Offset = "0x25B83F0", VA = "0x1825B8FF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float GIBFGBCEINN
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA9B860", Offset = "0xA9AC60", VA = "0x180A9B860")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4F8A6F0", Offset = "0x4F89AF0", VA = "0x184F8A6F0")]
	public T JBPJHCGIMGH(float BNBMPMKBBFO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4F8AA60", Offset = "0x4F89E60", VA = "0x184F8AA60")]
	public T MOCAKKHBADM(float BNBMPMKBBFO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T FDICNGKMPLB(T MMHCOKHACHF, T DEOGINMLLDP, float BNBMPMKBBFO);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6D18590", Offset = "0x6D17990", VA = "0x186D18590", Slot = "4")]
	protected override float FDICNGKMPLB(float MMHCOKHACHF, float DEOGINMLLDP, float BNBMPMKBBFO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6D185D0", Offset = "0x6D179D0", VA = "0x186D185D0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x11B37A0", Offset = "0x11B2BA0", VA = "0x1811B37A0", Slot = "4")]
	protected override Vector3 FDICNGKMPLB(Vector3 MMHCOKHACHF, Vector3 DEOGINMLLDP, float BNBMPMKBBFO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6D1D630", Offset = "0x6D1CA30", VA = "0x186D1D630")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6D17AC0", Offset = "0x6D16EC0", VA = "0x186D17AC0", Slot = "4")]
	protected override Color FDICNGKMPLB(Color MMHCOKHACHF, Color DEOGINMLLDP, float BNBMPMKBBFO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6D17B80", Offset = "0x6D16F80", VA = "0x186D17B80")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class AAECGEIEPAC : JDKIILBAIKO<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6D175B0", Offset = "0x6D169B0", VA = "0x186D175B0")]
	public AAECGEIEPAC(int PCJIPONCEAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6D17540", Offset = "0x6D16940", VA = "0x186D17540", Slot = "6")]
	protected override uint AOGPACECJCM(uint KOJHIJJELLP, string PFKKDHPJFEH)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class CIDNOHBICPN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly IDisposable GHDNHBBFDEB;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	public CIDNOHBICPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct IGBDBLKMLAC<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> BNKLFLDJMFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int NIBHEAGMJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int FCOPNOMDACK;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x420D080", Offset = "0x420C480", VA = "0x18420D080")]
	private IGBDBLKMLAC(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> GOMNKMAAMMA, int BODBDHGONBK, int DCJGAMKMPOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x420CF80", Offset = "0x420C380", VA = "0x18420CF80")]
	public static IGBDBLKMLAC<T> GIIIFAJNKEL()
	{
		return default(IGBDBLKMLAC<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x420C140", Offset = "0x420B540", VA = "0x18420C140")]
	public (int, int, Task<T>) FIBBFAKKFHN(int NPNBEFCNIIF, [Optional] CancellationToken GBOOEEMCFEA, double FOPCLCJOGBF = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x420B0F0", Offset = "0x420A4F0", VA = "0x18420B0F0")]
	public void DJFEHIPBFAO(int NPNBEFCNIIF, int DCJGAMKMPOI, [In] T HCMJFDLGOJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class KFEBHPOCBIH
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6D19E70", Offset = "0x6D19270", VA = "0x186D19E70")]
	public static IGBDBLKMLAC<FHMPKELNMGN> GIIIFAJNKEL()
	{
		return default(IGBDBLKMLAC<FHMPKELNMGN>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6D19DF0", Offset = "0x6D191F0", VA = "0x186D19DF0")]
	public static void DJFEHIPBFAO([In] this IGBDBLKMLAC<FHMPKELNMGN> EAFEIEDNLNL, int NPNBEFCNIIF, int DCJGAMKMPOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public class FFECCPKHIFD<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly Dictionary<TKey, TVal> AECHBAJNDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<TVal, TKey> FKCAJLIMBJN;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int AHBPDFJLDEL
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x38CC630", Offset = "0x38CBA30", VA = "0x1838CC630", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool FGFOPPEDKMD
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public ICollection<TKey> NKLGCGCAEDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3F384B0", Offset = "0x3F378B0", VA = "0x183F384B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public ICollection<TVal> KLONAGGGDLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3F38500", Offset = "0x3F37900", VA = "0x183F38500", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public TVal LGNCPMFFKIH
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3F383F0", Offset = "0x3F377F0", VA = "0x183F383F0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x3F38550", Offset = "0x3F37950", VA = "0x183F38550", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public TKey LGNCPMFFKIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x3F38050", Offset = "0x3F37450", VA = "0x183F38050")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3F37910", Offset = "0x3F36D10", VA = "0x183F37910", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3F38220", Offset = "0x3F37620", VA = "0x183F38220", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3F376B0", Offset = "0x3F36AB0", VA = "0x183F376B0", Slot = "9")]
	public void Add(TKey PBFBBOFLBNL, TVal PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3F37660", Offset = "0x3F36A60", VA = "0x183F37660", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> DHLKAMHBBEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3F379B0", Offset = "0x3F36DB0", VA = "0x183F379B0", Slot = "8")]
	public bool ContainsKey(TKey PBFBBOFLBNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3F37A40", Offset = "0x3F36E40", VA = "0x183F37A40", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> DHLKAMHBBEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3F38110", Offset = "0x3F37510", VA = "0x183F38110", Slot = "10")]
	public bool Remove(TKey PBFBBOFLBNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3F38150", Offset = "0x3F37550", VA = "0x183F38150", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> DHLKAMHBBEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3F38270", Offset = "0x3F37670", VA = "0x183F38270", Slot = "11")]
	public bool TryGetValue(TKey PBFBBOFLBNL, [Out] TVal PFKKDHPJFEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3F37D30", Offset = "0x3F37130", VA = "0x183F37D30", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3F37A80", Offset = "0x3F36E80", VA = "0x183F37A80", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] EFKOIGFMOHD, int KLLAFCJKGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3F37FF0", Offset = "0x3F373F0", VA = "0x183F37FF0")]
	public bool NKKJANMEMGN(TVal PBFBBOFLBNL, [Out] TKey PFKKDHPJFEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3F37EA0", Offset = "0x3F372A0", VA = "0x183F37EA0")]
	private void KCNLBJFFPBF(TKey PBFBBOFLBNL, TVal KCIHDEINMKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3F37750", Offset = "0x3F36B50", VA = "0x183F37750")]
	private void BCFANCJBAFP(TKey PBFBBOFLBNL, TVal KCIHDEINMKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3F37C10", Offset = "0x3F37010", VA = "0x183F37C10")]
	private bool EKJOPGPGGCE(TKey PBFBBOFLBNL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3F382D0", Offset = "0x3F376D0", VA = "0x183F382D0")]
	public FFECCPKHIFD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class PDJLHLCBNLL<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private PDJLHLCBNLL<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x3C08780", Offset = "0x3C07B80", VA = "0x183C08780", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x3C1C880", Offset = "0x3C1BC80", VA = "0x183C1C880", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3C1D5C0", Offset = "0x3C1C9C0", VA = "0x183C1D5C0")]
		public Enumerator(PDJLHLCBNLL<T> GMKBBDEHIHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3C18EA0", Offset = "0x3C182A0", VA = "0x183C18EA0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3C1AC00", Offset = "0x3C1A000", VA = "0x183C1AC00", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3C18240", Offset = "0x3C17640", VA = "0x183C18240")]
		private void IGLBJOJPNAA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private T[] IPHGGCFGEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int PNGCLOMDHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private int FEMNGPHAOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private int FCPMNBOKKMJ;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int AHBPDFJLDEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x4B1EF60", Offset = "0x4B1E360", VA = "0x184B1EF60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public T LGNCPMFFKIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x4B20B90", Offset = "0x4B1FF90", VA = "0x184B20B90")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4B20100", Offset = "0x4B1F500", VA = "0x184B20100")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4B210F0", Offset = "0x4B204F0", VA = "0x184B210F0")]
	public PDJLHLCBNLL(int PCJIPONCEAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4B1FC40", Offset = "0x4B1F040", VA = "0x184B1FC40")]
	public void FNBCENOGBNB(T BNBMPMKBBFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4B1F950", Offset = "0x4B1ED50", VA = "0x184B1F950")]
	public void FEPOBOIDOBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4B202E0", Offset = "0x4B1F6E0", VA = "0x184B202E0")]
	public void HDEAJFINKJN(int GMOPHNCDIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4B1F670", Offset = "0x4B1EA70", VA = "0x184B1F670")]
	public void FDHCGLEDBPO(T[] EFKOIGFMOHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4B1F040", Offset = "0x4B1E440", VA = "0x184B1F040")]
	public Enumerator EDIPCEILGGF()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4B20E90", Offset = "0x4B20290", VA = "0x184B20E90", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4B20E90", Offset = "0x4B20290", VA = "0x184B20E90", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4B20740", Offset = "0x4B1FB40", VA = "0x184B20740")]
	private int KBMNNKNOCNK(int OBFJPFHENMC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4B20DE0", Offset = "0x4B201E0", VA = "0x184B20DE0")]
	private int OJGAFLPMPKI(int OBFJPFHENMC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class EJLCMECDGCA<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate Task<TResult> MMCNBJJJNJP(TRequest OPBNONPHAEF, CancellationToken GBOOEEMCFEA);

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public enum FLECAEFEJBE
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class HHMENNDLIIO
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private const float OIAGELJMLDN = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TimeSpan JPKFIHJILOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int AIJNPOHDDKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public FLECAEFEJBE ICOANJJGDCJ;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public static readonly HHMENNDLIIO JDAIBLFKEOP;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float APIENOENLOD
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x4151520", Offset = "0x4150920", VA = "0x184151520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan DOGOKPPHFAE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x4151600", Offset = "0x4150A00", VA = "0x184151600")]
		public HHMENNDLIIO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private readonly struct KKFNFAPFODA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly TRequest OPBNONPHAEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly CancellationToken GBOOEEMCFEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly TaskCompletionSource<TResult> PKEIDCHDBJM;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x452B2E0", Offset = "0x452A6E0", VA = "0x18452B2E0")]
		public KKFNFAPFODA(TRequest OPBNONPHAEF, TaskCompletionSource<TResult> PKEIDCHDBJM, CancellationToken GBOOEEMCFEA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct OOHKGLLEMFG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public EJLCMECDGCA<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x4A822B0", Offset = "0x4A816B0", VA = "0x184A822B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x4A82F70", Offset = "0x4A82370", VA = "0x184A82F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct EKHALFHDBFD : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public EJLCMECDGCA<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private KKFNFAPFODA <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3BA7500", Offset = "0x3BA6900", VA = "0x183BA7500", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3BA8130", Offset = "0x3BA7530", VA = "0x183BA8130", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly CancellationTokenSource IDFILBIAHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<KKFNFAPFODA> ACNBIIFNFPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly HHMENNDLIIO PGNCKNEKOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly MMCNBJJJNJP MNCLNOLOEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Task JPPNAADHOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private int DFGBMBCBIMC;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3BA1210", Offset = "0x3BA0610", VA = "0x183BA1210")]
	public EJLCMECDGCA(MMCNBJJJNJP MNCLNOLOEJA, [Optional] HHMENNDLIIO PGNCKNEKOOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3BA0AA0", Offset = "0x3B9FEA0", VA = "0x183BA0AA0")]
	public Task<TResult> LCCEPCGBGEK(TRequest OPBNONPHAEF, CancellationToken GBOOEEMCFEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3BA0450", Offset = "0x3B9F850", VA = "0x183BA0450")]
	private void ILPFONMDFIM(KKFNFAPFODA JMAMGJIJFEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3BA1070", Offset = "0x3BA0470", VA = "0x183BA1070")]
	[AsyncStateMachine(typeof(EJLCMECDGCA<, >.OOHKGLLEMFG))]
	private Task OPILPIFIOGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3B9FAD0", Offset = "0x3B9EED0", VA = "0x183B9FAD0")]
	private KKFNFAPFODA IAHOBFFHIKK()
	{
		return default(KKFNFAPFODA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3BA0EB0", Offset = "0x3BA02B0", VA = "0x183BA0EB0")]
	[AsyncStateMachine(typeof(EJLCMECDGCA<, >.EKHALFHDBFD))]
	private Task LNCEEANOOFE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3B9F7D0", Offset = "0x3B9EBD0", VA = "0x183B9F7D0")]
	private void GDNJOMNAAMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3B9F790", Offset = "0x3B9EB90", VA = "0x183B9F790", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class OAGGKJIEPBL<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly List<T> PBBPHMMFLFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private HashSet<T> PLGMOFBLCMM;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int AHBPDFJLDEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x38CC630", Offset = "0x38CBA30", VA = "0x1838CC630", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool FGFOPPEDKMD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8E46A0", Offset = "0x8E3AA0", VA = "0x1808E46A0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T LGNCPMFFKIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2DCD330", Offset = "0x2DCC730", VA = "0x182DCD330", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x4A429A0", Offset = "0x4A41DA0", VA = "0x184A429A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3F6EF70", Offset = "0x3F6E370", VA = "0x183F6EF70", Slot = "11")]
	public void Add(T DHLKAMHBBEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4A41DF0", Offset = "0x4A411F0", VA = "0x184A41DF0")]
	public bool BDOCPPPBOIK(T DHLKAMHBBEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x4A427C0", Offset = "0x4A41BC0", VA = "0x184A427C0", Slot = "15")]
	public bool Remove(T DHLKAMHBBEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x4A42140", Offset = "0x4A41540", VA = "0x184A42140", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3F8A8D0", Offset = "0x3F89CD0", VA = "0x183F8A8D0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x4A41FF0", Offset = "0x4A413F0", VA = "0x184A41FF0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x4A42090", Offset = "0x4A41490", VA = "0x184A42090", Slot = "13")]
	public bool Contains(T DHLKAMHBBEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x4A420E0", Offset = "0x4A414E0", VA = "0x184A420E0", Slot = "14")]
	public void CopyTo(T[] EFKOIGFMOHD, int KLLAFCJKGMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x457D6B0", Offset = "0x457CAB0", VA = "0x18457D6B0", Slot = "6")]
	public int IndexOf(T DHLKAMHBBEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x4A42320", Offset = "0x4A41720", VA = "0x184A42320", Slot = "7")]
	public void Insert(int OBFJPFHENMC, T DHLKAMHBBEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x4A42460", Offset = "0x4A41860", VA = "0x184A42460", Slot = "8")]
	public void RemoveAt(int OBFJPFHENMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x4A42880", Offset = "0x4A41C80", VA = "0x184A42880")]
	public OAGGKJIEPBL()
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
			[Cpp2IlInjected.Address(RVA = "0x245F6C0", Offset = "0x245EAC0", VA = "0x18245F6C0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6D1CBC0", Offset = "0x6D1BFC0", VA = "0x186D1CBC0")]
		public SerializedGuid([In] Guid MDOJFEIEAFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6D1C8E0", Offset = "0x6D1BCE0", VA = "0x186D1C8E0")]
		public static SerializedGuid DFKKFCHNGHB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6D1CAA0", Offset = "0x6D1BEA0", VA = "0x186D1CAA0")]
		public static SerializedGuid KGDIHAMFFDI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6D1CA30", Offset = "0x6D1BE30", VA = "0x186D1CA30")]
		public bool FKFNLLHBIGN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6D1CB90", Offset = "0x6D1BF90", VA = "0x186D1CB90", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6D1CB10", Offset = "0x6D1BF10", VA = "0x186D1CB10", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6D1C960", Offset = "0x6D1BD60", VA = "0x186D1C960", Slot = "7")]
		public bool Equals(SerializedGuid OGKFFDCECEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6D1C9A0", Offset = "0x6D1BDA0", VA = "0x186D1C9A0", Slot = "0")]
		public override bool Equals(object FAKGLFFOLFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6D1CA90", Offset = "0x6D1BE90", VA = "0x186D1CA90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6D1C8B0", Offset = "0x6D1BCB0", VA = "0x186D1C8B0", Slot = "6")]
		public int CompareTo(SerializedGuid OGKFFDCECEL)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class FMJEJGJHEFN : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly Type LFCKIFHDGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly string OIPOLLHKKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly bool AKDLABDLNIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly bool LHPFLMONEHF;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6D18520", Offset = "0x6D17920", VA = "0x186D18520")]
	public FMJEJGJHEFN(Type EFOAIEAOMFD, string LOGCDNHENFD, bool EMHPCOCDLIG = false, bool AFJOFBHCCDA = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class ELNHPHNENME<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public readonly struct BJLALLCPNLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly long EKIKKJJDOBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly long HGAOEHNNMIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly int LABBILCJHDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly int BLPNBMGLHOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public readonly bool FANAABPBCLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly string IPNNJGMJNOM;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x52530A0", Offset = "0x52524A0", VA = "0x1852530A0")]
		public BJLALLCPNLH(long EKIKKJJDOBD, int LABBILCJHDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5253110", Offset = "0x5252510", VA = "0x185253110")]
		public BJLALLCPNLH(long EKIKKJJDOBD, long HGAOEHNNMIL, int LABBILCJHDI, int BLPNBMGLHOJ, bool FANAABPBCLG, string IPNNJGMJNOM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5252F30", Offset = "0x5252330", VA = "0x185252F30")]
		public int FKGGKPMNNEF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5253020", Offset = "0x5252420", VA = "0x185253020")]
		public int JOMBLOEIFJH(int KPMGMAOGDDO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5253040", Offset = "0x5252440", VA = "0x185253040")]
		public double MFCMFEDOBNP()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5252F80", Offset = "0x5252380", VA = "0x185252F80")]
		public BJLALLCPNLH HGDMNJFODHC(long HGAOEHNNMIL, int BLPNBMGLHOJ)
		{
			return default(BJLALLCPNLH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class KGEBNKHIPGG : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private struct FAONDENMAOI<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public KGEBNKHIPGG <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public Func<KGEBNKHIPGG, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private KGEBNKHIPGG <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x3F17760", Offset = "0x3F16B60", VA = "0x183F17760", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x3F17C30", Offset = "0x3F17030", VA = "0x183F17C30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public readonly TKey NOMMKAICFPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly ELNHPHNENME<TKey> PJIAIBMJLCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public readonly LDGDBHIGNCI OLIMOPFMMIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private List<KGEBNKHIPGG> KMHABFEJGMG;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string IANLDIAIPHA
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x44FF080", Offset = "0x44FE480", VA = "0x1844FF080")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IEnumerable<KGEBNKHIPGG> DILMILEMKFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x44FF040", Offset = "0x44FE440", VA = "0x1844FF040")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public BJLALLCPNLH MMNADJJIIFO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x44FF0D0", Offset = "0x44FE4D0", VA = "0x1844FF0D0")]
			[CompilerGenerated]
			get
			{
				return default(BJLALLCPNLH);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x44FEC10", Offset = "0x44FE010", VA = "0x1844FEC10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x44FF0F0", Offset = "0x44FE4F0", VA = "0x1844FF0F0")]
		internal KGEBNKHIPGG(ELNHPHNENME<TKey> PJIAIBMJLCJ, TKey PBFBBOFLBNL, LDGDBHIGNCI OLIMOPFMMIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x44FEE90", Offset = "0x44FE290", VA = "0x1844FEE90")]
		public KGEBNKHIPGG JLNLGEIGFBL(TKey PBFBBOFLBNL, [Optional] LDGDBHIGNCI? GBJOMBIEPMK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x3067E90", Offset = "0x3067290", VA = "0x183067E90")]
		[AsyncStateMachine(typeof(FAONDENMAOI<>))]
		public Task<T> IMBDKFDAHEN<T>(TKey PBFBBOFLBNL, Func<KGEBNKHIPGG, Task<T>> FDHGHLDCDAN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x44FEC40", Offset = "0x44FE040", VA = "0x1844FEC40", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class ODPMPLMHGAL : IEnumerable<(TKey, List<TKey>, BJLALLCPNLH)>, IEnumerable, IEnumerator<(TKey, List<TKey>, BJLALLCPNLH)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private (TKey key, List<TKey> path, BJLALLCPNLH timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public ELNHPHNENME<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private IEnumerator<(TKey key, List<TKey> path, BJLALLCPNLH timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, BJLALLCPNLH) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x2461530", Offset = "0x2460930", VA = "0x182461530", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, BJLALLCPNLH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x4A4C490", Offset = "0x4A4B890", VA = "0x184A4C490", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x2461620", Offset = "0x2460A20", VA = "0x182461620")]
		[DebuggerHidden]
		public ODPMPLMHGAL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3D87970", Offset = "0x3D86D70", VA = "0x183D87970", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4A4BFD0", Offset = "0x4A4B3D0", VA = "0x184A4BFD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4A4BF80", Offset = "0x4A4B380", VA = "0x184A4BF80")]
		private void KAONCANHJBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4A4C440", Offset = "0x4A4B840", VA = "0x184A4C440", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x4A4C370", Offset = "0x4A4B770", VA = "0x184A4C370", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, BJLALLCPNLH)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3EE0D70", Offset = "0x3EE0170", VA = "0x183EE0D70", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class DJAKBOEEKGI : IEnumerable<(TKey, List<TKey>, BJLALLCPNLH)>, IEnumerable, IEnumerator<(TKey, List<TKey>, BJLALLCPNLH)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private (TKey key, List<TKey> path, BJLALLCPNLH timerEntry) <>2__current;

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
		private KGEBNKHIPGG timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public KGEBNKHIPGG <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public ELNHPHNENME<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private IEnumerator<KGEBNKHIPGG> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private IEnumerator<(TKey key, List<TKey> path, BJLALLCPNLH timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private (TKey, List<TKey>, BJLALLCPNLH) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x2461530", Offset = "0x2460930", VA = "0x182461530", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, BJLALLCPNLH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x5BF6840", Offset = "0x5BF5C40", VA = "0x185BF6840", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x2461620", Offset = "0x2460A20", VA = "0x182461620")]
		[DebuggerHidden]
		public DJAKBOEEKGI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5BF68A0", Offset = "0x5BF5CA0", VA = "0x185BF68A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5BF5EC0", Offset = "0x5BF52C0", VA = "0x185BF5EC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5BF5E60", Offset = "0x5BF5260", VA = "0x185BF5E60")]
		private void KAONCANHJBE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x5BF6690", Offset = "0x5BF5A90", VA = "0x185BF6690")]
		private void NJJPNOJLCPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5BF67F0", Offset = "0x5BF5BF0", VA = "0x185BF67F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5BF66F0", Offset = "0x5BF5AF0", VA = "0x185BF66F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, BJLALLCPNLH)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4D4B4F0", Offset = "0x4D4A8F0", VA = "0x184D4B4F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly Action<TKey, BJLALLCPNLH, LDGDBHIGNCI> DBIEMACFHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Action<TKey, BJLALLCPNLH, LDGDBHIGNCI> DAKOFOMMDGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Action<ELNHPHNENME<TKey>, LDGDBHIGNCI> NOPGCCHJONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly LDGDBHIGNCI OLIMOPFMMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly KGEBNKHIPGG NDIBPOFEFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private bool MPIODIOKEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int PMGFJNHOMHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Stopwatch JCMBABGDKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly int AGKNOHPCHAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private string ICFPHADPAJG;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public KGEBNKHIPGG AGOOJNJMPML
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x89EF20", Offset = "0x89E320", VA = "0x18089EF20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[NotNull]
	public string IANLDIAIPHA
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x89D950", Offset = "0x89CD50", VA = "0x18089D950")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3BAAF50", Offset = "0x3BAA350", VA = "0x183BAAF50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3BAB030", Offset = "0x3BAA430", VA = "0x183BAB030")]
	public ELNHPHNENME(TKey HCINGKPHNHE, LDGDBHIGNCI OLIMOPFMMIB, [Optional] int? LABBILCJHDI, [Optional][CanBeNull] Stopwatch JCMBABGDKPB, [Optional] Action<TKey, BJLALLCPNLH, LDGDBHIGNCI> DBIEMACFHBF, [Optional] Action<TKey, BJLALLCPNLH, LDGDBHIGNCI> DAKOFOMMDGP, [Optional] Action<ELNHPHNENME<TKey>, LDGDBHIGNCI> NOPGCCHJONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3BAAE80", Offset = "0x3BAA280", VA = "0x183BAAE80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3BAADE0", Offset = "0x3BAA1E0", VA = "0x183BAADE0")]
	[IteratorStateMachine(typeof(ELNHPHNENME<>.ODPMPLMHGAL))]
	public IEnumerable<(TKey, List<TKey>, BJLALLCPNLH)> DACKBEAMDGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3BAAD00", Offset = "0x3BAA100", VA = "0x183BAAD00")]
	[IteratorStateMachine(typeof(ELNHPHNENME<>.DJAKBOEEKGI))]
	private IEnumerable<(TKey, List<TKey>, BJLALLCPNLH)> DACKBEAMDGG(List<TKey> GEAOIIINCOC, KGEBNKHIPGG DOOGIEDKCMA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3BAAFB0", Offset = "0x3BAA3B0", VA = "0x183BAAFB0")]
	private (long, int) OLGDLPBDNHG()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public abstract class IBEIJLPGBHK<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut MOAMMBGPFOM(ELNHPHNENME<TKey> PJIAIBMJLCJ);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	protected IBEIJLPGBHK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public abstract class KJALGCNJPEG<TKey> : IBEIJLPGBHK<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate string IENOGLPPJGK(TKey PBFBBOFLBNL);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x4524000", Offset = "0x4523400", VA = "0x184524000")]
	private static string LEFPPJKEEGA(TKey PBFBBOFLBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x4524190", Offset = "0x4523590", VA = "0x184524190", Slot = "4")]
	public override string MOAMMBGPFOM(ELNHPHNENME<TKey> PJIAIBMJLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x4524040", Offset = "0x4523440", VA = "0x184524040")]
	public string MOAMMBGPFOM(ELNHPHNENME<TKey> PJIAIBMJLCJ, [NotNull] IENOGLPPJGK OHFOIKGFGAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string IDOIENJDLJD(ELNHPHNENME<TKey> PJIAIBMJLCJ, [NotNull] IENOGLPPJGK OHFOIKGFGAI);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3F5A1D0", Offset = "0x3F595D0", VA = "0x183F5A1D0")]
	protected KJALGCNJPEG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class MICIMLDCJDA<TKey> : IBEIJLPGBHK<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate string LNGIPIEFMBD(TKey PBFBBOFLBNL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly string NBMMKFAPFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly double EEGEJOLANFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly bool DFIHFMELJAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly int JFOAFHGKJOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly ISet<string> JOPNADFJMKG;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x48CC1D0", Offset = "0x48CB5D0", VA = "0x1848CC1D0")]
	private static string LEFPPJKEEGA(TKey PBFBBOFLBNL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x48CCBA0", Offset = "0x48CBFA0", VA = "0x1848CCBA0")]
	public MICIMLDCJDA(string NBMMKFAPFGN = "F2", double EEGEJOLANFJ = double.MaxValue, bool DFIHFMELJAI = false, int JFOAFHGKJOO = int.MaxValue, [Optional] ISet<string> JOPNADFJMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x48CCAC0", Offset = "0x48CBEC0", VA = "0x1848CCAC0", Slot = "4")]
	public override Dictionary<string, string> MOAMMBGPFOM(ELNHPHNENME<TKey> PJIAIBMJLCJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x48CC100", Offset = "0x48CB500", VA = "0x1848CC100")]
	private bool BLIAJNMPHMI(string MDBFLBKPPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x48CC480", Offset = "0x48CB880", VA = "0x1848CC480")]
	public Dictionary<string, string> MOAMMBGPFOM(ELNHPHNENME<TKey> PJIAIBMJLCJ, LNGIPIEFMBD OHFOIKGFGAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x48CC210", Offset = "0x48CB610", VA = "0x1848CC210")]
	private string LNHEDOCACLC(StringBuilder KCNCNLLHIBC, List<TKey> DMPOIFKELLI, LNGIPIEFMBD OHFOIKGFGAI, bool EEOOAPIAGDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x48CBFA0", Offset = "0x48CB3A0", VA = "0x1848CBFA0")]
	private static void BHBEHKCIIKC(StringBuilder OCKCPEIPGFC, string NEPGGANEKNE, bool OLKCCAFPEAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class OOOPAKLPKMC<TKey> : KJALGCNJPEG<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct ENBHEEJMOGJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public IENOGLPPJGK keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static OOOPAKLPKMC<TKey> GHDNHBBFDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly string[] LLIKBMCGLOC;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x4A86370", Offset = "0x4A85770", VA = "0x184A86370")]
	private OOOPAKLPKMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4A85420", Offset = "0x4A84820", VA = "0x184A85420", Slot = "5")]
	protected override string IDOIENJDLJD(ELNHPHNENME<TKey> PJIAIBMJLCJ, IENOGLPPJGK OHFOIKGFGAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4A85320", Offset = "0x4A84720", VA = "0x184A85320")]
	[CompilerGenerated]
	internal static string HDCDNDIHOHC(string FFGLJFMNMPK, TKey PBFBBOFLBNL, ENBHEEJMOGJ P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class OBLHNNPCJPN : ELNHPHNENME<string>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class ADJDNIOGGDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Action<OBLHNNPCJPN, LDGDBHIGNCI> callback;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public ADJDNIOGGDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6D17600", Offset = "0x6D16A00", VA = "0x186D17600")]
		internal void HGFPNHBPPAP(ELNHPHNENME<string> timer, LDGDBHIGNCI log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6D1B350", Offset = "0x6D1A750", VA = "0x186D1B350")]
	public OBLHNNPCJPN(LDGDBHIGNCI OLIMOPFMMIB, [Optional] string DIDABPPNDBC, [Optional] int? LABBILCJHDI, [Optional] Stopwatch JCMBABGDKPB, [Optional] Action<string, BJLALLCPNLH, LDGDBHIGNCI> DBIEMACFHBF, [Optional] Action<string, BJLALLCPNLH, LDGDBHIGNCI> DAKOFOMMDGP, [Optional] Action<OBLHNNPCJPN, LDGDBHIGNCI> NOPGCCHJONA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6D1B290", Offset = "0x6D1A690", VA = "0x186D1B290")]
	private static Action<ELNHPHNENME<string>, LDGDBHIGNCI> HKOFOBDNNAH(Action<OBLHNNPCJPN, LDGDBHIGNCI> NEDFJOJDIHF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public abstract class NJNEKFNIHLI
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private class JMBCFHIMPCG : NJNEKFNIHLI
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static NJNEKFNIHLI GHDNHBBFDEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x6D19CA0", Offset = "0x6D190A0", VA = "0x186D19CA0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override float HLDKDGHPMHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0xCD1C20", Offset = "0xCD1020", VA = "0x180CD1C20", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6D19DA0", Offset = "0x6D191A0", VA = "0x186D19DA0")]
		public JMBCFHIMPCG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static NJNEKFNIHLI APIHNGIGJMC;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static NJNEKFNIHLI JDAIBLFKEOP
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6D1B0A0", Offset = "0x6D1A4A0", VA = "0x186D1B0A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public abstract float HLDKDGHPMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
	protected NJNEKFNIHLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface HGIIABNNGMK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool DCPGEINIIPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface OELCFEONCJD<T> : HGIIABNNGMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	[NotNull]
	Task<T> HOOFOAIBFBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	[NotNull]
	ELLFHPNCMJG<T> CBFJOMGGDCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class KHBPIEBOLKA
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2F68A60", Offset = "0x2F67E60", VA = "0x182F68A60")]
	public static OELCFEONCJD<TResource> GBOLPNILEIH<TResource, TId>(this OFMNOCCLPOF<TId, TResource> CLENOLHAPKH, TId HDCHKIOFILD, [Optional] Func<TId, CancellationToken, Task<TResource>>? GKOBKPLADJP) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class IFPEODAILDH
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private sealed class MGIMHEOGCIO<T> : OGNFHNOKBJP<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override Task<T?> HOOFOAIBFBL
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override ELLFHPNCMJG<T?> CBFJOMGGDCK
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x89EF40", Offset = "0x89E340", VA = "0x18089EF40", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x48C4C20", Offset = "0x48C4020", VA = "0x1848C4C20")]
		public MGIMHEOGCIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "10")]
		protected override void HMFLMFDPDJB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private sealed class OKGHIFJDNEK<T> : OGNFHNOKBJP<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly T DJFAKDNIJMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly Action<T>? FCOCKNNGONO;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override Task<T> HOOFOAIBFBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x8A1340", Offset = "0x8A0740", VA = "0x1808A1340", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override ELLFHPNCMJG<T> CBFJOMGGDCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x8A0F80", Offset = "0x8A0380", VA = "0x1808A0F80", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x4A6DC80", Offset = "0x4A6D080", VA = "0x184A6DC80")]
		public OKGHIFJDNEK(T NPHDACFOFLD, Action<T>? EIGMGLNDPGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x4A6DBD0", Offset = "0x4A6CFD0", VA = "0x184A6DBD0", Slot = "10")]
		protected override void HMFLMFDPDJB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private sealed class MEMKMEMEPFK<T> : OGNFHNOKBJP<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override Task<T> HOOFOAIBFBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override ELLFHPNCMJG<T> CBFJOMGGDCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x89EF40", Offset = "0x89E340", VA = "0x18089EF40", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x485A080", Offset = "0x4859480", VA = "0x18485A080")]
		public MEMKMEMEPFK(Exception DACOLACFJMH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "10")]
		protected override void HMFLMFDPDJB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private sealed class CCFMGCEMNHM<T> : OGNFHNOKBJP<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct PNLMPHPDAPA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public Task<OELCFEONCJD<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private TaskAwaiter<OELCFEONCJD<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x4B4ABA0", Offset = "0x4B49FA0", VA = "0x184B4ABA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x4B4B580", Offset = "0x4B4A980", VA = "0x184B4B580", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private struct NINOEEEIAOJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public Task<OELCFEONCJD<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private TaskAwaiter<OELCFEONCJD<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x494D020", Offset = "0x494C420", VA = "0x18494D020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x494D250", Offset = "0x494C650", VA = "0x18494D250", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly Task<OELCFEONCJD<T>> ENHFBAAIHMM;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override Task<T> HOOFOAIBFBL
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x89EF40", Offset = "0x89E340", VA = "0x18089EF40", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override ELLFHPNCMJG<T> CBFJOMGGDCK
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x89EF10", Offset = "0x89E310", VA = "0x18089EF10", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x5536B80", Offset = "0x5535F80", VA = "0x185536B80")]
		public CCFMGCEMNHM(Task<OELCFEONCJD<T>> FFKGFPJNCFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x5536650", Offset = "0x5535A50", VA = "0x185536650", Slot = "10")]
		protected override void HMFLMFDPDJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x55366E0", Offset = "0x5535AE0", VA = "0x1855366E0")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(CCFMGCEMNHM<>.PNLMPHPDAPA))]
		internal static Task<T> PHFPDOBHMAO(Task<OELCFEONCJD<T>> FFKGFPJNCFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x5536AA0", Offset = "0x5535EA0", VA = "0x185536AA0")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(CCFMGCEMNHM<>.NINOEEEIAOJ))]
		internal static Task PMHOFJGHFFD(Task<OELCFEONCJD<T>> FFKGFPJNCFN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class CEBEABAOOMC<TIn, TOut> : OGNFHNOKBJP<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct PEMJFKPDADM : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x4B2B730", Offset = "0x4B2AB30", VA = "0x184B2B730", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x40836E0", Offset = "0x4082AE0", VA = "0x1840836E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly OELCFEONCJD<TIn> DICGENOHDLA;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<TOut> HOOFOAIBFBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x89EF40", Offset = "0x89E340", VA = "0x18089EF40", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override ELLFHPNCMJG<TOut> CBFJOMGGDCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x89EF10", Offset = "0x89E310", VA = "0x18089EF10", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x554C450", Offset = "0x554B850", VA = "0x18554C450")]
		public CEBEABAOOMC(OELCFEONCJD<TIn> JOFLGEOPJLA, Func<TIn, TOut> NDOIHMGJLGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x554C3B0", Offset = "0x554B7B0", VA = "0x18554C3B0", Slot = "10")]
		protected override void HMFLMFDPDJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x554C230", Offset = "0x554B630", VA = "0x18554C230")]
		[AsyncStateMachine(typeof(CEBEABAOOMC<, >.PEMJFKPDADM))]
		[CompilerGenerated]
		internal static Task<TOut> GINHBBIHEPJ(Task<TIn> HNIOFLMMNEL, Func<TIn, TOut> NDOIHMGJLGE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2EE2940", Offset = "0x2EE1D40", VA = "0x182EE2940")]
	public static OELCFEONCJD<T> HABKGKOFNKB<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x2EE2890", Offset = "0x2EE1C90", VA = "0x182EE2890")]
	public static OELCFEONCJD<T> GCBMKCCAGIF<T>(T HCMJFDLGOJF, [Optional] Action<T>? EIGMGLNDPGO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2C470C0", Offset = "0x2C464C0", VA = "0x182C470C0")]
	public static OELCFEONCJD<T> LENHPLDJFEI<T>(Exception DACOLACFJMH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x2C470C0", Offset = "0x2C464C0", VA = "0x182C470C0")]
	public static OELCFEONCJD<T> NOCEHBNLMLM<T>(Task<OELCFEONCJD<T>> FFKGFPJNCFN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2CDE720", Offset = "0x2CDDB20", VA = "0x182CDE720")]
	public static OELCFEONCJD<TOut> IMDABJDPEJO<TOut, TIn>(OELCFEONCJD<TIn> DOBBMOLDHPN, Func<TIn, TOut> NDOIHMGJLGE) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public abstract class OGNFHNOKBJP<T> : OELCFEONCJD<T>, HGIIABNNGMK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly string BLEFCADAGDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly HLACFEIODAE NNKDGBPCLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private bool MPIODIOKEMH;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool DCPGEINIIPA
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xEA3F30", Offset = "0xEA3330", VA = "0x180EA3F30", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public abstract Task<T> HOOFOAIBFBL
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public abstract ELLFHPNCMJG<T> CBFJOMGGDCK
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x4A55D80", Offset = "0x4A55180", VA = "0x184A55D80")]
	public OGNFHNOKBJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x4A55A40", Offset = "0x4A54E40", VA = "0x184A55A40", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void HMFLMFDPDJB();
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public abstract class AJLKNCPNHGO<TTask, T> : OGNFHNOKBJP<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class AIHLDHMFBCI
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
			public AIHLDHMFBCI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x38BA430", Offset = "0x38B9830", VA = "0x1838BA430", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x38BA6F0", Offset = "0x38B9AF0", VA = "0x1838BA6F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public AJLKNCPNHGO<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public AIHLDHMFBCI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x40FC420", Offset = "0x40FB820", VA = "0x1840FC420")]
		[AsyncStateMachine(typeof(AJLKNCPNHGO<, >.AIHLDHMFBCI.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> ADPHPNFANDJ(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly Task<T> FFKGFPJNCFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	protected readonly CancellationTokenSource JGOKKKADFHH;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public override Task<T> HOOFOAIBFBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public override ELLFHPNCMJG<T> CBFJOMGGDCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x89EF40", Offset = "0x89E340", VA = "0x18089EF40", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x40FDDA0", Offset = "0x40FD1A0", VA = "0x1840FDDA0")]
	protected AJLKNCPNHGO(TTask FFKGFPJNCFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x40FDB50", Offset = "0x40FCF50", VA = "0x1840FDB50", Slot = "10")]
	protected override void HMFLMFDPDJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T IOBIGFFEGDF(TTask NOEMICFDOIB);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void CNDJNKPFHMC();
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class GJFNFJKIHLM<T> : OGNFHNOKBJP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly GHHMJPGPOGF<Task<T>> LNABPLMLIEB;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public override Task<T> HOOFOAIBFBL
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x4052CF0", Offset = "0x40520F0", VA = "0x184052CF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public override ELLFHPNCMJG<T> CBFJOMGGDCK
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x89EF40", Offset = "0x89E340", VA = "0x18089EF40", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x4052D40", Offset = "0x4052140", VA = "0x184052D40")]
	public GJFNFJKIHLM(GHHMJPGPOGF<Task<T>> DCFCJKMDDOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x4052CD0", Offset = "0x40520D0", VA = "0x184052CD0", Slot = "10")]
	protected override void HMFLMFDPDJB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class ECIOKEBDIAI
{
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static readonly HashAlgorithmName BOBFOJKCPKN;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly ThreadLocal<IncrementalHash> JDNNGEBNMMN;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6D18260", Offset = "0x6D17660", VA = "0x186D18260")]
	public static int MEAJLEAFKKH(this OBEHHICAKLG FMLGIKFGGGL, IncrementalHash KOJHIJJELLP, byte[] EKHACCFNOKC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6D17ED0", Offset = "0x6D172D0", VA = "0x186D17ED0")]
	public static bool FIKBFGPHCGK([CanBeNull] this OBEHHICAKLG FMLGIKFGGGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6D17BC0", Offset = "0x6D16FC0", VA = "0x186D17BC0")]
	public static bool FIKBFGPHCGK([CanBeNull] this OBEHHICAKLG FMLGIKFGGGL, [Out] string IBDGAGPHJHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6D17F30", Offset = "0x6D17330", VA = "0x186D17F30")]
	public static bool FIKBFGPHCGK([CanBeNull] this OBEHHICAKLG FMLGIKFGGGL, IncrementalHash KOJHIJJELLP, byte[] EKHACCFNOKC, [Out] string IBDGAGPHJHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6D182E0", Offset = "0x6D176E0", VA = "0x186D182E0")]
	private static bool PBCAECEDGDJ(byte[] INJBMAPMNOH, Span<byte> CDHMEELBMDJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class BLANPPMLGMI
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6D17690", Offset = "0x6D16A90", VA = "0x186D17690")]
	public static int BACLGOLMIKD(HashAlgorithmName ECAHBACFIAO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6D177E0", Offset = "0x6D16BE0", VA = "0x186D177E0")]
	public static int MEAJLEAFKKH(this MCFPOFLGEIF AHHAAFOHIOH, byte[] PBCEHIPPAKE, IncrementalHash KOJHIJJELLP, byte[] MJELGBDLLGF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface MCFPOFLGEIF
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash KOJHIJJELLP);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface OBEHHICAKLG : MCFPOFLGEIF
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	[CanBeNull]
	byte[] NACLONINPBF
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	[CanBeNull]
	byte[] ODGDAOCINOL
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class MKMJFKJCOHN
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static bool EBDDICGDMOE;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly ArrayPool<byte> KDPBDGHHNDH;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly ArrayPool<char> OGNPNDIBAFL;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly Encoding EMPMKPPDCIK;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly ThreadLocal<Encoder> AGCECBHGMCP;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x2FC51A0", Offset = "0x2FC45A0", VA = "0x182FC51A0")]
	public static void LJEBILGFAAD<T>(this IncrementalHash IJMKEAEEAIO, [CanBeNull] T COMALCPHDMG) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2FC4BF0", Offset = "0x2FC3FF0", VA = "0x182FC4BF0")]
	public static void CAOAHBGLKOL<T>(this IncrementalHash IJMKEAEEAIO, [CanBeNull] T AHHAAFOHIOH) where T : MCFPOFLGEIF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x2FC4C80", Offset = "0x2FC4080", VA = "0x182FC4C80")]
	public static void CFOCFOCPIEN<T>(this IncrementalHash IJMKEAEEAIO, [CanBeNull] IList<T> CLMPNGHNKJF) where T : MCFPOFLGEIF
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6D1A9D0", Offset = "0x6D19DD0", VA = "0x186D1A9D0")]
	private static bool MFFJCHPHJID([CanBeNull] MCFPOFLGEIF AHHAAFOHIOH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6D1A280", Offset = "0x6D19680", VA = "0x186D1A280")]
	public static void KFNOBIIBOKG(this IncrementalHash KOJHIJJELLP, string? BMLJMMCGBKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6D1AA60", Offset = "0x6D19E60", VA = "0x186D1AA60")]
	public static void MPGGNNJJJML(this IncrementalHash KOJHIJJELLP, long HFEONHFGMKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6D1A690", Offset = "0x6D19A90", VA = "0x186D1A690")]
	public static void LHMIIIBAHEH(this IncrementalHash KOJHIJJELLP, int JDGANJEDFAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6D1AC30", Offset = "0x6D1A030", VA = "0x186D1AC30")]
	public static void OJENAFAPNJB(this IncrementalHash KOJHIJJELLP, short JKOKIHDAJMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6D1A110", Offset = "0x6D19510", VA = "0x186D1A110")]
	public static void HOMCCHMONFH(this IncrementalHash KOJHIJJELLP, byte LAHMHNPCNOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6D1A860", Offset = "0x6D19C60", VA = "0x186D1A860")]
	public static void MEPIHKIPBGP(this IncrementalHash KOJHIJJELLP, bool EBOJNPHJLLN, bool GNGFAFALCPH = false, bool BNFEIJKLCNG = false, bool BPGMKOKPCCG = false, bool OGMBFGANOBC = false, bool AAFPPOFAOKE = false, bool OPNAEMOKFMK = false, bool LGEHFCOBAKI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x2FC5260", Offset = "0x2FC4660", VA = "0x182FC5260")]
	public static void ONHOHBOOEOC<T>(this IncrementalHash KOJHIJJELLP, T LFKMIMEIEKO) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6D19EC0", Offset = "0x6D192C0", VA = "0x186D19EC0")]
	public static void EKFKHIFPCFC(this IncrementalHash KOJHIJJELLP, float HAHJPLOMJNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6D1A220", Offset = "0x6D19620", VA = "0x186D1A220")]
	public static void JBLKKFLNCHN(this IncrementalHash KOJHIJJELLP, ulong MGDGPGDOPMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6D1A050", Offset = "0x6D19450", VA = "0x186D1A050")]
	public static void FBPPONFAHJG(this IncrementalHash KOJHIJJELLP, uint DLGGDKDEHNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6D1A0B0", Offset = "0x6D194B0", VA = "0x186D1A0B0")]
	public static void HAHAAEJHGON(this IncrementalHash KOJHIJJELLP, ushort CBNJFFPMOEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6D19F20", Offset = "0x6D19320", VA = "0x186D19F20")]
	public static void ENDOCHEDOLE(this IncrementalHash KOJHIJJELLP, Vector3 JFMEGEOHJGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class EOHLIGDOKFH : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6D184C0", Offset = "0x6D178C0", VA = "0x186D184C0")]
	public EOHLIGDOKFH(string NFKMLKNHFEM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public abstract class OCGDJBNOAFG<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	internal class COGFOLHBHPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public TNode EAFEIEDNLNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public TNode EGIKLIBGODG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public APAJGBLKMEA NNHLGBCKJOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public List<APAJGBLKMEA> ICCEHKEJNAF;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public COGFOLHBHPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal struct APAJGBLKMEA : IComparable<APAJGBLKMEA>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public int IABPFIADDDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public TClaimant PAHOMJFEHGJ;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x10D9F40", Offset = "0x10D9340", VA = "0x1810D9F40")]
		public APAJGBLKMEA(int IABPFIADDDK, TClaimant PAHOMJFEHGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x421B2A0", Offset = "0x421A6A0", VA = "0x18421B2A0")]
		public bool IGKMFOOBBJE([In] APAJGBLKMEA OGKFFDCECEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x421B300", Offset = "0x421A700", VA = "0x18421B300")]
		public bool LKINFAKEMAM([In] APAJGBLKMEA OGKFFDCECEL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x421B290", Offset = "0x421A690", VA = "0x18421B290", Slot = "4")]
		public int CompareTo(APAJGBLKMEA OGKFFDCECEL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x421B310", Offset = "0x421A710", VA = "0x18421B310", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public enum OMMOKANHFPF
	{
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class LCCPMDIJKND : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public OCGDJBNOAFG<TClaimant, TNode> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8F0370", Offset = "0x8EF770", VA = "0x1808F0370")]
		[DebuggerHidden]
		public LCCPMDIJKND(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x45E0050", Offset = "0x45DF450", VA = "0x1845E0050", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x45E0230", Offset = "0x45DF630", VA = "0x1845E0230", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x45E0130", Offset = "0x45DF530", VA = "0x1845E0130", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3ED9A00", Offset = "0x3ED8E00", VA = "0x183ED9A00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly PAPCKMNGDME<COGFOLHBHPK> LOLPMAKLKGH;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly PAPCKMNGDME<List<APAJGBLKMEA>> DELBDALOMIO;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static int AKJJGOBCJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	internal readonly Dictionary<TClaimant, TNode> MNLGJGLMEGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	internal readonly Dictionary<TNode, COGFOLHBHPK> JFMKIHOENEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private OMMOKANHFPF CFINOJHBLLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool AAFPLDAFGFB;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode BLDMDJAKFFL(TNode NAALEPHLNNP);

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void BIGNOJJLOHI(TNode NAALEPHLNNP, TClaimant BAGFDJBPEKO, TClaimant NDAEGEOIONL);

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x4A47A50", Offset = "0x4A46E50", VA = "0x184A47A50")]
	public OCGDJBNOAFG(OMMOKANHFPF CFINOJHBLLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x4A46690", Offset = "0x4A45A90", VA = "0x184A46690")]
	public void FFGDPEDJPAA(TNode NAALEPHLNNP, TNode AFFIPMDDGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x4A473B0", Offset = "0x4A467B0", VA = "0x184A473B0")]
	public void PFHIHBJBCNL(TClaimant PAHOMJFEHGJ, TNode FJDDIMBJCPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x4A46480", Offset = "0x4A45880", VA = "0x184A46480", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x4A46910", Offset = "0x4A45D10", VA = "0x184A46910")]
	private void FIABEBPGHGB(TClaimant PAHOMJFEHGJ, TNode ADCEGHHBKJK, TNode FJDDIMBJCPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x4A46ED0", Offset = "0x4A462D0", VA = "0x184A46ED0")]
	private int HIDAEODMKEC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x4A47530", Offset = "0x4A46930", VA = "0x184A47530")]
	private void POKLCPCNBHI(TClaimant PAHOMJFEHGJ, TNode CGCMBDLANIO, TNode NKAJLLDOPAH, int MEOLNHPHCLG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x4A46840", Offset = "0x4A45C40", VA = "0x184A46840")]
	private void FHDJOLDIGCP(APAJGBLKMEA IPBEKODIJLG, COGFOLHBHPK MKPJNGJDPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x4A45F60", Offset = "0x4A45360", VA = "0x184A45F60")]
	private void ACGDCADHDOK(TClaimant PAHOMJFEHGJ, TNode CGCMBDLANIO, TNode NKAJLLDOPAH, int MEOLNHPHCLG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x4A46350", Offset = "0x4A45750", VA = "0x184A46350")]
	private void CNLHDFBHFHH(APAJGBLKMEA IPBEKODIJLG, TNode NAALEPHLNNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x4A47090", Offset = "0x4A46490", VA = "0x184A47090")]
	private void JINPJOHPBOP(APAJGBLKMEA IPBEKODIJLG, COGFOLHBHPK MKPJNGJDPAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x4A46F40", Offset = "0x4A46340", VA = "0x184A46F40")]
	private void HIGKIOOLPOE(COGFOLHBHPK MKPJNGJDPAL, bool DMOHEDOIFAI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x4A469E0", Offset = "0x4A45DE0", VA = "0x184A469E0")]
	private void GKDDJNDLGND(COGFOLHBHPK MKPJNGJDPAL, TNode AFFIPMDDGDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x4A46750", Offset = "0x4A45B50", VA = "0x184A46750")]
	[IteratorStateMachine(typeof(OCGDJBNOAFG<, >.LCCPMDIJKND))]
	private IEnumerable<TNode> FFMAFIDLCFM(TNode CGCMBDLANIO, TNode NKAJLLDOPAH, bool AKHIAPOFEML = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x4A46240", Offset = "0x4A45640", VA = "0x184A46240")]
	private COGFOLHBHPK BCAPCMNALNH(TNode NAALEPHLNNP, TNode EGIKLIBGODG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x4A46D50", Offset = "0x4A46150", VA = "0x184A46D50")]
	private COGFOLHBHPK GMLLCHIFOKK(TNode NAALEPHLNNP, TNode EGIKLIBGODG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x4A471F0", Offset = "0x4A465F0", VA = "0x184A471F0")]
	private void OMPLPBMILNM(COGFOLHBHPK MKPJNGJDPAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class JDKIILBAIKO<T> : IEnumerable<JDKIILBAIKO<T>.EBGKBFIMDPF>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public struct EBGKBFIMDPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public T PFKKDHPJFEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public int OBFJPFHENMC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class PCFCHPLNMPD : IEnumerator<EBGKBFIMDPF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private JDKIILBAIKO<T> CCLLBFABNDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private int OBFJPFHENMC;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x3BBCAB0", Offset = "0x3BBBEB0", VA = "0x183BBCAB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public EBGKBFIMDPF LDHKDFDFMKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x4B138E0", Offset = "0x4B12CE0", VA = "0x184B138E0", Slot = "4")]
			get
			{
				return default(EBGKBFIMDPF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x4B138A0", Offset = "0x4B12CA0", VA = "0x184B138A0")]
		public PCFCHPLNMPD(JDKIILBAIKO<T> CCLLBFABNDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x4B137A0", Offset = "0x4B12BA0", VA = "0x184B137A0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3C119D0", Offset = "0x3C10DD0", VA = "0x183C119D0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xC59770", Offset = "0xC58B70", VA = "0x180C59770", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private struct BKGCLLPBIJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public bool MKFACJHAOHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public T PFKKDHPJFEH;
	}

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private const int INDAAMKIEKP = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly Dictionary<T, int> GPDKNCLMFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private BKGCLLPBIJL[] CAPGPCODIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private int CALNOADHOFM;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public int CHIEMKCDGNL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8DB7A0", Offset = "0x8DABA0", VA = "0x1808DB7A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8DADA0", Offset = "0x8DA1A0", VA = "0x1808DADA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public int AHBPDFJLDEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x38CC630", Offset = "0x38CBA30", VA = "0x1838CC630")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x43DA770", Offset = "0x43D9B70", VA = "0x1843DA770")]
	public JDKIILBAIKO(int PCJIPONCEAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x43DAC90", Offset = "0x43DA090", VA = "0x1843DAC90")]
	public JDKIILBAIKO(EBGKBFIMDPF[] OFDDEHCMAKO, bool BAFIFONBLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x43DA2F0", Offset = "0x43D96F0", VA = "0x1843DA2F0")]
	public int EGJIFAKFLEB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x43D98C0", Offset = "0x43D8CC0", VA = "0x1843D98C0")]
	private int ABPGHGBGJLF()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x43D9D20", Offset = "0x43D9120", VA = "0x1843D9D20", Slot = "6")]
	protected virtual uint AOGPACECJCM(uint KOJHIJJELLP, T PFKKDHPJFEH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x43DA470", Offset = "0x43D9870", VA = "0x1843DA470")]
	public bool GIKCMDFINFB(T PFKKDHPJFEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x43DA5D0", Offset = "0x43D99D0", VA = "0x1843DA5D0")]
	public int PAFGPLDJMFD(T PFKKDHPJFEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x43DA3B0", Offset = "0x43D97B0", VA = "0x1843DA3B0")]
	public T FFDPDONAMEJ(int OBFJPFHENMC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x43D9D40", Offset = "0x43D9140", VA = "0x1843D9D40")]
	public bool BDOCPPPBOIK(T PFKKDHPJFEH, bool MBECLEAEEFK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x43D9DA0", Offset = "0x43D91A0", VA = "0x1843D9DA0")]
	public bool BDOCPPPBOIK(T PFKKDHPJFEH, int OBFJPFHENMC, bool MBECLEAEEFK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x43DA580", Offset = "0x43D9980", VA = "0x1843DA580")]
	private int JDDGGBFINAI(int PNGCLOMDHAJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x43DA6D0", Offset = "0x43D9AD0", VA = "0x1843DA6D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x43DA6D0", Offset = "0x43D9AD0", VA = "0x1843DA6D0", Slot = "4")]
	private IEnumerator<EBGKBFIMDPF> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class PAPCKMNGDME<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly Stack<T> MMFPHFFLLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly List<T> CGOPFKBBALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly int NBAGBEHIJFC;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x4B11D40", Offset = "0x4B11140", VA = "0x184B11D40")]
	public static PAPCKMNGDME<T> CAFFMBABECD(int PCJIPONCEAG = 0, int NBAGBEHIJFC = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x4B11E30", Offset = "0x4B11230", VA = "0x184B11E30")]
	public static PAPCKMNGDME<T> CDPODHLJIIH(int PCJIPONCEAG = 0, int NBAGBEHIJFC = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x4B12620", Offset = "0x4B11A20", VA = "0x184B12620")]
	public PAPCKMNGDME()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x4B12670", Offset = "0x4B11A70", VA = "0x184B12670")]
	public PAPCKMNGDME(int PCJIPONCEAG, int NBAGBEHIJFC = int.MaxValue, bool IJIKMCKPEBN = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x4B121F0", Offset = "0x4B115F0", VA = "0x184B121F0")]
	public T PBBCGENJODN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x4B11C60", Offset = "0x4B11060", VA = "0x184B11C60")]
	public void AFNCKMDLBLN(T PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x4B11F20", Offset = "0x4B11320", VA = "0x184B11F20")]
	private void DIJJADCKLCM(T PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x4B121B0", Offset = "0x4B115B0", VA = "0x184B121B0")]
	private void IOHMFFBLCFP(T PFKKDHPJFEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x4B12020", Offset = "0x4B11420", VA = "0x184B12020", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x4B123C0", Offset = "0x4B117C0", VA = "0x184B123C0")]
	private void PPIMBOHEFDG(IEnumerable<T> MHFHLBKJCIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class EANDBGCGGCD<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private Dictionary<int, T> GCAOPEJPLMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private T CPOCEEHPIFI;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public virtual T NGHGFNKFFHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x89EF50", Offset = "0x89E350", VA = "0x18089EF50", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x89CEC0", Offset = "0x89C2C0", VA = "0x18089CEC0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x3B65800", Offset = "0x3B64C00", VA = "0x183B65800")]
	public bool LCGHAFHBGIB(T PFKKDHPJFEH, int IABPFIADDDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x3B65760", Offset = "0x3B64B60", VA = "0x183B65760")]
	public bool CCHOEKLGFAB(int IABPFIADDDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x3B65940", Offset = "0x3B64D40", VA = "0x183B65940")]
	public T MGACAOGAFAF(int FGEBNMOPNLF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x3B655D0", Offset = "0x3B649D0", VA = "0x183B655D0")]
	private bool ABBAMLCMCJM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x3B65D80", Offset = "0x3B65180", VA = "0x183B65D80")]
	public bool NKKJANMEMGN(int IABPFIADDDK, [Out] T PFKKDHPJFEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x3B65DE0", Offset = "0x3B651E0", VA = "0x183B65DE0")]
	public EANDBGCGGCD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class OMAAFPCBNMC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	protected struct GJPBFDKAING
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public T FDJCHKNOIDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public int IHNBDKPEGGC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	protected readonly List<GJPBFDKAING> IPHGGCFGEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private T HGKPPOFAIOA;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public int AHBPDFJLDEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x38CC630", Offset = "0x38CBA30", VA = "0x1838CC630")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x4A794D0", Offset = "0x4A788D0", VA = "0x184A794D0")]
	public bool APJCMBOKLHP(T PFKKDHPJFEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x4A79B30", Offset = "0x4A78F30", VA = "0x184A79B30")]
	public void FNBCENOGBNB(T PFKKDHPJFEH, int IABPFIADDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x4A798A0", Offset = "0x4A78CA0", VA = "0x184A798A0")]
	public bool BIJNEFLCHFA(T PFKKDHPJFEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x4A79A90", Offset = "0x4A78E90", VA = "0x184A79A90")]
	public void FEPOBOIDOBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x4A7A050", Offset = "0x4A79450", VA = "0x184A7A050")]
	public T PJCMNAHNFLM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x4A79CC0", Offset = "0x4A790C0", VA = "0x184A79CC0")]
	protected void HBJGGIIENDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x4A7A0F0", Offset = "0x4A794F0", VA = "0x184A7A0F0")]
	public OMAAFPCBNMC()
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
		[PCIEPDMGHOH(AHBKOCJDDCB.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x6D1B5E0", Offset = "0x6D1A9E0", VA = "0x186D1B5E0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x6D1B8B0", Offset = "0x6D1ACB0", VA = "0x186D1B8B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x6D1B7C0", Offset = "0x6D1ABC0", VA = "0x186D1B7C0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x6D1B530", Offset = "0x6D1A930", VA = "0x186D1B530")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x6D1B800", Offset = "0x6D1AC00", VA = "0x186D1B800")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x6D1B710", Offset = "0x6D1AB10", VA = "0x186D1B710")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x6D1B4A0", Offset = "0x6D1A8A0", VA = "0x186D1B4A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4CFA860", Offset = "0x4CF9C60", VA = "0x184CFA860", Slot = "4")]
		public virtual T LPJLCOGEBPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class GCHLCIGOFLN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private Dictionary<byte, GJAPGLBCFAL> LAFOFKMEIFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private readonly PAPCKMNGDME<GJAPGLBCFAL> AAFFNGAMPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly bool MCOLOBJFHNL;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public GJAPGLBCFAL MEEGPMDKCEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x89A1C0", Offset = "0x8995C0", VA = "0x18089A1C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x89A1B0", Offset = "0x8995B0", VA = "0x18089A1B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Vector2 CIIOFCLKJOD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x10757C0", Offset = "0x1074BC0", VA = "0x1810757C0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x13800E0", Offset = "0x137F4E0", VA = "0x1813800E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	private Vector2 EHAFPPJEOBK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x9F1D90", Offset = "0x9F1190", VA = "0x1809F1D90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Vector2 PNLCGMMHAEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6D18610", Offset = "0x6D17A10", VA = "0x186D18610")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8A1F30", Offset = "0x8A1330", VA = "0x1808A1F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int FCJAIMANDAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8A1360", Offset = "0x8A0760", VA = "0x1808A1360")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8A0F70", Offset = "0x8A0370", VA = "0x1808A0F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6D195C0", Offset = "0x6D189C0", VA = "0x186D195C0")]
	public GCHLCIGOFLN(Bounds BEGLNFINOHF, Vector2[] GADJGCEGPPP, int DPMDPGIGGPG, byte PNGCLOMDHAJ, float MKLPNJPEJIA = 0f, [Optional] PAPCKMNGDME<GJAPGLBCFAL> AAFFNGAMPAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6D18B40", Offset = "0x6D17F40", VA = "0x186D18B40")]
	public void IDCDMCDCPEI(Bounds BEGLNFINOHF, Vector2[] GADJGCEGPPP, int DPMDPGIGGPG, byte PNGCLOMDHAJ, float MKLPNJPEJIA = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6D19560", Offset = "0x6D18960", VA = "0x186D19560")]
	public GJAPGLBCFAL PGOHFLKIBGD(byte OBFJPFHENMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6D18FF0", Offset = "0x6D183F0", VA = "0x186D18FF0")]
	public void LLMGIGGFOEC(Vector3 OGKCMCMHLOD, float OKCNLNAFCPN, float FEPMJKJBOJI, List<byte> OLICKPHFPGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6D18FD0", Offset = "0x6D183D0", VA = "0x186D18FD0")]
	public void LHNJMKGGOFI(GJAPGLBCFAL.FANLLHIJFPJ PEHGNGOODMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6D190C0", Offset = "0x6D184C0", VA = "0x186D190C0")]
	public static int OFIEDJFKJKJ(Vector2[] GADJGCEGPPP, int DPMDPGIGGPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6D18690", Offset = "0x6D17A90", VA = "0x186D18690")]
	private GJAPGLBCFAL EDOIJHIDCIO(byte OBFJPFHENMC, GJAPGLBCFAL.JABCFLPGAMN FFILNBKMJMM, GJAPGLBCFAL EGIKLIBGODG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6D191A0", Offset = "0x6D185A0", VA = "0x186D191A0")]
	private void PEJEEGDACFM(GJAPGLBCFAL EGIKLIBGODG, Vector2[] GADJGCEGPPP, int KLLPMGBFPEF, int FNIMHCIHKBH, int KJLDGAPOOOE, int GGLBMLNPFFH, float MKLPNJPEJIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6D18920", Offset = "0x6D17D20", VA = "0x186D18920")]
	private void GKGAKBIEJMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6D18630", Offset = "0x6D17A30", VA = "0x186D18630", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6D188C0", Offset = "0x6D17CC0", VA = "0x186D188C0", Slot = "1")]
	~GCHLCIGOFLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class GJAPGLBCFAL
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public enum JABCFLPGAMN
	{
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public enum FANLLHIJFPJ
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
	public byte GPNGJJINABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public Vector3 JDBMEDLBFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public Vector3 INPFMBGIDBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public Vector3 PAFKEPDPFIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public Vector3 PHODFMCMPDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public JABCFLPGAMN BAHAJBJKDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public GJAPGLBCFAL LHNCJNMLCDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public List<GJAPGLBCFAL> MCDGNIKJNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public bool IPLENOIIAKE;

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x6D19B10", Offset = "0x6D18F10", VA = "0x186D19B10")]
	public GJAPGLBCFAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6D196E0", Offset = "0x6D18AE0", VA = "0x186D196E0")]
	public void FFOLLCLINMK(GJAPGLBCFAL KFLLLPCKFFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x89BD30", Offset = "0x89B130", VA = "0x18089BD30")]
	public void LHNJMKGGOFI(int GGIKJKPCGDA, FANLLHIJFPJ PEHGNGOODMK, int FJLOCMJCNHD = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x6D19820", Offset = "0x6D18C20", VA = "0x186D19820")]
	public void LLMGIGGFOEC(List<byte> OLICKPHFPGA, Vector3 OGKCMCMHLOD, float OKCNLNAFCPN, float FEPMJKJBOJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x6D19680", Offset = "0x6D18A80", VA = "0x186D19680")]
	public bool AEFLJDNEKAA(Vector3 FJJNEGEALHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x6D196B0", Offset = "0x6D18AB0", VA = "0x186D196B0")]
	public bool FDEIIABKPFD(Vector3 FJJNEGEALHA, float DNKOLEMADPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6D19A80", Offset = "0x6D18E80", VA = "0x186D19A80")]
	public void NOCOEJHJFAP()
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
		public struct FBDENEBNPFJ<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private readonly List<Component> PBBPHMMFLFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private readonly bool KLKOPMFDPOO;

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x3F18840", Offset = "0x3F17C40", VA = "0x183F18840")]
			public FBDENEBNPFJ(List<Component> PBBPHMMFLFN, bool KLKOPMFDPOO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x3F18710", Offset = "0x3F17B10", VA = "0x183F18710")]
			public GPIEGMIACOB<T> EDIPCEILGGF()
			{
				return default(GPIEGMIACOB<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x3F18770", Offset = "0x3F17B70", VA = "0x183F18770", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x3F18770", Offset = "0x3F17B70", VA = "0x183F18770", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006E")]
		public struct GPIEGMIACOB<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			private readonly List<Component> PBBPHMMFLFN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			private readonly bool KLKOPMFDPOO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			private int OBFJPFHENMC;

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public T LDHKDFDFMKJ
			{
				[Cpp2IlInjected.Token(Token = "0x600021A")]
				[Cpp2IlInjected.Address(RVA = "0x4084040", Offset = "0x4083440", VA = "0x184084040", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000061")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600021B")]
				[Cpp2IlInjected.Address(RVA = "0x4083FD0", Offset = "0x40833D0", VA = "0x184083FD0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x4084010", Offset = "0x4083410", VA = "0x184084010")]
			public GPIEGMIACOB(List<Component> PBBPHMMFLFN, bool KLKOPMFDPOO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x4083F10", Offset = "0x4083310", VA = "0x184083F10", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x4083F20", Offset = "0x4083320", VA = "0x184083F20", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x3C043B0", Offset = "0x3C037B0", VA = "0x183C043B0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x6D1D2D0", Offset = "0x6D1C6D0", VA = "0x186D1D2D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6D1D0D0", Offset = "0x6D1C4D0", VA = "0x186D1D0D0")]
		private void NOCOEJHJFAP(GameObject JIOOJLGNIAD, bool DLFLBGAHCIJ = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x6D1D040", Offset = "0x6D1C440", VA = "0x186D1D040")]
		public static void NOCOEJHJFAP(GameObject JIOOJLGNIAD, ToolHierarchyCache CLENOLHAPKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6D1CC70", Offset = "0x6D1C070", VA = "0x186D1CC70")]
		public void FHADBKEGAAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x320E8C0", Offset = "0x320DCC0", VA = "0x18320E8C0")]
		public void OHLNNPINADD<T>(Action<T> LLIKOHELCCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x320E760", Offset = "0x320DB60", VA = "0x18320E760")]
		public T DOADAELLGLJ<T>(bool KLKOPMFDPOO = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x320E800", Offset = "0x320DC00", VA = "0x18320E800")]
		public FBDENEBNPFJ<T> NHKCPCLAHLP<T>(bool KLKOPMFDPOO = false) where T : class
		{
			return default(FBDENEBNPFJ<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6D1CCF0", Offset = "0x6D1C0F0", VA = "0x186D1CCF0")]
		public List<Component> KNALIIMCGMH(Type EKNPHEPNHJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x6D1CBF0", Offset = "0x6D1BFF0", VA = "0x186D1CBF0", Slot = "4")]
		public bool Equals(ToolHierarchyCache KPPEBBOFEKD, ToolHierarchyCache EJAKPDCBGAD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x6D1CC80", Offset = "0x6D1C080", VA = "0x186D1CC80", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache FAKGLFFOLFI)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class DPANLPMKOAJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int PCJIPONCEAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int GPHFICIPPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private List<T> PAJGOMPLFDK;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int AHBPDFJLDEL
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x4052CF0", Offset = "0x40520F0", VA = "0x184052CF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public T LDACBOJGIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x5C1DEC0", Offset = "0x5C1D2C0", VA = "0x185C1DEC0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public T CNEAHHFIKLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x5C1DF90", Offset = "0x5C1D390", VA = "0x185C1DF90")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public T BCJOIOKBAAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x5C1E270", Offset = "0x5C1D670", VA = "0x185C1E270")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x5C1E360", Offset = "0x5C1D760", VA = "0x185C1E360")]
	public DPANLPMKOAJ(int PCJIPONCEAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x5C1DB50", Offset = "0x5C1CF50", VA = "0x185C1DB50")]
	public void FNBCENOGBNB(T OJJHEJMGBMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x5C1DAF0", Offset = "0x5C1CEF0", VA = "0x185C1DAF0")]
	public void FEPOBOIDOBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x5C1E0F0", Offset = "0x5C1D4F0", VA = "0x185C1E0F0")]
	public void LIJBNDBFODN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x5C1E080", Offset = "0x5C1D480", VA = "0x185C1E080")]
	public void IFJEHBLKPCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x5C1E0E0", Offset = "0x5C1D4E0", VA = "0x185C1E0E0")]
	public void KFIAGJHDPIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x5C1E1E0", Offset = "0x5C1D5E0", VA = "0x185C1E1E0")]
	public List<T> MBPPKBBBACN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class ACJDPNIFKFC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private struct DIJGLBKLOHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public int IHNBDKPEGGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public T FDJCHKNOIDG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly Dictionary<object, DIJGLBKLOHD> GCAOPEJPLMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly EqualityComparer<T> HBJJGHCIIKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private T CPOCEEHPIFI;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public virtual T NGHGFNKFFHC
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x9B3F70", Offset = "0x9B3370", VA = "0x1809B3F70", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x3FC0180", Offset = "0x3FBF580", VA = "0x183FC0180", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public bool CBFBNPMJLOM
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x3FBEA50", Offset = "0x3FBDE50", VA = "0x183FBEA50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public object CFEIHMMOHLB
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x89EF20", Offset = "0x89E320", VA = "0x18089EF20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x89EF30", Offset = "0x89E330", VA = "0x18089EF30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x3FBEC70", Offset = "0x3FBE070", VA = "0x183FBEC70")]
	public bool LCGHAFHBGIB(T PFKKDHPJFEH, object CFGHNHCDKCN, int IABPFIADDDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x3FBE990", Offset = "0x3FBDD90", VA = "0x183FBE990")]
	public bool CCHOEKLGFAB(object CFGHNHCDKCN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x3FBFB20", Offset = "0x3FBEF20", VA = "0x183FBFB20")]
	public bool NKKJANMEMGN(object CFGHNHCDKCN, [Out] T PFKKDHPJFEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x3F38500", Offset = "0x3F37900", VA = "0x183F38500")]
	public void FEPOBOIDOBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x3FBCF60", Offset = "0x3FBC360", VA = "0x183FBCF60")]
	private bool ABBAMLCMCJM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x3FC01D0", Offset = "0x3FBF5D0", VA = "0x183FC01D0")]
	public ACJDPNIFKFC()
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
