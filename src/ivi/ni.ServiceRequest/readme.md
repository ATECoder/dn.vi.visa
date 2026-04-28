# NationalInstrument.Visa Service Request Example

This example demonstrates how to use the service request event and
the service request status byte to determine when generated data is ready
and how to read it.

## Tested implementations:

* IVI.Visa package 8.0.2
* NI 26.2 package 25.3.0.11
* NI 26.2 package 25.5.0.13
* Keysight 2025-11 21.2.207
  * IVI.Visa package 8.0.2: Failed
  * KeysightTechnologies.Visa 18.6.6: Failed

## Keysight Implementation Failure

The service request is invoked only once. Thereafter the instrument must be restarted to invoke a single SRQ again.

## Required Hardware

Any message-based GPIB instrument.

## Tested hardware

| Company | Instrument |
|---------|------------|
|Keithley | 2612       |
