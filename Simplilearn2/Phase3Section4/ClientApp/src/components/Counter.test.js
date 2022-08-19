import React from 'react'
import { Counter } from './Counter';
import { render } from '@testing-library/react';

test('When Counter Component is rendered, should contain Current Count:',
    () => {
        const { queryByText } = render(<Counter />);

        const counterText = queryByText('Current count:')
        expect(counterText).not.toBeNull();
});
